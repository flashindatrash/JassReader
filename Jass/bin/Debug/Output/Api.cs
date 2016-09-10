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

	
	}
}

