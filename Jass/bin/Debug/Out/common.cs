using System;

namespace Jass {

	public class common {

		//==================================================================================================
//  $Id: common.ai,v 1.68 2003/05/12 02:34:18 bfitch Exp $
//==================================================================================================
private void DebugS(string str);
private void DebugFI(string str, int val);
private void DebugUnitID(string str, int val);
private void DisplayText(int p, string str);
private void DisplayTextI(int p, string str, int val);
private void DisplayTextII(int p, string str, int v1, int v2);
private void DisplayTextIII(int p, string str, int v1, int v2, int v3);
private boolean DoAiScriptDebug(nothin g);
private int GetAiPlayer(nothin g);
private int GetHeroId(nothin g);
private int GetHeroLevelAI(nothin g);
private int GetUnitCount(int unitid);
private int GetPlayerUnitTypeCount(player p, int unitid);
private int GetUnitCountDone(int unitid);
private int GetTownUnitCount(int id, int tn, boolean dn);
private int GetUnitGoldCost(int unitid);
private int GetUnitWoodCost(int unitid);
private int GetUnitBuildTime(int unitid);
private int GetMinesOwned(nothin g);
private int GetGoldOwned(nothin g);
private int TownWithMine(nothin g);
private boolean TownHasMine(int townid);
private boolean TownHasHall(int townid);
private int GetUpgradeLevel(int id);
private int GetUpgradeGoldCost(int id);
private int GetUpgradeWoodCost(int id);
private int GetNextExpansion(nothin g);
private unit GetMegaTarget(nothin g);
private unit GetBuilding(player p);
private int GetEnemyPower(nothin g);
private void SetAllianceTarget(unit id);
private unit GetAllianceTarget(nothin g);
private boolean SetProduce(int qty, int id, int town);
private void Unsummon(unit unitid);
private boolean SetExpansion(unit peon, int id);
private boolean SetUpgrade(int id);
private void SetHeroLevels(code func);
private void SetNewHeroes(boolean state);
private void PurchaseZeppelin(nothin g);
private boolean MergeUnits(int qty, int a, int b, int make);
private boolean ConvertUnits(int qty, int id);
private void SetCampaignAI(nothin g);
private void SetMeleeAI(nothin g);
private void SetTargetHeroes(boolean state);
private void SetPeonsRepair(boolean state);
private void SetRandomPaths(boolean state);
private void SetDefendPlayer(boolean state);
private void SetHeroesFlee(boolean state);
private void SetHeroesBuyItems(boolean state);
private void SetWatchMegaTargets(boolean state);
private void SetIgnoreInjured(boolean state);
private void SetHeroesTakeItems(boolean state);
private void SetUnitsFlee(boolean state);
private void SetGroupsFlee(boolean state);
private void SetSlowChopping(boolean state);
private void SetCaptainChanges(boolean allow);
private void SetSmartArtillery(boolean state);
private void SetReplacementCount(int qty);
private void GroupTimedLife(boolean allow);
private void RemoveInjuries(nothin g);
private void RemoveSiege(nothin g);
private void InitAssault(nothin g);
private boolean AddAssault(int qty, int id);
private boolean AddDefenders(int qty, int id);
private unit GetCreepCamp(int min, int max, boolean flyers_ok);
private void StartGetEnemyBase(nothin g);
private boolean WaitGetEnemyBase(nothin g);
private unit GetEnemyBase(nothin g);
private unit GetExpansionFoe(nothin g);
private unit GetEnemyExpansion(nothin g);
private int GetExpansionX(nothin g);
private int GetExpansionY(nothin g);
private void SetStagePoint(real x, real y);
private void AttackMoveKill(unit target);
private void AttackMoveXY(int x, int y);
private void LoadZepWave(int x, int y);
private boolean SuicidePlayer(player id, boolean check_full);
private boolean SuicidePlayerUnits(player id, boolean check_full);
private boolean CaptainInCombat(boolean attack_captain);
private boolean IsTowered(unit target);
private void ClearHarvestAI(nothin g);
private void HarvestGold(int town, int peons);
private void HarvestWood(int town, int peons);
private unit GetExpansionPeon(nothin g);
private void StopGathering(nothin g);
private void AddGuardPost(int id, real x, real y);
private void FillGuardPosts(nothin g);
private void ReturnGuardPosts(nothin g);
private void CreateCaptains(nothin g);
private void SetCaptainHome(int which, real x, real y);
private void ResetCaptainLocs(nothin g);
private void ShiftTownSpot(real x, real y);
private void TeleportCaptain(real x, real y);
private void ClearCaptainTargets(nothin g);
private void CaptainAttack(real x, real y);
private void CaptainVsUnits(player id);
private void CaptainVsPlayer(player id);
private void CaptainGoHome(nothin g);
private boolean CaptainIsHome(nothin g);
private boolean CaptainIsFull(nothin g);
private boolean CaptainIsEmpty(nothin g);
private int CaptainGroupSize(nothin g);
private int CaptainReadiness(nothin g);
private boolean CaptainRetreating(nothin g);
private int CaptainReadinessHP(nothin g);
private int CaptainReadinessMa(nothin g);
private boolean CaptainAtGoal(nothin g);
private boolean CreepsOnMap(nothin g);
private void SuicideUnit(int count, int unitid);
private void SuicideUnitEx(int ct, int uid, int pid);
private void StartThread(code func);
private void Sleep(real seconds);
private boolean UnitAlive(unit id);
private boolean UnitInvis(unit id);
private int IgnoredUnits(int unitid);
private boolean TownThreatened(nothin g);
private void DisablePathing(nothin g);
private void SetAmphibious(nothin g);
private int CommandsWaiting(nothin g);
private int GetLastCommand(nothin g);
private int GetLastData(nothin g);
private void PopLastCommand(nothin g);
private int MeleeDifficulty(nothin g);
//============================================================================
//  Globals for all AI scripts
//============================================================================
//--------------------------------------------------------------------
//  HUMANS
//--------------------------------------------------------------------
// human heroes
// human hero abilities
// special human heroes
// human units
// special human units
// human buildings
// human upgrades
//--------------------------------------------------------------------
//  ORCS
//--------------------------------------------------------------------
// orc heroes
// special orc heroes
// orc hero abilities
// orc units
// orc buildings
// orc upgrades
// Warcraft 2 orc units
// special orc units
//--------------------------------------------------------------------
//  UNDEAD
//--------------------------------------------------------------------
// undead heroes
// special undead heroes
// undead hero abilities
// undead units
// undead buildings
// normal
// upgraded once
// full upgrade
// normal
// upgraded
// frost tower
// undead upgrades
//--------------------------------------------------------------------
//  ELVES
//--------------------------------------------------------------------
// elf heroes
// special elf heroes
// elf hero abilities
// elf units
// special elf units
// elf buildings
// special elf buildings
// elf upgrades
//--------------------------------------------------------------------
// Neutral
//--------------------------------------------------------------------
//--------------------------------------------------------------------
// NAGA
//--------------------------------------------------------------------
// naga heroes
// naga units
// old names
// peon
// weak ranged
// weak air
// caster
// knight
// footman
// siege
// royal guard
// naga buildings
// town hall
// farm
// sirens & couatls
// myrm, snap dragon, hydra
// tower
// altar
// naga upgrades
//--------------------------------------------------------------------
// not used
//--------------------------------------------------------------------
// usually for potion money
//============================================================================
private player PlayerEx(int slot) {
return Player(slot-1);
}
//============================================================================
private void Trace(string message) {
if (trace_on) {
}
}
//============================================================================
private void TraceI(string message, int val) {
if (trace_on) {
}
}
//============================================================================
private void TraceII(string message, int v1, int v2) {
if (trace_on) {
}
}
//============================================================================
private void TraceIII(string message, int v1, int v2, int v3) {
if (trace_on) {
}
}
//============================================================================
private void InitAI() {
StopGathering();
}
//============================================================================
private void StandardAI(code heroes, code peons, code attacks) {
InitAI();
SetMeleeAI();
SetDefendPlayer(true);
SetGroupsFlee(not isNewbie);
SetHeroesBuyItems(not isNewbie);
SetHeroesFlee(true);
SetHeroesTakeItems(true);
SetIgnoreInjured(true);
SetPeonsRepair(true);
SetSmartArtillery(not isNewbie);
SetTargetHeroes(not isNewbie);
SetUnitsFlee(not isNewbie);
SetWatchMegaTargets(true);
CreateCaptains();
SetHeroLevels(heroes);
StartThread(peons);
StartThread(attacks);
}
//============================================================================
//  Utility Functions
//============================================================================
private int Min(int A, int B) {
if (A < B) {
return A;
return B;
}
}
private int Max(int A, int B) {
if (A > B) {
return A;
return B;
}
}
private void SetZepNextWave() {
}
private void SuicideSleep(int seconds) {
if (seconds >= 5) {
Sleep(5);
Sleep(seconds);
}
}
//============================================================================
private int WaitForSignal() {
//xxx
//xxx
Sleep(2);
Sleep(2);
Sleep(2);
Sleep(2);
Sleep(2);
//xxx
//xxx
if (display) {
}
//xxx
PopLastCommand();
return cmd;
}
//============================================================================
private void SetWoodPeons(int count) {
}
//============================================================================
private void SetGoldPeons(int count) {
}
//============================================================================
private void SetHarvestLumber(boolean harvest) {
if (harvest) {
}
}
//============================================================================
private void SetFormGroupTimeouts(boolean state) {
}
//============================================================================
private void DoCampaignFarms(boolean state) {
}
//============================================================================
private unit GetMinorCreep() {
return GetCreepCamp(0,9,false);
}
//============================================================================
private unit GetMajorCreep() {
return GetCreepCamp(10,100,allow_air_creeps);
}
//============================================================================
private int GetGold() {
return GetPlayerState(ai_player,PLAYER_STATE_RESOURCE_GOLD);
}
//============================================================================
private int GetWood() {
return GetPlayerState(ai_player,PLAYER_STATE_RESOURCE_LUMBER);
}
//============================================================================
private void InitBuildArray() {
}
//============================================================================
private void InitAssaultGroup() {
}
//============================================================================
private void InitDefenseGroup() {
}
//============================================================================
private void InitMeleeGroup() {
InitAssaultGroup();
RemoveInjuries();
RemoveSiege();
}
//============================================================================
private void PrepFullSuicide() {
InitAssaultGroup();
InitDefenseGroup();
}
//============================================================================
private void SetReplacements(int easy, int med, int hard) {
if (difficulty == EASY) {
SetReplacementCount(easy);
SetReplacementCount(med);
SetReplacementCount(hard);
}
}
//============================================================================
private void StartTownBuilder(code func) {
StartThread(func);
}
//============================================================================
private void SetBuildAll(int t, int qty, int unitid, int town) {
if (qty > 0) {
}
}
//============================================================================
private void SetBuildUnit(int qty, int unitid) {
}
//============================================================================
private void SetBuildNext(int qty, int unitid) {
if (has >= qty) {
}
}
//============================================================================
private void SetBuildUnitEx(int easy, int med, int hard, int unitid) {
if (difficulty == EASY) {
}
}
//============================================================================
private void SecondaryTown(int town, int qty, int unitid) {
}
//============================================================================
private void SecTown(int town, int qty, int unitid) {
}
//============================================================================
private void SetBuildUpgr(int qty, int unitid) {
if (MeleeDifficulty() != MELEE_NEWBIE || qty == 1) {
}
}
//============================================================================
private void SetBuildUpgrEx(int easy, int med, int hard, int unitid) {
if (difficulty == EASY) {
}
}
//============================================================================
private void SetBuildExpa(int qty, int unitid) {
}
//============================================================================
private boolean StartUpgrade(int level, int upgid) {
if (GetUpgradeLevel(upgid) >= level) {
return true;
}
if (total_gold < gold_cost) {
return false;
}
if (total_wood < wood_cost) {
return false;
}
return SetUpgrade(upgid);
}
//============================================================================
private void BuildFactory(int unitid) {
if (GetGold() > 1000 && GetWood() > 500) {
}
}
//============================================================================
private boolean HallsCompleted(int unitid) {
return GetUnitCount(unitid) == GetUnitCountDone(unitid);
}
//============================================================================
private void GuardSecondary(int townid, int qty, int unitid) {
if (TownHasHall(townid) && TownHasMine(townid)) {
}
}
//============================================================================
private int GetUnitCountEx(int unitid, boolean only_done, int townid) {
if (townid == -1) {
if (only_done) {
return GetUnitCountDone(unitid);
return GetUnitCount(unitid);
}
return GetTownUnitCount(unitid,townid,only_done);
}
}
//============================================================================
private int TownCountEx(int unitid, boolean only_done, int townid) {
if (unitid == TOWN_HALL) {
}
return have_qty;
}
//============================================================================
private int TownCountDone(int base) {
return TownCountEx(base,true,-1);
}
//============================================================================
private int TownCount(int base) {
return TownCountEx(base,false,-1);
}
//============================================================================
private void BasicExpansion(boolean build_it, int unitid) {
if (build_it && HallsCompleted(unitid)) {
}
}
//============================================================================
private void UpgradeAll(int baseid, int newid) {
}
//============================================================================
private int TownCountTown(int base, int townid) {
return TownCountEx(base,false,townid);
}
//============================================================================
//  FoodPool
//============================================================================
private void FoodPool(int food, boolean weak, int id1, int use1, boolean strong, int id2, int use2) {
if (strong) {
}
}
//============================================================================
//  MeleeTownHall
//============================================================================
private void MeleeTownHall(int townid, int unitid) {
if (TownHasMine(townid) && not TownHasHall(townid)) {
}
}
//============================================================================
private void WaitForUnits(int unitid, int qty) {
Sleep(2);
}
//============================================================================
private boolean StartUnit(int ask_qty, int unitid, int town) {
//------------------------------------------------------------------------
// if we have all we're asking for then make nothing
//
if (town == -1) {
}
if (have_qty >= ask_qty) {
return true;
}
//------------------------------------------------------------------------
// limit the qty we're requesting to the amount of resources available
//
if (gold_cost == 0) {
}
if (aff||d_gold < need_qty) {
}
if (wood_cost == 0) {
}
if (aff||d_wood < aff||d_qty) {
}
// if we're waiting on gold/wood; pause build orders
if (aff||d_qty < 1) {
return false;
}
//------------------------------------------------------------------------
// whether we make right now what we're requesting or not, assume we will
// and deduct the cost of the units from our fake gold total right away
//
if (total_gold < 0) {
}
if (total_wood < 0) {
}
//------------------------------------------------------------------------
// give the AI a chance to make the units (it may not be able to right now
// but that doesn't stop us from trying other units after this as long
// as we have enough money to make this AND the needed, unbuilt ones)
//
return SetProduce(afford_qty,unitid,town);
}
//============================================================================
private void WaitForTown(int towns, int townid) {
Sleep(10);
}
//============================================================================
private boolean StartExpansion(int qty, int hall) {
if (count >= qty) {
return true;
}
if (town == -1) {
return true;
}
if (gold_cost > total_gold) {
return false;
}
if (GetExpansionFoe() != null) {
return true;
}
if (peon != null) {
return SetExpansion(peon,hall);
}
return true;
}
//============================================================================
private void OneBuildLoop() {
//--------------------------------------------------------------------
if (tp == BUILD_UNIT) {
if (not StartUnit(qty,id,build_town[index])) {
}
//--------------------------------------------------------------------
//--------------------------------------------------------------------
// tp == BUILD_EXPAND
if (not StartExpansion(qty,id)) {
}
}
}
//============================================================================
private void StaggerSleep(real base, real spread) {
}
//============================================================================
private void BuildLoop() {
OneBuildLoop();
OneBuildLoop();
Sleep(2);
}
//============================================================================
private void StartBuildLoop() {
StartThread(function BuildLoop);
}
//============================================================================
private void SetInitialWave(int seconds) {
}
//============================================================================
private void AddSleepSeconds(int seconds) {
}
//============================================================================
private void SleepForever() {
//xxx
Sleep(100);
}
//============================================================================
private void PlayGame() {
StartBuildLoop();
SleepForever();
}
//============================================================================
private void ConvertNeeds(int unitid) {
if (GetUnitCount(unitid) < 1) {
}
}
//============================================================================
private void Conversions(int desire, int unitid) {
if (GetUnitCount(unitid) >= desire) {
}
if (unitid == HIPPO_RIDER) {
ConvertNeeds(ARCHER);
ConvertNeeds(HIPPO);
ConvertNeeds(OBS_STATUE);
}
}
//============================================================================
private void SetAssaultGroup(int qty, int max, int unitid) {
if (qty <= 0 && TownCountDone(unitid) == 0) {
}
}
//============================================================================
private void Interleave3(int e1, int m1, int h1, int u1, int e2, int m2, int h2, int u2, int e3, int m3, int h3, int u3) {
if (difficulty == EASY) {
// difficulty == HARD
}
if (q1 > 0) {
}
if (q2 > 0) {
}
if (q3 > 0) {
}
}
//============================================================================
private void SetMeleeGroup(int unitid) {
if (unitid == hero_id) {
}
}
//============================================================================
private void CampaignDefender(int level, int qty, int unitid) {
if (qty > 0 && difficulty >= level) {
}
}
//============================================================================
private void CampaignDefenderEx(int easy, int med, int hard, int unitid) {
if (difficulty == EASY) {
}
}
//============================================================================
private void CampaignAttacker(int level, int qty, int unitid) {
if (qty > 0 && difficulty >= level) {
}
}
//============================================================================
private void CampaignAttackerEx(int easy, int med, int hard, int unitid) {
if (difficulty == EASY) {
}
}
//============================================================================
private void FormGroup(int seconds, boolean testReady) {
// normally test for CaptainReadiness() of 50%
if (testReady == true) {
//xxx
//xxx
}
//xxx
SuicideSleep(seconds);
InitAssault();
if (count >= desire) {
if (count < desire) {
}
}
//xxx
if (f||m_group_timeouts && (sleep_seconds < -60)) {
}
//xxx
// time out and send group anyway if time has already expired
}
//============================================================================
private int WavePrepare(int unitid) {
return GetUnitBuildTime(unitid);
}
//============================================================================
private int PrepTime() {
if (prep > largest) {
}
//xxx
return largest;
}
//============================================================================
private boolean PrepSuicideOnPlayer(int seconds) {
AddSleepSeconds(seconds);
if (sleep_seconds-wave_prep > 0) {
//xxx
}
//xxx
if (harass_length < 1) {
//xxx
return false;
}
return true;
}
//============================================================================
private void SleepUntilAtGoal() {
// reached goal
// failed to path and returned home
// all units died
SuicideSleep(3);
}
//============================================================================
private void SleepInCombat() {
// goal is cleared
// duh
SuicideSleep(1);
//xxx this is what it should have been; do this for next patch?
//call SuicideSleep(1)
}
//============================================================================
private void AttackMoveXYA(int x, int y) {
if (zep_next_wave) {
}
SleepUntilAtGoal();
SleepInCombat();
}
//============================================================================
private void SuicideOnPlayerWave() {
//xxx
//xxx
if (allow_signal_ab||t && Comm&&sWaiting() != 0) {
}
if (CaptainInCombat(true)) {
}
if (CaptainIsEmpty()) {
}
if (sleep_seconds < -300) {
}
//xxx
SuicideSleep(10);
//xxx
//xxx
if (allow_signal_ab||t && Comm&&sWaiting() != 0) {
}
if (CaptainIsEmpty()) {
}
if (sleep_seconds < -300) {
}
//xxx
SuicideSleep(10);
}
//--------------------------------------------------------------------------------------------------
private void CommonSuicideOnPlayer(boolean standard, boolean bldgs, int seconds, player p, int x, int y) {
if (not PrepSuicideOnPlayer(seconds)) {
}
//xxx
if (allow_signal_ab||t && Comm&&sWaiting() != 0) {
}
//xxx
//xxx
if (st&&ard) {
if (bldgs) {
}
}
//xxx
SuicideSleep(5);
SuicideOnPlayerWave();
}
//--------------------------------------------------------------------------------------------------
private void SuicideOnPlayer(int seconds, player p) {
}
//--------------------------------------------------------------------------------------------------
private void SuicideOnUnits(int seconds, player p) {
}
//--------------------------------------------------------------------------------------------------
private void SuicideOnPoint(int seconds, player p, int x, int y) {
}
//============================================================================
private void SuicideUntilSignal(int seconds, player p) {
AddSleepSeconds(seconds);
if (sleep_seconds-wave_prep > 0) {
}
SuicideSleep(3);
SuicideSleep(5);
}
//--------------------------------------------------------------------------------------------------
private void SuicideOnce(int easy, int med, int hard, int unitid) {
if (difficulty == EASY) {
}
}
//--------------------------------------------------------------------------------------------------
private void SuicideUnitA(int unitid) {
if (unitid != 0) {
}
}
//--------------------------------------------------------------------------------------------------
private void SuicideUnitB(int unitid, int playerid) {
if (unitid != 0) {
}
}
//--------------------------------------------------------------------------------------------------
private void SuicideUnits(int u1, int u2, int u3, int u4, int u5, int u6, int u7, int u8, int u9, int uA) {
//xxx
PrepFullSuicide();
SuicideUnitA(u1);
SuicideUnitA(u2);
SuicideUnitA(u3);
SuicideUnitA(u4);
SuicideUnitA(u5);
SuicideUnitA(u6);
SuicideUnitA(u7);
SuicideUnitA(u8);
SuicideUnitA(u9);
SuicideUnitA(uA);
}
//--------------------------------------------------------------------------------------------------
private void SuicideUnitsEx(int playerid, int u1, int u2, int u3, int u4, int u5, int u6, int u7, int u8, int u9, int uA) {
//xxx
PrepFullSuicide();
}
//--------------------------------------------------------------------------------------------------
private void SuicideOnPlayerEx(int easy, int med, int hard, player p) {
if (difficulty == EASY) {
}
}
//--------------------------------------------------------------------------------------------------
private void SuicideOnUnitsEx(int easy, int med, int hard, player p) {
if (difficulty == EASY) {
}
}
//--------------------------------------------------------------------------------------------------
private void SuicideOnPointEx(int easy, int med, int hard, player p, int x, int y) {
if (difficulty == EASY) {
}
}
//============================================================================
private void ForeverSuicideOnPlayer(int seconds, player p) {
}
//============================================================================
private void CommonSleepUntilTargetDead(unit target, boolean reform) {
if (not TownThreatened()) {
AttackMoveKill(target);
}
SuicideSleep(3);
if (ref||m && sleep_seconds < -40) {
if (CaptainInCombat(true)) {
}
}
}
//============================================================================
private void SleepUntilTargetDead(unit target) {
}
//============================================================================
private void ReformUntilTargetDead(unit target) {
}
//============================================================================
private void AttackMoveKillA(unit target) {
if (target == null) {
SuicideSleep(3);
}
AttackMoveKill(target);
ReformUntilTargetDead(target);
SleepInCombat();
}
//============================================================================
private void MinorCreepAttack() {
SetAllianceTarget(target);
AttackMoveKillA(target);
}
//============================================================================
private void MajorCreepAttack() {
SetAllianceTarget(target);
AttackMoveKillA(target);
}
//============================================================================
private void CreepAttackEx() {
SetAllianceTarget(target);
AttackMoveKillA(target);
}
//============================================================================
private void AnyPlayerAttack() {
if (hall == null) {
StartGetEnemyBase();
SuicideSleep(1);
}
SetAllianceTarget(hall);
AttackMoveKillA(hall);
}
//============================================================================
private void ExpansionAttack() {
if (creep == null) {
if (x != -1) {
}
AttackMoveKillA(creep);
}
}
//============================================================================
//  AddSiege
//============================================================================
private void AddSiege() {
}
//===========================================================================
//  GetAllyCount
//============================================================================
private int GetAllyCount(player whichPlayer) {
if (whichPlayer != indexPlayer) {
if (GetPlayerAlliance(whichPlayer,indexPlayer,ALLIANCE_PASSIVE)) {
if (GetPlayerAlliance(indexPlayer,whichPlayer,ALLIANCE_PASSIVE)) {
if (GetPlayerStructureCount(indexPlayer,true) > 0) {
}
}
}
}
return count;
}
//============================================================================
//  SingleMeleeAttack
//============================================================================
private void SingleMeleeAttack(boolean needs_exp, boolean has_siege, boolean major_ok, boolean air_units) {
//xxx
if (TownThreatened()) {
//xxx
Sleep(2);
}
// purchase zeppelins
//
if (get_zeppelin && GetGold() > 300 && GetWood() > 100) {
//xxx
PurchaseZeppelin();
}
// coordinate with allies
//
if (allies && MeleeDifficulty() != MELEE_NEWBIE) {
if (common != null) {
//xxx
if (GetMegaTarget() != null) {
AddSiege();
}
AttackMoveKillA(common);
SetAllianceTarget(null);
}
}
// take expansions as needed
//
if (needs_exp) {
//xxx
if (creep != null) {
//xxx
SetAllianceTarget(creep);
AttackMoveKillA(creep);
Sleep(20);
}
}
// all-out attack if the player is weak
//
if (MeleeDifficulty() != MELEE_NEWBIE) {
if (mega != null) {
//xxx
AddSiege();
AttackMoveKillA(mega);
}
}
// deny player an expansion
//
if (hall!=null && (can_siege || not IsTowered(hall))) {
//xxx
if (MeleeDifficulty() == MELEE_NEWBIE) {
// HARD, INSANE, and NORMAL with no allies
}
if (exp_seen >= minimum) {
//xxx
AddSiege();
SetAllianceTarget(hall);
AttackMoveKillA(hall);
}
}
// attack player's main base when siege is available
//
if (can_siege) {
//xxx
AddSiege();
AnyPlayerAttack();
}
// extended, more specific method of determining creep levels
//
if (min_creeps != -1) {
//xxx
CreepAttackEx();
}
// nothing better to do, so kill a creep camp
//
if (maj||_ok) {
//xxx
MajorCreepAttack();
}
//xxx
MinorCreepAttack();
}
//============================================================================
private void GetZeppelin() {
if (ready_f||_zeppelin) {
}
}
//============================================================================
private int FoodUsed() {
return GetPlayerState(ai_player,PLAYER_STATE_RESOURCE_FOOD_USED);
}
//============================================================================
private int FoodCap() {
return GetPlayerState(ai_player,PLAYER_STATE_RESOURCE_FOOD_CAP);
}
//============================================================================
private int FoodSpace() {
return FoodCap() - FoodUsed();
}
//============================================================================
private int FoodAvail(int base) {
return GetFoodMade(racial_farm) * TownCount(racial_farm) + GetFoodMade(base) * TownCount(base);
}
//============================================================================
private void BuildAttackers() {
if (count != desire) {
if (not StartUnit(desire,unitid,-1)) {
}
}
}
//============================================================================
private void BuildDefenders() {
}
//============================================================================
private void CampaignBasicsA() {
ClearHarvestAI();
if (CaptainInCombat(false)) {
}
if (harvest_town1) {
}
if (harvest_town2) {
}
if (harvest_town3) {
}
if (do_campaign_farms && FoodUsed()+food_each-1 > food_each*(TownCount(racial_farm)+1)) {
}
if (build_campaign_attackers) {
BuildAttackers();
}
if (not CaptainInCombat(false)) {
BuildDefenders();
}
FillGuardPosts();
ReturnGuardPosts();
}
//============================================================================
private void CampaignBasics() {
Sleep(1);
CampaignBasicsA();
CampaignBasicsA();
Sleep(campaign_basics_speed);
}
//============================================================================
private void CampaignAI(int farms, code heroes) {
if (GetGameDifficulty() == MAP_DIFFICULTY_EASY) {
SetTargetHeroes(false);
SetUnitsFlee(false);
SetTargetHeroes(false);
SetUnitsFlee(false);
SetPeonsRepair(true);
}
InitAI();
InitBuildArray();
InitAssaultGroup();
CreateCaptains();
SetNewHeroes(false);
if (heroes != null) {
SetHeroLevels(heroes);
}
SetHeroesFlee(false);
SetGroupsFlee(false);
SetSlowChopping(true);
GroupTimedLife(false);
SetCampaignAI();
StartThread(function CampaignBasics);
StartBuildLoop();
}
//============================================================================
private void UnsummonAll() {
Unsummon(bldg);
Sleep(2);
}
//============================================================================
//  SkillArrays
//============================================================================
private int SkillArrays() {
if (level > max_hero_level) {
}
if (GetHeroId() == hero_id) {
return skills1[level];
return skills2[level];
return skills3[level];
}
}
//--------------------------------------------------------------------------------------------------
//  SetSkillArray
//--------------------------------------------------------------------------------------------------
private void SetSkillArray(int index, int id) {
if (index == 1) {
if (hero_id != id) {
}
if (hero_id2 != id) {
}
if (hero_id3 != id) {
}
}
}
//============================================================================
//  AwaitMeleeHeroes
//============================================================================
private void AwaitMeleeHeroes() {
if (GetUnitCountDone(hero_id2) > 0) {
}
Sleep(1);
}
//============================================================================
//  PickMeleeHero
//============================================================================
private int PickMeleeHero(race raceid) {
//------------------------------------------------------------------------
if (raceid == RACE_HUMAN) {
//------------------------------------------------------------------------
//------------------------------------------------------------------------
//------------------------------------------------------------------------
//------------------------------------------------------------------------
//------------------------------------------------------------------------
//------------------------------------------------------------------------
//------------------------------------------------------------------------
}
if (VersionCompatible(VERSION_FROZEN_THRONE)) {
}
return hero_id;
}

	
	}
}

