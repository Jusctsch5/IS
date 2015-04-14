//rpgspecialatt.cs
//Phantom139
//for T2RPG Server

//Defined Variables
//$SpecialAtt[%special, DamageMod] - The Pure numerical damage of the special
//$SpecialAtt[%special, Skill] - The Associated skill of the special attack
//$SpecialAtt[%special, Element] - The Element of the special Attack
//$SpecialAtt[%special, NonSkillHitChance] - The chance a non-skill attack has (out of 100)
//$SpecialAtt[%special, IsPureDamage] - Pure damage means DamageMod exactly is dealt for non-skill hits.

function GameConnection::DoSpecialAttackDamage(%client, %sourcePl, %special) {
   %sourceCl = %sourcePl.client;
   %vguildid = IsInWhatGuild(%client);
   %aguildid = IsInWhatGuild(%sourceCl);
   if(%vguildid != -1)
      %vGuild = GuildGroup.getObject(%vguildid);
   if(%aguildid != -1)
      %aGuild = GuildGroup.GetObject(%aguildid);
   //get the damage mod
   %damage = $SpecialAtt[%special, DamageMod];
   //test based on skill
   %skill = $SpecialAtt[%special, Skill];
   %element = $SpecialAtt[%special, Element];
   if(%skill !$= "") {
      //apply the skill to test
      %dmg = %damage;
      %value = (%dmg / 100) * GetPlayerSkill(%sourceCl, %skill) + %dmg/10;
      %md = fetchdata(%client, "MDEF");
      if( $Spell::ElementDefense[%element] != 3 )
         %md = CombineRpgRolls(%md, AddPoints(%client,  $Spell::ElementDefense[%element]), 0, "inf");
      %md = GetRPGRoll(%md);
      %ab = (getRandom() * (%md*10)) + 1;
      %value = %value - %ab;
      //damage resistance now
      %value = Cap((%value)/1000, 0, "inf");
      //-------------- Damage Tests
      if(IsSameRace(%client, %sourceCl) && %sourceCl !$= %client && $rules !$= "dm") {
         if(inarenabattle(%sourceCl) && inarenabattle(%client)) {
            //combat in the arena. allow damage!
         }
         else if(%aGuild > 0 && fetchdata(%sourceCl, "zone").owner == %aguild && %aGuild != %vGuild && fetchdata(%sourceCl, "zone") == fetchdata(%client, "zone")) {
            //let damage pass
         }
         else if(!(IsInCommaList(fetchData(%client, "targetlist"), %sourceCl.rpgname) || IsInCommaList(fetchData(%sourceCl, "targetlist"), %client.rpgname))) {
            //no target-list involved
            if(%client.guildmatchpvp && %sourceCl.guildmatchpvp) {
               if(%client.enemyguild == %aGuild || %sourceCl.enemyguild == %vguild) {
                  //valid let damage pass
               }
               else {
                  %value = 0;
                  %isMiss = false;
                  %noImpulse = true;
               }
            }
            else {
               %value = 0;
               %isMiss = false;
               %noImpulse = true;
            }
         }
         else {
         }
      }
   }
   else {
      //true-form special attack, no effect, so we use pure damage based on chance
      %chance = $SpecialAtt[%special, NonSkillHitChance];
      %isPure = $SpecialAtt[%special, IsPureDamage];
      %hit_or_miss = getRandom(0, 100);
      if(%hit_or_miss <= %chance) {
         //hit
         if(%isPure) {
            %value = %damage;
         }
         else {
            %value = getRandom(0, %damage);
         }
      }
      else {
         //miss
         %value = 0;
         %isMiss = false;
         %noImpulse = true;
      }
      //
      //-------------- Damage Tests
      if(IsSameRace(%client, %sourceCl) && %sourceCl !$= %client && $rules !$= "dm") {
         if(inarenabattle(%sourceCl) && inarenabattle(%client)) {
            //combat in the arena. allow damage!
         }
         else if(%aGuild > 0 && fetchdata(%sourceCl, "zone").owner == %aguild && %aGuild != %vGuild && fetchdata(%sourceCl, "zone") == fetchdata(%client, "zone")) {
            //let damage pass
         }
         else if(!(IsInCommaList(fetchData(%client, "targetlist"), %sourceCl.rpgname) || IsInCommaList(fetchData(%sourceCl, "targetlist"), %client.rpgname))) {
            //no target-list involved
            if(%client.guildmatchpvp && %sourceCl.guildmatchpvp) {
               if(%client.enemyguild == %aGuild || %sourceCl.enemyguild == %vguild) {
                  //valid let damage pass
               }
               else {
                  %value = 0;
                  %isMiss = false;
                  %noImpulse = true;
               }
            }
            else {
               %value = 0;
               %isMiss = false;
               %noImpulse = true;
            }
         }
         else {
         }
      }
   }
   
   if(!$SpecialAtt[%special, CanSelfDamage] && %sourceCl $= %client) {
      %value = 0;
   }
   
   // -- Do Damage
   if(%isMiss) {
      %msgcolor = $MsgRed;
      %value = 0;
   }
   else if(!%isMiss && %value $= 0 && %sourceCl !$= %client) {
      %msgcolor = $MsgWhite;
   }
   if(%msgcolor !$= "") {
      messageClient(%sourceCl, 'onClientDamaged', %msgcolor @ %client.nameBase @ " resists your special attack!");
      messageClient(%client, 'onClientDamaged', %msgcolor @ "You resist " @ %sourceCl.nameBase @ "'s special attack!");
   }
   
   if(%value < 0) {
      %value = 0;
   }
   else {
      %backupValue = %value;
      %rhp = refreshHP(%client, %value);
      if(%client.isAiControlled() && fetchData(%client, "SpawnBotInfo") !$= "") {
         serverPlay3D(RandomRaceSound(fetchData(%client, "RACE"), Hit), %client.player.getPosition());
      }
      %convValue = round(%value * $TribesDamageToNumericDamage);
      if(%convValue > 0) {
         if(%sourceCl $= %client) {
            %hitby = "yourself";
         }
         else {
            %hitby = %sourceCl.nameBase;
         }
         if(%sourceCl !$= %client && %sourceCl != 0) {
            messageClient(%sourceCl, 'onClientDamaged', $MsgRed @ "You hit " @ %client.nameBase @ " for " @ %convValue @ " points of special attack damage!");
         }
         messageClient(%client, 'onClientDamaged', $MsgRed @ "You were hit by " @ %hitby @ " for " @ %convValue @ " points of special attack damage!");
      }
      //Apply Special Effect
      %client.applySpecialAttackEffect(%effect);
   }
}

function GameConnection::applySpecialAttackEffect(%client, %effect) {

}


//===========================================================
//===========================================================
//===========================================================
//===========================================================
//===========================================================
//SPECIAL ATTACK DATABLOCK & FUNCTIONS
//===========================================================
//===========================================================
//===========================================================
//===========================================================
//===========================================================

//Elemental Scepter: Elemental Shadow Pulse
$SpecialAtt["ElementalScepter", DamageMod] = 350;
$SpecialAtt["ElementalScepter", Skill] = $Skill::OffensiveCasting;
$SpecialAtt["ElementalScepter", Element] = "Gravity";
$SpecialAtt["ElementalScepter", CanSelfDamage] = false;
//$SpecialAtt["ElementalScepter", NonSkillHitChance] = 100;
//$SpecialAtt["ElementalScepter", IsPureDamage] = true;

datablock AudioProfile(ESCEPPulseBoomSound) {
   filename    = "fx/misc/MA1.WAV";
   description = AudioClosest3d;
   preload = true;
};

datablock ShockwaveData(ESCEPPulseBoomShockwave) {
   width = 5.0;
   numSegments = 150;
   numVertSegments = 2;
   velocity = 5;
   acceleration = 30.0;
   lifetimeMS = 2000;
   height = 1.0;
   is2D = true;

   texture[0] = "special/shockwave4";
   texture[1] = "special/gradient";
   texWrap = 6.0;

   times[0] = 0.0;
   times[1] = 0.5;
   times[2] = 1.0;

   colors[0] = "0.5 0.0 0.8 1.00";
   colors[1] = "0.8 0.0 0.5 0.20";
   colors[2] = "0.5 0.0 0.8 0.0";
};

datablock ExplosionData(ESCEPPulseExplosion) {
   soundProfile   = ESCEPPulseBoomSound;
   shockwave[0] =  ESCEPPulseBoomShockwave;

   faceViewer           = false;
};

datablock LinearFlareProjectileData(ESCEPPulse) {
   emitterDelay        = -1;
   directDamage        = 0;
   radiusDamageType    = $DamageType::SpecialAttack;
   hasDamageRadius     = true;
   indirectDamage      = 0.04;
   damageRadius        = 5.0;
   kickBackStrength    = 0.0;
   bubbleEmitTime      = 1.0;

   sound = PlasmaProjectileSound;
   velInheritFactor    = 0.5;

   explosion           = "ESCEPPulseExplosion";
   splash              = BlasterSplash;

   grenadeElasticity = 0.998;
   grenadeFriction   = 0.0;
   armingDelayMS     = 500;

   muzzleVelocity    = 100.0;

   drag = 0.05;

   gravityMod        = 0.0;

   dryVelocity       = 100.0;
   wetVelocity       = 80.0;

   reflectOnWaterImpactAngle = 0.0;
   explodeOnWaterImpact      = false;
   deflectionOnWaterImpact   = 0.0;
   fizzleUnderwaterMS        = 6000;

   lifetimeMS     = 6000;

   scale             = "1 1 1";
   numFlares         = 48;
   flareColor        = "0.5 0 1";
   flareModTexture   = "special/shrikeBoltCross";
   flareBaseTexture  = "special/shrikeBolt";
};

function ESCEPPulse::onExplode(%data, %proj, %pos, %mod) {
   RadiusExplosion(%proj, %pos, %data.damageRadius, %data.indirectDamage, 0, %proj.sourceObject, %data.radiusDamageType);
}
