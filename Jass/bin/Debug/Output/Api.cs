using System;
using System.Collections.Generic;

namespace Jass {
	
	/* native functions */
	public class Api {

		public static void DebugS(string str) { Engine.Test() }//native DebugS               takes string str                            returns nothing
		public static void DebugFI(string str, int val) { Engine.Test() }//native DebugFI              takes string str, integer val               returns nothing
		public static void DebugUnitID(string str, int val) { Engine.Test() }//native DebugUnitID          takes string str, integer val               returns nothing
		public static void DisplayText(int p, string str) { Engine.Test() }//native DisplayText          takes integer p, string str                 returns nothing
		public static void DisplayTextI(int p, string str, int val) { Engine.Test() }//native DisplayTextI         takes integer p, string str, integer val    returns nothing
		public static void DisplayTextII(int p, string str, int v1, int v2) { Engine.Test() }//native DisplayTextII        takes integer p, string str, integer v1, integer v2 returns nothing
		public static void DisplayTextIII(int p, string str, int v1, int v2, int v3) { Engine.Test() }//native DisplayTextIII       takes integer p, string str, integer v1, integer v2, integer v3 returns nothing
		public static bool DoAiScriptDebug(nothin g) { Engine.Test() }//native DoAiScriptDebug      takes nothing                               returns boolean
		public static int GetAiPlayer(nothin g) { Engine.Test() }//native GetAiPlayer          takes nothing                               returns integer
		public static int GetHeroId(nothin g) { Engine.Test() }//native GetHeroId            takes nothing                               returns integer
		public static int GetHeroLevelAI(nothin g) { Engine.Test() }//native GetHeroLevelAI       takes nothing                               returns integer
		public static int GetUnitCount(int unitid) { Engine.Test() }//native GetUnitCount         takes integer unitid                        returns integer
		public static int GetPlayerUnitTypeCount(player p, int unitid) { Engine.Test() }//native GetPlayerUnitTypeCount takes player p, integer unitid            returns integer
		public static int GetUnitCountDone(int unitid) { Engine.Test() }//native GetUnitCountDone     takes integer unitid                        returns integer
		public static int GetTownUnitCount(int id, int tn, bool dn) { Engine.Test() }//native GetTownUnitCount     takes integer id, integer tn, boolean dn    returns integer
		public static int GetUnitGoldCost(int unitid) { Engine.Test() }//native GetUnitGoldCost      takes integer unitid                        returns integer
		public static int GetUnitWoodCost(int unitid) { Engine.Test() }//native GetUnitWoodCost      takes integer unitid                        returns integer
		public static int GetUnitBuildTime(int unitid) { Engine.Test() }//native GetUnitBuildTime     takes integer unitid                        returns integer
		public static int GetMinesOwned(nothin g) { Engine.Test() }//native GetMinesOwned        takes nothing                               returns integer
		public static int GetGoldOwned(nothin g) { Engine.Test() }//native GetGoldOwned         takes nothing                               returns integer
		public static int TownWithMine(nothin g) { Engine.Test() }//native TownWithMine         takes nothing                               returns integer
		public static bool TownHasMine(int townid) { Engine.Test() }//native TownHasMine          takes integer townid                        returns boolean
		public static bool TownHasHall(int townid) { Engine.Test() }//native TownHasHall          takes integer townid                        returns boolean
		public static int GetUpgradeLevel(int id) { Engine.Test() }//native GetUpgradeLevel      takes integer id                            returns integer
		public static int GetUpgradeGoldCost(int id) { Engine.Test() }//native GetUpgradeGoldCost   takes integer id                            returns integer
		public static int GetUpgradeWoodCost(int id) { Engine.Test() }//native GetUpgradeWoodCost   takes integer id                            returns integer
		public static int GetNextExpansion(nothin g) { Engine.Test() }//native GetNextExpansion     takes nothing                               returns integer
		public static unit GetMegaTarget(nothin g) { Engine.Test() }//native GetMegaTarget        takes nothing                               returns unit
		public static unit GetBuilding(player p) { Engine.Test() }//native GetBuilding          takes player p                              returns unit
		public static int GetEnemyPower(nothin g) { Engine.Test() }//native GetEnemyPower        takes nothing                               returns integer
		public static void SetAllianceTarget(unit id) { Engine.Test() }//native SetAllianceTarget    takes unit id                               returns nothing
		public static unit GetAllianceTarget(nothin g) { Engine.Test() }//native GetAllianceTarget    takes nothing                               returns unit
		public static bool SetProduce(int qty, int id, int town) { Engine.Test() }//native SetProduce           takes integer qty, integer id, integer town returns boolean
		public static void Unsummon(unit unitid) { Engine.Test() }//native Unsummon             takes unit unitid                           returns nothing
		public static bool SetExpansion(unit peon, int id) { Engine.Test() }//native SetExpansion         takes unit peon, integer id                 returns boolean
		public static bool SetUpgrade(int id) { Engine.Test() }//native SetUpgrade           takes integer id                            returns boolean
		public static void SetHeroLevels(code func) { Engine.Test() }//native SetHeroLevels        takes code func                             returns nothing
		public static void SetNewHeroes(bool state) { Engine.Test() }//native SetNewHeroes         takes boolean state                         returns nothing
		public static void PurchaseZeppelin(nothin g) { Engine.Test() }//native PurchaseZeppelin     takes nothing                               returns nothing
		public static bool MergeUnits(int qty, int a, int b, int make) { Engine.Test() }//native MergeUnits           takes integer qty, integer a, integer b, integer make returns boolean
		public static bool ConvertUnits(int qty, int id) { Engine.Test() }//native ConvertUnits         takes integer qty, integer id               returns boolean
		public static void SetCampaignAI(nothin g) { Engine.Test() }//native SetCampaignAI        takes nothing                               returns nothing
		public static void SetMeleeAI(nothin g) { Engine.Test() }//native SetMeleeAI           takes nothing                               returns nothing
		public static void SetTargetHeroes(bool state) { Engine.Test() }//native SetTargetHeroes      takes boolean state                         returns nothing
		public static void SetPeonsRepair(bool state) { Engine.Test() }//native SetPeonsRepair       takes boolean state                         returns nothing
		public static void SetRandomPaths(bool state) { Engine.Test() }//native SetRandomPaths       takes boolean state                         returns nothing
		public static void SetDefendPlayer(bool state) { Engine.Test() }//native SetDefendPlayer      takes boolean state                         returns nothing
		public static void SetHeroesFlee(bool state) { Engine.Test() }//native SetHeroesFlee        takes boolean state                         returns nothing
		public static void SetHeroesBuyItems(bool state) { Engine.Test() }//native SetHeroesBuyItems    takes boolean state                         returns nothing
		public static void SetWatchMegaTargets(bool state) { Engine.Test() }//native SetWatchMegaTargets  takes boolean state                         returns nothing
		public static void SetIgnoreInjured(bool state) { Engine.Test() }//native SetIgnoreInjured     takes boolean state                         returns nothing
		public static void SetHeroesTakeItems(bool state) { Engine.Test() }//native SetHeroesTakeItems   takes boolean state                         returns nothing
		public static void SetUnitsFlee(bool state) { Engine.Test() }//native SetUnitsFlee         takes boolean state                         returns nothing
		public static void SetGroupsFlee(bool state) { Engine.Test() }//native SetGroupsFlee        takes boolean state                         returns nothing
		public static void SetSlowChopping(bool state) { Engine.Test() }//native SetSlowChopping      takes boolean state                         returns nothing
		public static void SetCaptainChanges(bool allow) { Engine.Test() }//native SetCaptainChanges    takes boolean allow                         returns nothing
		public static void SetSmartArtillery(bool state) { Engine.Test() }//native SetSmartArtillery    takes boolean state                         returns nothing
		public static void SetReplacementCount(int qty) { Engine.Test() }//native SetReplacementCount  takes integer qty                           returns nothing
		public static void GroupTimedLife(bool allow) { Engine.Test() }//native GroupTimedLife       takes boolean allow                         returns nothing
		public static void RemoveInjuries(nothin g) { Engine.Test() }//native RemoveInjuries       takes nothing                               returns nothing
		public static void RemoveSiege(nothin g) { Engine.Test() }//native RemoveSiege          takes nothing                               returns nothing
		public static void InitAssault(nothin g) { Engine.Test() }//native InitAssault          takes nothing                               returns nothing
		public static bool AddAssault(int qty, int id) { Engine.Test() }//native AddAssault           takes integer qty, integer id               returns boolean
		public static bool AddDefenders(int qty, int id) { Engine.Test() }//native AddDefenders         takes integer qty, integer id               returns boolean
		public static unit GetCreepCamp(int min, int max, bool flyers_ok) { Engine.Test() }//native GetCreepCamp         takes integer min, integer max, boolean flyers_ok returns unit
		public static void StartGetEnemyBase(nothin g) { Engine.Test() }//native StartGetEnemyBase    takes nothing                               returns nothing
		public static bool WaitGetEnemyBase(nothin g) { Engine.Test() }//native WaitGetEnemyBase     takes nothing                               returns boolean
		public static unit GetEnemyBase(nothin g) { Engine.Test() }//native GetEnemyBase         takes nothing                               returns unit
		public static unit GetExpansionFoe(nothin g) { Engine.Test() }//native GetExpansionFoe      takes nothing                               returns unit
		public static unit GetEnemyExpansion(nothin g) { Engine.Test() }//native GetEnemyExpansion    takes nothing                               returns unit
		public static int GetExpansionX(nothin g) { Engine.Test() }//native GetExpansionX        takes nothing                               returns integer
		public static int GetExpansionY(nothin g) { Engine.Test() }//native GetExpansionY        takes nothing                               returns integer
		public static void SetStagePoint(real x, real y) { Engine.Test() }//native SetStagePoint        takes real x, real y                        returns nothing
		public static void AttackMoveKill(unit target) { Engine.Test() }//native AttackMoveKill       takes unit target                           returns nothing
		public static void AttackMoveXY(int x, int y) { Engine.Test() }//native AttackMoveXY         takes integer x, integer y                  returns nothing
		public static void LoadZepWave(int x, int y) { Engine.Test() }//native LoadZepWave          takes integer x, integer y                  returns nothing
		public static bool SuicidePlayer(player id, bool check_full) { Engine.Test() }//native SuicidePlayer        takes player id, boolean check_full         returns boolean
		public static bool SuicidePlayerUnits(player id, bool check_full) { Engine.Test() }//native SuicidePlayerUnits   takes player id, boolean check_full         returns boolean
		public static bool CaptainInCombat(bool attack_captain) { Engine.Test() }//native CaptainInCombat      takes boolean attack_captain                returns boolean
		public static bool IsTowered(unit target) { Engine.Test() }//native IsTowered            takes unit target                           returns boolean
		public static void ClearHarvestAI(nothin g) { Engine.Test() }//native ClearHarvestAI       takes nothing                               returns nothing
		public static void HarvestGold(int town, int peons) { Engine.Test() }//native HarvestGold          takes integer town, integer peons           returns nothing
		public static void HarvestWood(int town, int peons) { Engine.Test() }//native HarvestWood          takes integer town, integer peons           returns nothing
		public static unit GetExpansionPeon(nothin g) { Engine.Test() }//native GetExpansionPeon     takes nothing                               returns unit
		public static void StopGathering(nothin g) { Engine.Test() }//native StopGathering        takes nothing                               returns nothing
		public static void AddGuardPost(int id, real x, real y) { Engine.Test() }//native AddGuardPost         takes integer id, real x, real y            returns nothing
		public static void FillGuardPosts(nothin g) { Engine.Test() }//native FillGuardPosts       takes nothing                               returns nothing
		public static void ReturnGuardPosts(nothin g) { Engine.Test() }//native ReturnGuardPosts     takes nothing                               returns nothing
		public static void CreateCaptains(nothin g) { Engine.Test() }//native CreateCaptains       takes nothing                               returns nothing
		public static void SetCaptainHome(int which, real x, real y) { Engine.Test() }//native SetCaptainHome       takes integer which, real x, real y         returns nothing
		public static void ResetCaptainLocs(nothin g) { Engine.Test() }//native ResetCaptainLocs     takes nothing                               returns nothing
		public static void ShiftTownSpot(real x, real y) { Engine.Test() }//native ShiftTownSpot        takes real x, real y                        returns nothing
		public static void TeleportCaptain(real x, real y) { Engine.Test() }//native TeleportCaptain      takes real x, real y                        returns nothing
		public static void ClearCaptainTargets(nothin g) { Engine.Test() }//native ClearCaptainTargets  takes nothing                               returns nothing
		public static void CaptainAttack(real x, real y) { Engine.Test() }//native CaptainAttack        takes real x, real y                        returns nothing
		public static void CaptainVsUnits(player id) { Engine.Test() }//native CaptainVsUnits       takes player id                             returns nothing
		public static void CaptainVsPlayer(player id) { Engine.Test() }//native CaptainVsPlayer      takes player id                             returns nothing
		public static void CaptainGoHome(nothin g) { Engine.Test() }//native CaptainGoHome        takes nothing                               returns nothing
		public static bool CaptainIsHome(nothin g) { Engine.Test() }//native CaptainIsHome        takes nothing                               returns boolean
		public static bool CaptainIsFull(nothin g) { Engine.Test() }//native CaptainIsFull        takes nothing                               returns boolean
		public static bool CaptainIsEmpty(nothin g) { Engine.Test() }//native CaptainIsEmpty       takes nothing                               returns boolean
		public static int CaptainGroupSize(nothin g) { Engine.Test() }//native CaptainGroupSize     takes nothing                               returns integer
		public static int CaptainReadiness(nothin g) { Engine.Test() }//native CaptainReadiness     takes nothing                               returns integer
		public static bool CaptainRetreating(nothin g) { Engine.Test() }//native CaptainRetreating    takes nothing                               returns boolean
		public static int CaptainReadinessHP(nothin g) { Engine.Test() }//native CaptainReadinessHP   takes nothing                               returns integer
		public static int CaptainReadinessMa(nothin g) { Engine.Test() }//native CaptainReadinessMa   takes nothing                               returns integer
		public static bool CaptainAtGoal(nothin g) { Engine.Test() }//native CaptainAtGoal        takes nothing                               returns boolean
		public static bool CreepsOnMap(nothin g) { Engine.Test() }//native CreepsOnMap          takes nothing                               returns boolean
		public static void SuicideUnit(int count, int unitid) { Engine.Test() }//native SuicideUnit          takes integer count, integer unitid         returns nothing
		public static void SuicideUnitEx(int ct, int uid, int pid) { Engine.Test() }//native SuicideUnitEx        takes integer ct, integer uid, integer pid  returns nothing
		public static void StartThread(code func) { Engine.Test() }//native StartThread          takes code func                             returns nothing
		public static void Sleep(real seconds) { Engine.Test() }//native Sleep                takes real seconds                          returns nothing
		public static bool UnitAlive(unit id) { Engine.Test() }//native UnitAlive            takes unit id                               returns boolean
		public static bool UnitInvis(unit id) { Engine.Test() }//native UnitInvis            takes unit id                               returns boolean
		public static int IgnoredUnits(int unitid) { Engine.Test() }//native IgnoredUnits         takes integer unitid                        returns integer
		public static bool TownThreatened(nothin g) { Engine.Test() }//native TownThreatened       takes nothing                               returns boolean
		public static void DisablePathing(nothin g) { Engine.Test() }//native DisablePathing       takes nothing                               returns nothing
		public static void SetAmphibious(nothin g) { Engine.Test() }//native SetAmphibious        takes nothing                               returns nothing
		public static int CommandsWaiting(nothin g) { Engine.Test() }//native CommandsWaiting      takes nothing                               returns integer
		public static int GetLastCommand(nothin g) { Engine.Test() }//native GetLastCommand       takes nothing                               returns integer
		public static int GetLastData(nothin g) { Engine.Test() }//native GetLastData          takes nothing                               returns integer
		public static void PopLastCommand(nothin g) { Engine.Test() }//native PopLastCommand       takes nothing                               returns nothing
		public static int MeleeDifficulty(nothin g) { Engine.Test() }//native MeleeDifficulty      takes nothing                               returns integer

	
	}
}

