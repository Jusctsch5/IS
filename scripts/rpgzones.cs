//rpgzones.cs
// Last Update: 3/6/15
// Change Log:
//  * 3/6/15: Stripped out unused code, upgraded zone behavior to be per-player based

//Phantom139: Updated 3/6/15.
function Zone::DoEnter(%zoneId, %client, %delay) {
    if(%delay != 1) {
        schedule(100, 0, "zonecheck", %client, %zoneid);
    }
    else {
        %oldZone = fetchData(%client, "zone");
        %newZone = %zoneId;
        commandtoClient(%client, 'StopMusic');
        storeData(%client, "zone", %newZone);
        if(fetchdata(%client, "guardzone") == 0) {
            storedata(%client, "guardzone", %newZone);
        }
        if(Zone::OnFriendlyTerms(%zoneId, %client)) {
            %color = $MsgBeige;
        }
        else {
            %color = $MsgRed;
        }
        %msg = "You have entered " @ %zoneId.description @ ".";
        %rzs = GetRaceZoneString(%client, %zoneId);
        if(%rzs !$= "") {
            %msg = %msg @ "  " @ %rzs;
        }
        if(%msg !$= "") {
            messageClient(%client, 'ZoneDoEnter', %color @ %msg);
        }
        if(%newZone.musicType !$= "") {
            commandtoClient(%client, 'RPGPlayMusic', %newzone.MusicType);
        }
        Zone::onEnter(%client, %oldZone, %newZone);
	}
}

function zonecheck(%client, %zoneid) {
    Zone::DoEnter(%zoneid, %client, 1);
}

function Zone::DoExit(%zoneId, %client) {
    if(inArena(%client)) {
        return;
    }
	%zoneLeft = fetchData(%client, "zone");
	commandtoClient(%client, 'StopMusic');
	storeData(%client, "zone", "");
	%color = $MsgBeige;
	%msg = "You have left " @ %zoneId.description @ ".";

	messageClient(%client, 'ZoneDoExit', %color @ %msg);
	commandtoClient(%client, 'RPGPlayMusic', "Wilderness");
	Zone::onExit(%client, %zoneLeft);
    // Check for Bot Removal?
    if(Zone::getNumPlayers(%zoneID, 0) <= 0) {
       schedule(10000, 0, doBotRemoval, %zoneID);
    }
}

function Zone::OnFriendlyTerms(%zoneId, %client) {
    %clraceId = $RaceID[fetchData(%client, "RACE")];
    %zraceId = %zoneId.RaceID;
    if(%zraceId !$= %clraceId) {
        return false;
    }
    else {
        return true;
    }
}

function IsInBetween(%x, %r1, %r2) {
    if(%r1 > %r2) {
        %tmp = %r1;
        %r1 = %r2;
        %r2 = %tmp;
    }
    if(%x >= %r1 && %x <= %r2) {
        return true;
    }
    else {
        return false;
    }
}

function Zone::handleTeleport(%zoneid, %client) { }

function Zone::onEnter(%client, %oldZone, %newZone) {
	refreshHPREGEN(%client);	//this is because you regen faster or slower depending on the zone you are in
}

function Zone::onExit(%client, %zoneLeft) {
	refreshHPREGEN(%client);	//this is because you regen faster or slower depending on the zone you are in
}

function GetNearestZone(%client, %mtype, %returnType) {
	if (%mtype $= "town") {
		%type = "Protected";
		%all = 0;
	}
	else if(%mtype $= "dungeon") {
		%type = "Dungeon";
		%all = 0;
	}
	else {
		%all = 1;// if we are just searching for the closest zone
	}
	%closestDist = 999999;
	%closestZone = "";
	%mpos = "";
	%clpos = %client.player.getPosition();
	%group = nameToId("MissionGroup/Zones");
	if(%group !$= -1) {
		%count = %group.getCount();
		for(%i = 0; %i < %count; %i++) {
			%object = %group.getObject(%i);
			if(%object.type $= %type || %all) {
				%modpos = %object.position;
				%dist = vectorDist(%modpos, %clpos);
				if(%dist < %closestDist) {
					%closestDist = %dist;
					//%clpos = %modpos;
					%closestZoneDesc = %object.description;
					%closestZone = %object;
					%mpos = %modpos;
				}
			}
		}
	}
	if(%mpos $= "") {		//no zones were found (this means there are NO zones in the map...)
		return false;
    }
	
	//%returnType:
	//1 = returns the distance from the client to the nearest zone
	//2 = returns the description of the zone nearest to the client
	//3 = returns the zone id of the zone nearest to the client
	//4 = returns the position of the middle of the zone nearest to the client
	if(%returnType $= 1) {
		return %closestDist;
    }
	else if(%returnType $= 2) {
		return %closestZoneDesc;
    }
	else if(%returnType $= 3) {
		return %closestZone;
    }
	else if(%returnType $= 4) {
		return %mpos;
    }
}

function GetZoneByKeywords(%client, %keywords, %returnType) {
    %mpos = "";
    %group = nameToId("MissionGroup/Zones");
    if(%group !$= -1) {
        %count = %group.getCount();
        for(%i = 0; %i < %count; %i++) {
            %object = %group.getObject(%i);
            %desc = %object.description;
            if(strstr(%desc, %keywords) !$= -1) {
                %dist = vectorDist(%object.position, %client.player.getPosition());
                if(%returnType $= 1) {
                    return %dist;
                }
                else if(%returnType $= 2) {
                    return %desc;
                }
                else if(%returnType $= 3) {
                    return %object;
                }
                else if(%returnType $= 4) {
                    return %mpos;
                }
            }
        }
        return false;
    }
    else {
        return false;
    }
}

function Zone::getNumPlayers(%z, %all) {
    %n = 0;
    %count = ClientGroup.getCount();
    for(%icl = 0; %icl < %count; %icl++) {
        %id = ClientGroup.getObject(%icl);
        if(fetchData(%id, "zone") $= %z) {
            if(%all) {
                %n++;
            }
            else {
                if(!%id.isAiControlled()) {
                    %n++;
                }
            }
        }
    }
	return %n;
}

function ObjectInWhichZone(%object) {
	return positionInWhichZone(%object.position);
}

//Phantom139: Updated broken code.
function positionInWhichZone(%pos, %debug) {
   %group = nameToID("MissionGroup/Zones");
   if(%group == -1) {
      error("RPG: positionInWhichZones: Missing Zones Group");
   }
   else {
      //Direct Zone Calculation
      %rex = getWord(%pos, 0);
      %rey = getWord(%pos, 1);
      %rez = getWord(%pos, 2);
      for(%i = 0; %i < %group.getCount(); %i++) {
         %zID = %group.getObject(%i);
         //Position
         %px = getWord(%zID.getWorldBoxCenter(), 0);
         %py = getWord(%zID.getWorldBoxCenter(), 1);
         %pz = getWord(%zID.getWorldBoxCenter(), 2);
         //Scale
         %x = getWord(%zID.scale, 0) / 2;
         %y = getWord(%zID.scale, 1) / 2;
         %z = getWord(%zID.scale, 2) / 2;
         //position checks: x
         if(%debug) {
            echo("Testing Zone "@%zID);
            echo("Test: "@%rex@" >= ("@%px-%x@") && "@%rex@" <= ("@%px+%x@")");
         }
         if((%rex >= (%px-%x)) && (%rex <= (%px+%x))) {
            if(%debug) {
               echo("X Passes Test");
               echo("Test: "@%rey@" >= ("@%py-%y@") && "@%rey@" <= ("@%py+%y@")");
            }
            if((%rey >= (%py-%y)) && (%rey <= (%py+%y))) {
               if(%debug) {
                  echo("Y Passes Test");
                  echo("Test: "@%rez@" >= ("@%pz-%z@") && "@%rez@" <= ("@%pz+%z@")");
               }
               if((%rez >= (%pz-%z)) && (%rez <= (%pz+%z))) {
                  //We're in this zone...
                  return %zID;
               }
            }
         }
      }
      //Still Missing? Find by Radius
	  %closest = 99999;
      %zone = -1;
      for(%i = 0; %i < %group.getCount(); %i++) {
         %zoneId = %group.getObject(%i);
         %rad = (GetWord(%zoneId.scale, 0) + GetWord(%zoneId.scale, 1) + GetWord(%zoneId.scale, 2)) / 3;
         %dist = vectorDist(%pos, %zoneId.position);
         if(%dist <= %rad) {
            if(%dist < %closest) {
               %closest = %dist;
               %zid = %zoneId;
			}
         }
	  }
      return %zid;
   }
}

function Zone::getPlayerList(%zoneId, %type) {
	%aa = "";
	%count = ClientGroup.getCount();
	for(%icl = 0; %icl < %count; %icl++) {
		%id = ClientGroup.getObject(%icl);
		if(fetchData(%id, "zone") $= %zoneId) {
			%flag = false;
			if(%type $= 1)
				%flag = true;
			else if(%type $= 2) {
				if(!%id.isAiControlled())
					%flag = true;
			}
			else if(%type $= 3) {
				if(%id.isAiControlled())
					%flag = true;
			}

			if(%flag)
				%aa = %aa @ %id @ " ";
		}
	}

	return %aa;
}


function RPGGame::onEnterTrigger(%game, %triggerName, %data, %obj, %colobj) {
	%player = %colobj;
	%client = %colobj.client;
	if(%obj.type $= "teleport") {
		%player.setPosition(%obj.value);
	}
	else if (%obj.type $= "sleepzone") {
		storedata(%client, "insleepzone", true);
		messageClient(%client, 'RPGchatCallback', "This area feels safe enough to #sleep.");
	}
	else if (%obj.type $= "BoatDock") {
		if(%colobj.getdatablock().getName() $= RPGBoat) {
			%obj.full = true;
			%colobj.zone = %obj;
		}
	}
    else if (%obj.type $= "falldie") {
       %colobj.scriptKill(); //Bye :)
       messageClient(%client, 'RPGchatCallback', "You fall to your death!");
       messageAll('msgDeath', "\c0"@%client.namebase@" fell to his death!");
    }
    else if (%obj.type $= "firedie") {
       %colobj.scriptKill(); //Bye :)
       messageClient(%client, 'RPGchatCallback', "You have burned to death in voltrue's eternal fire.");
       messageAll('msgDeath', "\c0"@%client.namebase@" became one with the eternal flame of Voltrue.");
    }
    else if (%obj.type $= "firegate") {
       if(Game.fetchData(%client, "LVL") < 80) {
          //You're not ready....
          messageClient(%client, 'RPGchatCallback', "The darkness in these flames is too strong for you to handle, and you are forced backwards.");
          %vel = %player.getvelocity();
          //reverse direction
          %vel = vectorscale(%vel, -10);
          %player.setvelocity(%vel);
       }
       else {
          messageClient(%client, 'RPGchatCallback', "The fire is strong, however in your great power you banish the darkness in the flames and pass through untouched.");
       }
    }
	else if(%obj.type $= "teleportVoltrue") {
       if(%client.data.invcount["VoltrueFireCrystal", 3, 1] < 1) {
          messageClient(%client, 'RPGchatCallback', "You lack the required voltrue fire crystal needed to enter.");
	      %vel = %player.getvelocity();
	      //reverse direction
	      %vel = vectorscale(%vel, -2);
	      %player.setvelocity(%vel);
       }
       else {
          Game.RemoveFromInventory(%client, 1, "VoltrueFireCrystal", 3, 1);
          messageClient(%client, 'RPGchatCallback', "Your voltrue fire crystal glows bright red and vanishes as you appear in a void of fire.");
          %player.setPosition(%obj.value);
       }
	}
	else if (%obj.type $= "guildzone") {
		if(%obj.fightinprogress ) {
			if(!%client.participate) {
				MessageClient(%client, 'Error', "Fight in Progress");
				%vel = %player.getvelocity();
				//reverse direction
				%vel = vectorscale(%vel, -2);
				%player.setvelocity(%vel);
				//push client outside of zone
			}
			else {
			    Zone::DoEnter(%obj, %client);
			}
		}
		else {
			Zone::DoEnter(%obj, %client);
			%guildid = IsInWhatGuild(%client);
			%guild = GuildGroup.getObject(%guildid);
			if(%obj.owned) {
				if(%obj.owner $= %guild) {
					MessageClient(%client, 'GuildEnter', "You have entered your guilds territory");
				}
				else {
					MessageClient(%client, 'GuildEnterHostile', "This land is owned by" SPC %obj.owner.getName() @ ", you may #challenge this ownership");
				}
			}
			else {
				if(%guildid != -1) {
					MessageClient(%client, 'GuildUnclaimed', "This zone is unclaimed, you may claim it with #claim");
                }
				else {
					MessageClient(%client, 'GuildUnclaimed', "No guild has claimed this land");
                }
			}
		}
	}
	else {
		Zone::DoEnter(%obj, %client);
	}
}

function RPGGame::onLeaveTrigger(%game, %triggerName, %data, %obj, %colobj)
{
	%client = %colobj.client;
	if(%obj.type $= "teleport")
	{
	
	
	}
	else if (%obj.type $= "sleepzone")
	{
		storedata(%client, "insleepzone", false);
	}
	else if (%obj.type $= "BoatDock")
	{
		if(%colobj.getdatablock().getName() $= RPGBoat)
		{
			%obj.full = false;
			%colobj.zone = %obj;
		}		
	}
	else if (%obj.type $= "guildzone")
	{
		Zone::DoExit(%obj, %client);
		%guildid = IsInWhatGuild(%client);
		%guild = GuildGroup.getObject(%guildid);
		if(%obj.fightinprogress && %client.participate)
		{
			if(%guild == %obj.owner)
			{
				%obj.home--;
				if(%obj.home <= 0) 
					%obj.owner.EndZoneMatch( %obj, %obj.challenger);
			}
			if(%guild == %obj.challenger)
			{
				%obj.away--;
				if(%obj.away <= 0)
					%obj.owner.EndZoneMatch( %obj, %obj.challenger);
			}
			%client.participate = "";
			%client.guildmatchpvp = "";
			%client.enemyguild = "";
		}
	}
	else
	{
		Zone::DoExit(%obj, %client);
	}
}



































//Phantom139: Added here - Zone bot removal for timed
function doBotRemoval(%zoneID) {
   //called when 10 seconds has expired, check once more for players
   if(Zone::getNumPlayers(%zoneID, 0) > 0) {
      //Nope, someone's in the zone
      return;
   }
   //ok the zone is empty, let's kick out all of the bots
   %list = Zone::GetPlayerList(%zoneID, 3);
   for(%i = 0; %i < getWordCount(%list); %i++) {
      %bot = getWord(%list, %i);
      if(%bot.isAIControlled()) {
         //drop it!
         %bot.deSpawn();
      }
   }
}

//And the DB for Voltrue
datablock ParticleData(VoltrueFireParticle) {
   dragCoeffiecient     = 0.0;
   gravityCoefficient   = -0.2;
   inheritedVelFactor   = 0.0;

   lifetimeMS           = 800;
   lifetimeVarianceMS   = 500;

   useInvAlpha = false;
   spinRandomMin = -160.0;
   spinRandomMax = 160.0;

   animateTexture = true;
   framesPerSec = 15;

   textureName = "special/cloudflash";

   colors[0]     = "1.0 0.6 0.4 1.0";
   colors[1]     = "1.0 0.5 0.2 1.0";
   colors[2]     = "1.0 0.25 0.1 0.0";

   sizes[0]      = 45;
   sizes[1]      = 45;
   sizes[2]      = 45;

   times[0]      = 0.0;
   times[1]      = 0.7;
   times[2]      = 1.0;
};

datablock ParticleEmitterData(VoltrueFireEmitter) {
   ejectionPeriodMS = 1;
   periodVarianceMS = 0;
   ejectionVelocity = 400.0;
   velocityVariance = 150.0;
   ejectionOffset   = 0.0;
   thetaMin         = 85;
   thetaMax         = 85;
   phiReferenceVel  = 0;
   phiVariance      = 360;
   overrideAdvances = false;
   particles = "VoltrueFireParticle";
};

datablock ParticleData(burnParticle) {
   dragCoeffiecient     = 0.0;
   gravityCoefficient   = -0.1;
   inheritedVelFactor   = 0.1;

   lifetimeMS           = 500;
   lifetimeVarianceMS   = 50;

   textureName          = "special/cloudflash";

   spinRandomMin = -10.0;
   spinRandomMax = 10.0;

   colors[0]     = "1 0.18 0.03 0.4";
   colors[1]     = "1 0.18 0.03 0.3";
   colors[2]     = "1 0.18 0.03 0.0";
   sizes[0]      = 2.0;
   sizes[1]      = 1.0;
   sizes[2]      = 0.8;
   times[0]      = 0.0;
   times[1]      = 0.6;
   times[2]      = 1.0;
};

datablock ParticleEmitterData(burnEmitter) {
   ejectionPeriodMS = 3;
   periodVarianceMS = 0;

   ejectionOffset = 0.2;
   ejectionVelocity = 10.0;
   velocityVariance = 0.0;

   thetaMin         = 0.0;
   thetaMax         = 10.0;

   particles = "burnParticle";
};
