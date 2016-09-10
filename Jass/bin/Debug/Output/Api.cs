using System;
using System.Collections.Generic;

namespace Jass {
	
	/* native functions */
	public class Api {

		private void DebugS(string str); //native DebugS               takes string str                            returns nothing
		private void DebugFI(string str, int val); //native DebugFI              takes string str, integer val               returns nothing
		private void DebugUnitID(string str, int val); //native DebugUnitID          takes string str, integer val               returns nothing
		private void DisplayText(int p, string str); //native DisplayText          takes integer p, string str                 returns nothing
		private void DisplayTextI(int p, string str, int val); //native DisplayTextI         takes integer p, string str, integer val    returns nothing
		private void DisplayTextII(int p, string str, int v1, int v2); //native DisplayTextII        takes integer p, string str, integer v1, integer v2 returns nothing
		private void DisplayTextIII(int p, string str, int v1, int v2, int v3); //native DisplayTextIII       takes integer p, string str, integer v1, integer v2, integer v3 returns nothing
		private bool DoAiScriptDebug(nothin g); //native DoAiScriptDebug      takes nothing                               returns boolean
		private int GetAiPlayer(nothin g); //native GetAiPlayer          takes nothing                               returns integer
		private int GetHeroId(nothin g); //native GetHeroId            takes nothing                               returns integer
		private int GetHeroLevelAI(nothin g); //native GetHeroLevelAI       takes nothing                               returns integer
		private int GetUnitCount(int unitid); //native GetUnitCount         takes integer unitid                        returns integer
		private int GetPlayerUnitTypeCount(player p, int unitid); //native GetPlayerUnitTypeCount takes player p, integer unitid            returns integer
		private int GetUnitCountDone(int unitid); //native GetUnitCountDone     takes integer unitid                        returns integer
		private int GetTownUnitCount(int id, int tn, bool dn); //native GetTownUnitCount     takes integer id, integer tn, boolean dn    returns integer
		private int GetUnitGoldCost(int unitid); //native GetUnitGoldCost      takes integer unitid                        returns integer
		private int GetUnitWoodCost(int unitid); //native GetUnitWoodCost      takes integer unitid                        returns integer
		private int GetUnitBuildTime(int unitid); //native GetUnitBuildTime     takes integer unitid                        returns integer
		private int GetMinesOwned(nothin g); //native GetMinesOwned        takes nothing                               returns integer
		private int GetGoldOwned(nothin g); //native GetGoldOwned         takes nothing                               returns integer
		private int TownWithMine(nothin g); //native TownWithMine         takes nothing                               returns integer
		private bool TownHasMine(int townid); //native TownHasMine          takes integer townid                        returns boolean
		private bool TownHasHall(int townid); //native TownHasHall          takes integer townid                        returns boolean
		private int GetUpgradeLevel(int id); //native GetUpgradeLevel      takes integer id                            returns integer
		private int GetUpgradeGoldCost(int id); //native GetUpgradeGoldCost   takes integer id                            returns integer
		private int GetUpgradeWoodCost(int id); //native GetUpgradeWoodCost   takes integer id                            returns integer
		private int GetNextExpansion(nothin g); //native GetNextExpansion     takes nothing                               returns integer
		private unit GetMegaTarget(nothin g); //native GetMegaTarget        takes nothing                               returns unit
		private unit GetBuilding(player p); //native GetBuilding          takes player p                              returns unit
		private int GetEnemyPower(nothin g); //native GetEnemyPower        takes nothing                               returns integer
		private void SetAllianceTarget(unit id); //native SetAllianceTarget    takes unit id                               returns nothing
		private unit GetAllianceTarget(nothin g); //native GetAllianceTarget    takes nothing                               returns unit
		private bool SetProduce(int qty, int id, int town); //native SetProduce           takes integer qty, integer id, integer town returns boolean
		private void Unsummon(unit unitid); //native Unsummon             takes unit unitid                           returns nothing
		private bool SetExpansion(unit peon, int id); //native SetExpansion         takes unit peon, integer id                 returns boolean
		private bool SetUpgrade(int id); //native SetUpgrade           takes integer id                            returns boolean
		private void SetHeroLevels(code func); //native SetHeroLevels        takes code func                             returns nothing
		private void SetNewHeroes(bool state); //native SetNewHeroes         takes boolean state                         returns nothing
		private void PurchaseZeppelin(nothin g); //native PurchaseZeppelin     takes nothing                               returns nothing
		private bool MergeUnits(int qty, int a, int b, int make); //native MergeUnits           takes integer qty, integer a, integer b, integer make returns boolean
		private bool ConvertUnits(int qty, int id); //native ConvertUnits         takes integer qty, integer id               returns boolean
		private void SetCampaignAI(nothin g); //native SetCampaignAI        takes nothing                               returns nothing
		private void SetMeleeAI(nothin g); //native SetMeleeAI           takes nothing                               returns nothing
		private void SetTargetHeroes(bool state); //native SetTargetHeroes      takes boolean state                         returns nothing
		private void SetPeonsRepair(bool state); //native SetPeonsRepair       takes boolean state                         returns nothing
		private void SetRandomPaths(bool state); //native SetRandomPaths       takes boolean state                         returns nothing
		private void SetDefendPlayer(bool state); //native SetDefendPlayer      takes boolean state                         returns nothing
		private void SetHeroesFlee(bool state); //native SetHeroesFlee        takes boolean state                         returns nothing
		private void SetHeroesBuyItems(bool state); //native SetHeroesBuyItems    takes boolean state                         returns nothing
		private void SetWatchMegaTargets(bool state); //native SetWatchMegaTargets  takes boolean state                         returns nothing
		private void SetIgnoreInjured(bool state); //native SetIgnoreInjured     takes boolean state                         returns nothing
		private void SetHeroesTakeItems(bool state); //native SetHeroesTakeItems   takes boolean state                         returns nothing
		private void SetUnitsFlee(bool state); //native SetUnitsFlee         takes boolean state                         returns nothing
		private void SetGroupsFlee(bool state); //native SetGroupsFlee        takes boolean state                         returns nothing
		private void SetSlowChopping(bool state); //native SetSlowChopping      takes boolean state                         returns nothing
		private void SetCaptainChanges(bool allow); //native SetCaptainChanges    takes boolean allow                         returns nothing
		private void SetSmartArtillery(bool state); //native SetSmartArtillery    takes boolean state                         returns nothing
		private void SetReplacementCount(int qty); //native SetReplacementCount  takes integer qty                           returns nothing
		private void GroupTimedLife(bool allow); //native GroupTimedLife       takes boolean allow                         returns nothing
		private void RemoveInjuries(nothin g); //native RemoveInjuries       takes nothing                               returns nothing
		private void RemoveSiege(nothin g); //native RemoveSiege          takes nothing                               returns nothing
		private void InitAssault(nothin g); //native InitAssault          takes nothing                               returns nothing
		private bool AddAssault(int qty, int id); //native AddAssault           takes integer qty, integer id               returns boolean
		private bool AddDefenders(int qty, int id); //native AddDefenders         takes integer qty, integer id               returns boolean
		private unit GetCreepCamp(int min, int max, bool flyers_ok); //native GetCreepCamp         takes integer min, integer max, boolean flyers_ok returns unit
		private void StartGetEnemyBase(nothin g); //native StartGetEnemyBase    takes nothing                               returns nothing
		private bool WaitGetEnemyBase(nothin g); //native WaitGetEnemyBase     takes nothing                               returns boolean
		private unit GetEnemyBase(nothin g); //native GetEnemyBase         takes nothing                               returns unit
		private unit GetExpansionFoe(nothin g); //native GetExpansionFoe      takes nothing                               returns unit
		private unit GetEnemyExpansion(nothin g); //native GetEnemyExpansion    takes nothing                               returns unit
		private int GetExpansionX(nothin g); //native GetExpansionX        takes nothing                               returns integer
		private int GetExpansionY(nothin g); //native GetExpansionY        takes nothing                               returns integer
		private void SetStagePoint(real x, real y); //native SetStagePoint        takes real x, real y                        returns nothing
		private void AttackMoveKill(unit target); //native AttackMoveKill       takes unit target                           returns nothing
		private void AttackMoveXY(int x, int y); //native AttackMoveXY         takes integer x, integer y                  returns nothing
		private void LoadZepWave(int x, int y); //native LoadZepWave          takes integer x, integer y                  returns nothing
		private bool SuicidePlayer(player id, bool check_full); //native SuicidePlayer        takes player id, boolean check_full         returns boolean
		private bool SuicidePlayerUnits(player id, bool check_full); //native SuicidePlayerUnits   takes player id, boolean check_full         returns boolean
		private bool CaptainInCombat(bool attack_captain); //native CaptainInCombat      takes boolean attack_captain                returns boolean
		private bool IsTowered(unit target); //native IsTowered            takes unit target                           returns boolean
		private void ClearHarvestAI(nothin g); //native ClearHarvestAI       takes nothing                               returns nothing
		private void HarvestGold(int town, int peons); //native HarvestGold          takes integer town, integer peons           returns nothing
		private void HarvestWood(int town, int peons); //native HarvestWood          takes integer town, integer peons           returns nothing
		private unit GetExpansionPeon(nothin g); //native GetExpansionPeon     takes nothing                               returns unit
		private void StopGathering(nothin g); //native StopGathering        takes nothing                               returns nothing
		private void AddGuardPost(int id, real x, real y); //native AddGuardPost         takes integer id, real x, real y            returns nothing
		private void FillGuardPosts(nothin g); //native FillGuardPosts       takes nothing                               returns nothing
		private void ReturnGuardPosts(nothin g); //native ReturnGuardPosts     takes nothing                               returns nothing
		private void CreateCaptains(nothin g); //native CreateCaptains       takes nothing                               returns nothing
		private void SetCaptainHome(int which, real x, real y); //native SetCaptainHome       takes integer which, real x, real y         returns nothing
		private void ResetCaptainLocs(nothin g); //native ResetCaptainLocs     takes nothing                               returns nothing
		private void ShiftTownSpot(real x, real y); //native ShiftTownSpot        takes real x, real y                        returns nothing
		private void TeleportCaptain(real x, real y); //native TeleportCaptain      takes real x, real y                        returns nothing
		private void ClearCaptainTargets(nothin g); //native ClearCaptainTargets  takes nothing                               returns nothing
		private void CaptainAttack(real x, real y); //native CaptainAttack        takes real x, real y                        returns nothing
		private void CaptainVsUnits(player id); //native CaptainVsUnits       takes player id                             returns nothing
		private void CaptainVsPlayer(player id); //native CaptainVsPlayer      takes player id                             returns nothing
		private void CaptainGoHome(nothin g); //native CaptainGoHome        takes nothing                               returns nothing
		private bool CaptainIsHome(nothin g); //native CaptainIsHome        takes nothing                               returns boolean
		private bool CaptainIsFull(nothin g); //native CaptainIsFull        takes nothing                               returns boolean
		private bool CaptainIsEmpty(nothin g); //native CaptainIsEmpty       takes nothing                               returns boolean
		private int CaptainGroupSize(nothin g); //native CaptainGroupSize     takes nothing                               returns integer
		private int CaptainReadiness(nothin g); //native CaptainReadiness     takes nothing                               returns integer
		private bool CaptainRetreating(nothin g); //native CaptainRetreating    takes nothing                               returns boolean
		private int CaptainReadinessHP(nothin g); //native CaptainReadinessHP   takes nothing                               returns integer
		private int CaptainReadinessMa(nothin g); //native CaptainReadinessMa   takes nothing                               returns integer
		private bool CaptainAtGoal(nothin g); //native CaptainAtGoal        takes nothing                               returns boolean
		private bool CreepsOnMap(nothin g); //native CreepsOnMap          takes nothing                               returns boolean
		private void SuicideUnit(int count, int unitid); //native SuicideUnit          takes integer count, integer unitid         returns nothing
		private void SuicideUnitEx(int ct, int uid, int pid); //native SuicideUnitEx        takes integer ct, integer uid, integer pid  returns nothing
		private void StartThread(code func); //native StartThread          takes code func                             returns nothing
		private void Sleep(real seconds); //native Sleep                takes real seconds                          returns nothing
		private bool UnitAlive(unit id); //native UnitAlive            takes unit id                               returns boolean
		private bool UnitInvis(unit id); //native UnitInvis            takes unit id                               returns boolean
		private int IgnoredUnits(int unitid); //native IgnoredUnits         takes integer unitid                        returns integer
		private bool TownThreatened(nothin g); //native TownThreatened       takes nothing                               returns boolean
		private void DisablePathing(nothin g); //native DisablePathing       takes nothing                               returns nothing
		private void SetAmphibious(nothin g); //native SetAmphibious        takes nothing                               returns nothing
		private int CommandsWaiting(nothin g); //native CommandsWaiting      takes nothing                               returns integer
		private int GetLastCommand(nothin g); //native GetLastCommand       takes nothing                               returns integer
		private int GetLastData(nothin g); //native GetLastData          takes nothing                               returns integer
		private void PopLastCommand(nothin g); //native PopLastCommand       takes nothing                               returns nothing
		private int MeleeDifficulty(nothin g); //native MeleeDifficulty      takes nothing                               returns integer

	
	}
}

