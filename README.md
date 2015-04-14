PGD Ironsphere RPG
====

PGD ISRPG is a customized version of the Ironsphere RPG Mod for Tribes 2. This mod adds new activities, items, and patches many flaws in the old mod. Tribes 2 is a pre 1.0 game of the Torque Game Engine.

Web Sites/Pages:
* http://www.phantomdev.net/Tribes2/ISRPG/ - Mod Homepage

Current Version: 1.3.1.4 (1314) [Development]

Ironsphere Credits:
* Goodie - WorldCraft Modeller
* Gul'Dar - WorldCraft Modeller and Mapper
* HiVoltage - Modeller
* JeremyIrons - Original Creator
* Lone Predator - Skinner
* Scourage - Coder
* SoulSlayer - WorldCraft Modeller
* Trident_RX - Head Coder, Creator
* Toaster - Documentation
* Twister - WorldCraft Modeller
* Fina - Head Mapper, Worldcraft Modeller
* Sirsteven - Lead Tester
* Jardin De Cecile - Music Score

PGD ISRPG Credits:
* Phantom139 - Lead Coder / Mod Developer, Official Host


Install:
* Unzip the GIT contents to a folder in your gamebase folder named IS
* Run the included batch file.
* ???
* Profit.

Uninstall: Delete the IS Folder

Server Setup:
To set up the administrator logins for a ISRPG server, you'll need to add five GVars to a script that is loaded with each server run, these variables are:
* $AdminPassword[1]: Admin Level 1
* $AdminPassword[2]: Admin Level 2
* $AdminPassword[3]: Admin Level 3
* $AdminPassword[4]: Admin Level 4
* $AdminPassword[5]: Admin Level 5 

MOD DEVELOPMENT LOG:
1313 -> 1314:
* Patched a bug in the Special Attack system that prevented specials from recharging when a player died during the change weapon process
* Moved the Sartopia entrance, it was previously in an unaccessible area (Only admins could reach it)
* Axed out a good amount of redundant mod methods, there are still a ton to go.
* Added Snowblind Village, a mysterous village located far beyond the current realm. Explore the world, and find new challenges!
* Patched a bug in the mod's quest system which prevented certain items from being removed from your inventory during certain phases.

1312 -> 1313:
* Patched an error in the mod's Zone Positioning Script
* Updated all zones to be handled by a more effective listing and find solution
* Updated the inWhichZone function to calculate using 3D World-Boxes instead of flawed radial calculations
* Updated the AI Spawning code to spawn AIs only when there is an active human player in the area, when there are no players, the AI Despawns
 - This route needs to be investigated for a potential .EXE patch to override the T2 Bot limit in the event of a massive server where all zones are marked active (There are over 100 total defined spawns)
* Fixed the firing bug with numerous bow weapons, all bows will now correctly fire their projectiles
* Added the Special Attack system to the mod
* Added ~20 New Items to the mod
* Added new "Stand Still & Talk" NPCs to guide players through the world space
* Fixed a few broken mod chat commands
* Added the Keldrin Training Zone and Dummy AI Bots to help new players level up to 5-7 to prepare for the mines.
* Added four new world dungeons to the mod
 - Myrklure: Water Temple [Levels 20 - 30]
 - Heven Plateau: Earth Temple [Levels 65 - 75]
 - Voltrue: Fire Temple [Levels 80 - 90]
 - Sartopia: Air/Sky/Ice Temple [Levels 105+]
* Added a Boss system to the mod, and added four bosses (one for each temple finale encounter)
* Added the "Power of the Elements" quest to the mod, Hunt down the Legendary Elemental Scepter!