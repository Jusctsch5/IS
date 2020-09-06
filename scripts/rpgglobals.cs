if($initlck $= "") $initlck = 8;
if($SPgainedPerLevel $= "") $SPgainedPerLevel = 15;
if($initSPcredits $= "") $initSPcredits = 60;
if($autoStartupSP $= "") $autoStartupSP = 1;	//for each skill
if($initbankcoins $= "") $initbankcoins = 0;
if($maxSAYdistVec $= "") $maxSAYdistVec = 20;
if($maxSHOUTdistVec $= "") $maxSHOUTdistVec = 60;
if($maxWHISPERdistVec $= "") $maxWHISPERdistVec = 5;

if($joinHouseCost $= "") $joinHouseCost = 2500;
if($changeHouseCost $= "") $changeHouseCost = 2500;
if($joinHouseRankPoints $= "") $joinHouseRankPoints = 4;

if($spawnMultiplier $= "") $spawnMultiplier = "1.0";
if($allowDuplicateIPs $= "") $allowDuplicateIPs = True;
if($recallDelay $= "") $recallDelay = 300;
if($SaveworldDelay $= "" || $SaveworldDelay < 60 ) $SaveworldDelay = 5 * 60; // 5 min 
if($daynightcycle $= "") $daynightcycle = 4 * 60 * 60;
if($guildownerzonelimit $= "") $guildownerzonelimit = 2;//limits the number of zones a guild can own.
if($Host::MaxBanTime $= "") $Host::MaxBanTime = 60*60*24*7; //default is one week. numbers are seconds.
if($Host::UseSanctionedAdmin $= "") $Host::UseSanctionedAdmin = 0;
$Host::CRCTextures = 0;

$initsp = 30;
$TribesDamageToNumericDamage = 100.0;
$maxDamagedBy = 10;
$damagedByEraseDelay = 60;
$maxEvents = 10;
$skillRangePerLevel = 12;
$stealDelay = 5;
$sayDelay = 0.2;
$SkillCap = 1000;
$MsgBlack = "\c0";
$MsgLightGray = "\c1";
$MsgLightGrey = $MsgLightGray;
$MsgRed = "\c2";
$MsgWhite = "\c3";
$MsgWhite2 = "\c4";
$MsgWhite3 = "\c5";
$MsgDarkGray = "\c6";
$MsgDarkGrey = $MsgDarkGray;
$MsgOlive = "\c3";
$MsgBlue = "\c0";
$MsgGreen = "\c1";
$MsgBrown = "\c5";
$MsgLtBlue = "\c4";
$maxAIdistVec = 10;
$initcoins = 100;
$sepchar = ",";

$LandingDamageType = 0;
$PiercingDamageType = 1;
$SlashingDamageType = 2;
$BludgeoningDamageType = 3;
$ArcheryDamageType = 4;
$SpellDamageType = 8;
//we will change this to the way T2 likes to have it...

$DamageType::Landing = 0;
$DamageType::Ground = 0;//heheh
$DamageType::Piercing = 1;
$DamageType::Slashing = 2;
$DamageType::Bludgeoning = 3;
$DamageType::Archery = 4;
$DamageType::Spell = 8;
$serverallowinfinitespawn=0;//respawns bots before the previous one dies.... want a massive army set this to 1 will cause server to crash eventually...
$version = 1.314;
$rpgver = $version;
$compilesaves = true; //compile the save files for anti hax security! set this to false and you can look at the uncompiled versions!
$displaydebugticks = false; //display game ticks as they happen

$isdeveloperversion = false;

$vcrc[1.3] = false;//if client version is 1.3 kick (false) and notify.
$vcrc[1.31] = false;
$vcrc[1.311] = false;
$vcrc[1.312] = false;
//Phantom139: We need to be using the new Phantom RPG for this server
$vcrc[1.313] = false;
//Server Version 1.314
$vcrc[1.314] = true;
