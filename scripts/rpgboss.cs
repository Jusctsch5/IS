//lol
function BossSetup(%client) {
   //%name = %client.bossName;
   //
}

function BossComplete(%client, %lastPosition) {
   if(%client.despawning) {
      echo("* BOSS "@%client@" Despawning.. Cancelling completion call.");
      return;
   }
   %zone = %client.Bzone;
   %test = positionInWhichZone(%lastPosition);
   echo("* BOSS KILL "@%client@" @ "@%lastPosition@" (Boss Zone: "@%zone@" - In Zone: "@%test@")");
   //get all of the players in the boss' zone
   echo("** Removing players from "@%zone);
   for(%i = 0; %i < ClientGroup.getCount(); %i++) {
      %cl = ClientGroup.getObject(%i);
      if(!%cl.isAIControlled()) {
         echo("Scanning "@%cl@" ("@%cl.namebase@"): "@fetchData(%cl, "zone"));
         if(isObject(%cl.player) && %cl.player.getState() !$= "dead") {
            if(fetchData(%cl, "zone") $= %zone) {
               messageClient(%cl, 'msgVictory', "\c0"@%client.bossName@" has fallen! You will be teleported out in 5 seconds....");
               //teleport them out after 25 seconds
               if(isObject(%cl.player)) {
                  allDoneBoss(%cl.player, %client.bossName, %zone);
               }
            }
         }
      }
   }
}

function allDoneBoss(%player, %boss, %zone) {
   echo("Schedule set: "@%player@" -> "@%zone.exitPos@"");
   %player.schedule(5000, setPosition, ""@%zone.exitPos@"");
   
   %client = %player.client;
   //Phantom139: Let's make sure everyone get's what they deserve
   switch$(%boss) {
      case "Navegus":
         Game.AddToInventory(%client, 1, "AirElement", 1, 1);
         RefreshAll(%client);
      case "Verlium":
         Game.AddToInventory(%client, 1, "EarthElement", 1, 1);
         RefreshAll(%client);
      case "Magmus":
         Game.AddToInventory(%client, 1, "FireElement", 1, 1);
         Game.AddToInventory(%client, 1, "MagmusDarkSpirit", 1, 1);
         RefreshAll(%client);
      case "Laviathena":
         Game.AddToInventory(%client, 1, "WaterElement", 1, 1);
         RefreshAll(%client);
   }
}

//--------------------- BOSS SPELLS
// Castran
// * Fire Hammer
// ** Lunge into the air and crush down with a fire explosion
// * Magma Pylons
// ** Summon hotspot flares which open up magma pylon zones, which inflict damage if entered
// * Pulsar
// ** Castran's version of "melt"
// * Nova
// ** Fire hotspot flares out in all directions
// * Reign of Fire
// ** Like snowstorm, but with fire bombs
function UseBossSpell_Castran(%client, %tP) {

}

// Magmus
// * Pillar
// ** Open a large fire pillar which remains intact for 20 seconds, damaging any player that touches it
// * Frenzy
// ** Launch Fire Blasts in all directions
// * Forsaken Blast
// ** Summon fire bombs in a straight line
// * Doomlurk
// ** Summon 7+ Pillars
// * Flame Coat
// ** Attach a flame coat to a target, freezing it in place for a short period of time
// * Fire Punch
// ** Send out a massive fire wall in one direction
function UseBossSpell_Magmus(%client, %tP) {

}

//Navegus
