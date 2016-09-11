using System;
using System.Collections.Generic;

namespace Jass {

	public class CommonAi {

		//
		//
		//
		public static void DebugS(string str);//native DebugS               takes string str                            returns nothing
		public static void DebugFI(string str, int val);//native DebugFI              takes string str, integer val               returns nothing
		public static void DebugUnitID(string str, int val);//native DebugUnitID          takes string str, integer val               returns nothing
		public static void DisplayText(int p, string str);//native DisplayText          takes integer p, string str                 returns nothing
		public static void DisplayTextI(int p, string str, int val);//native DisplayTextI         takes integer p, string str, integer val    returns nothing
		public static void DisplayTextII(int p, string str, int v1, int v2);//native DisplayTextII        takes integer p, string str, integer v1, integer v2 returns nothing
		public static void DisplayTextIII(int p, string str, int v1, int v2, int v3);//native DisplayTextIII       takes integer p, string str, integer v1, integer v2, integer v3 returns nothing
		public static bool DoAiScriptDebug(nothin g);//native DoAiScriptDebug      takes nothing                               returns boolean
		public static int GetAiPlayer(nothin g);//native GetAiPlayer          takes nothing                               returns integer
		public static int GetHeroId(nothin g);//native GetHeroId            takes nothing                               returns integer
		public static int GetHeroLevelAI(nothin g);//native GetHeroLevelAI       takes nothing                               returns integer
		public static int GetUnitCount(int unitid);//native GetUnitCount         takes integer unitid                        returns integer
		public static int GetPlayerUnitTypeCount(player p, int unitid);//native GetPlayerUnitTypeCount takes player p, integer unitid            returns integer
		public static int GetUnitCountDone(int unitid);//native GetUnitCountDone     takes integer unitid                        returns integer
		public static int GetTownUnitCount(int id, int tn, bool dn);//native GetTownUnitCount     takes integer id, integer tn, boolean dn    returns integer
		public static int GetUnitGoldCost(int unitid);//native GetUnitGoldCost      takes integer unitid                        returns integer
		public static int GetUnitWoodCost(int unitid);//native GetUnitWoodCost      takes integer unitid                        returns integer
		public static int GetUnitBuildTime(int unitid);//native GetUnitBuildTime     takes integer unitid                        returns integer
		public static int GetMinesOwned(nothin g);//native GetMinesOwned        takes nothing                               returns integer
		public static int GetGoldOwned(nothin g);//native GetGoldOwned         takes nothing                               returns integer
		public static int TownWithMine(nothin g);//native TownWithMine         takes nothing                               returns integer
		public static bool TownHasMine(int townid);//native TownHasMine          takes integer townid                        returns boolean
		public static bool TownHasHall(int townid);//native TownHasHall          takes integer townid                        returns boolean
		public static int GetUpgradeLevel(int id);//native GetUpgradeLevel      takes integer id                            returns integer
		public static int GetUpgradeGoldCost(int id);//native GetUpgradeGoldCost   takes integer id                            returns integer
		public static int GetUpgradeWoodCost(int id);//native GetUpgradeWoodCost   takes integer id                            returns integer
		public static int GetNextExpansion(nothin g);//native GetNextExpansion     takes nothing                               returns integer
		public static unit GetMegaTarget(nothin g);//native GetMegaTarget        takes nothing                               returns unit
		public static unit GetBuilding(player p);//native GetBuilding          takes player p                              returns unit
		public static int GetEnemyPower(nothin g);//native GetEnemyPower        takes nothing                               returns integer
		public static void SetAllianceTarget(unit id);//native SetAllianceTarget    takes unit id                               returns nothing
		public static unit GetAllianceTarget(nothin g);//native GetAllianceTarget    takes nothing                               returns unit
		public static bool SetProduce(int qty, int id, int town);//native SetProduce           takes integer qty, integer id, integer town returns boolean
		public static void Unsummon(unit unitid);//native Unsummon             takes unit unitid                           returns nothing
		public static bool SetExpansion(unit peon, int id);//native SetExpansion         takes unit peon, integer id                 returns boolean
		public static bool SetUpgrade(int id);//native SetUpgrade           takes integer id                            returns boolean
		public static void SetHeroLevels(code func);//native SetHeroLevels        takes code func                             returns nothing
		public static void SetNewHeroes(bool state);//native SetNewHeroes         takes boolean state                         returns nothing
		public static void PurchaseZeppelin(nothin g);//native PurchaseZeppelin     takes nothing                               returns nothing
		public static bool MergeUnits(int qty, int a, int b, int make);//native MergeUnits           takes integer qty, integer a, integer b, integer make returns boolean
		public static bool ConvertUnits(int qty, int id);//native ConvertUnits         takes integer qty, integer id               returns boolean
		public static void SetCampaignAI(nothin g);//native SetCampaignAI        takes nothing                               returns nothing
		public static void SetMeleeAI(nothin g);//native SetMeleeAI           takes nothing                               returns nothing
		public static void SetTargetHeroes(bool state);//native SetTargetHeroes      takes boolean state                         returns nothing
		public static void SetPeonsRepair(bool state);//native SetPeonsRepair       takes boolean state                         returns nothing
		public static void SetRandomPaths(bool state);//native SetRandomPaths       takes boolean state                         returns nothing
		public static void SetDefendPlayer(bool state);//native SetDefendPlayer      takes boolean state                         returns nothing
		public static void SetHeroesFlee(bool state);//native SetHeroesFlee        takes boolean state                         returns nothing
		public static void SetHeroesBuyItems(bool state);//native SetHeroesBuyItems    takes boolean state                         returns nothing
		public static void SetWatchMegaTargets(bool state);//native SetWatchMegaTargets  takes boolean state                         returns nothing
		public static void SetIgnoreInjured(bool state);//native SetIgnoreInjured     takes boolean state                         returns nothing
		public static void SetHeroesTakeItems(bool state);//native SetHeroesTakeItems   takes boolean state                         returns nothing
		public static void SetUnitsFlee(bool state);//native SetUnitsFlee         takes boolean state                         returns nothing
		public static void SetGroupsFlee(bool state);//native SetGroupsFlee        takes boolean state                         returns nothing
		public static void SetSlowChopping(bool state);//native SetSlowChopping      takes boolean state                         returns nothing
		public static void SetCaptainChanges(bool allow);//native SetCaptainChanges    takes boolean allow                         returns nothing
		public static void SetSmartArtillery(bool state);//native SetSmartArtillery    takes boolean state                         returns nothing
		public static void SetReplacementCount(int qty);//native SetReplacementCount  takes integer qty                           returns nothing
		public static void GroupTimedLife(bool allow);//native GroupTimedLife       takes boolean allow                         returns nothing
		public static void RemoveInjuries(nothin g);//native RemoveInjuries       takes nothing                               returns nothing
		public static void RemoveSiege(nothin g);//native RemoveSiege          takes nothing                               returns nothing
		public static void InitAssault(nothin g);//native InitAssault          takes nothing                               returns nothing
		public static bool AddAssault(int qty, int id);//native AddAssault           takes integer qty, integer id               returns boolean
		public static bool AddDefenders(int qty, int id);//native AddDefenders         takes integer qty, integer id               returns boolean
		public static unit GetCreepCamp(int min, int max, bool flyers_ok);//native GetCreepCamp         takes integer min, integer max, boolean flyers_ok returns unit
		public static void StartGetEnemyBase(nothin g);//native StartGetEnemyBase    takes nothing                               returns nothing
		public static bool WaitGetEnemyBase(nothin g);//native WaitGetEnemyBase     takes nothing                               returns boolean
		public static unit GetEnemyBase(nothin g);//native GetEnemyBase         takes nothing                               returns unit
		public static unit GetExpansionFoe(nothin g);//native GetExpansionFoe      takes nothing                               returns unit
		public static unit GetEnemyExpansion(nothin g);//native GetEnemyExpansion    takes nothing                               returns unit
		public static int GetExpansionX(nothin g);//native GetExpansionX        takes nothing                               returns integer
		public static int GetExpansionY(nothin g);//native GetExpansionY        takes nothing                               returns integer
		public static void SetStagePoint(float x, float y);//native SetStagePoint        takes real x, real y                        returns nothing
		public static void AttackMoveKill(unit target);//native AttackMoveKill       takes unit target                           returns nothing
		public static void AttackMoveXY(int x, int y);//native AttackMoveXY         takes integer x, integer y                  returns nothing
		public static void LoadZepWave(int x, int y);//native LoadZepWave          takes integer x, integer y                  returns nothing
		public static bool SuicidePlayer(player id, bool check_full);//native SuicidePlayer        takes player id, boolean check_full         returns boolean
		public static bool SuicidePlayerUnits(player id, bool check_full);//native SuicidePlayerUnits   takes player id, boolean check_full         returns boolean
		public static bool CaptainInCombat(bool attack_captain);//native CaptainInCombat      takes boolean attack_captain                returns boolean
		public static bool IsTowered(unit target);//native IsTowered            takes unit target                           returns boolean
		public static void ClearHarvestAI(nothin g);//native ClearHarvestAI       takes nothing                               returns nothing
		public static void HarvestGold(int town, int peons);//native HarvestGold          takes integer town, integer peons           returns nothing
		public static void HarvestWood(int town, int peons);//native HarvestWood          takes integer town, integer peons           returns nothing
		public static unit GetExpansionPeon(nothin g);//native GetExpansionPeon     takes nothing                               returns unit
		public static void StopGathering(nothin g);//native StopGathering        takes nothing                               returns nothing
		public static void AddGuardPost(int id, float x, float y);//native AddGuardPost         takes integer id, real x, real y            returns nothing
		public static void FillGuardPosts(nothin g);//native FillGuardPosts       takes nothing                               returns nothing
		public static void ReturnGuardPosts(nothin g);//native ReturnGuardPosts     takes nothing                               returns nothing
		public static void CreateCaptains(nothin g);//native CreateCaptains       takes nothing                               returns nothing
		public static void SetCaptainHome(int which, float x, float y);//native SetCaptainHome       takes integer which, real x, real y         returns nothing
		public static void ResetCaptainLocs(nothin g);//native ResetCaptainLocs     takes nothing                               returns nothing
		public static void ShiftTownSpot(float x, float y);//native ShiftTownSpot        takes real x, real y                        returns nothing
		public static void TeleportCaptain(float x, float y);//native TeleportCaptain      takes real x, real y                        returns nothing
		public static void ClearCaptainTargets(nothin g);//native ClearCaptainTargets  takes nothing                               returns nothing
		public static void CaptainAttack(float x, float y);//native CaptainAttack        takes real x, real y                        returns nothing
		public static void CaptainVsUnits(player id);//native CaptainVsUnits       takes player id                             returns nothing
		public static void CaptainVsPlayer(player id);//native CaptainVsPlayer      takes player id                             returns nothing
		public static void CaptainGoHome(nothin g);//native CaptainGoHome        takes nothing                               returns nothing
		public static bool CaptainIsHome(nothin g);//native CaptainIsHome        takes nothing                               returns boolean
		public static bool CaptainIsFull(nothin g);//native CaptainIsFull        takes nothing                               returns boolean
		public static bool CaptainIsEmpty(nothin g);//native CaptainIsEmpty       takes nothing                               returns boolean
		public static int CaptainGroupSize(nothin g);//native CaptainGroupSize     takes nothing                               returns integer
		public static int CaptainReadiness(nothin g);//native CaptainReadiness     takes nothing                               returns integer
		public static bool CaptainRetreating(nothin g);//native CaptainRetreating    takes nothing                               returns boolean
		public static int CaptainReadinessHP(nothin g);//native CaptainReadinessHP   takes nothing                               returns integer
		public static int CaptainReadinessMa(nothin g);//native CaptainReadinessMa   takes nothing                               returns integer
		public static bool CaptainAtGoal(nothin g);//native CaptainAtGoal        takes nothing                               returns boolean
		public static bool CreepsOnMap(nothin g);//native CreepsOnMap          takes nothing                               returns boolean
		public static void SuicideUnit(int count, int unitid);//native SuicideUnit          takes integer count, integer unitid         returns nothing
		public static void SuicideUnitEx(int ct, int uid, int pid);//native SuicideUnitEx        takes integer ct, integer uid, integer pid  returns nothing
		public static void StartThread(code func);//native StartThread          takes code func                             returns nothing
		public static void Sleep(float seconds);//native Sleep                takes real seconds                          returns nothing
		public static bool UnitAlive(unit id);//native UnitAlive            takes unit id                               returns boolean
		public static bool UnitInvis(unit id);//native UnitInvis            takes unit id                               returns boolean
		public static int IgnoredUnits(int unitid);//native IgnoredUnits         takes integer unitid                        returns integer
		public static bool TownThreatened(nothin g);//native TownThreatened       takes nothing                               returns boolean
		public static void DisablePathing(nothin g);//native DisablePathing       takes nothing                               returns nothing
		public static void SetAmphibious(nothin g);//native SetAmphibious        takes nothing                               returns nothing
		public static int CommandsWaiting(nothin g);//native CommandsWaiting      takes nothing                               returns integer
		public static int GetLastCommand(nothin g);//native GetLastCommand       takes nothing                               returns integer
		public static int GetLastData(nothin g);//native GetLastData          takes nothing                               returns integer
		public static void PopLastCommand(nothin g);//native PopLastCommand       takes nothing                               returns nothing
		public static int MeleeDifficulty(nothin g);//native MeleeDifficulty      takes nothing                               returns integer
		//
		//
		//
		//
		//
		//
		//
		public const int ARCHMAGE = 'Hamg';//constant integer ARCHMAGE           = 'Hamg'
		public const int PALADIN = 'Hpal';//constant integer PALADIN            = 'Hpal'
		public const int MTN_KING = 'Hmkg';//constant integer MTN_KING           = 'Hmkg'
		public const int BLOOD_MAGE = 'Hblm';//constant integer BLOOD_MAGE         = 'Hblm'
		//
		public const int AVATAR = 'AHav';//constant integer AVATAR             = 'AHav'
		public const int BASH = 'AHbh';//constant integer BASH               = 'AHbh'
		public const int THUNDER_BOLT = 'AHtb';//constant integer THUNDER_BOLT       = 'AHtb'
		public const int THUNDER_CLAP = 'AHtc';//constant integer THUNDER_CLAP       = 'AHtc'
		public const int DEVOTION_AURA = 'AHad';//constant integer DEVOTION_AURA      = 'AHad'
		public const int DIVINE_SHIELD = 'AHds';//constant integer DIVINE_SHIELD      = 'AHds'
		public const int HOLY_BOLT = 'AHhb';//constant integer HOLY_BOLT          = 'AHhb'
		public const int RESURRECTION = 'AHre';//constant integer RESURRECTION       = 'AHre'
		public const int BLIZZARD = 'AHbz';//constant integer BLIZZARD           = 'AHbz'
		public const int BRILLIANCE_AURA = 'AHab';//constant integer BRILLIANCE_AURA    = 'AHab'
		public const int MASS_TELEPORT = 'AHmt';//constant integer MASS_TELEPORT      = 'AHmt'
		public const int WATER_ELEMENTAL = 'AHwe';//constant integer WATER_ELEMENTAL    = 'AHwe'
		public const int BANISH = 'AHbn';//constant integer BANISH             = 'AHbn'
		public const int FLAME_STRIKE = 'AHfs';//constant integer FLAME_STRIKE       = 'AHfs'
		public const int SUMMON_PHOENIX = 'AHpx';//constant integer SUMMON_PHOENIX     = 'AHpx'
		public const int SIPHON_MANA = 'AHdr';//constant integer SIPHON_MANA        = 'AHdr'
		//
		public const int JAINA = 'Hjai';//constant integer JAINA              = 'Hjai'
		public const int MURADIN = 'Hmbr';//constant integer MURADIN            = 'Hmbr'
		public const int GARITHOS = 'Hlgr';//constant integer GARITHOS           = 'Hlgr'
		public const int KAEL = 'Hkal';//constant integer KAEL               = 'Hkal'
		//
		public const int COPTER = 'hgyr';//constant integer COPTER             = 'hgyr'
		public const int GYRO = COPTER;//constant integer GYRO               =  COPTER
		public const int ELEMENTAL = 'hwat';//constant integer ELEMENTAL          = 'hwat'
		public const int FOOTMAN = 'hfoo';//constant integer FOOTMAN            = 'hfoo'
		public const int FOOTMEN = FOOTMAN;//constant integer FOOTMEN            =  FOOTMAN
		public const int GRYPHON = 'hgry';//constant integer GRYPHON            = 'hgry'
		public const int KNIGHT = 'hkni';//constant integer KNIGHT             = 'hkni'
		public const int MORTAR = 'hmtm';//constant integer MORTAR             = 'hmtm'
		public const int PEASANT = 'hpea';//constant integer PEASANT            = 'hpea'
		public const int PRIEST = 'hmpr';//constant integer PRIEST             = 'hmpr'
		public const int RIFLEMAN = 'hrif';//constant integer RIFLEMAN           = 'hrif'
		public const int RIFLEMEN = RIFLEMAN;//constant integer RIFLEMEN           =  RIFLEMAN
		public const int SORCERESS = 'hsor';//constant integer SORCERESS          = 'hsor'
		public const int TANK = 'hmtt';//constant integer TANK               = 'hmtt'
		public const int STEAM_TANK = TANK;//constant integer STEAM_TANK         =  TANK
		public const int ROCKET_TANK = 'hrtt';//constant integer ROCKET_TANK        = 'hrtt'
		public const int MILITIA = 'hmil';//constant integer MILITIA            = 'hmil'
		public const int SPELL_BREAKER = 'hspt';//constant integer SPELL_BREAKER      = 'hspt'
		public const int HUMAN_DRAGON_HAWK = 'hdhw';//constant integer HUMAN_DRAGON_HAWK  = 'hdhw'
		//
		public const int BLOOD_PRIEST = 'hbep';//constant integer BLOOD_PRIEST       = 'hbep'
		public const int BLOOD_SORCERESS = 'hbes';//constant integer BLOOD_SORCERESS    = 'hbes'
		public const int BLOOD_PEASANT = 'nhew';//constant integer BLOOD_PEASANT      = 'nhew'
		//
		public const int AVIARY = 'hgra';//constant integer AVIARY             = 'hgra'
		public const int BARRACKS = 'hbar';//constant integer BARRACKS           = 'hbar'
		public const int BLACKSMITH = 'hbla';//constant integer BLACKSMITH         = 'hbla'
		public const int CANNON_TOWER = 'hctw';//constant integer CANNON_TOWER       = 'hctw'
		public const int CASTLE = 'hcas';//constant integer CASTLE             = 'hcas'
		public const int CHURCH = 'htws';//constant integer CHURCH             = 'htws'
		public const int MAGE_TOWER = CHURCH;//constant integer MAGE_TOWER         =  CHURCH
		public const int GUARD_TOWER = 'hgtw';//constant integer GUARD_TOWER        = 'hgtw'
		public const int HOUSE = 'hhou';//constant integer HOUSE              = 'hhou'
		public const int HUMAN_ALTAR = 'halt';//constant integer HUMAN_ALTAR        = 'halt'
		public const int KEEP = 'hkee';//constant integer KEEP               = 'hkee'
		public const int LUMBER_MILL = 'hlum';//constant integer LUMBER_MILL        = 'hlum'
		public const int SANCTUM = 'hars';//constant integer SANCTUM            = 'hars'
		public const int ARCANE_SANCTUM = SANCTUM;//constant integer ARCANE_SANCTUM     =  SANCTUM
		public const int TOWN_HALL = 'htow';//constant integer TOWN_HALL          = 'htow'
		public const int WATCH_TOWER = 'hwtw';//constant integer WATCH_TOWER        = 'hwtw'
		public const int WORKSHOP = 'harm';//constant integer WORKSHOP           = 'harm'
		public const int ARCANE_VAULT = 'hvlt';//constant integer ARCANE_VAULT       = 'hvlt'
		public const int ARCANE_TOWER = 'hatw';//constant integer ARCANE_TOWER       = 'hatw'
		//
		public const int UPG_MELEE = 'Rhme';//constant integer UPG_MELEE          = 'Rhme'
		public const int UPG_RANGED = 'Rhra';//constant integer UPG_RANGED         = 'Rhra'
		public const int UPG_ARTILLERY = 'Rhaa';//constant integer UPG_ARTILLERY      = 'Rhaa'
		public const int UPG_ARMOR = 'Rhar';//constant integer UPG_ARMOR          = 'Rhar'
		public const int UPG_GOLD = 'Rhmi';//constant integer UPG_GOLD           = 'Rhmi'
		public const int UPG_MASONRY = 'Rhac';//constant integer UPG_MASONRY        = 'Rhac'
		public const int UPG_SIGHT = 'Rhss';//constant integer UPG_SIGHT          = 'Rhss'
		public const int UPG_DEFEND = 'Rhde';//constant integer UPG_DEFEND         = 'Rhde'
		public const int UPG_BREEDING = 'Rhan';//constant integer UPG_BREEDING       = 'Rhan'
		public const int UPG_PRAYING = 'Rhpt';//constant integer UPG_PRAYING        = 'Rhpt'
		public const int UPG_SORCERY = 'Rhst';//constant integer UPG_SORCERY        = 'Rhst'
		public const int UPG_LEATHER = 'Rhla';//constant integer UPG_LEATHER        = 'Rhla'
		public const int UPG_GUN_RANGE = 'Rhri';//constant integer UPG_GUN_RANGE      = 'Rhri'
		public const int UPG_WOOD = 'Rhlh';//constant integer UPG_WOOD           = 'Rhlh'
		public const int UPG_SENTINEL = 'Rhse';//constant integer UPG_SENTINEL       = 'Rhse'
		public const int UPG_SCATTER = 'Rhsr';//constant integer UPG_SCATTER        = 'Rhsr'
		public const int UPG_BOMBS = 'Rhgb';//constant integer UPG_BOMBS          = 'Rhgb'
		public const int UPG_HAMMERS = 'Rhhb';//constant integer UPG_HAMMERS        = 'Rhhb'
		public const int UPG_CONT_MAGIC = 'Rhss';//constant integer UPG_CONT_MAGIC     = 'Rhss'
		public const int UPG_FRAGS = 'Rhfs';//constant integer UPG_FRAGS          = 'Rhfs'
		public const int UPG_TANK = 'Rhrt';//constant integer UPG_TANK           = 'Rhrt'
		public const int UPG_FLAK = 'Rhfc';//constant integer UPG_FLAK           = 'Rhfc'
		public const int UPG_CLOUD = 'Rhcd';//constant integer UPG_CLOUD          = 'Rhcd'
		//
		//
		//
		//
		public const int BLADE_MASTER = 'Obla';//constant integer BLADE_MASTER       = 'Obla'
		public const int FAR_SEER = 'Ofar';//constant integer FAR_SEER           = 'Ofar'
		public const int TAUREN_CHIEF = 'Otch';//constant integer TAUREN_CHIEF       = 'Otch'
		public const int SHADOW_HUNTER = 'Oshd';//constant integer SHADOW_HUNTER      = 'Oshd'
		//
		public const int GROM = 'Ogrh';//constant integer GROM               = 'Ogrh'
		public const int THRALL = 'Othr';//constant integer THRALL             = 'Othr'
		//
		public const int CRITICAL_STRIKE = 'AOcr';//constant integer CRITICAL_STRIKE    = 'AOcr'
		public const int MIRROR_IMAGE = 'AOmi';//constant integer MIRROR_IMAGE       = 'AOmi'
		public const int BLADE_STORM = 'AOww';//constant integer BLADE_STORM        = 'AOww'
		public const int WIND_WALK = 'AOwk';//constant integer WIND_WALK          = 'AOwk'
		public const int CHAIN_LIGHTNING = 'AOcl';//constant integer CHAIN_LIGHTNING    = 'AOcl'
		public const int EARTHQUAKE = 'AOeq';//constant integer EARTHQUAKE         = 'AOeq'
		public const int FAR_SIGHT = 'AOfs';//constant integer FAR_SIGHT          = 'AOfs'
		public const int SPIRIT_WOLF = 'AOsf';//constant integer SPIRIT_WOLF        = 'AOsf'
		public const int ENDURANE_AURA = 'AOae';//constant integer ENDURANE_AURA      = 'AOae'
		public const int REINCARNATION = 'AOre';//constant integer REINCARNATION      = 'AOre'
		public const int SHOCKWAVE = 'AOsh';//constant integer SHOCKWAVE          = 'AOsh'
		public const int WAR_STOMP = 'AOws';//constant integer WAR_STOMP          = 'AOws'
		public const int HEALING_WAVE = 'AOhw';//constant integer HEALING_WAVE       = 'AOhw'
		public const int HEX = 'AOhx';//constant integer HEX                = 'AOhx'
		public const int SERPENT_WARD = 'AOsw';//constant integer SERPENT_WARD       = 'AOsw'
		public const int VOODOO = 'AOvd';//constant integer VOODOO             = 'AOvd'
		//
		public const int GUARDIAN = 'oang';//constant integer GUARDIAN           = 'oang'
		public const int CATAPULT = 'ocat';//constant integer CATAPULT           = 'ocat'
		public const int WITCH_DOCTOR = 'odoc';//constant integer WITCH_DOCTOR       = 'odoc'
		public const int GRUNT = 'ogru';//constant integer GRUNT              = 'ogru'
		public const int HEAD_HUNTER = 'ohun';//constant integer HEAD_HUNTER        = 'ohun'
		public const int BERSERKER = 'otbk';//constant integer BERSERKER          = 'otbk'
		public const int KODO_BEAST = 'okod';//constant integer KODO_BEAST         = 'okod'
		public const int PEON = 'opeo';//constant integer PEON               = 'opeo'
		public const int RAIDER = 'orai';//constant integer RAIDER             = 'orai'
		public const int SHAMAN = 'oshm';//constant integer SHAMAN             = 'oshm'
		public const int TAUREN = 'otau';//constant integer TAUREN             = 'otau'
		public const int WYVERN = 'owyv';//constant integer WYVERN             = 'owyv'
		public const int BATRIDER = 'otbr';//constant integer BATRIDER           = 'otbr'
		public const int SPIRIT_WALKER = 'ospw';//constant integer SPIRIT_WALKER      = 'ospw'
		public const int SPIRIT_WALKER_M = 'ospm';//constant integer SPIRIT_WALKER_M    = 'ospm'
		//
		public const int ORC_ALTAR = 'oalt';//constant integer ORC_ALTAR          = 'oalt'
		public const int ORC_BARRACKS = 'obar';//constant integer ORC_BARRACKS       = 'obar'
		public const int BESTIARY = 'obea';//constant integer BESTIARY           = 'obea'
		public const int FORGE = 'ofor';//constant integer FORGE              = 'ofor'
		public const int FORTRESS = 'ofrt';//constant integer FORTRESS           = 'ofrt'
		public const int GREAT_HALL = 'ogre';//constant integer GREAT_HALL         = 'ogre'
		public const int LODGE = 'osld';//constant integer LODGE              = 'osld'
		public const int STRONGHOLD = 'ostr';//constant integer STRONGHOLD         = 'ostr'
		public const int BURROW = 'otrb';//constant integer BURROW             = 'otrb'
		public const int TOTEM = 'otto';//constant integer TOTEM              = 'otto'
		public const int ORC_WATCH_TOWER = 'owtw';//constant integer ORC_WATCH_TOWER    = 'owtw'
		public const int VOODOO_LOUNGE = 'ovln';//constant integer VOODOO_LOUNGE      = 'ovln'
		//
		public const int UPG_ORC_MELEE = 'Rome';//constant integer UPG_ORC_MELEE      = 'Rome'
		public const int UPG_ORC_RANGED = 'Rora';//constant integer UPG_ORC_RANGED     = 'Rora'
		public const int UPG_ORC_ARTILLERY = 'Roaa';//constant integer UPG_ORC_ARTILLERY  = 'Roaa'
		public const int UPG_ORC_ARMOR = 'Roar';//constant integer UPG_ORC_ARMOR      = 'Roar'
		public const int UPG_ORC_WAR_DRUMS = 'Rwdm';//constant integer UPG_ORC_WAR_DRUMS  = 'Rwdm'
		public const int UPG_ORC_PILLAGE = 'Ropg';//constant integer UPG_ORC_PILLAGE    = 'Ropg'
		public const int UPG_ORC_BERSERK = 'Robs';//constant integer UPG_ORC_BERSERK    = 'Robs'
		public const int UPG_ORC_PULVERIZE = 'Rows';//constant integer UPG_ORC_PULVERIZE  = 'Rows'
		public const int UPG_ORC_ENSNARE = 'Roen';//constant integer UPG_ORC_ENSNARE    = 'Roen'
		public const int UPG_ORC_VENOM = 'Rovs';//constant integer UPG_ORC_VENOM      = 'Rovs'
		public const int UPG_ORC_DOCS = 'Rowd';//constant integer UPG_ORC_DOCS       = 'Rowd'
		public const int UPG_ORC_SHAMAN = 'Rost';//constant integer UPG_ORC_SHAMAN     = 'Rost'
		public const int UPG_ORC_SPIKES = 'Rosp';//constant integer UPG_ORC_SPIKES     = 'Rosp'
		public const int UPG_ORC_BURROWS = 'Rorb';//constant integer UPG_ORC_BURROWS    = 'Rorb'
		public const int UPG_ORC_REGEN = 'Rotr';//constant integer UPG_ORC_REGEN      = 'Rotr'
		public const int UPG_ORC_FIRE = 'Rolf';//constant integer UPG_ORC_FIRE       = 'Rolf'
		public const int UPG_ORC_SWALKER = 'Rowt';//constant integer UPG_ORC_SWALKER    = 'Rowt'
		public const int UPG_ORC_BERSERKER = 'Robk';//constant integer UPG_ORC_BERSERKER  = 'Robk'
		public const int UPG_ORC_NAPTHA = 'Robf';//constant integer UPG_ORC_NAPTHA     = 'Robf'
		public const int UPG_ORC_CHAOS = 'Roch';//constant integer UPG_ORC_CHAOS      = 'Roch'
		//
		public const int OGRE_MAGI = 'nomg';//constant integer OGRE_MAGI          = 'nomg'
		public const int ORC_DRAGON = 'nrwm';//constant integer ORC_DRAGON         = 'nrwm'
		public const int SAPPER = 'ngsp';//constant integer SAPPER             = 'ngsp'
		public const int ZEPPLIN = 'nzep';//constant integer ZEPPLIN            = 'nzep'
		public const int ZEPPELIN = ZEPPLIN;//constant integer ZEPPELIN           =  ZEPPLIN
		public const int W2_WARLOCK = 'nw2w';//constant integer W2_WARLOCK         = 'nw2w'
		public const int PIG_FARM = 'npgf';//constant integer PIG_FARM           = 'npgf'
		//
		public const int CHAOS_GRUNT = 'nchg';//constant integer CHAOS_GRUNT        = 'nchg'
		public const int CHAOS_WARLOCK = 'nchw';//constant integer CHAOS_WARLOCK      = 'nchw'
		public const int CHAOS_RAIDER = 'nchr';//constant integer CHAOS_RAIDER       = 'nchr'
		public const int CHAOS_PEON = 'ncpn';//constant integer CHAOS_PEON         = 'ncpn'
		public const int CHAOS_KODO = 'nckb';//constant integer CHAOS_KODO         = 'nckb'
		public const int CHAOS_GROM = 'Opgh';//constant integer CHAOS_GROM         = 'Opgh'
		public const int CHAOS_BLADEMASTER = 'Nbbc';//constant integer CHAOS_BLADEMASTER  = 'Nbbc'
		public const int CHAOS_BURROW = 'ocbw';//constant integer CHAOS_BURROW       = 'ocbw'
		//
		//
		//
		//
		public const int DEATH_KNIGHT = 'Udea';//constant integer DEATH_KNIGHT       = 'Udea'
		public const int DREAD_LORD = 'Udre';//constant integer DREAD_LORD         = 'Udre'
		public const int LICH = 'Ulic';//constant integer LICH               = 'Ulic'
		public const int CRYPT_LORD = 'Ucrl';//constant integer CRYPT_LORD         = 'Ucrl'
		//
		public const int MALGANIS = 'Umal';//constant integer MALGANIS           = 'Umal'
		public const int TICHONDRIUS = 'Utic';//constant integer TICHONDRIUS        = 'Utic'
		public const int PIT_LORD = 'Npld';//constant integer PIT_LORD           = 'Npld'
		public const int DETHEROC = 'Udth';//constant integer DETHEROC           = 'Udth'
		//
		public const int SLEEP = 'AUsl';//constant integer SLEEP              = 'AUsl'
		public const int VAMP_AURA = 'AUav';//constant integer VAMP_AURA          = 'AUav'
		public const int CARRION_SWARM = 'AUcs';//constant integer CARRION_SWARM      = 'AUcs'
		public const int INFERNO = 'AUin';//constant integer INFERNO            = 'AUin'
		public const int DARK_RITUAL = 'AUdr';//constant integer DARK_RITUAL        = 'AUdr'
		public const int DEATH_DECAY = 'AUdd';//constant integer DEATH_DECAY        = 'AUdd'
		public const int FROST_ARMOR = 'AUfu';//constant integer FROST_ARMOR        = 'AUfu'
		public const int FROST_NOVA = 'AUfn';//constant integer FROST_NOVA         = 'AUfn'
		public const int ANIM_DEAD = 'AUan';//constant integer ANIM_DEAD          = 'AUan'
		public const int DEATH_COIL = 'AUdc';//constant integer DEATH_COIL         = 'AUdc'
		public const int DEATH_PACT = 'AUdp';//constant integer DEATH_PACT         = 'AUdp'
		public const int UNHOLY_AURA = 'AUau';//constant integer UNHOLY_AURA        = 'AUau'
		public const int CARRION_SCARAB = 'AUcb';//constant integer CARRION_SCARAB     = 'AUcb'
		public const int IMPALE = 'AUim';//constant integer IMPALE             = 'AUim'
		public const int LOCUST_SWARM = 'AUls';//constant integer LOCUST_SWARM       = 'AUls'
		public const int THORNY_SHIELD = 'AUts';//constant integer THORNY_SHIELD      = 'AUts'
		//
		public const int ABOMINATION = 'uabo';//constant integer ABOMINATION        = 'uabo'
		public const int ACOLYTE = 'uaco';//constant integer ACOLYTE            = 'uaco'
		public const int BANSHEE = 'uban';//constant integer BANSHEE            = 'uban'
		public const int PIT_FIEND = 'ucry';//constant integer PIT_FIEND          = 'ucry'
		public const int CRYPT_FIEND = PIT_FIEND;//constant integer CRYPT_FIEND        =  PIT_FIEND
		public const int FROST_WYRM = 'ufro';//constant integer FROST_WYRM         = 'ufro'
		public const int GARGOYLE = 'ugar';//constant integer GARGOYLE           = 'ugar'
		public const int GARGOYLE_MORPH = 'ugrm';//constant integer GARGOYLE_MORPH     = 'ugrm'
		public const int GHOUL = 'ugho';//constant integer GHOUL              = 'ugho'
		public const int MEAT_WAGON = 'umtw';//constant integer MEAT_WAGON         = 'umtw'
		public const int NECRO = 'unec';//constant integer NECRO              = 'unec'
		public const int SKEL_WARRIOR = 'uske';//constant integer SKEL_WARRIOR       = 'uske'
		public const int SHADE = 'ushd';//constant integer SHADE              = 'ushd'
		public const int UNDEAD_BARGE = 'uarb';//constant integer UNDEAD_BARGE       = 'uarb'
		public const int OBSIDIAN_STATUE = 'uobs';//constant integer OBSIDIAN_STATUE    = 'uobs'
		public const int OBS_STATUE = OBSIDIAN_STATUE;//constant integer OBS_STATUE         =  OBSIDIAN_STATUE
		public const int BLK_SPHINX = 'ubsp';//constant integer BLK_SPHINX         = 'ubsp'
		//
		public const int UNDEAD_MINE = 'ugol';//constant integer UNDEAD_MINE        = 'ugol'
		public const int UNDEAD_ALTAR = 'uaod';//constant integer UNDEAD_ALTAR       = 'uaod'
		public const int BONEYARD = 'ubon';//constant integer BONEYARD           = 'ubon'
		public const int GARG_SPIRE = 'ugsp';//constant integer GARG_SPIRE         = 'ugsp'
		public const int NECROPOLIS_1 = 'unpl';//constant integer NECROPOLIS_1       = 'unpl'
		public const int NECROPOLIS_2 = 'unp1';//constant integer NECROPOLIS_2       = 'unp1'
		public const int NECROPOLIS_3 = 'unp2';//constant integer NECROPOLIS_3       = 'unp2'
		public const int SAC_PIT = 'usap';//constant integer SAC_PIT            = 'usap'
		public const int CRYPT = 'usep';//constant integer CRYPT              = 'usep'
		public const int SLAUGHTERHOUSE = 'uslh';//constant integer SLAUGHTERHOUSE     = 'uslh'
		public const int DAMNED_TEMPLE = 'utod';//constant integer DAMNED_TEMPLE      = 'utod'
		public const int ZIGGURAT_1 = 'uzig';//constant integer ZIGGURAT_1         = 'uzig'
		public const int ZIGGURAT_2 = 'uzg1';//constant integer ZIGGURAT_2         = 'uzg1'
		public const int ZIGGURAT_FROST = 'uzg2';//constant integer ZIGGURAT_FROST     = 'uzg2'
		public const int GRAVEYARD = 'ugrv';//constant integer GRAVEYARD          = 'ugrv'
		public const int TOMB_OF_RELICS = 'utom';//constant integer TOMB_OF_RELICS     = 'utom'
		//
		public const int UPG_UNHOLY_STR = 'Rume';//constant integer UPG_UNHOLY_STR     = 'Rume'
		public const int UPG_CR_ATTACK = 'Rura';//constant integer UPG_CR_ATTACK      = 'Rura'
		public const int UPG_UNHOLY_ARMOR = 'Ruar';//constant integer UPG_UNHOLY_ARMOR   = 'Ruar'
		public const int UPG_CANNIBALIZE = 'Ruac';//constant integer UPG_CANNIBALIZE    = 'Ruac'
		public const int UPG_GHOUL_FRENZY = 'Rugf';//constant integer UPG_GHOUL_FRENZY   = 'Rugf'
		public const int UPG_FIEND_WEB = 'Ruwb';//constant integer UPG_FIEND_WEB      = 'Ruwb'
		public const int UPG_ABOM = 'Ruab';//constant integer UPG_ABOM           = 'Ruab'
		public const int UPG_STONE_FORM = 'Rusf';//constant integer UPG_STONE_FORM     = 'Rusf'
		public const int UPG_NECROS = 'Rune';//constant integer UPG_NECROS         = 'Rune'
		public const int UPG_BANSHEE = 'Ruba';//constant integer UPG_BANSHEE        = 'Ruba'
		public const int UPG_MEAT_WAGON = 'Rump';//constant integer UPG_MEAT_WAGON     = 'Rump'
		public const int UPG_WYRM_BREATH = 'Rufb';//constant integer UPG_WYRM_BREATH    = 'Rufb'
		public const int UPG_SKEL_LIFE = 'Rusl';//constant integer UPG_SKEL_LIFE      = 'Rusl'
		public const int UPG_SKEL_MASTERY = 'Rusm';//constant integer UPG_SKEL_MASTERY   = 'Rusm'
		public const int UPG_EXHUME = 'Ruex';//constant integer UPG_EXHUME         = 'Ruex'
		public const int UPG_SACRIFICE = 'Rurs';//constant integer UPG_SACRIFICE      = 'Rurs'
		public const int UPG_ABOM_EXPL = 'Ruax';//constant integer UPG_ABOM_EXPL      = 'Ruax'
		public const int UPG_CR_ARMOR = 'Rucr';//constant integer UPG_CR_ARMOR       = 'Rucr'
		public const int UPG_PLAGUE = 'Rupc';//constant integer UPG_PLAGUE         = 'Rupc'
		public const int UPG_BLK_SPHINX = 'Rusp';//constant integer UPG_BLK_SPHINX     = 'Rusp'
		public const int UPG_BURROWING = 'Rubu';//constant integer UPG_BURROWING      = 'Rubu'
		//
		//
		//
		//
		public const int DEMON_HUNTER = 'Edem';//constant integer DEMON_HUNTER       = 'Edem'
		public const int DEMON_HUNTER_M = 'Edmm';//constant integer DEMON_HUNTER_M     = 'Edmm'
		public const int KEEPER = 'Ekee';//constant integer KEEPER             = 'Ekee'
		public const int MOON_CHICK = 'Emoo';//constant integer MOON_CHICK         = 'Emoo'
		public const int MOON_BABE = MOON_CHICK;//constant integer MOON_BABE          =  MOON_CHICK
		public const int MOON_HONEY = MOON_CHICK;//constant integer MOON_HONEY         =  MOON_CHICK
		public const int WARDEN = 'Ewar';//constant integer WARDEN             = 'Ewar'
		//
		public const int SYLVANUS = 'Hvwd';//constant integer SYLVANUS           = 'Hvwd'
		public const int CENARIUS = 'Ecen';//constant integer CENARIUS           = 'Ecen'
		public const int ILLIDAN = 'Eevi';//constant integer ILLIDAN            = 'Eevi'
		public const int ILLIDAN_DEMON = 'Eevm';//constant integer ILLIDAN_DEMON      = 'Eevm'
		public const int MAIEV = 'Ewrd';//constant integer MAIEV              = 'Ewrd'
		//
		public const int FORCE_NATURE = 'AEfn';//constant integer FORCE_NATURE       = 'AEfn'
		public const int ENT_ROOTS = 'AEer';//constant integer ENT_ROOTS          = 'AEer'
		public const int THORNS_AURA = 'AEah';//constant integer THORNS_AURA        = 'AEah'
		public const int TRANQUILITY = 'AEtq';//constant integer TRANQUILITY        = 'AEtq'
		public const int EVASION = 'AEev';//constant integer EVASION            = 'AEev'
		public const int IMMOLATION = 'AEim';//constant integer IMMOLATION         = 'AEim'
		public const int MANA_BURN = 'AEmb';//constant integer MANA_BURN          = 'AEmb'
		public const int METAMORPHOSIS = 'AEme';//constant integer METAMORPHOSIS      = 'AEme'
		public const int SEARING_ARROWS = 'AHfa';//constant integer SEARING_ARROWS     = 'AHfa'
		public const int SCOUT = 'AEst';//constant integer SCOUT              = 'AEst'
		public const int STARFALL = 'AEsf';//constant integer STARFALL           = 'AEsf'
		public const int TRUESHOT = 'AEar';//constant integer TRUESHOT           = 'AEar'
		public const int BLINK = 'AEbl';//constant integer BLINK              = 'AEbl'
		public const int FAN_KNIVES = 'AEfk';//constant integer FAN_KNIVES         = 'AEfk'
		public const int SHADOW_TOUCH = 'AEsh';//constant integer SHADOW_TOUCH       = 'AEsh'
		public const int VENGEANCE = 'AEsv';//constant integer VENGEANCE          = 'AEsv'
		//
		public const int WISP = 'ewsp';//constant integer WISP               = 'ewsp'
		public const int ARCHER = 'earc';//constant integer ARCHER             = 'earc'
		public const int DRUID_TALON = 'edot';//constant integer DRUID_TALON        = 'edot'
		public const int DRUID_TALON_M = 'edtm';//constant integer DRUID_TALON_M      = 'edtm'
		public const int BALLISTA = 'ebal';//constant integer BALLISTA           = 'ebal'
		public const int DRUID_CLAW = 'edoc';//constant integer DRUID_CLAW         = 'edoc'
		public const int DRUID_CLAW_M = 'edcm';//constant integer DRUID_CLAW_M       = 'edcm'
		public const int DRYAD = 'edry';//constant integer DRYAD              = 'edry'
		public const int HIPPO = 'ehip';//constant integer HIPPO              = 'ehip'
		public const int HIPPO_RIDER = 'ehpr';//constant integer HIPPO_RIDER        = 'ehpr'
		public const int HUNTRESS = 'esen';//constant integer HUNTRESS           = 'esen'
		public const int CHIMAERA = 'echm';//constant integer CHIMAERA           = 'echm'
		public const int ENT = 'efon';//constant integer ENT                = 'efon'
		public const int MOUNTAIN_GIANT = 'emtg';//constant integer MOUNTAIN_GIANT     = 'emtg'
		public const int FAERIE_DRAGON = 'efdr';//constant integer FAERIE_DRAGON      = 'efdr'
		//
		public const int HIGH_ARCHER = 'nhea';//constant integer HIGH_ARCHER        = 'nhea'
		public const int HIGH_FOOTMAN = 'hcth';//constant integer HIGH_FOOTMAN       = 'hcth'
		public const int HIGH_FOOTMEN = HIGH_FOOTMAN;//constant integer HIGH_FOOTMEN       =  HIGH_FOOTMAN
		public const int HIGH_SWORDMAN = 'hhes';//constant integer HIGH_SWORDMAN      = 'hhes'
		public const int DRAGON_HAWK = 'nws1';//constant integer DRAGON_HAWK        = 'nws1'
		public const int CORRUPT_TREANT = 'nenc';//constant integer CORRUPT_TREANT     = 'nenc'
		public const int POISON_TREANT = 'nenp';//constant integer POISON_TREANT      = 'nenp'
		public const int PLAGUE_TREANT = 'nepl';//constant integer PLAGUE_TREANT      = 'nepl'
		public const int SHANDRIS = 'eshd';//constant integer SHANDRIS           = 'eshd'
		//
		public const int ANCIENT_LORE = 'eaoe';//constant integer ANCIENT_LORE       = 'eaoe'
		public const int ANCIENT_WAR = 'eaom';//constant integer ANCIENT_WAR        = 'eaom'
		public const int ANCIENT_WIND = 'eaow';//constant integer ANCIENT_WIND       = 'eaow'
		public const int TREE_AGES = 'etoa';//constant integer TREE_AGES          = 'etoa'
		public const int TREE_ETERNITY = 'etoe';//constant integer TREE_ETERNITY      = 'etoe'
		public const int TREE_LIFE = 'etol';//constant integer TREE_LIFE          = 'etol'
		public const int ANCIENT_PROTECT = 'etrp';//constant integer ANCIENT_PROTECT    = 'etrp'
		public const int ELF_ALTAR = 'eate';//constant integer ELF_ALTAR          = 'eate'
		public const int BEAR_DEN = 'edol';//constant integer BEAR_DEN           = 'edol'
		public const int CHIMAERA_ROOST = 'edos';//constant integer CHIMAERA_ROOST     = 'edos'
		public const int HUNTERS_HALL = 'edob';//constant integer HUNTERS_HALL       = 'edob'
		public const int MOON_WELL = 'emow';//constant integer MOON_WELL          = 'emow'
		public const int ELF_MINE = 'egol';//constant integer ELF_MINE           = 'egol'
		public const int DEN_OF_WONDERS = 'eden';//constant integer DEN_OF_WONDERS     = 'eden'
		//
		public const int ELF_FARM = 'nefm';//constant integer ELF_FARM           = 'nefm'
		public const int ELF_GUARD_TOWER = 'negt';//constant integer ELF_GUARD_TOWER    = 'negt'
		public const int HIGH_SKY = 'negm';//constant integer HIGH_SKY           = 'negm'
		public const int HIGH_EARTH = 'negf';//constant integer HIGH_EARTH         = 'negf'
		public const int HIGH_TOWER = 'negt';//constant integer HIGH_TOWER         = 'negt'
		public const int ELF_HIGH_BARRACKS = 'nheb';//constant integer ELF_HIGH_BARRACKS  = 'nheb'
		public const int CORRUPT_LIFE = 'nctl';//constant integer CORRUPT_LIFE       = 'nctl'
		public const int CORRUPT_WELL = 'ncmw';//constant integer CORRUPT_WELL       = 'ncmw'
		public const int CORRUPT_PROTECTOR = 'ncap';//constant integer CORRUPT_PROTECTOR  = 'ncap'
		public const int CORRUPT_WAR = 'ncaw';//constant integer CORRUPT_WAR        = 'ncaw'
		//
		public const int UPG_STR_MOON = 'Resm';//constant integer UPG_STR_MOON       = 'Resm'
		public const int UPG_STR_WILD = 'Resw';//constant integer UPG_STR_WILD       = 'Resw'
		public const int UPG_MOON_ARMOR = 'Rema';//constant integer UPG_MOON_ARMOR     = 'Rema'
		public const int UPG_HIDES = 'Rerh';//constant integer UPG_HIDES          = 'Rerh'
		public const int UPG_ULTRAVISION = 'Reuv';//constant integer UPG_ULTRAVISION    = 'Reuv'
		public const int UPG_BLESSING = 'Renb';//constant integer UPG_BLESSING       = 'Renb'
		public const int UPG_SCOUT = 'Resc';//constant integer UPG_SCOUT          = 'Resc'
		public const int UPG_GLAIVE = 'Remg';//constant integer UPG_GLAIVE         = 'Remg'
		public const int UPG_BOWS = 'Reib';//constant integer UPG_BOWS           = 'Reib'
		public const int UPG_MARKSMAN = 'Remk';//constant integer UPG_MARKSMAN       = 'Remk'
		public const int UPG_DRUID_TALON = 'Redt';//constant integer UPG_DRUID_TALON    = 'Redt'
		public const int UPG_DRUID_CLAW = 'Redc';//constant integer UPG_DRUID_CLAW     = 'Redc'
		public const int UPG_ABOLISH = 'Resi';//constant integer UPG_ABOLISH        = 'Resi'
		public const int UPG_CHIM_ACID = 'Recb';//constant integer UPG_CHIM_ACID      = 'Recb'
		public const int UPG_HIPPO_TAME = 'Reht';//constant integer UPG_HIPPO_TAME     = 'Reht'
		public const int UPG_BOLT = 'Repd';//constant integer UPG_BOLT           = 'Repd'
		public const int UPG_MARK_CLAW = 'Reeb';//constant integer UPG_MARK_CLAW      = 'Reeb'
		public const int UPG_MARK_TALON = 'Reec';//constant integer UPG_MARK_TALON     = 'Reec'
		public const int UPG_HARD_SKIN = 'Rehs';//constant integer UPG_HARD_SKIN      = 'Rehs'
		public const int UPG_RESIST_SKIN = 'Rers';//constant integer UPG_RESIST_SKIN    = 'Rers'
		public const int UPG_WELL_SPRING = 'Rews';//constant integer UPG_WELL_SPRING    = 'Rews'
		//
		//
		//
		public const int DEMON_GATE = 'ndmg';//constant integer DEMON_GATE         = 'ndmg'
		public const int FELLHOUND = 'nfel';//constant integer FELLHOUND          = 'nfel'
		public const int INFERNAL = 'ninf';//constant integer INFERNAL           = 'ninf'
		public const int DOOMGUARD = 'nbal';//constant integer DOOMGUARD          = 'nbal'
		public const int SATYR = 'nsty';//constant integer SATYR              = 'nsty'
		public const int TRICKSTER = 'nsat';//constant integer TRICKSTER          = 'nsat'
		public const int SHADOWDANCER = 'nsts';//constant integer SHADOWDANCER       = 'nsts'
		public const int SOULSTEALER = 'nstl';//constant integer SOULSTEALER        = 'nstl'
		public const int HELLCALLER = 'nsth';//constant integer HELLCALLER         = 'nsth'
		public const int SKEL_ARCHER = 'nska';//constant integer SKEL_ARCHER        = 'nska'
		public const int SKEL_MARKSMAN = 'nskm';//constant integer SKEL_MARKSMAN      = 'nskm'
		public const int SKEL_BURNING = 'nskf';//constant integer SKEL_BURNING       = 'nskf'
		public const int SKEL_GIANT = 'nskg';//constant integer SKEL_GIANT         = 'nskg'
		public const int FURBOLG = 'nfrl';//constant integer FURBOLG            = 'nfrl'
		public const int FURBOLG_TRACKER = 'nfrb';//constant integer FURBOLG_TRACKER    = 'nfrb'
		public const int FURBOLG_SHAMAN = 'nfrs';//constant integer FURBOLG_SHAMAN     = 'nfrs'
		public const int FURBOLG_CHAMP = 'nfrg';//constant integer FURBOLG_CHAMP      = 'nfrg'
		public const int FURBOLG_ELDER = 'nfre';//constant integer FURBOLG_ELDER      = 'nfre'
		//
		//
		//
		//
		public const int NAGA_SORCERESS = 'Nngs';//constant integer NAGA_SORCERESS     = 'Nngs'
		public const int NAGA_VASHJ = 'Hvsh';//constant integer NAGA_VASHJ         = 'Hvsh'
		//
		public const int NAGA_DRAGON = 'nsnp';//constant integer NAGA_DRAGON        = 'nsnp'
		public const int NAGA_WITCH = 'nnsw';//constant integer NAGA_WITCH         = 'nnsw'
		public const int NAGA_SERPENT = 'nwgs';//constant integer NAGA_SERPENT       = 'nwgs'
		public const int NAGA_HYDRA = 'nhyc';//constant integer NAGA_HYDRA         = 'nhyc'
		public const int NAGA_SLAVE = 'nmpe';//constant integer NAGA_SLAVE         = 'nmpe'
		public const int NAGA_SNAP_DRAGON = NAGA_DRAGON;//constant integer NAGA_SNAP_DRAGON   =  NAGA_DRAGON
		public const int NAGA_COUATL = NAGA_SERPENT;//constant integer NAGA_COUATL        =  NAGA_SERPENT
		public const int NAGA_SIREN = NAGA_WITCH;//constant integer NAGA_SIREN         =  NAGA_WITCH
		public const int NAGA_MYRMIDON = 'nmyr';//constant integer NAGA_MYRMIDON      = 'nmyr'
		public const int NAGA_REAVER = 'nnmg';//constant integer NAGA_REAVER        = 'nnmg'
		public const int NAGA_TURTLE = NAGA_HYDRA;//constant integer NAGA_TURTLE        =  NAGA_HYDRA
		public const int NAGA_ROYAL = 'nnrg';//constant integer NAGA_ROYAL         = 'nnrg'
		//
		public const int NAGA_TEMPLE = 'nntt';//constant integer NAGA_TEMPLE        = 'nntt'
		public const int NAGA_CORAL = 'nnfm';//constant integer NAGA_CORAL         = 'nnfm'
		public const int NAGA_SHRINE = 'nnsa';//constant integer NAGA_SHRINE        = 'nnsa'
		public const int NAGA_SPAWNING = 'nnsg';//constant integer NAGA_SPAWNING      = 'nnsg'
		public const int NAGA_GUARDIAN = 'nntg';//constant integer NAGA_GUARDIAN      = 'nntg'
		public const int NAGA_ALTAR = 'nnad';//constant integer NAGA_ALTAR         = 'nnad'
		//
		public const int UPG_NAGA_ARMOR = 'Rnam';//constant integer UPG_NAGA_ARMOR     = 'Rnam'
		public const int UPG_NAGA_ATTACK = 'Rnat';//constant integer UPG_NAGA_ATTACK    = 'Rnat'
		public const int UPG_NAGA_ABOLISH = 'Rnsi';//constant integer UPG_NAGA_ABOLISH   = 'Rnsi'
		public const int UPG_SIREN = 'Rnsw';//constant integer UPG_SIREN          = 'Rnsw'
		public const int UPG_NAGA_ENSNARE = 'Rnen';//constant integer UPG_NAGA_ENSNARE   = 'Rnen'
		//
		public const int M1 = 60;//constant integer M1                 =    60
		public const int M2 = 2*60;//constant integer M2                 =  2*60
		public const int M3 = 3*60;//constant integer M3                 =  3*60
		public const int M4 = 4*60;//constant integer M4                 =  4*60
		public const int M5 = 5*60;//constant integer M5                 =  5*60
		public const int M6 = 6*60;//constant integer M6                 =  6*60
		public const int M7 = 7*60;//constant integer M7                 =  7*60
		public const int M8 = 8*60;//constant integer M8                 =  8*60
		public const int M9 = 9*60;//constant integer M9                 =  9*60
		public const int M10 = 10*60;//constant integer M10                = 10*60
		public const int M11 = 11*60;//constant integer M11                = 11*60
		public const int M12 = 12*60;//constant integer M12                = 12*60
		public const int M13 = 13*60;//constant integer M13                = 13*60
		public const int M14 = 14*60;//constant integer M14                = 14*60
		public const int M15 = 15*60;//constant integer M15                = 15*60
		public const int EASY = 1;//constant integer EASY               = 1
		public const int NORMAL = 2;//constant integer NORMAL             = 2
		public const int HARD = 3;//constant integer HARD               = 3
		public const int INSANE = 4;//constant integer INSANE             = 4
		public const int MELEE_NEWBIE = 1;//constant integer MELEE_NEWBIE       = 1
		public const int MELEE_NORMAL = 2;//constant integer MELEE_NORMAL       = 2
		public const int MELEE_INSANE = 3;//constant integer MELEE_INSANE       = 3
		public const int ATTACK_CAPTAIN = 1;//constant integer ATTACK_CAPTAIN     = 1
		public const int DEFENSE_CAPTAIN = 2;//constant integer DEFENSE_CAPTAIN    = 2
		public const int BOTH_CAPTAINS = 3;//constant integer BOTH_CAPTAINS      = 3
		public const int BUILD_UNIT = 1;//constant integer BUILD_UNIT         = 1
		public const int BUILD_UPGRADE = 2;//constant integer BUILD_UPGRADE      = 2
		public const int BUILD_EXPAND = 3;//constant integer BUILD_EXPAND       = 3
		public const int UPKEEP_TIER1 = 50;//constant integer UPKEEP_TIER1       = 50
		public const int UPKEEP_TIER2 = 80;//constant integer UPKEEP_TIER2       = 80
		//
		public static player ai_player;//player  ai_player
		public static int sleep_seconds;//integer sleep_seconds
		public static int total_gold = 0;//integer total_gold              = 0
		public static int total_wood = 0;//integer total_wood              = 0
		public static int gold_buffer = 0;//integer gold_buffer             = 0
		public static int difficulty = NORMAL;//integer difficulty              = NORMAL
		public static int exp_seen = 0;//integer exp_seen                = 0
		public static int racial_farm = 'hhou';//integer racial_farm             = 'hhou'
		public static int hero_id = 'Hamg';//integer hero_id                 = 'Hamg'
		public static int hero_id2 = 'Hmkg';//integer hero_id2                = 'Hmkg'
		public static int hero_id3 = 'Hpal';//integer hero_id3                = 'Hpal'
		public static int[] skill;//integer array skill
		public static int[] skills1;//integer array skills1
		public static int[] skills2;//integer array skills2
		public static int[] skills3;//integer array skills3
		public static int max_hero_level = 0;//integer max_hero_level          = 0
		public static int[] harass_qty;//integer array harass_qty
		public static int[] harass_max;//integer array harass_max
		public static int[] harass_units;//integer array harass_units
		public static int harass_length = 0;//integer harass_length           = 0
		public static int[] defense_qty;//integer array defense_qty
		public static int[] defense_units;//integer array defense_units
		public static int defense_length = 0;//integer defense_length          = 0
		public static int[] build_qty;//integer array build_qty
		public static int[] build_type;//integer array build_type
		public static int[] build_item;//integer array build_item
		public static int[] build_town;//integer array build_town
		public static int build_length = 0;//integer build_length            = 0
		public static int campaign_gold_peons = 5;//integer campaign_gold_peons     = 5
		public static int campaign_wood_peons = 3;//integer campaign_wood_peons     = 3
		public static int campaign_basics_speed = 5;//integer campaign_basics_speed   = 5
		public static int min_creeps = -1;//integer min_creeps              = -1
		public static int max_creeps = -1;//integer max_creeps              = -1
		public static bool harvest_town1 = true;//boolean harvest_town1           = true
		public static bool harvest_town2 = true;//boolean harvest_town2           = true
		public static bool harvest_town3 = true;//boolean harvest_town3           = true
		public static bool do_campaign_farms = true;//boolean do_campaign_farms       = true
		public static bool two_heroes = false;//boolean two_heroes              = false
		public static bool allow_air_creeps = false;//boolean allow_air_creeps        = false
		public static bool take_exp = false;//boolean take_exp                = false
		public static bool allow_signal_abort = false;//boolean allow_signal_abort      = false
		public static bool ready_for_zeppelin = true;//boolean ready_for_zeppelin      = true
		public static bool get_zeppelin = false;//boolean get_zeppelin            = false
		public static bool build_campaign_attackers = true;//boolean build_campaign_attackers = true
		public static bool do_debug_cheats = false;//boolean do_debug_cheats         = false
		public static bool trace_on = true;//boolean trace_on                = true
		public static bool zep_next_wave = false;//boolean zep_next_wave           = false
		public static bool form_group_timeouts = true;//boolean form_group_timeouts     = true
		//
		private player PlayerEx(int slot) {//function PlayerEx takes integer slot returns player
			return Player(slot-1);//return Player(slot-1)
		}//endfunction
		//
		private void Trace(string message) {//function Trace takes string message returns nothing
			if (trace_on) {//if trace_on then
				DisplayText(GetAiPlayer(), message);//call DisplayText(GetAiPlayer(),message)
			}//endif
		}//endfunction
		//
		private void TraceI(string message, int val) {//function TraceI takes string message, integer val returns nothing
			if (trace_on) {//if trace_on then
				DisplayTextI(GetAiPlayer(), message, val);//call DisplayTextI(GetAiPlayer(),message,val)
			}//endif
		}//endfunction
		//
		private void TraceII(string message, int v1, int v2) {//function TraceII takes string message, integer v1, integer v2 returns nothing
			if (trace_on) {//if trace_on then
				DisplayTextII(GetAiPlayer(), message, v1, v2);//call DisplayTextII(GetAiPlayer(),message,v1,v2)
			}//endif
		}//endfunction
		//
		private void TraceIII(string message, int v1, int v2, int v3) {//function TraceIII takes string message, integer v1, integer v2, integer v3 returns nothing
			if (trace_on) {//if trace_on then
				DisplayTextIII(GetAiPlayer(), message, v1, v2, v3);//call DisplayTextIII(GetAiPlayer(),message,v1,v2,v3)
			}//endif
		}//endfunction
		//
		private void InitAI() {//function InitAI takes nothing returns nothing
			ai_player = Player(GetAiPlayer());//set ai_player = Player(GetAiPlayer())
			sleep_seconds = 0;//set sleep_seconds = 0
			StopGathering();//call StopGathering()
		}//endfunction
		//
		private void StandardAI(code heroes, code peons, code attacks) {//function StandardAI takes code heroes, code peons, code attacks returns nothing
			bool isNewbie = (MeleeDifficulty() == MELEE_NEWBIE);//local boolean isNewbie = (MeleeDifficulty() == MELEE_NEWBIE)
			InitAI();//call InitAI()
			SetMeleeAI();//call SetMeleeAI()
			SetDefendPlayer(true);//call SetDefendPlayer(true)
			SetGroupsFlee(not isNewbie);//call SetGroupsFlee(not isNewbie)
			SetHeroesBuyItems(not isNewbie);//call SetHeroesBuyItems(not isNewbie)
			SetHeroesFlee(true);//call SetHeroesFlee(true)
			SetHeroesTakeItems(true);//call SetHeroesTakeItems(true)
			SetIgnoreInjured(true);//call SetIgnoreInjured(true)
			SetPeonsRepair(true);//call SetPeonsRepair(true)
			SetSmartArtillery(not isNewbie);//call SetSmartArtillery(not isNewbie)
			SetTargetHeroes(not isNewbie);//call SetTargetHeroes(not isNewbie)
			SetUnitsFlee(not isNewbie);//call SetUnitsFlee(not isNewbie)
			SetWatchMegaTargets(true);//call SetWatchMegaTargets(true)
			CreateCaptains();//call CreateCaptains()
			SetHeroLevels(heroes);//call SetHeroLevels(heroes)
			Sleep(0.1);//call Sleep(0.1)
			StartThread(peons);//call StartThread(peons)
			StartThread(attacks);//call StartThread(attacks)
		}//endfunction
		//
		//
		//
		private int Min(int A, int B) {//function Min takes integer A, integer B returns integer
			if (A < B) {//if A < B then
				return A;//return A
			} else {//else
				return B;//return B
			}//endif
		}//endfunction
		private int Max(int A, int B) {//function Max takes integer A, integer B returns integer
			if (A > B) {//if A > B then
				return A;//return A
			} else {//else
				return B;//return B
			}//endif
		}//endfunction
		private void SetZepNextWave() {//function SetZepNextWave takes nothing returns nothing
			zep_next_wave = true;//set zep_next_wave = true
		}//endfunction
		private void SuicideSleep(int seconds) {//function SuicideSleep takes integer seconds returns nothing
			sleep_seconds = sleep_seconds - seconds;//set sleep_seconds = sleep_seconds - seconds
			while (true) {//loop
				if (seconds <= 0) { break; }//exitwhen seconds <= 0
				if (allow_signal_abort && CommandsWaiting() != 0) { break; }//exitwhen allow_signal_abort and CommandsWaiting() != 0
				if (seconds >= 5) {//if seconds >= 5 then
					Sleep(5);//call Sleep(5)
					seconds = seconds - 5;//set seconds = seconds - 5
				} else {//else
					Sleep(seconds);//call Sleep(seconds)
					seconds = 0;//set seconds = 0
				}//endif
			}//endloop
		}//endfunction
		//
		private int WaitForSignal() {//function WaitForSignal takes nothing returns integer
			int cmd;//local integer cmd
			bool display = false;//local boolean display = false
			while (true) {//loop
				if (CommandsWaiting() != 0) { break; }//exitwhen CommandsWaiting() != 0
				//
				Trace("waiting for a signal to begin AI script...\n");//call Trace("waiting for a signal to begin AI script...\n")
				display = true;//set display = true
				Sleep(2);//call Sleep(2)
				if (CommandsWaiting() != 0) { break; }//exitwhen CommandsWaiting() != 0
				Sleep(2);//call Sleep(2)
				if (CommandsWaiting() != 0) { break; }//exitwhen CommandsWaiting() != 0
				Sleep(2);//call Sleep(2)
				if (CommandsWaiting() != 0) { break; }//exitwhen CommandsWaiting() != 0
				Sleep(2);//call Sleep(2)
				if (CommandsWaiting() != 0) { break; }//exitwhen CommandsWaiting() != 0
				Sleep(2);//call Sleep(2)
				//
			}//endloop
			//
			if (display) {//if display then
				Trace("signal received, beginning AI script\n");//call Trace("signal received, beginning AI script\n")
			}//endif
			//
			cmd = GetLastCommand();//set cmd = GetLastCommand()
			PopLastCommand();//call PopLastCommand()
			return cmd;//return cmd
		}//endfunction
		//
		private void SetWoodPeons(int count) {//function SetWoodPeons takes integer count returns nothing
			campaign_wood_peons = count;//set campaign_wood_peons = count
		}//endfunction
		//
		private void SetGoldPeons(int count) {//function SetGoldPeons takes integer count returns nothing
			campaign_gold_peons = count;//set campaign_gold_peons = count
		}//endfunction
		//
		private void SetHarvestLumber(bool harvest) {//function SetHarvestLumber takes boolean harvest returns nothing
			if (harvest) {//if harvest then
				campaign_wood_peons = 3;//set campaign_wood_peons = 3
			} else {//else
				campaign_wood_peons = 0;//set campaign_wood_peons = 0
			}//endif
		}//endfunction
		//
		private void SetFormGroupTimeouts(bool state) {//function SetFormGroupTimeouts takes boolean state returns nothing
			form_group_timeouts = state;//set form_group_timeouts = state
		}//endfunction
		//
		private void DoCampaignFarms(bool state) {//function DoCampaignFarms takes boolean state returns nothing
			do_campaign_farms = state;//set do_campaign_farms = state
		}//endfunction
		//
		private unit GetMinorCreep() {//function GetMinorCreep takes nothing returns unit
			return GetCreepCamp(0,9,false);//return GetCreepCamp(0,9,false)
		}//endfunction
		//
		private unit GetMajorCreep() {//function GetMajorCreep takes nothing returns unit
			return GetCreepCamp(10,100,allow_air_creeps);//return GetCreepCamp(10,100,allow_air_creeps)
		}//endfunction
		//
		private int GetGold() {//function GetGold takes nothing returns integer
			return GetPlayerState(ai_player,PLAYER_STATE_RESOURCE_GOLD);//return GetPlayerState(ai_player,PLAYER_STATE_RESOURCE_GOLD)
		}//endfunction
		//
		private int GetWood() {//function GetWood takes nothing returns integer
			return GetPlayerState(ai_player,PLAYER_STATE_RESOURCE_LUMBER);//return GetPlayerState(ai_player,PLAYER_STATE_RESOURCE_LUMBER)
		}//endfunction
		//
		private void InitBuildArray() {//function InitBuildArray takes nothing returns nothing
			build_length = 0;//set build_length = 0
		}//endfunction
		//
		private void InitAssaultGroup() {//function InitAssaultGroup takes nothing returns nothing
			harass_length = 0;//set harass_length = 0
		}//endfunction
		//
		private void InitDefenseGroup() {//function InitDefenseGroup takes nothing returns nothing
			defense_length = 0;//set defense_length = 0
		}//endfunction
		//
		private void InitMeleeGroup() {//function InitMeleeGroup takes nothing returns nothing
			InitAssaultGroup();//call InitAssaultGroup()
			RemoveInjuries();//call RemoveInjuries()
			RemoveSiege();//call RemoveSiege()
		}//endfunction
		//
		private void PrepFullSuicide() {//function PrepFullSuicide takes nothing returns nothing
			InitAssaultGroup();//call InitAssaultGroup()
			InitDefenseGroup();//call InitDefenseGroup()
			campaign_gold_peons = 0;//set campaign_gold_peons = 0
			campaign_wood_peons = 0;//set campaign_wood_peons = 0
		}//endfunction
		//
		private void SetReplacements(int easy, int med, int hard) {//function SetReplacements takes integer easy, integer med, integer hard returns nothing
			if (difficulty == EASY) {//if difficulty == EASY then
				SetReplacementCount(easy);//call SetReplacementCount(easy)
			} else if (difficulty == NORMAL) {//elseif difficulty == NORMAL then
				SetReplacementCount(med);//call SetReplacementCount(med)
			} else {//else
				SetReplacementCount(hard);//call SetReplacementCount(hard)
			}//endif
		}//endfunction
		//
		private void StartTownBuilder(code func) {//function StartTownBuilder takes code func returns nothing
			StartThread(func);//call StartThread(func)
		}//endfunction
		//
		private void SetBuildAll(int t, int qty, int unitid, int town) {//function SetBuildAll takes integer t, integer qty, integer unitid, integer town returns nothing
			if (qty > 0) {//if qty > 0 then
				build_qty[build_length] = qty;//set build_qty[build_length] = qty
				build_type[build_length] = t;//set build_type[build_length] = t
				build_item[build_length] = unitid;//set build_item[build_length] = unitid
				build_town[build_length] = town;//set build_town[build_length] = town
				build_length = build_length + 1;//set build_length = build_length + 1
			}//endif
		}//endfunction
		//
		private void SetBuildUnit(int qty, int unitid) {//function SetBuildUnit takes integer qty, integer unitid returns nothing
			SetBuildAll(CommonAi.BUILD_UNIT, qty, unitid, -1);//call SetBuildAll(BUILD_UNIT,qty,unitid,-1)
		}//endfunction
		//
		private void SetBuildNext(int qty, int unitid) {//function SetBuildNext takes integer qty, integer unitid returns nothing
			int has = GetUnitCount(unitid);//local integer has = GetUnitCount(unitid)
			if (has >= qty) {//if has >= qty then
				return;//return
			}//endif
			SetBuildAll(CommonAi.BUILD_UNIT, GetUnitCountDone(unitid)+1, unitid, -1);//call SetBuildAll(BUILD_UNIT,GetUnitCountDone(unitid)+1,unitid,-1)
		}//endfunction
		//
		private void SetBuildUnitEx(int easy, int med, int hard, int unitid) {//function SetBuildUnitEx takes integer easy, integer med, integer hard, integer unitid returns nothing
			if (difficulty == EASY) {//if difficulty == EASY then
				SetBuildAll(CommonAi.BUILD_UNIT, easy, unitid, -1);//call SetBuildAll(BUILD_UNIT,easy,unitid,-1)
			} else if (difficulty == NORMAL) {//elseif difficulty == NORMAL then
				SetBuildAll(CommonAi.BUILD_UNIT, med, unitid, -1);//call SetBuildAll(BUILD_UNIT,med,unitid,-1)
			} else {//else
				SetBuildAll(CommonAi.BUILD_UNIT, hard, unitid, -1);//call SetBuildAll(BUILD_UNIT,hard,unitid,-1)
			}//endif
		}//endfunction
		//
		private void SecondaryTown(int town, int qty, int unitid) {//function SecondaryTown takes integer town, integer qty, integer unitid returns nothing
			SetBuildAll(CommonAi.BUILD_UNIT, qty, unitid, town);//call SetBuildAll(BUILD_UNIT,qty,unitid,town)
		}//endfunction
		//
		private void SecTown(int town, int qty, int unitid) {//function SecTown takes integer town, integer qty, integer unitid returns nothing
			SetBuildAll(CommonAi.BUILD_UNIT, qty, unitid, town);//call SetBuildAll(BUILD_UNIT,qty,unitid,town)
		}//endfunction
		//
		private void SetBuildUpgr(int qty, int unitid) {//function SetBuildUpgr takes integer qty, integer unitid returns nothing
			if (MeleeDifficulty() != MELEE_NEWBIE || qty == 1) {//if MeleeDifficulty() != MELEE_NEWBIE or qty == 1 then
				SetBuildAll(CommonAi.BUILD_UPGRADE, qty, unitid, -1);//call SetBuildAll(BUILD_UPGRADE,qty,unitid,-1)
			}//endif
		}//endfunction
		//
		private void SetBuildUpgrEx(int easy, int med, int hard, int unitid) {//function SetBuildUpgrEx takes integer easy, integer med, integer hard, integer unitid returns nothing
			if (difficulty == EASY) {//if difficulty == EASY then
				SetBuildAll(CommonAi.BUILD_UPGRADE, easy, unitid, -1);//call SetBuildAll(BUILD_UPGRADE,easy,unitid,-1)
			} else if (difficulty == NORMAL) {//elseif difficulty == NORMAL then
				SetBuildAll(CommonAi.BUILD_UPGRADE, med, unitid, -1);//call SetBuildAll(BUILD_UPGRADE,med,unitid,-1)
			} else {//else
				SetBuildAll(CommonAi.BUILD_UPGRADE, hard, unitid, -1);//call SetBuildAll(BUILD_UPGRADE,hard,unitid,-1)
			}//endif
		}//endfunction
		//
		private void SetBuildExpa(int qty, int unitid) {//function SetBuildExpa takes integer qty, integer unitid returns nothing
			SetBuildAll(CommonAi.BUILD_EXPAND, qty, unitid, -1);//call SetBuildAll(BUILD_EXPAND,qty,unitid,-1)
		}//endfunction
		//
		private bool StartUpgrade(int level, int upgid) {//function StartUpgrade takes integer level, integer upgid returns boolean
			int gold_cost;//local integer gold_cost
			int wood_cost;//local integer wood_cost
			if (GetUpgradeLevel(upgid) >= level) {//if GetUpgradeLevel(upgid) >= level then
				return true;//return true
			}//endif
			gold_cost = GetUpgradeGoldCost(upgid);//set gold_cost = GetUpgradeGoldCost(upgid)
			if (total_gold < gold_cost) {//if total_gold < gold_cost then
				return false;//return false
			}//endif
			wood_cost = GetUpgradeWoodCost(upgid);//set wood_cost = GetUpgradeWoodCost(upgid)
			if (total_wood < wood_cost) {//if total_wood < wood_cost then
				return false;//return false
			}//endif
			return SetUpgrade(upgid);//return SetUpgrade(upgid)
		}//endfunction
		//
		private void BuildFactory(int unitid) {//function BuildFactory takes integer unitid returns nothing
			if (GetGold() > 1000 && GetWood() > 500) {//if GetGold() > 1000 and GetWood() > 500 then
				SetBuildUnit(2, unitid);//call SetBuildUnit( 2, unitid )
			} else {//else
				SetBuildUnit(1, unitid);//call SetBuildUnit( 1, unitid )
			}//endif
		}//endfunction
		//
		private bool HallsCompleted(int unitid) {//function HallsCompleted takes integer unitid returns boolean
			return GetUnitCount(unitid) == GetUnitCountDone(unitid);//return GetUnitCount(unitid) == GetUnitCountDone(unitid)
		}//endfunction
		//
		private void GuardSecondary(int townid, int qty, int unitid) {//function GuardSecondary takes integer townid, integer qty, integer unitid returns nothing
			if (TownHasHall(townid) && TownHasMine(townid)) {//if TownHasHall(townid) and TownHasMine(townid) then
				SecondaryTown(townid, qty, unitid);//call SecondaryTown( townid, qty, unitid )
			}//endif
		}//endfunction
		//
		private int GetUnitCountEx(int unitid, bool only_done, int townid) {//function GetUnitCountEx takes integer unitid, boolean only_done, integer townid returns integer
			if (townid == -1) {//if townid == -1 then
				if (only_done) {//if only_done then
					return GetUnitCountDone(unitid);//return GetUnitCountDone(unitid)
				} else {//else
					return GetUnitCount(unitid);//return GetUnitCount(unitid)
				}//endif
			} else {//else
				return GetTownUnitCount(unitid,townid,only_done);//return GetTownUnitCount(unitid,townid,only_done)
			}//endif
		}//endfunction
		//
		private int TownCountEx(int unitid, bool only_done, int townid) {//function TownCountEx takes integer unitid, boolean only_done, integer townid returns integer
			int have_qty = GetUnitCountEx(unitid,only_done,townid);//local integer have_qty = GetUnitCountEx(unitid,only_done,townid)
			if (unitid == TOWN_HALL) {//if unitid == TOWN_HALL then
				have_qty = have_qty + GetUnitCountEx(KEEP,false,townid) + GetUnitCountEx(CASTLE,false,townid);//set have_qty = have_qty + GetUnitCountEx(KEEP,false,townid) + GetUnitCountEx(CASTLE,false,townid)
			} else if (unitid == KEEP) {//elseif unitid == KEEP then
				have_qty = have_qty  + GetUnitCountEx(CASTLE,false,townid);//set have_qty = have_qty  + GetUnitCountEx(CASTLE,false,townid)
			} else if (unitid == WATCH_TOWER) {//elseif unitid == WATCH_TOWER then
				have_qty = have_qty + GetUnitCountEx(GUARD_TOWER,false,townid) + GetUnitCountEx(CANNON_TOWER,false,townid) + GetUnitCountEx(ARCANE_TOWER,false,townid);//set have_qty = have_qty + GetUnitCountEx(GUARD_TOWER,false,townid) + GetUnitCountEx(CANNON_TOWER,false,townid) + GetUnitCountEx(ARCANE_TOWER,false,townid)
			} else if (unitid == PEASANT) {//elseif unitid == PEASANT then
				have_qty = have_qty + GetUnitCountEx(MILITIA,false,townid);//set have_qty = have_qty + GetUnitCountEx(MILITIA,false,townid)
			} else if (unitid == GREAT_HALL) {//elseif unitid == GREAT_HALL then
				have_qty = have_qty + GetUnitCountEx(STRONGHOLD,false,townid) + GetUnitCountEx(FORTRESS,false,townid);//set have_qty = have_qty + GetUnitCountEx(STRONGHOLD,false,townid) + GetUnitCountEx(FORTRESS,false,townid)
			} else if (unitid == STRONGHOLD) {//elseif unitid == STRONGHOLD then
				have_qty = have_qty + GetUnitCountEx(FORTRESS,false,townid);//set have_qty = have_qty + GetUnitCountEx(FORTRESS,false,townid)
			} else if (unitid == HEAD_HUNTER) {//elseif unitid == HEAD_HUNTER then
				have_qty = have_qty + GetUnitCountEx(BERSERKER,false,townid);//set have_qty = have_qty + GetUnitCountEx(BERSERKER,false,townid)
			} else if (unitid == SPIRIT_WALKER) {//elseif unitid == SPIRIT_WALKER then
				have_qty = have_qty + GetUnitCountEx(SPIRIT_WALKER_M,false,townid);//set have_qty = have_qty + GetUnitCountEx(SPIRIT_WALKER_M,false,townid)
			} else if (unitid == SPIRIT_WALKER_M) {//elseif unitid == SPIRIT_WALKER_M then
				have_qty = have_qty + GetUnitCountEx(SPIRIT_WALKER,only_done,townid);//set have_qty = have_qty + GetUnitCountEx(SPIRIT_WALKER,only_done,townid)
			} else if (unitid == NECROPOLIS_1) {//elseif unitid == NECROPOLIS_1 then
				have_qty = have_qty + GetUnitCountEx(NECROPOLIS_2,false,townid) + GetUnitCountEx(NECROPOLIS_3,false,townid);//set have_qty = have_qty + GetUnitCountEx(NECROPOLIS_2,false,townid) + GetUnitCountEx(NECROPOLIS_3,false,townid)
			} else if (unitid == NECROPOLIS_2) {//elseif unitid == NECROPOLIS_2 then
				have_qty = have_qty + GetUnitCountEx(NECROPOLIS_3,false,townid);//set have_qty = have_qty + GetUnitCountEx(NECROPOLIS_3,false,townid)
			} else if (unitid == ZIGGURAT_1) {//elseif unitid == ZIGGURAT_1 then
				have_qty = have_qty + GetUnitCountEx(ZIGGURAT_2,false,townid) + GetUnitCountEx(ZIGGURAT_FROST,false,townid);//set have_qty = have_qty + GetUnitCountEx(ZIGGURAT_2,false,townid) + GetUnitCountEx(ZIGGURAT_FROST,false,townid)
			} else if (unitid == GARGOYLE) {//elseif unitid == GARGOYLE then
				have_qty = have_qty + GetUnitCountEx(GARGOYLE_MORPH,false,townid);//set have_qty = have_qty + GetUnitCountEx(GARGOYLE_MORPH,false,townid)
			} else if (unitid == TREE_LIFE) {//elseif unitid == TREE_LIFE then
				have_qty = have_qty + GetUnitCountEx(TREE_AGES,false,townid) + GetUnitCountEx(TREE_ETERNITY,false,townid);//set have_qty = have_qty + GetUnitCountEx(TREE_AGES,false,townid) + GetUnitCountEx(TREE_ETERNITY,false,townid)
			} else if (unitid == TREE_AGES) {//elseif unitid == TREE_AGES then
				have_qty = have_qty + GetUnitCountEx(TREE_ETERNITY,false,townid);//set have_qty = have_qty + GetUnitCountEx(TREE_ETERNITY,false,townid)
			} else if (unitid == DRUID_TALON) {//elseif unitid == DRUID_TALON then
				have_qty = have_qty + GetUnitCountEx(DRUID_TALON_M,false,townid);//set have_qty = have_qty + GetUnitCountEx(DRUID_TALON_M,false,townid)
			} else if (unitid == DRUID_TALON_M) {//elseif unitid == DRUID_TALON_M then
				have_qty = have_qty + GetUnitCountEx(DRUID_TALON,only_done,townid);//set have_qty = have_qty + GetUnitCountEx(DRUID_TALON,only_done,townid)
			} else if (unitid == DRUID_CLAW) {//elseif unitid == DRUID_CLAW then
				have_qty = have_qty + GetUnitCountEx(DRUID_CLAW_M,false,townid);//set have_qty = have_qty + GetUnitCountEx(DRUID_CLAW_M,false,townid)
			} else if (unitid == DRUID_CLAW_M) {//elseif unitid == DRUID_CLAW_M then
				have_qty = have_qty + GetUnitCountEx(DRUID_CLAW,only_done,townid);//set have_qty = have_qty + GetUnitCountEx(DRUID_CLAW,only_done,townid)
			} else if (unitid == ILLIDAN) {//elseif unitid == ILLIDAN then
				have_qty = have_qty + GetUnitCountEx(ILLIDAN_DEMON,false,townid);//set have_qty = have_qty + GetUnitCountEx(ILLIDAN_DEMON,false,townid)
			}//endif
			return have_qty;//return have_qty
		}//endfunction
		//
		private int TownCountDone(int base) {//function TownCountDone takes integer base returns integer
			return TownCountEx(base,true,-1);//return TownCountEx(base,true,-1)
		}//endfunction
		//
		private int TownCount(int base) {//function TownCount takes integer base returns integer
			return TownCountEx(base,false,-1);//return TownCountEx(base,false,-1)
		}//endfunction
		//
		private void BasicExpansion(bool build_it, int unitid) {//function BasicExpansion takes boolean build_it, integer unitid returns nothing
			if (build_it && HallsCompleted(unitid)) {//if build_it and HallsCompleted(unitid) then
				SetBuildExpa(TownCount(unitid)+1, unitid);//call SetBuildExpa( TownCount(unitid)+1, unitid )
			}//endif
		}//endfunction
		//
		private void UpgradeAll(int baseid, int newid) {//function UpgradeAll takes integer baseid, integer newid returns nothing
			SetBuildUnit(TownCountDone(baseid), newid);//call SetBuildUnit( TownCountDone(baseid), newid )
		}//endfunction
		//
		private int TownCountTown(int base, int townid) {//function TownCountTown takes integer base, integer townid returns integer
			return TownCountEx(base,false,townid);//return TownCountEx(base,false,townid)
		}//endfunction
		//
		//
		//
		private void FoodPool(int food, bool weak, int id1, int use1, bool strong, int id2, int use2) {//function FoodPool takes integer food, boolean weak, integer id1, integer use1, boolean strong, integer id2, integer use2 returns nothing
			if (strong) {//if strong then
				SetBuildUnit((food - use1 * TownCount(id1)) / use2, id2);//call SetBuildUnit( (food - use1 * TownCount(id1)) / use2, id2 )
			} else if (weak) {//elseif weak then
				SetBuildUnit((food - use2 * TownCount(id2)) / use1, id1);//call SetBuildUnit( (food - use2 * TownCount(id2)) / use1, id1 )
			}//endif
		}//endfunction
		//
		//
		//
		private void MeleeTownHall(int townid, int unitid) {//function MeleeTownHall takes integer townid, integer unitid returns nothing
			if (TownHasMine(townid) && !TownHasHall(townid)) {//if TownHasMine(townid) and not TownHasHall(townid) then
				SecondaryTown(townid, 1, unitid);//call SecondaryTown ( townid, 1, unitid )
			}//endif
		}//endfunction
		//
		private void WaitForUnits(int unitid, int qty) {//function WaitForUnits takes integer unitid, integer qty returns nothing
			while (true) {//loop
				if (TownCountDone(unitid) == qty) { break; }//exitwhen TownCountDone(unitid) == qty
				Sleep(2);//call Sleep(2)
			}//endloop
		}//endfunction
		//
		private bool StartUnit(int ask_qty, int unitid, int town) {//function StartUnit takes integer ask_qty, integer unitid, integer town returns boolean
			int have_qty;//local integer have_qty
			int need_qty;//local integer need_qty
			int afford_gold;//local integer afford_gold
			int afford_wood;//local integer afford_wood
			int afford_qty;//local integer afford_qty
			int gold_cost;//local integer gold_cost
			int wood_cost;//local integer wood_cost
			//
			//
			//
			if (town == -1) {//if town == -1 then
				have_qty = TownCount(unitid);//set have_qty = TownCount(unitid)
			} else {//else
				have_qty = TownCountTown(unitid,town);//set have_qty = TownCountTown(unitid,town)
			}//endif
			if (have_qty >= ask_qty) {//if have_qty >= ask_qty then
				return true;//return true
			}//endif
			need_qty = ask_qty - have_qty;//set need_qty = ask_qty - have_qty
			//
			//
			//
			gold_cost = GetUnitGoldCost(unitid);//set gold_cost = GetUnitGoldCost(unitid)
			wood_cost = GetUnitWoodCost(unitid);//set wood_cost = GetUnitWoodCost(unitid)
			if (gold_cost == 0) {//if gold_cost == 0 then
				afford_gold = need_qty;//set afford_gold = need_qty
			} else {//else
				afford_gold = total_gold / gold_cost;//set afford_gold = total_gold / gold_cost
			}//endif
			if (afford_gold < need_qty) {//if afford_gold < need_qty then
				afford_qty = afford_gold;//set afford_qty = afford_gold
			} else {//else
				afford_qty = need_qty;//set afford_qty = need_qty
			}//endif
			if (wood_cost == 0) {//if wood_cost == 0 then
				afford_wood = need_qty;//set afford_wood = need_qty
			} else {//else
				afford_wood = total_wood / wood_cost;//set afford_wood = total_wood / wood_cost
			}//endif
			if (afford_wood < afford_qty) {//if afford_wood < afford_qty then
				afford_qty = afford_wood;//set afford_qty = afford_wood
			}//endif
			//
			if (afford_qty < 1) {//if afford_qty < 1 then
				return false;//return false
			}//endif
			//
			//
			//
			//
			total_gold = total_gold - gold_cost * need_qty;//set total_gold = total_gold - gold_cost * need_qty
			total_wood = total_wood - wood_cost * need_qty;//set total_wood = total_wood - wood_cost * need_qty
			if (total_gold < 0) {//if total_gold < 0 then
				total_gold = 0;//set total_gold = 0
			}//endif
			if (total_wood < 0) {//if total_wood < 0 then
				total_wood = 0;//set total_wood = 0
			}//endif
			//
			//
			//
			//
			//
			return SetProduce(afford_qty,unitid,town);//return SetProduce(afford_qty,unitid,town)
		}//endfunction
		//
		private void WaitForTown(int towns, int townid) {//function WaitForTown takes integer towns, integer townid returns nothing
			int i = 0;//local integer i = 0
			while (true) {//loop
				Sleep(10);//call Sleep(10)
				if (TownCount(townid) >= towns) { break; }//exitwhen TownCount(townid) >= towns
				i = i + 1;//set i = i + 1
				if (i == 12) { break; }//exitwhen i == 12
			}//endloop
		}//endfunction
		//
		private bool StartExpansion(int qty, int hall) {//function StartExpansion takes integer qty, integer hall returns boolean
			int count;//local integer count
			int town;//local integer town
			unit peon;//local unit    peon
			int gold_cost;//local integer gold_cost
			count = TownCount(hall);//set count = TownCount(hall)
			if (count >= qty) {//if count >= qty then
				return true;//return true
			}//endif
			town = GetNextExpansion();//set town = GetNextExpansion()
			if (town == -1) {//if town == -1 then
				return true;//return true
			}//endif
			take_exp = true;//set take_exp = true
			gold_cost = GetUnitGoldCost(hall);//set gold_cost = GetUnitGoldCost(hall)
			if (gold_cost > total_gold) {//if gold_cost > total_gold then
				return false;//return false
			}//endif
			total_gold = total_gold - gold_cost;//set total_gold = total_gold - gold_cost
			if (GetExpansionFoe() != null) {//if GetExpansionFoe() != null then
				return true;//return true
			}//endif
			peon = GetExpansionPeon();//set peon = GetExpansionPeon()
			if (peon != null) {//if peon != null then
				return SetExpansion(peon,hall);//return SetExpansion(peon,hall)
			}//endif
			return true;//return true
		}//endfunction
		//
		private void OneBuildLoop() {//function OneBuildLoop takes nothing returns nothing
			int index = 0;//local integer index = 0
			int qty;//local integer qty
			int id;//local integer id
			int tp;//local integer tp
			total_gold = GetGold() - gold_buffer;//set total_gold = GetGold() - gold_buffer
			total_wood = GetWood();//set total_wood = GetWood()
			while (true) {//loop
				if (index == build_length) { break; }//exitwhen index == build_length
				qty = build_qty [index];//set qty = build_qty [index]
				id = build_item[index];//set id  = build_item[index]
				tp = build_type[index];//set tp  = build_type[index]
				//
				if (tp == BUILD_UNIT) {//if tp == BUILD_UNIT then
					if (!StartUnit(qty,id,build_town[index])) {//if not StartUnit(qty,id,build_town[index]) then
						return;//return
					}//endif
					//
				} else if (tp == BUILD_UPGRADE) {//elseif tp == BUILD_UPGRADE then
					StartUpgrade(qty, id);//call StartUpgrade(qty,id)
					//
				} else {//else
					if (!StartExpansion(qty,id)) {//if not StartExpansion(qty,id) then
						return;//return
					}//endif
				}//endif
				index = index + 1;//set index = index + 1
			}//endloop
		}//endfunction
		//
		private void StaggerSleep(float base, float spread) {//function StaggerSleep takes real base, real spread returns nothing
			Sleep(base + spread * I2R(GetAiPlayer()) / I2R(GetPlayers()));//call Sleep(base + spread * I2R(GetAiPlayer()) / I2R(GetPlayers()))
		}//endfunction
		//
		private void BuildLoop() {//function BuildLoop takes nothing returns nothing
			OneBuildLoop();//call OneBuildLoop()
			StaggerSleep(1, 2);//call StaggerSleep(1,2)
			while (true) {//loop
				OneBuildLoop();//call OneBuildLoop()
				Sleep(2);//call Sleep(2)
			}//endloop
		}//endfunction
		//
		private void StartBuildLoop() {//function StartBuildLoop takes nothing returns nothing
			StartThread(function BuildLoop);//call StartThread(function BuildLoop)
		}//endfunction
		//
		private void SetInitialWave(int seconds) {//function SetInitialWave takes integer seconds returns nothing
			sleep_seconds = seconds;//set sleep_seconds = seconds
		}//endfunction
		//
		private void AddSleepSeconds(int seconds) {//function AddSleepSeconds takes integer seconds returns nothing
			sleep_seconds = sleep_seconds + seconds;//set sleep_seconds = sleep_seconds + seconds
		}//endfunction
		//
		private void SleepForever() {//function SleepForever takes nothing returns nothing
			Trace("going to sleep forever\n");//call Trace("going to sleep forever\n")
			while (true) {//loop
				Sleep(100);//call Sleep(100)
			}//endloop
		}//endfunction
		//
		private void PlayGame() {//function PlayGame takes nothing returns nothing
			StartBuildLoop();//call StartBuildLoop()
			SleepForever();//call SleepForever()
		}//endfunction
		//
		private void ConvertNeeds(int unitid) {//function ConvertNeeds takes integer unitid returns nothing
			if (GetUnitCount(unitid) < 1) {//if GetUnitCount(unitid) < 1 then
				StartUnit(1, unitid, -1);//call StartUnit(1,unitid,-1)
			}//endif
		}//endfunction
		//
		private void Conversions(int desire, int unitid) {//function Conversions takes integer desire, integer unitid returns nothing
			if (GetUnitCount(unitid) >= desire) {//if GetUnitCount(unitid) >= desire then
				return;//return
			}//endif
			if (unitid == HIPPO_RIDER) {//if unitid == HIPPO_RIDER then
				ConvertNeeds(CommonAi.ARCHER);//call ConvertNeeds(ARCHER)
				ConvertNeeds(CommonAi.HIPPO);//call ConvertNeeds(HIPPO)
				MergeUnits(desire, CommonAi.ARCHER, CommonAi.HIPPO, CommonAi.HIPPO_RIDER);//call MergeUnits(desire,ARCHER,HIPPO,HIPPO_RIDER)
			} else if (unitid == BLK_SPHINX) {//elseif unitid == BLK_SPHINX then
				ConvertNeeds(CommonAi.OBS_STATUE);//call ConvertNeeds(OBS_STATUE)
				ConvertUnits(desire, CommonAi.OBS_STATUE);//call ConvertUnits(desire,OBS_STATUE)
			}//endif
		}//endfunction
		//
		private void SetAssaultGroup(int qty, int max, int unitid) {//function SetAssaultGroup takes integer qty, integer max, integer unitid returns nothing
			Conversions(max, unitid);//call Conversions(max,unitid)
			if (qty <= 0 && TownCountDone(unitid) == 0) {//if qty <= 0 and TownCountDone(unitid) == 0 then
				return;//return
			}//endif
			harass_qty[harass_length] = qty;//set harass_qty[harass_length] = qty
			harass_max[harass_length] = max;//set harass_max[harass_length] = max
			harass_units[harass_length] = unitid;//set harass_units[harass_length] = unitid
			harass_length = harass_length + 1;//set harass_length = harass_length + 1
		}//endfunction
		//
		private void Interleave3(int e1, int m1, int h1, int u1, int e2, int m2, int h2, int u2, int e3, int m3, int h3, int u3) {//function Interleave3 takes integer e1, integer m1, integer h1, integer u1, integer e2, integer m2, integer h2, integer u2, integer e3, integer m3, integer h3, integer u3 returns nothing
			int i1 = 1;//local integer i1 = 1
			int i2 = 1;//local integer i2 = 1
			int i3 = 1;//local integer i3 = 1
			int q1;//local integer q1
			int q2;//local integer q2
			int q3;//local integer q3
			if (difficulty == EASY) {//if difficulty == EASY then
				q1 = e1;//set q1 = e1
				q2 = e2;//set q2 = e2
				q3 = e3;//set q3 = e3
			} else if (difficulty == NORMAL) {//elseif difficulty == NORMAL then
				q1 = m1;//set q1 = m1
				q2 = m2;//set q2 = m2
				q3 = m3;//set q3 = m3
			} else {//else
				q1 = h1;//set q1 = h1
				q2 = h2;//set q2 = h2
				q3 = h3;//set q3 = h3
			}//endif
			while (true) {//loop
				if (q1<=0 && q2<=0 && q3<=0) { break; }//exitwhen q1<=0 and q2<=0 and q3<=0
				if (q1 > 0) {//if q1 > 0 then
					SetAssaultGroup(i1, i1, u1);//call SetAssaultGroup(i1,i1,u1)
					q1 = q1 - 1;//set q1 = q1 - 1
					i1 = i1 + 1;//set i1 = i1 + 1
				}//endif
				if (q2 > 0) {//if q2 > 0 then
					SetAssaultGroup(i2, i2, u2);//call SetAssaultGroup(i2,i2,u2)
					q2 = q2 - 1;//set q2 = q2 - 1
					i2 = i2 + 1;//set i2 = i2 + 1
				}//endif
				if (q3 > 0) {//if q3 > 0 then
					SetAssaultGroup(i3, i3, u3);//call SetAssaultGroup(i3,i3,u3)
					q3 = q3 - 1;//set q3 = q3 - 1
					i3 = i3 + 1;//set i3 = i3 + 1
				}//endif
			}//endloop
		}//endfunction
		//
		private void SetMeleeGroup(int unitid) {//function SetMeleeGroup takes integer unitid returns nothing
			if (unitid == hero_id) {//if unitid == hero_id then
				SetAssaultGroup(1, 9, unitid);//call SetAssaultGroup(1,9,unitid)
			} else {//else
				SetAssaultGroup((TownCountDone(unitid)*3)/4, 20, unitid);//call SetAssaultGroup((TownCountDone(unitid)*3)/4,20,unitid)
			}//endif
		}//endfunction
		//
		private void CampaignDefender(int level, int qty, int unitid) {//function CampaignDefender takes integer level, integer qty, integer unitid returns nothing
			if (qty > 0 && difficulty >= level) {//if qty > 0 and difficulty >= level then
				defense_qty[defense_length] = qty;//set defense_qty[defense_length] = qty
				defense_units[defense_length] = unitid;//set defense_units[defense_length] = unitid
				defense_length = defense_length + 1;//set defense_length = defense_length + 1
				Conversions(qty, unitid);//call Conversions(qty,unitid)
				SetBuildUnit(qty, unitid);//call SetBuildUnit(qty,unitid)
			}//endif
		}//endfunction
		//
		private void CampaignDefenderEx(int easy, int med, int hard, int unitid) {//function CampaignDefenderEx takes integer easy, integer med, integer hard, integer unitid returns nothing
			if (difficulty == EASY) {//if difficulty == EASY then
				CampaignDefender(CommonAi.EASY, easy, unitid);//call CampaignDefender(EASY,easy,unitid)
			} else if (difficulty == NORMAL) {//elseif difficulty == NORMAL then
				CampaignDefender(DemoAi.NORMAL, med, unitid);//call CampaignDefender(NORMAL,med,unitid)
			} else {//else
				CampaignDefender(CommonAi.HARD, hard, unitid);//call CampaignDefender(HARD,hard,unitid)
			}//endif
		}//endfunction
		//
		private void CampaignAttacker(int level, int qty, int unitid) {//function CampaignAttacker takes integer level, integer qty, integer unitid returns nothing
			if (qty > 0 && difficulty >= level) {//if qty > 0 and difficulty >= level then
				SetAssaultGroup(qty, qty, unitid);//call SetAssaultGroup(qty,qty,unitid)
			}//endif
		}//endfunction
		//
		private void CampaignAttackerEx(int easy, int med, int hard, int unitid) {//function CampaignAttackerEx takes integer easy, integer med, integer hard, integer unitid returns nothing
			if (difficulty == EASY) {//if difficulty == EASY then
				CampaignAttacker(CommonAi.EASY, easy, unitid);//call CampaignAttacker(EASY,easy,unitid)
			} else if (difficulty == NORMAL) {//elseif difficulty == NORMAL then
				CampaignAttacker(DemoAi.NORMAL, med, unitid);//call CampaignAttacker(NORMAL,med,unitid)
			} else {//else
				CampaignAttacker(CommonAi.HARD, hard, unitid);//call CampaignAttacker(HARD,hard,unitid)
			}//endif
		}//endfunction
		//
		private void FormGroup(int seconds, bool testReady) {//function FormGroup takes integer seconds, boolean testReady returns nothing
			int index;//local integer index
			int count;//local integer count
			int unitid;//local integer unitid
			int desire;//local integer desire
			int readyPercent;//local integer readyPercent
			//
			if (testReady == true) {//if testReady == true then
				readyPercent = 50;//set readyPercent = 50
				Trace("forming group, requiring healthy guys\n");//call Trace("forming group, requiring healthy guys\n")
			} else {//else
				readyPercent = 0;//set readyPercent = 0
				Trace("forming group, unit health not important\n");//call Trace("forming group, unit health not important\n")
			}//endif
			Trace("trying to gather forces\n");//call Trace("trying to gather forces\n")
			while (true) {//loop
				SuicideSleep(seconds);//call SuicideSleep(seconds)
				InitAssault();//call InitAssault()
				index = 0;//set index = 0
				while (true) {//loop
					if (index == harass_length) { break; }//exitwhen index == harass_length
					unitid = harass_units[index];//set unitid = harass_units[index]
					desire = harass_max[index];//set desire = harass_max[index]
					count = TownCountDone(unitid);//set count  = TownCountDone(unitid)
					Conversions(desire, unitid);//call Conversions(desire,unitid)
					if (count >= desire) {//if count >= desire then
						AddAssault(desire, unitid);//call AddAssault(desire,unitid)
					} else {//else
						desire = harass_qty[index];//set desire = harass_qty[index]
						if (count < desire) {//if count < desire then
							AddAssault(desire, unitid);//call AddAssault(desire,unitid)
						} else {//else
							AddAssault(count, unitid);//call AddAssault(count,unitid)
						}//endif
					}//endif
					index = index + 1;//set index = index + 1
				}//endloop
				//
				if (form_group_timeouts && (sleep_seconds < -60)) {//if form_group_timeouts and (sleep_seconds < -60) then
					Trace("exit form group -- timeout\n");//call Trace("exit form group -- timeout\n")
				} else if (CaptainInCombat(true)) {//elseif CaptainInCombat(true) then
					Trace("exit form group -- can't form while already in combat\n");//call Trace("exit form group -- can't form while already in combat\n")
				} else if (CaptainIsFull() && CaptainReadiness() >= readyPercent) {//elseif CaptainIsFull() and CaptainReadiness() >= readyPercent then
					Trace("exit form group -- ready\n");//call Trace("exit form group -- ready\n")
				}//endif
				//
				//
				if (form_group_timeouts && (sleep_seconds < -60)) { break; }//exitwhen form_group_timeouts and (sleep_seconds < -60)
				if (CaptainInCombat(true)) { break; }//exitwhen CaptainInCombat(true)
				if (CaptainIsFull() && CaptainReadiness() >= readyPercent) { break; }//exitwhen CaptainIsFull() and CaptainReadiness() >= readyPercent
			}//endloop
		}//endfunction
		//
		private int WavePrepare(int unitid) {//function WavePrepare takes integer unitid returns integer
			return GetUnitBuildTime(unitid);//return GetUnitBuildTime(unitid)
		}//endfunction
		//
		private int PrepTime() {//function PrepTime takes nothing returns integer
			int unitid;//local integer unitid
			int missing;//local integer missing
			int prep;//local integer prep
			int count;//local integer count
			int largest = 30;//local integer largest = 30
			int index = 0;//local integer index = 0
			while (true) {//loop
				if (index == harass_length) { break; }//exitwhen index == harass_length
				unitid = harass_units[index];//set unitid  = harass_units[index]
				missing = harass_qty[index] + IgnoredUnits(unitid) - TownCount(unitid);//set missing = harass_qty[index] + IgnoredUnits(unitid) - TownCount(unitid)
				prep = WavePrepare(unitid) * missing;//set prep    = WavePrepare(unitid) * missing
				if (prep > largest) {//if prep > largest then
					largest = prep;//set largest = prep
				}//endif
				index = index + 1;//set index = index + 1
			}//endloop
			TraceI("next wave will require around %d seconds to build and gather\n", largest);//call TraceI("next wave will require around %d seconds to build and gather\n",largest)
			return largest;//return largest
		}//endfunction
		//
		private bool PrepSuicideOnPlayer(int seconds) {//function PrepSuicideOnPlayer takes integer seconds returns boolean
			int wave_prep = PrepTime();//local integer wave_prep   = PrepTime()
			int save_length;//local integer save_length
			save_length = harass_length;//set save_length = harass_length
			harass_length = 0;//set harass_length = 0
			AddSleepSeconds(seconds);//call AddSleepSeconds(seconds)
			if (sleep_seconds-wave_prep > 0) {//if sleep_seconds-wave_prep > 0 then
				TraceI("going to sleep for %d seconds before gathering next attack wave\n", sleep_seconds-wave_prep);//call TraceI("going to sleep for %d seconds before gathering next attack wave\n",sleep_seconds-wave_prep)
				SuicideSleep(sleep_seconds-wave_prep);//call SuicideSleep(sleep_seconds-wave_prep)
			}//endif
			Trace("preparing suicide attack wave\n");//call Trace("preparing suicide attack wave\n")
			harass_length = save_length;//set harass_length = save_length
			if (harass_length < 1) {//if harass_length < 1 then
				Trace("ERROR - no units specificed, exiting early\n");//call Trace("ERROR - no units specificed, exiting early\n")
				return false;//return false
			}//endif
			return true;//return true
		}//endfunction
		//
		private void SleepUntilAtGoal() {//function SleepUntilAtGoal takes nothing returns nothing
			while (true) {//loop
				if (CaptainRetreating()) { break; }//exitwhen CaptainRetreating()
				if (CaptainAtGoal()) { break; }//exitwhen CaptainAtGoal()
				if (CaptainIsHome()) { break; }//exitwhen CaptainIsHome()
				if (CaptainIsEmpty()) { break; }//exitwhen CaptainIsEmpty()
				SuicideSleep(3);//call SuicideSleep(3)
			}//endloop
		}//endfunction
		//
		private void SleepInCombat() {//function SleepInCombat takes nothing returns nothing
			int count = 0;//local integer count = 0
			while (true) {//loop
				while (true) {//loop
					if (!CaptainInCombat(true)) { break; }//exitwhen not CaptainInCombat(true)
					if (CaptainIsEmpty()) { break; }//exitwhen CaptainIsEmpty()
					SuicideSleep(1);//call SuicideSleep(1)
				}//endloop
				count = count + 1;//set count = count + 1
				if (count >= 8) { break; }//exitwhen count >= 8
				//
				//
			}//endloop
		}//endfunction
		//
		private void AttackMoveXYA(int x, int y) {//function AttackMoveXYA takes integer x, integer y returns nothing
			if (zep_next_wave) {//if zep_next_wave then
				LoadZepWave(x, y);//call LoadZepWave(x,y)
				zep_next_wave = false;//set zep_next_wave = false
			}//endif
			AttackMoveXY(x, y);//call AttackMoveXY(x,y)
			SleepUntilAtGoal();//call SleepUntilAtGoal()
			SleepInCombat();//call SleepInCombat()
		}//endfunction
		//
		private void SuicideOnPlayerWave() {//function SuicideOnPlayerWave takes nothing returns nothing
			Trace("waiting for attack wave to enter combat\n");//call Trace("waiting for attack wave to enter combat\n")
			while (true) {//loop
				//
				if (allow_signal_abort && CommandsWaiting() != 0) {//if allow_signal_abort and CommandsWaiting() != 0 then
					Trace("ABORT -- attack wave override\n");//call Trace("ABORT -- attack wave override\n")
				}//endif
				if (CaptainInCombat(true)) {//if CaptainInCombat(true) then
					Trace("done - captain has entered combat\n");//call Trace("done - captain has entered combat\n")
				}//endif
				if (CaptainIsEmpty()) {//if CaptainIsEmpty() then
					Trace("done - all units are dead\n");//call Trace("done - all units are dead\n")
				}//endif
				if (sleep_seconds < -300) {//if sleep_seconds < -300 then
					Trace("done - timeout, took too long to reach engage the enemy\n");//call Trace("done - timeout, took too long to reach engage the enemy\n")
				}//endif
				//
				if (allow_signal_abort && CommandsWaiting() != 0) { break; }//exitwhen allow_signal_abort and CommandsWaiting() != 0
				if (CaptainInCombat(true)) { break; }//exitwhen CaptainInCombat(true)
				if (CaptainIsEmpty()) { break; }//exitwhen CaptainIsEmpty()
				SuicideSleep(10);//call SuicideSleep(10)
				if (sleep_seconds < -300) { break; }//exitwhen sleep_seconds < -300
			}//endloop
			Trace("waiting for attack wave to die\n");//call Trace("waiting for attack wave to die\n")
			while (true) {//loop
				//
				if (allow_signal_abort && CommandsWaiting() != 0) {//if allow_signal_abort and CommandsWaiting() != 0 then
					Trace("ABORT - attack wave override\n");//call Trace("ABORT - attack wave override\n")
				}//endif
				if (CaptainIsEmpty()) {//if CaptainIsEmpty() then
					Trace("done - all units are dead\n");//call Trace("done - all units are dead\n")
				}//endif
				if (sleep_seconds < -300) {//if sleep_seconds < -300 then
					Trace("done - timeout, took too long to reach engage the enemy\n");//call Trace("done - timeout, took too long to reach engage the enemy\n")
				}//endif
				//
				if (allow_signal_abort && CommandsWaiting() != 0) { break; }//exitwhen allow_signal_abort and CommandsWaiting() != 0
				if (CaptainIsEmpty()) { break; }//exitwhen CaptainIsEmpty()
				SuicideSleep(10);//call SuicideSleep(10)
				if (sleep_seconds < -300) { break; }//exitwhen sleep_seconds < -300
			}//endloop
		}//endfunction
		//
		private void CommonSuicideOnPlayer(bool standard, bool bldgs, int seconds, player p, int x, int y) {//function CommonSuicideOnPlayer takes boolean standard, boolean bldgs, integer seconds, player p, integer x, integer y returns nothing
			int save_peons;//local integer save_peons
			if (!PrepSuicideOnPlayer(seconds)) {//if not PrepSuicideOnPlayer(seconds) then
				return;//return
			}//endif
			save_peons = campaign_wood_peons;//set save_peons = campaign_wood_peons
			campaign_wood_peons = 0;//set campaign_wood_peons = 0
			while (true) {//loop
				//
				if (allow_signal_abort && CommandsWaiting() != 0) {//if allow_signal_abort and CommandsWaiting() != 0 then
					Trace("ABORT -- attack wave override\n");//call Trace("ABORT -- attack wave override\n")
				}//endif
				//
				if (allow_signal_abort && CommandsWaiting() != 0) { break; }//exitwhen allow_signal_abort and CommandsWaiting() != 0
				while (true) {//loop
					if (allow_signal_abort && CommandsWaiting() != 0) { break; }//exitwhen allow_signal_abort and CommandsWaiting() != 0
					FormGroup(5, true);//call FormGroup(5,true)
					if (sleep_seconds <= 0) { break; }//exitwhen sleep_seconds <= 0
					TraceI("waiting %d seconds before suicide\n", CommonAi.sleep_seconds);//call TraceI("waiting %d seconds before suicide\n",sleep_seconds)
				}//endloop
				if (standard) {//if standard then
					if (bldgs) {//if bldgs then
						if (SuicidePlayer(p,sleep_seconds >= -60)) { break; }//exitwhen SuicidePlayer(p,sleep_seconds >= -60)
					} else {//else
						if (SuicidePlayerUnits(p,sleep_seconds >= -60)) { break; }//exitwhen SuicidePlayerUnits(p,sleep_seconds >= -60)
					}//endif
				} else {//else
					AttackMoveXYA(x, y);//call AttackMoveXYA(x,y)
				}//endif
				TraceI("waiting %d seconds before timeout\n", 60+sleep_seconds);//call TraceI("waiting %d seconds before timeout\n",60+sleep_seconds)
				SuicideSleep(5);//call SuicideSleep(5)
			}//endloop
			campaign_wood_peons = save_peons;//set campaign_wood_peons = save_peons
			harass_length = 0;//set harass_length = 0
			SuicideOnPlayerWave();//call SuicideOnPlayerWave()
		}//endfunction
		//
		private void SuicideOnPlayer(int seconds, player p) {//function SuicideOnPlayer takes integer seconds, player p returns nothing
			CommonSuicideOnPlayer(true, true, seconds, p, 0, 0);//call CommonSuicideOnPlayer(true,true,seconds,p,0,0)
		}//endfunction
		//
		private void SuicideOnUnits(int seconds, player p) {//function SuicideOnUnits takes integer seconds, player p returns nothing
			CommonSuicideOnPlayer(true, false, seconds, p, 0, 0);//call CommonSuicideOnPlayer(true,false,seconds,p,0,0)
		}//endfunction
		//
		private void SuicideOnPoint(int seconds, player p, int x, int y) {//function SuicideOnPoint takes integer seconds, player p, integer x, integer y returns nothing
			CommonSuicideOnPlayer(false, false, seconds, p, x, y);//call CommonSuicideOnPlayer(false,false,seconds,p,x,y)
		}//endfunction
		//
		private void SuicideUntilSignal(int seconds, player p) {//function SuicideUntilSignal takes integer seconds, player p returns nothing
			int save;//local integer save
			int wave_prep = PrepTime();//local integer wave_prep = PrepTime()
			while (true) {//loop
				AddSleepSeconds(seconds);//call AddSleepSeconds(seconds)
				if (sleep_seconds-wave_prep > 0) {//if sleep_seconds-wave_prep > 0 then
					SuicideSleep(sleep_seconds-wave_prep);//call SuicideSleep(sleep_seconds-wave_prep)
				}//endif
				save = campaign_wood_peons;//set save = campaign_wood_peons
				campaign_wood_peons = 0;//set campaign_wood_peons = 0
				while (true) {//loop
					while (true) {//loop
						FormGroup(5, true);//call FormGroup(5, true)
						if (sleep_seconds <= 0) { break; }//exitwhen sleep_seconds <= 0
						if (CommandsWaiting() != 0) { break; }//exitwhen CommandsWaiting() != 0
					}//endloop
					if (SuicidePlayer(p,sleep_seconds >= -60)) { break; }//exitwhen SuicidePlayer(p,sleep_seconds >= -60)
					if (CommandsWaiting() != 0) { break; }//exitwhen CommandsWaiting() != 0
					SuicideSleep(3);//call SuicideSleep(3)
				}//endloop
				campaign_wood_peons = save;//set campaign_wood_peons = save
				while (true) {//loop
					if (CaptainIsEmpty()) { break; }//exitwhen CaptainIsEmpty()
					if (CommandsWaiting() != 0) { break; }//exitwhen CommandsWaiting() != 0
					SuicideSleep(5);//call SuicideSleep(5)
				}//endloop
				if (CommandsWaiting() != 0) { break; }//exitwhen CommandsWaiting() != 0
			}//endloop
		}//endfunction
		//
		private void SuicideOnce(int easy, int med, int hard, int unitid) {//function SuicideOnce takes integer easy, integer med, integer hard, integer unitid returns nothing
			if (difficulty == EASY) {//if difficulty == EASY then
				SuicideUnit(easy, unitid);//call SuicideUnit(easy,unitid)
			} else if (difficulty == NORMAL) {//elseif difficulty == NORMAL then
				SuicideUnit(med, unitid);//call SuicideUnit(med,unitid)
			} else {//else
				SuicideUnit(hard, unitid);//call SuicideUnit(hard,unitid)
			}//endif
		}//endfunction
		//
		private void SuicideUnitA(int unitid) {//function SuicideUnitA takes integer unitid returns nothing
			if (unitid != 0) {//if unitid != 0 then
				SuicideUnit(1, unitid);//call SuicideUnit(1,unitid)
			}//endif
			Sleep(0.1);//call Sleep(0.1)
		}//endfunction
		//
		private void SuicideUnitB(int unitid, int playerid) {//function SuicideUnitB takes integer unitid, integer playerid returns nothing
			if (unitid != 0) {//if unitid != 0 then
				SuicideUnitEx(1, unitid, playerid);//call SuicideUnitEx(1,unitid,playerid)
			}//endif
			Sleep(0.1);//call Sleep(0.1)
		}//endfunction
		//
		private void SuicideUnits(int u1, int u2, int u3, int u4, int u5, int u6, int u7, int u8, int u9, int uA) {//function SuicideUnits takes integer u1, integer u2, integer u3, integer u4, integer u5, integer u6, integer u7, integer u8, integer u9, integer uA returns nothing
			Trace("MASS SUICIDE - this script is now technically done\n");//call Trace("MASS SUICIDE - this script is now technically done\n")
			PrepFullSuicide();//call PrepFullSuicide()
			while (true) {//loop
				SuicideUnitA(u1);//call SuicideUnitA(u1)
				SuicideUnitA(u2);//call SuicideUnitA(u2)
				SuicideUnitA(u3);//call SuicideUnitA(u3)
				SuicideUnitA(u4);//call SuicideUnitA(u4)
				SuicideUnitA(u5);//call SuicideUnitA(u5)
				SuicideUnitA(u6);//call SuicideUnitA(u6)
				SuicideUnitA(u7);//call SuicideUnitA(u7)
				SuicideUnitA(u8);//call SuicideUnitA(u8)
				SuicideUnitA(u9);//call SuicideUnitA(u9)
				SuicideUnitA(uA);//call SuicideUnitA(uA)
			}//endloop
		}//endfunction
		//
		private void SuicideUnitsEx(int playerid, int u1, int u2, int u3, int u4, int u5, int u6, int u7, int u8, int u9, int uA) {//function SuicideUnitsEx takes integer playerid, integer u1, integer u2, integer u3, integer u4, integer u5, integer u6, integer u7, integer u8, integer u9, integer uA returns nothing
			Trace("MASS SUICIDE - this script is now technically done\n");//call Trace("MASS SUICIDE - this script is now technically done\n")
			PrepFullSuicide();//call PrepFullSuicide()
			while (true) {//loop
				SuicideUnitB(u1, playerid);//call SuicideUnitB(u1,playerid)
				SuicideUnitB(u2, playerid);//call SuicideUnitB(u2,playerid)
				SuicideUnitB(u3, playerid);//call SuicideUnitB(u3,playerid)
				SuicideUnitB(u4, playerid);//call SuicideUnitB(u4,playerid)
				SuicideUnitB(u5, playerid);//call SuicideUnitB(u5,playerid)
				SuicideUnitB(u6, playerid);//call SuicideUnitB(u6,playerid)
				SuicideUnitB(u7, playerid);//call SuicideUnitB(u7,playerid)
				SuicideUnitB(u8, playerid);//call SuicideUnitB(u8,playerid)
				SuicideUnitB(u9, playerid);//call SuicideUnitB(u9,playerid)
				SuicideUnitB(uA, playerid);//call SuicideUnitB(uA,playerid)
			}//endloop
		}//endfunction
		//
		private void SuicideOnPlayerEx(int easy, int med, int hard, player p) {//function SuicideOnPlayerEx takes integer easy, integer med, integer hard, player p returns nothing
			if (difficulty == EASY) {//if difficulty == EASY then
				SuicideOnPlayer(easy, p);//call SuicideOnPlayer(easy,p)
			} else if (difficulty == NORMAL) {//elseif difficulty == NORMAL then
				SuicideOnPlayer(med, p);//call SuicideOnPlayer(med,p)
			} else {//else
				SuicideOnPlayer(hard, p);//call SuicideOnPlayer(hard,p)
			}//endif
		}//endfunction
		//
		private void SuicideOnUnitsEx(int easy, int med, int hard, player p) {//function SuicideOnUnitsEx takes integer easy, integer med, integer hard, player p returns nothing
			if (difficulty == EASY) {//if difficulty == EASY then
				SuicideOnUnits(easy, p);//call SuicideOnUnits(easy,p)
			} else if (difficulty == NORMAL) {//elseif difficulty == NORMAL then
				SuicideOnUnits(med, p);//call SuicideOnUnits(med,p)
			} else {//else
				SuicideOnUnits(hard, p);//call SuicideOnUnits(hard,p)
			}//endif
		}//endfunction
		//
		private void SuicideOnPointEx(int easy, int med, int hard, player p, int x, int y) {//function SuicideOnPointEx takes integer easy, integer med, integer hard, player p, integer x, integer y returns nothing
			if (difficulty == EASY) {//if difficulty == EASY then
				SuicideOnPoint(easy, p, x, y);//call SuicideOnPoint(easy,p,x,y)
			} else if (difficulty == NORMAL) {//elseif difficulty == NORMAL then
				SuicideOnPoint(med, p, x, y);//call SuicideOnPoint(med,p,x,y)
			} else {//else
				SuicideOnPoint(hard, p, x, y);//call SuicideOnPoint(hard,p,x,y)
			}//endif
		}//endfunction
		//
		private void ForeverSuicideOnPlayer(int seconds, player p) {//function ForeverSuicideOnPlayer takes integer seconds, player p returns nothing
			int length = harass_length;//local integer length = harass_length
			while (true) {//loop
				if (allow_signal_abort && CommandsWaiting() != 0) { break; }//exitwhen allow_signal_abort and CommandsWaiting() != 0
				SuicideOnPlayer(seconds, p);//call SuicideOnPlayer(seconds,p)
				harass_length = length;//set harass_length = length
			}//endloop
		}//endfunction
		//
		private void CommonSleepUntilTargetDead(unit target, bool reform) {//function CommonSleepUntilTargetDead takes unit target, boolean reform returns nothing
			while (true) {//loop
				if (CaptainRetreating()) { break; }//exitwhen CaptainRetreating()
				if (CaptainReadinessHP() <= 40) { break; }//exitwhen CaptainReadinessHP() <= 40
				if (!UnitAlive(target)) { break; }//exitwhen not UnitAlive(target)
				if (UnitInvis(target) && !IsUnitDetected(target,ai_player)) { break; }//exitwhen UnitInvis(target) and not IsUnitDetected(target,ai_player)
				if (!TownThreatened()) {//if not TownThreatened() then
					AttackMoveKill(N07_rainbowAi.target);//call AttackMoveKill(target)
				}//endif
				SuicideSleep(3);//call SuicideSleep(3)
				if (reform && sleep_seconds < -40) {//if reform and sleep_seconds < -40 then
					if (CaptainInCombat(true)) {//if CaptainInCombat(true) then
						sleep_seconds = sleep_seconds + 5;//set sleep_seconds = sleep_seconds + 5
					} else {//else
						sleep_seconds = 0;//set sleep_seconds = 0
						FormGroup(1, false);//call FormGroup(1,false)
					}//endif
				}//endif
			}//endloop
		}//endfunction
		//
		private void SleepUntilTargetDead(unit target) {//function SleepUntilTargetDead takes unit target returns nothing
			CommonSleepUntilTargetDead(N07_rainbowAi.target, false);//call CommonSleepUntilTargetDead(target,false)
		}//endfunction
		//
		private void ReformUntilTargetDead(unit target) {//function ReformUntilTargetDead takes unit target returns nothing
			CommonSleepUntilTargetDead(N07_rainbowAi.target, true);//call CommonSleepUntilTargetDead(target,true)
		}//endfunction
		//
		private void AttackMoveKillA(unit target) {//function AttackMoveKillA takes unit target returns nothing
			if (target == null) {//if target == null then
				SuicideSleep(3);//call SuicideSleep(3)
				return;//return
			}//endif
			AttackMoveKill(N07_rainbowAi.target);//call AttackMoveKill(target)
			ReformUntilTargetDead(N07_rainbowAi.target);//call ReformUntilTargetDead(target)
			SleepInCombat();//call SleepInCombat()
		}//endfunction
		//
		private void MinorCreepAttack() {//function MinorCreepAttack takes nothing returns nothing
			unit target = GetMinorCreep();//local unit target = GetMinorCreep()
			SetAllianceTarget(N07_rainbowAi.target);//call SetAllianceTarget(target)
			FormGroup(3, true);//call FormGroup(3, true)
			AttackMoveKillA(N07_rainbowAi.target);//call AttackMoveKillA(target)
		}//endfunction
		//
		private void MajorCreepAttack() {//function MajorCreepAttack takes nothing returns nothing
			unit target = GetMajorCreep();//local unit target = GetMajorCreep()
			SetAllianceTarget(N07_rainbowAi.target);//call SetAllianceTarget(target)
			FormGroup(3, true);//call FormGroup(3,true)
			AttackMoveKillA(N07_rainbowAi.target);//call AttackMoveKillA(target)
		}//endfunction
		//
		private void CreepAttackEx() {//function CreepAttackEx takes nothing returns nothing
			unit target = GetCreepCamp(min_creeps,max_creeps,allow_air_creeps);//local unit target = GetCreepCamp(min_creeps,max_creeps,allow_air_creeps)
			SetAllianceTarget(N07_rainbowAi.target);//call SetAllianceTarget(target)
			FormGroup(3, true);//call FormGroup(3,true)
			AttackMoveKillA(N07_rainbowAi.target);//call AttackMoveKillA(target)
		}//endfunction
		//
		private void AnyPlayerAttack() {//function AnyPlayerAttack takes nothing returns nothing
			unit hall;//local unit hall
			hall = GetEnemyExpansion();//set hall = GetEnemyExpansion()
			if (hall == null) {//if hall == null then
				StartGetEnemyBase();//call StartGetEnemyBase()
				while (true) {//loop
					if (!WaitGetEnemyBase()) { break; }//exitwhen not WaitGetEnemyBase()
					SuicideSleep(1);//call SuicideSleep(1)
				}//endloop
				hall = GetEnemyBase();//set hall = GetEnemyBase()
			}//endif
			SetAllianceTarget(hall);//call SetAllianceTarget(hall)
			FormGroup(3, true);//call FormGroup(3,true)
			AttackMoveKillA(hall);//call AttackMoveKillA(hall)
		}//endfunction
		//
		private void ExpansionAttack() {//function ExpansionAttack takes nothing returns nothing
			unit creep = GetExpansionFoe();//local unit creep = GetExpansionFoe()
			int x;//local integer x
			FormGroup(3, true);//call FormGroup(3, true)
			if (creep == null) {//if creep == null then
				x = GetExpansionX();//set x = GetExpansionX()
				if (x != -1) {//if x != -1 then
					AttackMoveXYA(x, GetExpansionY());//call AttackMoveXYA(x,GetExpansionY())
				}//endif
			} else {//else
				AttackMoveKillA(creep);//call AttackMoveKillA(creep)
			}//endif
		}//endfunction
		//
		//
		//
		private void AddSiege() {//function AddSiege takes nothing returns nothing
			SetAssaultGroup(0, 9, CommonAi.SHADE);//call SetAssaultGroup( 0, 9, SHADE       )
			SetAssaultGroup(0, 9, CommonAi.MEAT_WAGON);//call SetAssaultGroup( 0, 9, MEAT_WAGON  )
			SetAssaultGroup(0, 9, CommonAi.MORTAR);//call SetAssaultGroup( 0, 9, MORTAR      )
			SetAssaultGroup(0, 9, CommonAi.TANK);//call SetAssaultGroup( 0, 9, TANK        )
			SetAssaultGroup(0, 9, CommonAi.BALLISTA);//call SetAssaultGroup( 0, 9, BALLISTA    )
			SetAssaultGroup(0, 9, CommonAi.CATAPULT);//call SetAssaultGroup( 0, 9, CATAPULT    )
		}//endfunction
		//
		//
		//
		private int GetAllyCount(player whichPlayer) {//function GetAllyCount takes player whichPlayer returns integer
			int playerIndex = 0;//local integer    playerIndex = 0
			int count = 0;//local integer    count = 0
			player indexPlayer;//local player     indexPlayer
			while (true) {//loop
				indexPlayer = Player(playerIndex);//set indexPlayer = Player(playerIndex)
				if (whichPlayer != indexPlayer) {//if whichPlayer != indexPlayer then
					if (GetPlayerAlliance(whichPlayer,indexPlayer,ALLIANCE_PASSIVE)) {//if GetPlayerAlliance(whichPlayer,indexPlayer,ALLIANCE_PASSIVE) then
						if (GetPlayerAlliance(indexPlayer,whichPlayer,ALLIANCE_PASSIVE)) {//if GetPlayerAlliance(indexPlayer,whichPlayer,ALLIANCE_PASSIVE) then
							if (GetPlayerStructureCount(indexPlayer,true) > 0) {//if GetPlayerStructureCount(indexPlayer,true) > 0 then
								count = count + 1;//set count = count + 1
							}//endif
						}//endif
					}//endif
				}//endif
				playerIndex = playerIndex + 1;//set playerIndex = playerIndex + 1
				if (playerIndex == 12) { break; }//exitwhen playerIndex == 12
			}//endloop
			return count;//return count
		}//endfunction
		//
		//
		//
		private void SingleMeleeAttack(bool needs_exp, bool has_siege, bool major_ok, bool air_units) {//function SingleMeleeAttack takes boolean needs_exp, boolean has_siege, boolean major_ok, boolean air_units returns nothing
			bool can_siege;//local boolean   can_siege
			float daytime;//local real      daytime
			unit hall;//local unit      hall
			unit mega;//local unit      mega
			unit creep;//local unit      creep
			unit common;//local unit      common
			int minimum;//local integer   minimum
			bool allies;//local boolean   allies
			Trace("===SingleMeleeAttack===\n");//call Trace("===SingleMeleeAttack===\n")
			if (TownThreatened()) {//if TownThreatened() then
				Trace("sleep 2, town threatened\n");//call Trace("sleep 2, town threatened\n")
				Sleep(2);//call Sleep(2)
				return;//return
			}//endif
			//
			//
			if (get_zeppelin && GetGold() > 300 && GetWood() > 100) {//if get_zeppelin and GetGold() > 300 and GetWood() > 100 then
				Trace("purchase zep\n");//call Trace("purchase zep\n")
				PurchaseZeppelin();//call PurchaseZeppelin()
				get_zeppelin = false;//set get_zeppelin = false
				ready_for_zeppelin = false;//set ready_for_zeppelin = false
				return;//return
			}//endif
			ready_for_zeppelin = true;//set ready_for_zeppelin = true
			//
			//
			allies = GetAllyCount(ai_player) > 0;//set allies = GetAllyCount(ai_player) > 0
			if (allies && MeleeDifficulty() != MELEE_NEWBIE) {//if allies and MeleeDifficulty() != MELEE_NEWBIE then
				common = GetAllianceTarget();//set common = GetAllianceTarget()
				if (common != null) {//if common != null then
					Trace("join ally force\n");//call Trace("join ally force\n")
					if (GetMegaTarget() != null) {//if GetMegaTarget() != null then
						AddSiege();//call AddSiege()
					}//endif
					FormGroup(3, true);//call FormGroup(3,true)
					AttackMoveKillA(common);//call AttackMoveKillA(common)
					SetAllianceTarget(null);//call SetAllianceTarget(null)
					return;//return
				}//endif
			}//endif
			//
			//
			if (needs_exp) {//if needs_exp then
				Trace("needs exp\n");//call Trace("needs exp\n")
				creep = GetExpansionFoe();//set creep = GetExpansionFoe()
				if (creep != null) {//if creep != null then
					Trace("attack exp\n");//call Trace("attack exp\n")
					SetAllianceTarget(creep);//call SetAllianceTarget(creep)
					FormGroup(3, true);//call FormGroup(3,true)
					AttackMoveKillA(creep);//call AttackMoveKillA(creep)
					Sleep(20);//call Sleep(20)
					take_exp = false;//set take_exp = false
					return;//return
				}//endif
			}//endif
			//
			//
			if (MeleeDifficulty() != MELEE_NEWBIE) {//if MeleeDifficulty() != MELEE_NEWBIE then
				mega = GetMegaTarget();//set mega = GetMegaTarget()
				if (mega != null) {//if mega != null then
					Trace("MEGA TARGET!!!\n");//call Trace("MEGA TARGET!!!\n")
					AddSiege();//call AddSiege()
					FormGroup(3, true);//call FormGroup(3,true)
					AttackMoveKillA(mega);//call AttackMoveKillA(mega)
					return;//return
				}//endif
			}//endif
			//
			//
			hall = GetEnemyExpansion();//set hall = GetEnemyExpansion()
			daytime = GetFloatGameState(GAME_STATE_TIME_OF_DAY);//set daytime = GetFloatGameState(GAME_STATE_TIME_OF_DAY)
			can_siege = has_siege && (air_units || (daytime>=4 && daytime<=12));//set can_siege = has_siege and (air_units or (daytime>=4 and daytime<=12))
			if (hall!=null && (can_siege || !IsTowered(hall))) {//if hall!=null and (can_siege or not IsTowered(hall)) then
				Trace("test player town attack\n");//call Trace("test player town attack\n")
				if (MeleeDifficulty() == MELEE_NEWBIE) {//if MeleeDifficulty() == MELEE_NEWBIE then
					minimum = 3;//set minimum = 3
				} else if (allies && MeleeDifficulty() == MELEE_NORMAL) {//elseif allies and MeleeDifficulty() == MELEE_NORMAL then
					minimum = 1;//set minimum = 1
				} else {//else
					minimum = 0;//set minimum = 0
				}//endif
				if (exp_seen >= minimum) {//if exp_seen >= minimum then
					Trace("do player town attack\n");//call Trace("do player town attack\n")
					exp_seen = 0;//set exp_seen = 0
					AddSiege();//call AddSiege()
					SetAllianceTarget(hall);//call SetAllianceTarget(hall)
					FormGroup(3, true);//call FormGroup(3,true)
					AttackMoveKillA(hall);//call AttackMoveKillA(hall)
					return;//return
				}//endif
				exp_seen = exp_seen + 1;//set exp_seen = exp_seen + 1
			}//endif
			//
			//
			if (can_siege) {//if can_siege then
				Trace("attack player's town\n");//call Trace("attack player's town\n")
				AddSiege();//call AddSiege()
				AnyPlayerAttack();//call AnyPlayerAttack()
				return;//return
			}//endif
			//
			//
			if (min_creeps != -1) {//if min_creeps != -1 then
				TraceI("custom creep attack %d\n", CommonAi.max_creeps);//call TraceI("custom creep attack %d\n",max_creeps)
				CreepAttackEx();//call CreepAttackEx()
				return;//return
			}//endif
			//
			//
			if (major_ok) {//if major_ok then
				Trace("major creep attack\n");//call Trace("major creep attack\n")
				MajorCreepAttack();//call MajorCreepAttack()
				return;//return
			}//endif
			Trace("minor creep attack\n");//call Trace("minor creep attack\n")
			MinorCreepAttack();//call MinorCreepAttack()
		}//endfunction
		//
		private void GetZeppelin() {//function GetZeppelin takes nothing returns nothing
			if (ready_for_zeppelin) {//if ready_for_zeppelin then
				get_zeppelin = true;//set get_zeppelin = true
			}//endif
		}//endfunction
		//
		private int FoodUsed() {//function FoodUsed takes nothing returns integer
			return GetPlayerState(ai_player,PLAYER_STATE_RESOURCE_FOOD_USED);//return GetPlayerState(ai_player,PLAYER_STATE_RESOURCE_FOOD_USED)
		}//endfunction
		//
		private int FoodCap() {//function FoodCap takes nothing returns integer
			return GetPlayerState(ai_player,PLAYER_STATE_RESOURCE_FOOD_CAP);//return GetPlayerState(ai_player,PLAYER_STATE_RESOURCE_FOOD_CAP)
		}//endfunction
		//
		private int FoodSpace() {//function FoodSpace takes nothing returns integer
			return FoodCap() - FoodUsed();//return FoodCap() - FoodUsed()
		}//endfunction
		//
		private int FoodAvail(int base) {//function FoodAvail takes integer base returns integer
			return GetFoodMade(racial_farm) * TownCount(racial_farm) + GetFoodMade(base) * TownCount(base);//return GetFoodMade(racial_farm) * TownCount(racial_farm) + GetFoodMade(base) * TownCount(base)
		}//endfunction
		//
		private void BuildAttackers() {//function BuildAttackers takes nothing returns nothing
			int index = 0;//local integer index = 0
			int unitid;//local integer unitid
			int desire;//local integer desire
			int count;//local integer count
			while (true) {//loop
				if (index == harass_length) { break; }//exitwhen index == harass_length
				unitid = harass_units[index];//set unitid = harass_units[index]
				desire = harass_qty[index] + IgnoredUnits(unitid);//set desire = harass_qty[index] + IgnoredUnits(unitid)
				count = TownCount(unitid);//set count  = TownCount(unitid)
				if (count != desire) {//if count != desire then
					if (!StartUnit(desire,unitid,-1)) {//if not StartUnit(desire,unitid,-1) then
						return;//return
					}//endif
				}//endif
				index = index + 1;//set index = index + 1
			}//endloop
		}//endfunction
		//
		private void BuildDefenders() {//function BuildDefenders takes nothing returns nothing
			int index = 0;//local integer index = 0
			int unitid;//local integer unitid
			int qty;//local integer qty
			while (true) {//loop
				if (index == defense_length) { break; }//exitwhen index == defense_length
				unitid = defense_units[index];//set unitid = defense_units[index]
				qty = defense_qty[index];//set qty = defense_qty[index]
				Conversions(qty, unitid);//call Conversions(qty,unitid)
				AddDefenders(qty, unitid);//call AddDefenders(qty,unitid)
				index = index + 1;//set index = index + 1
			}//endloop
		}//endfunction
		//
		private void CampaignBasicsA() {//function CampaignBasicsA takes nothing returns nothing
			int food_each = GetFoodMade(racial_farm);//local integer food_each = GetFoodMade(racial_farm)
			int on_wood;//local integer on_wood
			ClearHarvestAI();//call ClearHarvestAI()
			if (CaptainInCombat(false)) {//if CaptainInCombat(false) then
				on_wood = 0;//set on_wood = 0
			} else {//else
				on_wood = campaign_wood_peons;//set on_wood = campaign_wood_peons
			}//endif
			HarvestGold(0, CommonAi.campaign_gold_peons);//call HarvestGold(0,campaign_gold_peons)
			HarvestWood(0, on_wood);//call HarvestWood(0,on_wood)
			if (harvest_town1) {//if harvest_town1 then
				HarvestGold(1, CommonAi.campaign_gold_peons);//call HarvestGold(1,campaign_gold_peons)
				HarvestWood(1, on_wood);//call HarvestWood(1,on_wood)
			}//endif
			if (harvest_town2) {//if harvest_town2 then
				HarvestGold(2, CommonAi.campaign_gold_peons);//call HarvestGold(2,campaign_gold_peons)
				HarvestWood(2, on_wood);//call HarvestWood(2,on_wood)
			}//endif
			if (harvest_town3) {//if harvest_town3 then
				HarvestGold(3, CommonAi.campaign_gold_peons);//call HarvestGold(3,campaign_gold_peons)
				HarvestWood(3, on_wood);//call HarvestWood(3,on_wood)
			}//endif
			if (do_campaign_farms && FoodUsed()+food_each-1 > food_each*(TownCount(racial_farm)+1)) {//if do_campaign_farms and FoodUsed()+food_each-1 > food_each*(TownCount(racial_farm)+1) then
				StartUnit(TownCount(racial_farm)+1, CommonAi.racial_farm, -1);//call StartUnit(TownCount(racial_farm)+1,racial_farm,-1)
			}//endif
			if (build_campaign_attackers) {//if build_campaign_attackers then
				BuildAttackers();//call BuildAttackers()
			}//endif
			if (!CaptainInCombat(false)) {//if not CaptainInCombat(false) then
				BuildDefenders();//call BuildDefenders()
			}//endif
			FillGuardPosts();//call FillGuardPosts()
			ReturnGuardPosts();//call ReturnGuardPosts()
		}//endfunction
		//
		private void CampaignBasics() {//function CampaignBasics takes nothing returns nothing
			Sleep(1);//call Sleep(1)
			CampaignBasicsA();//call CampaignBasicsA()
			StaggerSleep(1, 5);//call StaggerSleep(1,5)
			while (true) {//loop
				CampaignBasicsA();//call CampaignBasicsA()
				Sleep(CommonAi.campaign_basics_speed);//call Sleep(campaign_basics_speed)
			}//endloop
		}//endfunction
		//
		private void CampaignAI(int farms, code heroes) {//function CampaignAI takes integer farms, code heroes returns nothing
			if (GetGameDifficulty() == MAP_DIFFICULTY_EASY) {//if GetGameDifficulty() == MAP_DIFFICULTY_EASY then
				difficulty = EASY;//set difficulty = EASY
				SetTargetHeroes(false);//call SetTargetHeroes(false)
				SetUnitsFlee(false);//call SetUnitsFlee(false)
			} else if (GetGameDifficulty() == MAP_DIFFICULTY_NORMAL) {//elseif GetGameDifficulty() == MAP_DIFFICULTY_NORMAL then
				difficulty = NORMAL;//set difficulty = NORMAL
				SetTargetHeroes(false);//call SetTargetHeroes(false)
				SetUnitsFlee(false);//call SetUnitsFlee(false)
			} else if (GetGameDifficulty() == MAP_DIFFICULTY_HARD) {//elseif GetGameDifficulty() == MAP_DIFFICULTY_HARD then
				difficulty = HARD;//set difficulty = HARD
				SetPeonsRepair(true);//call SetPeonsRepair(true)
			} else {//else
				difficulty = INSANE;//set difficulty = INSANE
			}//endif
			InitAI();//call InitAI()
			InitBuildArray();//call InitBuildArray()
			InitAssaultGroup();//call InitAssaultGroup()
			CreateCaptains();//call CreateCaptains()
			SetNewHeroes(false);//call SetNewHeroes(false)
			if (heroes != null) {//if heroes != null then
				SetHeroLevels(heroes);//call SetHeroLevels(heroes)
			}//endif
			SetHeroesFlee(false);//call SetHeroesFlee(false)
			SetGroupsFlee(false);//call SetGroupsFlee(false)
			SetSlowChopping(true);//call SetSlowChopping(true)
			GroupTimedLife(false);//call GroupTimedLife(false)
			SetCampaignAI();//call SetCampaignAI()
			Sleep(0.1);//call Sleep(0.1)
			racial_farm = farms;//set racial_farm = farms
			StartThread(function CampaignBasics);//call StartThread(function CampaignBasics)
			StartBuildLoop();//call StartBuildLoop()
		}//endfunction
		//
		private void UnsummonAll() {//function UnsummonAll takes nothing returns nothing
			unit bldg;//local unit bldg
			while (true) {//loop
				bldg = GetBuilding(ai_player);//set bldg = GetBuilding(ai_player)
				if (bldg==null) { break; }//exitwhen bldg==null
				Unsummon(bldg);//call Unsummon(bldg)
				Sleep(2);//call Sleep(2)
			}//endloop
		}//endfunction
		//
		//
		//
		private int SkillArrays() {//function SkillArrays takes nothing returns integer
			int level = GetHeroLevelAI();//local integer level = GetHeroLevelAI()
			if (level > max_hero_level) {//if level > max_hero_level then
				max_hero_level = level;//set max_hero_level = level
			}//endif
			if (GetHeroId() == hero_id) {//if GetHeroId() == hero_id then
				return skills1[level];//return skills1[level]
			} else if (GetHeroId() == hero_id2) {//elseif GetHeroId() == hero_id2 then
				return skills2[level];//return skills2[level]
			} else {//else
				return skills3[level];//return skills3[level]
			}//endif
		}//endfunction
		//
		//
		//
		private void SetSkillArray(int index, int id) {//function SetSkillArray takes integer index, integer id returns nothing
			int i = 1;//local integer i = 1
			if (index == 1) {//if index == 1 then
				if (hero_id != id) {//if hero_id != id then
					return;//return
				}//endif
				while (true) {//loop
					skills1[i] = skill[i];//set skills1[i] = skill[i]
					if (i == 10) { break; }//exitwhen i == 10
					i = i + 1;//set i = i + 1
				}//endloop
			} else if (index == 2) {//elseif index == 2 then
				if (hero_id2 != id) {//if hero_id2 != id then
					return;//return
				}//endif
				while (true) {//loop
					skills2[i] = skill[i];//set skills2[i] = skill[i]
					if (i == 10) { break; }//exitwhen i == 10
					i = i + 1;//set i = i + 1
				}//endloop
			} else {//else
				if (hero_id3 != id) {//if hero_id3 != id then
					return;//return
				}//endif
				while (true) {//loop
					skills3[i] = skill[i];//set skills3[i] = skill[i]
					if (i == 10) { break; }//exitwhen i == 10
					i = i + 1;//set i = i + 1
				}//endloop
			}//endif
		}//endfunction
		//
		//
		//
		private void AwaitMeleeHeroes() {//function AwaitMeleeHeroes takes nothing returns nothing
			if (GetUnitCountDone(hero_id2) > 0) {//if GetUnitCountDone(hero_id2) > 0 then
				two_heroes = true;//set two_heroes = true
			}//endif
			while (true) {//loop
				if (GetUnitCountDone(hero_id)>0 && (take_exp || (!two_heroes || GetUnitCountDone(hero_id2)>0))) { break; }//exitwhen GetUnitCountDone(hero_id)>0 and (take_exp or (not two_heroes or GetUnitCountDone(hero_id2)>0))
				Sleep(1);//call Sleep(1)
			}//endloop
		}//endfunction
		//
		//
		//
		private int PickMeleeHero(race raceid) {//function PickMeleeHero takes race raceid returns integer
			int first;//local integer first
			int second;//local integer second
			int third;//local integer third
			int last;//local integer last
			int[] heroes;//local integer array heroes
			//
			if (raceid == RACE_HUMAN) {//if raceid == RACE_HUMAN then
				//
				heroes[1] = ARCHMAGE;//set heroes[1] = ARCHMAGE
				heroes[2] = MTN_KING;//set heroes[2] = MTN_KING
				heroes[3] = PALADIN;//set heroes[3] = PALADIN
				heroes[4] = BLOOD_MAGE;//set heroes[4] = BLOOD_MAGE
				//
			} else if (raceid == RACE_ORC) {//elseif raceid == RACE_ORC then
				//
				heroes[1] = BLADE_MASTER;//set heroes[1] = BLADE_MASTER
				heroes[2] = FAR_SEER;//set heroes[2] = FAR_SEER
				heroes[3] = TAUREN_CHIEF;//set heroes[3] = TAUREN_CHIEF
				heroes[4] = SHADOW_HUNTER;//set heroes[4] = SHADOW_HUNTER
				//
			} else if (raceid == RACE_NIGHTELF) {//elseif raceid == RACE_NIGHTELF then
				//
				heroes[1] = DEMON_HUNTER;//set heroes[1] = DEMON_HUNTER
				heroes[2] = KEEPER;//set heroes[2] = KEEPER
				heroes[3] = MOON_BABE;//set heroes[3] = MOON_BABE
				heroes[4] = WARDEN;//set heroes[4] = WARDEN
				//
			} else if (raceid == RACE_UNDEAD) {//elseif raceid == RACE_UNDEAD then
				//
				heroes[1] = DEATH_KNIGHT;//set heroes[1] = DEATH_KNIGHT
				heroes[2] = DREAD_LORD;//set heroes[2] = DREAD_LORD
				heroes[3] = LICH;//set heroes[3] = LICH
				heroes[4] = CRYPT_LORD;//set heroes[4] = CRYPT_LORD
			} else {//else
				hero_id = 0;//set hero_id = 0
			}//endif
			if (VersionCompatible(VERSION_FROZEN_THRONE)) {//if VersionCompatible(VERSION_FROZEN_THRONE) then
				last = 4;//set last = 4
			} else {//else
				last = 3;//set last = 3
			}//endif
			first = GetRandomInt(1,last);//set first  = GetRandomInt(1,last)
			second = GetRandomInt(1,last-1);//set second = GetRandomInt(1,last-1)
			third = GetRandomInt(1,last-2);//set third  = GetRandomInt(1,last-2)
			hero_id = heroes[first];//set hero_id        = heroes[first]
			heroes[first] = heroes[last];//set heroes[first]  = heroes[last]
			hero_id2 = heroes[second];//set hero_id2       = heroes[second]
			heroes[second] = heroes[last-1];//set heroes[second] = heroes[last-1]
			hero_id3 = heroes[third];//set hero_id3       = heroes[third]
			return hero_id;//return hero_id
		}//endfunction

	
	}
}

