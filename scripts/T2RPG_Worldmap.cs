// ##################################### //
// ##################################### //
//          Enemy Spawn Points           //
// ##################################### //
// ##################################### //


function DefineAISpawn()
{
   //createAISpawn(%pos, %box, %mindelay, %maxdelay, %botlist, %team, %attackId);
   //%botlist contains a list seperated by spaces of the $spawnindex values defined below
   //ex createAISpawn("-1006.14 706.277 64.804", "0 0 0", 1, 10, "1 2 3",1,0);
    //createAISpawn("-1006.14 706.277 64.804", "0 0 0", 1, 10, "1 1 1 1 2 2 3",5,0);
    //createAISpawn("-1006 706 64.804", "0 0 0", 5, 20, "1 1 1 1 2 2 3",5,0);

// Ethren Attack Army
        $AI::AttackPos[1,0] = "256.131 -249 53.3192";
	//removed
	
// Mine Spawn points!

	//goblins (1-4)
	createAIspawn("-1083 596 119", "0 0 0", 5, 20, "1 1 2 3 3", 1, 0);
	createAIspawn("-1075.57 630.961 119", "0 0 0", 5, 20, "1 1 2 3 3 4 4", 1, 0);

	createAIspawn("-1138.26 585.48 139.881", "0 0 0", 5, 20, "1", 1, 0);
	createAIspawn("-1145.42 501.896 139.881", "0 0 0", 5, 20, "1", 1, 0);
	createAIspawn("-1184.18 542.456 139.881", "0 0 0", 5, 20, "1 1 2", 1, 0);
	createAIspawn("-1093.31 651.489 139.881", "0 0 0", 5, 20, "1 1 2", 1, 0);

	createAIspawn("-1114.59 703.356 133.63", "0 0 0", 5, 20, "1 2 3", 1, 0);
	createAIspawn("-1025.38 511.41 114.677", "0 0 0", 5, 20, "1 1 1 2 2 3", 1, 0);
	createAIspawn("-1059.84 508.23 94.0157", "0 0 0", 5, 20, "1 1 2", 1, 0);

	//Gnolls (7-9, 22)

        //Large Equipment room
	createAIspawn("-1172.1 566.279 92.3973", "1 1 0", 5, 30, "7 7 8 22 7", 1, 0);
	createAIspawn("-1174.1 568.279 92.3973", "1 1 0", 5, 30, "7 7 8 8 7", 1, 0);
        //Yellow Room
	//createAIspawn("-1031.06 686.976 121.668", "0 0 0", 5, 20, "7", 1, 0);
	createAIspawn("-1034.06 686.976 121.668", "0 0 0", 5, 20, "7 7 8", 1, 0);
	createAIspawn("-1031.06 690.976 121.668", "0 0 0", 5, 20, "7 7 7 8 8 9 9 22", 1, 0);

// Conscripts (5)
	$AI::AttackPos[2,0] = "255.689 -253.689 51.21";
	createAISpawn("255.689 -253.689 53.21", "0 0 0", 100, 900, "5",1,2);

	$AI::AttackPos[3,0] = "256.042 -250.623 51.21267";
	$AI::AttackPos[9,0] = "256.042 -252.623 55.21267";
	$AI::AttackPos[9,1] = "255.689 -255.689 55.21";
	createAISpawn("256.042 -250.623 53.21267", "0 0 0", 100, 900, "5",1,3);
	//createAISpawn("256.042 -252.623 55.21267", "0 0 0", 300, 600, "5",1,9);
	//createAISpawn("255.689 -255.689 55.21", "0 0 0", 300, 600, "5",1,9);
	
	$AI::AttackPos[4,0] = "-362.205 956.154 51.3047";
	createAISpawn("-362.205 956.154 51.3047", "0 0 0", 5, 10, "5", 1, 4);
	
// Fish Spawn points (6)
	//createAISpawn("-592 855 10", "1 1 10", 50, 200, "6",1,0);
	//createAISpawn("-590 857 10", "1 1 10", 50, 200, "6",1,0);
	//createAISpawn("-594 855 10", "1 1 10", 50, 200, "6",1,0);
	createAISpawn("-598 855 10", "1 1 10", 50, 200, "6",1,0);
	createAISpawn("-600 855 10", "1 1 10", 50, 200, "6",1,0);
	createAISpawn("-602 855 10", "1 1 10", 50, 200, "6",1,0);
	createAISpawn("-604 855 10", "1 1 10", 50, 200, "6",1,0);
	createAISpawn("-606 855 10", "1 1 10", 50, 200, "6",1,0);
	createAISpawn("-608 855 10", "1 1 10", 50, 200, "6",1,0);
	createAISpawn("-610 855 10", "1 1 10", 50, 200, "6",1,0);
	createAISpawn("-612 855 10", "1 1 10", 50, 200, "6",1,0);
	//createAISpawn("-614 855 10", "1 1 10", 50, 200, "6",1,0);
	//createAISpawn("-616 855 10", "1 1 10", 50, 200, "6",1,0);
	//createAISpawn("-618 855 10", "1 1 10", 50, 200, "6",1,0);
	//createAISpawn("-620 855 10", "1 1 10", 50, 200, "6",1,0);
	

// Yolanda ( 11-13, 26)
	//Orcs! Beware
	$AI::AttackPos[7,0] = "-1091.74 604.728 321.142";
	createAISpawn("-1091.74 604.728 321.142", "0 0 0", 5, 20, "11 12 13 11 12 11",5,7);
	createAISpawn("-1147.03 565.174 321.142", "0 0 0", 5, 20, "11 12 13 11 12 26 11 12 12",5,7);	

//ogre (28-31)
	$Ai::AttackPos[11, 0] = "-2661.32 404.086 60.9192";
	$Ai::AttackPos[11, 1] = "-2643.2 343.718 67.7022";
	createAISpawn("-2661.32 404.086 60.9192", "0 0 0", 10, 30, "28 28 29 29 29 30 30 30 30", 7, 11);
	createAISpawn("-2643.2 343.718 67.7022", "0 0 0", 12, 33, "31 28 29 30 30 29", 7, 11);

// Elementals (10)
	$AI::AttackPos[5,0] = "33.3125 1134.59 64.152";
	$AI::AttackPos[6,0] = "727.324 984.623 157.157";
	createAISpawn("33.3125 1134.59 64.152", "0 0 0", 5, 20, "10", 7, 5);
	createAISpawn("727.324 984.623 157.157", "0 0 0", 5, 20, "10", 7, 6);
//undead/skel (32-35)
	createAISpawn("-839.313 -1003.23 56.9435", "0 0 0", 10, 20, "32 32 33 33", 9, 0);
	createAISpawn("-848.6 -1006.72 56.9435", "0 0 0", 10, 20, "32 32 33 33", 9, 0);
	createAISpawn("-845.956 -986.872 49.4435", "0 0 0", 10, 20, "34 35 34", 9, 0);

//Elf (15-18, 23)
	
	$AI::AttackPos[8,0] = "-1082 2128 120";
	$AI::AttackPos[8,1] = "-1095 2209 134";
	$AI::AttackPos[8,2] = "-1044 2163 124";
	createAISpawn("-1082 2128 120", "0 0 0", 5, 20, "15 16 17 18 15 16", 3, 8);
	//createAISpawn("-1095 2209 134", "0 0 0", 5, 20, "15 15 15 16", 3, 8);
	createAISpawn("-1044 2163 124", "0 0 0", 5, 20, "23 15 16 16 17", 3, 8);

//Travellers (19-21, 24)
	$AI::AttackPos[10,0] = "1559 -48 125";
	$AI::AttackPos[10,1] = "1571 -170 125";
	$AI::AttackPos[10,2] = "1474 -226 115";
	$AI::AttackPos[10,3] = "1348 -50 105";
	//createAISpawn("1559 -48 125", "0 0 0", 5, 20, "19 20 21", 4, 10);
	createAISpawn("1571 -170 125", "0 0 0", 5, 20, "19 19 20 21 20", 4, 10);
	createAISpawn("1474 -226 115", "0 0 0", 5, 20, "19 19 19 20 21 20", 4, 10);
	createAISpawn("1349 -177 105", "0 0 0", 5, 20, "24 19 19 19 20 21 20", 4, 10);
	createAISpawn("1348 -50 105", "0 0 0", 5, 20, "24 24 19 19 19 20 21 20", 4, 10);


//minotuar!!!! (14, 25)

	createAISpawn("504.963 1415.49 65", "0 0 0", 20, 30, "14", 5, 0);
	createAISpawn("504.963 1415.49 70", "0 0 0", 20, 30, "14 14 25", 5, 0);

	customAiSpawn();
}
function DefineLoadouts()
{
	$RaceDescription[1] = "Death Knight";
	$RaceDescription[2] = "Human";
	$RaceDescription[3] = "Orc";
	$RaceDescription[4] = "Elf";
	$RaceDescription[5] = "Goblin";
	$RaceDescription[6] = "Gnoll";
	$RaceDescription[7] = "Ogre";
	$RaceDescription[8] = "Wild Orc";
	$RaceDescription[9] = "Undead";
	$RaceDescription[10] = "Minotaur";
	$RaceDescription[11] = "Fish";
	$RaceDescription[12] = "Elemental";
	$RaceDescription[13] = "Dark Human";
	
	$RaceSkin[1] = "";//if "" it will be default, if specified the skin will be used.
	$RaceSkin[2] = "";
	$RaceSkin[3] = "";
	$RaceSkin[4] = "Elf_AM_skin";
	$RaceSkin[5] = "";
	$RaceSkin[6] = "";
	$RaceSkin[7] = "";
	$RaceSkin[8] = "";
	$RaceSkin[9] = "";
	$RaceSkin[10] = "";
	$RaceSkin[11] = "";
	$RaceSkin[12] = "";
	$RaceSkin[13] = "";
	
	
	
	$RaceID[DeathKnight] = 1;
	$RaceID[MaleHuman] = 2;
	$RaceID[FemaleHuman] = 2;
	$RaceID[MaleOrc] = 3;
	$RaceID[FemaleOrc] = 3;
	$RaceID[MaleElf] = 4;
	$RaceID[FemaleElf] = 4;
	$RaceID[Goblin] = 5;
	$RaceID[GoblinShaman] = 5;
	$RaceID[Gnoll] = 6;
	$RaceID[GnollShaman] = 6;
	$RaceID[Ogre] = 7;
	$RaceID[BigOrc] = 8;
	$RaceID[Skeleton] = 9;
	$RaceID[Zombie] = 9;
	$RaceID[Vampire] = 9;
	$RaceID[Ghoul] = 9;
	$RaceID[Lich] = 9;
	$RaceID[Wraith] = 9;
	$RaceID[Minotaur] = 10;
	$RaceID[Fish] = 11;
	$RaceID[Elemental] = 12;
	$RaceID[Orc] = 3;
	$RaceID[DarkHuman] = 13;

	$MinHP[DeathKnight] = 5000;
	$MinHP[MaleHuman] = 15;
	$MinHP[FemaleHuman] = 15;
	$MinHP[MaleOrc] = 13;
	$MinHP[FemaleOrc] = 13;
	$MinHP[MaleElf] = 10;
	$MinHP[FemaleElf] = 10;
	$MinHP[Goblin] = 0;
	$MinHP[GoblinShaman] = 5;
	$MinHP[Gnoll] = 3;
	$MinHP[GnollShaman] = 8;
	$MinHP[Ogre] = 10;
	$MinHP[BigOrc] = 16;
	$MinHP[Skeleton] = 13;
	$MinHP[Zombie] = 14;
	$MinHP[Vampire] = 15;
	$MinHP[Ghoul] = 15;
	$MinHP[Lich] = 18;
	$MinHP[Wraith] = 24;
	$MinHP[Minotaur] = 35;
	$MinHP[Fish] = 1;
	$MinHP[Lightning] = 100;
	$MinHP[Orc] = 16;
	$MinHP[DarkHuman] = 12;

	$PlayableRace[1] = true;
	$PlayableRace[2] = true;
	$PlayableRace[3] = false;//in other versions we may set this to true..
	$PlayableRace[4] = false;
	$PlayableRace[5] = false;
	$PlayableRace[6] = false;
	$PlayableRace[7] = false;
	$PlayableRace[8] = false;
	$PlayableRace[9] = false;
	$PlayableRace[10] = false;
	$PlayableRace[11] = false;
	$PlayableRace[12] = false;
	$PlayableRace[13] = false;
        //RACE [racename] LVL [XrY] CLASS [classname]  ex RACE Orc LVL 1r1 CLASS fighter
// Humans
	$EnemyProfile[Conscript] = "LVL 80r100 CLASS Fighter COINS 20r35";
// Fish
	$EnemyProfile[Fish] = "LVL 1r1 CLASS Fighter";
// Goblins
	$EnemyProfile[Runt] = "LVL 1r1 CLASS Fighter COINS 1r1";
	$EnemyProfile[Thief] = "LVL 2r3 CLASS Fighter COINS 1r3";
	$EnemyProfile[Raider] = "LVL 3r5 CLASS Fighter COINS 5r15";
	$EnemyProfile[Wizard] = "LVL 3r6 CLASS Mage COINS 30r40";
// Gnolls
	$EnemyProfile[Pup] = "LVL 4r8 CLASS Fighter COINS 5r10";
	$EnemyProfile[Scavenger] = "LVL 8r12 CLASS Fighter COINS 10r15";
	$EnemyProfile[Hunter] = "LVL 10r15 CLASS Ranger COINS 20r30";
	$EnemyProfile[Shaman] = "LVL 10r15 CLASS Mage COINS 20r30";
// Elemental
        $EnemyProfile[Lightning] = "LVL 50r60 Class Fighter COINS 150r200";
// Orcs
	$EnemyProfile[Berserker] = "LVL 17r23 Class Fighter COINS 13r25";
	$EnemyProfile[Ravager] = "LVL 20r28 Class Fighter COINS 13r25";
	$EnemyProfile[Slayer] = "LVL 24r30 Class Fighter COINS 13r25";
	$EnemyProfile[WarLock] = "LVL 14r18 Class Mage COINS 34r45";
// Minotaur
	$EnemyProfile[Guardian] = "LVL 90r110 CLASS Fighter COINS 300r600";
	$EnemyProfile[Reaper]	= "LVL 95r115 CLASS Mage COINS 300r650";
//Elf
	$EnemyProfile[Protector] = "LVL 45r55 CLASS Fighter COINS 1r60";
	$EnemyProfile[Peacekeeper] = "LVL 48r58 CLASS Fighter Coins 1r80";
	$EnemyProfile[Lord]		= "LVL 50r60 CLASS Fighter Coins 1r100";
	$EnemyProfile[Champion]		= "LVL 52r62 CLASS Fighter Coins 20r120";
	$EnemyProfile[Conjurer]		= "LVL 53r63 CLASS Mage COINS 30r100";

//travellers
	$EnemyProfile[Birgand]		= "LVL 70r80 CLASS Fighter COINS 30r40";
	$EnemyProfile[Marauder]		= "LVL 75r85 CLASS Fighter COINS 30r42";
	$EnemyProfile[Knight]		= "LVL 78r88 CLASS Fighter COINS 36r46";
	$EnemyProfile[Paladin]		= "LVL 80r90 CLASS Mage COINS 50r100";
//ogres
	$EnemyProfile[Ruffian]		= "LVL 20r24 CLASS Fighter COINS 12r30";
	$EnemyProfile[Destroyer]	= "LVL 22r33 CLASS Fighter COINS 23r34";
	$EnemyProfile[Halberdier]	= "LVL 29r33 CLASS Fighter COINS 13r39";
	$EnemyProfile[Dreadnought]	= "LVL 33r39 CLASS FIghter COINS 19r42";
	$EnemyProfile[Magi]		= "LVL 39r44 CLASS Mage COINS 25r75";
//undead
	$EnemyProfile[Mauler]		= "LVL 42r46 CLASS Fighter COINS 20r30";
	$EnemyProfile[Thrasher]		= "LVL 45r52 CLASS Fighter COINS 23r33";
//walking skeletons
	$EnemyProfile[Skeleton]		= "LVL 52r56 CLASS Fighter COINS 26r36";
	$EnemyProfile[Necromancer]	= "LVL 58r63 CLASS Fighter COINS 29r39";





	$aiRace[Runt] 		= "Goblin";
	$aiRace[Thief] 		= "Goblin";
	$aiRace[Raider] 	= "Goblin";
	$aiRace[Wizard] 	= "Goblin";
	$aiRace[Conscript] 	= "MaleHuman";
	$aiRace[Fish] 		= "Fish";
	$aiRace[Pup] 		= "Gnoll";
	$aiRace[Scavenger] 	= "Gnoll";
	$aiRace[Hunter] 	= "Gnoll";
	$aiRace[Lightning] 	= "Elemental";
	$aiRace[Berserker] 	= "Orc";
	$aiRace[Ravager] 	= "Orc";
	$aiRace[Slayer] 	= "Orc";
	$aiRace[Warlock]	= "Orc";
	$aiRace[Guardian] 	= "Minotaur";
	$aiRace[Protector] 	= "MaleElf";
	$aiRace[Peacekeeper] 	= "MaleElf";
	$aiRace[Lord] 		= "MaleElf";
	$aiRace[Champion] 	= "MaleElf";
	$aiRace[Birgand]  	= "EvilHuman";
	$aiRace[Marauder] 	= "EvilHuman";
	$aiRace[Knight]		= "EvilHuman";
	$aiRace[Shaman]		= "Gnoll";
	$aiRace[Conjurer]	= "MaleElf";
	$aiRace[Paladin]	= "EvilHuman";
	$aiRace[Reaper]		= "Minotaur";
	$aiRace[Ruffian]	= "Ogre";
	$aiRace[Destroyer]	= "Ogre";
	$aiRace[Halberdier]	= "Ogre";
	$aiRace[Dreadnought] 	= "Ogre";
	$aiRace[Magi]		= "Ogre";
	$aiRace[Mauler]		= "Zombie";
	$aiRace[Thrasher]	= "Zombie";
	$aiRace[Skeleton]	= "Skeleton";
	$aiRace[Necromancer]	= "Skeleton";

	$SpawnIndex[1] 		= "Runt";
	$SpawnIndex[2] 		= "Thief";
	$SpawnIndex[3] 		= "Raider";
	$SpawnIndex[4] 		= "Wizard";
	$SpawnIndex[5] 		= "Conscript";
	$SpawnIndex[6] 		= "Fish";
	$SpawnIndex[7] 		= "Pup";
	$SpawnIndex[8] 		= "Scavenger";
	$SpawnIndex[9] 		= "Hunter";
        $SpawnIndex[10] 	= "Lightning";
        $spawnIndex[11] 	= "Berserker";
        $spawnIndex[12] 	= "Ravager";
        $SpawnIndex[13] 	= "Slayer";
        $SpawnIndex[14] 	= "Guardian";
        $SpawnIndex[15] 	= "Protector";
        $SpawnIndex[16] 	= "Lord";
        $SpawnIndex[17] 	= "Peacekeeper";
        $SpawnIndex[18] 	= "Champion";
        $SpawnIndex[19] 	= "Birgand";
        $SpawnIndex[20]		= "Marauder";
        $SpawnIndex[21]		= "Knight";
        $SpawnIndex[22]		= "Shaman";
        $SpawnIndex[23]		= "Conjurer";
	$SpawnIndex[24] 	= "Paladin";
	$SpawnIndex[25]		= "Reaper";
	$SpawnIndex[26] 	= "Warlock";
	$SpawnIndex[27] 	= "Ruffian";
	$SpawnIndex[28]		= "Destroyer";
	$SpawnIndex[29]	 	= "Halberdier";
	$SpawnIndex[30]		= "Dreadnought";
	$SpawnIndex[31] 	= "Magi";
	$SpawnIndex[32] 	= "Mauler";
	$SpawnIndex[33] 	= "Thrasher";
	$SpawnIndex[34]		= "Skeleton";
	$SpawnIndex[35]		= "Necromancer";
	
	//attack behaviors
	//0 is default
	//1 is only attack enemies in its own zone, or enemies that hit him
	$attb[Runt] 		= 0;
	$attb[Thief] 		= 0;
	$attb[Raider] 		= 0;
	$attb[Wizard] 		= 0;
	$attb[Conscript] 	= 1;
	$attb[Fish] 		= 0;
	$attb[Pup] 		= 0;
	$attb[Scavenger] 	= 0;
	$attb[Hunter] 		= 0;
	$attb[Lightning] 	= 0;
	$attb[Berserker] 	= 0;
	$attb[Ravager]	 	= 0;
	$attb[Slayer] 		= 0;
	$attb[warlock]		= 0;
	$attb[Guardian] 	= 0;
	$attb[Protector] 	= 0;
	$attb[Peacekeeper] 	= 0;
	$attb[Lord] 		= 0;
	$attb[Champion] 	= 0;
	$attb[Birgand]		= 0;
	$attb[Marauder]		= 0;
	$attb[Knight]		= 0;
	$attb[Shaman]		= 0;
	$attb[Conjurer]		= 0;
	$attb[Paladin]		= 0;
	$attb[Reaper]		= 0;
	$attb[Ruffian] 		= 0;
	$attb[Destroyer]	= 0;
	$attb[Halberdier]	= 0;
	$attb[Dreadnought]	= 0;
	$attb[Magi] 		= 0;
	$attb[Mauler]		= 0;
	$attb[Thrasher]		= 0;
	$attb[Skeleton]		= 0;
	$attb[Necromancer]	= 0;
	
	//uses magic!
	$Bot::Magic[Runt] 	= 0;
	$Bot::Magic[Thief] 	= 0;
	$Bot::Magic[Raider] 	= 0;
	$Bot::Magic[Wizard] 	= 1;
	$Bot::Magic[Conscript] 	= 0;
	$Bot::Magic[Fish] 	= 0;
	$Bot::Magic[Pup] 	= 0;
	$Bot::Magic[Scavenger] 	= 0;
	$Bot::Magic[Hunter] 	= 0;
	$Bot::Magic[Lightning] 	= 0;
	$Bot::Magic[Berserker] 	= 0;
	$Bot::Magic[Ravager]	= 0;
	$Bot::Magic[Slayer] 	= 0;
	$Bot::Magic[Guardian] 	= 0;
	$Bot::Magic[Protector] 	= 0;
	$Bot::Magic[Peacekeeper]= 0;
	$Bot::Magic[Lord] 	= 0;
	$Bot::Magic[Champion] 	= 0;
	$Bot::Magic[Birgand]	= 0;
	$Bot::Magic[Marauder]	= 0;
	$Bot::Magic[Knight]	= 0;
	$Bot::Magic[Shaman]	= 1;
	$Bot::Magic[Conjurer]	= 1;
	$Bot::Magic[Paladin]	= 1;
	$Bot::Magic[Reaper]	= 1;
	$Bot::Magic[Warlock]	= 1;
	$Bot::Magic[Ruffian] 	= 0;
	$Bot::Magic[Destroyer]	= 0;
	$Bot::Magic[Halberdier]	= 0;
	$Bot::Magic[Dreadnought]= 0;
	$Bot::Magic[Magi] 	= 1;
	$Bot::Magic[Mauler]	= 0;
	$Bot::Magic[Thrasher]	= 0;
	$Bot::Magic[Skeleton]	= 0;
	$Bot::Magic[Necromancer]= 1;
	//Runt
        $EnemyWeapons[1] 	= "Knife 1 1";//first value item, then prefix then suffix 1 prefix is rusty 3 is normal, 1 suffex is normal..
        $EnemyArmor[1] 		= "";//same type as weapons.... no randomness to actually having it...
        $EnemyItems[1] 		= "";// first value is how many second value is odds... for items the values must be a roll... 1r1 will always give an item...
	//Thief
	$EnemyWeapons[2] 	= "Knife 2 1 Sling 2 1";
	$EnemyArmor[2] 		= "";
	$EnemyItems[2] 		= "BluePotion 1r1 1r20 String 1r1 1r25 SmallRock 10r15 1r1";
	//Raider
	$EnemyWeapons[3] 	= "PickAxe 1 1";
	$EnemyArmor[3] 		= "";
	$EnemyItems[3] 		= "BluePotion 1r1 1r10 Rod 1r1 1r20";
	//Wizard
	$EnemyWeapons[4] 	= "Knife 3 1";
	$EnemyArmor[4] 		= "";
	$EnemyItems[4] 		= "BluePotion 1r1 1r2";
	//Conscript
	$EnemyWeapons[5] 	= "Spear 3 1";
	$EnemyArmor[5] 		= "";
	$EnemyItems[5] 		= "BluePotion 1r1 1r10 ";
	//Fish
	$EnemyWeapons[6] 	= "";
	$EnemyArmor[6] 		= "";
	$EnemyItems[6] 		= "Fish 1r1 1r1";
	//Pup
	$EnemyWeapons[7] 	= "WarAxe 2 1";
	$EnemyArmor[7] 		= "";
	$EnemyItems[7] 		= "CrystalBluePotion 1r1 1r3 GnollHide 1r1 1r3";
	//Scavenger
	$EnemyWeapons[8] 	= "WarAxe 3 1";
	$EnemyArmor[8] 		= "";
	$EnemyItems[8] 		= "BluePotion 1r1 1r5 GnollHide 1r1 1r2";
	//Hunter
	$EnemyWeapons[9] 	= "WarAxe 1 1 Sling 3 1";
	$EnemyArmor[9] 		= "";
	$EnemyItems[9] 		= "BluePotion 1r1 1r3 GnollHide 1r1 1r1 SmallRock 20r25 1r1";
	//lightning
	$EnemyWeapons[10] 	= "Broadsword 3 1";
	$EnemyArmor[10] 	= "";
	$EnemyItems[10] 	= "CrystalBluePotion 1r3 1r2";
	//berserker
	$EnemyWeapons[11] 	= "BroadSword 2 1";
	$EnemyArmor[11] 	= "";
	$EnemyItems[11] 	= "BluePotion 1r2 1r5 Rod 1r1 1r12";
	//ravanger
	$EnemyWeapons[12] 	= "BroadSword 2 1";
	$EnemyArmor[12] 	= "";
	$EnemyItems[12] 	= "String 1r1 1r10";
	//slayer
	$EnemyWeapons[13] 	= "BroadSword 2 1 ShortBow 2 1";
	$EnemyArmor[13] 	= "";
	$EnemyItems[13] 	= "BluePotion 1r3 1r2 Opal 1r4 1r100 BasicArrow 10r15";
	//guardian
	$EnemyWeapons[14] 	= "BattleAxe 2 1";
	$EnemyArmor[14] 	= "";
	$enemyItems[14] 	= "";
	//protector
	$EnemyWeapons[15] 	= "LongSword 3 1";
	$EnemyArmor[15] 	= "";
	$EnemyItems[15] 	= "BluePotion 1r2 1r10 Rod 1r1 1r20 Coal 1r1 1r5 Iron 1r4 1r5";
	//peacekeeper
	$EnemyWeapons[16] 	= "LongSword 4 1";
	$EnemyArmor[16] 	= "";
	$EnemyItems[16] 	= "BluePotion 1r1 1r5 Coal 1r4 1r10";
	//lord
	$EnemyWeapons[17] 	= "LongSword 4 1 ShortBow 3 1";
	$EnemyArmor[17] 	= "";
	$EnemyItems[17] 	= "BluePotion 1r3 1r10 Iron 1r1 1r2 BasicArrow 20r30 1r1";
	//champion
	$EnemyWeapons[18] 	= "LongSword 5 1 LightCrossbow 2 1";
	$EnemyArmor[18] 	= "";
	$EnemyItems[18] 	= "CrystalBluePotion 1r1 1r10 Jade 1r1 1r10 Diamond 1r1 1r500 ShortQuarrel 20r30 1r1";
	//brigand
	$EnemyWeapons[19] 	= "Mace 2 1";
	$EnemyArmor[19] 	= "";
	$EnemyItems[19] 	= "BluePotion 1r1 1r10 Topaz 1r2 1r20 Diamond 1r1 1r100 Iron 1r5 1r10";
	//marauder
	$EnemyWeapons[20] 	= "Mace 3 1";
	$EnemyArmor[20] 	= "";
	$EnemyItems[20]		= "Coal 1r1 1r2";
	//knight
	$EnemyWeapons[21]	= "LongSword 5 1 LightCrossbow 3 1";
	$EnemyArmor[21]		= "";
	$EnemyItems[21]		= "Coal 1r1 1r1 Iron 1r2 1r1 ShortQuarrel 30r35 1r1";
	//shaman
	$EnemyWeapons[22]	= "Dagger 3 1";
	$EnemyArmor[22]		= "";
	$EnemyItems[22]		= "bluepotion 1r2 1r10 GnollHide 1r1 1r1";
	//conjurer
	$EnemyWeapons[23]	= "ShortSword 3 1";
	$EnemyArmor[23]		= "";
	$EnemyItems[23]		= "bluepotion 1r2 1r10";
	//paladin
	$EnemyWeapons[24]	= "Spear 3 1";
	$EnemyArmor[24]		= "";
	$EnemyItems[24]		= "bluepotion 1r2 1r10 energyvial 1r1 1r10";
	//reaper
	$EnemyWeapons[25]	= "Gladius 3 1";
	$EnemyArmor[25]		= "";
	$EnemyItems[25]		= "bluepotion 1r2 1r1 crystalenergyvial 1r1 1r5";
	//warlock
	$EnemyWeapons[26]	= "ShortSword 3 1";
	$EnemyArmor[26] 	= "";
	$EnemyItems[26]		= "ruby 1r1 1r200 EnergyVial 1r1 1r2";
	//Ruffian
	$EnemyWeapons[27]	= "BroadSword 2 1";
	$EnemyArmor[27]		= "";
	$EnemyItems[27]		= "Quartz 1r1 1r200";
	//Destroyer
	$EnemyWeapons[28]	= "SpikedClub 3 1";
	$EnemyArmor[28]		= "";
	$EnemyItems[28]		= "iron 1r1 1r1";
	//Halberdier
	$enemyWeapons[29]	= "BroadSword 3 1";
	$EnemyArmor[29]		= "";
	$EnemyItems[29]		= "BluePotion 1r3 1r10";
	//Dreadnought
	$enemyWeapons[30]	= "LongSword 2 1 ShortBow 3 1";
	$enemyArmor[30]		= "";
	$EnemyItems[30]		= "BasicArrow 10r20 1r1 coal 1r1 1r1";
	//Magi
	$EnemyWeapons[31]	= "ShortSword 2 1";
	$EnemyArmor[31]		= "";
	$EnemyItems[31]		= "Emerald 1r1 1r6000 Quartz 1r10 1r200";
	//Mauler
	$EnemyWeapons[32]	= "Mace 3 1";
	$EnemyArmor[32]		= "";
	$EnemyItems[32]		= "Granite 1r10 1r5";
	//Thrasher
	$enemyWeapons[33]	= "LongSword 3 1";
	$EnemyArmor[33] 	= "";
	$EnemyItems[33] 	= "Turquoise 1r1 1r300 iron 1r3 1r2";
	//Skeleton
	$EnemyWeapons[34]	= "LongSword 4 1";
	$EnemyArmor[34]		= "";
	$EnemyItems[34]		= "Opal 1r1 1r50 Iron 1r5 1r1 coal 1r1 1r5";
	//NecroMancer
	$EnemyWeapons[35]	= "Sling 3 1 Dagger 3 1";
	$EnemyArmor[35]		= "";
	$EnemyItems[35]		= "SmallRock 35r40 1r1 Diamond 1r1 1r3000 coal 1r2 1r1";
	

	customLoadouts(35); //35 just tells your custom function how many bots the base game has defined. Make absolutely sure you dont overwrite any, unless you really want to change some of their loadouts. I recommend that you pick numbers that would be high up so you wont have to come back and change them if more bot types are added to this def file. 
	
}

// ##################################### //
// ##################################### //
//               Shop NPCs               //
// ##################################### //
// ##################################### //

function DefineTownBots()
{

	//###################loadouts##################################### DEFINE BEFORE DEFINEING THE SPAWN!
	//$shop::loadout*[number (used for %shop above)] = "itemlist... ...";

// Keldrin Town Weapons shop
	$shop::loadoutweapons[0] 	= "Pickaxe Knife Dagger ShortSword Club QuarterStaff SpikedClub Hatchet WarAxe BroadSword Sling ShortBow";//weapons this merchant sells
	$shop::loadoutArmors[0] 	= "PaddedArmor LeatherArmor SpikedLeatherArmor BasicRobe LeatherBoots";//armor the merchant sells...
	$shop::loadoutItems[0]		= "BluePotion EnergyVial BasicArrow SmallRock";//items the merchant sells + misc stuff...

// Ethren Weapon Merchant
	$shop::loadoutweapons[1] 	= "Pickaxe Bardiche WarHammer WarMaul Claymore Katana BastardSword";

// Ethren Armor Merchant
	//$shop::loadoutArmors[2] 	= "LeatherArmor SpikedLeatherArmor";
	$shop::loadoutweapons[2] 		= "HammerPick BattleAxe Gladius WarMaul Trident BastardSword";
	$shop::loadoutItems[2]		= "BluePotion CrystalBluePotion EnergyVial CrystalEnergyVial";

// Mystery Merchant
	$shop::loadoutweapons[3] 	= "GreatClaymore";

// Barracks
	$shop::loadoutweapons[4] 	= "Gladius";

//Delkin merchant
	$shop::loadoutweapons[5] 	= "ShortSword Spear SpikedClub Mace BroadSword Longsword ShortBow LightCrossbow";
	$shop::loadoutarmors[5]		= "";
	$shop::loadoutItems[5]		= "BluePotion CrystalBluePotion EnergyVial";

//jaten merchant

	$shop::loadoutweapons[6] 	= "HammerPick BattleAxe Gladius";
	$shop::loadoutarmors[6]		= "";
	$shop::loadoutitems[6]		= "BluePotion EnergyVial";
	//spawnTownBot(%pos, %team, %type,%race , %shop , %name)
	//team 1 is human...
	//type is Merchant.. more to come later
	//%transform is the x y z rx ry nsz rz coord of the merchant rx ry and rz is the rotation you want to set the z axis rotation... nsz is something weird also used in rotation ... rotation is in radians
	//use the admin command #gettransform to figure out the rotation..
	
	
// Keldrin Town Merchant
	spawnTownBot("-332.496 952.588 51.6751 0 0 1 171.887", 1, "Merchant", "MaleHuman",0,"Town Merchant");

//Keldrin Banker
	spawnTownbot("-323.278 951.544 51.6752 0 0 1 3", 1, "Bank", "MaleHuman", 0, "Banker");
	
// Ethren Weapon Merchant
	//spawnTownBot("286.289 -257.365 45.2258 0 0 1 199.841", 1, "Merchant", "MaleHuman",1,"Weapons Merchant");


// Ethren Armor Merchant
	spawnTownBot("282.646 -268.252 46 0 0 1 23.2416", 1, "Merchant", "MaleHuman",2,"Armor Merchant");
	spawnTownBot("281.703 -271.054 74.0168 0 0 1 0", 1, "Bank", "MaleHuman", 0, "Ethren Banker");

// Mystery Merchant
	//spawnTownBot("1490.12 1182.97 53.6898 0 0 -1 59.4933", 1, "Merchant", "MaleHuman",3,"Mysterious Man");

// Barracks
	//spawnTownBot("-356.012 202.856 129.421 0 0 1 90.2093", 1, "Merchant", "MaleHuman",4,"Old Warrior");
//Delkin Merchant
	spawnTownBot("-1539 1545.22 92 0 0 1 1.91409", 1, "Merchant", "MaleHuman", 5, "Delkin Merchant");
//Delkin Banker
	spawnTownBot("-1495.14 1534.54 91.5668 0 0 -1 1.4342", 1, "Bank", "MaleHuman", 0, "Delkin Banker");
//jaten banker
	spawnTownBot("-2742.07 1355.07 62.4689 0 0 1 0", 1, "Bank", "MaleHuman", 0, "Banker");
//jaten merchant
	spawnTownBot("-2834.62 1227.5 68.8091 0 0 1 0", 1, "Merchant", "MaleHuman", 6, "Jaten Merchant");
//Guild master dude
	spawnTownBot("419.742 -163.515 179.373 0 0 1 2.13914", 1, "Guild", "MaleHuman", 0, "Guild Register");
	
//arena dude
	spawnTownBot("47.0899 107.787 68.7241 0 0 -1 1.59045", 1, "Porter", "MaleHuman", 0, "Arena Attendant");



	//QUESTS!.
	//note when anyone says anything within the radius of this bot, functioncall will be called like this
	//quest[function](%botid, %client, %text), from there the quest bot will operate. All questing functions should be defined in the mission cs file.
	//over time i will create a bunch of simple support functions for these bots.
	//NOTE: all functions called by quest bots will always start with QUEST see example	
	//example
	//spawnquestbot( "1032 309 123", 1, "MaleHuman", "newbiebottalk", "helper", "FirstQuest"); //syntax note spawnquestbot(%transform, %team, %race, %function, %botname, %questname); note: %questname must be one word.
	//function Questnewbiebottalk(%botid, %client, %text)	

	//quest specific functions. Please only use these functions and the quest object when creating your quests. More functions will be added at a later date. 
	//isgreeting(%text) returns either true or false if the text message is a greeting.
	//Quest Object:
	//Functions (%this is just the quest object, when calling these functions use the (.) operator example %quest.respond(%botid, %client, "something");, note how you dont specify the %this.
	//Quest::GetState(%this, %botid, %client);
	//Quest::setState(%this, %botid, %client, %state);
	//Quest::Respond(%this, %botid, %client, %message);
	//Quest::ClientHasItem(%this, %client, %item, %amount);
	//Quest::TakeItem(%this, %botid, %client, %item, %amount);
	//Quest::GiveItem(%this, %botid, %client, %item, %prefix, %suffix, %amount); 
	//Quest::GiveReward(%this, %botid, %client, %reward);//%reward is a stuffstring.Note: Do not give exp as an award.
	//Quest::GetBotByIndex(%this, %index); // returns the botid of the quest bot in the same group. The first one spawned will have an index of 1, second one spawned will have an index of 2. This is useful if you have a quest with multiple questbots.
	spawnquestbot("-307.007 944.572 57 0 0 -1 0.0967409", 1, "MaleHuman", "Test", "Old Man", "FirstQuest");
	customTownBots(); //loaded in custom file
}
function QuestTest(%quest, %botid, %client, %text)
{
	if(%quest.getState(%botid, %client) == 0)
	{
		if(isgreeting(%text))
		{
			%quest.respond(%botid, %client, "Hello adventurer! Are you looking for a quest? [yes or no]");
			%quest.setState(%botid, %client, 1);
		}
	}
	else if(%quest.getstate(%botid, %client) == 1)
	{
		if(%text $= "yes")
		{
			%quest.respond(%botid, %client, "Good! I used to be a miner back in my day, however... my age has not been kind to me as of late. Could you retrieve one quartz and one topaz for me please? [yes or no]");
			%quest.setState(%botid, %client, 2);
		}
		else if(%text $= "no")
		{
			%quest.respond(%botid, %client, "Get out of my sight then!");
			%quest.setState(%botid, %client, 0);
		}
		else if(isgreeting(%text))
		{
			%quest.respond(%botid, %client, "Hello adventurer! Are you looking for a quest? [yes or no]");
		}
	}
	else if(%quest.getState(%botid, %client) == 2)
	{
		if(%text $= "yes")
		{
			%quest.respond(%botid, %client, "YES! Thank you very much, come say hi to me when you get the items!");
			%quest.setstate(%botid, %client, 3);
		}
		else if( %text $= "no")
		{
			%quest.setstate(%botid, %client, 0);
			%quest.respond(%botid, %client, "How dare you waste my time! Away with you!");
		}
		else if(isgreeting(%text))
		{
			//it's a good idea to allow the bot to repeat the last thing he said if the user logs off and logs back on and has no clue where he left off.
			%quest.respond(%botid, %client, "Will you get one topaz and one quartz for me please? [yes or no]");
		}
	}
	else if(%quest.getstate(%botid, %client) == 3)
	{
		if(isgreeting(%text))
		{
			if( %quest.clienthasitem(%client, "Quartz", 1) && %quest.clienthasitem(%client, "Opal", 1) )
			{
				%quest.TakeItem(%botid, %client, "Quartz", 1);
				%quest.TakeItem(%botid, %client, "Opal", 1);
				%quest.respond(%botid, %client, "Wow! You got it! Thank you very much. Take this as a reward!");
				%quest.givereward(%botid, %client, "SP 10");
				%quest.setstate(%botid, %client, 4);
			}
			else
			{
				%quest.respond(%botid, %client, "I am still waiting for the topaz and quartz!");
			}
		
		}
	}
	else if(%quest.getstate(%botid, %client) == 4)
	{
		if(isgreeting(%text))
		{
			%quest.respond(%botid, %client, "Sorry, I do not need your help anymore.");
		}
	}
}

function DefineZoneSpecifications()
{

	//---------------------------------------------------------------------------------------
	//	RaceZoneStrings[Client entering's RaceID, Zone being entered's RaceID, n]

	//DeathKnight entering zones
	$RaceZoneStrings[1, 1, 1] = "This area is DeathKnight territory.";
	$RaceZoneStrings[1, 2, 1] = "This area is Human territory.";
	$RaceZoneStrings[1, 3, 1] = "This area is Orc territory.";
	$RaceZoneStrings[1, 4, 1] = "This area is Elven territory.";
	$RaceZoneStrings[1, 5, 1] = "This area is Goblin territory.";
	$RaceZoneStrings[1, 6, 1] = "This area is Gnoll territory.";
	$RaceZoneStrings[1, 7, 1] = "This area is Ogre territory.";
	$RaceZoneStrings[1, 8, 1] = "This area is Wild Orc territory.";
	$RaceZoneStrings[1, 9, 1] = "This area is Undead territory.";
	$RaceZoneStrings[1, 10, 1] = "This area is Minotaur territory.";

	//Human entering zones
	$RaceZoneStrings[2, 1, 1] = "In this area dwell much higher powers.";
	$RaceZoneStrings[2, 2, 1] = "This area feels like home.";
	$RaceZoneStrings[2, 3, 1] = "This area is Orcish in nature.";
	$RaceZoneStrings[2, 3, 2] = "This area is infested with Orcs.";
	$RaceZoneStrings[2, 4, 1] = "Elves appear to inhabit this area.";
	$RaceZoneStrings[2, 5, 1] = "This place smells of goblins.";
	$RaceZoneStrings[2, 6, 1] = "It appears many gnolls wander here.";
	$RaceZoneStrings[2, 7, 1] = "You can hear the sounds of hungry ogres.";
	$RaceZoneStrings[2, 8, 1] = "This area is Orcish in nature, but the smell is intolerable.";
	$RaceZoneStrings[2, 9, 1] = "The inhabitants of this area are void of life.";
	$RaceZoneStrings[2, 10, 1] = "Here dwell the dangerous minotaur.";



	customZoneSpecifications();


}

function DefineMiningPoints()
{
	//CreateMiningSpot("x y z", [Multiplier]) the x y z is the pos and the multiplyer determines how fast it will spawn rocks, 0 is increadably fast dont use that
	//1 is normal, .5 is twice as fast .25 is four times as fast and so on. 2 is twice as long, 4 is 4x long and so on. 
	CreateMiningSpot("-1037.09 495.774 139.376",1);
	CreateMiningSpot("-1169.51 588.677 105",1);
	CreateMiningSpot("-1075.57 630.961 133",2);
	CreateMiningSpot("-1083 596 133", 2);
	CustomMiningPoints();

}
//This adds Env mapping to the Minotaur's Lair marble textures
addMaterialMapping("MinoLair/Mino_Marble", "environment: Minolair/Mino_Emap 0.20"); 
addMaterialMapping("MinoLair/Mino_OldRoof", "environment: Minolair/Mino_Emap 0.20"); 
addMaterialMapping("MinoLair/Mino_OldRoof2", "environment: Minolair/Mino_Emap 0.20"); 
addMaterialMapping("MinoLair/Mino_MossMarble", "environment: Minolair/Mino_Emap 0.20"); 
addMaterialMapping("ISTextures/F_KWater", "environment: RPGSky/RPG_emap 0.20");
addMaterialMapping("ISTextures/F_Bars", "environment: Minolair/Mino_Emap 0.30");
addMaterialMapping("terrain/RPG_grass1", "color: 0.4 0.325 0.243 1.0 0.0"); 
exec("scripts/rpgpropmap.cs");
//custom quests should be loaded in this file! if the file does not exist go ahead and create it. This way when the map updates clients wont have to restart custom quests.
//also you can put the following functions in this file to add on things to the map and keep them when the dev team updates this file: customzonespecifications, customloadouts, customaispawn, customtownbots, customminingpoints. Put quests in customtownbots
exec("missions/custom/T2RPG_Worldmap_custom.cs");