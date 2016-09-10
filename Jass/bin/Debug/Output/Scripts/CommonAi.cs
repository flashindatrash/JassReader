using System;
using System.Collections.Generic;

namespace Jass {

	public class CommonAi {

		//==================================================================================================
		//  $Id: common.ai,v 1.68 2003/05/12 02:34:18 bfitch Exp $
		//==================================================================================================
		//============================================================================
		//  Globals for all AI scripts
		//============================================================================
		
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
			bool isNewbie = (MeleeDifficulty() == MELEE_NEWBIE);
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
			while (true) {
				if (seconds <= 0) { break; }
				if (allow_signal_ab||t && Comm&&sWaiting() != 0) { break; }
				if (seconds >= 5) {
					Sleep(5);
					seconds = seconds - 5;
				} else {
					Sleep(seconds);
					seconds = 0;
				}
			}
		}
		//============================================================================
		private int WaitForSignal() {
			int cmd;
			bool display = false;//xxx
			while (true) {
				if (Comm&&sWaiting() != 0) { break; }
				//xxx
				Trace("waiting for a signal to begin AI script...\n");
				display = true;
				Sleep(2);
				if (Comm&&sWaiting() != 0) { break; }
				Sleep(2);
				if (Comm&&sWaiting() != 0) { break; }
				Sleep(2);
				if (Comm&&sWaiting() != 0) { break; }
				Sleep(2);
				if (Comm&&sWaiting() != 0) { break; }
				Sleep(2);
				//xxx
			}
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
				build_qty[build_length] = qty;
				build_type[build_length] = t;
				build_item[build_length] = unitid;
				build_town[build_length] = town;
				build_length = build_length + 1;
			}
		}
		//============================================================================
		private void SetBuildUnit(int qty, int unitid) {
			SetBuildAll(BUILD_UNIT,qty,unitid,-1);
		}
		//============================================================================
		private void SetBuildNext(int qty, int unitid) {
			int has = GetUnitCount(unitid);
			if (has >= qty) {
				return;
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
			int gold_cost;
			int wood_cost;
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
			int have_qty = GetUnitCountEx(unitid,only_done,townid);
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
			while (true) {
				if (TownCountDone(unitid) == qty) { break; }
				Sleep(2);
			}
		}
		//============================================================================
		private bool StartUnit(int ask_qty, int unitid, int town) {
			int have_qty;
			int need_qty;
			int afford_gold;
			int afford_wood;
			int afford_qty;
			int gold_cost;
			int wood_cost;
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
			int i = 0;
			while (true) {
				Sleep(10);
				if (TownCount(townid) >= towns) { break; }
				i = i + 1;
				if (i == 12) { break; }
			}
		}
		//============================================================================
		private bool StartExpansion(int qty, int hall) {
			int count;
			int town;
			unit peon;
			int gold_cost;
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
			int index = 0;
			int qty;
			int id;
			int tp;
			total_gold = GetGold() - gold_buffer;
			total_wood = GetWood();
			while (true) {
				if (index == build_length) { break; }
				qty = build_qty [index];
				id = build_item[index];
				tp = build_type[index];
				//--------------------------------------------------------------------
				if (tp == BUILD_UNIT) {
					if (not StartUnit(qty,id,build_town[index])) {
						return;
					}
					//--------------------------------------------------------------------
				} else if (tp == BUILD_UPGRADE) {
					StartUpgrade(qty,id);
					//--------------------------------------------------------------------
				} else {// tp == BUILD_EXPAND
					if (not StartExpansion(qty,id)) {
						return;
					}
				}
				index = index + 1;
			}
		}
		//============================================================================
		private void StaggerSleep(real base, real spread) {
			Sleep(base + spread * I2R(GetAiPlayer()) / I2R(GetPlayers()));
		}
		//============================================================================
		private void BuildLoop() {
			OneBuildLoop();
			StaggerSleep(1,2);
			while (true) {
				OneBuildLoop();
				Sleep(2);
			}
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
			Trace("going to sleep forever\n");//xxx
			while (true) {
				Sleep(100);
			}
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
				return;
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
				return;
			}
			harass_qty[harass_length] = qty;
			harass_max[harass_length] = max;
			harass_units[harass_length] = unitid;
			harass_length = harass_length + 1;
		}
		//============================================================================
		private void Interleave3(int e1, int m1, int h1, int u1, int e2, int m2, int h2, int u2, int e3, int m3, int h3, int u3) {
			int i1 = 1;
			int i2 = 1;
			int i3 = 1;
			int q1;
			int q2;
			int q3;
			if (difficulty == EASY) {
				q1 = e1;
				q2 = e2;
				q3 = e3;
			} else if (difficulty == NORMAL) {
				q1 = m1;
				q2 = m2;
				q3 = m3;
			} else {// difficulty == HARD
				q1 = h1;
				q2 = h2;
				q3 = h3;
			}
			while (true) {
				if (q1<=0 && q2<=0 && q3<=0) { break; }
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
				defense_qty[defense_length] = qty;
				defense_units[defense_length] = unitid;
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
			int index;
			int count;
			int unitid;
			int desire;
			int readyPercent;
			// normally test for CaptainReadiness() of 50%
			if (testReady == true) {
				readyPercent = 50;
				Trace("forming group, requiring healthy guys\n");//xxx
			} else {
				readyPercent = 0;
				Trace("forming group, unit health not important\n");//xxx
			}
			Trace("trying to gather forces\n");//xxx
			while (true) {
				SuicideSleep(seconds);
				InitAssault();
				index = 0;
				while (true) {
					if (index == harass_length) { break; }
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
				}
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
				if (f||m_group_timeouts && (sleep_seconds < -60)) { break; }
				if (CaptainInCombat(true)) { break; }
				if (CaptainIsFull() && CaptainReadiness() >= readyPercent) { break; }
			}
		}
		//============================================================================
		private int WavePrepare(int unitid) {
			return GetUnitBuildTime(unitid);
		}
		//============================================================================
		private int PrepTime() {
			int unitid;
			int missing;
			int prep;
			int count;
			int largest = 30;
			int index = 0;
			while (true) {
				if (index == harass_length) { break; }
				unitid = harass_units[index];
				missing = harass_qty[index] + IgnoredUnits(unitid) - TownCount(unitid);
				prep = WavePrepare(unitid) * missing;
				if (prep > largest) {
					largest = prep;
				}
				index = index + 1;
			}
			TraceI("next wave will require around %d seconds to build and gather\n",largest);//xxx
			return largest;
		}
		//============================================================================
		private bool PrepSuicideOnPlayer(int seconds) {
			int wave_prep = PrepTime();
			int save_length;
			save_length = harass_length;
			harass_length = 0;
			AddSleepSeconds(seconds);
			if (sleep_seconds-wave_prep > 0) {
				TraceI("going to sleep for %d seconds before gathering next attack wave\n",sleep_seconds-wave_prep);//xxx
				SuicideSleep(sleep_seconds-wave_prep);
			}
			Trace("preparing suicide attack wave\n");//xxx
			harass_length = save_length;
			if (harass_length < 1) {
				Trace("ERROR - no units specificed, exiting early\n");//xxx
				return false;
			}
			return true;
		}
		//============================================================================
		private void SleepUntilAtGoal() {
			while (true) {
				if (CaptainRetreating()) { break; }
				if (CaptainAtGoal()) { break; }// reached goal
				if (CaptainIsHome()) { break; }// failed to path and returned home
				if (CaptainIsEmpty()) { break; }// all units died
				SuicideSleep(3);
			}
		}
		//============================================================================
		private void SleepInCombat() {
			int count = 0;
			Trace("SleepInCombat\n");
			while (true) {
				while (true) {
					if (not CaptainInCombat(true)) { break; }// goal is cleared
					if (CaptainIsEmpty()) { break; }// duh
					SuicideSleep(1);
				}
				count = count + 1;
				if (count >= 8) { break; }
				//xxx this is what it should have been; do this for next patch?
				//call SuicideSleep(1)
			}
			Trace("exit SleepInCombat\n");
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
			Trace("waiting for attack wave to enter combat\n");//xxx
			while (true) {
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
				if (allow_signal_ab||t && Comm&&sWaiting() != 0) { break; }
				if (CaptainInCombat(true)) { break; }
				if (CaptainIsEmpty()) { break; }
				SuicideSleep(10);
				if (sleep_seconds < -300) { break; }
			}
			Trace("waiting for attack wave to die\n");//xxx
			while (true) {
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
				if (allow_signal_ab||t && Comm&&sWaiting() != 0) { break; }
				if (CaptainIsEmpty()) { break; }
				SuicideSleep(10);
				if (sleep_seconds < -300) { break; }
			}
		}
		//--------------------------------------------------------------------------------------------------
		private void CommonSuicideOnPlayer(bool standard, bool bldgs, int seconds, player p, int x, int y) {
			int save_peons;
			if (not PrepSuicideOnPlayer(seconds)) {
				return;
			}
			save_peons = campaign_wood_peons;
			campaign_wood_peons = 0;
			while (true) {
				//xxx
				if (allow_signal_ab||t && Comm&&sWaiting() != 0) {
					Trace("ABORT -- attack wave override\n");
				}
				//xxx
				if (allow_signal_ab||t && Comm&&sWaiting() != 0) { break; }
				while (true) {
					if (allow_signal_ab||t && Comm&&sWaiting() != 0) { break; }
					FormGroup(5,true);
					if (sleep_seconds <= 0) { break; }
					TraceI("waiting %d seconds before suicide\n",sleep_seconds);//xxx
				}
				if (st&&ard) {
					if (bldgs) {
						if (SuicidePlayer(p,sleep_seconds >= -60)) { break; }
					} else {
						if (SuicidePlayerUnits(p,sleep_seconds >= -60)) { break; }
					}
				} else {
					AttackMoveXYA(x,y);
				}
				TraceI("waiting %d seconds before timeout\n",60+sleep_seconds);//xxx
				SuicideSleep(5);
			}
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
			int save;
			int wave_prep = PrepTime();
			while (true) {
				AddSleepSeconds(seconds);
				if (sleep_seconds-wave_prep > 0) {
					SuicideSleep(sleep_seconds-wave_prep);
				}
				save = campaign_wood_peons;
				campaign_wood_peons = 0;
				while (true) {
					while (true) {
						FormGroup(5, true);
						if (sleep_seconds <= 0) { break; }
						if (Comm&&sWaiting() != 0) { break; }
					}
					if (SuicidePlayer(p,sleep_seconds >= -60)) { break; }
					if (Comm&&sWaiting() != 0) { break; }
					SuicideSleep(3);
				}
				campaign_wood_peons = save;
				while (true) {
					if (CaptainIsEmpty()) { break; }
					if (Comm&&sWaiting() != 0) { break; }
					SuicideSleep(5);
				}
				if (Comm&&sWaiting() != 0) { break; }
			}
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
			Trace("MASS SUICIDE - this script is now technically done\n");//xxx
			PrepFullSuicide();
			while (true) {
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
		}
		//--------------------------------------------------------------------------------------------------
		private void SuicideUnitsEx(int playerid, int u1, int u2, int u3, int u4, int u5, int u6, int u7, int u8, int u9, int uA) {
			Trace("MASS SUICIDE - this script is now technically done\n");//xxx
			PrepFullSuicide();
			while (true) {
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
			int length = harass_length;
			while (true) {
				if (allow_signal_ab||t && Comm&&sWaiting() != 0) { break; }
				SuicideOnPlayer(seconds,p);
				harass_length = length;
			}
		}
		//============================================================================
		private void CommonSleepUntilTargetDead(unit target, bool reform) {
			while (true) {
				if (CaptainRetreating()) { break; }
				if (CaptainReadinessHP() <= 40) { break; }
				if (not UnitAlive(target)) { break; }
				if (UnitInvis(target) && not IsUnitDetected(target,ai_player)) { break; }
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
		}
		//============================================================================
		private void SleepUntilTargetDead(unit target) {
			CommonSleepUntilTargetDead(target,false);
		}
		//============================================================================
		private void ReformUntilTargetDead(unit target) {
			Trace("ReformUntilTargetDead\n");
			CommonSleepUntilTargetDead(target,true);
		}
		//============================================================================
		private void AttackMoveKillA(unit target) {
			if (target == null) {
				SuicideSleep(3);
				return;
			}
			Trace("AttackMoveKillA\n");
			AttackMoveKill(target);
			ReformUntilTargetDead(target);
			SleepInCombat();
		}
		//============================================================================
		private void MinorCreepAttack() {
			unit target = GetMinorCreep();
			SetAllianceTarget(target);
			FormGroup(3, true);
			AttackMoveKillA(target);
		}
		//============================================================================
		private void MajorCreepAttack() {
			unit target = GetMajorCreep();
			SetAllianceTarget(target);
			FormGroup(3,true);
			AttackMoveKillA(target);
		}
		//============================================================================
		private void CreepAttackEx() {
			unit target = GetCreepCamp(min_creeps,max_creeps,allow_air_creeps);
			SetAllianceTarget(target);
			FormGroup(3,true);
			AttackMoveKillA(target);
		}
		//============================================================================
		private void AnyPlayerAttack() {
			unit hall;
			hall = GetEnemyExpansion();
			if (hall == null) {
				StartGetEnemyBase();
				while (true) {
					if (not WaitGetEnemyBase()) { break; }
					SuicideSleep(1);
				}
				hall = GetEnemyBase();
			}
			SetAllianceTarget(hall);
			FormGroup(3,true);
			AttackMoveKillA(hall);
		}
		//============================================================================
		private void ExpansionAttack() {
			unit creep = GetExpansionFoe();
			int x;
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
			int playerIndex = 0;
			int count = 0;
			player indexPlayer;
			while (true) {
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
				if (playerIndex == 12) { break; }
			}
			return count;
		}
		//============================================================================
		//  SingleMeleeAttack
		//============================================================================
		private void SingleMeleeAttack(bool needs_exp, bool has_siege, bool major_ok, bool air_units) {
			bool can_siege;
			real daytime;
			unit hall;
			unit mega;
			unit creep;
			unit common;
			int minimum;
			bool allies;
			Trace("===SingleMeleeAttack===\n");//xxx
			if (TownThreatened()) {
				Trace("sleep 2, town threatened\n");//xxx
				Sleep(2);
				return;
			}
			// purchase zeppelins
			//
			if (get_zeppelin && GetGold() > 300 && GetWood() > 100) {
				Trace("purchase zep\n");//xxx
				PurchaseZeppelin();
				get_zeppelin = false;
				ready_for_zeppelin = false;
				return;
			}
			ready_for_zeppelin = true;
			// coordinate with allies
			//
			allies = GetAllyCount(ai_player) > 0;
			if (allies && MeleeDifficulty() != MELEE_NEWBIE) {
				common = GetAllianceTarget();
				if (common != null) {
					Trace("join ally force\n");//xxx
					if (GetMegaTarget() != null) {
						AddSiege();
					}
					FormGroup(3,true);
					AttackMoveKillA(common);
					SetAllianceTarget(null);
					return;
				}
			}
			// take expansions as needed
			//
			if (needs_exp) {
				Trace("needs exp\n");//xxx
				creep = GetExpansionFoe();
				if (creep != null) {
					Trace("attack exp\n");//xxx
					SetAllianceTarget(creep);
					FormGroup(3,true);
					AttackMoveKillA(creep);
					Sleep(20);
					take_exp = false;
					return;
				}
			}
			// all-out attack if the player is weak
			//
			if (MeleeDifficulty() != MELEE_NEWBIE) {
				mega = GetMegaTarget();
				if (mega != null) {
					Trace("MEGA TARGET!!!\n");//xxx
					AddSiege();
					FormGroup(3,true);
					AttackMoveKillA(mega);
					return;
				}
			}
			// deny player an expansion
			//
			hall = GetEnemyExpansion();
			daytime = GetFloatGameState(GAME_STATE_TIME_OF_DAY);
			can_siege = has_siege and (air_units or (daytime>=4 and daytime<=12));
			if (hall!=null && (can_siege || not IsTowered(hall))) {
				Trace("test player town attack\n");//xxx
				if (MeleeDifficulty() == MELEE_NEWBIE) {
					minimum = 3;
				} else if (allies && MeleeDifficulty() == MELEE_NORMAL) {
					minimum = 1;
				} else {
					minimum = 0;// HARD, INSANE, and NORMAL with no allies
				}
				if (exp_seen >= minimum) {
					Trace("do player town attack\n");//xxx
					exp_seen = 0;
					AddSiege();
					SetAllianceTarget(hall);
					FormGroup(3,true);
					AttackMoveKillA(hall);
					return;
				}
				exp_seen = exp_seen + 1;
			}
			// attack player's main base when siege is available
			//
			if (can_siege) {
				Trace("attack player's town\n");//xxx
				AddSiege();
				AnyPlayerAttack();
				return;
			}
			// extended, more specific method of determining creep levels
			//
			if (min_creeps != -1) {
				TraceI("custom creep attack %d\n",max_creeps);//xxx
				CreepAttackEx();
				return;
			}
			// nothing better to do, so kill a creep camp
			//
			if (maj||_ok) {
				Trace("major creep attack\n");//xxx
				MajorCreepAttack();
				return;
			}
			Trace("minor creep attack\n");//xxx
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
			int index = 0;
			int unitid;
			int desire;
			int count;
			while (true) {
				if (index == harass_length) { break; }
				unitid = harass_units[index];
				desire = harass_qty[index] + IgnoredUnits(unitid);
				count = TownCount(unitid);
				if (count != desire) {
					if (not StartUnit(desire,unitid,-1)) {
						return;
					}
				}
				index = index + 1;
			}
		}
		//============================================================================
		private void BuildDefenders() {
			int index = 0;
			int unitid;
			int qty;
			while (true) {
				if (index == defense_length) { break; }
				unitid = defense_units[index];
				qty = defense_qty[index];
				Conversions(qty,unitid);
				AddDefenders(qty,unitid);
				index = index + 1;
			}
		}
		//============================================================================
		private void CampaignBasicsA() {
			int food_each = GetFoodMade(racial_farm);
			int on_wood;
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
			while (true) {
				CampaignBasicsA();
				Sleep(campaign_basics_speed);
			}
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
			unit bldg;
			while (true) {
				bldg = GetBuilding(ai_player);
				if (bldg==null) { break; }
				Unsummon(bldg);
				Sleep(2);
			}
		}
		//============================================================================
		//  SkillArrays
		//============================================================================
		private int SkillArrays() {
			int level = GetHeroLevelAI();
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
			int i = 1;
			if (index == 1) {
				if (hero_id != id) {
					return;
				}
				while (true) {
					skills1[i] = skill[i];
					if (i == 10) { break; }
					i = i + 1;
				}
			} else if (index == 2) {
				if (hero_id2 != id) {
					return;
				}
				while (true) {
					skills2[i] = skill[i];
					if (i == 10) { break; }
					i = i + 1;
				}
			} else {
				if (hero_id3 != id) {
					return;
				}
				while (true) {
					skills3[i] = skill[i];
					if (i == 10) { break; }
					i = i + 1;
				}
			}
		}
		//============================================================================
		//  AwaitMeleeHeroes
		//============================================================================
		private void AwaitMeleeHeroes() {
			if (GetUnitCountDone(hero_id2) > 0) {
				two_heroes = true;
			}
			while (true) {
				if (GetUnitCountDone(hero_id)>0 && (take_exp || (not two_heroes || GetUnitCountDone(hero_id2)>0))) { break; }
				Sleep(1);
			}
		}
		//============================================================================
		//  PickMeleeHero
		//============================================================================
		private int PickMeleeHero(race raceid) {
			int first;
			int second;
			int third;
			int last;
			int[]heroes;
			//------------------------------------------------------------------------
			if (raceid == RACE_HUMAN) {
				//------------------------------------------------------------------------
				heroes[1] = ARCHMAGE;
				heroes[2] = MTN_KING;
				heroes[3] = PALADIN;
				heroes[4] = BLOOD_MAGE;
				//------------------------------------------------------------------------
			} else if (raceid == RACE_ORC) {
				//------------------------------------------------------------------------
				heroes[1] = BLADE_MASTER;
				heroes[2] = FAR_SEER;
				heroes[3] = TAUREN_CHIEF;
				heroes[4] = SHADOW_HUNTER;
				//------------------------------------------------------------------------
			} else if (raceid == RACE_NIGHTELF) {
				//------------------------------------------------------------------------
				heroes[1] = DEMON_HUNTER;
				heroes[2] = KEEPER;
				heroes[3] = MOON_BABE;
				heroes[4] = WARDEN;
				//------------------------------------------------------------------------
			} else if (raceid == RACE_UNDEAD) {
				//------------------------------------------------------------------------
				heroes[1] = DEATH_KNIGHT;
				heroes[2] = DREAD_LORD;
				heroes[3] = LICH;
				heroes[4] = CRYPT_LORD;
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
			heroes[first] = heroes[last];
			hero_id2 = heroes[second];
			heroes[second] = heroes[last-1];
			hero_id3 = heroes[third];
			return hero_id;
		}

	
	}
}

