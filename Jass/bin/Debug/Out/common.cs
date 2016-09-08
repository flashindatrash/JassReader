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
private bool DoAiScriptDebug(nothin g);
private int GetAiPlayer(nothin g);
private int GetHeroId(nothin g);
private int GetHeroLevelAI(nothin g);
private int GetUnitCount(int unitid);
private int GetPlayerUnitTypeCount(player p, int unitid);
private int GetUnitCountDone(int unitid);
private int GetTownUnitCount(int id, int tn, bool dn);
private int GetUnitGoldCost(int unitid);
private int GetUnitWoodCost(int unitid);
private int GetUnitBuildTime(int unitid);
private int GetMinesOwned(nothin g);
private int GetGoldOwned(nothin g);
private int TownWithMine(nothin g);
private bool TownHasMine(int townid);
private bool TownHasHall(int townid);
private int GetUpgradeLevel(int id);
private int GetUpgradeGoldCost(int id);
private int GetUpgradeWoodCost(int id);
private int GetNextExpansion(nothin g);
private unit GetMegaTarget(nothin g);
private unit GetBuilding(player p);
private int GetEnemyPower(nothin g);
private void SetAllianceTarget(unit id);
private unit GetAllianceTarget(nothin g);
private bool SetProduce(int qty, int id, int town);
private void Unsummon(unit unitid);
private bool SetExpansion(unit peon, int id);
private bool SetUpgrade(int id);
private void SetHeroLevels(code func);
private void SetNewHeroes(bool state);
private void PurchaseZeppelin(nothin g);
private bool MergeUnits(int qty, int a, int b, int make);
private bool ConvertUnits(int qty, int id);
private void SetCampaignAI(nothin g);
private void SetMeleeAI(nothin g);
private void SetTargetHeroes(bool state);
private void SetPeonsRepair(bool state);
private void SetRandomPaths(bool state);
private void SetDefendPlayer(bool state);
private void SetHeroesFlee(bool state);
private void SetHeroesBuyItems(bool state);
private void SetWatchMegaTargets(bool state);
private void SetIgnoreInjured(bool state);
private void SetHeroesTakeItems(bool state);
private void SetUnitsFlee(bool state);
private void SetGroupsFlee(bool state);
private void SetSlowChopping(bool state);
private void SetCaptainChanges(bool allow);
private void SetSmartArtillery(bool state);
private void SetReplacementCount(int qty);
private void GroupTimedLife(bool allow);
private void RemoveInjuries(nothin g);
private void RemoveSiege(nothin g);
private void InitAssault(nothin g);
private bool AddAssault(int qty, int id);
private bool AddDefenders(int qty, int id);
private unit GetCreepCamp(int min, int max, bool flyers_ok);
private void StartGetEnemyBase(nothin g);
private bool WaitGetEnemyBase(nothin g);
private unit GetEnemyBase(nothin g);
private unit GetExpansionFoe(nothin g);
private unit GetEnemyExpansion(nothin g);
private int GetExpansionX(nothin g);
private int GetExpansionY(nothin g);
private void SetStagePoint(real x, real y);
private void AttackMoveKill(unit target);
private void AttackMoveXY(int x, int y);
private void LoadZepWave(int x, int y);
private bool SuicidePlayer(player id, bool check_full);
private bool SuicidePlayerUnits(player id, bool check_full);
private bool CaptainInCombat(bool attack_captain);
private bool IsTowered(unit target);
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
private bool CaptainIsHome(nothin g);
private bool CaptainIsFull(nothin g);
private bool CaptainIsEmpty(nothin g);
private int CaptainGroupSize(nothin g);
private int CaptainReadiness(nothin g);
private bool CaptainRetreating(nothin g);
private int CaptainReadinessHP(nothin g);
private int CaptainReadinessMa(nothin g);
private bool CaptainAtGoal(nothin g);
private bool CreepsOnMap(nothin g);
private void SuicideUnit(int count, int unitid);
private void SuicideUnitEx(int ct, int uid, int pid);
private void StartThread(code func);
private void Sleep(real seconds);
private bool UnitAlive(unit id);
private bool UnitInvis(unit id);
private int IgnoredUnits(int unitid);
private bool TownThreatened(nothin g);
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
DisplayText(GetAiPlayer(),message);
}
}
//============================================================================
private void TraceI(string message, int val) {
if (trace_on) {
DisplayTextI(GetAiPlayer(),message,val);
}
}
//============================================================================
private void TraceII(string message, int v1, int v2) {
if (trace_on) {
DisplayTextII(GetAiPlayer(),message,v1,v2);
}
}
//============================================================================
private void TraceIII(string message, int v1, int v2, int v3) {
if (trace_on) {
DisplayTextIII(GetAiPlayer(),message,v1,v2,v3);
}
}
//============================================================================
private void InitAI() {
ai_player = Player(GetAiPlayer());
sleep_seconds = 0;
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
Sleep(0.1);
StartThread(peons);
StartThread(attacks);
}
//============================================================================
//  Utility Functions
//============================================================================
private int Min(int A, int B) {
if (A < B) {
return A;
} else {
return B;
}
}
private int Max(int A, int B) {
if (A > B) {
return A;
} else {
return B;
}
}
private void SetZepNextWave() {
zep_next_wave = true;
}
private void SuicideSleep(int seconds) {
sleep_seconds = sleep_seconds - seconds;
if (seconds >= 5) {
Sleep(5);
seconds = seconds - 5;
} else {
Sleep(seconds);
seconds = 0;
}
}
//============================================================================
private int WaitForSignal() {
//xxx
//xxx
Trace("waiting for a signal to begin AI script...\n");
display = true;
Sleep(2);
Sleep(2);
Sleep(2);
Sleep(2);
Sleep(2);
//xxx
//xxx
if (display) {
Trace("signal received, beginning AI script\n");
}
//xxx
cmd = GetLastCommand();
PopLastCommand();
return cmd;
}
//============================================================================
private void SetWoodPeons(int count) {
campaign_wood_peons = count;
}
//============================================================================
private void SetGoldPeons(int count) {
campaign_gold_peons = count;
}
//============================================================================
private void SetHarvestLumber(bool harvest) {
if (harvest) {
campaign_wood_peons = 3;
} else {
campaign_wood_peons = 0;
}
}
//============================================================================
private void SetFormGroupTimeouts(bool state) {
form_group_timeouts = state;
}
//============================================================================
private void DoCampaignFarms(bool state) {
do_campaign_farms = state;
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
build_length = 0;
}
//============================================================================
private void InitAssaultGroup() {
harass_length = 0;
}
//============================================================================
private void InitDefenseGroup() {
defense_length = 0;
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
campaign_gold_peons = 0;
campaign_wood_peons = 0;
}
//============================================================================
private void SetReplacements(int easy, int med, int hard) {
if (difficulty == EASY) {
SetReplacementCount(easy);
} else if (difficulty == NORMAL) {
SetReplacementCount(med);
} else {
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
build_length = build_length + 1;
}
}
//============================================================================
private void SetBuildUnit(int qty, int unitid) {
SetBuildAll(BUILD_UNIT,qty,unitid,-1);
}
//============================================================================
private void SetBuildNext(int qty, int unitid) {
if (has >= qty) {
}
SetBuildAll(BUILD_UNIT,GetUnitCountDone(unitid)+1,unitid,-1);
}
//============================================================================
private void SetBuildUnitEx(int easy, int med, int hard, int unitid) {
if (difficulty == EASY) {
SetBuildAll(BUILD_UNIT,easy,unitid,-1);
} else if (difficulty == NORMAL) {
SetBuildAll(BUILD_UNIT,med,unitid,-1);
} else {
SetBuildAll(BUILD_UNIT,hard,unitid,-1);
}
}
//============================================================================
private void SecondaryTown(int town, int qty, int unitid) {
SetBuildAll(BUILD_UNIT,qty,unitid,town);
}
//============================================================================
private void SecTown(int town, int qty, int unitid) {
SetBuildAll(BUILD_UNIT,qty,unitid,town);
}
//============================================================================
private void SetBuildUpgr(int qty, int unitid) {
if (MeleeDifficulty() != MELEE_NEWBIE || qty == 1) {
SetBuildAll(BUILD_UPGRADE,qty,unitid,-1);
}
}
//============================================================================
private void SetBuildUpgrEx(int easy, int med, int hard, int unitid) {
if (difficulty == EASY) {
SetBuildAll(BUILD_UPGRADE,easy,unitid,-1);
} else if (difficulty == NORMAL) {
SetBuildAll(BUILD_UPGRADE,med,unitid,-1);
} else {
SetBuildAll(BUILD_UPGRADE,hard,unitid,-1);
}
}
//============================================================================
private void SetBuildExpa(int qty, int unitid) {
SetBuildAll(BUILD_EXPAND,qty,unitid,-1);
}
//============================================================================
private bool StartUpgrade(int level, int upgid) {
if (GetUpgradeLevel(upgid) >= level) {
return true;
}
gold_cost = GetUpgradeGoldCost(upgid);
if (total_gold < gold_cost) {
return false;
}
wood_cost = GetUpgradeWoodCost(upgid);
if (total_wood < wood_cost) {
return false;
}
return SetUpgrade(upgid);
}
//============================================================================
private void BuildFactory(int unitid) {
if (GetGold() > 1000 && GetWood() > 500) {
SetBuildUnit(2, unitid);
} else {
SetBuildUnit(1, unitid);
}
}
//============================================================================
private bool HallsCompleted(int unitid) {
return GetUnitCount(unitid) == GetUnitCountDone(unitid);
}
//============================================================================
private void GuardSecondary(int townid, int qty, int unitid) {
if (TownHasHall(townid) && TownHasMine(townid)) {
SecondaryTown(townid, qty, unitid);
}
}
//============================================================================
private int GetUnitCountEx(int unitid, bool only_done, int townid) {
if (townid == -1) {
if (only_done) {
return GetUnitCountDone(unitid);
} else {
return GetUnitCount(unitid);
}
} else {
return GetTownUnitCount(unitid,townid,only_done);
}
}
//============================================================================
private int TownCountEx(int unitid, bool only_done, int townid) {
if (unitid == TOWN_HALL) {
have_qty = have_qty + GetUnitCountEx(KEEP,false,townid) + GetUnitCountEx(CASTLE,false,townid);
} else if (unitid == KEEP) {
have_qty = have_qty  + GetUnitCountEx(CASTLE,false,townid);
} else if (unitid == WATCH_TOWER) {
have_qty = have_qty + GetUnitCountEx(GUARD_TOWER,false,townid) + GetUnitCountEx(CANNON_TOWER,false,townid) + GetUnitCountEx(ARCANE_TOWER,false,townid);
} else if (unitid == PEASANT) {
have_qty = have_qty + GetUnitCountEx(MILITIA,false,townid);
} else if (unitid == GREAT_HALL) {
have_qty = have_qty + GetUnitCountEx(STRONGHOLD,false,townid) + GetUnitCountEx(FORTRESS,false,townid);
} else if (unitid == STRONGHOLD) {
have_qty = have_qty + GetUnitCountEx(FORTRESS,false,townid);
} else if (unitid == HEAD_HUNTER) {
have_qty = have_qty + GetUnitCountEx(BERSERKER,false,townid);
} else if (unitid == SPIRIT_WALKER) {
have_qty = have_qty + GetUnitCountEx(SPIRIT_WALKER_M,false,townid);
} else if (unitid == SPIRIT_WALKER_M) {
have_qty = have_qty + GetUnitCountEx(SPIRIT_WALKER,only_done,townid);
} else if (unitid == NECROPOLIS_1) {
have_qty = have_qty + GetUnitCountEx(NECROPOLIS_2,false,townid) + GetUnitCountEx(NECROPOLIS_3,false,townid);
} else if (unitid == NECROPOLIS_2) {
have_qty = have_qty + GetUnitCountEx(NECROPOLIS_3,false,townid);
} else if (unitid == ZIGGURAT_1) {
have_qty = have_qty + GetUnitCountEx(ZIGGURAT_2,false,townid) + GetUnitCountEx(ZIGGURAT_FROST,false,townid);
} else if (unitid == GARGOYLE) {
have_qty = have_qty + GetUnitCountEx(GARGOYLE_MORPH,false,townid);
} else if (unitid == TREE_LIFE) {
have_qty = have_qty + GetUnitCountEx(TREE_AGES,false,townid) + GetUnitCountEx(TREE_ETERNITY,false,townid);
} else if (unitid == TREE_AGES) {
have_qty = have_qty + GetUnitCountEx(TREE_ETERNITY,false,townid);
} else if (unitid == DRUID_TALON) {
have_qty = have_qty + GetUnitCountEx(DRUID_TALON_M,false,townid);
} else if (unitid == DRUID_TALON_M) {
have_qty = have_qty + GetUnitCountEx(DRUID_TALON,only_done,townid);
} else if (unitid == DRUID_CLAW) {
have_qty = have_qty + GetUnitCountEx(DRUID_CLAW_M,false,townid);
} else if (unitid == DRUID_CLAW_M) {
have_qty = have_qty + GetUnitCountEx(DRUID_CLAW,only_done,townid);
} else if (unitid == ILLIDAN) {
have_qty = have_qty + GetUnitCountEx(ILLIDAN_DEMON,false,townid);
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
private void BasicExpansion(bool build_it, int unitid) {
if (build_it && HallsCompleted(unitid)) {
SetBuildExpa(TownCount(unitid)+1, unitid);
}
}
//============================================================================
private void UpgradeAll(int baseid, int newid) {
SetBuildUnit(TownCountDone(baseid), newid);
}
//============================================================================
private int TownCountTown(int base, int townid) {
return TownCountEx(base,false,townid);
}
//============================================================================
//  FoodPool
//============================================================================
private void FoodPool(int food, bool weak, int id1, int use1, bool strong, int id2, int use2) {
if (strong) {
SetBuildUnit((food - use1 * TownCount(id1)) / use2, id2);
} else if (weak) {
SetBuildUnit((food - use2 * TownCount(id2)) / use1, id1);
}
}
//============================================================================
//  MeleeTownHall
//============================================================================
private void MeleeTownHall(int townid, int unitid) {
if (TownHasMine(townid) && not TownHasHall(townid)) {
SecondaryTown(townid, 1, unitid);
}
}
//============================================================================
private void WaitForUnits(int unitid, int qty) {
Sleep(2);
}
//============================================================================
private bool StartUnit(int ask_qty, int unitid, int town) {
//------------------------------------------------------------------------
// if we have all we're asking for then make nothing
//
if (town == -1) {
have_qty = TownCount(unitid);
} else {
have_qty = TownCountTown(unitid,town);
}
if (have_qty >= ask_qty) {
return true;
}
need_qty = ask_qty - have_qty;
//------------------------------------------------------------------------
// limit the qty we're requesting to the amount of resources available
//
gold_cost = GetUnitGoldCost(unitid);
wood_cost = GetUnitWoodCost(unitid);
if (gold_cost == 0) {
afford_gold = need_qty;
} else {
afford_gold = total_gold / gold_cost;
}
if (aff||d_gold < need_qty) {
afford_qty = afford_gold;
} else {
afford_qty = need_qty;
}
if (wood_cost == 0) {
afford_wood = need_qty;
} else {
afford_wood = total_wood / wood_cost;
}
if (aff||d_wood < aff||d_qty) {
afford_qty = afford_wood;
}
// if we're waiting on gold/wood; pause build orders
if (aff||d_qty < 1) {
return false;
}
//------------------------------------------------------------------------
// whether we make right now what we're requesting or not, assume we will
// and deduct the cost of the units from our fake gold total right away
//
total_gold = total_gold - gold_cost * need_qty;
total_wood = total_wood - wood_cost * need_qty;
if (total_gold < 0) {
total_gold = 0;
}
if (total_wood < 0) {
total_wood = 0;
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
i = i + 1;
}
//============================================================================
private bool StartExpansion(int qty, int hall) {
count = TownCount(hall);
if (count >= qty) {
return true;
}
town = GetNextExpansion();
if (town == -1) {
return true;
}
take_exp = true;
gold_cost = GetUnitGoldCost(hall);
if (gold_cost > total_gold) {
return false;
}
total_gold = total_gold - gold_cost;
if (GetExpansionFoe() != null) {
return true;
}
peon = GetExpansionPeon();
if (peon != null) {
return SetExpansion(peon,hall);
}
return true;
}
//============================================================================
private void OneBuildLoop() {
total_gold = GetGold() - gold_buffer;
total_wood = GetWood();
qty = build_qty [index];
id = build_item[index];
tp = build_type[index];
//--------------------------------------------------------------------
if (tp == BUILD_UNIT) {
if (not StartUnit(qty,id,build_town[index])) {
}
//--------------------------------------------------------------------
} else if (tp == BUILD_UPGRADE) {
StartUpgrade(qty,id);
//--------------------------------------------------------------------
// tp == BUILD_EXPAND
if (not StartExpansion(qty,id)) {
}
}
index = index + 1;
}
//============================================================================
private void StaggerSleep(real base, real spread) {
Sleep(base + spread * I2R(GetAiPlayer()) / I2R(GetPlayers()));
}
//============================================================================
private void BuildLoop() {
OneBuildLoop();
StaggerSleep(1,2);
OneBuildLoop();
Sleep(2);
}
//============================================================================
private void StartBuildLoop() {
StartThread(function BuildLoop);
}
//============================================================================
private void SetInitialWave(int seconds) {
sleep_seconds = seconds;
}
//============================================================================
private void AddSleepSeconds(int seconds) {
sleep_seconds = sleep_seconds + seconds;
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
StartUnit(1,unitid,-1);
}
}
//============================================================================
private void Conversions(int desire, int unitid) {
if (GetUnitCount(unitid) >= desire) {
}
if (unitid == HIPPO_RIDER) {
ConvertNeeds(ARCHER);
ConvertNeeds(HIPPO);
MergeUnits(desire,ARCHER,HIPPO,HIPPO_RIDER);
} else if (unitid == BLK_SPHINX) {
ConvertNeeds(OBS_STATUE);
ConvertUnits(desire,OBS_STATUE);
}
}
//============================================================================
private void SetAssaultGroup(int qty, int max, int unitid) {
Conversions(max,unitid);
if (qty <= 0 && TownCountDone(unitid) == 0) {
}
harass_length = harass_length + 1;
}
//============================================================================
private void Interleave3(int e1, int m1, int h1, int u1, int e2, int m2, int h2, int u2, int e3, int m3, int h3, int u3) {
if (difficulty == EASY) {
q1 = e1;
q2 = e2;
q3 = e3;
} else if (difficulty == NORMAL) {
q1 = m1;
q2 = m2;
q3 = m3;
// difficulty == HARD
q1 = h1;
q2 = h2;
q3 = h3;
}
if (q1 > 0) {
SetAssaultGroup(i1,i1,u1);
q1 = q1 - 1;
i1 = i1 + 1;
}
if (q2 > 0) {
SetAssaultGroup(i2,i2,u2);
q2 = q2 - 1;
i2 = i2 + 1;
}
if (q3 > 0) {
SetAssaultGroup(i3,i3,u3);
q3 = q3 - 1;
i3 = i3 + 1;
}
}
//============================================================================
private void SetMeleeGroup(int unitid) {
if (unitid == hero_id) {
SetAssaultGroup(1,9,unitid);
} else {
SetAssaultGroup((TownCountDone(unitid)*3)/4,20,unitid);
}
}
//============================================================================
private void CampaignDefender(int level, int qty, int unitid) {
if (qty > 0 && difficulty >= level) {
defense_length = defense_length + 1;
Conversions(qty,unitid);
SetBuildUnit(qty,unitid);
}
}
//============================================================================
private void CampaignDefenderEx(int easy, int med, int hard, int unitid) {
if (difficulty == EASY) {
CampaignDefender(EASY,easy,unitid);
} else if (difficulty == NORMAL) {
CampaignDefender(NORMAL,med,unitid);
} else {
CampaignDefender(HARD,hard,unitid);
}
}
//============================================================================
private void CampaignAttacker(int level, int qty, int unitid) {
if (qty > 0 && difficulty >= level) {
SetAssaultGroup(qty,qty,unitid);
}
}
//============================================================================
private void CampaignAttackerEx(int easy, int med, int hard, int unitid) {
if (difficulty == EASY) {
CampaignAttacker(EASY,easy,unitid);
} else if (difficulty == NORMAL) {
CampaignAttacker(NORMAL,med,unitid);
} else {
CampaignAttacker(HARD,hard,unitid);
}
}
//============================================================================
private void FormGroup(int seconds, bool testReady) {
// normally test for CaptainReadiness() of 50%
if (testReady == true) {
readyPercent = 50;
//xxx
} else {
readyPercent = 0;
//xxx
}
//xxx
SuicideSleep(seconds);
InitAssault();
index = 0;
unitid = harass_units[index];
desire = harass_max[index];
count = TownCountDone(unitid);
Conversions(desire,unitid);
if (count >= desire) {
AddAssault(desire,unitid);
} else {
desire = harass_qty[index];
if (count < desire) {
AddAssault(desire,unitid);
} else {
AddAssault(count,unitid);
}
}
index = index + 1;
//xxx
if (f||m_group_timeouts && (sleep_seconds < -60)) {
Trace("exit form group -- timeout\n");
} else if (CaptainInCombat(true)) {
Trace("exit form group -- can't form while already in combat\n");
} else if (CaptainIsFull() && CaptainReadiness() >= readyPercent) {
Trace("exit form group -- ready\n");
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
unitid = harass_units[index];
missing = harass_qty[index] + IgnoredUnits(unitid) - TownCount(unitid);
prep = WavePrepare(unitid) * missing;
if (prep > largest) {
largest = prep;
}
index = index + 1;
//xxx
return largest;
}
//============================================================================
private bool PrepSuicideOnPlayer(int seconds) {
save_length = harass_length;
harass_length = 0;
AddSleepSeconds(seconds);
if (sleep_seconds-wave_prep > 0) {
//xxx
SuicideSleep(sleep_seconds-wave_prep);
}
//xxx
harass_length = save_length;
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
count = count + 1;
//xxx this is what it should have been; do this for next patch?
//call SuicideSleep(1)
}
//============================================================================
private void AttackMoveXYA(int x, int y) {
if (zep_next_wave) {
LoadZepWave(x,y);
zep_next_wave = false;
}
AttackMoveXY(x,y);
SleepUntilAtGoal();
SleepInCombat();
}
//============================================================================
private void SuicideOnPlayerWave() {
//xxx
//xxx
if (allow_signal_ab||t && Comm&&sWaiting() != 0) {
Trace("ABORT -- attack wave override\n");
}
if (CaptainInCombat(true)) {
Trace("done - captain has entered combat\n");
}
if (CaptainIsEmpty()) {
Trace("done - all units are dead\n");
}
if (sleep_seconds < -300) {
Trace("done - timeout, took too long to reach engage the enemy\n");
}
//xxx
SuicideSleep(10);
//xxx
//xxx
if (allow_signal_ab||t && Comm&&sWaiting() != 0) {
Trace("ABORT - attack wave override\n");
}
if (CaptainIsEmpty()) {
Trace("done - all units are dead\n");
}
if (sleep_seconds < -300) {
Trace("done - timeout, took too long to reach engage the enemy\n");
}
//xxx
SuicideSleep(10);
}
//--------------------------------------------------------------------------------------------------
private void CommonSuicideOnPlayer(bool standard, bool bldgs, int seconds, player p, int x, int y) {
if (not PrepSuicideOnPlayer(seconds)) {
}
save_peons = campaign_wood_peons;
campaign_wood_peons = 0;
//xxx
if (allow_signal_ab||t && Comm&&sWaiting() != 0) {
Trace("ABORT -- attack wave override\n");
}
//xxx
FormGroup(5,true);
//xxx
if (st&&ard) {
if (bldgs) {
} else {
}
} else {
AttackMoveXYA(x,y);
}
//xxx
SuicideSleep(5);
campaign_wood_peons = save_peons;
harass_length = 0;
SuicideOnPlayerWave();
}
//--------------------------------------------------------------------------------------------------
private void SuicideOnPlayer(int seconds, player p) {
CommonSuicideOnPlayer(true,true,seconds,p,0,0);
}
//--------------------------------------------------------------------------------------------------
private void SuicideOnUnits(int seconds, player p) {
CommonSuicideOnPlayer(true,false,seconds,p,0,0);
}
//--------------------------------------------------------------------------------------------------
private void SuicideOnPoint(int seconds, player p, int x, int y) {
CommonSuicideOnPlayer(false,false,seconds,p,x,y);
}
//============================================================================
private void SuicideUntilSignal(int seconds, player p) {
AddSleepSeconds(seconds);
if (sleep_seconds-wave_prep > 0) {
SuicideSleep(sleep_seconds-wave_prep);
}
save = campaign_wood_peons;
campaign_wood_peons = 0;
FormGroup(5, true);
SuicideSleep(3);
campaign_wood_peons = save;
SuicideSleep(5);
}
//--------------------------------------------------------------------------------------------------
private void SuicideOnce(int easy, int med, int hard, int unitid) {
if (difficulty == EASY) {
SuicideUnit(easy,unitid);
} else if (difficulty == NORMAL) {
SuicideUnit(med,unitid);
} else {
SuicideUnit(hard,unitid);
}
}
//--------------------------------------------------------------------------------------------------
private void SuicideUnitA(int unitid) {
if (unitid != 0) {
SuicideUnit(1,unitid);
}
Sleep(0.1);
}
//--------------------------------------------------------------------------------------------------
private void SuicideUnitB(int unitid, int playerid) {
if (unitid != 0) {
SuicideUnitEx(1,unitid,playerid);
}
Sleep(0.1);
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
SuicideUnitB(u1,playerid);
SuicideUnitB(u2,playerid);
SuicideUnitB(u3,playerid);
SuicideUnitB(u4,playerid);
SuicideUnitB(u5,playerid);
SuicideUnitB(u6,playerid);
SuicideUnitB(u7,playerid);
SuicideUnitB(u8,playerid);
SuicideUnitB(u9,playerid);
SuicideUnitB(uA,playerid);
}
//--------------------------------------------------------------------------------------------------
private void SuicideOnPlayerEx(int easy, int med, int hard, player p) {
if (difficulty == EASY) {
SuicideOnPlayer(easy,p);
} else if (difficulty == NORMAL) {
SuicideOnPlayer(med,p);
} else {
SuicideOnPlayer(hard,p);
}
}
//--------------------------------------------------------------------------------------------------
private void SuicideOnUnitsEx(int easy, int med, int hard, player p) {
if (difficulty == EASY) {
SuicideOnUnits(easy,p);
} else if (difficulty == NORMAL) {
SuicideOnUnits(med,p);
} else {
SuicideOnUnits(hard,p);
}
}
//--------------------------------------------------------------------------------------------------
private void SuicideOnPointEx(int easy, int med, int hard, player p, int x, int y) {
if (difficulty == EASY) {
SuicideOnPoint(easy,p,x,y);
} else if (difficulty == NORMAL) {
SuicideOnPoint(med,p,x,y);
} else {
SuicideOnPoint(hard,p,x,y);
}
}
//============================================================================
private void ForeverSuicideOnPlayer(int seconds, player p) {
SuicideOnPlayer(seconds,p);
harass_length = length;
}
//============================================================================
private void CommonSleepUntilTargetDead(unit target, bool reform) {
if (not TownThreatened()) {
AttackMoveKill(target);
}
SuicideSleep(3);
if (ref||m && sleep_seconds < -40) {
if (CaptainInCombat(true)) {
sleep_seconds = sleep_seconds + 5;
} else {
sleep_seconds = 0;
FormGroup(1,false);
}
}
}
//============================================================================
private void SleepUntilTargetDead(unit target) {
CommonSleepUntilTargetDead(target,false);
}
//============================================================================
private void ReformUntilTargetDead(unit target) {
CommonSleepUntilTargetDead(target,true);
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
FormGroup(3, true);
AttackMoveKillA(target);
}
//============================================================================
private void MajorCreepAttack() {
SetAllianceTarget(target);
FormGroup(3,true);
AttackMoveKillA(target);
}
//============================================================================
private void CreepAttackEx() {
SetAllianceTarget(target);
FormGroup(3,true);
AttackMoveKillA(target);
}
//============================================================================
private void AnyPlayerAttack() {
hall = GetEnemyExpansion();
if (hall == null) {
StartGetEnemyBase();
SuicideSleep(1);
hall = GetEnemyBase();
}
SetAllianceTarget(hall);
FormGroup(3,true);
AttackMoveKillA(hall);
}
//============================================================================
private void ExpansionAttack() {
FormGroup(3, true);
if (creep == null) {
x = GetExpansionX();
if (x != -1) {
AttackMoveXYA(x,GetExpansionY());
}
} else {
AttackMoveKillA(creep);
}
}
//============================================================================
//  AddSiege
//============================================================================
private void AddSiege() {
SetAssaultGroup(0, 9, SHADE);
SetAssaultGroup(0, 9, MEAT_WAGON);
SetAssaultGroup(0, 9, MORTAR);
SetAssaultGroup(0, 9, TANK);
SetAssaultGroup(0, 9, BALLISTA);
SetAssaultGroup(0, 9, CATAPULT);
}
//===========================================================================
//  GetAllyCount
//============================================================================
private int GetAllyCount(player whichPlayer) {
indexPlayer = Player(playerIndex);
if (whichPlayer != indexPlayer) {
if (GetPlayerAlliance(whichPlayer,indexPlayer,ALLIANCE_PASSIVE)) {
if (GetPlayerAlliance(indexPlayer,whichPlayer,ALLIANCE_PASSIVE)) {
if (GetPlayerStructureCount(indexPlayer,true) > 0) {
count = count + 1;
}
}
}
}
playerIndex = playerIndex + 1;
return count;
}
//============================================================================
//  SingleMeleeAttack
//============================================================================
private void SingleMeleeAttack(bool needs_exp, bool has_siege, bool major_ok, bool air_units) {
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
get_zeppelin = false;
ready_for_zeppelin = false;
}
ready_for_zeppelin = true;
// coordinate with allies
//
allies = GetAllyCount(ai_player) > 0;
if (allies && MeleeDifficulty() != MELEE_NEWBIE) {
common = GetAllianceTarget();
if (common != null) {
//xxx
if (GetMegaTarget() != null) {
AddSiege();
}
FormGroup(3,true);
AttackMoveKillA(common);
SetAllianceTarget(null);
}
}
// take expansions as needed
//
if (needs_exp) {
//xxx
creep = GetExpansionFoe();
if (creep != null) {
//xxx
SetAllianceTarget(creep);
FormGroup(3,true);
AttackMoveKillA(creep);
Sleep(20);
take_exp = false;
}
}
// all-out attack if the player is weak
//
if (MeleeDifficulty() != MELEE_NEWBIE) {
mega = GetMegaTarget();
if (mega != null) {
//xxx
AddSiege();
FormGroup(3,true);
AttackMoveKillA(mega);
}
}
// deny player an expansion
//
hall = GetEnemyExpansion();
daytime = GetFloatGameState(GAME_STATE_TIME_OF_DAY);
can_siege = has_siege and (air_units or (daytime>=4 and daytime<=12));
if (hall!=null && (can_siege || not IsTowered(hall))) {
//xxx
if (MeleeDifficulty() == MELEE_NEWBIE) {
minimum = 3;
} else if (allies && MeleeDifficulty() == MELEE_NORMAL) {
minimum = 1;
} else {
// HARD, INSANE, and NORMAL with no allies
minimum = 0 ;
}
if (exp_seen >= minimum) {
//xxx
exp_seen = 0;
AddSiege();
SetAllianceTarget(hall);
FormGroup(3,true);
AttackMoveKillA(hall);
}
exp_seen = exp_seen + 1;
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
get_zeppelin = true;
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
unitid = harass_units[index];
desire = harass_qty[index] + IgnoredUnits(unitid);
count = TownCount(unitid);
if (count != desire) {
if (not StartUnit(desire,unitid,-1)) {
}
}
index = index + 1;
}
//============================================================================
private void BuildDefenders() {
unitid = defense_units[index];
qty = defense_qty[index];
Conversions(qty,unitid);
AddDefenders(qty,unitid);
index = index + 1;
}
//============================================================================
private void CampaignBasicsA() {
ClearHarvestAI();
if (CaptainInCombat(false)) {
on_wood = 0;
} else {
on_wood = campaign_wood_peons;
}
HarvestGold(0,campaign_gold_peons);
HarvestWood(0,on_wood);
if (harvest_town1) {
HarvestGold(1,campaign_gold_peons);
HarvestWood(1,on_wood);
}
if (harvest_town2) {
HarvestGold(2,campaign_gold_peons);
HarvestWood(2,on_wood);
}
if (harvest_town3) {
HarvestGold(3,campaign_gold_peons);
HarvestWood(3,on_wood);
}
if (do_campaign_farms && FoodUsed()+food_each-1 > food_each*(TownCount(racial_farm)+1)) {
StartUnit(TownCount(racial_farm)+1,racial_farm,-1);
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
StaggerSleep(1,5);
CampaignBasicsA();
Sleep(campaign_basics_speed);
}
//============================================================================
private void CampaignAI(int farms, code heroes) {
if (GetGameDifficulty() == MAP_DIFFICULTY_EASY) {
difficulty = EASY;
SetTargetHeroes(false);
SetUnitsFlee(false);
} else if (GetGameDifficulty() == MAP_DIFFICULTY_NORMAL) {
difficulty = NORMAL;
SetTargetHeroes(false);
SetUnitsFlee(false);
} else if (GetGameDifficulty() == MAP_DIFFICULTY_HARD) {
difficulty = HARD;
SetPeonsRepair(true);
} else {
difficulty = INSANE;
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
Sleep(0.1);
racial_farm = farms;
StartThread(function CampaignBasics);
StartBuildLoop();
}
//============================================================================
private void UnsummonAll() {
bldg = GetBuilding(ai_player);
Unsummon(bldg);
Sleep(2);
}
//============================================================================
//  SkillArrays
//============================================================================
private int SkillArrays() {
if (level > max_hero_level) {
max_hero_level = level;
}
if (GetHeroId() == hero_id) {
return skills1[level];
} else if (GetHeroId() == hero_id2) {
return skills2[level];
} else {
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
i = i + 1;
} else if (index == 2) {
if (hero_id2 != id) {
}
i = i + 1;
} else {
if (hero_id3 != id) {
}
i = i + 1;
}
}
//============================================================================
//  AwaitMeleeHeroes
//============================================================================
private void AwaitMeleeHeroes() {
if (GetUnitCountDone(hero_id2) > 0) {
two_heroes = true;
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
} else if (raceid == RACE_ORC) {
//------------------------------------------------------------------------
//------------------------------------------------------------------------
} else if (raceid == RACE_NIGHTELF) {
//------------------------------------------------------------------------
//------------------------------------------------------------------------
} else if (raceid == RACE_UNDEAD) {
//------------------------------------------------------------------------
} else {
hero_id = 0;
}
if (VersionCompatible(VERSION_FROZEN_THRONE)) {
last = 4;
} else {
last = 3;
}
first = GetRandomInt(1,last);
second = GetRandomInt(1,last-1);
third = GetRandomInt(1,last-2);
hero_id = heroes[first];
hero_id2 = heroes[second];
hero_id3 = heroes[third];
return hero_id;
}

	
	}
}

