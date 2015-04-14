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
	createAISpawn("255.689 -253.689 55.21", "0 0 0", 100, 900, "5",1,2);

	$AI::AttackPos[3,0] = "256.042 -250.623 51.21267";
	$AI::AttackPos[9,0] = "256.042 -252.623 55.21267";
	$AI::AttackPos[9,1] = "255.689 -255.689 55.21";
	createAISpawn("256.042 -250.623 55.21267", "0 0 0", 100, 900, "5",1,3);
	//createAISpawn("256.042 -252.623 55.21267", "0 0 0", 300, 600, "5",1,9);
	//createAISpawn("255.689 -255.689 55.21", "0 0 0", 300, 600, "5",1,9);
	
	$AI::AttackPos[4,0] = "-362.205 956.154 51.3047";
	createAISpawn("-362.205 956.154 55.3047", "0 0 0", 5, 10, "5", 1, 4);
	
// Fish Spawn points (6)
	//createAISpawn("-592 855 10", "1 1 10", 50, 200, "6",1,0);
	//createAISpawn("-590 857 10", "1 1 10", 50, 200, "6",1,0);
	//createAISpawn("-594 855 10", "1 1 10", 50, 200, "6",1,0);
	//createAISpawn("-598 855 10", "1 1 10", 50, 200, "6",1,0);
	createAISpawn("-600 855 10", "1 1 10", 50, 200, "6",1,0);
	//createAISpawn("-602 855 10", "1 1 10", 50, 200, "6",1,0);
	createAISpawn("-604 855 10", "1 1 10", 50, 200, "6",1,0);
	//createAISpawn("-606 855 10", "1 1 10", 50, 200, "6",1,0);
	createAISpawn("-608 855 10", "1 1 10", 50, 200, "6",1,0);
	//createAISpawn("-610 855 10", "1 1 10", 50, 200, "6",1,0);
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
 
    //Training Dummies (36)
    createAISpawn("-472.653 845.748 51.884", "0 0 0", 5, 5, "36", 5, 0);
    createAISpawn("-458.765 853.93 52.09", "0 0 0", 5, 5, "36", 5, 0);
    createAISpawn("-456.07 823.741 52.09", "0 0 0", 5, 5, "36", 5, 0);
    
    //Sartopia
    createAISpawn("375.015 299.208 1579.4", "0 0 0", 15, 20, "37 38", 5, 0);
    createAISpawn("354.771 328.233 1579.57", "0 0 0", 15, 20, "37 38", 5, 0);
    createAISpawn("303.872 294.013 1578.74", "0 0 0", 15, 20, "37 38", 5, 0);
    createAISpawn("354.771 328.233 1579.57", "0 0 0", 15, 20, "37 38", 5, 0);
    createAISpawn("254.665 359.866 1579.53", "0 0 0", 15, 20, "37 38", 5, 0);
    createAISpawn("244.141 318.594 1569.69", "0 0 0", 15, 20, "37 38", 5, 0);
    createAISpawn("227.196 266.107 1555.47", "0 0 0", 15, 20, "37 38", 5, 0);
    createAISpawn("206.374 223.413 1555.46", "0 0 0", 15, 20, "37 38", 5, 0);
    createAISpawn("440.071 249.91 1554.14", "0 0 0", 15, 20, "37 38", 5, 0);
    createAISpawn("252.174 96.584 1554.18", "0 0 0", 15, 20, "37 38", 5, 0);
    
    createAISpawn("471.895 364.563 1872.72", "0 0 0", 30, 35, "39", 5, 0, 1);

    //Heven
    createAISpawn("923.9 595.8 285.9", "0 0 0", 20, 30, "40", 5, 0, 0);
    createAISpawn("911.7 619.41 285.9", "0 0 0", 20, 30, "40 41", 5, 0, 0);
    createAISpawn("926.16 652.15 288.85", "0 0 0", 20, 30, "40 41", 5, 0, 0);
    createAISpawn("940.72 595.17 290.1", "0 0 0", 20, 30, "42", 5, 0, 0);
    createAISpawn("938 585.4 283.1", "0 0 0", 20, 30, "40 41", 5, 0, 0);
    createAISpawn("942.01 543.232 288.85", "0 0 0", 20, 30, "40 41", 5, 0, 0);
    createAISpawn("956.389 542.723 288.847", "0 0 0", 20, 30, "40 41", 5, 0, 0);
    createAISpawn("964.039 550.817 285.845", "0 0 0", 20, 30, "40 41", 5, 0, 0);
    createAISpawn("953.171 574.524 291.865", "0 0 0", 20, 30, "40 41", 5, 0, 0);
    createAISpawn("954.134 614.056 291.844", "0 0 0", 20, 30, "42", 5, 0, 0);
    createAISpawn("901.87 596.495 300.974", "0 0 0", 20, 30, "42", 5, 0, 0);
    createAISpawn("975.809 598.365 308.102", "0 0 0", 20, 30, "42", 5, 0, 0);
    createAISpawn("935.633 647.122 306.717", "0 0 0", 20, 30, "42", 5, 0, 0);

    createAISpawn("681.486 392.996 403.836", "0 0 0", 30, 35, "43", 5, 0, 1);
    
    // Voltrue
    createAISpawn("-1517.27 -955.275 -257.1", "0 0 0", 30, 35, "44", 5, 0, 0);
    createAISpawn("-1510.62 -966.915 -274", "0 0 0", 30, 35, "44", 5, 0, 0);
    createAISpawn("-1474.29 -937.454 -274.5", "0 0 0", 30, 35, "45", 5, 0, 0);
    createAISpawn("-1434.24 -871.654 -275.3", "0 0 0", 30, 35, "45", 5, 0, 0);
    createAISpawn("-1329.92 -1143.83 -316.7", "0 0 0", 30, 35, "44", 5, 0, 0);
    createAISpawn("-1345.5 -1159.09 -300", "0 0 0", 30, 35, "45", 5, 0, 0);
    createAISpawn("-1357.21 -1076.52 -299", "0 0 0", 30, 35, "45", 5, 0, 0);
    createAISpawn("-1568.33 -1111.62 -306", "0 0 0", 30, 35, "46", 5, 0, 0);
    createAISpawn("-1504.07 -1075.64 -307.2", "0 0 0", 30, 35, "45", 5, 0, 0);
    createAISpawn("-1499.48 -1148.56 -307.2", "0 0 0", 30, 35, "45", 5, 0, 0);
    createAISpawn("-1496.5 -1242.67 -367", "0 0 0", 30, 35, "46", 5, 0, 0);

    // Voltrue Bosses
    createAISpawn("-1287.32 -672.304 -411.4", "0 0 0", 30, 35, "47", 5, 0, 1);
    createAISpawn("-1498.27 -1373.12 -426", "0 0 0", 30, 35, "48", 5, 0, 1);
    createAISpawn("-1124.26 -1267.6 -450.7", "0 0 0", 30, 35, "49", 5, 0, 1);
    
    //Myrklure
    createAISpawn("-161.3 1540.5 12", "0 0 0", 30, 35, "50 51", 5, 0, 0);
    createAISpawn("-188.12 1543.5 12", "0 0 0", 30, 35, "50 51", 5, 0, 0);
    createAISpawn("-158.2 1557.9 -18.7", "0 0 0", 30, 35, "50 51", 5, 0, 0);
    createAISpawn("-156.57 1541.7 -26.8", "0 0 0", 30, 35, "50 51", 5, 0, 0);
    createAISpawn("-165.592 1599.9 -43.9", "0 0 0", 30, 35, "50 51", 5, 0, 0);
    createAISpawn("-197.4 1584.7 -43.9", "0 0 0", 30, 35, "50 51 52", 5, 0, 0);
    createAISpawn("-191.7 1549.8 -43.9", "0 0 0", 30, 35, "50 51 52", 5, 0, 0);
    createAISpawn("-167.5 1474.8 -43.9", "0 0 0", 30, 35, "52 53", 5, 0, 0);
    createAISpawn("-216.1 1540.9 -34.9", "0 0 0", 30, 35, "52 53", 5, 0, 0);
    createAISpawn("-215.3 1567.6 -18.9", "0 0 0", 30, 35, "53", 5, 0, 0);
    createAISpawn("-97.5 1503.1 44", "0 0 0", 30, 35, "54", 5, 0, 0);
                                                                            
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
 
    $MinHP[Flasix] = 150000;
    $MinHP[Castran] = 220000;
    $MinHP[Magmus] = 500000;
    $MinHP[Navegus] = 750000;
    $MinHP[Verlium] = 80000;

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
    $EnemyProfile[Dummy] = "LVL 1r1 CLASS Fighter";
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
	$EnemyProfile[Guardian] = "LVL 90r100 CLASS Fighter COINS 300r600";
	$EnemyProfile[Reaper]	= "LVL 93r103 CLASS Mage COINS 300r650";
//Elf
	$EnemyProfile[Protector] = "LVL 45r55 CLASS Fighter COINS 1r60";
	$EnemyProfile[Peacekeeper] = "LVL 48r58 CLASS Fighter Coins 1r80";
	$EnemyProfile[Lord]		= "LVL 50r60 CLASS Fighter Coins 1r100";
	$EnemyProfile[Champion]		= "LVL 52r62 CLASS Fighter Coins 20r120";
	$EnemyProfile[Conjurer]		= "LVL 53r63 CLASS Mage COINS 30r100";

//travellers
	$EnemyProfile[Birgand]		= "LVL 65r70 CLASS Fighter COINS 30r40";
	$EnemyProfile[Marauder]		= "LVL 66r71 CLASS Fighter COINS 30r42";
	$EnemyProfile[Knight]		= "LVL 65r72 CLASS Fighter COINS 36r46";
	$EnemyProfile[Paladin]		= "LVL 70r72 CLASS Mage COINS 50r100";
//ogres
	$EnemyProfile[Ruffian]		= "LVL 20r24 CLASS Fighter COINS 12r30";
	$EnemyProfile[Destroyer]	= "LVL 22r33 CLASS Fighter COINS 23r34";
	$EnemyProfile[Halberdier]	= "LVL 29r33 CLASS Fighter COINS 13r39";
	$EnemyProfile[Dreadnought]	= "LVL 33r39 CLASS Fighter COINS 19r42";
	$EnemyProfile[Magi]		= "LVL 39r44 CLASS Mage COINS 25r75";
//undead
	$EnemyProfile[Mauler]		= "LVL 42r46 CLASS Fighter COINS 20r30";
	$EnemyProfile[Thrasher]		= "LVL 45r52 CLASS Fighter COINS 23r33";
//walking skeletons
	$EnemyProfile[Skeleton]		= "LVL 52r56 CLASS Fighter COINS 26r36";
	$EnemyProfile[Necromancer]	= "LVL 58r63 CLASS Fighter COINS 29r39";

//Heven
    $EnemyProfile[Wispwalker]   = "LVL 62r64 CLASS Ranger COINS 200r300";
    $EnemyProfile[Validad]      = "LVL 63r65 CLASS Ranger COINS 250r300";
    $EnemyProfile[Herfian]      = "LVL 65r66 CLASS Ranger COINS 250r300";
    $EnemyProfile[Verlium]      = "LVL 68r68 CLASS Ranger COINS 25000r30000";
    
//Voltrue
    $EnemyProfile[FireSpirit]	= "LVL 79r83 CLASS Mage COINS 400r800";
    $EnemyProfile[Pylonist]	    = "LVL 81r83 CLASS Mage COINS 400r800";
    $EnemyProfile[HellWalker]	= "LVL 84r86 CLASS Fighter COINS 400r800";
    
    $EnemyProfile[Flasix]	    = "LVL 84r84 CLASS Fighter COINS 4000r10000";
    $EnemyProfile[Castran]      = "LVL 85r85 CLASS Mage COINS 30000r45000";
    $EnemyProfile[Magmus]       = "LVL 87r87 CLASS Mage COINS 50000r75000";

//Sartopia
    $EnemyProfile[Twister]		= "LVL 97r104 CLASS Fighter COINS 400r800";
    $EnemyProfile[Cyclone]		= "LVL 100r109 CLASS Mage COINS 400r800";
    $EnemyProfile[Navegus]      = "LVL 110r110 CLASS Mage COINS 50000r75000";
    
//Myrklure
    $EnemyProfile[Seakeeper]    = "LVL 15r20 CLASS Fighter COINS 100r150";
    $EnemyProfile[Eel]          = "LVL 19r22 CLASS Ranger COINS 150r175";
    $EnemyProfile[Piranha]      = "LVL 24r27 CLASS Fighter COINS 125r190";
    $EnemyProfile[Torpedo]      = "LVL 24r27 CLASS Mage COINS 200r250";
    $EnemyProfile[Laviathena]   = "LVL 28r28 CLASS Mage COINS 500r750";



    $aiRace[Seakeeper]  = "EvilHuman";
    $aiRace[Eel]        = "EvilHuman";
    $aiRace[Piranha]    = "EvilHuman";
    $aiRace[Torpedo]    = "EvilHuman";
    $aiRace[Laviathena] = "EvilHuman";
    $aiRace[Dummy]      = "EvilHuman";
    $aiRace[Navegus]    = "EvilHuman";
    $aiRace[Twister]    = "EvilHuman";
    $aiRace[Cyclone]    = "EvilHuman";
    $aiRace[Wispwalker] = "EvilHuman";
    $aiRace[Validad]    = "EvilHuman";
    $aiRace[Herfian]    = "EvilHuman";
    $aiRace[Verlium]    = "EvilHuman";
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
    $SpawnIndex[36]     = "Dummy";
    
    $SpawnIndex[37]     = "Twister";
    $SpawnIndex[38]     = "Cyclone";
    $SpawnIndex[39]     = "Navegus";
    
    $SpawnIndex[40]     = "Wispwalker";
    $SpawnIndex[41]     = "Validad";
    $SpawnIndex[42]     = "Herfian";
    $SpawnIndex[43]     = "Verlium";
    
    $SpawnIndex[44]     = "FireSpirit";
    $SpawnIndex[45]     = "Pylonist";
    $SpawnIndex[46]     = "HellWalker";
    $SpawnIndex[47]     = "Flasix";
    $SpawnIndex[48]     = "Castran";
    $SpawnIndex[49]     = "Magmus";
    $SpawnIndex[50]     = "Seakeeper";
    $SpawnIndex[51]     = "Eel";
    $SpawnIndex[52]     = "Piranha";
    $SpawnIndex[53]     = "Torpedo";
    $SpawnIndex[54]     = "Laviathena";
    
    $AISpawn::Boss[39] = 1;
    $AISpawn::Boss[43] = 1;
    $AISpawn::Boss[47] = 1;
    $AISpawn::Boss[48] = 1;
    $AISpawn::Boss[49] = 1;
    $AISpawn::Boss[54] = 1;
	
	//attack behaviors
	//0 is default
	//1 is only attack enemies in its own zone, or enemies that hit him
    $attb[Dummy]        = 2;
    $attb[Seakeeper]    = 1;
    $attb[Eel]          = 1;
    $attb[Piranha]      = 1;
    $attb[Torpedo]      = 1;
    $attb[Laviathena]   = 1;
    $attb[Pylonist]     = 1;
    $attb[FireSpirit] 	= 1;
    $attb[HellWalker] 	= 1;
    $attb[Flasix] 	    = 1;
    $attb[Castran] 	    = 1;
    $attb[Magmus] 	    = 1;
    $attb[Wispwalker] 	= 1;
    $attb[Validad] 	    = 1;
    $attb[Herfian] 		= 1;
    $attb[Verlium] 		= 1;
    $attb[Twister] 		= 1;
    $attb[Cyclone] 		= 1;
    $attb[Navegus] 		= 1;
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
    $Bot::spellList[Wizard] = "bolt thorn fireball spikes";
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
    $Bot::spellList[Shaman] = "bolt thorn fireball firebomb";
	$Bot::Magic[Conjurer]	= 1;
    $Bot::spellList[Conjurer] = "bolt thorn fireball icespike icestorm firebomb melt ironfist watersurge cloud melt powercloud";
	$Bot::Magic[Paladin]	= 1;
    $Bot::spellList[Paladin] = "bolt thorn fireball icespike firebomb watersurge icestorm spikes melt ironfist cloud powercloud hellstorm beam";
	$Bot::Magic[Reaper]	= 1;
    $Bot::spellList[Reaper] = "bolt thorn fireball icespike firebomb watersurge icestorm spikes melt ironfist cloud powercloud hellstorm beam snowstorm dimensionrift";
	$Bot::Magic[Warlock]	= 1;
    $Bot::spellList[Warlock] = "bolt thorn fireball firebomb spikes icespike icestorm";
	$Bot::Magic[Ruffian] 	= 0;
	$Bot::Magic[Destroyer]	= 0;
	$Bot::Magic[Halberdier]	= 0;
	$Bot::Magic[Dreadnought]= 0;
	$Bot::Magic[Magi] 	= 1;
    $Bot::spellList[Magi] = "bolt thorn fireball icespike icestorm firebomb melt ironfist watersurge cloud melt";
	$Bot::Magic[Mauler]	= 0;
	$Bot::Magic[Thrasher]	= 0;
	$Bot::Magic[Skeleton]	= 0;
	$Bot::Magic[Necromancer]= 1;
    $Bot::spellList[Necromancer] = "bolt thorn fireball icespike firebomb watersurge icestorm spikes melt ironfist cloud powercloud";
    $Bot::Magic[Dummy] = 0;
    $Bot::Magic[Twister] = 0;
    $Bot::Magic[Cyclone] = 1;
    $Bot::spellList[Cyclone] = "icespike watersurge icestorm ironfist cloud powercloud snowstorm";
    $Bot::Magic[Navegus] = 1;
    $Bot::spellList[Navegus] = "icestorm ironfist powercloud snowstorm";
    $Bot::Magic[Wispwalker] 	= 1;
    $Bot::spellList[Wispwalker] = "thorn ironfist spikes";
    $Bot::Magic[Validad] 	= 0;
    $Bot::Magic[Herfian] 		= 0;
    $Bot::Magic[Verlium] 		= 1;
    $Bot::spellList[Verlium] = "thorn ironfist spikes cloud";
    $Bot::Magic[Pylonist] = 1;
    $Bot::spellList[Pylonist] = "fireball firebomb melt hellstorm beam";
    $Bot::Magic[Castran] = 1;
    $Bot::spellList[Castran] = "melt hellstorm beam";
    $Bot::Magic[FireSpirit] 	= 0;
    $Bot::Magic[HellWalker] 	= 0;
    $Bot::Magic[Flasix] 		= 0;
    $Bot::Magic[Magmus] 		= 1;
    $Bot::spellList[Magmus] = "melt ironfist powercloud hellstorm beam";
    $Bot::Magic[Seakeeper] 		= 0;
    $Bot::Magic[Eel] 		    = 0;
    $Bot::Magic[Piranha] 		= 0;
    $Bot::Magic[Torpedo] 		= 1;
    $Bot::spellList[Torpedo] = "icespike watersurge icestorm";
    $Bot::Magic[Laviathena]     = 1;
    $Bot::spellList[Laviathena] = "icespike watersurge icestorm ironfist";
    
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
	$EnemyItems[13] 	= "BluePotion 1r3 1r2 Opal 1r4 1r100 BasicArrow 10r15 1r1";
	//guardian
	$EnemyWeapons[14] 	= "BattleAxe 2 1";
	$EnemyArmor[14] 	= "";
	$enemyItems[14] 	= "DragonScale 1r1 1r10";
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
    //Dummy
	$EnemyWeapons[36]	= "";
	$EnemyArmor[36]		= "";
    $EnemyItems[36]		= "";
    //Twister
	$EnemyWeapons[37]	= "GreatClaymore 3 1";
	$EnemyArmor[37]		= "";
    $EnemyItems[37]		= "";
    //Cyclone
	$EnemyWeapons[38]	= "IceBroadsword 3 1";
	$EnemyArmor[38]		= "";
    $EnemyItems[38]		= "";
    //Navegus
	$EnemyWeapons[39]	= "LightningSword 6 1";
	$EnemyArmor[39]		= "";
    $EnemyItems[39]		= "";
    //Wispwalker
	$EnemyWeapons[40]	= "LightCrossbow 4 1 SpiritualDagger 1 1";
	$EnemyArmor[40]		= "";
    $EnemyItems[40]		= "ShortQuarrel 50r75 1r1";
    //Validad
	$EnemyWeapons[41]	= "NatureBow 3 1 SpiritualDagger 2 1";
	$EnemyArmor[41]		= "";
    $EnemyItems[41]		= "SpiritualArrow 35r50 1r1";
    //Herfian
	$EnemyWeapons[42]	= "NatureBow 5 1 SpiritualDagger 3 1";
	$EnemyArmor[42]		= "";
    $EnemyItems[42]		= "SpiritualArrow 45r60 1r1";
    //Verlium
	$EnemyWeapons[43]	= "SpiritualBow 6 1 SpiritualDagger 6 1";
	$EnemyArmor[43]		= "";
    $EnemyItems[43]		= "DarkSpectreArrow 75r100 1r1";
    //Fire Spirit
	$EnemyWeapons[44]	= "FireBroadsword 2 1";
	$EnemyArmor[44]		= "";
    $EnemyItems[44]		= "";
    //Pylonist
	$EnemyWeapons[45]	= "Dagger 4 1";
	$EnemyArmor[45]		= "";
    $EnemyItems[45]		= "";
    //Hell Walker
	$EnemyWeapons[46]	= "FireBroadsword 4 1";
	$EnemyArmor[46]		= "";
    $EnemyItems[46]		= "";
    //Flasix
	$EnemyWeapons[47]	= "FireBroadsword 5 1";
	$EnemyArmor[47]		= "";
    $EnemyItems[47]		= "";
    //Castran
	$EnemyWeapons[48]	= "Dagger 6 1";
	$EnemyArmor[48]		= "";
    $EnemyItems[48]		= "";
    //Magmus
	$EnemyWeapons[49]	= "FireBroadsword 6 1";
	$EnemyArmor[49]		= "";
    $EnemyItems[49]		= "";
    //Seakeeper
	$EnemyWeapons[50]	= "ShortSword 3 1";
	$EnemyArmor[50]		= "";
    $EnemyItems[50]		= "bluepotion 1r2 1r10 energyvial 1r1 1r10";
    //Eel
	$EnemyWeapons[51] 	= "ShortBow 2 1";
	$EnemyArmor[51] 	= "";
	$EnemyItems[51] 	= "BluePotion 1r3 1r2 Opal 1r4 1r100 BasicArrow 30r50 1r1";
    //Piranha
	$EnemyWeapons[52]	= "LongSword 3 1";
	$EnemyArmor[52]		= "";
    $EnemyItems[52]		= "Quartz 1r1 1r200";
    //Torpedo
	$EnemyWeapons[53]	= "ShortSword 3 1";
	$EnemyArmor[53]		= "";
    $EnemyItems[53]		= "bluepotion 1r2 1r10 crystalenergyvial 1r1 1r5";
    //Lavithena
	$EnemyWeapons[54]	= "WaterBroadsword 4 1";
	$EnemyArmor[54]		= "";
    $EnemyItems[54]		= "bluepotion 1r2 1r10 crystalenergyvial 1r1 1r5";

	customLoadouts(54); //35 just tells your custom function how many bots the base game has defined. Make absolutely sure you dont overwrite any, unless you really want to change some of their loadouts. I recommend that you pick numbers that would be high up so you wont have to come back and change them if more bot types are added to this def file.
	
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
	$shop::loadoutArmors[0] 	= "PaddedArmor LeatherArmor SpikedLeatherArmor StuddedLeatherArmor BasicRobe LeatherBoots";//armor the merchant sells...
	$shop::loadoutItems[0]		= "BluePotion EnergyVial BasicArrow SmallRock";//items the merchant sells + misc stuff...

// Ethren Weapon Merchant
	$shop::loadoutweapons[1] 	= "Pickaxe Bardiche WarHammer WarMaul Claymore Katana BastardSword";

// Ethren Armor Merchant
	$shop::loadoutArmors[2] 	= "BronzePlate HalfPlate FieldPlate FullPlate";
	$shop::loadoutweapons[2] 		= "HammerPick BattleAxe Gladius WarHammer Trident BastardSword";
	$shop::loadoutItems[2]		= "BluePotion CrystalBluePotion EnergyVial CrystalEnergyVial";

// Mystery Merchant
	$shop::loadoutweapons[3] 	= "GreatClaymore";

// Barracks
	$shop::loadoutweapons[4] 	= "Gladius";

//Delkin merchant
	$shop::loadoutweapons[5] 	= "ShortSword Spear SpikedClub Mace BroadSword Longsword ShortBow LightCrossbow";
	$shop::loadoutarmors[5]		= "ScaleMailBody BrigandineBody";
	$shop::loadoutItems[5]		= "BluePotion CrystalBluePotion EnergyVial";

//jaten merchant

	$shop::loadoutweapons[6] 	= "HammerPick BattleAxe Gladius";
	$shop::loadoutArmors[6]		= "HideArmor ChainMailBody RingMailBody BandedMailArmor SplintMailBody";
	$shop::loadoutitems[6]		= "BluePotion EnergyVial";
	
	
// Apprentice
	$shop::loadoutweapons[7] 	= "";
	$shop::loadoutarmors[7]		= "ApprenticeRobe LightRobe FineRobe";
	$shop::loadoutitems[7] 		= "";
// Mage Guild merchant
	$shop::LoadoutArmors[8]		= "BloodRobe AdvisorRobe";
	$shop::loadoutitems[8] 		= "";
	$shop::loadoutweapons[8]	= "";
	//spawnTownBot(%pos, %team, %type,%race , %shop , %name)
	//team 1 is human...
	//type 
	//Merchant is a merchant
	//bank is the banker
	//Porter is the arena porter
	//Guild is the guild registar. 
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

//Apprentice
	spawnTownBot("-345.534 207.509 134.986 0 0 1 3.25385", 1, "Merchant", "MaleHuman", 7, "Apprentice");

//Ktown Boat Dude
	spawnTownBot("-534.049 1156.74 49.5689 0 0 1 1.98489", 1, "Boat", "MaleHuman", "Keldrin", "George");
//Ethren Boat Dude
	spawnTownBot("-111.542 -430.296 49.6485 0 0 1 1.20955", 1, "Boat", "MaleHuman", "Ethren", "Tom");
//Delkin Boat Dude
	spawnTownBot("-1519.24 1520.42 91.565 0 0 0.999994 0.131746", 1, "Boat", "MaleHuman", "Delkin", "Bill");
//Jaten Boat Dude
	spawnTownBot("-2664.15 1183.22 49.9633 0 0 -1 0.842143", 1, "Boat", "MaleHuman", "Jaten", "Chris");
//Snowblind Boat Dude
	spawnTownBot("4534.252 -2510.4 50.81 0 0 -1.00015 0.0231716", 1, "Boat", "MaleHuman", "Snowblind", "Alex");
//GuildMage Merchant
	spawnTownBot("2132.84 92.9041 93.3237 0 0 -1 0.0337519", 1, "Merchant", "MaleHuman", 8, "Jerry");
	//-2665.44 1184.03 49.9734 0 0 -1 0.974081
	//QUESTS!.
	//note when anyone says anything within the radius of this bot, functioncall will be called like this
	//quest[function](%quest, %botid, %client, %text), from there the quest bot will operate. All questing functions should be defined in the mission cs file.
	//over time i will create a bunch of simple support functions for these bots.
	//NOTE: all functions called by quest bots will always start with QUEST see example	
	//example
	//spawnquestbot( "1032 309 123", 1, "MaleHuman", "newbiebottalk", "helper", "FirstQuest"); //syntax note spawnquestbot(%transform, %team, %race, %function, %botname, %questname); note: %questname must be one word.
	//function Questnewbiebottalk(%quest, %botid, %client, %text)	

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
	
	spawnquestbot("-342.667 963.046 52 0 0 1 1.5663", 1, "MaleHuman", "Message", "Sean", "DeliveryQuest");
	spawnquestbot("-2846.8 1366.72 65 0 0 1 3.72164", 1, "MaleHuman", "Message2", "Garren", "DeliveryQuest");
 
    spawnquestbot("-1458.86 -993.598 155.268 0 0 -1 1.53876", 1, "MaleHuman", "FireTemple", "Mervis", "FinalBossQuest");
    spawnquestbot("-353.906 927.342 56.9243 0 0 0.999 0.1815", 1, "MaleHuman", "PhantomRPG", "Unknown Archmage", "LegendQuest");

    spawnquestbot("776.08 -1804.62 278.594 0 0 -1 1.5637", 1, "MaleHuman", "SnowblindInvestigation", "Lord Richard", "SnowblindQuest1");
    spawnquestbot("-339.026 922.244 51.673 0 0 1 3.61714", 1, "MaleHuman", "SnowblindInvestigation2", "Navegus", "SnowblindQuest1");

	//Phantom139: New Bots
    $AITalkMessage["Warrior Andrew", 0] = "Hello %n, This is the training zone. I highly recommend you prepare yourself before heading off into the world";
    spawntownbot("-430.935 822.297 51.514 0 0 1 0.305074", 1, "BaseNPC", "MaleHuman", 0, "Warrior Andrew");
    $AITalkMessage["Warrior Andrew", 1] = "Hello %n, I was trying to get into Myrklure, but the water is so tough to navigate through, Perhaps this is the plan of the Water Guardian to test potential challengers. Be cautious if you proceed...";
    spawntownbot("-183.481 1455.11 50.9808 0 0 0.999999 0.334985", 1, "BaseNPC", "MaleHuman", 1, "Warrior Andrew");
    $AITalkMessage["Lord Ethren", 1] = "%n, you have great power in this world, however the most noble and wisest of the Guardians awaits in his sky temple. To challenge him is a task I must advise you to avoid unless you are truly prepared for the clash of champions...";
    spawntownbot("460.1 140.88 215.254 0 0 -1 0.68952", 1, "BaseNPC", "MaleHuman", 1, "Lord Ethren");
    $AITalkMessage["Verlium", 0] = "Greetings %n, Welcome to my temple. You are obviously here seeking the Earth element, however I am not just going to hand it to you. Prove your worth to me and defeat me upon the snowy peak, and I shall give it to you.";
    spawntownbot("811.338 524.328 186.717 0 0 -1 1.58115", 1, "BaseNPC", "MaleHuman", 0, "Verlium");
    $AITalkMessage["Verlium", 1] = "This place, is filled with great evil %n. I must caution you, the minotaurs who lurk this labrynith are extremely unforgiving to those who find themselves lost within.";
    spawntownbot("708.701 1174.76 170.153 0 0 1 3.49912", 1, "BaseNPC", "MaleHuman", 1, "Verlium");
    $AITalkMessage["Captain Jacob", 0] = "This building has been corrupted with the evil of orcs %n... I only wish to bring upon their destruction...";
    spawntownbot("-1147.96 661.493 282.924 0 0 1 2.29494", 1, "BaseNPC", "MaleHuman", 0, "Captain Jacob");
    $AITalkMessage["Ethren Scout", 0] = "Yolanda... just the word itself gives me the shivers....";
    spawntownbot("-1150.74 644.062 286.174 0 0 1 1.7963", 1, "BaseNPC", "MaleHuman", 0, "Ethren Scout");
    $AITalkMessage["Kzukuria", 0] = "Human!! You must help us. My bretheren have been corrupted by the dark magma lord Magmus... we must stop them before all of orckind is put at risk.";
    spawntownbot("-1116.96 653.92 286.76 0 0 1 3.26643", 1, "BaseNPC", "MaleOrc", 0, "Kzukuria");
    $AITalkMessage["Keldrin Miner", 0] = "Ever since those knolls and orcs took over the mines, Keldrin has been facing a major resource crisis.... we really need someone like you to help us.";
    spawntownbot("-979.792 633.969 136.846 0 0 1 4.18059", 1, "BaseNPC", "MaleHuman", 0, "Keldrin Miner");
    $AITalkMessage["Ethren Scout", 1] = "Hello %n, looking to take on some orcs? Well... if you head down the path to my left, you'll hit the mines with some weak runts.. the path to my right, leads to Yolanda....";
    spawntownbot("-641.558 515.182 51.1776 0 0 1 0.668349", 1, "BaseNPC", "MaleHuman", 1, "Ethren Scout");
    $AITalkMessage["Navegus", 0] = "Interesting... you're tougher than you look %n, maybe you are worthy to hold my air element, after all you did defeat Magmus, but I will be your final test for that... step forth if you are prepared for a real challenge friend....";
    spawntownbot("473.266 104.474 1552.58 0 0 -1 1.53234", 1, "BaseNPC", "MaleHuman", 0, "Navegus");
    $AITalkMessage["Keldrin Barkeep", 0] = "Hey %n, people have been saying that that fellow over there is some very powerful magician... You might want to talk to him if you're interested in some ancient power, so I hear.";
    spawntownbot("-340.448 919.352 56.9211 0 0 1 4.17416", 1, "BaseNPC", "MaleHuman", 0, "Keldrin Barkeep");
    $AITalkMessage["Keldrin Citizen", 0] = "Ever since Magmus arrived, darkness has been spreading, a hero really needs to step up to destroy his evil.";
    spawntownbot("-339.115 934.519 51.3006 0 0 1 1.33707", 1, "BaseNPC", "MaleHuman", 0, "Keldrin Citizen");
    $AITalkMessage["Keldrin Citizen", 1] = "Welcome to Keldrin, %n. Alot has changed since the darkness has begun to spread.... this place has lost the energy it used to contain.";
    spawntownbot("-314.21 914.668 51.294 0 0 1 1.52469", 1, "BaseNPC", "MaleHuman", 1, "Keldrin Citizen");
    $AITalkMessage["Mage Joseph", 0] = "I sense dark magic here %n. This must be the work of necromancers.... those damned Magmus followers... you should go in there and slay them all.";
    spawntownbot("-853.595 -1003.11 75.0954 0 0 1 3.74101", 1, "BaseNPC", "MaleHuman", 0, "Mage Joseph");
    $AITalkMessage["Verlium", 2] = "You have come far %n, Magmus lies within his great fire temple Voltrue, however it lies in an alternate realm of fire. You must be at your full potential if you want to emerge victorious.";
    spawntownbot("-1475.68 -997.037 155.268 0 0 1 1.16306", 1, "BaseNPC", "MaleHuman", 2, "Verlium");
    $AITalkMessage["Mage Joseph", 1] = "Listen %n, I want Magmus gone, but attacking him in his own realm is suicide! Please.... you must be very careful...";
    spawntownbot("-1475.69 -984.697 155.266 0 0 1 4.13975", 1, "BaseNPC", "MaleHuman", 1, "Mage Joseph");
    $AITalkMessage["Navegus", 2] = "Hello again %n, I am guardian of the sky temple Sartopia. Magmus has been corrupted by a dark power, and he must be defeated. If you want to enter, speak to my advisary next to me, he will grant you the crystal of fire.";
    spawntownbot("-1460.26 -984.344 155.266 0 0 1 4.08923", 1, "BaseNPC", "MaleHuman", 2, "Navegus");
    $AITalkMessage["Lost Townsman", 0] = "Where.... Where am I??? Something strange happened to this place. Some kind of dark portal opened, and then we were here... Please... Find the portal and cose it!!!";
    spawntownbot("-1508.7 -1083.38 -233.073 0 0 -0.999995 0.0990289", 1, "BaseNPC", "MaleHuman", 0, "Lost Townsman");
    $AITalkMessage["Revered Spirit Castran", 0] = "You may have power %n, but when Magmus is done with you, I will finish with you here myself...";
    spawntownbot("-1472.06 -1078.45 -227.805 0 0 -1 1.01309", 1, "BaseNPC", "MaleHuman", 0, "Revered Spirit Castran");
    $AITalkMessage["Old Guard", 0] = "Hello Sir %n. We cannot allow you inside since the flame storm lies above, please find a way to destroy it.";
    spawntownbot("-1511.47 -1171.58 -230.992 0 0 -1.00013 0.00229024", 1, "BaseNPC", "MaleHuman", 0, "Old Guard");
    $AITalkMessage["Old Guard", 1] = "Hello Sir %n. We cannot allow you inside since the flame storm lies above, please find a way to destroy it.";
    spawntownbot("-1509.5 -1171.58 -230.992 0 0 -1.00013 0.00229024", 1, "BaseNPC", "MaleHuman", 1, "Old Guard");
    $AITalkMessage["Old Guard", 2] = "Sir, this structure is not safe for entry since the dark portal pulled us in, please leave.";
    spawntownbot("-1510.2 -1200.53 -230.992 0 0 1 3.14295", 1, "BaseNPC", "MaleHuman", 2, "Old Guard");
    $AITalkMessage["Lord Helvic", 0] = "So %n, you are the hero the prophecy spoke of... I think you know what to do here, this dark portal must be destroyed... one way, or another.";
    spawntownbot("-1510.83 -1154.72 -233.089 0 0 1 0.268648", 1, "BaseNPC", "MaleHuman", 0, "Lord Helvic");
    $AITalkMessage["The Ringmaster", 0] = "I'm completely lost, one day I'm preparing to set up shot here in this nice town for a performance, the next, I'm trapped in this dark realm.";
    spawntownbot("-1540.61 -1131.2 -233.091 0 0 -1 0.6688", 1, "BaseNPC", "MaleHuman", 0, "The Ringmaster");

    $AITalkMessage["Snowblind Citizen", 0] = "This place is so cold, and the night it seemed so long. I can't even remember the last time it was sunny here.";
    spawntownbot("700.29 -1821.55 273.442 0 0 -1 2.07883", 1, "BaseNPC", "MaleHuman", 0, "Snowblind Citizen");

	customTownBots(); //loaded in custom file
}

function QuestSnowblindInvestigation(%quest, %botid, %client, %text) {
	if(%quest.getState(%botid, %client) == 0) {
		if(isgreeting(%text)) {
			%quest.respond(%botid, %client, "I don't believe my eyes... There really is a new person in town. This is... unbelievable to say the least [what]");
			%quest.setState(%botid, %client, 1);
		}
    }
    else if(%quest.getstate(%botid, %client) == 1) {
        if(isgreeting(%text)) {
            %quest.respond(%botid, %client, "I don't believe my eyes... There really is a new person in town. This is... unbelievable to say the least [what]");
        }
        else if(%text $= "what") {
            %quest.respond(%botid, %client, "To be honest, I haven't told the others. Something has kept our town hidden for over 1000 years. Nobody has aged a day, and it was of eternal night here... Something has happened, will you investigate for us? [yes or no]");
			%quest.setState(%botid, %client, 2);
        }
    }
    else if(%quest.getstate(%botid, %client) == 2) {
        if(%text $= "yes") {
            %quest.respond(%botid, %client, "Thank you. Now, Snowblind used to be watched over by a powerful elemental guardian, Navegus.. I think his name was. Perhaps he might know something?");
			%quest.setState(%botid, %client, 3);
        }
        else if(%text $= "no") {
			%quest.respond(%botid, %client, "That's disappointing, we really need someone to find out what happened to our village, and what about the rest of the world.");
			%quest.setState(%botid, %client, 2);
		}
		else if(isgreeting(%text)) {
			%quest.respond(%botid, %client, "To be honest, I haven't told the others. Something has kept our town hidden for over 1000 years. Nobody has aged a day, and it was of eternal night here... The light has returned so something happened, will you investigate for us? [yes or no]");
		}
    }
    else if(%quest.getstate(%botid, %client) == 3) {
        if(%quest.getstate(%quest.getbotbyindex(2), %client) == 1) {
            %quest.respond(%botid, %client, "A collapse of the world... That... is just horrible...");
            %quest.schedule(1250, respond, %botid, %client, "About all I can help you with is that a day or so before the darkness came over us, there was a powerful dark wizard who set up shop in the nearby Wintercrest Forest. Go there and find his staff, perhaps it will contain some information we need.");
			%quest.setState(%botid, %client, 4);
        }
        else {
            if(isgreeting(%text)) {
                %quest.respond(%botid, %client, "Find Navegus and tell him what happened. From what I know about him, he usually comes out of his temple and stays amongst the people, usually in a small town...");
            }
        }
    }
    else if(%quest.getstate(%botid, %client) == 4) {
	    if(%quest.clienthasitem(%client, "DarkWintercrestGem", 1)) {
            %quest.respond(%botid, %client, "This gem is flowing with darkened energy, none of the kind I have ever seen before. Take this to Navegus, He'll know more than I could.");
            %quest.setState(%botid, %client, 5);
        }
        else {
            %quest.respond(%botid, %client, "You will find Wintercrest Forest to the North-East of the town... Be careful, a powerful darkness swept over those woods before we vanished, you can be asured that will still persist.");
        }
    }
    else if(%quest.getstate(%botid, %client) == 5) {
        if(%quest.getstate(%quest.getbotbyindex(2), %client) == 2) {
            %quest.respond(%botid, %client, "Another guardian of the land? I thought there were only four. And this one has potentially turned on us?");
            %quest.schedule(1250, respond, %botid, %client, "There is a more pressing matter right now, A dark energy has surged out of the Wintercrest Caverns, you need to go down there and stop whatever is doing this....");
			%quest.setState(%botid, %client, 6);
        }
        else {
            %quest.respond(%botid, %client, "Take that gem to Navegus, he'll know where that came from and what it's power truly is.");
        }
    }
    else if(%quest.getstate(%botid, %client) == 6) {
	    if(%quest.clienthasitem(%client, "ShadowRiftGate", 1)) {
            %quest.respond(%botid, %client, "That Crystal is pulsating with a pure darkened force, I don't like it at all. Take that to Navegus, he should be able to defuse it.");
            %quest.setState(%botid, %client, 7);
        }
        else {
            %quest.respond(%botid, %client, "Surely you saw the caverns? It's at the edge of the Wintercrest Forest... Now hurry before we potentially vanish from the world again!");
        }
    }
    else {
        %quest.respond(%botid, %client, "Thanks to your efforts we can all sleep a little easier around here. It will take a while for people here to get used to normality again, but this is a great start.");
    }
}

function QuestSnowblindInvestigation2(%quest, %botid, %client, %text) {
	if(%quest.getstate(%quest.getbotbyindex(1), %client) == 3) {
		if(%quest.getstate(%botid, %client) == 0) {
			if(isgreeting(%text)) {
				%quest.respond(%botid, %client, "Greetings "@%client.namebase@", you look anxious, as if you have something important to tell me. [yes or no]");
            }
			if(%text $= "yes") {
				%quest.respond(%botid, %client, "Wait..... What did you just say... Snowblind has... Returned????");
				%quest.schedule(1250, respond, %botid, %client, "Snowblind has been missing for over a thousand years. A shadow of some form swept over the land years ago and wiped it out, I thought it was Magmus at first but this... this is very concerning...");
                %quest.schedule(3000, respond, %botid, %client, "Go back to Snowblind "@%client.namebase@"... Pick their knowledge, find out what happened there. Maybe they can give us some pointers as to who or what caused the great collapse all that time ago.");
                %quest.setstate(%botid, %client, 1);
			}
			else if(%text $= "no") {
				%quest.respond(%botid, %client, "You might want to go back to your home and get some rest then, because you look exhausted..");
			}
		}
		else {
			if(isgreeting(%text)) {
				%quest.respond(%botid, %client, "Hello "@%client.namebase@", I'm glad to see you on the path of the hero, a honorable path I once followed.. I'll be seeing you around. Who knows, maybe one day we'll have a good match up.");
            }
		}
	}
    else if(%quest.getstate(%quest.getbotbyindex(1), %client) == 5) {
		if(%quest.getstate(%botid, %client) == 0) {
			if(isgreeting(%text)) {
				%quest.respond(%botid, %client, "Hello again "@%client.namebase@". Do you have more news from Snowblind? [yes or no]");
            }
			if(%text $= "yes") {
                if(%quest.clienthasitem(%client, "DarkWintercrestGem", 1)) {
				    %quest.respond(%botid, %client, "That is a terrifying crystal you're holding. This belongs to an ancient power called the Shadow Rift.");
				    %quest.schedule(1250, respond, %botid, %client, "A quick story for you friend, Me and three other Champions of the land were once watched over by a supreme guardian called the Shadow Lord, who ruled over the land. Legend says that this guardian would cleanse the land of all impurities.");
                    %quest.schedule(3000, respond, %botid, %client, "It also says he has control over the flow of both time and space. I believe these legends, because they are in fact, true. This Shadow Lord is the one responsible for giving us our power. If he has turned against us. No... He can't have. Go back to Snowblind...");
                    Game.RemoveFromInventory(%client, 1, "DarkWintercrestGem", 3, 1);
                    %quest.setstate(%botid, %client, 2);
                }
                else {
                    %quest.respond(%botid, %client, "A darkened crystal created by a Dark Wizard? And can I see this Crystal? Oh, you don't have it... We'll go get it.");
                }
			}
			else if(%text $= "no") {
				%quest.respond(%botid, %client, "I see, well if you find anything let me know at once...");
			}
		}
		else {
			if(isgreeting(%text)) {
				%quest.respond(%botid, %client, "Hello "@%client.namebase@", I'm glad to see you on the path of the hero, a honorable path I once followed.. I'll be seeing you around. Who knows, maybe one day we'll have a good match up.");
            }
		}
	}
    else if(%quest.getstate(%quest.getbotbyindex(1), %client) == 7) {
		if(%quest.getstate(%botid, %client) == 0) {
			if(isgreeting(%text)) {
				%quest.respond(%botid, %client, "Hello again "@%client.namebase@". Do you have more news from Snowblind? [yes or no]");
            }
			if(%text $= "yes") {
                if(%quest.clienthasitem(%client, "ShadowRiftGate", 1)) {
				    %quest.respond(%botid, %client, "That's what I was looking for right there, you just saved another disaster from happening my friend.");
				    %quest.schedule(1250, respond, %botid, %client, "And you should also know that the Shadow Lord isn't against us either, he personally affirmed that to me earlier. This gate was stolen from the rift, and now can safely be returned.");
                    Game.RemoveFromInventory(%client, 1, "ShadowRiftGate", 3, 1);
                    //Rewards?
                }
                else {
                    %quest.respond(%botid, %client, "A darkened crystal created by a Dark Wizard? And can I see this Crystal? Oh, you don't have it... We'll go get it.");
                }
			}
			else if(%text $= "no") {
				%quest.respond(%botid, %client, "I see, well if you find anything let me know at once...");
			}
		}
		else {
			if(isgreeting(%text)) {
				%quest.respond(%botid, %client, "Hello "@%client.namebase@", I'm glad to see you on the path of the hero, a honorable path I once followed.. I'll be seeing you around. Who knows, maybe one day we'll have a good match up.");
            }
		}
	}
	else {
		if(isgreeting(%text)) {
			%quest.respond(%botid, %client, "Hello "@%client.namebase@", I'm glad to see you on the path of the hero, a honorable path I once followed.. I'll be seeing you around. Who knows, maybe one day we'll have a good match up.");
        }
	}
}

function QuestFireTemple(%quest, %botid, %client, %text) {
	if(%quest.getState(%botid, %client) == 0)
	{
		if(isgreeting(%text))
		{
			%quest.respond(%botid, %client, "I am Mervis, Navegus' assistant, are you prepared to face Magmus in his temple of fire? [yes or no]");
			%quest.setState(%botid, %client, 1);
		}
	}
	else if(%quest.getstate(%botid, %client) == 1)
	{
		if(%text $= "yes")
		{
            if(%quest.clienthasitem(%client, "VoltrueFireCrystal", 1)) {
			   %quest.respond(%botid, %client, "Very well, here is the fire crystal... Wait, you're holding one... Just step inside the portal, the crystal will handle the rest.");
			   %quest.setState(%botid, %client, 2);
            }
            else {
			   %quest.respond(%botid, %client, "Very well, here is the fire crystal, it will allow you to enter the realm of Voltrue. Be cautious, once you enter this place, there is no leaving.");
			   %quest.setState(%botid, %client, 2);
               %quest.giveitem(%botid, %client, "VoltrueFireCrystal", 1, 1, 1);
           }
		}
		else if(%text $= "no")
		{
			%quest.respond(%botid, %client, "Ok, please return when you are prepared.");
			%quest.setState(%botid, %client, 0);
		}
		else if(isgreeting(%text))
		{
			%quest.respond(%botid, %client, "I am Mervis, Navegus' assistant, are you prepared to face Magmus in his temple of fire? [yes or no]");
		}
	}
    else if(%quest.getstate(%botid, %client) == 2) {
       if(%quest.clienthasitem(%client, "VoltrueFireCrystal", 1)) {
	      %quest.respond(%botid, %client, "You must go into the portal and defeat Magmus... Please hurry, we may not have much time left. You must be cautious in there however, there are rumors of two powerful fire guardians protecting him.");
       }
       else {
          if(%quest.clienthasitem(%client, "MagmusDarkSpirit", 1)) {
	         %quest.respond(%botid, %client, "Most Excellent!!! You have succeeded in what no other hero has ever accomplished! Know that we could never accomplish this feat without you, and you will be gracefully rewarded...");
	         %quest.setState(%botid, %client, 3);
             %quest.givereward(%botid, %client, "EXP 5000");
             Game.RemoveFromInventory(%client, 1, "MagmusDarkSpirit", 3, 1);
          }
          else {
             %quest.respond(%botid, %client, "You have made progress, however you're lacking consistency, regather your strength and try again!");
             %quest.setState(%botid, %client, 2);
             %quest.giveitem(%botid, %client, "VoltrueFireCrystal", 1, 1, 1);
          }
       }
    }
    else if(%quest.getstate(%botid, %client) == 3) {
		if(isgreeting(%text)) {
		   %quest.respond(%botid, %client, "Hello great hero of Voltrue, do you seek to maintain the balance of this realm again? [yes or no]");
		   %quest.setState(%botid, %client, 4);
        }
        else {
		   %quest.respond(%botid, %client, "You have done us a great dead, and for repayment, you will be welcome to return to Voltrue at any time you please. Do you want to re-enter now? [yes or no]");
		   %quest.setState(%botid, %client, 4);
        }
    }
    else if(%quest.getstate(%botid, %client) == 4) {
	   if(%text $= "yes") {
          %quest.respond(%botid, %client, "Here's your crystal, feel free to re-enter Voltrue to hunt down the dark spirit of Magmus.");
          %quest.setState(%botid, %client, 5);
          %quest.giveitem(%botid, %client, "VoltrueFireCrystal", 1, 1, 1);
       }
       else {
          %quest.respond(%botid, %client, "Very well! Feel free to return at any time you wish to re-enter this realm.");
	      %quest.setState(%botid, %client, 3);
       }
       if(isgreeting(%text)) {
          %quest.respond(%botid, %client, "Hello great hero of Voltrue, do you seek to maintain the balance of this realm again? [yes or no]");
	      %quest.setState(%botid, %client, 4);
       }
    }
    else if(%quest.getstate(%botid, %client) == 5) {
       if(%quest.clienthasitem(%client, "VoltrueFireCrystal", 1)) {
	      %quest.respond(%botid, %client, "I gave you my crystal to enter Voltrue, just step in the portal.");
       }
       else {
          if(%quest.clienthasitem(%client, "MagmusDarkSpirit", 1)) {
	         %quest.respond(%botid, %client, "And yet you continue to amaze us. Nice job on obtaining another dark spirit of Magmus!");
	         %quest.setState(%botid, %client, 3);
             %quest.givereward(%botid, %client, "SP 1r10");
             Game.RemoveFromInventory(%client, 1, "MagmusDarkSpirit", 3, 1);
          }
          else {
             %quest.respond(%botid, %client, "So he got you this time? Oh well, here's another crystal to re-enter Voltrue...");
             %quest.setState(%botid, %client, 5);
             %quest.giveitem(%botid, %client, "VoltrueFireCrystal", 1, 1, 1);
          }
       }
    }
}

function QuestPhantomRPG(%quest, %botid, %client, %text) {
	if(%quest.getState(%botid, %client) == 0)
	{
		if(isgreeting(%text))
		{
			%quest.respond(%botid, %client, "Hello brave warrior, are you looking for a challenge? [yes or no]");
			%quest.setState(%botid, %client, 1);
		}
	}
	else if(%quest.getstate(%botid, %client) == 1)
	{
		if(%text $= "yes")
		{
			%quest.respond(%botid, %client, "Excellent! I must warn you however, this is very dangerous, but the reward is perfect... are you sure you want to take this on? [yes or no]");
			%quest.setState(%botid, %client, 2);
		}
		else if(%text $= "no")
		{
			%quest.respond(%botid, %client, "Unfortunate, I thought you were prepared for this.");
			%quest.setState(%botid, %client, 0);
		}
		else if(isgreeting(%text))
		{
			%quest.respond(%botid, %client, "Hello brave warrior, are you looking for a challenge? [yes or no]");
		}
	}
	else if(%quest.getState(%botid, %client) == 2)
	{
		if(%text $= "yes")
		{
			%quest.respond(%botid, %client, "There is a legend, that four elemental temples exist in this world, each is safeguarded by a powerful guardian, obtain all four elements from them, and I can fashion you a weapon like no other.");
			%quest.setstate(%botid, %client, 3);
		}
		else if( %text $= "no")
		{
			%quest.setstate(%botid, %client, 0);
			%quest.respond(%botid, %client, "I see, please return when you are prepared.");
		}
		else if(isgreeting(%text))
		{
			//it's a good idea to allow the bot to repeat the last thing he said if the user logs off and logs back on and has no clue where he left off.
			%quest.respond(%botid, %client, "Excellent! I must warn you however, this is very dangerous, but the reward is perfect... are you sure you want to take this on? [yes or no]");
		}
	}
	else if(%quest.getstate(%botid, %client) == 3)
	{
		if(isgreeting(%text))
		{
			if( %quest.clienthasitem(%client, "WaterElement", 1) && %quest.clienthasitem(%client, "FireElement", 1) && %quest.clienthasitem(%client, "AirElement", 1) && %quest.clienthasitem(%client, "EarthElement", 1) )
			{
                Game.RemoveFromInventory(%client, 1, "WaterElement", 3, 1);
                Game.RemoveFromInventory(%client, 1, "FireElement", 3, 1);
                Game.RemoveFromInventory(%client, 1, "AirElement", 3, 1);
                Game.RemoveFromInventory(%client, 1, "EarthElement", 3, 1);
				%quest.respond(%botid, %client, "You ARE a true warrior! let me build your weapon.... And here it is. If you ever need another one, come talk to me again.");
				%quest.givereward(%botid, %client, "SP 10");
                %quest.giveitem(%botid, %client, "ElementalScepter", 3, 1, 1);
				%quest.setstate(%botid, %client, 0);
			}
			else
			{
				%quest.respond(%botid, %client, "Don't be afraid warrior, I have fate in your combat abilities. Obtain the four elements and bring them to me!");
			}

		}
	}
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
			%quest.respond(%botid, %client, "Good! I used to be a miner back in my day, however... my age has not been kind to me as of late. Could you retrieve one quartz and one opal for me please? [yes or no]");
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
			%quest.respond(%botid, %client, "Will you get one opal and one quartz for me please? [yes or no]");
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
function QuestMessage(%quest, %botid, %client, %text)
{
	if(%Quest.getstate(%botid, %client) == 0)
	{
		if(isgreeting(%text))
			%quest.respond(%botid, %client, "Hello traveller! I am Sean. I am charge of the stores for our SHOPS.");
		if(%text $= "shops" || %text $= "shops?")
		{
			%quest.setstate(%botid, %client, 1);
			%quest.respond(%botid, %client, "Yes, the keldrin item shop over there. Which reminds me, I need to order a shipment of cargo and there are no messangers around to deliver the message. Do you think you can help me?");
		}
	}
	else if(%quest.getstate(%botid, %client) == 1)
	{
		if(isgreeting(%text))
			%quest.respond(%botid, %client, "Do you think you can help me? [yes or no]");
		if(%text $= "yes")
		{
			%quest.setstate(%botid, %client, 2);
			%quest.respond(%botid, %client, "Oh good! Take this note to Garren in Jaten.");
		}
		else if (%text $= "no")
		{
			%quest.respond(%botid, %client, "Thats too bad, I guess I have to find someone else.");
			%quest.setstate(%botid, %client, 0);
		}
	}
	else if(%quest.getstate(%botid, %client) == 2)
	{
		if(%quest.getstate(%quest.getbotbyindex(2), %client) == 1)
		{
			
			%quest.respond(%botid, %client, "Thank you very much! Here is your payment!");
			%quest.givereward(%botid, %client, "COINS 10000");
			%quest.setstate(%botid, %client, 3);
		}
		else
		{
			if(isgreeting(%text))
				%quest.respond(%botid, %client, "Please deliver the note I gave you to Garren in Jaten");
		}
	}
	else if(%quest.getstate(%botid, %client) == 3)
	{
		if(isgreeting(%text))
			%quest.respond(%botid, %client, "Sorry, I have no more messages for you to deliver. Maybe some other time");
	}
}
function QuestMessage2(%quest, %botid, %client, %text)
{
	if(%quest.getstate(%quest.getbotbyindex(1), %client) == 2)
	{
		if(%quest.getstate(%botid, %client) == 0)
		{
			if(isgreeting(%text))
				%quest.respond(%botid, %client, "Hello! I see you have a note, is it for me?");
			if(%text $= "yes")
			{
				%quest.respond(%botid, %client, "Thanks. Hrm...");
				%quest.respond(%botid, %client, "Thank you, take this note back to Sean to prove to him you gave me his note");
				%quest.setstate(%botid, %client, 1);
			}
			else if(%text $= "no")
			{
				%quest.respond(%botid, %client, "That is unfortunate, I think that note is for me...");
			}
		}
		else
		{
			if(isgreeting(%text))
				%quest.respond(%botid, %client, "Hello, welcome to my home, you may rest here if you like.");
		}
	}
	else
	{
		if(isgreeting(%text))
			%quest.respond(%botid, %client, "Hello, welcome to my home, you may rest here if you like.");
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
	CreateMiningSpot("-1075.57 630.961 133",0.75);
	CreateMiningSpot("-1083 596 133", 0.75);
	CreateMiningSpot("670 2307 275", 0.5);
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
