using System;
using System.Collections.Generic;

namespace Jass {
	
	/* native functions */
	public class Api {

		public static void DebugS() {  }//native DebugS               takes string str                            returns nothing
		public static void DebugFI(string str, int val) {  }//native DebugFI              takes string str, integer val               returns nothing
		public static void DebugUnitID(string str, int val) {  }//native DebugUnitID          takes string str, integer val               returns nothing
		public static void DisplayText(int p, string str) {  }//native DisplayText          takes integer p, string str                 returns nothing
		public static void DisplayTextI(int p, string str, int val) {  }//native DisplayTextI         takes integer p, string str, integer val    returns nothing
		public static void DisplayTextII(int p, string str, int v1, int v2) {  }//native DisplayTextII        takes integer p, string str, integer v1, integer v2 returns nothing
		public static void DisplayTextIII(int p, string str, int v1, int v2, int v3) {  }//native DisplayTextIII       takes integer p, string str, integer v1, integer v2, integer v3 returns nothing
		public static bool DoAiScriptDebug() { return false; }//native DoAiScriptDebug      takes nothing                               returns boolean
		public static int GetAiPlayer() { return 0; }//native GetAiPlayer          takes nothing                               returns integer
		public static int GetHeroId() { return 0; }//native GetHeroId            takes nothing                               returns integer
		public static int GetHeroLevelAI() { return 0; }//native GetHeroLevelAI       takes nothing                               returns integer
		public static int GetUnitCount() { return 0; }//native GetUnitCount         takes integer unitid                        returns integer
		public static int GetPlayerUnitTypeCount(player p, int unitid) { return 0; }//native GetPlayerUnitTypeCount takes player p, integer unitid            returns integer
		public static int GetUnitCountDone() { return 0; }//native GetUnitCountDone     takes integer unitid                        returns integer
		public static int GetTownUnitCount(int id, int tn, bool dn) { return 0; }//native GetTownUnitCount     takes integer id, integer tn, boolean dn    returns integer
		public static int GetUnitGoldCost() { return 0; }//native GetUnitGoldCost      takes integer unitid                        returns integer
		public static int GetUnitWoodCost() { return 0; }//native GetUnitWoodCost      takes integer unitid                        returns integer
		public static int GetUnitBuildTime() { return 0; }//native GetUnitBuildTime     takes integer unitid                        returns integer
		public static int GetMinesOwned() { return 0; }//native GetMinesOwned        takes nothing                               returns integer
		public static int GetGoldOwned() { return 0; }//native GetGoldOwned         takes nothing                               returns integer
		public static int TownWithMine() { return 0; }//native TownWithMine         takes nothing                               returns integer
		public static bool TownHasMine() { return false; }//native TownHasMine          takes integer townid                        returns boolean
		public static bool TownHasHall() { return false; }//native TownHasHall          takes integer townid                        returns boolean
		public static int GetUpgradeLevel() { return 0; }//native GetUpgradeLevel      takes integer id                            returns integer
		public static int GetUpgradeGoldCost() { return 0; }//native GetUpgradeGoldCost   takes integer id                            returns integer
		public static int GetUpgradeWoodCost() { return 0; }//native GetUpgradeWoodCost   takes integer id                            returns integer
		public static int GetNextExpansion() { return 0; }//native GetNextExpansion     takes nothing                               returns integer
		public static int GetMegaTarget() { return 0; }//native GetMegaTarget        takes nothing                               returns unit
		public static int GetBuilding() { return 0; }//native GetBuilding          takes player p                              returns unit
		public static int GetEnemyPower() { return 0; }//native GetEnemyPower        takes nothing                               returns integer
		public static void SetAllianceTarget() {  }//native SetAllianceTarget    takes unit id                               returns nothing
		public static int GetAllianceTarget() { return 0; }//native GetAllianceTarget    takes nothing                               returns unit
		public static bool SetProduce(int qty, int id, int town) { return false; }//native SetProduce           takes integer qty, integer id, integer town returns boolean
		public static void Unsummon() {  }//native Unsummon             takes unit unitid                           returns nothing
		public static bool SetExpansion(int peon, int id) { return false; }//native SetExpansion         takes unit peon, integer id                 returns boolean
		public static bool SetUpgrade() { return false; }//native SetUpgrade           takes integer id                            returns boolean
		public static void SetHeroLevels() {  }//native SetHeroLevels        takes code func                             returns nothing
		public static void SetNewHeroes() {  }//native SetNewHeroes         takes boolean state                         returns nothing
		public static void PurchaseZeppelin() {  }//native PurchaseZeppelin     takes nothing                               returns nothing
		public static bool MergeUnits(int qty, int a, int b, int make) { return false; }//native MergeUnits           takes integer qty, integer a, integer b, integer make returns boolean
		public static bool ConvertUnits(int qty, int id) { return false; }//native ConvertUnits         takes integer qty, integer id               returns boolean
		public static void SetCampaignAI() {  }//native SetCampaignAI        takes nothing                               returns nothing
		public static void SetMeleeAI() {  }//native SetMeleeAI           takes nothing                               returns nothing
		public static void SetTargetHeroes() {  }//native SetTargetHeroes      takes boolean state                         returns nothing
		public static void SetPeonsRepair() {  }//native SetPeonsRepair       takes boolean state                         returns nothing
		public static void SetRandomPaths() {  }//native SetRandomPaths       takes boolean state                         returns nothing
		public static void SetDefendPlayer() {  }//native SetDefendPlayer      takes boolean state                         returns nothing
		public static void SetHeroesFlee() {  }//native SetHeroesFlee        takes boolean state                         returns nothing
		public static void SetHeroesBuyItems() {  }//native SetHeroesBuyItems    takes boolean state                         returns nothing
		public static void SetWatchMegaTargets() {  }//native SetWatchMegaTargets  takes boolean state                         returns nothing
		public static void SetIgnoreInjured() {  }//native SetIgnoreInjured     takes boolean state                         returns nothing
		public static void SetHeroesTakeItems() {  }//native SetHeroesTakeItems   takes boolean state                         returns nothing
		public static void SetUnitsFlee() {  }//native SetUnitsFlee         takes boolean state                         returns nothing
		public static void SetGroupsFlee() {  }//native SetGroupsFlee        takes boolean state                         returns nothing
		public static void SetSlowChopping() {  }//native SetSlowChopping      takes boolean state                         returns nothing
		public static void SetCaptainChanges() {  }//native SetCaptainChanges    takes boolean allow                         returns nothing
		public static void SetSmartArtillery() {  }//native SetSmartArtillery    takes boolean state                         returns nothing
		public static void SetReplacementCount() {  }//native SetReplacementCount  takes integer qty                           returns nothing
		public static void GroupTimedLife() {  }//native GroupTimedLife       takes boolean allow                         returns nothing
		public static void RemoveInjuries() {  }//native RemoveInjuries       takes nothing                               returns nothing
		public static void RemoveSiege() {  }//native RemoveSiege          takes nothing                               returns nothing
		public static void InitAssault() {  }//native InitAssault          takes nothing                               returns nothing
		public static bool AddAssault(int qty, int id) { return false; }//native AddAssault           takes integer qty, integer id               returns boolean
		public static bool AddDefenders(int qty, int id) { return false; }//native AddDefenders         takes integer qty, integer id               returns boolean
		public static int GetCreepCamp(int min, int max, bool flyers_ok) { return 0; }//native GetCreepCamp         takes integer min, integer max, boolean flyers_ok returns unit
		public static void StartGetEnemyBase() {  }//native StartGetEnemyBase    takes nothing                               returns nothing
		public static bool WaitGetEnemyBase() { return false; }//native WaitGetEnemyBase     takes nothing                               returns boolean
		public static int GetEnemyBase() { return 0; }//native GetEnemyBase         takes nothing                               returns unit
		public static int GetExpansionFoe() { return 0; }//native GetExpansionFoe      takes nothing                               returns unit
		public static int GetEnemyExpansion() { return 0; }//native GetEnemyExpansion    takes nothing                               returns unit
		public static int GetExpansionX() { return 0; }//native GetExpansionX        takes nothing                               returns integer
		public static int GetExpansionY() { return 0; }//native GetExpansionY        takes nothing                               returns integer
		public static void SetStagePoint(real x, real y) {  }//native SetStagePoint        takes real x, real y                        returns nothing
		public static void AttackMoveKill() {  }//native AttackMoveKill       takes unit target                           returns nothing
		public static void AttackMoveXY(int x, int y) {  }//native AttackMoveXY         takes integer x, integer y                  returns nothing
		public static void LoadZepWave(int x, int y) {  }//native LoadZepWave          takes integer x, integer y                  returns nothing
		public static bool SuicidePlayer(player id, bool check_full) { return false; }//native SuicidePlayer        takes player id, boolean check_full         returns boolean
		public static bool SuicidePlayerUnits(player id, bool check_full) { return false; }//native SuicidePlayerUnits   takes player id, boolean check_full         returns boolean
		public static bool CaptainInCombat() { return false; }//native CaptainInCombat      takes boolean attack_captain                returns boolean
		public static bool IsTowered() { return false; }//native IsTowered            takes unit target                           returns boolean
		public static void ClearHarvestAI() {  }//native ClearHarvestAI       takes nothing                               returns nothing
		public static void HarvestGold(int town, int peons) {  }//native HarvestGold          takes integer town, integer peons           returns nothing
		public static void HarvestWood(int town, int peons) {  }//native HarvestWood          takes integer town, integer peons           returns nothing
		public static int GetExpansionPeon() { return 0; }//native GetExpansionPeon     takes nothing                               returns unit
		public static void StopGathering() {  }//native StopGathering        takes nothing                               returns nothing
		public static void AddGuardPost(int id, real x, real y) {  }//native AddGuardPost         takes integer id, real x, real y            returns nothing
		public static void FillGuardPosts() {  }//native FillGuardPosts       takes nothing                               returns nothing
		public static void ReturnGuardPosts() {  }//native ReturnGuardPosts     takes nothing                               returns nothing
		public static void CreateCaptains() {  }//native CreateCaptains       takes nothing                               returns nothing
		public static void SetCaptainHome(int which, real x, real y) {  }//native SetCaptainHome       takes integer which, real x, real y         returns nothing
		public static void ResetCaptainLocs() {  }//native ResetCaptainLocs     takes nothing                               returns nothing
		public static void ShiftTownSpot(real x, real y) {  }//native ShiftTownSpot        takes real x, real y                        returns nothing
		public static void TeleportCaptain(real x, real y) {  }//native TeleportCaptain      takes real x, real y                        returns nothing
		public static void ClearCaptainTargets() {  }//native ClearCaptainTargets  takes nothing                               returns nothing
		public static void CaptainAttack(real x, real y) {  }//native CaptainAttack        takes real x, real y                        returns nothing
		public static void CaptainVsUnits() {  }//native CaptainVsUnits       takes player id                             returns nothing
		public static void CaptainVsPlayer() {  }//native CaptainVsPlayer      takes player id                             returns nothing
		public static void CaptainGoHome() {  }//native CaptainGoHome        takes nothing                               returns nothing
		public static bool CaptainIsHome() { return false; }//native CaptainIsHome        takes nothing                               returns boolean
		public static bool CaptainIsFull() { return false; }//native CaptainIsFull        takes nothing                               returns boolean
		public static bool CaptainIsEmpty() { return false; }//native CaptainIsEmpty       takes nothing                               returns boolean
		public static int CaptainGroupSize() { return 0; }//native CaptainGroupSize     takes nothing                               returns integer
		public static int CaptainReadiness() { return 0; }//native CaptainReadiness     takes nothing                               returns integer
		public static bool CaptainRetreating() { return false; }//native CaptainRetreating    takes nothing                               returns boolean
		public static int CaptainReadinessHP() { return 0; }//native CaptainReadinessHP   takes nothing                               returns integer
		public static int CaptainReadinessMa() { return 0; }//native CaptainReadinessMa   takes nothing                               returns integer
		public static bool CaptainAtGoal() { return false; }//native CaptainAtGoal        takes nothing                               returns boolean
		public static bool CreepsOnMap() { return false; }//native CreepsOnMap          takes nothing                               returns boolean
		public static void SuicideUnit(int count, int unitid) {  }//native SuicideUnit          takes integer count, integer unitid         returns nothing
		public static void SuicideUnitEx(int ct, int uid, int pid) {  }//native SuicideUnitEx        takes integer ct, integer uid, integer pid  returns nothing
		public static void StartThread() {  }//native StartThread          takes code func                             returns nothing
		public static void Sleep() {  }//native Sleep                takes real seconds                          returns nothing
		public static bool UnitAlive() { return false; }//native UnitAlive            takes unit id                               returns boolean
		public static bool UnitInvis() { return false; }//native UnitInvis            takes unit id                               returns boolean
		public static int IgnoredUnits() { return 0; }//native IgnoredUnits         takes integer unitid                        returns integer
		public static bool TownThreatened() { return false; }//native TownThreatened       takes nothing                               returns boolean
		public static void DisablePathing() {  }//native DisablePathing       takes nothing                               returns nothing
		public static void SetAmphibious() {  }//native SetAmphibious        takes nothing                               returns nothing
		public static int CommandsWaiting() { return 0; }//native CommandsWaiting      takes nothing                               returns integer
		public static int GetLastCommand() { return 0; }//native GetLastCommand       takes nothing                               returns integer
		public static int GetLastData() { return 0; }//native GetLastData          takes nothing                               returns integer
		public static void PopLastCommand() {  }//native PopLastCommand       takes nothing                               returns nothing
		public static int MeleeDifficulty() { return 0; }//native MeleeDifficulty      takes nothing                               returns integer
		public static race ConvertRace() { return ; }//constant native ConvertRace                 takes integer i returns race
		public static alliancetype ConvertAllianceType() { return ; }//constant native ConvertAllianceType         takes integer i returns alliancetype
		public static racepreference ConvertRacePref() { return ; }//constant native ConvertRacePref             takes integer i returns racepreference
		public static igamestate ConvertIGameState() { return ; }//constant native ConvertIGameState           takes integer i returns igamestate
		public static fgamestate ConvertFGameState() { return ; }//constant native ConvertFGameState           takes integer i returns fgamestate
		public static playerstate ConvertPlayerState() { return ; }//constant native ConvertPlayerState          takes integer i returns playerstate
		public static playerscore ConvertPlayerScore() { return ; }//constant native ConvertPlayerScore          takes integer i returns playerscore
		public static playergameresult ConvertPlayerGameResult() { return ; }//constant native ConvertPlayerGameResult     takes integer i returns playergameresult
		public static unitstate ConvertUnitState() { return ; }//constant native ConvertUnitState            takes integer i returns unitstate
		public static aidifficulty ConvertAIDifficulty() { return ; }//constant native ConvertAIDifficulty         takes integer i returns aidifficulty
		public static gameevent ConvertGameEvent() { return ; }//constant native ConvertGameEvent            takes integer i returns gameevent
		public static playerevent ConvertPlayerEvent() { return ; }//constant native ConvertPlayerEvent          takes integer i returns playerevent
		public static playerunitevent ConvertPlayerUnitEvent() { return ; }//constant native ConvertPlayerUnitEvent      takes integer i returns playerunitevent
		public static widgetevent ConvertWidgetEvent() { return ; }//constant native ConvertWidgetEvent          takes integer i returns widgetevent
		public static dialogevent ConvertDialogEvent() { return ; }//constant native ConvertDialogEvent          takes integer i returns dialogevent
		public static unitevent ConvertUnitEvent() { return ; }//constant native ConvertUnitEvent            takes integer i returns unitevent
		public static limitop ConvertLimitOp() { return ; }//constant native ConvertLimitOp              takes integer i returns limitop
		public static unittype ConvertUnitType() { return ; }//constant native ConvertUnitType             takes integer i returns unittype
		public static gamespeed ConvertGameSpeed() { return ; }//constant native ConvertGameSpeed            takes integer i returns gamespeed
		public static placement ConvertPlacement() { return ; }//constant native ConvertPlacement            takes integer i returns placement
		public static startlocprio ConvertStartLocPrio() { return ; }//constant native ConvertStartLocPrio         takes integer i returns startlocprio
		public static gamedifficulty ConvertGameDifficulty() { return ; }//constant native ConvertGameDifficulty       takes integer i returns gamedifficulty
		public static gametype ConvertGameType() { return ; }//constant native ConvertGameType             takes integer i returns gametype
		public static mapflag ConvertMapFlag() { return ; }//constant native ConvertMapFlag              takes integer i returns mapflag
		public static mapvisibility ConvertMapVisibility() { return ; }//constant native ConvertMapVisibility        takes integer i returns mapvisibility
		public static mapsetting ConvertMapSetting() { return ; }//constant native ConvertMapSetting           takes integer i returns mapsetting
		public static mapdensity ConvertMapDensity() { return ; }//constant native ConvertMapDensity           takes integer i returns mapdensity
		public static mapcontrol ConvertMapControl() { return ; }//constant native ConvertMapControl           takes integer i returns mapcontrol
		public static playercolor ConvertPlayerColor() { return ; }//constant native ConvertPlayerColor          takes integer i returns playercolor
		public static playerslotstate ConvertPlayerSlotState() { return ; }//constant native ConvertPlayerSlotState      takes integer i returns playerslotstate
		public static volumegroup ConvertVolumeGroup() { return ; }//constant native ConvertVolumeGroup          takes integer i returns volumegroup
		public static camerafield ConvertCameraField() { return ; }//constant native ConvertCameraField          takes integer i returns camerafield
		public static blendmode ConvertBlendMode() { return ; }//constant native ConvertBlendMode            takes integer i returns blendmode
		public static raritycontrol ConvertRarityControl() { return ; }//constant native ConvertRarityControl        takes integer i returns raritycontrol
		public static texmapflags ConvertTexMapFlags() { return ; }//constant native ConvertTexMapFlags          takes integer i returns texmapflags
		public static fogstate ConvertFogState() { return ; }//constant native ConvertFogState             takes integer i returns fogstate
		public static effecttype ConvertEffectType() { return ; }//constant native ConvertEffectType           takes integer i returns effecttype
		public static version ConvertVersion() { return ; }//constant native ConvertVersion              takes integer i returns version
		public static itemtype ConvertItemType() { return ; }//constant native ConvertItemType             takes integer i returns itemtype
		public static attacktype ConvertAttackType() { return ; }//constant native ConvertAttackType           takes integer i returns attacktype
		public static damagetype ConvertDamageType() { return ; }//constant native ConvertDamageType           takes integer i returns damagetype
		public static weapontype ConvertWeaponType() { return ; }//constant native ConvertWeaponType           takes integer i returns weapontype
		public static soundtype ConvertSoundType() { return ; }//constant native ConvertSoundType            takes integer i returns soundtype
		public static pathingtype ConvertPathingType() { return ; }//constant native ConvertPathingType          takes integer i returns pathingtype
		public static int OrderId() { return 0; }//constant native OrderId                     takes string  orderIdString     returns integer
		public static string OrderId2String() { return ; }//constant native OrderId2String              takes integer orderId           returns string
		public static int UnitId() { return 0; }//constant native UnitId                      takes string  unitIdString      returns integer
		public static string UnitId2String() { return ; }//constant native UnitId2String               takes integer unitId            returns string
		public static int AbilityId() { return 0; }//constant native AbilityId                   takes string  abilityIdString   returns integer
		public static string AbilityId2String() { return ; }//constant native AbilityId2String            takes integer abilityId         returns string
		public static string GetObjectName() { return ; }//constant native GetObjectName               takes integer objectId          returns string
		public static real Deg2Rad() { return ; }//native Deg2Rad  takes real degrees returns real
		public static real Rad2Deg() { return ; }//native Rad2Deg  takes real radians returns real
		public static real Sin() { return ; }//native Sin      takes real radians returns real
		public static real Cos() { return ; }//native Cos      takes real radians returns real
		public static real Tan() { return ; }//native Tan      takes real radians returns real
		public static real Asin() { return ; }//native Asin     takes real y returns real
		public static real Acos() { return ; }//native Acos     takes real x returns real
		public static real Atan() { return ; }//native Atan     takes real x returns real
		public static real Atan2(real y, real x) { return ; }//native Atan2    takes real y, real x returns real
		public static real SquareRoot() { return ; }//native SquareRoot takes real x returns real
		public static real Pow(real x, real power) { return ; }//native Pow      takes real x, real power returns real
		public static real I2R() { return ; }//native I2R  takes integer i returns real
		public static int R2I() { return 0; }//native R2I  takes real r returns integer
		public static string I2S() { return ; }//native I2S  takes integer i returns string
		public static string R2S() { return ; }//native R2S  takes real r returns string
		public static string R2SW(real r, int width, int precision) { return ; }//native R2SW takes real r, integer width, integer precision returns string
		public static int S2I() { return 0; }//native S2I  takes string s returns integer
		public static real S2R() { return ; }//native S2R  takes string s returns real
		public static int GetHandleId() { return 0; }//native GetHandleId takes handle h returns integer
		public static string SubString(string source, int start, int end) { return ; }//native SubString takes string source, integer start, integer end returns string
		public static int StringLength() { return 0; }//native StringLength takes string s returns integer
		public static string StringCase(string source, bool upper) { return ; }//native StringCase takes string source, boolean upper returns string
		public static int StringHash() { return 0; }//native StringHash takes string s returns integer
		public static string GetLocalizedString() { return ; }//native GetLocalizedString takes string source returns string
		public static int GetLocalizedHotkey() { return 0; }//native GetLocalizedHotkey takes string source returns integer
		public static void SetMapName() {  }//native SetMapName           takes string name returns nothing
		public static void SetMapDescription() {  }//native SetMapDescription    takes string description returns nothing
		public static void SetTeams() {  }//native SetTeams             takes integer teamcount returns nothing
		public static void SetPlayers() {  }//native SetPlayers           takes integer playercount returns nothing
		public static void DefineStartLocation(int whichStartLoc, real x, real y) {  }//native DefineStartLocation      takes integer whichStartLoc, real x, real y returns nothing
		public static void DefineStartLocationLoc(int whichStartLoc, location whichLocation) {  }//native DefineStartLocationLoc   takes integer whichStartLoc, location whichLocation returns nothing
		public static void SetStartLocPrioCount(int whichStartLoc, int prioSlotCount) {  }//native SetStartLocPrioCount     takes integer whichStartLoc, integer prioSlotCount returns nothing
		public static void SetStartLocPrio(int whichStartLoc, int prioSlotIndex, int otherStartLocIndex, startlocprio priority) {  }//native SetStartLocPrio          takes integer whichStartLoc, integer prioSlotIndex, integer otherStartLocIndex, startlocprio priority returns nothing
		public static int GetStartLocPrioSlot(int whichStartLoc, int prioSlotIndex) { return 0; }//native GetStartLocPrioSlot      takes integer whichStartLoc, integer prioSlotIndex returns integer
		public static startlocprio GetStartLocPrio(int whichStartLoc, int prioSlotIndex) { return ; }//native GetStartLocPrio          takes integer whichStartLoc, integer prioSlotIndex returns startlocprio
		public static void SetGameTypeSupported(gametype whichGameType, bool value) {  }//native SetGameTypeSupported takes gametype whichGameType, boolean value returns nothing
		public static void SetMapFlag(mapflag whichMapFlag, bool value) {  }//native SetMapFlag           takes mapflag whichMapFlag, boolean value returns nothing
		public static void SetGamePlacement() {  }//native SetGamePlacement     takes placement whichPlacementType returns nothing
		public static void SetGameSpeed() {  }//native SetGameSpeed         takes gamespeed whichspeed returns nothing
		public static void SetGameDifficulty() {  }//native SetGameDifficulty    takes gamedifficulty whichdifficulty returns nothing
		public static void SetResourceDensity() {  }//native SetResourceDensity   takes mapdensity whichdensity returns nothing
		public static void SetCreatureDensity() {  }//native SetCreatureDensity   takes mapdensity whichdensity returns nothing
		public static int GetTeams() { return 0; }//native GetTeams             takes nothing returns integer
		public static int GetPlayers() { return 0; }//native GetPlayers           takes nothing returns integer
		public static bool IsGameTypeSupported() { return false; }//native IsGameTypeSupported  takes gametype whichGameType returns boolean
		public static gametype GetGameTypeSelected() { return ; }//native GetGameTypeSelected  takes nothing returns gametype
		public static bool IsMapFlagSet() { return false; }//native IsMapFlagSet         takes mapflag whichMapFlag returns boolean
		public static placement GetGamePlacement() { return ; }//constant native GetGamePlacement     takes nothing returns placement
		public static gamespeed GetGameSpeed() { return ; }//constant native GetGameSpeed         takes nothing returns gamespeed
		public static gamedifficulty GetGameDifficulty() { return ; }//constant native GetGameDifficulty    takes nothing returns gamedifficulty
		public static mapdensity GetResourceDensity() { return ; }//constant native GetResourceDensity   takes nothing returns mapdensity
		public static mapdensity GetCreatureDensity() { return ; }//constant native GetCreatureDensity   takes nothing returns mapdensity
		public static real GetStartLocationX() { return ; }//constant native GetStartLocationX    takes integer whichStartLocation returns real
		public static real GetStartLocationY() { return ; }//constant native GetStartLocationY    takes integer whichStartLocation returns real
		public static location GetStartLocationLoc() { return ; }//constant native GetStartLocationLoc  takes integer whichStartLocation returns location
		public static void SetPlayerTeam(player whichPlayer, int whichTeam) {  }//native SetPlayerTeam            takes player whichPlayer, integer whichTeam returns nothing
		public static void SetPlayerStartLocation(player whichPlayer, int startLocIndex) {  }//native SetPlayerStartLocation   takes player whichPlayer, integer startLocIndex returns nothing
		public static void ForcePlayerStartLocation(player whichPlayer, int startLocIndex) {  }//native ForcePlayerStartLocation takes player whichPlayer, integer startLocIndex returns nothing
		public static void SetPlayerColor(player whichPlayer, playercolor color) {  }//native SetPlayerColor           takes player whichPlayer, playercolor color returns nothing
		public static void SetPlayerAlliance(player sourcePlayer, player otherPlayer, alliancetype whichAllianceSetting, bool value) {  }//native SetPlayerAlliance        takes player sourcePlayer, player otherPlayer, alliancetype whichAllianceSetting, boolean value returns nothing
		public static void SetPlayerTaxRate(player sourcePlayer, player otherPlayer, playerstate whichResource, int rate) {  }//native SetPlayerTaxRate         takes player sourcePlayer, player otherPlayer, playerstate whichResource, integer rate returns nothing
		public static void SetPlayerRacePreference(player whichPlayer, racepreference whichRacePreference) {  }//native SetPlayerRacePreference  takes player whichPlayer, racepreference whichRacePreference returns nothing
		public static void SetPlayerRaceSelectable(player whichPlayer, bool value) {  }//native SetPlayerRaceSelectable  takes player whichPlayer, boolean value returns nothing
		public static void SetPlayerController(player whichPlayer, mapcontrol controlType) {  }//native SetPlayerController      takes player whichPlayer, mapcontrol controlType returns nothing
		public static void SetPlayerName(player whichPlayer, string name) {  }//native SetPlayerName            takes player whichPlayer, string name returns nothing
		public static void SetPlayerOnScoreScreen(player whichPlayer, bool flag) {  }//native SetPlayerOnScoreScreen   takes player whichPlayer, boolean flag returns nothing
		public static int GetPlayerTeam() { return 0; }//native GetPlayerTeam            takes player whichPlayer returns integer
		public static int GetPlayerStartLocation() { return 0; }//native GetPlayerStartLocation   takes player whichPlayer returns integer
		public static playercolor GetPlayerColor() { return ; }//native GetPlayerColor           takes player whichPlayer returns playercolor
		public static bool GetPlayerSelectable() { return false; }//native GetPlayerSelectable      takes player whichPlayer returns boolean
		public static mapcontrol GetPlayerController() { return ; }//native GetPlayerController      takes player whichPlayer returns mapcontrol
		public static playerslotstate GetPlayerSlotState() { return ; }//native GetPlayerSlotState       takes player whichPlayer returns playerslotstate
		public static int GetPlayerTaxRate(player sourcePlayer, player otherPlayer, playerstate whichResource) { return 0; }//native GetPlayerTaxRate         takes player sourcePlayer, player otherPlayer, playerstate whichResource returns integer
		public static bool IsPlayerRacePrefSet(player whichPlayer, racepreference pref) { return false; }//native IsPlayerRacePrefSet      takes player whichPlayer, racepreference pref returns boolean
		public static string GetPlayerName() { return ; }//native GetPlayerName            takes player whichPlayer returns string
		public static timer CreateTimer() { return ; }//native CreateTimer          takes nothing returns timer
		public static void DestroyTimer() {  }//native DestroyTimer         takes timer whichTimer returns nothing
		public static void TimerStart(timer whichTimer, real timeout, bool periodic, code handlerFunc) {  }//native TimerStart           takes timer whichTimer, real timeout, boolean periodic, code handlerFunc returns nothing
		public static real TimerGetElapsed() { return ; }//native TimerGetElapsed      takes timer whichTimer returns real
		public static real TimerGetRemaining() { return ; }//native TimerGetRemaining    takes timer whichTimer returns real
		public static real TimerGetTimeout() { return ; }//native TimerGetTimeout      takes timer whichTimer returns real
		public static void PauseTimer() {  }//native PauseTimer           takes timer whichTimer returns nothing
		public static void ResumeTimer() {  }//native ResumeTimer          takes timer whichTimer returns nothing
		public static timer GetExpiredTimer() { return ; }//native GetExpiredTimer      takes nothing returns timer
		public static group CreateGroup() { return ; }//native CreateGroup                          takes nothing returns group
		public static void DestroyGroup() {  }//native DestroyGroup                         takes group whichGroup returns nothing
		public static void GroupAddUnit(group whichGroup, int whichUnit) {  }//native GroupAddUnit                         takes group whichGroup, unit whichUnit returns nothing
		public static void GroupRemoveUnit(group whichGroup, int whichUnit) {  }//native GroupRemoveUnit                      takes group whichGroup, unit whichUnit returns nothing
		public static void GroupClear() {  }//native GroupClear                           takes group whichGroup returns nothing
		public static void GroupEnumUnitsOfType(group whichGroup, string unitname, boolexpr filter) {  }//native GroupEnumUnitsOfType                 takes group whichGroup, string unitname, boolexpr filter returns nothing
		public static void GroupEnumUnitsOfPlayer(group whichGroup, player whichPlayer, boolexpr filter) {  }//native GroupEnumUnitsOfPlayer               takes group whichGroup, player whichPlayer, boolexpr filter returns nothing
		public static void GroupEnumUnitsOfTypeCounted(group whichGroup, string unitname, boolexpr filter, int countLimit) {  }//native GroupEnumUnitsOfTypeCounted          takes group whichGroup, string unitname, boolexpr filter, integer countLimit returns nothing
		public static void GroupEnumUnitsInRect(group whichGroup, rect r, boolexpr filter) {  }//native GroupEnumUnitsInRect                 takes group whichGroup, rect r, boolexpr filter returns nothing
		public static void GroupEnumUnitsInRectCounted(group whichGroup, rect r, boolexpr filter, int countLimit) {  }//native GroupEnumUnitsInRectCounted          takes group whichGroup, rect r, boolexpr filter, integer countLimit returns nothing
		public static void GroupEnumUnitsInRange(group whichGroup, real x, real y, real radius, boolexpr filter) {  }//native GroupEnumUnitsInRange                takes group whichGroup, real x, real y, real radius, boolexpr filter returns nothing
		public static void GroupEnumUnitsInRangeOfLoc(group whichGroup, location whichLocation, real radius, boolexpr filter) {  }//native GroupEnumUnitsInRangeOfLoc           takes group whichGroup, location whichLocation, real radius, boolexpr filter returns nothing
		public static void GroupEnumUnitsInRangeCounted(group whichGroup, real x, real y, real radius, boolexpr filter, int countLimit) {  }//native GroupEnumUnitsInRangeCounted         takes group whichGroup, real x, real y, real radius, boolexpr filter, integer countLimit returns nothing
		public static void GroupEnumUnitsInRangeOfLocCounted(group whichGroup, location whichLocation, real radius, boolexpr filter, int countLimit) {  }//native GroupEnumUnitsInRangeOfLocCounted    takes group whichGroup, location whichLocation, real radius, boolexpr filter, integer countLimit returns nothing
		public static void GroupEnumUnitsSelected(group whichGroup, player whichPlayer, boolexpr filter) {  }//native GroupEnumUnitsSelected               takes group whichGroup, player whichPlayer, boolexpr filter returns nothing
		public static bool GroupImmediateOrder(group whichGroup, string order) { return false; }//native GroupImmediateOrder                  takes group whichGroup, string order returns boolean
		public static bool GroupImmediateOrderById(group whichGroup, int order) { return false; }//native GroupImmediateOrderById              takes group whichGroup, integer order returns boolean
		public static bool GroupPointOrder(group whichGroup, string order, real x, real y) { return false; }//native GroupPointOrder                      takes group whichGroup, string order, real x, real y returns boolean
		public static bool GroupPointOrderLoc(group whichGroup, string order, location whichLocation) { return false; }//native GroupPointOrderLoc                   takes group whichGroup, string order, location whichLocation returns boolean
		public static bool GroupPointOrderById(group whichGroup, int order, real x, real y) { return false; }//native GroupPointOrderById                  takes group whichGroup, integer order, real x, real y returns boolean
		public static bool GroupPointOrderByIdLoc(group whichGroup, int order, location whichLocation) { return false; }//native GroupPointOrderByIdLoc               takes group whichGroup, integer order, location whichLocation returns boolean
		public static bool GroupTargetOrder(group whichGroup, string order, widget targetWidget) { return false; }//native GroupTargetOrder                     takes group whichGroup, string order, widget targetWidget returns boolean
		public static bool GroupTargetOrderById(group whichGroup, int order, widget targetWidget) { return false; }//native GroupTargetOrderById                 takes group whichGroup, integer order, widget targetWidget returns boolean
		public static void ForGroup(group whichGroup, code callback) {  }//native ForGroup                 takes group whichGroup, code callback returns nothing
		public static int FirstOfGroup() { return 0; }//native FirstOfGroup             takes group whichGroup returns unit
		public static force CreateForce() { return ; }//native CreateForce              takes nothing returns force
		public static void DestroyForce() {  }//native DestroyForce             takes force whichForce returns nothing
		public static void ForceAddPlayer(force whichForce, player whichPlayer) {  }//native ForceAddPlayer           takes force whichForce, player whichPlayer returns nothing
		public static void ForceRemovePlayer(force whichForce, player whichPlayer) {  }//native ForceRemovePlayer        takes force whichForce, player whichPlayer returns nothing
		public static void ForceClear() {  }//native ForceClear               takes force whichForce returns nothing
		public static void ForceEnumPlayers(force whichForce, boolexpr filter) {  }//native ForceEnumPlayers         takes force whichForce, boolexpr filter returns nothing
		public static void ForceEnumPlayersCounted(force whichForce, boolexpr filter, int countLimit) {  }//native ForceEnumPlayersCounted  takes force whichForce, boolexpr filter, integer countLimit returns nothing
		public static void ForceEnumAllies(force whichForce, player whichPlayer, boolexpr filter) {  }//native ForceEnumAllies          takes force whichForce, player whichPlayer, boolexpr filter returns nothing
		public static void ForceEnumEnemies(force whichForce, player whichPlayer, boolexpr filter) {  }//native ForceEnumEnemies         takes force whichForce, player whichPlayer, boolexpr filter returns nothing
		public static void ForForce(force whichForce, code callback) {  }//native ForForce                 takes force whichForce, code callback returns nothing
		public static rect Rect(real minx, real miny, real maxx, real maxy) { return ; }//native Rect                     takes real minx, real miny, real maxx, real maxy returns rect
		public static rect RectFromLoc(location min, location max) { return ; }//native RectFromLoc              takes location min, location max returns rect
		public static void RemoveRect() {  }//native RemoveRect               takes rect whichRect returns nothing
		public static void SetRect(rect whichRect, real minx, real miny, real maxx, real maxy) {  }//native SetRect                  takes rect whichRect, real minx, real miny, real maxx, real maxy returns nothing
		public static void SetRectFromLoc(rect whichRect, location min, location max) {  }//native SetRectFromLoc           takes rect whichRect, location min, location max returns nothing
		public static void MoveRectTo(rect whichRect, real newCenterX, real newCenterY) {  }//native MoveRectTo               takes rect whichRect, real newCenterX, real newCenterY returns nothing
		public static void MoveRectToLoc(rect whichRect, location newCenterLoc) {  }//native MoveRectToLoc            takes rect whichRect, location newCenterLoc returns nothing
		public static real GetRectCenterX() { return ; }//native GetRectCenterX           takes rect whichRect returns real
		public static real GetRectCenterY() { return ; }//native GetRectCenterY           takes rect whichRect returns real
		public static real GetRectMinX() { return ; }//native GetRectMinX              takes rect whichRect returns real
		public static real GetRectMinY() { return ; }//native GetRectMinY              takes rect whichRect returns real
		public static real GetRectMaxX() { return ; }//native GetRectMaxX              takes rect whichRect returns real
		public static real GetRectMaxY() { return ; }//native GetRectMaxY              takes rect whichRect returns real
		public static region CreateRegion() { return ; }//native CreateRegion             takes nothing returns region
		public static void RemoveRegion() {  }//native RemoveRegion             takes region whichRegion returns nothing
		public static void RegionAddRect(region whichRegion, rect r) {  }//native RegionAddRect            takes region whichRegion, rect r returns nothing
		public static void RegionClearRect(region whichRegion, rect r) {  }//native RegionClearRect          takes region whichRegion, rect r returns nothing
		public static void RegionAddCell(region whichRegion, real x, real y) {  }//native RegionAddCell           takes region whichRegion, real x, real y returns nothing
		public static void RegionAddCellAtLoc(region whichRegion, location whichLocation) {  }//native RegionAddCellAtLoc      takes region whichRegion, location whichLocation returns nothing
		public static void RegionClearCell(region whichRegion, real x, real y) {  }//native RegionClearCell         takes region whichRegion, real x, real y returns nothing
		public static void RegionClearCellAtLoc(region whichRegion, location whichLocation) {  }//native RegionClearCellAtLoc    takes region whichRegion, location whichLocation returns nothing
		public static location Location(real x, real y) { return ; }//native Location                 takes real x, real y returns location
		public static void RemoveLocation() {  }//native RemoveLocation           takes location whichLocation returns nothing
		public static void MoveLocation(location whichLocation, real newX, real newY) {  }//native MoveLocation             takes location whichLocation, real newX, real newY returns nothing
		public static real GetLocationX() { return ; }//native GetLocationX             takes location whichLocation returns real
		public static real GetLocationY() { return ; }//native GetLocationY             takes location whichLocation returns real
		public static real GetLocationZ() { return ; }//native GetLocationZ             takes location whichLocation returns real
		public static bool IsUnitInRegion(region whichRegion, int whichUnit) { return false; }//native IsUnitInRegion               takes region whichRegion, unit whichUnit returns boolean
		public static bool IsPointInRegion(region whichRegion, real x, real y) { return false; }//native IsPointInRegion              takes region whichRegion, real x, real y returns boolean
		public static bool IsLocationInRegion(region whichRegion, location whichLocation) { return false; }//native IsLocationInRegion           takes region whichRegion, location whichLocation returns boolean
		public static rect GetWorldBounds() { return ; }//native GetWorldBounds           takes nothing returns rect
		public static trigger CreateTrigger() { return ; }//native CreateTrigger    takes nothing returns trigger
		public static void DestroyTrigger() {  }//native DestroyTrigger   takes trigger whichTrigger returns nothing
		public static void ResetTrigger() {  }//native ResetTrigger     takes trigger whichTrigger returns nothing
		public static void EnableTrigger() {  }//native EnableTrigger    takes trigger whichTrigger returns nothing
		public static void DisableTrigger() {  }//native DisableTrigger   takes trigger whichTrigger returns nothing
		public static bool IsTriggerEnabled() { return false; }//native IsTriggerEnabled takes trigger whichTrigger returns boolean
		public static void TriggerWaitOnSleeps(trigger whichTrigger, bool flag) {  }//native TriggerWaitOnSleeps   takes trigger whichTrigger, boolean flag returns nothing
		public static bool IsTriggerWaitOnSleeps() { return false; }//native IsTriggerWaitOnSleeps takes trigger whichTrigger returns boolean
		public static int GetFilterUnit() { return 0; }//constant native GetFilterUnit       takes nothing returns unit
		public static int GetEnumUnit() { return 0; }//constant native GetEnumUnit         takes nothing returns unit
		public static destructable GetFilterDestructable() { return ; }//constant native GetFilterDestructable   takes nothing returns destructable
		public static destructable GetEnumDestructable() { return ; }//constant native GetEnumDestructable     takes nothing returns destructable
		public static item GetFilterItem() { return ; }//constant native GetFilterItem           takes nothing returns item
		public static item GetEnumItem() { return ; }//constant native GetEnumItem             takes nothing returns item
		public static player GetFilterPlayer() { return ; }//constant native GetFilterPlayer     takes nothing returns player
		public static player GetEnumPlayer() { return ; }//constant native GetEnumPlayer       takes nothing returns player
		public static trigger GetTriggeringTrigger() { return ; }//constant native GetTriggeringTrigger    takes nothing returns trigger
		public static eventid GetTriggerEventId() { return ; }//constant native GetTriggerEventId       takes nothing returns eventid
		public static int GetTriggerEvalCount() { return 0; }//constant native GetTriggerEvalCount     takes trigger whichTrigger returns integer
		public static int GetTriggerExecCount() { return 0; }//constant native GetTriggerExecCount     takes trigger whichTrigger returns integer
		public static void ExecuteFunc() {  }//native ExecuteFunc          takes string funcName returns nothing
		public static boolexpr And(boolexpr operandA, boolexpr operandB) { return ; }//native And              takes boolexpr operandA, boolexpr operandB returns boolexpr
		public static boolexpr Or(boolexpr operandA, boolexpr operandB) { return ; }//native Or               takes boolexpr operandA, boolexpr operandB returns boolexpr
		public static boolexpr Not() { return ; }//native Not              takes boolexpr operand returns boolexpr
		public static conditionfunc Condition() { return ; }//native Condition        takes code func returns conditionfunc
		public static void DestroyCondition() {  }//native DestroyCondition takes conditionfunc c returns nothing
		public static filterfunc Filter() { return ; }//native Filter           takes code func returns filterfunc
		public static void DestroyFilter() {  }//native DestroyFilter    takes filterfunc f returns nothing
		public static void DestroyBoolExpr() {  }//native DestroyBoolExpr  takes boolexpr e returns nothing
		public static event TriggerRegisterVariableEvent(trigger whichTrigger, string varName, limitop opcode, real limitval) { return ; }//native TriggerRegisterVariableEvent takes trigger whichTrigger, string varName, limitop opcode, real limitval returns event
		public static event TriggerRegisterTimerEvent(trigger whichTrigger, real timeout, bool periodic) { return ; }//native TriggerRegisterTimerEvent takes trigger whichTrigger, real timeout, boolean periodic returns event
		public static event TriggerRegisterTimerExpireEvent(trigger whichTrigger, timer t) { return ; }//native TriggerRegisterTimerExpireEvent takes trigger whichTrigger, timer t returns event
		public static event TriggerRegisterGameStateEvent(trigger whichTrigger, gamestate whichState, limitop opcode, real limitval) { return ; }//native TriggerRegisterGameStateEvent takes trigger whichTrigger, gamestate whichState, limitop opcode, real limitval returns event
		public static event TriggerRegisterDialogEvent(trigger whichTrigger, dialog whichDialog) { return ; }//native TriggerRegisterDialogEvent       takes trigger whichTrigger, dialog whichDialog returns event
		public static event TriggerRegisterDialogButtonEvent(trigger whichTrigger, button whichButton) { return ; }//native TriggerRegisterDialogButtonEvent takes trigger whichTrigger, button whichButton returns event
		public static gamestate GetEventGameState() { return ; }//constant native GetEventGameState takes nothing returns gamestate
		public static event TriggerRegisterGameEvent(trigger whichTrigger, gameevent whichGameEvent) { return ; }//native TriggerRegisterGameEvent takes trigger whichTrigger, gameevent whichGameEvent returns event
		public static player GetWinningPlayer() { return ; }//constant native GetWinningPlayer takes nothing returns player
		public static event TriggerRegisterEnterRegion(trigger whichTrigger, region whichRegion, boolexpr filter) { return ; }//native TriggerRegisterEnterRegion takes trigger whichTrigger, region whichRegion, boolexpr filter returns event
		public static region GetTriggeringRegion() { return ; }//constant native GetTriggeringRegion takes nothing returns region
		public static int GetEnteringUnit() { return 0; }//constant native GetEnteringUnit takes nothing returns unit
		public static event TriggerRegisterLeaveRegion(trigger whichTrigger, region whichRegion, boolexpr filter) { return ; }//native TriggerRegisterLeaveRegion takes trigger whichTrigger, region whichRegion, boolexpr filter returns event
		public static int GetLeavingUnit() { return 0; }//constant native GetLeavingUnit takes nothing returns unit
		public static event TriggerRegisterTrackableHitEvent(trigger whichTrigger, trackable t) { return ; }//native TriggerRegisterTrackableHitEvent takes trigger whichTrigger, trackable t returns event
		public static event TriggerRegisterTrackableTrackEvent(trigger whichTrigger, trackable t) { return ; }//native TriggerRegisterTrackableTrackEvent takes trigger whichTrigger, trackable t returns event
		public static trackable GetTriggeringTrackable() { return ; }//constant native GetTriggeringTrackable takes nothing returns trackable
		public static button GetClickedButton() { return ; }//constant native GetClickedButton takes nothing returns button
		public static dialog GetClickedDialog() { return ; }//constant native GetClickedDialog    takes nothing returns dialog
		public static real GetTournamentFinishSoonTimeRemaining() { return ; }//constant native GetTournamentFinishSoonTimeRemaining takes nothing returns real
		public static int GetTournamentFinishNowRule() { return 0; }//constant native GetTournamentFinishNowRule takes nothing returns integer
		public static player GetTournamentFinishNowPlayer() { return ; }//constant native GetTournamentFinishNowPlayer takes nothing returns player
		public static int GetTournamentScore() { return 0; }//constant native GetTournamentScore takes player whichPlayer returns integer
		public static string GetSaveBasicFilename() { return ; }//constant native GetSaveBasicFilename takes nothing returns string
		public static event TriggerRegisterPlayerEvent(trigger whichTrigger, player whichPlayer, playerevent whichPlayerEvent) { return ; }//native TriggerRegisterPlayerEvent takes trigger whichTrigger, player  whichPlayer, playerevent whichPlayerEvent returns event
		public static player GetTriggerPlayer() { return ; }//constant native GetTriggerPlayer takes nothing returns player
		public static event TriggerRegisterPlayerUnitEvent(trigger whichTrigger, player whichPlayer, playerunitevent whichPlayerUnitEvent, boolexpr filter) { return ; }//native TriggerRegisterPlayerUnitEvent takes trigger whichTrigger, player whichPlayer, playerunitevent whichPlayerUnitEvent, boolexpr filter returns event
		public static int GetLevelingUnit() { return 0; }//constant native GetLevelingUnit takes nothing returns unit
		public static int GetLearningUnit() { return 0; }//constant native GetLearningUnit      takes nothing returns unit
		public static int GetLearnedSkill() { return 0; }//constant native GetLearnedSkill      takes nothing returns integer
		public static int GetLearnedSkillLevel() { return 0; }//constant native GetLearnedSkillLevel takes nothing returns integer
		public static int GetRevivableUnit() { return 0; }//constant native GetRevivableUnit takes nothing returns unit
		public static int GetRevivingUnit() { return 0; }//constant native GetRevivingUnit takes nothing returns unit
		public static int GetAttacker() { return 0; }//constant native GetAttacker takes nothing returns unit
		public static int GetRescuer() { return 0; }//constant native GetRescuer  takes nothing returns unit
		public static int GetDyingUnit() { return 0; }//constant native GetDyingUnit takes nothing returns unit
		public static int GetKillingUnit() { return 0; }//constant native GetKillingUnit takes nothing returns unit
		public static int GetDecayingUnit() { return 0; }//constant native GetDecayingUnit takes nothing returns unit
		public static int GetConstructingStructure() { return 0; }//constant native GetConstructingStructure takes nothing returns unit
		public static int GetCancelledStructure() { return 0; }//constant native GetCancelledStructure takes nothing returns unit
		public static int GetConstructedStructure() { return 0; }//constant native GetConstructedStructure takes nothing returns unit
		public static int GetResearchingUnit() { return 0; }//constant native GetResearchingUnit takes nothing returns unit
		public static int GetResearched() { return 0; }//constant native GetResearched takes nothing returns integer
		public static int GetTrainedUnitType() { return 0; }//constant native GetTrainedUnitType takes nothing returns integer
		public static int GetTrainedUnit() { return 0; }//constant native GetTrainedUnit takes nothing returns unit
		public static int GetDetectedUnit() { return 0; }//constant native GetDetectedUnit takes nothing returns unit
		public static int GetSummoningUnit() { return 0; }//constant native GetSummoningUnit    takes nothing returns unit
		public static int GetSummonedUnit() { return 0; }//constant native GetSummonedUnit     takes nothing returns unit
		public static int GetTransportUnit() { return 0; }//constant native GetTransportUnit    takes nothing returns unit
		public static int GetLoadedUnit() { return 0; }//constant native GetLoadedUnit       takes nothing returns unit
		public static int GetSellingUnit() { return 0; }//constant native GetSellingUnit      takes nothing returns unit
		public static int GetSoldUnit() { return 0; }//constant native GetSoldUnit         takes nothing returns unit
		public static int GetBuyingUnit() { return 0; }//constant native GetBuyingUnit       takes nothing returns unit
		public static item GetSoldItem() { return ; }//constant native GetSoldItem         takes nothing returns item
		public static int GetChangingUnit() { return 0; }//constant native GetChangingUnit             takes nothing returns unit
		public static player GetChangingUnitPrevOwner() { return ; }//constant native GetChangingUnitPrevOwner    takes nothing returns player
		public static int GetManipulatingUnit() { return 0; }//constant native GetManipulatingUnit takes nothing returns unit
		public static item GetManipulatedItem() { return ; }//constant native GetManipulatedItem  takes nothing returns item
		public static int GetOrderedUnit() { return 0; }//constant native GetOrderedUnit takes nothing returns unit
		public static int GetIssuedOrderId() { return 0; }//constant native GetIssuedOrderId takes nothing returns integer
		public static real GetOrderPointX() { return ; }//constant native GetOrderPointX takes nothing returns real
		public static real GetOrderPointY() { return ; }//constant native GetOrderPointY takes nothing returns real
		public static location GetOrderPointLoc() { return ; }//constant native GetOrderPointLoc takes nothing returns location
		public static widget GetOrderTarget() { return ; }//constant native GetOrderTarget              takes nothing returns widget
		public static destructable GetOrderTargetDestructable() { return ; }//constant native GetOrderTargetDestructable  takes nothing returns destructable
		public static item GetOrderTargetItem() { return ; }//constant native GetOrderTargetItem          takes nothing returns item
		public static int GetOrderTargetUnit() { return 0; }//constant native GetOrderTargetUnit          takes nothing returns unit
		public static int GetSpellAbilityUnit() { return 0; }//constant native GetSpellAbilityUnit         takes nothing returns unit
		public static int GetSpellAbilityId() { return 0; }//constant native GetSpellAbilityId           takes nothing returns integer
		public static ability GetSpellAbility() { return ; }//constant native GetSpellAbility             takes nothing returns ability
		public static location GetSpellTargetLoc() { return ; }//constant native GetSpellTargetLoc           takes nothing returns location
		public static real GetSpellTargetX() { return ; }//constant native GetSpellTargetX				takes nothing returns real
		public static real GetSpellTargetY() { return ; }//constant native GetSpellTargetY				takes nothing returns real
		public static destructable GetSpellTargetDestructable() { return ; }//constant native GetSpellTargetDestructable  takes nothing returns destructable
		public static item GetSpellTargetItem() { return ; }//constant native GetSpellTargetItem          takes nothing returns item
		public static int GetSpellTargetUnit() { return 0; }//constant native GetSpellTargetUnit          takes nothing returns unit
		public static event TriggerRegisterPlayerAllianceChange(trigger whichTrigger, player whichPlayer, alliancetype whichAlliance) { return ; }//native TriggerRegisterPlayerAllianceChange takes trigger whichTrigger, player whichPlayer, alliancetype whichAlliance returns event
		public static event TriggerRegisterPlayerStateEvent(trigger whichTrigger, player whichPlayer, playerstate whichState, limitop opcode, real limitval) { return ; }//native TriggerRegisterPlayerStateEvent takes trigger whichTrigger, player whichPlayer, playerstate whichState, limitop opcode, real limitval returns event
		public static playerstate GetEventPlayerState() { return ; }//constant native GetEventPlayerState takes nothing returns playerstate
		public static event TriggerRegisterPlayerChatEvent(trigger whichTrigger, player whichPlayer, string chatMessageToDetect, bool exactMatchOnly) { return ; }//native TriggerRegisterPlayerChatEvent takes trigger whichTrigger, player whichPlayer, string chatMessageToDetect, boolean exactMatchOnly returns event
		public static string GetEventPlayerChatString() { return ; }//constant native GetEventPlayerChatString takes nothing returns string
		public static string GetEventPlayerChatStringMatched() { return ; }//constant native GetEventPlayerChatStringMatched takes nothing returns string
		public static event TriggerRegisterDeathEvent(trigger whichTrigger, widget whichWidget) { return ; }//native TriggerRegisterDeathEvent takes trigger whichTrigger, widget whichWidget returns event
		public static int GetTriggerUnit() { return 0; }//constant native GetTriggerUnit takes nothing returns unit
		public static event TriggerRegisterUnitStateEvent(trigger whichTrigger, int whichUnit, unitstate whichState, limitop opcode, real limitval) { return ; }//native TriggerRegisterUnitStateEvent takes trigger whichTrigger, unit whichUnit, unitstate whichState, limitop opcode, real limitval returns event
		public static unitstate GetEventUnitState() { return ; }//constant native GetEventUnitState takes nothing returns unitstate
		public static event TriggerRegisterUnitEvent(trigger whichTrigger, int whichUnit, unitevent whichEvent) { return ; }//native TriggerRegisterUnitEvent takes trigger whichTrigger, unit whichUnit, unitevent whichEvent returns event
		public static real GetEventDamage() { return ; }//constant native GetEventDamage takes nothing returns real
		public static int GetEventDamageSource() { return 0; }//constant native GetEventDamageSource takes nothing returns unit
		public static player GetEventDetectingPlayer() { return ; }//constant native GetEventDetectingPlayer takes nothing returns player
		public static event TriggerRegisterFilterUnitEvent(trigger whichTrigger, int whichUnit, unitevent whichEvent, boolexpr filter) { return ; }//native TriggerRegisterFilterUnitEvent takes trigger whichTrigger, unit whichUnit, unitevent whichEvent, boolexpr filter returns event
		public static int GetEventTargetUnit() { return 0; }//constant native GetEventTargetUnit takes nothing returns unit
		public static event TriggerRegisterUnitInRange(trigger whichTrigger, int whichUnit, real range, boolexpr filter) { return ; }//native TriggerRegisterUnitInRange takes trigger whichTrigger, unit whichUnit, real range, boolexpr filter returns event
		public static triggercondition TriggerAddCondition(trigger whichTrigger, boolexpr condition) { return ; }//native TriggerAddCondition    takes trigger whichTrigger, boolexpr condition returns triggercondition
		public static void TriggerRemoveCondition(trigger whichTrigger, triggercondition whichCondition) {  }//native TriggerRemoveCondition takes trigger whichTrigger, triggercondition whichCondition returns nothing
		public static void TriggerClearConditions() {  }//native TriggerClearConditions takes trigger whichTrigger returns nothing
		public static triggeraction TriggerAddAction(trigger whichTrigger, code actionFunc) { return ; }//native TriggerAddAction     takes trigger whichTrigger, code actionFunc returns triggeraction
		public static void TriggerRemoveAction(trigger whichTrigger, triggeraction whichAction) {  }//native TriggerRemoveAction  takes trigger whichTrigger, triggeraction whichAction returns nothing
		public static void TriggerClearActions() {  }//native TriggerClearActions  takes trigger whichTrigger returns nothing
		public static void TriggerSleepAction() {  }//native TriggerSleepAction   takes real timeout returns nothing
		public static void TriggerWaitForSound(sound s, real offset) {  }//native TriggerWaitForSound  takes sound s, real offset returns nothing
		public static bool TriggerEvaluate() { return false; }//native TriggerEvaluate      takes trigger whichTrigger returns boolean
		public static void TriggerExecute() {  }//native TriggerExecute       takes trigger whichTrigger returns nothing
		public static void TriggerExecuteWait() {  }//native TriggerExecuteWait   takes trigger whichTrigger returns nothing
		public static void TriggerSyncStart() {  }//native TriggerSyncStart     takes nothing returns nothing
		public static void TriggerSyncReady() {  }//native TriggerSyncReady     takes nothing returns nothing
		public static real GetWidgetLife() { return ; }//native  GetWidgetLife   takes widget whichWidget returns real
		public static void SetWidgetLife(widget whichWidget, real newLife) {  }//native  SetWidgetLife   takes widget whichWidget, real newLife returns nothing
		public static real GetWidgetX() { return ; }//native  GetWidgetX      takes widget whichWidget returns real
		public static real GetWidgetY() { return ; }//native  GetWidgetY      takes widget whichWidget returns real
		public static widget GetTriggerWidget() { return ; }//constant native GetTriggerWidget takes nothing returns widget
		public static destructable CreateDestructable(int objectid, real x, real y, real face, real scale, int variation) { return ; }//native          CreateDestructable          takes integer objectid, real x, real y, real face, real scale, integer variation returns destructable
		public static destructable CreateDestructableZ(int objectid, real x, real y, real z, real face, real scale, int variation) { return ; }//native          CreateDestructableZ         takes integer objectid, real x, real y, real z, real face, real scale, integer variation returns destructable
		public static destructable CreateDeadDestructable(int objectid, real x, real y, real face, real scale, int variation) { return ; }//native          CreateDeadDestructable      takes integer objectid, real x, real y, real face, real scale, integer variation returns destructable
		public static destructable CreateDeadDestructableZ(int objectid, real x, real y, real z, real face, real scale, int variation) { return ; }//native          CreateDeadDestructableZ     takes integer objectid, real x, real y, real z, real face, real scale, integer variation returns destructable
		public static void RemoveDestructable() {  }//native          RemoveDestructable          takes destructable d returns nothing
		public static void KillDestructable() {  }//native          KillDestructable            takes destructable d returns nothing
		public static void SetDestructableInvulnerable(destructable d, bool flag) {  }//native          SetDestructableInvulnerable takes destructable d, boolean flag returns nothing
		public static bool IsDestructableInvulnerable() { return false; }//native          IsDestructableInvulnerable  takes destructable d returns boolean
		public static void EnumDestructablesInRect(rect r, boolexpr filter, code actionFunc) {  }//native          EnumDestructablesInRect     takes rect r, boolexpr filter, code actionFunc returns nothing
		public static int GetDestructableTypeId() { return 0; }//native          GetDestructableTypeId       takes destructable d returns integer
		public static real GetDestructableX() { return ; }//native          GetDestructableX            takes destructable d returns real
		public static real GetDestructableY() { return ; }//native          GetDestructableY            takes destructable d returns real
		public static void SetDestructableLife(destructable d, real life) {  }//native          SetDestructableLife         takes destructable d, real life returns nothing
		public static real GetDestructableLife() { return ; }//native          GetDestructableLife         takes destructable d returns real
		public static void SetDestructableMaxLife(destructable d, real max) {  }//native          SetDestructableMaxLife      takes destructable d, real max returns nothing
		public static real GetDestructableMaxLife() { return ; }//native          GetDestructableMaxLife      takes destructable d returns real
		public static void DestructableRestoreLife(destructable d, real life, bool birth) {  }//native          DestructableRestoreLife     takes destructable d, real life, boolean birth returns nothing
		public static void QueueDestructableAnimation(destructable d, string whichAnimation) {  }//native          QueueDestructableAnimation  takes destructable d, string whichAnimation returns nothing
		public static void SetDestructableAnimation(destructable d, string whichAnimation) {  }//native          SetDestructableAnimation    takes destructable d, string whichAnimation returns nothing
		public static void SetDestructableAnimationSpeed(destructable d, real speedFactor) {  }//native          SetDestructableAnimationSpeed takes destructable d, real speedFactor returns nothing
		public static void ShowDestructable(destructable d, bool flag) {  }//native          ShowDestructable            takes destructable d, boolean flag returns nothing
		public static real GetDestructableOccluderHeight() { return ; }//native          GetDestructableOccluderHeight takes destructable d returns real
		public static void SetDestructableOccluderHeight(destructable d, real height) {  }//native          SetDestructableOccluderHeight takes destructable d, real height returns nothing
		public static string GetDestructableName() { return ; }//native          GetDestructableName         takes destructable d returns string
		public static destructable GetTriggerDestructable() { return ; }//constant native GetTriggerDestructable takes nothing returns destructable
		public static item CreateItem(int itemid, real x, real y) { return ; }//native          CreateItem      takes integer itemid, real x, real y returns item
		public static void RemoveItem() {  }//native          RemoveItem      takes item whichItem returns nothing
		public static player GetItemPlayer() { return ; }//native          GetItemPlayer   takes item whichItem returns player
		public static int GetItemTypeId() { return 0; }//native          GetItemTypeId   takes item i returns integer
		public static real GetItemX() { return ; }//native          GetItemX        takes item i returns real
		public static real GetItemY() { return ; }//native          GetItemY        takes item i returns real
		public static void SetItemPosition(item i, real x, real y) {  }//native          SetItemPosition takes item i, real x, real y returns nothing
		public static void SetItemDropOnDeath(item whichItem, bool flag) {  }//native          SetItemDropOnDeath  takes item whichItem, boolean flag returns nothing
		public static void SetItemDroppable(item i, bool flag) {  }//native          SetItemDroppable takes item i, boolean flag returns nothing
		public static void SetItemPawnable(item i, bool flag) {  }//native          SetItemPawnable takes item i, boolean flag returns nothing
		public static void SetItemPlayer(item whichItem, player whichPlayer, bool changeColor) {  }//native          SetItemPlayer    takes item whichItem, player whichPlayer, boolean changeColor returns nothing
		public static void SetItemInvulnerable(item whichItem, bool flag) {  }//native          SetItemInvulnerable takes item whichItem, boolean flag returns nothing
		public static bool IsItemInvulnerable() { return false; }//native          IsItemInvulnerable  takes item whichItem returns boolean
		public static void SetItemVisible(item whichItem, bool show) {  }//native          SetItemVisible  takes item whichItem, boolean show returns nothing
		public static bool IsItemVisible() { return false; }//native          IsItemVisible   takes item whichItem returns boolean
		public static bool IsItemOwned() { return false; }//native          IsItemOwned     takes item whichItem returns boolean
		public static bool IsItemPowerup() { return false; }//native          IsItemPowerup   takes item whichItem returns boolean
		public static bool IsItemSellable() { return false; }//native          IsItemSellable  takes item whichItem returns boolean
		public static bool IsItemPawnable() { return false; }//native          IsItemPawnable  takes item whichItem returns boolean
		public static bool IsItemIdPowerup() { return false; }//native          IsItemIdPowerup takes integer itemId returns boolean
		public static bool IsItemIdSellable() { return false; }//native          IsItemIdSellable takes integer itemId returns boolean
		public static bool IsItemIdPawnable() { return false; }//native          IsItemIdPawnable takes integer itemId returns boolean
		public static void EnumItemsInRect(rect r, boolexpr filter, code actionFunc) {  }//native          EnumItemsInRect     takes rect r, boolexpr filter, code actionFunc returns nothing
		public static int GetItemLevel() { return 0; }//native          GetItemLevel    takes item whichItem returns integer
		public static itemtype GetItemType() { return ; }//native          GetItemType     takes item whichItem returns itemtype
		public static void SetItemDropID(item whichItem, int unitId) {  }//native          SetItemDropID   takes item whichItem, integer unitId returns nothing
		public static string GetItemName() { return ; }//constant native GetItemName     takes item whichItem returns string
		public static int GetItemCharges() { return 0; }//native          GetItemCharges  takes item whichItem returns integer
		public static void SetItemCharges(item whichItem, int charges) {  }//native          SetItemCharges  takes item whichItem, integer charges returns nothing
		public static int GetItemUserData() { return 0; }//native          GetItemUserData takes item whichItem returns integer
		public static void SetItemUserData(item whichItem, int data) {  }//native          SetItemUserData takes item whichItem, integer data returns nothing
		public static int CreateUnit(player id, int unitid, real x, real y, real face) { return 0; }//native          CreateUnit              takes player id, integer unitid, real x, real y, real face returns unit
		public static int CreateUnitByName(player whichPlayer, string unitname, real x, real y, real face) { return 0; }//native          CreateUnitByName        takes player whichPlayer, string unitname, real x, real y, real face returns unit
		public static int CreateUnitAtLoc(player id, int unitid, location whichLocation, real face) { return 0; }//native          CreateUnitAtLoc         takes player id, integer unitid, location whichLocation, real face returns unit
		public static int CreateUnitAtLocByName(player id, string unitname, location whichLocation, real face) { return 0; }//native          CreateUnitAtLocByName   takes player id, string unitname, location whichLocation, real face returns unit
		public static int CreateCorpse(player whichPlayer, int unitid, real x, real y, real face) { return 0; }//native          CreateCorpse            takes player whichPlayer, integer unitid, real x, real y, real face returns unit
		public static void KillUnit() {  }//native          KillUnit            takes unit whichUnit returns nothing
		public static void RemoveUnit() {  }//native          RemoveUnit          takes unit whichUnit returns nothing
		public static void ShowUnit(int whichUnit, bool show) {  }//native          ShowUnit            takes unit whichUnit, boolean show returns nothing
		public static void SetUnitState(int whichUnit, unitstate whichUnitState, real newVal) {  }//native          SetUnitState        takes unit whichUnit, unitstate whichUnitState, real newVal returns nothing
		public static void SetUnitX(int whichUnit, real newX) {  }//native          SetUnitX            takes unit whichUnit, real newX returns nothing
		public static void SetUnitY(int whichUnit, real newY) {  }//native          SetUnitY            takes unit whichUnit, real newY returns nothing
		public static void SetUnitPosition(int whichUnit, real newX, real newY) {  }//native          SetUnitPosition     takes unit whichUnit, real newX, real newY returns nothing
		public static void SetUnitPositionLoc(int whichUnit, location whichLocation) {  }//native          SetUnitPositionLoc  takes unit whichUnit, location whichLocation returns nothing
		public static void SetUnitFacing(int whichUnit, real facingAngle) {  }//native          SetUnitFacing       takes unit whichUnit, real facingAngle returns nothing
		public static void SetUnitFacingTimed(int whichUnit, real facingAngle, real duration) {  }//native          SetUnitFacingTimed  takes unit whichUnit, real facingAngle, real duration returns nothing
		public static void SetUnitMoveSpeed(int whichUnit, real newSpeed) {  }//native          SetUnitMoveSpeed    takes unit whichUnit, real newSpeed returns nothing
		public static void SetUnitFlyHeight(int whichUnit, real newHeight, real rate) {  }//native          SetUnitFlyHeight    takes unit whichUnit, real newHeight, real rate returns nothing
		public static void SetUnitTurnSpeed(int whichUnit, real newTurnSpeed) {  }//native          SetUnitTurnSpeed    takes unit whichUnit, real newTurnSpeed returns nothing
		public static void SetUnitPropWindow(int whichUnit, real newPropWindowAngle) {  }//native          SetUnitPropWindow   takes unit whichUnit, real newPropWindowAngle returns nothing
		public static void SetUnitAcquireRange(int whichUnit, real newAcquireRange) {  }//native          SetUnitAcquireRange takes unit whichUnit, real newAcquireRange returns nothing
		public static void SetUnitCreepGuard(int whichUnit, bool creepGuard) {  }//native          SetUnitCreepGuard   takes unit whichUnit, boolean creepGuard returns nothing
		public static real GetUnitAcquireRange() { return ; }//native          GetUnitAcquireRange     takes unit whichUnit returns real
		public static real GetUnitTurnSpeed() { return ; }//native          GetUnitTurnSpeed        takes unit whichUnit returns real
		public static real GetUnitPropWindow() { return ; }//native          GetUnitPropWindow       takes unit whichUnit returns real
		public static real GetUnitFlyHeight() { return ; }//native          GetUnitFlyHeight        takes unit whichUnit returns real
		public static real GetUnitDefaultAcquireRange() { return ; }//native          GetUnitDefaultAcquireRange      takes unit whichUnit returns real
		public static real GetUnitDefaultTurnSpeed() { return ; }//native          GetUnitDefaultTurnSpeed         takes unit whichUnit returns real
		public static real GetUnitDefaultPropWindow() { return ; }//native          GetUnitDefaultPropWindow        takes unit whichUnit returns real
		public static real GetUnitDefaultFlyHeight() { return ; }//native          GetUnitDefaultFlyHeight         takes unit whichUnit returns real
		public static void SetUnitOwner(int whichUnit, player whichPlayer, bool changeColor) {  }//native          SetUnitOwner        takes unit whichUnit, player whichPlayer, boolean changeColor returns nothing
		public static void SetUnitColor(int whichUnit, playercolor whichColor) {  }//native          SetUnitColor        takes unit whichUnit, playercolor whichColor returns nothing
		public static void SetUnitScale(int whichUnit, real scaleX, real scaleY, real scaleZ) {  }//native          SetUnitScale        takes unit whichUnit, real scaleX, real scaleY, real scaleZ returns nothing
		public static void SetUnitTimeScale(int whichUnit, real timeScale) {  }//native          SetUnitTimeScale    takes unit whichUnit, real timeScale returns nothing
		public static void SetUnitBlendTime(int whichUnit, real blendTime) {  }//native          SetUnitBlendTime    takes unit whichUnit, real blendTime returns nothing
		public static void SetUnitVertexColor(int whichUnit, int red, int green, int blue, int alpha) {  }//native          SetUnitVertexColor  takes unit whichUnit, integer red, integer green, integer blue, integer alpha returns nothing
		public static void QueueUnitAnimation(int whichUnit, string whichAnimation) {  }//native          QueueUnitAnimation          takes unit whichUnit, string whichAnimation returns nothing
		public static void SetUnitAnimation(int whichUnit, string whichAnimation) {  }//native          SetUnitAnimation            takes unit whichUnit, string whichAnimation returns nothing
		public static void SetUnitAnimationByIndex(int whichUnit, int whichAnimation) {  }//native          SetUnitAnimationByIndex     takes unit whichUnit, integer whichAnimation returns nothing
		public static void SetUnitAnimationWithRarity(int whichUnit, string whichAnimation, raritycontrol rarity) {  }//native          SetUnitAnimationWithRarity  takes unit whichUnit, string whichAnimation, raritycontrol rarity returns nothing
		public static void AddUnitAnimationProperties(int whichUnit, string animProperties, bool add) {  }//native          AddUnitAnimationProperties  takes unit whichUnit, string animProperties, boolean add returns nothing
		public static void SetUnitLookAt(int whichUnit, string whichBone, int lookAtTarget, real offsetX, real offsetY, real offsetZ) {  }//native          SetUnitLookAt       takes unit whichUnit, string whichBone, unit lookAtTarget, real offsetX, real offsetY, real offsetZ returns nothing
		public static void ResetUnitLookAt() {  }//native          ResetUnitLookAt     takes unit whichUnit returns nothing
		public static void SetUnitRescuable(int whichUnit, player byWhichPlayer, bool flag) {  }//native          SetUnitRescuable    takes unit whichUnit, player byWhichPlayer, boolean flag returns nothing
		public static void SetUnitRescueRange(int whichUnit, real range) {  }//native          SetUnitRescueRange  takes unit whichUnit, real range returns nothing
		public static void SetHeroStr(int whichHero, int newStr, bool permanent) {  }//native          SetHeroStr          takes unit whichHero, integer newStr, boolean permanent returns nothing
		public static void SetHeroAgi(int whichHero, int newAgi, bool permanent) {  }//native          SetHeroAgi          takes unit whichHero, integer newAgi, boolean permanent returns nothing
		public static void SetHeroInt(int whichHero, int newInt, bool permanent) {  }//native          SetHeroInt          takes unit whichHero, integer newInt, boolean permanent returns nothing
		public static int GetHeroStr(int whichHero, bool includeBonuses) { return 0; }//native          GetHeroStr          takes unit whichHero, boolean includeBonuses returns integer
		public static int GetHeroAgi(int whichHero, bool includeBonuses) { return 0; }//native          GetHeroAgi          takes unit whichHero, boolean includeBonuses returns integer
		public static int GetHeroInt(int whichHero, bool includeBonuses) { return 0; }//native          GetHeroInt          takes unit whichHero, boolean includeBonuses returns integer
		public static bool UnitStripHeroLevel(int whichHero, int howManyLevels) { return false; }//native          UnitStripHeroLevel  takes unit whichHero, integer howManyLevels returns boolean
		public static int GetHeroXP() { return 0; }//native          GetHeroXP           takes unit whichHero returns integer
		public static void SetHeroXP(int whichHero, int newXpVal, bool showEyeCandy) {  }//native          SetHeroXP           takes unit whichHero, integer newXpVal,  boolean showEyeCandy returns nothing
		public static int GetHeroSkillPoints() { return 0; }//native          GetHeroSkillPoints      takes unit whichHero returns integer
		public static bool UnitModifySkillPoints(int whichHero, int skillPointDelta) { return false; }//native          UnitModifySkillPoints   takes unit whichHero, integer skillPointDelta returns boolean
		public static void AddHeroXP(int whichHero, int xpToAdd, bool showEyeCandy) {  }//native          AddHeroXP           takes unit whichHero, integer xpToAdd,   boolean showEyeCandy returns nothing
		public static void SetHeroLevel(int whichHero, int level, bool showEyeCandy) {  }//native          SetHeroLevel        takes unit whichHero, integer level,  boolean showEyeCandy returns nothing
		public static int GetHeroLevel() { return 0; }//constant native GetHeroLevel        takes unit whichHero returns integer
		public static int GetUnitLevel() { return 0; }//constant native GetUnitLevel        takes unit whichUnit returns integer
		public static string GetHeroProperName() { return ; }//native          GetHeroProperName   takes unit whichHero returns string
		public static void SuspendHeroXP(int whichHero, bool flag) {  }//native          SuspendHeroXP       takes unit whichHero, boolean flag returns nothing
		public static bool IsSuspendedXP() { return false; }//native          IsSuspendedXP       takes unit whichHero returns boolean
		public static void SelectHeroSkill(int whichHero, int abilcode) {  }//native          SelectHeroSkill     takes unit whichHero, integer abilcode returns nothing
		public static int GetUnitAbilityLevel(int whichUnit, int abilcode) { return 0; }//native          GetUnitAbilityLevel takes unit whichUnit, integer abilcode returns integer
		public static int DecUnitAbilityLevel(int whichUnit, int abilcode) { return 0; }//native          DecUnitAbilityLevel takes unit whichUnit, integer abilcode returns integer
		public static int IncUnitAbilityLevel(int whichUnit, int abilcode) { return 0; }//native          IncUnitAbilityLevel takes unit whichUnit, integer abilcode returns integer
		public static int SetUnitAbilityLevel(int whichUnit, int abilcode, int level) { return 0; }//native          SetUnitAbilityLevel takes unit whichUnit, integer abilcode, integer level returns integer
		public static bool ReviveHero(int whichHero, real x, real y, bool doEyecandy) { return false; }//native          ReviveHero          takes unit whichHero, real x, real y, boolean doEyecandy returns boolean
		public static bool ReviveHeroLoc(int whichHero, location loc, bool doEyecandy) { return false; }//native          ReviveHeroLoc       takes unit whichHero, location loc, boolean doEyecandy returns boolean
		public static void SetUnitExploded(int whichUnit, bool exploded) {  }//native          SetUnitExploded     takes unit whichUnit, boolean exploded returns nothing
		public static void SetUnitInvulnerable(int whichUnit, bool flag) {  }//native          SetUnitInvulnerable takes unit whichUnit, boolean flag returns nothing
		public static void PauseUnit(int whichUnit, bool flag) {  }//native          PauseUnit           takes unit whichUnit, boolean flag returns nothing
		public static bool IsUnitPaused() { return false; }//native          IsUnitPaused        takes unit whichHero returns boolean
		public static void SetUnitPathing(int whichUnit, bool flag) {  }//native          SetUnitPathing      takes unit whichUnit, boolean flag returns nothing
		public static void ClearSelection() {  }//native          ClearSelection      takes nothing returns nothing
		public static void SelectUnit(int whichUnit, bool flag) {  }//native          SelectUnit          takes unit whichUnit, boolean flag returns nothing
		public static int GetUnitPointValue() { return 0; }//native          GetUnitPointValue       takes unit whichUnit returns integer
		public static int GetUnitPointValueByType() { return 0; }//native          GetUnitPointValueByType takes integer unitType returns integer
		public static bool UnitAddItem(int whichUnit, item whichItem) { return false; }//native          UnitAddItem             takes unit whichUnit, item whichItem returns boolean
		public static item UnitAddItemById(int whichUnit, int itemId) { return ; }//native          UnitAddItemById         takes unit whichUnit, integer itemId returns item
		public static bool UnitAddItemToSlotById(int whichUnit, int itemId, int itemSlot) { return false; }//native          UnitAddItemToSlotById   takes unit whichUnit, integer itemId, integer itemSlot returns boolean
		public static void UnitRemoveItem(int whichUnit, item whichItem) {  }//native          UnitRemoveItem          takes unit whichUnit, item whichItem returns nothing
		public static item UnitRemoveItemFromSlot(int whichUnit, int itemSlot) { return ; }//native          UnitRemoveItemFromSlot  takes unit whichUnit, integer itemSlot returns item
		public static bool UnitHasItem(int whichUnit, item whichItem) { return false; }//native          UnitHasItem             takes unit whichUnit, item whichItem returns boolean
		public static item UnitItemInSlot(int whichUnit, int itemSlot) { return ; }//native          UnitItemInSlot          takes unit whichUnit, integer itemSlot returns item
		public static int UnitInventorySize() { return 0; }//native          UnitInventorySize       takes unit whichUnit returns integer
		public static bool UnitDropItemPoint(int whichUnit, item whichItem, real x, real y) { return false; }//native          UnitDropItemPoint       takes unit whichUnit, item whichItem, real x, real y returns boolean
		public static bool UnitDropItemSlot(int whichUnit, item whichItem, int slot) { return false; }//native          UnitDropItemSlot        takes unit whichUnit, item whichItem, integer slot returns boolean
		public static bool UnitDropItemTarget(int whichUnit, item whichItem, widget target) { return false; }//native          UnitDropItemTarget      takes unit whichUnit, item whichItem, widget target returns boolean
		public static bool UnitUseItem(int whichUnit, item whichItem) { return false; }//native          UnitUseItem             takes unit whichUnit, item whichItem returns boolean
		public static bool UnitUseItemPoint(int whichUnit, item whichItem, real x, real y) { return false; }//native          UnitUseItemPoint        takes unit whichUnit, item whichItem, real x, real y returns boolean
		public static bool UnitUseItemTarget(int whichUnit, item whichItem, widget target) { return false; }//native          UnitUseItemTarget       takes unit whichUnit, item whichItem, widget target returns boolean
		public static real GetUnitX() { return ; }//constant native GetUnitX            takes unit whichUnit returns real
		public static real GetUnitY() { return ; }//constant native GetUnitY            takes unit whichUnit returns real
		public static location GetUnitLoc() { return ; }//constant native GetUnitLoc          takes unit whichUnit returns location
		public static real GetUnitFacing() { return ; }//constant native GetUnitFacing       takes unit whichUnit returns real
		public static real GetUnitMoveSpeed() { return ; }//constant native GetUnitMoveSpeed    takes unit whichUnit returns real
		public static real GetUnitDefaultMoveSpeed() { return ; }//constant native GetUnitDefaultMoveSpeed takes unit whichUnit returns real
		public static real GetUnitState(int whichUnit, unitstate whichUnitState) { return ; }//constant native GetUnitState        takes unit whichUnit, unitstate whichUnitState returns real
		public static player GetOwningPlayer() { return ; }//constant native GetOwningPlayer     takes unit whichUnit returns player
		public static int GetUnitTypeId() { return 0; }//constant native GetUnitTypeId       takes unit whichUnit returns integer
		public static race GetUnitRace() { return ; }//constant native GetUnitRace         takes unit whichUnit returns race
		public static string GetUnitName() { return ; }//constant native GetUnitName         takes unit whichUnit returns string
		public static int GetUnitFoodUsed() { return 0; }//constant native GetUnitFoodUsed     takes unit whichUnit returns integer
		public static int GetUnitFoodMade() { return 0; }//constant native GetUnitFoodMade     takes unit whichUnit returns integer
		public static int GetFoodMade() { return 0; }//constant native GetFoodMade         takes integer unitId returns integer
		public static int GetFoodUsed() { return 0; }//constant native GetFoodUsed         takes integer unitId returns integer
		public static void SetUnitUseFood(int whichUnit, bool useFood) {  }//native          SetUnitUseFood      takes unit whichUnit, boolean useFood returns nothing
		public static location GetUnitRallyPoint() { return ; }//constant native GetUnitRallyPoint           takes unit whichUnit returns location
		public static int GetUnitRallyUnit() { return 0; }//constant native GetUnitRallyUnit            takes unit whichUnit returns unit
		public static destructable GetUnitRallyDestructable() { return ; }//constant native GetUnitRallyDestructable    takes unit whichUnit returns destructable
		public static bool IsUnitInGroup(int whichUnit, group whichGroup) { return false; }//constant native IsUnitInGroup       takes unit whichUnit, group whichGroup returns boolean
		public static bool IsUnitInForce(int whichUnit, force whichForce) { return false; }//constant native IsUnitInForce       takes unit whichUnit, force whichForce returns boolean
		public static bool IsUnitOwnedByPlayer(int whichUnit, player whichPlayer) { return false; }//constant native IsUnitOwnedByPlayer takes unit whichUnit, player whichPlayer returns boolean
		public static bool IsUnitAlly(int whichUnit, player whichPlayer) { return false; }//constant native IsUnitAlly          takes unit whichUnit, player whichPlayer returns boolean
		public static bool IsUnitEnemy(int whichUnit, player whichPlayer) { return false; }//constant native IsUnitEnemy         takes unit whichUnit, player whichPlayer returns boolean
		public static bool IsUnitVisible(int whichUnit, player whichPlayer) { return false; }//constant native IsUnitVisible       takes unit whichUnit, player whichPlayer returns boolean
		public static bool IsUnitDetected(int whichUnit, player whichPlayer) { return false; }//constant native IsUnitDetected      takes unit whichUnit, player whichPlayer returns boolean
		public static bool IsUnitInvisible(int whichUnit, player whichPlayer) { return false; }//constant native IsUnitInvisible     takes unit whichUnit, player whichPlayer returns boolean
		public static bool IsUnitFogged(int whichUnit, player whichPlayer) { return false; }//constant native IsUnitFogged        takes unit whichUnit, player whichPlayer returns boolean
		public static bool IsUnitMasked(int whichUnit, player whichPlayer) { return false; }//constant native IsUnitMasked        takes unit whichUnit, player whichPlayer returns boolean
		public static bool IsUnitSelected(int whichUnit, player whichPlayer) { return false; }//constant native IsUnitSelected      takes unit whichUnit, player whichPlayer returns boolean
		public static bool IsUnitRace(int whichUnit, race whichRace) { return false; }//constant native IsUnitRace          takes unit whichUnit, race whichRace returns boolean
		public static bool IsUnitType(int whichUnit, unittype whichUnitType) { return false; }//constant native IsUnitType          takes unit whichUnit, unittype whichUnitType returns boolean
		public static bool IsUnit(int whichUnit, int whichSpecifiedUnit) { return false; }//constant native IsUnit              takes unit whichUnit, unit whichSpecifiedUnit returns boolean
		public static bool IsUnitInRange(int whichUnit, int otherUnit, real distance) { return false; }//constant native IsUnitInRange       takes unit whichUnit, unit otherUnit, real distance returns boolean
		public static bool IsUnitInRangeXY(int whichUnit, real x, real y, real distance) { return false; }//constant native IsUnitInRangeXY     takes unit whichUnit, real x, real y, real distance returns boolean
		public static bool IsUnitInRangeLoc(int whichUnit, location whichLocation, real distance) { return false; }//constant native IsUnitInRangeLoc    takes unit whichUnit, location whichLocation, real distance returns boolean
		public static bool IsUnitHidden() { return false; }//constant native IsUnitHidden        takes unit whichUnit returns boolean
		public static bool IsUnitIllusion() { return false; }//constant native IsUnitIllusion      takes unit whichUnit returns boolean
		public static bool IsUnitInTransport(int whichUnit, int whichTransport) { return false; }//constant native IsUnitInTransport   takes unit whichUnit, unit whichTransport returns boolean
		public static bool IsUnitLoaded() { return false; }//constant native IsUnitLoaded        takes unit whichUnit returns boolean
		public static bool IsHeroUnitId() { return false; }//constant native IsHeroUnitId        takes integer unitId returns boolean
		public static bool IsUnitIdType(int unitId, unittype whichUnitType) { return false; }//constant native IsUnitIdType        takes integer unitId, unittype whichUnitType returns boolean
		public static void UnitShareVision(int whichUnit, player whichPlayer, bool share) {  }//native UnitShareVision              takes unit whichUnit, player whichPlayer, boolean share returns nothing
		public static void UnitSuspendDecay(int whichUnit, bool suspend) {  }//native UnitSuspendDecay             takes unit whichUnit, boolean suspend returns nothing
		public static bool UnitAddType(int whichUnit, unittype whichUnitType) { return false; }//native UnitAddType                  takes unit whichUnit, unittype whichUnitType returns boolean
		public static bool UnitRemoveType(int whichUnit, unittype whichUnitType) { return false; }//native UnitRemoveType               takes unit whichUnit, unittype whichUnitType returns boolean
		public static bool UnitAddAbility(int whichUnit, int abilityId) { return false; }//native UnitAddAbility               takes unit whichUnit, integer abilityId returns boolean
		public static bool UnitRemoveAbility(int whichUnit, int abilityId) { return false; }//native UnitRemoveAbility            takes unit whichUnit, integer abilityId returns boolean
		public static bool UnitMakeAbilityPermanent(int whichUnit, bool permanent, int abilityId) { return false; }//native UnitMakeAbilityPermanent     takes unit whichUnit, boolean permanent, integer abilityId returns boolean
		public static void UnitRemoveBuffs(int whichUnit, bool removePositive, bool removeNegative) {  }//native UnitRemoveBuffs              takes unit whichUnit, boolean removePositive, boolean removeNegative returns nothing
		public static void UnitRemoveBuffsEx(int whichUnit, bool removePositive, bool removeNegative, bool magic, bool physical, bool timedLife, bool aura, bool autoDispel) {  }//native UnitRemoveBuffsEx            takes unit whichUnit, boolean removePositive, boolean removeNegative, boolean magic, boolean physical, boolean timedLife, boolean aura, boolean autoDispel returns nothing
		public static bool UnitHasBuffsEx(int whichUnit, bool removePositive, bool removeNegative, bool magic, bool physical, bool timedLife, bool aura, bool autoDispel) { return false; }//native UnitHasBuffsEx               takes unit whichUnit, boolean removePositive, boolean removeNegative, boolean magic, boolean physical, boolean timedLife, boolean aura, boolean autoDispel returns boolean
		public static int UnitCountBuffsEx(int whichUnit, bool removePositive, bool removeNegative, bool magic, bool physical, bool timedLife, bool aura, bool autoDispel) { return 0; }//native UnitCountBuffsEx             takes unit whichUnit, boolean removePositive, boolean removeNegative, boolean magic, boolean physical, boolean timedLife, boolean aura, boolean autoDispel returns integer
		public static void UnitAddSleep(int whichUnit, bool add) {  }//native UnitAddSleep                 takes unit whichUnit, boolean add returns nothing
		public static bool UnitCanSleep() { return false; }//native UnitCanSleep                 takes unit whichUnit returns boolean
		public static void UnitAddSleepPerm(int whichUnit, bool add) {  }//native UnitAddSleepPerm             takes unit whichUnit, boolean add returns nothing
		public static bool UnitCanSleepPerm() { return false; }//native UnitCanSleepPerm             takes unit whichUnit returns boolean
		public static bool UnitIsSleeping() { return false; }//native UnitIsSleeping               takes unit whichUnit returns boolean
		public static void UnitWakeUp() {  }//native UnitWakeUp                   takes unit whichUnit returns nothing
		public static void UnitApplyTimedLife(int whichUnit, int buffId, real duration) {  }//native UnitApplyTimedLife           takes unit whichUnit, integer buffId, real duration returns nothing
		public static bool UnitIgnoreAlarm(int whichUnit, bool flag) { return false; }//native UnitIgnoreAlarm              takes unit whichUnit, boolean flag returns boolean
		public static bool UnitIgnoreAlarmToggled() { return false; }//native UnitIgnoreAlarmToggled       takes unit whichUnit returns boolean
		public static void UnitResetCooldown() {  }//native UnitResetCooldown            takes unit whichUnit returns nothing
		public static void UnitSetConstructionProgress(int whichUnit, int constructionPercentage) {  }//native UnitSetConstructionProgress  takes unit whichUnit, integer constructionPercentage returns nothing
		public static void UnitSetUpgradeProgress(int whichUnit, int upgradePercentage) {  }//native UnitSetUpgradeProgress       takes unit whichUnit, integer upgradePercentage returns nothing
		public static void UnitPauseTimedLife(int whichUnit, bool flag) {  }//native UnitPauseTimedLife           takes unit whichUnit, boolean flag returns nothing
		public static void UnitSetUsesAltIcon(int whichUnit, bool flag) {  }//native UnitSetUsesAltIcon           takes unit whichUnit, boolean flag returns nothing
		public static bool UnitDamagePoint(int whichUnit, real delay, real radius, real x, real y, real amount, bool attack, bool ranged, attacktype attackType, damagetype damageType, weapontype weaponType) { return false; }//native UnitDamagePoint              takes unit whichUnit, real delay, real radius, real x, real y, real amount, boolean attack, boolean ranged, attacktype attackType, damagetype damageType, weapontype weaponType returns boolean
		public static bool UnitDamageTarget(int whichUnit, widget target, real amount, bool attack, bool ranged, attacktype attackType, damagetype damageType, weapontype weaponType) { return false; }//native UnitDamageTarget             takes unit whichUnit, widget target, real amount, boolean attack, boolean ranged, attacktype attackType, damagetype damageType, weapontype weaponType returns boolean
		public static bool IssueImmediateOrder(int whichUnit, string order) { return false; }//native IssueImmediateOrder          takes unit whichUnit, string order returns boolean
		public static bool IssueImmediateOrderById(int whichUnit, int order) { return false; }//native IssueImmediateOrderById      takes unit whichUnit, integer order returns boolean
		public static bool IssuePointOrder(int whichUnit, string order, real x, real y) { return false; }//native IssuePointOrder              takes unit whichUnit, string order, real x, real y returns boolean
		public static bool IssuePointOrderLoc(int whichUnit, string order, location whichLocation) { return false; }//native IssuePointOrderLoc           takes unit whichUnit, string order, location whichLocation returns boolean
		public static bool IssuePointOrderById(int whichUnit, int order, real x, real y) { return false; }//native IssuePointOrderById          takes unit whichUnit, integer order, real x, real y returns boolean
		public static bool IssuePointOrderByIdLoc(int whichUnit, int order, location whichLocation) { return false; }//native IssuePointOrderByIdLoc       takes unit whichUnit, integer order, location whichLocation returns boolean
		public static bool IssueTargetOrder(int whichUnit, string order, widget targetWidget) { return false; }//native IssueTargetOrder             takes unit whichUnit, string order, widget targetWidget returns boolean
		public static bool IssueTargetOrderById(int whichUnit, int order, widget targetWidget) { return false; }//native IssueTargetOrderById         takes unit whichUnit, integer order, widget targetWidget returns boolean
		public static bool IssueInstantPointOrder(int whichUnit, string order, real x, real y, widget instantTargetWidget) { return false; }//native IssueInstantPointOrder       takes unit whichUnit, string order, real x, real y, widget instantTargetWidget returns boolean
		public static bool IssueInstantPointOrderById(int whichUnit, int order, real x, real y, widget instantTargetWidget) { return false; }//native IssueInstantPointOrderById   takes unit whichUnit, integer order, real x, real y, widget instantTargetWidget returns boolean
		public static bool IssueInstantTargetOrder(int whichUnit, string order, widget targetWidget, widget instantTargetWidget) { return false; }//native IssueInstantTargetOrder      takes unit whichUnit, string order, widget targetWidget, widget instantTargetWidget returns boolean
		public static bool IssueInstantTargetOrderById(int whichUnit, int order, widget targetWidget, widget instantTargetWidget) { return false; }//native IssueInstantTargetOrderById  takes unit whichUnit, integer order, widget targetWidget, widget instantTargetWidget returns boolean
		public static bool IssueBuildOrder(int whichPeon, string unitToBuild, real x, real y) { return false; }//native IssueBuildOrder              takes unit whichPeon, string unitToBuild, real x, real y returns boolean
		public static bool IssueBuildOrderById(int whichPeon, int unitId, real x, real y) { return false; }//native IssueBuildOrderById          takes unit whichPeon, integer unitId, real x, real y returns boolean
		public static bool IssueNeutralImmediateOrder(player forWhichPlayer, int neutralStructure, string unitToBuild) { return false; }//native IssueNeutralImmediateOrder       takes player forWhichPlayer, unit neutralStructure, string unitToBuild returns boolean
		public static bool IssueNeutralImmediateOrderById(player forWhichPlayer, int neutralStructure, int unitId) { return false; }//native IssueNeutralImmediateOrderById   takes player forWhichPlayer,unit neutralStructure, integer unitId returns boolean
		public static bool IssueNeutralPointOrder(player forWhichPlayer, int neutralStructure, string unitToBuild, real x, real y) { return false; }//native IssueNeutralPointOrder           takes player forWhichPlayer,unit neutralStructure, string unitToBuild, real x, real y returns boolean
		public static bool IssueNeutralPointOrderById(player forWhichPlayer, int neutralStructure, int unitId, real x, real y) { return false; }//native IssueNeutralPointOrderById       takes player forWhichPlayer,unit neutralStructure, integer unitId, real x, real y returns boolean
		public static bool IssueNeutralTargetOrder(player forWhichPlayer, int neutralStructure, string unitToBuild, widget target) { return false; }//native IssueNeutralTargetOrder          takes player forWhichPlayer,unit neutralStructure, string unitToBuild, widget target returns boolean
		public static bool IssueNeutralTargetOrderById(player forWhichPlayer, int neutralStructure, int unitId, widget target) { return false; }//native IssueNeutralTargetOrderById      takes player forWhichPlayer,unit neutralStructure, integer unitId, widget target returns boolean
		public static int GetUnitCurrentOrder() { return 0; }//native GetUnitCurrentOrder          takes unit whichUnit returns integer
		public static void SetResourceAmount(int whichUnit, int amount) {  }//native SetResourceAmount            takes unit whichUnit, integer amount returns nothing
		public static void AddResourceAmount(int whichUnit, int amount) {  }//native AddResourceAmount            takes unit whichUnit, integer amount returns nothing
		public static int GetResourceAmount() { return 0; }//native GetResourceAmount            takes unit whichUnit returns integer
		public static real WaygateGetDestinationX() { return ; }//native WaygateGetDestinationX       takes unit waygate returns real
		public static real WaygateGetDestinationY() { return ; }//native WaygateGetDestinationY       takes unit waygate returns real
		public static void WaygateSetDestination(int waygate, real x, real y) {  }//native WaygateSetDestination        takes unit waygate, real x, real y returns nothing
		public static void WaygateActivate(int waygate, bool activate) {  }//native WaygateActivate              takes unit waygate, boolean activate returns nothing
		public static bool WaygateIsActive() { return false; }//native WaygateIsActive              takes unit waygate returns boolean
		public static void AddItemToAllStock(int itemId, int currentStock, int stockMax) {  }//native AddItemToAllStock            takes integer itemId, integer currentStock, integer stockMax returns nothing
		public static void AddItemToStock(int whichUnit, int itemId, int currentStock, int stockMax) {  }//native AddItemToStock               takes unit whichUnit, integer itemId, integer currentStock, integer stockMax returns nothing
		public static void AddUnitToAllStock(int unitId, int currentStock, int stockMax) {  }//native AddUnitToAllStock            takes integer unitId, integer currentStock, integer stockMax returns nothing
		public static void AddUnitToStock(int whichUnit, int unitId, int currentStock, int stockMax) {  }//native AddUnitToStock               takes unit whichUnit, integer unitId, integer currentStock, integer stockMax returns nothing
		public static void RemoveItemFromAllStock() {  }//native RemoveItemFromAllStock       takes integer itemId returns nothing
		public static void RemoveItemFromStock(int whichUnit, int itemId) {  }//native RemoveItemFromStock          takes unit whichUnit, integer itemId returns nothing
		public static void RemoveUnitFromAllStock() {  }//native RemoveUnitFromAllStock       takes integer unitId returns nothing
		public static void RemoveUnitFromStock(int whichUnit, int unitId) {  }//native RemoveUnitFromStock          takes unit whichUnit, integer unitId returns nothing
		public static void SetAllItemTypeSlots() {  }//native SetAllItemTypeSlots          takes integer slots returns nothing
		public static void SetAllUnitTypeSlots() {  }//native SetAllUnitTypeSlots          takes integer slots returns nothing
		public static void SetItemTypeSlots(int whichUnit, int slots) {  }//native SetItemTypeSlots             takes unit whichUnit, integer slots returns nothing
		public static void SetUnitTypeSlots(int whichUnit, int slots) {  }//native SetUnitTypeSlots             takes unit whichUnit, integer slots returns nothing
		public static int GetUnitUserData() { return 0; }//native GetUnitUserData              takes unit whichUnit returns integer
		public static void SetUnitUserData(int whichUnit, int data) {  }//native SetUnitUserData              takes unit whichUnit, integer data returns nothing
		public static player Player() { return ; }//constant native Player              takes integer number returns player
		public static player GetLocalPlayer() { return ; }//constant native GetLocalPlayer      takes nothing returns player
		public static bool IsPlayerAlly(player whichPlayer, player otherPlayer) { return false; }//constant native IsPlayerAlly        takes player whichPlayer, player otherPlayer returns boolean
		public static bool IsPlayerEnemy(player whichPlayer, player otherPlayer) { return false; }//constant native IsPlayerEnemy       takes player whichPlayer, player otherPlayer returns boolean
		public static bool IsPlayerInForce(player whichPlayer, force whichForce) { return false; }//constant native IsPlayerInForce     takes player whichPlayer, force whichForce returns boolean
		public static bool IsPlayerObserver() { return false; }//constant native IsPlayerObserver    takes player whichPlayer returns boolean
		public static bool IsVisibleToPlayer(real x, real y, player whichPlayer) { return false; }//constant native IsVisibleToPlayer           takes real x, real y, player whichPlayer returns boolean
		public static bool IsLocationVisibleToPlayer(location whichLocation, player whichPlayer) { return false; }//constant native IsLocationVisibleToPlayer   takes location whichLocation, player whichPlayer returns boolean
		public static bool IsFoggedToPlayer(real x, real y, player whichPlayer) { return false; }//constant native IsFoggedToPlayer            takes real x, real y, player whichPlayer returns boolean
		public static bool IsLocationFoggedToPlayer(location whichLocation, player whichPlayer) { return false; }//constant native IsLocationFoggedToPlayer    takes location whichLocation, player whichPlayer returns boolean
		public static bool IsMaskedToPlayer(real x, real y, player whichPlayer) { return false; }//constant native IsMaskedToPlayer            takes real x, real y, player whichPlayer returns boolean
		public static bool IsLocationMaskedToPlayer(location whichLocation, player whichPlayer) { return false; }//constant native IsLocationMaskedToPlayer    takes location whichLocation, player whichPlayer returns boolean
		public static race GetPlayerRace() { return ; }//constant native GetPlayerRace           takes player whichPlayer returns race
		public static int GetPlayerId() { return 0; }//constant native GetPlayerId             takes player whichPlayer returns integer
		public static int GetPlayerUnitCount(player whichPlayer, bool includeIncomplete) { return 0; }//constant native GetPlayerUnitCount      takes player whichPlayer, boolean includeIncomplete returns integer
		public static int GetPlayerTypedUnitCount(player whichPlayer, string unitName, bool includeIncomplete, bool includeUpgrades) { return 0; }//constant native GetPlayerTypedUnitCount takes player whichPlayer, string unitName, boolean includeIncomplete, boolean includeUpgrades returns integer
		public static int GetPlayerStructureCount(player whichPlayer, bool includeIncomplete) { return 0; }//constant native GetPlayerStructureCount takes player whichPlayer, boolean includeIncomplete returns integer
		public static int GetPlayerState(player whichPlayer, playerstate whichPlayerState) { return 0; }//constant native GetPlayerState          takes player whichPlayer, playerstate whichPlayerState returns integer
		public static int GetPlayerScore(player whichPlayer, playerscore whichPlayerScore) { return 0; }//constant native GetPlayerScore          takes player whichPlayer, playerscore whichPlayerScore returns integer
		public static bool GetPlayerAlliance(player sourcePlayer, player otherPlayer, alliancetype whichAllianceSetting) { return false; }//constant native GetPlayerAlliance       takes player sourcePlayer, player otherPlayer, alliancetype whichAllianceSetting returns boolean
		public static real GetPlayerHandicap() { return ; }//constant native GetPlayerHandicap       takes player whichPlayer returns real
		public static real GetPlayerHandicapXP() { return ; }//constant native GetPlayerHandicapXP     takes player whichPlayer returns real
		public static void SetPlayerHandicap(player whichPlayer, real handicap) {  }//constant native SetPlayerHandicap       takes player whichPlayer, real handicap returns nothing
		public static void SetPlayerHandicapXP(player whichPlayer, real handicap) {  }//constant native SetPlayerHandicapXP     takes player whichPlayer, real handicap returns nothing
		public static void SetPlayerTechMaxAllowed(player whichPlayer, int techid, int maximum) {  }//constant native SetPlayerTechMaxAllowed takes player whichPlayer, integer techid, integer maximum returns nothing
		public static int GetPlayerTechMaxAllowed(player whichPlayer, int techid) { return 0; }//constant native GetPlayerTechMaxAllowed takes player whichPlayer, integer techid returns integer
		public static void AddPlayerTechResearched(player whichPlayer, int techid, int levels) {  }//constant native AddPlayerTechResearched takes player whichPlayer, integer techid, integer levels returns nothing
		public static void SetPlayerTechResearched(player whichPlayer, int techid, int setToLevel) {  }//constant native SetPlayerTechResearched takes player whichPlayer, integer techid, integer setToLevel returns nothing
		public static bool GetPlayerTechResearched(player whichPlayer, int techid, bool specificonly) { return false; }//constant native GetPlayerTechResearched takes player whichPlayer, integer techid, boolean specificonly returns boolean
		public static int GetPlayerTechCount(player whichPlayer, int techid, bool specificonly) { return 0; }//constant native GetPlayerTechCount      takes player whichPlayer, integer techid, boolean specificonly returns integer
		public static void SetPlayerUnitsOwner(player whichPlayer, int newOwner) {  }//native SetPlayerUnitsOwner takes player whichPlayer, integer newOwner returns nothing
		public static void CripplePlayer(player whichPlayer, force toWhichPlayers, bool flag) {  }//native CripplePlayer takes player whichPlayer, force toWhichPlayers, boolean flag returns nothing
		public static void SetPlayerAbilityAvailable(player whichPlayer, int abilid, bool avail) {  }//native SetPlayerAbilityAvailable        takes player whichPlayer, integer abilid, boolean avail returns nothing
		public static void SetPlayerState(player whichPlayer, playerstate whichPlayerState, int value) {  }//native SetPlayerState   takes player whichPlayer, playerstate whichPlayerState, integer value returns nothing
		public static void RemovePlayer(player whichPlayer, playergameresult gameResult) {  }//native RemovePlayer     takes player whichPlayer, playergameresult gameResult returns nothing
		public static void CachePlayerHeroData() {  }//native CachePlayerHeroData takes player whichPlayer returns nothing
		public static void SetFogStateRect(player forWhichPlayer, fogstate whichState, rect where, bool useSharedVision) {  }//native  SetFogStateRect      takes player forWhichPlayer, fogstate whichState, rect where, boolean useSharedVision returns nothing
		public static void SetFogStateRadius(player forWhichPlayer, fogstate whichState, real centerx, real centerY, real radius, bool useSharedVision) {  }//native  SetFogStateRadius    takes player forWhichPlayer, fogstate whichState, real centerx, real centerY, real radius, boolean useSharedVision returns nothing
		public static void SetFogStateRadiusLoc(player forWhichPlayer, fogstate whichState, location center, real radius, bool useSharedVision) {  }//native  SetFogStateRadiusLoc takes player forWhichPlayer, fogstate whichState, location center, real radius, boolean useSharedVision returns nothing
		public static void FogMaskEnable() {  }//native  FogMaskEnable        takes boolean enable returns nothing
		public static bool IsFogMaskEnabled() { return false; }//native  IsFogMaskEnabled     takes nothing returns boolean
		public static void FogEnable() {  }//native  FogEnable            takes boolean enable returns nothing
		public static bool IsFogEnabled() { return false; }//native  IsFogEnabled         takes nothing returns boolean
		public static fogmodifier CreateFogModifierRect(player forWhichPlayer, fogstate whichState, rect where, bool useSharedVision, bool afterUnits) { return ; }//native CreateFogModifierRect        takes player forWhichPlayer, fogstate whichState, rect where, boolean useSharedVision, boolean afterUnits returns fogmodifier
		public static fogmodifier CreateFogModifierRadius(player forWhichPlayer, fogstate whichState, real centerx, real centerY, real radius, bool useSharedVision, bool afterUnits) { return ; }//native CreateFogModifierRadius      takes player forWhichPlayer, fogstate whichState, real centerx, real centerY, real radius, boolean useSharedVision, boolean afterUnits returns fogmodifier
		public static fogmodifier CreateFogModifierRadiusLoc(player forWhichPlayer, fogstate whichState, location center, real radius, bool useSharedVision, bool afterUnits) { return ; }//native CreateFogModifierRadiusLoc   takes player forWhichPlayer, fogstate whichState, location center, real radius, boolean useSharedVision, boolean afterUnits returns fogmodifier
		public static void DestroyFogModifier() {  }//native DestroyFogModifier           takes fogmodifier whichFogModifier returns nothing
		public static void FogModifierStart() {  }//native FogModifierStart             takes fogmodifier whichFogModifier returns nothing
		public static void FogModifierStop() {  }//native FogModifierStop              takes fogmodifier whichFogModifier returns nothing
		public static version VersionGet() { return ; }//native VersionGet takes nothing returns version
		public static bool VersionCompatible() { return false; }//native VersionCompatible takes version whichVersion returns boolean
		public static bool VersionSupported() { return false; }//native VersionSupported takes version whichVersion returns boolean
		public static void EndGame() {  }//native EndGame takes boolean doScoreScreen returns nothing
		public static void ChangeLevel(string newLevel, bool doScoreScreen) {  }//native          ChangeLevel         takes string newLevel, boolean doScoreScreen returns nothing
		public static void RestartGame() {  }//native          RestartGame         takes boolean doScoreScreen returns nothing
		public static void ReloadGame() {  }//native          ReloadGame          takes nothing returns nothing
		public static void SetCampaignMenuRace() {  }//native          SetCampaignMenuRace takes race r returns nothing
		public static void SetCampaignMenuRaceEx() {  }//native          SetCampaignMenuRaceEx takes integer campaignIndex returns nothing
		public static void ForceCampaignSelectScreen() {  }//native          ForceCampaignSelectScreen takes nothing returns nothing
		public static void LoadGame(string saveFileName, bool doScoreScreen) {  }//native          LoadGame            takes string saveFileName, boolean doScoreScreen returns nothing
		public static void SaveGame() {  }//native          SaveGame            takes string saveFileName returns nothing
		public static bool RenameSaveDirectory(string sourceDirName, string destDirName) { return false; }//native          RenameSaveDirectory takes string sourceDirName, string destDirName returns boolean
		public static bool RemoveSaveDirectory() { return false; }//native          RemoveSaveDirectory takes string sourceDirName returns boolean
		public static bool CopySaveGame(string sourceSaveName, string destSaveName) { return false; }//native          CopySaveGame        takes string sourceSaveName, string destSaveName returns boolean
		public static bool SaveGameExists() { return false; }//native          SaveGameExists      takes string saveName returns boolean
		public static void SyncSelections() {  }//native          SyncSelections      takes nothing returns nothing
		public static void SetFloatGameState(fgamestate whichFloatGameState, real value) {  }//native          SetFloatGameState   takes fgamestate whichFloatGameState, real value returns nothing
		public static real GetFloatGameState() { return ; }//constant native GetFloatGameState   takes fgamestate whichFloatGameState returns real
		public static void SetIntegerGameState(igamestate whichIntegerGameState, int value) {  }//native          SetIntegerGameState takes igamestate whichIntegerGameState, integer value returns nothing
		public static int GetIntegerGameState() { return 0; }//constant native GetIntegerGameState takes igamestate whichIntegerGameState returns integer
		public static void SetTutorialCleared() {  }//native  SetTutorialCleared      takes boolean cleared returns nothing
		public static void SetMissionAvailable(int campaignNumber, int missionNumber, bool available) {  }//native  SetMissionAvailable     takes integer campaignNumber, integer missionNumber, boolean available returns nothing
		public static void SetCampaignAvailable(int campaignNumber, bool available) {  }//native  SetCampaignAvailable    takes integer campaignNumber, boolean available  returns nothing
		public static void SetOpCinematicAvailable(int campaignNumber, bool available) {  }//native  SetOpCinematicAvailable takes integer campaignNumber, boolean available  returns nothing
		public static void SetEdCinematicAvailable(int campaignNumber, bool available) {  }//native  SetEdCinematicAvailable takes integer campaignNumber, boolean available  returns nothing
		public static gamedifficulty GetDefaultDifficulty() { return ; }//native  GetDefaultDifficulty    takes nothing returns gamedifficulty
		public static void SetDefaultDifficulty() {  }//native  SetDefaultDifficulty    takes gamedifficulty g returns nothing
		public static void SetCustomCampaignButtonVisible(int whichButton, bool visible) {  }//native  SetCustomCampaignButtonVisible  takes integer whichButton, boolean visible returns nothing
		public static bool GetCustomCampaignButtonVisible() { return false; }//native  GetCustomCampaignButtonVisible  takes integer whichButton returns boolean
		public static void DoNotSaveReplay() {  }//native  DoNotSaveReplay         takes nothing returns nothing
		public static dialog DialogCreate() { return ; }//native DialogCreate                 takes nothing returns dialog
		public static void DialogDestroy() {  }//native DialogDestroy                takes dialog whichDialog returns nothing
		public static void DialogClear() {  }//native DialogClear                  takes dialog whichDialog returns nothing
		public static void DialogSetMessage(dialog whichDialog, string messageText) {  }//native DialogSetMessage             takes dialog whichDialog, string messageText returns nothing
		public static button DialogAddButton(dialog whichDialog, string buttonText, int hotkey) { return ; }//native DialogAddButton              takes dialog whichDialog, string buttonText, integer hotkey returns button
		public static button DialogAddQuitButton(dialog whichDialog, bool doScoreScreen, string buttonText, int hotkey) { return ; }//native DialogAddQuitButton          takes dialog whichDialog, boolean doScoreScreen, string buttonText, integer hotkey returns button
		public static void DialogDisplay(player whichPlayer, dialog whichDialog, bool flag) {  }//native DialogDisplay                takes player whichPlayer, dialog whichDialog, boolean flag returns nothing
		public static bool ReloadGameCachesFromDisk() { return false; }//native  ReloadGameCachesFromDisk takes nothing returns boolean
		public static gamecache InitGameCache() { return ; }//native  InitGameCache    takes string campaignFile returns gamecache
		public static bool SaveGameCache() { return false; }//native  SaveGameCache    takes gamecache whichCache returns boolean
		public static void StoreInteger(gamecache cache, string missionKey, string key, int value) {  }//native  StoreInteger					takes gamecache cache, string missionKey, string key, integer value returns nothing
		public static void StoreReal(gamecache cache, string missionKey, string key, real value) {  }//native  StoreReal						takes gamecache cache, string missionKey, string key, real value returns nothing
		public static void StoreBoolean(gamecache cache, string missionKey, string key, bool value) {  }//native  StoreBoolean					takes gamecache cache, string missionKey, string key, boolean value returns nothing
		public static bool StoreUnit(gamecache cache, string missionKey, string key, int whichUnit) { return false; }//native  StoreUnit						takes gamecache cache, string missionKey, string key, unit whichUnit returns boolean
		public static bool StoreString(gamecache cache, string missionKey, string key, string value) { return false; }//native  StoreString						takes gamecache cache, string missionKey, string key, string value returns boolean
		public static void SyncStoredInteger(gamecache cache, string missionKey, string key) {  }//native SyncStoredInteger        takes gamecache cache, string missionKey, string key returns nothing
		public static void SyncStoredReal(gamecache cache, string missionKey, string key) {  }//native SyncStoredReal           takes gamecache cache, string missionKey, string key returns nothing
		public static void SyncStoredBoolean(gamecache cache, string missionKey, string key) {  }//native SyncStoredBoolean        takes gamecache cache, string missionKey, string key returns nothing
		public static void SyncStoredUnit(gamecache cache, string missionKey, string key) {  }//native SyncStoredUnit           takes gamecache cache, string missionKey, string key returns nothing
		public static void SyncStoredString(gamecache cache, string missionKey, string key) {  }//native SyncStoredString         takes gamecache cache, string missionKey, string key returns nothing
		public static bool HaveStoredInteger(gamecache cache, string missionKey, string key) { return false; }//native  HaveStoredInteger					takes gamecache cache, string missionKey, string key returns boolean
		public static bool HaveStoredReal(gamecache cache, string missionKey, string key) { return false; }//native  HaveStoredReal						takes gamecache cache, string missionKey, string key returns boolean
		public static bool HaveStoredBoolean(gamecache cache, string missionKey, string key) { return false; }//native  HaveStoredBoolean					takes gamecache cache, string missionKey, string key returns boolean
		public static bool HaveStoredUnit(gamecache cache, string missionKey, string key) { return false; }//native  HaveStoredUnit						takes gamecache cache, string missionKey, string key returns boolean
		public static bool HaveStoredString(gamecache cache, string missionKey, string key) { return false; }//native  HaveStoredString					takes gamecache cache, string missionKey, string key returns boolean
		public static void FlushGameCache() {  }//native  FlushGameCache						takes gamecache cache returns nothing
		public static void FlushStoredMission(gamecache cache, string missionKey) {  }//native  FlushStoredMission					takes gamecache cache, string missionKey returns nothing
		public static void FlushStoredInteger(gamecache cache, string missionKey, string key) {  }//native  FlushStoredInteger					takes gamecache cache, string missionKey, string key returns nothing
		public static void FlushStoredReal(gamecache cache, string missionKey, string key) {  }//native  FlushStoredReal						takes gamecache cache, string missionKey, string key returns nothing
		public static void FlushStoredBoolean(gamecache cache, string missionKey, string key) {  }//native  FlushStoredBoolean					takes gamecache cache, string missionKey, string key returns nothing
		public static void FlushStoredUnit(gamecache cache, string missionKey, string key) {  }//native  FlushStoredUnit						takes gamecache cache, string missionKey, string key returns nothing
		public static void FlushStoredString(gamecache cache, string missionKey, string key) {  }//native  FlushStoredString					takes gamecache cache, string missionKey, string key returns nothing
		public static int GetStoredInteger(gamecache cache, string missionKey, string key) { return 0; }//native  GetStoredInteger				takes gamecache cache, string missionKey, string key returns integer
		public static real GetStoredReal(gamecache cache, string missionKey, string key) { return ; }//native  GetStoredReal					takes gamecache cache, string missionKey, string key returns real
		public static bool GetStoredBoolean(gamecache cache, string missionKey, string key) { return false; }//native  GetStoredBoolean				takes gamecache cache, string missionKey, string key returns boolean
		public static string GetStoredString(gamecache cache, string missionKey, string key) { return ; }//native  GetStoredString					takes gamecache cache, string missionKey, string key returns string
		public static int RestoreUnit(gamecache cache, string missionKey, string key, player forWhichPlayer, real x, real y, real facing) { return 0; }//native  RestoreUnit						takes gamecache cache, string missionKey, string key, player forWhichPlayer, real x, real y, real facing returns unit
		public static hashtable InitHashtable() { return ; }//native  InitHashtable    takes nothing returns hashtable
		public static void SaveInteger(hashtable table, int parentKey, int childKey, int value) {  }//native  SaveInteger						takes hashtable table, integer parentKey, integer childKey, integer value returns nothing
		public static void SaveReal(hashtable table, int parentKey, int childKey, real value) {  }//native  SaveReal						takes hashtable table, integer parentKey, integer childKey, real value returns nothing
		public static void SaveBoolean(hashtable table, int parentKey, int childKey, bool value) {  }//native  SaveBoolean						takes hashtable table, integer parentKey, integer childKey, boolean value returns nothing
		public static bool SaveStr(hashtable table, int parentKey, int childKey, string value) { return false; }//native  SaveStr							takes hashtable table, integer parentKey, integer childKey, string value returns boolean
		public static bool SavePlayerHandle(hashtable table, int parentKey, int childKey, player whichPlayer) { return false; }//native  SavePlayerHandle				takes hashtable table, integer parentKey, integer childKey, player whichPlayer returns boolean
		public static bool SaveWidgetHandle(hashtable table, int parentKey, int childKey, widget whichWidget) { return false; }//native  SaveWidgetHandle				takes hashtable table, integer parentKey, integer childKey, widget whichWidget returns boolean
		public static bool SaveDestructableHandle(hashtable table, int parentKey, int childKey, destructable whichDestructable) { return false; }//native  SaveDestructableHandle			takes hashtable table, integer parentKey, integer childKey, destructable whichDestructable returns boolean
		public static bool SaveItemHandle(hashtable table, int parentKey, int childKey, item whichItem) { return false; }//native  SaveItemHandle					takes hashtable table, integer parentKey, integer childKey, item whichItem returns boolean
		public static bool SaveUnitHandle(hashtable table, int parentKey, int childKey, int whichUnit) { return false; }//native  SaveUnitHandle					takes hashtable table, integer parentKey, integer childKey, unit whichUnit returns boolean
		public static bool SaveAbilityHandle(hashtable table, int parentKey, int childKey, ability whichAbility) { return false; }//native  SaveAbilityHandle				takes hashtable table, integer parentKey, integer childKey, ability whichAbility returns boolean
		public static bool SaveTimerHandle(hashtable table, int parentKey, int childKey, timer whichTimer) { return false; }//native  SaveTimerHandle					takes hashtable table, integer parentKey, integer childKey, timer whichTimer returns boolean
		public static bool SaveTriggerHandle(hashtable table, int parentKey, int childKey, trigger whichTrigger) { return false; }//native  SaveTriggerHandle				takes hashtable table, integer parentKey, integer childKey, trigger whichTrigger returns boolean
		public static bool SaveTriggerConditionHandle(hashtable table, int parentKey, int childKey, triggercondition whichTriggercondition) { return false; }//native  SaveTriggerConditionHandle		takes hashtable table, integer parentKey, integer childKey, triggercondition whichTriggercondition returns boolean
		public static bool SaveTriggerActionHandle(hashtable table, int parentKey, int childKey, triggeraction whichTriggeraction) { return false; }//native  SaveTriggerActionHandle			takes hashtable table, integer parentKey, integer childKey, triggeraction whichTriggeraction returns boolean
		public static bool SaveTriggerEventHandle(hashtable table, int parentKey, int childKey, event whichEvent) { return false; }//native  SaveTriggerEventHandle			takes hashtable table, integer parentKey, integer childKey, event whichEvent returns boolean
		public static bool SaveForceHandle(hashtable table, int parentKey, int childKey, force whichForce) { return false; }//native  SaveForceHandle					takes hashtable table, integer parentKey, integer childKey, force whichForce returns boolean
		public static bool SaveGroupHandle(hashtable table, int parentKey, int childKey, group whichGroup) { return false; }//native  SaveGroupHandle					takes hashtable table, integer parentKey, integer childKey, group whichGroup returns boolean
		public static bool SaveLocationHandle(hashtable table, int parentKey, int childKey, location whichLocation) { return false; }//native  SaveLocationHandle				takes hashtable table, integer parentKey, integer childKey, location whichLocation returns boolean
		public static bool SaveRectHandle(hashtable table, int parentKey, int childKey, rect whichRect) { return false; }//native  SaveRectHandle					takes hashtable table, integer parentKey, integer childKey, rect whichRect returns boolean
		public static bool SaveBooleanExprHandle(hashtable table, int parentKey, int childKey, boolexpr whichBoolexpr) { return false; }//native  SaveBooleanExprHandle			takes hashtable table, integer parentKey, integer childKey, boolexpr whichBoolexpr returns boolean
		public static bool SaveSoundHandle(hashtable table, int parentKey, int childKey, sound whichSound) { return false; }//native  SaveSoundHandle					takes hashtable table, integer parentKey, integer childKey, sound whichSound returns boolean
		public static bool SaveEffectHandle(hashtable table, int parentKey, int childKey, effect whichEffect) { return false; }//native  SaveEffectHandle				takes hashtable table, integer parentKey, integer childKey, effect whichEffect returns boolean
		public static bool SaveUnitPoolHandle(hashtable table, int parentKey, int childKey, unitpool whichUnitpool) { return false; }//native  SaveUnitPoolHandle				takes hashtable table, integer parentKey, integer childKey, unitpool whichUnitpool returns boolean
		public static bool SaveItemPoolHandle(hashtable table, int parentKey, int childKey, itempool whichItempool) { return false; }//native  SaveItemPoolHandle				takes hashtable table, integer parentKey, integer childKey, itempool whichItempool returns boolean
		public static bool SaveQuestHandle(hashtable table, int parentKey, int childKey, quest whichQuest) { return false; }//native  SaveQuestHandle					takes hashtable table, integer parentKey, integer childKey, quest whichQuest returns boolean
		public static bool SaveQuestItemHandle(hashtable table, int parentKey, int childKey, questitem whichQuestitem) { return false; }//native  SaveQuestItemHandle				takes hashtable table, integer parentKey, integer childKey, questitem whichQuestitem returns boolean
		public static bool SaveDefeatConditionHandle(hashtable table, int parentKey, int childKey, defeatcondition whichDefeatcondition) { return false; }//native  SaveDefeatConditionHandle		takes hashtable table, integer parentKey, integer childKey, defeatcondition whichDefeatcondition returns boolean
		public static bool SaveTimerDialogHandle(hashtable table, int parentKey, int childKey, timerdialog whichTimerdialog) { return false; }//native  SaveTimerDialogHandle			takes hashtable table, integer parentKey, integer childKey, timerdialog whichTimerdialog returns boolean
		public static bool SaveLeaderboardHandle(hashtable table, int parentKey, int childKey, leaderboard whichLeaderboard) { return false; }//native  SaveLeaderboardHandle			takes hashtable table, integer parentKey, integer childKey, leaderboard whichLeaderboard returns boolean
		public static bool SaveMultiboardHandle(hashtable table, int parentKey, int childKey, multiboard whichMultiboard) { return false; }//native  SaveMultiboardHandle			takes hashtable table, integer parentKey, integer childKey, multiboard whichMultiboard returns boolean
		public static bool SaveMultiboardItemHandle(hashtable table, int parentKey, int childKey, multiboarditem whichMultiboarditem) { return false; }//native  SaveMultiboardItemHandle		takes hashtable table, integer parentKey, integer childKey, multiboarditem whichMultiboarditem returns boolean
		public static bool SaveTrackableHandle(hashtable table, int parentKey, int childKey, trackable whichTrackable) { return false; }//native  SaveTrackableHandle				takes hashtable table, integer parentKey, integer childKey, trackable whichTrackable returns boolean
		public static bool SaveDialogHandle(hashtable table, int parentKey, int childKey, dialog whichDialog) { return false; }//native  SaveDialogHandle				takes hashtable table, integer parentKey, integer childKey, dialog whichDialog returns boolean
		public static bool SaveButtonHandle(hashtable table, int parentKey, int childKey, button whichButton) { return false; }//native  SaveButtonHandle				takes hashtable table, integer parentKey, integer childKey, button whichButton returns boolean
		public static bool SaveTextTagHandle(hashtable table, int parentKey, int childKey, texttag whichTexttag) { return false; }//native  SaveTextTagHandle				takes hashtable table, integer parentKey, integer childKey, texttag whichTexttag returns boolean
		public static bool SaveLightningHandle(hashtable table, int parentKey, int childKey, lightning whichLightning) { return false; }//native  SaveLightningHandle				takes hashtable table, integer parentKey, integer childKey, lightning whichLightning returns boolean
		public static bool SaveImageHandle(hashtable table, int parentKey, int childKey, image whichImage) { return false; }//native  SaveImageHandle					takes hashtable table, integer parentKey, integer childKey, image whichImage returns boolean
		public static bool SaveUbersplatHandle(hashtable table, int parentKey, int childKey, ubersplat whichUbersplat) { return false; }//native  SaveUbersplatHandle				takes hashtable table, integer parentKey, integer childKey, ubersplat whichUbersplat returns boolean
		public static bool SaveRegionHandle(hashtable table, int parentKey, int childKey, region whichRegion) { return false; }//native  SaveRegionHandle				takes hashtable table, integer parentKey, integer childKey, region whichRegion returns boolean
		public static bool SaveFogStateHandle(hashtable table, int parentKey, int childKey, fogstate whichFogState) { return false; }//native  SaveFogStateHandle				takes hashtable table, integer parentKey, integer childKey, fogstate whichFogState returns boolean
		public static bool SaveFogModifierHandle(hashtable table, int parentKey, int childKey, fogmodifier whichFogModifier) { return false; }//native  SaveFogModifierHandle			takes hashtable table, integer parentKey, integer childKey, fogmodifier whichFogModifier returns boolean
		public static bool SaveAgentHandle(hashtable table, int parentKey, int childKey, agent whichAgent) { return false; }//native  SaveAgentHandle					takes hashtable table, integer parentKey, integer childKey, agent whichAgent returns boolean
		public static bool SaveHashtableHandle(hashtable table, int parentKey, int childKey, hashtable whichHashtable) { return false; }//native  SaveHashtableHandle				takes hashtable table, integer parentKey, integer childKey, hashtable whichHashtable returns boolean
		public static int LoadInteger(hashtable table, int parentKey, int childKey) { return 0; }//native  LoadInteger					takes hashtable table, integer parentKey, integer childKey returns integer
		public static real LoadReal(hashtable table, int parentKey, int childKey) { return ; }//native  LoadReal					takes hashtable table, integer parentKey, integer childKey returns real
		public static bool LoadBoolean(hashtable table, int parentKey, int childKey) { return false; }//native  LoadBoolean				    takes hashtable table, integer parentKey, integer childKey returns boolean
		public static string LoadStr(hashtable table, int parentKey, int childKey) { return ; }//native  LoadStr 					takes hashtable table, integer parentKey, integer childKey returns string
		public static player LoadPlayerHandle(hashtable table, int parentKey, int childKey) { return ; }//native  LoadPlayerHandle			takes hashtable table, integer parentKey, integer childKey returns player
		public static widget LoadWidgetHandle(hashtable table, int parentKey, int childKey) { return ; }//native  LoadWidgetHandle			takes hashtable table, integer parentKey, integer childKey returns widget
		public static destructable LoadDestructableHandle(hashtable table, int parentKey, int childKey) { return ; }//native  LoadDestructableHandle		takes hashtable table, integer parentKey, integer childKey returns destructable
		public static item LoadItemHandle(hashtable table, int parentKey, int childKey) { return ; }//native  LoadItemHandle				takes hashtable table, integer parentKey, integer childKey returns item
		public static int LoadUnitHandle(hashtable table, int parentKey, int childKey) { return 0; }//native  LoadUnitHandle				takes hashtable table, integer parentKey, integer childKey returns unit
		public static ability LoadAbilityHandle(hashtable table, int parentKey, int childKey) { return ; }//native  LoadAbilityHandle			takes hashtable table, integer parentKey, integer childKey returns ability
		public static timer LoadTimerHandle(hashtable table, int parentKey, int childKey) { return ; }//native  LoadTimerHandle				takes hashtable table, integer parentKey, integer childKey returns timer
		public static trigger LoadTriggerHandle(hashtable table, int parentKey, int childKey) { return ; }//native  LoadTriggerHandle			takes hashtable table, integer parentKey, integer childKey returns trigger
		public static triggercondition LoadTriggerConditionHandle(hashtable table, int parentKey, int childKey) { return ; }//native  LoadTriggerConditionHandle	takes hashtable table, integer parentKey, integer childKey returns triggercondition
		public static triggeraction LoadTriggerActionHandle(hashtable table, int parentKey, int childKey) { return ; }//native  LoadTriggerActionHandle		takes hashtable table, integer parentKey, integer childKey returns triggeraction
		public static event LoadTriggerEventHandle(hashtable table, int parentKey, int childKey) { return ; }//native  LoadTriggerEventHandle		takes hashtable table, integer parentKey, integer childKey returns event
		public static force LoadForceHandle(hashtable table, int parentKey, int childKey) { return ; }//native  LoadForceHandle				takes hashtable table, integer parentKey, integer childKey returns force
		public static group LoadGroupHandle(hashtable table, int parentKey, int childKey) { return ; }//native  LoadGroupHandle				takes hashtable table, integer parentKey, integer childKey returns group
		public static location LoadLocationHandle(hashtable table, int parentKey, int childKey) { return ; }//native  LoadLocationHandle			takes hashtable table, integer parentKey, integer childKey returns location
		public static rect LoadRectHandle(hashtable table, int parentKey, int childKey) { return ; }//native  LoadRectHandle				takes hashtable table, integer parentKey, integer childKey returns rect
		public static boolexpr LoadBooleanExprHandle(hashtable table, int parentKey, int childKey) { return ; }//native  LoadBooleanExprHandle		takes hashtable table, integer parentKey, integer childKey returns boolexpr
		public static sound LoadSoundHandle(hashtable table, int parentKey, int childKey) { return ; }//native  LoadSoundHandle				takes hashtable table, integer parentKey, integer childKey returns sound
		public static effect LoadEffectHandle(hashtable table, int parentKey, int childKey) { return ; }//native  LoadEffectHandle			takes hashtable table, integer parentKey, integer childKey returns effect
		public static unitpool LoadUnitPoolHandle(hashtable table, int parentKey, int childKey) { return ; }//native  LoadUnitPoolHandle			takes hashtable table, integer parentKey, integer childKey returns unitpool
		public static itempool LoadItemPoolHandle(hashtable table, int parentKey, int childKey) { return ; }//native  LoadItemPoolHandle			takes hashtable table, integer parentKey, integer childKey returns itempool
		public static quest LoadQuestHandle(hashtable table, int parentKey, int childKey) { return ; }//native  LoadQuestHandle				takes hashtable table, integer parentKey, integer childKey returns quest
		public static questitem LoadQuestItemHandle(hashtable table, int parentKey, int childKey) { return ; }//native  LoadQuestItemHandle			takes hashtable table, integer parentKey, integer childKey returns questitem
		public static defeatcondition LoadDefeatConditionHandle(hashtable table, int parentKey, int childKey) { return ; }//native  LoadDefeatConditionHandle	takes hashtable table, integer parentKey, integer childKey returns defeatcondition
		public static timerdialog LoadTimerDialogHandle(hashtable table, int parentKey, int childKey) { return ; }//native  LoadTimerDialogHandle		takes hashtable table, integer parentKey, integer childKey returns timerdialog
		public static leaderboard LoadLeaderboardHandle(hashtable table, int parentKey, int childKey) { return ; }//native  LoadLeaderboardHandle		takes hashtable table, integer parentKey, integer childKey returns leaderboard
		public static multiboard LoadMultiboardHandle(hashtable table, int parentKey, int childKey) { return ; }//native  LoadMultiboardHandle		takes hashtable table, integer parentKey, integer childKey returns multiboard
		public static multiboarditem LoadMultiboardItemHandle(hashtable table, int parentKey, int childKey) { return ; }//native  LoadMultiboardItemHandle	takes hashtable table, integer parentKey, integer childKey returns multiboarditem
		public static trackable LoadTrackableHandle(hashtable table, int parentKey, int childKey) { return ; }//native  LoadTrackableHandle			takes hashtable table, integer parentKey, integer childKey returns trackable
		public static dialog LoadDialogHandle(hashtable table, int parentKey, int childKey) { return ; }//native  LoadDialogHandle			takes hashtable table, integer parentKey, integer childKey returns dialog
		public static button LoadButtonHandle(hashtable table, int parentKey, int childKey) { return ; }//native  LoadButtonHandle			takes hashtable table, integer parentKey, integer childKey returns button
		public static texttag LoadTextTagHandle(hashtable table, int parentKey, int childKey) { return ; }//native  LoadTextTagHandle			takes hashtable table, integer parentKey, integer childKey returns texttag
		public static lightning LoadLightningHandle(hashtable table, int parentKey, int childKey) { return ; }//native  LoadLightningHandle			takes hashtable table, integer parentKey, integer childKey returns lightning
		public static image LoadImageHandle(hashtable table, int parentKey, int childKey) { return ; }//native  LoadImageHandle				takes hashtable table, integer parentKey, integer childKey returns image
		public static ubersplat LoadUbersplatHandle(hashtable table, int parentKey, int childKey) { return ; }//native  LoadUbersplatHandle			takes hashtable table, integer parentKey, integer childKey returns ubersplat
		public static region LoadRegionHandle(hashtable table, int parentKey, int childKey) { return ; }//native  LoadRegionHandle			takes hashtable table, integer parentKey, integer childKey returns region
		public static fogstate LoadFogStateHandle(hashtable table, int parentKey, int childKey) { return ; }//native  LoadFogStateHandle			takes hashtable table, integer parentKey, integer childKey returns fogstate
		public static fogmodifier LoadFogModifierHandle(hashtable table, int parentKey, int childKey) { return ; }//native  LoadFogModifierHandle		takes hashtable table, integer parentKey, integer childKey returns fogmodifier
		public static hashtable LoadHashtableHandle(hashtable table, int parentKey, int childKey) { return ; }//native  LoadHashtableHandle			takes hashtable table, integer parentKey, integer childKey returns hashtable
		public static bool HaveSavedInteger(hashtable table, int parentKey, int childKey) { return false; }//native  HaveSavedInteger					takes hashtable table, integer parentKey, integer childKey returns boolean
		public static bool HaveSavedReal(hashtable table, int parentKey, int childKey) { return false; }//native  HaveSavedReal						takes hashtable table, integer parentKey, integer childKey returns boolean
		public static bool HaveSavedBoolean(hashtable table, int parentKey, int childKey) { return false; }//native  HaveSavedBoolean					takes hashtable table, integer parentKey, integer childKey returns boolean
		public static bool HaveSavedString(hashtable table, int parentKey, int childKey) { return false; }//native  HaveSavedString					    takes hashtable table, integer parentKey, integer childKey returns boolean
		public static bool HaveSavedHandle(hashtable table, int parentKey, int childKey) { return false; }//native  HaveSavedHandle     				takes hashtable table, integer parentKey, integer childKey returns boolean
		public static void RemoveSavedInteger(hashtable table, int parentKey, int childKey) {  }//native  RemoveSavedInteger					takes hashtable table, integer parentKey, integer childKey returns nothing
		public static void RemoveSavedReal(hashtable table, int parentKey, int childKey) {  }//native  RemoveSavedReal						takes hashtable table, integer parentKey, integer childKey returns nothing
		public static void RemoveSavedBoolean(hashtable table, int parentKey, int childKey) {  }//native  RemoveSavedBoolean					takes hashtable table, integer parentKey, integer childKey returns nothing
		public static void RemoveSavedString(hashtable table, int parentKey, int childKey) {  }//native  RemoveSavedString					takes hashtable table, integer parentKey, integer childKey returns nothing
		public static void RemoveSavedHandle(hashtable table, int parentKey, int childKey) {  }//native  RemoveSavedHandle					takes hashtable table, integer parentKey, integer childKey returns nothing
		public static void FlushParentHashtable() {  }//native  FlushParentHashtable						takes hashtable table returns nothing
		public static void FlushChildHashtable(hashtable table, int parentKey) {  }//native  FlushChildHashtable					takes hashtable table, integer parentKey returns nothing
		public static int GetRandomInt(int lowBound, int highBound) { return 0; }//native GetRandomInt takes integer lowBound, integer highBound returns integer
		public static real GetRandomReal(real lowBound, real highBound) { return ; }//native GetRandomReal takes real lowBound, real highBound returns real
		public static unitpool CreateUnitPool() { return ; }//native CreateUnitPool           takes nothing returns unitpool
		public static void DestroyUnitPool() {  }//native DestroyUnitPool          takes unitpool whichPool returns nothing
		public static void UnitPoolAddUnitType(unitpool whichPool, int unitId, real weight) {  }//native UnitPoolAddUnitType      takes unitpool whichPool, integer unitId, real weight returns nothing
		public static void UnitPoolRemoveUnitType(unitpool whichPool, int unitId) {  }//native UnitPoolRemoveUnitType   takes unitpool whichPool, integer unitId returns nothing
		public static int PlaceRandomUnit(unitpool whichPool, player forWhichPlayer, real x, real y, real facing) { return 0; }//native PlaceRandomUnit          takes unitpool whichPool, player forWhichPlayer, real x, real y, real facing returns unit
		public static itempool CreateItemPool() { return ; }//native CreateItemPool           takes nothing returns itempool
		public static void DestroyItemPool() {  }//native DestroyItemPool          takes itempool whichItemPool returns nothing
		public static void ItemPoolAddItemType(itempool whichItemPool, int itemId, real weight) {  }//native ItemPoolAddItemType      takes itempool whichItemPool, integer itemId, real weight returns nothing
		public static void ItemPoolRemoveItemType(itempool whichItemPool, int itemId) {  }//native ItemPoolRemoveItemType   takes itempool whichItemPool, integer itemId returns nothing
		public static item PlaceRandomItem(itempool whichItemPool, real x, real y) { return ; }//native PlaceRandomItem          takes itempool whichItemPool, real x, real y returns item
		public static int ChooseRandomCreep() { return 0; }//native ChooseRandomCreep        takes integer level returns integer
		public static int ChooseRandomNPBuilding() { return 0; }//native ChooseRandomNPBuilding   takes nothing returns integer
		public static int ChooseRandomItem() { return 0; }//native ChooseRandomItem         takes integer level returns integer
		public static int ChooseRandomItemEx(itemtype whichType, int level) { return 0; }//native ChooseRandomItemEx       takes itemtype whichType, integer level returns integer
		public static void SetRandomSeed() {  }//native SetRandomSeed            takes integer seed returns nothing
		public static void SetTerrainFog(real a, real b, real c, real d, real e) {  }//native SetTerrainFog                takes real a, real b, real c, real d, real e returns nothing
		public static void ResetTerrainFog() {  }//native ResetTerrainFog              takes nothing returns nothing
		public static void SetUnitFog(real a, real b, real c, real d, real e) {  }//native SetUnitFog                   takes real a, real b, real c, real d, real e returns nothing
		public static void SetTerrainFogEx(int style, real zstart, real zend, real density, real red, real green, real blue) {  }//native SetTerrainFogEx              takes integer style, real zstart, real zend, real density, real red, real green, real blue returns nothing
		public static void DisplayTextToPlayer(player toPlayer, real x, real y, string message) {  }//native DisplayTextToPlayer          takes player toPlayer, real x, real y, string message returns nothing
		public static void DisplayTimedTextToPlayer(player toPlayer, real x, real y, real duration, string message) {  }//native DisplayTimedTextToPlayer     takes player toPlayer, real x, real y, real duration, string message returns nothing
		public static void DisplayTimedTextFromPlayer(player toPlayer, real x, real y, real duration, string message) {  }//native DisplayTimedTextFromPlayer   takes player toPlayer, real x, real y, real duration, string message returns nothing
		public static void ClearTextMessages() {  }//native ClearTextMessages            takes nothing returns nothing
		public static void SetDayNightModels(string terrainDNCFile, string unitDNCFile) {  }//native SetDayNightModels            takes string terrainDNCFile, string unitDNCFile returns nothing
		public static void SetSkyModel() {  }//native SetSkyModel                  takes string skyModelFile returns nothing
		public static void EnableUserControl() {  }//native EnableUserControl            takes boolean b returns nothing
		public static void EnableUserUI() {  }//native EnableUserUI                 takes boolean b returns nothing
		public static void SuspendTimeOfDay() {  }//native SuspendTimeOfDay             takes boolean b returns nothing
		public static void SetTimeOfDayScale() {  }//native SetTimeOfDayScale            takes real r returns nothing
		public static real GetTimeOfDayScale() { return ; }//native GetTimeOfDayScale            takes nothing returns real
		public static void ShowInterface(bool flag, real fadeDuration) {  }//native ShowInterface                takes boolean flag, real fadeDuration returns nothing
		public static void PauseGame() {  }//native PauseGame                    takes boolean flag returns nothing
		public static void UnitAddIndicator(int whichUnit, int red, int green, int blue, int alpha) {  }//native UnitAddIndicator             takes unit whichUnit, integer red, integer green, integer blue, integer alpha returns nothing
		public static void AddIndicator(widget whichWidget, int red, int green, int blue, int alpha) {  }//native AddIndicator                 takes widget whichWidget, integer red, integer green, integer blue, integer alpha returns nothing
		public static void PingMinimap(real x, real y, real duration) {  }//native PingMinimap                  takes real x, real y, real duration returns nothing
		public static void PingMinimapEx(real x, real y, real duration, int red, int green, int blue, bool extraEffects) {  }//native PingMinimapEx                takes real x, real y, real duration, integer red, integer green, integer blue, boolean extraEffects returns nothing
		public static void EnableOcclusion() {  }//native EnableOcclusion              takes boolean flag returns nothing
		public static void SetIntroShotText() {  }//native SetIntroShotText             takes string introText returns nothing
		public static void SetIntroShotModel() {  }//native SetIntroShotModel            takes string introModelPath returns nothing
		public static void EnableWorldFogBoundary() {  }//native EnableWorldFogBoundary       takes boolean b returns nothing
		public static void PlayModelCinematic() {  }//native PlayModelCinematic           takes string modelName returns nothing
		public static void PlayCinematic() {  }//native PlayCinematic                takes string movieName returns nothing
		public static void ForceUIKey() {  }//native ForceUIKey                   takes string key returns nothing
		public static void ForceUICancel() {  }//native ForceUICancel                takes nothing returns nothing
		public static void DisplayLoadDialog() {  }//native DisplayLoadDialog            takes nothing returns nothing
		public static void SetAltMinimapIcon() {  }//native SetAltMinimapIcon            takes string iconPath returns nothing
		public static void DisableRestartMission() {  }//native DisableRestartMission        takes boolean flag returns nothing
		public static texttag CreateTextTag() { return ; }//native CreateTextTag                takes nothing returns texttag
		public static void DestroyTextTag() {  }//native DestroyTextTag               takes texttag t returns nothing
		public static void SetTextTagText(texttag t, string s, real height) {  }//native SetTextTagText               takes texttag t, string s, real height returns nothing
		public static void SetTextTagPos(texttag t, real x, real y, real heightOffset) {  }//native SetTextTagPos                takes texttag t, real x, real y, real heightOffset returns nothing
		public static void SetTextTagPosUnit(texttag t, int whichUnit, real heightOffset) {  }//native SetTextTagPosUnit            takes texttag t, unit whichUnit, real heightOffset returns nothing
		public static void SetTextTagColor(texttag t, int red, int green, int blue, int alpha) {  }//native SetTextTagColor              takes texttag t, integer red, integer green, integer blue, integer alpha returns nothing
		public static void SetTextTagVelocity(texttag t, real xvel, real yvel) {  }//native SetTextTagVelocity           takes texttag t, real xvel, real yvel returns nothing
		public static void SetTextTagVisibility(texttag t, bool flag) {  }//native SetTextTagVisibility         takes texttag t, boolean flag returns nothing
		public static void SetTextTagSuspended(texttag t, bool flag) {  }//native SetTextTagSuspended          takes texttag t, boolean flag returns nothing
		public static void SetTextTagPermanent(texttag t, bool flag) {  }//native SetTextTagPermanent          takes texttag t, boolean flag returns nothing
		public static void SetTextTagAge(texttag t, real age) {  }//native SetTextTagAge                takes texttag t, real age returns nothing
		public static void SetTextTagLifespan(texttag t, real lifespan) {  }//native SetTextTagLifespan           takes texttag t, real lifespan returns nothing
		public static void SetTextTagFadepoint(texttag t, real fadepoint) {  }//native SetTextTagFadepoint          takes texttag t, real fadepoint returns nothing
		public static void SetReservedLocalHeroButtons() {  }//native SetReservedLocalHeroButtons  takes integer reserved returns nothing
		public static int GetAllyColorFilterState() { return 0; }//native GetAllyColorFilterState      takes nothing returns integer
		public static void SetAllyColorFilterState() {  }//native SetAllyColorFilterState      takes integer state returns nothing
		public static bool GetCreepCampFilterState() { return false; }//native GetCreepCampFilterState      takes nothing returns boolean
		public static void SetCreepCampFilterState() {  }//native SetCreepCampFilterState      takes boolean state returns nothing
		public static void EnableMinimapFilterButtons(bool enableAlly, bool enableCreep) {  }//native EnableMinimapFilterButtons   takes boolean enableAlly, boolean enableCreep returns nothing
		public static void EnableDragSelect(bool state, bool ui) {  }//native EnableDragSelect             takes boolean state, boolean ui returns nothing
		public static void EnablePreSelect(bool state, bool ui) {  }//native EnablePreSelect              takes boolean state, boolean ui returns nothing
		public static void EnableSelect(bool state, bool ui) {  }//native EnableSelect                 takes boolean state, boolean ui returns nothing
		public static trackable CreateTrackable(string trackableModelPath, real x, real y, real facing) { return ; }//native CreateTrackable      takes string trackableModelPath, real x, real y, real facing returns trackable
		public static quest CreateQuest() { return ; }//native CreateQuest          takes nothing returns quest
		public static void DestroyQuest() {  }//native DestroyQuest         takes quest whichQuest returns nothing
		public static void QuestSetTitle(quest whichQuest, string title) {  }//native QuestSetTitle        takes quest whichQuest, string title returns nothing
		public static void QuestSetDescription(quest whichQuest, string description) {  }//native QuestSetDescription  takes quest whichQuest, string description returns nothing
		public static void QuestSetIconPath(quest whichQuest, string iconPath) {  }//native QuestSetIconPath     takes quest whichQuest, string iconPath returns nothing
		public static void QuestSetRequired(quest whichQuest, bool required) {  }//native QuestSetRequired     takes quest whichQuest, boolean required   returns nothing
		public static void QuestSetCompleted(quest whichQuest, bool completed) {  }//native QuestSetCompleted    takes quest whichQuest, boolean completed  returns nothing
		public static void QuestSetDiscovered(quest whichQuest, bool discovered) {  }//native QuestSetDiscovered   takes quest whichQuest, boolean discovered returns nothing
		public static void QuestSetFailed(quest whichQuest, bool failed) {  }//native QuestSetFailed       takes quest whichQuest, boolean failed     returns nothing
		public static void QuestSetEnabled(quest whichQuest, bool enabled) {  }//native QuestSetEnabled      takes quest whichQuest, boolean enabled    returns nothing
		public static bool IsQuestRequired() { return false; }//native IsQuestRequired     takes quest whichQuest returns boolean
		public static bool IsQuestCompleted() { return false; }//native IsQuestCompleted    takes quest whichQuest returns boolean
		public static bool IsQuestDiscovered() { return false; }//native IsQuestDiscovered   takes quest whichQuest returns boolean
		public static bool IsQuestFailed() { return false; }//native IsQuestFailed       takes quest whichQuest returns boolean
		public static bool IsQuestEnabled() { return false; }//native IsQuestEnabled      takes quest whichQuest returns boolean
		public static questitem QuestCreateItem() { return ; }//native QuestCreateItem          takes quest whichQuest returns questitem
		public static void QuestItemSetDescription(questitem whichQuestItem, string description) {  }//native QuestItemSetDescription  takes questitem whichQuestItem, string description returns nothing
		public static void QuestItemSetCompleted(questitem whichQuestItem, bool completed) {  }//native QuestItemSetCompleted    takes questitem whichQuestItem, boolean completed returns nothing
		public static bool IsQuestItemCompleted() { return false; }//native IsQuestItemCompleted     takes questitem whichQuestItem returns boolean
		public static defeatcondition CreateDefeatCondition() { return ; }//native CreateDefeatCondition            takes nothing returns defeatcondition
		public static void DestroyDefeatCondition() {  }//native DestroyDefeatCondition           takes defeatcondition whichCondition returns nothing
		public static void DefeatConditionSetDescription(defeatcondition whichCondition, string description) {  }//native DefeatConditionSetDescription    takes defeatcondition whichCondition, string description returns nothing
		public static void FlashQuestDialogButton() {  }//native FlashQuestDialogButton   takes nothing returns nothing
		public static void ForceQuestDialogUpdate() {  }//native ForceQuestDialogUpdate   takes nothing returns nothing
		public static timerdialog CreateTimerDialog() { return ; }//native CreateTimerDialog                takes timer t returns timerdialog
		public static void DestroyTimerDialog() {  }//native DestroyTimerDialog               takes timerdialog whichDialog returns nothing
		public static void TimerDialogSetTitle(timerdialog whichDialog, string title) {  }//native TimerDialogSetTitle              takes timerdialog whichDialog, string title returns nothing
		public static void TimerDialogSetTitleColor(timerdialog whichDialog, int red, int green, int blue, int alpha) {  }//native TimerDialogSetTitleColor         takes timerdialog whichDialog, integer red, integer green, integer blue, integer alpha returns nothing
		public static void TimerDialogSetTimeColor(timerdialog whichDialog, int red, int green, int blue, int alpha) {  }//native TimerDialogSetTimeColor          takes timerdialog whichDialog, integer red, integer green, integer blue, integer alpha returns nothing
		public static void TimerDialogSetSpeed(timerdialog whichDialog, real speedMultFactor) {  }//native TimerDialogSetSpeed              takes timerdialog whichDialog, real speedMultFactor returns nothing
		public static void TimerDialogDisplay(timerdialog whichDialog, bool display) {  }//native TimerDialogDisplay               takes timerdialog whichDialog, boolean display returns nothing
		public static bool IsTimerDialogDisplayed() { return false; }//native IsTimerDialogDisplayed           takes timerdialog whichDialog returns boolean
		public static void TimerDialogSetRealTimeRemaining(timerdialog whichDialog, real timeRemaining) {  }//native TimerDialogSetRealTimeRemaining  takes timerdialog whichDialog, real timeRemaining returns nothing
		public static leaderboard CreateLeaderboard() { return ; }//native CreateLeaderboard                takes nothing returns leaderboard
		public static void DestroyLeaderboard() {  }//native DestroyLeaderboard               takes leaderboard lb returns nothing
		public static void LeaderboardDisplay(leaderboard lb, bool show) {  }//native LeaderboardDisplay               takes leaderboard lb, boolean show returns nothing
		public static bool IsLeaderboardDisplayed() { return false; }//native IsLeaderboardDisplayed           takes leaderboard lb returns boolean
		public static int LeaderboardGetItemCount() { return 0; }//native LeaderboardGetItemCount          takes leaderboard lb returns integer
		public static void LeaderboardSetSizeByItemCount(leaderboard lb, int count) {  }//native LeaderboardSetSizeByItemCount    takes leaderboard lb, integer count returns nothing
		public static void LeaderboardAddItem(leaderboard lb, string label, int value, player p) {  }//native LeaderboardAddItem               takes leaderboard lb, string label, integer value, player p returns nothing
		public static void LeaderboardRemoveItem(leaderboard lb, int index) {  }//native LeaderboardRemoveItem            takes leaderboard lb, integer index returns nothing
		public static void LeaderboardRemovePlayerItem(leaderboard lb, player p) {  }//native LeaderboardRemovePlayerItem      takes leaderboard lb, player p returns nothing
		public static void LeaderboardClear() {  }//native LeaderboardClear                 takes leaderboard lb returns nothing
		public static void LeaderboardSortItemsByValue(leaderboard lb, bool ascending) {  }//native LeaderboardSortItemsByValue      takes leaderboard lb, boolean ascending returns nothing
		public static void LeaderboardSortItemsByPlayer(leaderboard lb, bool ascending) {  }//native LeaderboardSortItemsByPlayer     takes leaderboard lb, boolean ascending returns nothing
		public static void LeaderboardSortItemsByLabel(leaderboard lb, bool ascending) {  }//native LeaderboardSortItemsByLabel      takes leaderboard lb, boolean ascending returns nothing
		public static bool LeaderboardHasPlayerItem(leaderboard lb, player p) { return false; }//native LeaderboardHasPlayerItem         takes leaderboard lb, player p returns boolean
		public static int LeaderboardGetPlayerIndex(leaderboard lb, player p) { return 0; }//native LeaderboardGetPlayerIndex        takes leaderboard lb, player p returns integer
		public static void LeaderboardSetLabel(leaderboard lb, string label) {  }//native LeaderboardSetLabel              takes leaderboard lb, string label returns nothing
		public static string LeaderboardGetLabelText() { return ; }//native LeaderboardGetLabelText          takes leaderboard lb returns string
		public static void PlayerSetLeaderboard(player toPlayer, leaderboard lb) {  }//native PlayerSetLeaderboard             takes player toPlayer, leaderboard lb returns nothing
		public static leaderboard PlayerGetLeaderboard() { return ; }//native PlayerGetLeaderboard             takes player toPlayer returns leaderboard
		public static void LeaderboardSetLabelColor(leaderboard lb, int red, int green, int blue, int alpha) {  }//native LeaderboardSetLabelColor         takes leaderboard lb, integer red, integer green, integer blue, integer alpha returns nothing
		public static void LeaderboardSetValueColor(leaderboard lb, int red, int green, int blue, int alpha) {  }//native LeaderboardSetValueColor         takes leaderboard lb, integer red, integer green, integer blue, integer alpha returns nothing
		public static void LeaderboardSetStyle(leaderboard lb, bool showLabel, bool showNames, bool showValues, bool showIcons) {  }//native LeaderboardSetStyle              takes leaderboard lb, boolean showLabel, boolean showNames, boolean showValues, boolean showIcons returns nothing
		public static void LeaderboardSetItemValue(leaderboard lb, int whichItem, int val) {  }//native LeaderboardSetItemValue          takes leaderboard lb, integer whichItem, integer val returns nothing
		public static void LeaderboardSetItemLabel(leaderboard lb, int whichItem, string val) {  }//native LeaderboardSetItemLabel          takes leaderboard lb, integer whichItem, string val returns nothing
		public static void LeaderboardSetItemStyle(leaderboard lb, int whichItem, bool showLabel, bool showValue, bool showIcon) {  }//native LeaderboardSetItemStyle          takes leaderboard lb, integer whichItem, boolean showLabel, boolean showValue, boolean showIcon returns nothing
		public static void LeaderboardSetItemLabelColor(leaderboard lb, int whichItem, int red, int green, int blue, int alpha) {  }//native LeaderboardSetItemLabelColor     takes leaderboard lb, integer whichItem, integer red, integer green, integer blue, integer alpha returns nothing
		public static void LeaderboardSetItemValueColor(leaderboard lb, int whichItem, int red, int green, int blue, int alpha) {  }//native LeaderboardSetItemValueColor     takes leaderboard lb, integer whichItem, integer red, integer green, integer blue, integer alpha returns nothing
		public static multiboard CreateMultiboard() { return ; }//native CreateMultiboard                 takes nothing returns multiboard
		public static void DestroyMultiboard() {  }//native DestroyMultiboard                takes multiboard lb returns nothing
		public static void MultiboardDisplay(multiboard lb, bool show) {  }//native MultiboardDisplay                takes multiboard lb, boolean show returns nothing
		public static bool IsMultiboardDisplayed() { return false; }//native IsMultiboardDisplayed            takes multiboard lb returns boolean
		public static void MultiboardMinimize(multiboard lb, bool minimize) {  }//native MultiboardMinimize               takes multiboard lb, boolean minimize returns nothing
		public static bool IsMultiboardMinimized() { return false; }//native IsMultiboardMinimized            takes multiboard lb returns boolean
		public static void MultiboardClear() {  }//native MultiboardClear                  takes multiboard lb returns nothing
		public static void MultiboardSetTitleText(multiboard lb, string label) {  }//native MultiboardSetTitleText           takes multiboard lb, string label returns nothing
		public static string MultiboardGetTitleText() { return ; }//native MultiboardGetTitleText           takes multiboard lb returns string
		public static void MultiboardSetTitleTextColor(multiboard lb, int red, int green, int blue, int alpha) {  }//native MultiboardSetTitleTextColor      takes multiboard lb, integer red, integer green, integer blue, integer alpha returns nothing
		public static int MultiboardGetRowCount() { return 0; }//native MultiboardGetRowCount            takes multiboard lb returns integer
		public static int MultiboardGetColumnCount() { return 0; }//native MultiboardGetColumnCount         takes multiboard lb returns integer
		public static void MultiboardSetColumnCount(multiboard lb, int count) {  }//native MultiboardSetColumnCount         takes multiboard lb, integer count returns nothing
		public static void MultiboardSetRowCount(multiboard lb, int count) {  }//native MultiboardSetRowCount            takes multiboard lb, integer count returns nothing
		public static void MultiboardSetItemsStyle(multiboard lb, bool showValues, bool showIcons) {  }//native MultiboardSetItemsStyle          takes multiboard lb, boolean showValues, boolean showIcons returns nothing
		public static void MultiboardSetItemsValue(multiboard lb, string value) {  }//native MultiboardSetItemsValue          takes multiboard lb, string value returns nothing
		public static void MultiboardSetItemsValueColor(multiboard lb, int red, int green, int blue, int alpha) {  }//native MultiboardSetItemsValueColor     takes multiboard lb, integer red, integer green, integer blue, integer alpha returns nothing
		public static void MultiboardSetItemsWidth(multiboard lb, real width) {  }//native MultiboardSetItemsWidth          takes multiboard lb, real width returns nothing
		public static void MultiboardSetItemsIcon(multiboard lb, string iconPath) {  }//native MultiboardSetItemsIcon           takes multiboard lb, string iconPath returns nothing
		public static multiboarditem MultiboardGetItem(multiboard lb, int row, int column) { return ; }//native MultiboardGetItem                takes multiboard lb, integer row, integer column returns multiboarditem
		public static void MultiboardReleaseItem() {  }//native MultiboardReleaseItem            takes multiboarditem mbi returns nothing
		public static void MultiboardSetItemStyle(multiboarditem mbi, bool showValue, bool showIcon) {  }//native MultiboardSetItemStyle           takes multiboarditem mbi, boolean showValue, boolean showIcon returns nothing
		public static void MultiboardSetItemValue(multiboarditem mbi, string val) {  }//native MultiboardSetItemValue           takes multiboarditem mbi, string val returns nothing
		public static void MultiboardSetItemValueColor(multiboarditem mbi, int red, int green, int blue, int alpha) {  }//native MultiboardSetItemValueColor      takes multiboarditem mbi, integer red, integer green, integer blue, integer alpha returns nothing
		public static void MultiboardSetItemWidth(multiboarditem mbi, real width) {  }//native MultiboardSetItemWidth           takes multiboarditem mbi, real width returns nothing
		public static void MultiboardSetItemIcon(multiboarditem mbi, string iconFileName) {  }//native MultiboardSetItemIcon            takes multiboarditem mbi, string iconFileName returns nothing
		public static void MultiboardSuppressDisplay() {  }//native MultiboardSuppressDisplay        takes boolean flag returns nothing
		public static void SetCameraPosition(real x, real y) {  }//native SetCameraPosition            takes real x, real y returns nothing
		public static void SetCameraQuickPosition(real x, real y) {  }//native SetCameraQuickPosition       takes real x, real y returns nothing
		public static void SetCameraBounds(real x1, real y1, real x2, real y2, real x3, real y3, real x4, real y4) {  }//native SetCameraBounds              takes real x1, real y1, real x2, real y2, real x3, real y3, real x4, real y4 returns nothing
		public static void StopCamera() {  }//native StopCamera                   takes nothing returns nothing
		public static void ResetToGameCamera() {  }//native ResetToGameCamera            takes real duration returns nothing
		public static void PanCameraTo(real x, real y) {  }//native PanCameraTo                  takes real x, real y returns nothing
		public static void PanCameraToTimed(real x, real y, real duration) {  }//native PanCameraToTimed             takes real x, real y, real duration returns nothing
		public static void PanCameraToWithZ(real x, real y, real zOffsetDest) {  }//native PanCameraToWithZ             takes real x, real y, real zOffsetDest returns nothing
		public static void PanCameraToTimedWithZ(real x, real y, real zOffsetDest, real duration) {  }//native PanCameraToTimedWithZ        takes real x, real y, real zOffsetDest, real duration returns nothing
		public static void SetCinematicCamera() {  }//native SetCinematicCamera           takes string cameraModelFile returns nothing
		public static void SetCameraRotateMode(real x, real y, real radiansToSweep, real duration) {  }//native SetCameraRotateMode          takes real x, real y, real radiansToSweep, real duration returns nothing
		public static void SetCameraField(camerafield whichField, real value, real duration) {  }//native SetCameraField               takes camerafield whichField, real value, real duration returns nothing
		public static void AdjustCameraField(camerafield whichField, real offset, real duration) {  }//native AdjustCameraField            takes camerafield whichField, real offset, real duration returns nothing
		public static void SetCameraTargetController(int whichUnit, real xoffset, real yoffset, bool inheritOrientation) {  }//native SetCameraTargetController    takes unit whichUnit, real xoffset, real yoffset, boolean inheritOrientation returns nothing
		public static void SetCameraOrientController(int whichUnit, real xoffset, real yoffset) {  }//native SetCameraOrientController    takes unit whichUnit, real xoffset, real yoffset returns nothing
		public static camerasetup CreateCameraSetup() { return ; }//native CreateCameraSetup                    takes nothing returns camerasetup
		public static void CameraSetupSetField(camerasetup whichSetup, camerafield whichField, real value, real duration) {  }//native CameraSetupSetField                  takes camerasetup whichSetup, camerafield whichField, real value, real duration returns nothing
		public static real CameraSetupGetField(camerasetup whichSetup, camerafield whichField) { return ; }//native CameraSetupGetField                  takes camerasetup whichSetup, camerafield whichField returns real
		public static void CameraSetupSetDestPosition(camerasetup whichSetup, real x, real y, real duration) {  }//native CameraSetupSetDestPosition           takes camerasetup whichSetup, real x, real y, real duration returns nothing
		public static location CameraSetupGetDestPositionLoc() { return ; }//native CameraSetupGetDestPositionLoc        takes camerasetup whichSetup returns location
		public static real CameraSetupGetDestPositionX() { return ; }//native CameraSetupGetDestPositionX          takes camerasetup whichSetup returns real
		public static real CameraSetupGetDestPositionY() { return ; }//native CameraSetupGetDestPositionY          takes camerasetup whichSetup returns real
		public static void CameraSetupApply(camerasetup whichSetup, bool doPan, bool panTimed) {  }//native CameraSetupApply                     takes camerasetup whichSetup, boolean doPan, boolean panTimed returns nothing
		public static void CameraSetupApplyWithZ(camerasetup whichSetup, real zDestOffset) {  }//native CameraSetupApplyWithZ                takes camerasetup whichSetup, real zDestOffset returns nothing
		public static void CameraSetupApplyForceDuration(camerasetup whichSetup, bool doPan, real forceDuration) {  }//native CameraSetupApplyForceDuration        takes camerasetup whichSetup, boolean doPan, real forceDuration returns nothing
		public static void CameraSetupApplyForceDurationWithZ(camerasetup whichSetup, real zDestOffset, real forceDuration) {  }//native CameraSetupApplyForceDurationWithZ   takes camerasetup whichSetup, real zDestOffset, real forceDuration returns nothing
		public static void CameraSetTargetNoise(real mag, real velocity) {  }//native CameraSetTargetNoise             takes real mag, real velocity returns nothing
		public static void CameraSetSourceNoise(real mag, real velocity) {  }//native CameraSetSourceNoise             takes real mag, real velocity returns nothing
		public static void CameraSetTargetNoiseEx(real mag, real velocity, bool vertOnly) {  }//native CameraSetTargetNoiseEx           takes real mag, real velocity, boolean vertOnly returns nothing
		public static void CameraSetSourceNoiseEx(real mag, real velocity, bool vertOnly) {  }//native CameraSetSourceNoiseEx           takes real mag, real velocity, boolean vertOnly returns nothing
		public static void CameraSetSmoothingFactor() {  }//native CameraSetSmoothingFactor         takes real factor returns nothing
		public static void SetCineFilterTexture() {  }//native SetCineFilterTexture             takes string filename returns nothing
		public static void SetCineFilterBlendMode() {  }//native SetCineFilterBlendMode           takes blendmode whichMode returns nothing
		public static void SetCineFilterTexMapFlags() {  }//native SetCineFilterTexMapFlags         takes texmapflags whichFlags returns nothing
		public static void SetCineFilterStartUV(real minu, real minv, real maxu, real maxv) {  }//native SetCineFilterStartUV             takes real minu, real minv, real maxu, real maxv returns nothing
		public static void SetCineFilterEndUV(real minu, real minv, real maxu, real maxv) {  }//native SetCineFilterEndUV               takes real minu, real minv, real maxu, real maxv returns nothing
		public static void SetCineFilterStartColor(int red, int green, int blue, int alpha) {  }//native SetCineFilterStartColor          takes integer red, integer green, integer blue, integer alpha returns nothing
		public static void SetCineFilterEndColor(int red, int green, int blue, int alpha) {  }//native SetCineFilterEndColor            takes integer red, integer green, integer blue, integer alpha returns nothing
		public static void SetCineFilterDuration() {  }//native SetCineFilterDuration            takes real duration returns nothing
		public static void DisplayCineFilter() {  }//native DisplayCineFilter                takes boolean flag returns nothing
		public static bool IsCineFilterDisplayed() { return false; }//native IsCineFilterDisplayed            takes nothing returns boolean
		public static void SetCinematicScene(int portraitUnitId, playercolor color, string speakerTitle, string text, real sceneDuration, real voiceoverDuration) {  }//native SetCinematicScene                takes integer portraitUnitId, playercolor color, string speakerTitle, string text, real sceneDuration, real voiceoverDuration returns nothing
		public static void EndCinematicScene() {  }//native EndCinematicScene                takes nothing returns nothing
		public static void ForceCinematicSubtitles() {  }//native ForceCinematicSubtitles          takes boolean flag returns nothing
		public static real GetCameraMargin() { return ; }//native GetCameraMargin                  takes integer whichMargin returns real
		public static real GetCameraBoundMinX() { return ; }//constant native GetCameraBoundMinX          takes nothing returns real
		public static real GetCameraBoundMinY() { return ; }//constant native GetCameraBoundMinY          takes nothing returns real
		public static real GetCameraBoundMaxX() { return ; }//constant native GetCameraBoundMaxX          takes nothing returns real
		public static real GetCameraBoundMaxY() { return ; }//constant native GetCameraBoundMaxY          takes nothing returns real
		public static real GetCameraField() { return ; }//constant native GetCameraField              takes camerafield whichField returns real
		public static real GetCameraTargetPositionX() { return ; }//constant native GetCameraTargetPositionX    takes nothing returns real
		public static real GetCameraTargetPositionY() { return ; }//constant native GetCameraTargetPositionY    takes nothing returns real
		public static real GetCameraTargetPositionZ() { return ; }//constant native GetCameraTargetPositionZ    takes nothing returns real
		public static location GetCameraTargetPositionLoc() { return ; }//constant native GetCameraTargetPositionLoc  takes nothing returns location
		public static real GetCameraEyePositionX() { return ; }//constant native GetCameraEyePositionX       takes nothing returns real
		public static real GetCameraEyePositionY() { return ; }//constant native GetCameraEyePositionY       takes nothing returns real
		public static real GetCameraEyePositionZ() { return ; }//constant native GetCameraEyePositionZ       takes nothing returns real
		public static location GetCameraEyePositionLoc() { return ; }//constant native GetCameraEyePositionLoc     takes nothing returns location
		public static void NewSoundEnvironment() {  }//native NewSoundEnvironment          takes string environmentName returns nothing
		public static sound CreateSound(string fileName, bool looping, bool is3D, bool stopwhenoutofrange, int fadeInRate, int fadeOutRate, string eaxSetting) { return ; }//native CreateSound                  takes string fileName, boolean looping, boolean is3D, boolean stopwhenoutofrange, integer fadeInRate, integer fadeOutRate, string eaxSetting returns sound
		public static sound CreateSoundFilenameWithLabel(string fileName, bool looping, bool is3D, bool stopwhenoutofrange, int fadeInRate, int fadeOutRate, string SLKEntryName) { return ; }//native CreateSoundFilenameWithLabel takes string fileName, boolean looping, boolean is3D, boolean stopwhenoutofrange, integer fadeInRate, integer fadeOutRate, string SLKEntryName returns sound
		public static sound CreateSoundFromLabel(string soundLabel, bool looping, bool is3D, bool stopwhenoutofrange, int fadeInRate, int fadeOutRate) { return ; }//native CreateSoundFromLabel         takes string soundLabel, boolean looping, boolean is3D, boolean stopwhenoutofrange, integer fadeInRate, integer fadeOutRate returns sound
		public static sound CreateMIDISound(string soundLabel, int fadeInRate, int fadeOutRate) { return ; }//native CreateMIDISound              takes string soundLabel, integer fadeInRate, integer fadeOutRate returns sound
		public static void SetSoundParamsFromLabel(sound soundHandle, string soundLabel) {  }//native SetSoundParamsFromLabel      takes sound soundHandle, string soundLabel returns nothing
		public static void SetSoundDistanceCutoff(sound soundHandle, real cutoff) {  }//native SetSoundDistanceCutoff       takes sound soundHandle, real cutoff returns nothing
		public static void SetSoundChannel(sound soundHandle, int channel) {  }//native SetSoundChannel              takes sound soundHandle, integer channel returns nothing
		public static void SetSoundVolume(sound soundHandle, int volume) {  }//native SetSoundVolume               takes sound soundHandle, integer volume returns nothing
		public static void SetSoundPitch(sound soundHandle, real pitch) {  }//native SetSoundPitch                takes sound soundHandle, real pitch returns nothing
		public static void SetSoundPlayPosition(sound soundHandle, int millisecs) {  }//native SetSoundPlayPosition         takes sound soundHandle, integer millisecs returns nothing
		public static void SetSoundDistances(sound soundHandle, real minDist, real maxDist) {  }//native SetSoundDistances            takes sound soundHandle, real minDist, real maxDist returns nothing
		public static void SetSoundConeAngles(sound soundHandle, real inside, real outside, int outsideVolume) {  }//native SetSoundConeAngles           takes sound soundHandle, real inside, real outside, integer outsideVolume returns nothing
		public static void SetSoundConeOrientation(sound soundHandle, real x, real y, real z) {  }//native SetSoundConeOrientation      takes sound soundHandle, real x, real y, real z returns nothing
		public static void SetSoundPosition(sound soundHandle, real x, real y, real z) {  }//native SetSoundPosition             takes sound soundHandle, real x, real y, real z returns nothing
		public static void SetSoundVelocity(sound soundHandle, real x, real y, real z) {  }//native SetSoundVelocity             takes sound soundHandle, real x, real y, real z returns nothing
		public static void AttachSoundToUnit(sound soundHandle, int whichUnit) {  }//native AttachSoundToUnit            takes sound soundHandle, unit whichUnit returns nothing
		public static void StartSound() {  }//native StartSound                   takes sound soundHandle returns nothing
		public static void StopSound(sound soundHandle, bool killWhenDone, bool fadeOut) {  }//native StopSound                    takes sound soundHandle, boolean killWhenDone, boolean fadeOut returns nothing
		public static void KillSoundWhenDone() {  }//native KillSoundWhenDone            takes sound soundHandle returns nothing
		public static void SetMapMusic(string musicName, bool random, int index) {  }//native SetMapMusic                  takes string musicName, boolean random, integer index returns nothing
		public static void ClearMapMusic() {  }//native ClearMapMusic                takes nothing returns nothing
		public static void PlayMusic() {  }//native PlayMusic                    takes string musicName returns nothing
		public static void PlayMusicEx(string musicName, int frommsecs, int fadeinmsecs) {  }//native PlayMusicEx                  takes string musicName, integer frommsecs, integer fadeinmsecs returns nothing
		public static void StopMusic() {  }//native StopMusic                    takes boolean fadeOut returns nothing
		public static void ResumeMusic() {  }//native ResumeMusic                  takes nothing returns nothing
		public static void PlayThematicMusic() {  }//native PlayThematicMusic            takes string musicFileName returns nothing
		public static void PlayThematicMusicEx(string musicFileName, int frommsecs) {  }//native PlayThematicMusicEx          takes string musicFileName, integer frommsecs returns nothing
		public static void EndThematicMusic() {  }//native EndThematicMusic             takes nothing returns nothing
		public static void SetMusicVolume() {  }//native SetMusicVolume               takes integer volume returns nothing
		public static void SetMusicPlayPosition() {  }//native SetMusicPlayPosition         takes integer millisecs returns nothing
		public static void SetThematicMusicPlayPosition() {  }//native SetThematicMusicPlayPosition takes integer millisecs returns nothing
		public static void SetSoundDuration(sound soundHandle, int duration) {  }//native SetSoundDuration             takes sound soundHandle, integer duration returns nothing
		public static int GetSoundDuration() { return 0; }//native GetSoundDuration             takes sound soundHandle returns integer
		public static int GetSoundFileDuration() { return 0; }//native GetSoundFileDuration         takes string musicFileName returns integer
		public static void VolumeGroupSetVolume(volumegroup vgroup, real scale) {  }//native VolumeGroupSetVolume         takes volumegroup vgroup, real scale returns nothing
		public static void VolumeGroupReset() {  }//native VolumeGroupReset             takes nothing returns nothing
		public static bool GetSoundIsPlaying() { return false; }//native GetSoundIsPlaying            takes sound soundHandle returns boolean
		public static bool GetSoundIsLoading() { return false; }//native GetSoundIsLoading            takes sound soundHandle returns boolean
		public static void RegisterStackedSound(sound soundHandle, bool byPosition, real rectwidth, real rectheight) {  }//native RegisterStackedSound         takes sound soundHandle, boolean byPosition, real rectwidth, real rectheight returns nothing
		public static void UnregisterStackedSound(sound soundHandle, bool byPosition, real rectwidth, real rectheight) {  }//native UnregisterStackedSound       takes sound soundHandle, boolean byPosition, real rectwidth, real rectheight returns nothing
		public static weathereffect AddWeatherEffect(rect where, int effectID) { return ; }//native AddWeatherEffect             takes rect where, integer effectID returns weathereffect
		public static void RemoveWeatherEffect() {  }//native RemoveWeatherEffect          takes weathereffect whichEffect returns nothing
		public static void EnableWeatherEffect(weathereffect whichEffect, bool enable) {  }//native EnableWeatherEffect          takes weathereffect whichEffect, boolean enable returns nothing
		public static terraindeformation TerrainDeformCrater(real x, real y, real radius, real depth, int duration, bool permanent) { return ; }//native TerrainDeformCrater          takes real x, real y, real radius, real depth, integer duration, boolean permanent returns terraindeformation
		public static terraindeformation TerrainDeformRipple(real x, real y, real radius, real depth, int duration, int count, real spaceWaves, real timeWaves, real radiusStartPct, bool limitNeg) { return ; }//native TerrainDeformRipple          takes real x, real y, real radius, real depth, integer duration, integer count, real spaceWaves, real timeWaves, real radiusStartPct, boolean limitNeg returns terraindeformation
		public static terraindeformation TerrainDeformWave(real x, real y, real dirX, real dirY, real distance, real speed, real radius, real depth, int trailTime, int count) { return ; }//native TerrainDeformWave            takes real x, real y, real dirX, real dirY, real distance, real speed, real radius, real depth, integer trailTime, integer count returns terraindeformation
		public static terraindeformation TerrainDeformRandom(real x, real y, real radius, real minDelta, real maxDelta, int duration, int updateInterval) { return ; }//native TerrainDeformRandom          takes real x, real y, real radius, real minDelta, real maxDelta, integer duration, integer updateInterval returns terraindeformation
		public static void TerrainDeformStop(terraindeformation deformation, int duration) {  }//native TerrainDeformStop            takes terraindeformation deformation, integer duration returns nothing
		public static void TerrainDeformStopAll() {  }//native TerrainDeformStopAll         takes nothing returns nothing
		public static effect AddSpecialEffect(string modelName, real x, real y) { return ; }//native AddSpecialEffect             takes string modelName, real x, real y returns effect
		public static effect AddSpecialEffectLoc(string modelName, location where) { return ; }//native AddSpecialEffectLoc          takes string modelName, location where returns effect
		public static effect AddSpecialEffectTarget(string modelName, widget targetWidget, string attachPointName) { return ; }//native AddSpecialEffectTarget       takes string modelName, widget targetWidget, string attachPointName returns effect
		public static void DestroyEffect() {  }//native DestroyEffect                takes effect whichEffect returns nothing
		public static effect AddSpellEffect(string abilityString, effecttype t, real x, real y) { return ; }//native AddSpellEffect               takes string abilityString, effecttype t, real x, real y returns effect
		public static effect AddSpellEffectLoc(string abilityString, effecttype t, location where) { return ; }//native AddSpellEffectLoc            takes string abilityString, effecttype t,location where returns effect
		public static effect AddSpellEffectById(int abilityId, effecttype t, real x, real y) { return ; }//native AddSpellEffectById           takes integer abilityId, effecttype t,real x, real y returns effect
		public static effect AddSpellEffectByIdLoc(int abilityId, effecttype t, location where) { return ; }//native AddSpellEffectByIdLoc        takes integer abilityId, effecttype t,location where returns effect
		public static effect AddSpellEffectTarget(string modelName, effecttype t, widget targetWidget, string attachPoint) { return ; }//native AddSpellEffectTarget         takes string modelName, effecttype t, widget targetWidget, string attachPoint returns effect
		public static effect AddSpellEffectTargetById(int abilityId, effecttype t, widget targetWidget, string attachPoint) { return ; }//native AddSpellEffectTargetById     takes integer abilityId, effecttype t, widget targetWidget, string attachPoint returns effect
		public static lightning AddLightning(string codeName, bool checkVisibility, real x1, real y1, real x2, real y2) { return ; }//native AddLightning                 takes string codeName, boolean checkVisibility, real x1, real y1, real x2, real y2 returns lightning
		public static lightning AddLightningEx(string codeName, bool checkVisibility, real x1, real y1, real z1, real x2, real y2, real z2) { return ; }//native AddLightningEx               takes string codeName, boolean checkVisibility, real x1, real y1, real z1, real x2, real y2, real z2 returns lightning
		public static bool DestroyLightning() { return false; }//native DestroyLightning             takes lightning whichBolt returns boolean
		public static bool MoveLightning(lightning whichBolt, bool checkVisibility, real x1, real y1, real x2, real y2) { return false; }//native MoveLightning                takes lightning whichBolt, boolean checkVisibility, real x1, real y1, real x2, real y2 returns boolean
		public static bool MoveLightningEx(lightning whichBolt, bool checkVisibility, real x1, real y1, real z1, real x2, real y2, real z2) { return false; }//native MoveLightningEx              takes lightning whichBolt, boolean checkVisibility, real x1, real y1, real z1, real x2, real y2, real z2 returns boolean
		public static real GetLightningColorA() { return ; }//native GetLightningColorA           takes lightning whichBolt returns real
		public static real GetLightningColorR() { return ; }//native GetLightningColorR           takes lightning whichBolt returns real
		public static real GetLightningColorG() { return ; }//native GetLightningColorG           takes lightning whichBolt returns real
		public static real GetLightningColorB() { return ; }//native GetLightningColorB           takes lightning whichBolt returns real
		public static bool SetLightningColor(lightning whichBolt, real r, real g, real b, real a) { return false; }//native SetLightningColor            takes lightning whichBolt, real r, real g, real b, real a returns boolean
		public static string GetAbilityEffect(string abilityString, effecttype t, int index) { return ; }//native GetAbilityEffect             takes string abilityString, effecttype t, integer index returns string
		public static string GetAbilityEffectById(int abilityId, effecttype t, int index) { return ; }//native GetAbilityEffectById         takes integer abilityId, effecttype t, integer index returns string
		public static string GetAbilitySound(string abilityString, soundtype t) { return ; }//native GetAbilitySound              takes string abilityString, soundtype t returns string
		public static string GetAbilitySoundById(int abilityId, soundtype t) { return ; }//native GetAbilitySoundById          takes integer abilityId, soundtype t returns string
		public static int GetTerrainCliffLevel(real x, real y) { return 0; }//native GetTerrainCliffLevel         takes real x, real y returns integer
		public static void SetWaterBaseColor(int red, int green, int blue, int alpha) {  }//native SetWaterBaseColor            takes integer red, integer green, integer blue, integer alpha returns nothing
		public static void SetWaterDeforms() {  }//native SetWaterDeforms              takes boolean val returns nothing
		public static int GetTerrainType(real x, real y) { return 0; }//native GetTerrainType               takes real x, real y returns integer
		public static int GetTerrainVariance(real x, real y) { return 0; }//native GetTerrainVariance           takes real x, real y returns integer
		public static void SetTerrainType(real x, real y, int terrainType, int variation, int area, int shape) {  }//native SetTerrainType               takes real x, real y, integer terrainType, integer variation, integer area, integer shape returns nothing
		public static bool IsTerrainPathable(real x, real y, pathingtype t) { return false; }//native IsTerrainPathable            takes real x, real y, pathingtype t returns boolean
		public static void SetTerrainPathable(real x, real y, pathingtype t, bool flag) {  }//native SetTerrainPathable           takes real x, real y, pathingtype t, boolean flag returns nothing
		public static image CreateImage(string file, real sizeX, real sizeY, real sizeZ, real posX, real posY, real posZ, real originX, real originY, real originZ, int imageType) { return ; }//native CreateImage                  takes string file, real sizeX, real sizeY, real sizeZ, real posX, real posY, real posZ, real originX, real originY, real originZ, integer imageType returns image
		public static void DestroyImage() {  }//native DestroyImage                 takes image whichImage returns nothing
		public static void ShowImage(image whichImage, bool flag) {  }//native ShowImage                    takes image whichImage, boolean flag returns nothing
		public static void SetImageConstantHeight(image whichImage, bool flag, real height) {  }//native SetImageConstantHeight       takes image whichImage, boolean flag, real height returns nothing
		public static void SetImagePosition(image whichImage, real x, real y, real z) {  }//native SetImagePosition             takes image whichImage, real x, real y, real z returns nothing
		public static void SetImageColor(image whichImage, int red, int green, int blue, int alpha) {  }//native SetImageColor                takes image whichImage, integer red, integer green, integer blue, integer alpha returns nothing
		public static void SetImageRender(image whichImage, bool flag) {  }//native SetImageRender               takes image whichImage, boolean flag returns nothing
		public static void SetImageRenderAlways(image whichImage, bool flag) {  }//native SetImageRenderAlways         takes image whichImage, boolean flag returns nothing
		public static void SetImageAboveWater(image whichImage, bool flag, bool useWaterAlpha) {  }//native SetImageAboveWater           takes image whichImage, boolean flag, boolean useWaterAlpha returns nothing
		public static void SetImageType(image whichImage, int imageType) {  }//native SetImageType                 takes image whichImage, integer imageType returns nothing
		public static ubersplat CreateUbersplat(real x, real y, string name, int red, int green, int blue, int alpha, bool forcePaused, bool noBirthTime) { return ; }//native CreateUbersplat              takes real x, real y, string name, integer red, integer green, integer blue, integer alpha, boolean forcePaused, boolean noBirthTime returns ubersplat
		public static void DestroyUbersplat() {  }//native DestroyUbersplat             takes ubersplat whichSplat returns nothing
		public static void ResetUbersplat() {  }//native ResetUbersplat               takes ubersplat whichSplat returns nothing
		public static void FinishUbersplat() {  }//native FinishUbersplat              takes ubersplat whichSplat returns nothing
		public static void ShowUbersplat(ubersplat whichSplat, bool flag) {  }//native ShowUbersplat                takes ubersplat whichSplat, boolean flag returns nothing
		public static void SetUbersplatRender(ubersplat whichSplat, bool flag) {  }//native SetUbersplatRender           takes ubersplat whichSplat, boolean flag returns nothing
		public static void SetUbersplatRenderAlways(ubersplat whichSplat, bool flag) {  }//native SetUbersplatRenderAlways     takes ubersplat whichSplat, boolean flag returns nothing
		public static void SetBlight(player whichPlayer, real x, real y, real radius, bool addBlight) {  }//native SetBlight                takes player whichPlayer, real x, real y, real radius, boolean addBlight returns nothing
		public static void SetBlightRect(player whichPlayer, rect r, bool addBlight) {  }//native SetBlightRect            takes player whichPlayer, rect r, boolean addBlight returns nothing
		public static void SetBlightPoint(player whichPlayer, real x, real y, bool addBlight) {  }//native SetBlightPoint           takes player whichPlayer, real x, real y, boolean addBlight returns nothing
		public static void SetBlightLoc(player whichPlayer, location whichLocation, real radius, bool addBlight) {  }//native SetBlightLoc             takes player whichPlayer, location whichLocation, real radius, boolean addBlight returns nothing
		public static int CreateBlightedGoldmine(player id, real x, real y, real face) { return 0; }//native CreateBlightedGoldmine   takes player id, real x, real y, real face returns unit
		public static bool IsPointBlighted(real x, real y) { return false; }//native IsPointBlighted          takes real x, real y returns boolean
		public static void SetDoodadAnimation(real x, real y, real radius, int doodadID, bool nearestOnly, string animName, bool animRandom) {  }//native SetDoodadAnimation       takes real x, real y, real radius, integer doodadID, boolean nearestOnly, string animName, boolean animRandom returns nothing
		public static void SetDoodadAnimationRect(rect r, int doodadID, string animName, bool animRandom) {  }//native SetDoodadAnimationRect   takes rect r, integer doodadID, string animName, boolean animRandom returns nothing
		public static void StartMeleeAI(player num, string script) {  }//native StartMeleeAI         takes player num, string script                 returns nothing
		public static void StartCampaignAI(player num, string script) {  }//native StartCampaignAI      takes player num, string script                 returns nothing
		public static void CommandAI(player num, int command, int data) {  }//native CommandAI            takes player num, integer command, integer data returns nothing
		public static void PauseCompAI(player p, bool pause) {  }//native PauseCompAI          takes player p,   boolean pause                 returns nothing
		public static aidifficulty GetAIDifficulty() { return ; }//native GetAIDifficulty      takes player num                                returns aidifficulty
		public static void RemoveGuardPosition() {  }//native RemoveGuardPosition  takes unit hUnit                                returns nothing
		public static void RecycleGuardPosition() {  }//native RecycleGuardPosition takes unit hUnit                                returns nothing
		public static void RemoveAllGuardPositions() {  }//native RemoveAllGuardPositions takes player num                             returns nothing
		public static void Cheat() {  }//native Cheat            takes string cheatStr returns nothing
		public static bool IsNoVictoryCheat() { return false; }//native IsNoVictoryCheat takes nothing returns boolean
		public static bool IsNoDefeatCheat() { return false; }//native IsNoDefeatCheat  takes nothing returns boolean
		public static void Preload() {  }//native Preload          takes string filename returns nothing
		public static void PreloadEnd() {  }//native PreloadEnd       takes real timeout returns nothing
		public static void PreloadStart() {  }//native PreloadStart     takes nothing returns nothing
		public static void PreloadRefresh() {  }//native PreloadRefresh   takes nothing returns nothing
		public static void PreloadEndEx() {  }//native PreloadEndEx     takes nothing returns nothing
		public static void PreloadGenClear() {  }//native PreloadGenClear  takes nothing returns nothing
		public static void PreloadGenStart() {  }//native PreloadGenStart  takes nothing returns nothing
		public static void PreloadGenEnd() {  }//native PreloadGenEnd    takes string filename returns nothing
		public static void Preloader() {  }//native Preloader        takes string filename returns nothing

	
	}
}

