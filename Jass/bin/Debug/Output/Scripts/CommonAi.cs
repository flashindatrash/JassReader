using System;
using System.Collections.Generic;

namespace Jass {

	public class CommonAi {

		 //
		 //
		 //
		 //
		 //
		 //
		 //
		private player PlayerEx(int slot) { //function PlayerEx takes integer slot returns player
			return Player(slot-1); //return Player(slot-1)
		} //endfunction
		 //
		private void Trace(string message) { //function Trace takes string message returns nothing
			if (trace_on) { //if trace_on then
				DisplayText(GetAiPlayer(),message); //call DisplayText(GetAiPlayer(),message)
			} //endif
		} //endfunction
		 //
		private void TraceI(string message, int val) { //function TraceI takes string message, integer val returns nothing
			if (trace_on) { //if trace_on then
				DisplayTextI(GetAiPlayer(),message,val); //call DisplayTextI(GetAiPlayer(),message,val)
			} //endif
		} //endfunction
		 //
		private void TraceII(string message, int v1, int v2) { //function TraceII takes string message, integer v1, integer v2 returns nothing
			if (trace_on) { //if trace_on then
				DisplayTextII(GetAiPlayer(),message,v1,v2); //call DisplayTextII(GetAiPlayer(),message,v1,v2)
			} //endif
		} //endfunction
		 //
		private void TraceIII(string message, int v1, int v2, int v3) { //function TraceIII takes string message, integer v1, integer v2, integer v3 returns nothing
			if (trace_on) { //if trace_on then
				DisplayTextIII(GetAiPlayer(),message,v1,v2,v3); //call DisplayTextIII(GetAiPlayer(),message,v1,v2,v3)
			} //endif
		} //endfunction
		 //
		private void InitAI() { //function InitAI takes nothing returns nothing
			ai_player = Player(GetAiPlayer()); //set ai_player = Player(GetAiPlayer())
			sleep_seconds = 0; //set sleep_seconds = 0
			StopGathering(); //call StopGathering()
		} //endfunction
		 //
		private void StandardAI(code heroes, code peons, code attacks) { //function StandardAI takes code heroes, code peons, code attacks returns nothing
			bool isNewbie = (MeleeDifficulty() == MELEE_NEWBIE); //local boolean isNewbie = (MeleeDifficulty() == MELEE_NEWBIE)
			InitAI(); //call InitAI()
			SetMeleeAI(); //call SetMeleeAI()
			SetDefendPlayer(true); //call SetDefendPlayer(true)
			SetGroupsFlee(not isNewbie); //call SetGroupsFlee(not isNewbie)
			SetHeroesBuyItems(not isNewbie); //call SetHeroesBuyItems(not isNewbie)
			SetHeroesFlee(true); //call SetHeroesFlee(true)
			SetHeroesTakeItems(true); //call SetHeroesTakeItems(true)
			SetIgnoreInjured(true); //call SetIgnoreInjured(true)
			SetPeonsRepair(true); //call SetPeonsRepair(true)
			SetSmartArtillery(not isNewbie); //call SetSmartArtillery(not isNewbie)
			SetTargetHeroes(not isNewbie); //call SetTargetHeroes(not isNewbie)
			SetUnitsFlee(not isNewbie); //call SetUnitsFlee(not isNewbie)
			SetWatchMegaTargets(true); //call SetWatchMegaTargets(true)
			CreateCaptains(); //call CreateCaptains()
			SetHeroLevels(heroes); //call SetHeroLevels(heroes)
			Sleep(0.1); //call Sleep(0.1)
			StartThread(peons); //call StartThread(peons)
			StartThread(attacks); //call StartThread(attacks)
		} //endfunction
		 //
		 //
		 //
		private int Min(int A, int B) { //function Min takes integer A, integer B returns integer
			if (A < B) { //if A < B then
				return A; //return A
			} else { //else
				return B; //return B
			} //endif
		} //endfunction
		private int Max(int A, int B) { //function Max takes integer A, integer B returns integer
			if (A > B) { //if A > B then
				return A; //return A
			} else { //else
				return B; //return B
			} //endif
		} //endfunction
		private void SetZepNextWave() { //function SetZepNextWave takes nothing returns nothing
			zep_next_wave = true; //set zep_next_wave = true
		} //endfunction
		private void SuicideSleep(int seconds) { //function SuicideSleep takes integer seconds returns nothing
			sleep_seconds = sleep_seconds - seconds; //set sleep_seconds = sleep_seconds - seconds
			while (true) { //loop
				if (seconds <= 0) { break; } //exitwhen seconds <= 0
				if (allow_signal_abort && CommandsWaiting() != 0) { break; } //exitwhen allow_signal_abort and CommandsWaiting() != 0
				if (seconds >= 5) { //if seconds >= 5 then
					Sleep(5); //call Sleep(5)
					seconds = seconds - 5; //set seconds = seconds - 5
				} else { //else
					Sleep(seconds); //call Sleep(seconds)
					seconds = 0; //set seconds = 0
				} //endif
			} //endloop
		} //endfunction
		 //
		private int WaitForSignal() { //function WaitForSignal takes nothing returns integer
			int cmd; //local integer cmd
			bool display = false; //local boolean display = false
			while (true) { //loop
				if (CommandsWaiting() != 0) { break; } //exitwhen CommandsWaiting() != 0
				 //
				Trace("waiting for a signal to begin AI script...\n"); //call Trace("waiting for a signal to begin AI script...\n")
				display = true; //set display = true
				Sleep(2); //call Sleep(2)
				if (CommandsWaiting() != 0) { break; } //exitwhen CommandsWaiting() != 0
				Sleep(2); //call Sleep(2)
				if (CommandsWaiting() != 0) { break; } //exitwhen CommandsWaiting() != 0
				Sleep(2); //call Sleep(2)
				if (CommandsWaiting() != 0) { break; } //exitwhen CommandsWaiting() != 0
				Sleep(2); //call Sleep(2)
				if (CommandsWaiting() != 0) { break; } //exitwhen CommandsWaiting() != 0
				Sleep(2); //call Sleep(2)
				 //
			} //endloop
			 //
			if (display) { //if display then
				Trace("signal received, beginning AI script\n"); //call Trace("signal received, beginning AI script\n")
			} //endif
			 //
			cmd = GetLastCommand(); //set cmd = GetLastCommand()
			PopLastCommand(); //call PopLastCommand()
			return cmd; //return cmd
		} //endfunction
		 //
		private void SetWoodPeons(int count) { //function SetWoodPeons takes integer count returns nothing
			campaign_wood_peons = count; //set campaign_wood_peons = count
		} //endfunction
		 //
		private void SetGoldPeons(int count) { //function SetGoldPeons takes integer count returns nothing
			campaign_gold_peons = count; //set campaign_gold_peons = count
		} //endfunction
		 //
		private void SetHarvestLumber(bool harvest) { //function SetHarvestLumber takes boolean harvest returns nothing
			if (harvest) { //if harvest then
				campaign_wood_peons = 3; //set campaign_wood_peons = 3
			} else { //else
				campaign_wood_peons = 0; //set campaign_wood_peons = 0
			} //endif
		} //endfunction
		 //
		private void SetFormGroupTimeouts(bool state) { //function SetFormGroupTimeouts takes boolean state returns nothing
			form_group_timeouts = state; //set form_group_timeouts = state
		} //endfunction
		 //
		private void DoCampaignFarms(bool state) { //function DoCampaignFarms takes boolean state returns nothing
			do_campaign_farms = state; //set do_campaign_farms = state
		} //endfunction
		 //
		private unit GetMinorCreep() { //function GetMinorCreep takes nothing returns unit
			return GetCreepCamp(0,9,false); //return GetCreepCamp(0,9,false)
		} //endfunction
		 //
		private unit GetMajorCreep() { //function GetMajorCreep takes nothing returns unit
			return GetCreepCamp(10,100,allow_air_creeps); //return GetCreepCamp(10,100,allow_air_creeps)
		} //endfunction
		 //
		private int GetGold() { //function GetGold takes nothing returns integer
			return GetPlayerState(ai_player,PLAYER_STATE_RESOURCE_GOLD); //return GetPlayerState(ai_player,PLAYER_STATE_RESOURCE_GOLD)
		} //endfunction
		 //
		private int GetWood() { //function GetWood takes nothing returns integer
			return GetPlayerState(ai_player,PLAYER_STATE_RESOURCE_LUMBER); //return GetPlayerState(ai_player,PLAYER_STATE_RESOURCE_LUMBER)
		} //endfunction
		 //
		private void InitBuildArray() { //function InitBuildArray takes nothing returns nothing
			build_length = 0; //set build_length = 0
		} //endfunction
		 //
		private void InitAssaultGroup() { //function InitAssaultGroup takes nothing returns nothing
			harass_length = 0; //set harass_length = 0
		} //endfunction
		 //
		private void InitDefenseGroup() { //function InitDefenseGroup takes nothing returns nothing
			defense_length = 0; //set defense_length = 0
		} //endfunction
		 //
		private void InitMeleeGroup() { //function InitMeleeGroup takes nothing returns nothing
			InitAssaultGroup(); //call InitAssaultGroup()
			RemoveInjuries(); //call RemoveInjuries()
			RemoveSiege(); //call RemoveSiege()
		} //endfunction
		 //
		private void PrepFullSuicide() { //function PrepFullSuicide takes nothing returns nothing
			InitAssaultGroup(); //call InitAssaultGroup()
			InitDefenseGroup(); //call InitDefenseGroup()
			campaign_gold_peons = 0; //set campaign_gold_peons = 0
			campaign_wood_peons = 0; //set campaign_wood_peons = 0
		} //endfunction
		 //
		private void SetReplacements(int easy, int med, int hard) { //function SetReplacements takes integer easy, integer med, integer hard returns nothing
			if (difficulty == EASY) { //if difficulty == EASY then
				SetReplacementCount(easy); //call SetReplacementCount(easy)
			} else if (difficulty == NORMAL) { //elseif difficulty == NORMAL then
				SetReplacementCount(med); //call SetReplacementCount(med)
			} else { //else
				SetReplacementCount(hard); //call SetReplacementCount(hard)
			} //endif
		} //endfunction
		 //
		private void StartTownBuilder(code func) { //function StartTownBuilder takes code func returns nothing
			StartThread(func); //call StartThread(func)
		} //endfunction
		 //
		private void SetBuildAll(int t, int qty, int unitid, int town) { //function SetBuildAll takes integer t, integer qty, integer unitid, integer town returns nothing
			if (qty > 0) { //if qty > 0 then
				build_qty[build_length] = qty; //set build_qty[build_length] = qty
				build_type[build_length] = t; //set build_type[build_length] = t
				build_item[build_length] = unitid; //set build_item[build_length] = unitid
				build_town[build_length] = town; //set build_town[build_length] = town
				build_length = build_length + 1; //set build_length = build_length + 1
			} //endif
		} //endfunction
		 //
		private void SetBuildUnit(int qty, int unitid) { //function SetBuildUnit takes integer qty, integer unitid returns nothing
			SetBuildAll(BUILD_UNIT,qty,unitid,-1); //call SetBuildAll(BUILD_UNIT,qty,unitid,-1)
		} //endfunction
		 //
		private void SetBuildNext(int qty, int unitid) { //function SetBuildNext takes integer qty, integer unitid returns nothing
			int has = GetUnitCount(unitid); //local integer has = GetUnitCount(unitid)
			if (has >= qty) { //if has >= qty then
				return; //return
			} //endif
			SetBuildAll(BUILD_UNIT,GetUnitCountDone(unitid)+1,unitid,-1); //call SetBuildAll(BUILD_UNIT,GetUnitCountDone(unitid)+1,unitid,-1)
		} //endfunction
		 //
		private void SetBuildUnitEx(int easy, int med, int hard, int unitid) { //function SetBuildUnitEx takes integer easy, integer med, integer hard, integer unitid returns nothing
			if (difficulty == EASY) { //if difficulty == EASY then
				SetBuildAll(BUILD_UNIT,easy,unitid,-1); //call SetBuildAll(BUILD_UNIT,easy,unitid,-1)
			} else if (difficulty == NORMAL) { //elseif difficulty == NORMAL then
				SetBuildAll(BUILD_UNIT,med,unitid,-1); //call SetBuildAll(BUILD_UNIT,med,unitid,-1)
			} else { //else
				SetBuildAll(BUILD_UNIT,hard,unitid,-1); //call SetBuildAll(BUILD_UNIT,hard,unitid,-1)
			} //endif
		} //endfunction
		 //
		private void SecondaryTown(int town, int qty, int unitid) { //function SecondaryTown takes integer town, integer qty, integer unitid returns nothing
			SetBuildAll(BUILD_UNIT,qty,unitid,town); //call SetBuildAll(BUILD_UNIT,qty,unitid,town)
		} //endfunction
		 //
		private void SecTown(int town, int qty, int unitid) { //function SecTown takes integer town, integer qty, integer unitid returns nothing
			SetBuildAll(BUILD_UNIT,qty,unitid,town); //call SetBuildAll(BUILD_UNIT,qty,unitid,town)
		} //endfunction
		 //
		private void SetBuildUpgr(int qty, int unitid) { //function SetBuildUpgr takes integer qty, integer unitid returns nothing
			if (MeleeDifficulty() != MELEE_NEWBIE || qty == 1) { //if MeleeDifficulty() != MELEE_NEWBIE or qty == 1 then
				SetBuildAll(BUILD_UPGRADE,qty,unitid,-1); //call SetBuildAll(BUILD_UPGRADE,qty,unitid,-1)
			} //endif
		} //endfunction
		 //
		private void SetBuildUpgrEx(int easy, int med, int hard, int unitid) { //function SetBuildUpgrEx takes integer easy, integer med, integer hard, integer unitid returns nothing
			if (difficulty == EASY) { //if difficulty == EASY then
				SetBuildAll(BUILD_UPGRADE,easy,unitid,-1); //call SetBuildAll(BUILD_UPGRADE,easy,unitid,-1)
			} else if (difficulty == NORMAL) { //elseif difficulty == NORMAL then
				SetBuildAll(BUILD_UPGRADE,med,unitid,-1); //call SetBuildAll(BUILD_UPGRADE,med,unitid,-1)
			} else { //else
				SetBuildAll(BUILD_UPGRADE,hard,unitid,-1); //call SetBuildAll(BUILD_UPGRADE,hard,unitid,-1)
			} //endif
		} //endfunction
		 //
		private void SetBuildExpa(int qty, int unitid) { //function SetBuildExpa takes integer qty, integer unitid returns nothing
			SetBuildAll(BUILD_EXPAND,qty,unitid,-1); //call SetBuildAll(BUILD_EXPAND,qty,unitid,-1)
		} //endfunction
		 //
		private bool StartUpgrade(int level, int upgid) { //function StartUpgrade takes integer level, integer upgid returns boolean
			int gold_cost; //local integer gold_cost
			int wood_cost; //local integer wood_cost
			if (GetUpgradeLevel(upgid) >= level) { //if GetUpgradeLevel(upgid) >= level then
				return true; //return true
			} //endif
			gold_cost = GetUpgradeGoldCost(upgid); //set gold_cost = GetUpgradeGoldCost(upgid)
			if (total_gold < gold_cost) { //if total_gold < gold_cost then
				return false; //return false
			} //endif
			wood_cost = GetUpgradeWoodCost(upgid); //set wood_cost = GetUpgradeWoodCost(upgid)
			if (total_wood < wood_cost) { //if total_wood < wood_cost then
				return false; //return false
			} //endif
			return SetUpgrade(upgid); //return SetUpgrade(upgid)
		} //endfunction
		 //
		private void BuildFactory(int unitid) { //function BuildFactory takes integer unitid returns nothing
			if (GetGold() > 1000 && GetWood() > 500) { //if GetGold() > 1000 and GetWood() > 500 then
				SetBuildUnit(2, unitid); //call SetBuildUnit( 2, unitid )
			} else { //else
				SetBuildUnit(1, unitid); //call SetBuildUnit( 1, unitid )
			} //endif
		} //endfunction
		 //
		private bool HallsCompleted(int unitid) { //function HallsCompleted takes integer unitid returns boolean
			return GetUnitCount(unitid) == GetUnitCountDone(unitid); //return GetUnitCount(unitid) == GetUnitCountDone(unitid)
		} //endfunction
		 //
		private void GuardSecondary(int townid, int qty, int unitid) { //function GuardSecondary takes integer townid, integer qty, integer unitid returns nothing
			if (TownHasHall(townid) && TownHasMine(townid)) { //if TownHasHall(townid) and TownHasMine(townid) then
				SecondaryTown(townid, qty, unitid); //call SecondaryTown( townid, qty, unitid )
			} //endif
		} //endfunction
		 //
		private int GetUnitCountEx(int unitid, bool only_done, int townid) { //function GetUnitCountEx takes integer unitid, boolean only_done, integer townid returns integer
			if (townid == -1) { //if townid == -1 then
				if (only_done) { //if only_done then
					return GetUnitCountDone(unitid); //return GetUnitCountDone(unitid)
				} else { //else
					return GetUnitCount(unitid); //return GetUnitCount(unitid)
				} //endif
			} else { //else
				return GetTownUnitCount(unitid,townid,only_done); //return GetTownUnitCount(unitid,townid,only_done)
			} //endif
		} //endfunction
		 //
		private int TownCountEx(int unitid, bool only_done, int townid) { //function TownCountEx takes integer unitid, boolean only_done, integer townid returns integer
			int have_qty = GetUnitCountEx(unitid,only_done,townid); //local integer have_qty = GetUnitCountEx(unitid,only_done,townid)
			if (unitid == TOWN_HALL) { //if unitid == TOWN_HALL then
				have_qty = have_qty + GetUnitCountEx(KEEP,false,townid) + GetUnitCountEx(CASTLE,false,townid); //set have_qty = have_qty + GetUnitCountEx(KEEP,false,townid) + GetUnitCountEx(CASTLE,false,townid)
			} else if (unitid == KEEP) { //elseif unitid == KEEP then
				have_qty = have_qty  + GetUnitCountEx(CASTLE,false,townid); //set have_qty = have_qty  + GetUnitCountEx(CASTLE,false,townid)
			} else if (unitid == WATCH_TOWER) { //elseif unitid == WATCH_TOWER then
				have_qty = have_qty + GetUnitCountEx(GUARD_TOWER,false,townid) + GetUnitCountEx(CANNON_TOWER,false,townid) + GetUnitCountEx(ARCANE_TOWER,false,townid); //set have_qty = have_qty + GetUnitCountEx(GUARD_TOWER,false,townid) + GetUnitCountEx(CANNON_TOWER,false,townid) + GetUnitCountEx(ARCANE_TOWER,false,townid)
			} else if (unitid == PEASANT) { //elseif unitid == PEASANT then
				have_qty = have_qty + GetUnitCountEx(MILITIA,false,townid); //set have_qty = have_qty + GetUnitCountEx(MILITIA,false,townid)
			} else if (unitid == GREAT_HALL) { //elseif unitid == GREAT_HALL then
				have_qty = have_qty + GetUnitCountEx(STRONGHOLD,false,townid) + GetUnitCountEx(FORTRESS,false,townid); //set have_qty = have_qty + GetUnitCountEx(STRONGHOLD,false,townid) + GetUnitCountEx(FORTRESS,false,townid)
			} else if (unitid == STRONGHOLD) { //elseif unitid == STRONGHOLD then
				have_qty = have_qty + GetUnitCountEx(FORTRESS,false,townid); //set have_qty = have_qty + GetUnitCountEx(FORTRESS,false,townid)
			} else if (unitid == HEAD_HUNTER) { //elseif unitid == HEAD_HUNTER then
				have_qty = have_qty + GetUnitCountEx(BERSERKER,false,townid); //set have_qty = have_qty + GetUnitCountEx(BERSERKER,false,townid)
			} else if (unitid == SPIRIT_WALKER) { //elseif unitid == SPIRIT_WALKER then
				have_qty = have_qty + GetUnitCountEx(SPIRIT_WALKER_M,false,townid); //set have_qty = have_qty + GetUnitCountEx(SPIRIT_WALKER_M,false,townid)
			} else if (unitid == SPIRIT_WALKER_M) { //elseif unitid == SPIRIT_WALKER_M then
				have_qty = have_qty + GetUnitCountEx(SPIRIT_WALKER,only_done,townid); //set have_qty = have_qty + GetUnitCountEx(SPIRIT_WALKER,only_done,townid)
			} else if (unitid == NECROPOLIS_1) { //elseif unitid == NECROPOLIS_1 then
				have_qty = have_qty + GetUnitCountEx(NECROPOLIS_2,false,townid) + GetUnitCountEx(NECROPOLIS_3,false,townid); //set have_qty = have_qty + GetUnitCountEx(NECROPOLIS_2,false,townid) + GetUnitCountEx(NECROPOLIS_3,false,townid)
			} else if (unitid == NECROPOLIS_2) { //elseif unitid == NECROPOLIS_2 then
				have_qty = have_qty + GetUnitCountEx(NECROPOLIS_3,false,townid); //set have_qty = have_qty + GetUnitCountEx(NECROPOLIS_3,false,townid)
			} else if (unitid == ZIGGURAT_1) { //elseif unitid == ZIGGURAT_1 then
				have_qty = have_qty + GetUnitCountEx(ZIGGURAT_2,false,townid) + GetUnitCountEx(ZIGGURAT_FROST,false,townid); //set have_qty = have_qty + GetUnitCountEx(ZIGGURAT_2,false,townid) + GetUnitCountEx(ZIGGURAT_FROST,false,townid)
			} else if (unitid == GARGOYLE) { //elseif unitid == GARGOYLE then
				have_qty = have_qty + GetUnitCountEx(GARGOYLE_MORPH,false,townid); //set have_qty = have_qty + GetUnitCountEx(GARGOYLE_MORPH,false,townid)
			} else if (unitid == TREE_LIFE) { //elseif unitid == TREE_LIFE then
				have_qty = have_qty + GetUnitCountEx(TREE_AGES,false,townid) + GetUnitCountEx(TREE_ETERNITY,false,townid); //set have_qty = have_qty + GetUnitCountEx(TREE_AGES,false,townid) + GetUnitCountEx(TREE_ETERNITY,false,townid)
			} else if (unitid == TREE_AGES) { //elseif unitid == TREE_AGES then
				have_qty = have_qty + GetUnitCountEx(TREE_ETERNITY,false,townid); //set have_qty = have_qty + GetUnitCountEx(TREE_ETERNITY,false,townid)
			} else if (unitid == DRUID_TALON) { //elseif unitid == DRUID_TALON then
				have_qty = have_qty + GetUnitCountEx(DRUID_TALON_M,false,townid); //set have_qty = have_qty + GetUnitCountEx(DRUID_TALON_M,false,townid)
			} else if (unitid == DRUID_TALON_M) { //elseif unitid == DRUID_TALON_M then
				have_qty = have_qty + GetUnitCountEx(DRUID_TALON,only_done,townid); //set have_qty = have_qty + GetUnitCountEx(DRUID_TALON,only_done,townid)
			} else if (unitid == DRUID_CLAW) { //elseif unitid == DRUID_CLAW then
				have_qty = have_qty + GetUnitCountEx(DRUID_CLAW_M,false,townid); //set have_qty = have_qty + GetUnitCountEx(DRUID_CLAW_M,false,townid)
			} else if (unitid == DRUID_CLAW_M) { //elseif unitid == DRUID_CLAW_M then
				have_qty = have_qty + GetUnitCountEx(DRUID_CLAW,only_done,townid); //set have_qty = have_qty + GetUnitCountEx(DRUID_CLAW,only_done,townid)
			} else if (unitid == ILLIDAN) { //elseif unitid == ILLIDAN then
				have_qty = have_qty + GetUnitCountEx(ILLIDAN_DEMON,false,townid); //set have_qty = have_qty + GetUnitCountEx(ILLIDAN_DEMON,false,townid)
			} //endif
			return have_qty; //return have_qty
		} //endfunction
		 //
		private int TownCountDone(int base) { //function TownCountDone takes integer base returns integer
			return TownCountEx(base,true,-1); //return TownCountEx(base,true,-1)
		} //endfunction
		 //
		private int TownCount(int base) { //function TownCount takes integer base returns integer
			return TownCountEx(base,false,-1); //return TownCountEx(base,false,-1)
		} //endfunction
		 //
		private void BasicExpansion(bool build_it, int unitid) { //function BasicExpansion takes boolean build_it, integer unitid returns nothing
			if (build_it && HallsCompleted(unitid)) { //if build_it and HallsCompleted(unitid) then
				SetBuildExpa(TownCount(unitid)+1, unitid); //call SetBuildExpa( TownCount(unitid)+1, unitid )
			} //endif
		} //endfunction
		 //
		private void UpgradeAll(int baseid, int newid) { //function UpgradeAll takes integer baseid, integer newid returns nothing
			SetBuildUnit(TownCountDone(baseid), newid); //call SetBuildUnit( TownCountDone(baseid), newid )
		} //endfunction
		 //
		private int TownCountTown(int base, int townid) { //function TownCountTown takes integer base, integer townid returns integer
			return TownCountEx(base,false,townid); //return TownCountEx(base,false,townid)
		} //endfunction
		 //
		 //
		 //
		private void FoodPool(int food, bool weak, int id1, int use1, bool strong, int id2, int use2) { //function FoodPool takes integer food, boolean weak, integer id1, integer use1, boolean strong, integer id2, integer use2 returns nothing
			if (strong) { //if strong then
				SetBuildUnit((food - use1 * TownCount(id1)) / use2, id2); //call SetBuildUnit( (food - use1 * TownCount(id1)) / use2, id2 )
			} else if (weak) { //elseif weak then
				SetBuildUnit((food - use2 * TownCount(id2)) / use1, id1); //call SetBuildUnit( (food - use2 * TownCount(id2)) / use1, id1 )
			} //endif
		} //endfunction
		 //
		 //
		 //
		private void MeleeTownHall(int townid, int unitid) { //function MeleeTownHall takes integer townid, integer unitid returns nothing
			if (TownHasMine(townid) && !TownHasHall(townid)) { //if TownHasMine(townid) and not TownHasHall(townid) then
				SecondaryTown(townid, 1, unitid); //call SecondaryTown ( townid, 1, unitid )
			} //endif
		} //endfunction
		 //
		private void WaitForUnits(int unitid, int qty) { //function WaitForUnits takes integer unitid, integer qty returns nothing
			while (true) { //loop
				if (TownCountDone(unitid) == qty) { break; } //exitwhen TownCountDone(unitid) == qty
				Sleep(2); //call Sleep(2)
			} //endloop
		} //endfunction
		 //
		private bool StartUnit(int ask_qty, int unitid, int town) { //function StartUnit takes integer ask_qty, integer unitid, integer town returns boolean
			int have_qty; //local integer have_qty
			int need_qty; //local integer need_qty
			int afford_gold; //local integer afford_gold
			int afford_wood; //local integer afford_wood
			int afford_qty; //local integer afford_qty
			int gold_cost; //local integer gold_cost
			int wood_cost; //local integer wood_cost
			 //
			 //
			 //
			if (town == -1) { //if town == -1 then
				have_qty = TownCount(unitid); //set have_qty = TownCount(unitid)
			} else { //else
				have_qty = TownCountTown(unitid,town); //set have_qty = TownCountTown(unitid,town)
			} //endif
			if (have_qty >= ask_qty) { //if have_qty >= ask_qty then
				return true; //return true
			} //endif
			need_qty = ask_qty - have_qty; //set need_qty = ask_qty - have_qty
			 //
			 //
			 //
			gold_cost = GetUnitGoldCost(unitid); //set gold_cost = GetUnitGoldCost(unitid)
			wood_cost = GetUnitWoodCost(unitid); //set wood_cost = GetUnitWoodCost(unitid)
			if (gold_cost == 0) { //if gold_cost == 0 then
				afford_gold = need_qty; //set afford_gold = need_qty
			} else { //else
				afford_gold = total_gold / gold_cost; //set afford_gold = total_gold / gold_cost
			} //endif
			if (afford_gold < need_qty) { //if afford_gold < need_qty then
				afford_qty = afford_gold; //set afford_qty = afford_gold
			} else { //else
				afford_qty = need_qty; //set afford_qty = need_qty
			} //endif
			if (wood_cost == 0) { //if wood_cost == 0 then
				afford_wood = need_qty; //set afford_wood = need_qty
			} else { //else
				afford_wood = total_wood / wood_cost; //set afford_wood = total_wood / wood_cost
			} //endif
			if (afford_wood < afford_qty) { //if afford_wood < afford_qty then
				afford_qty = afford_wood; //set afford_qty = afford_wood
			} //endif
			 //
			if (afford_qty < 1) { //if afford_qty < 1 then
				return false; //return false
			} //endif
			 //
			 //
			 //
			 //
			total_gold = total_gold - gold_cost * need_qty; //set total_gold = total_gold - gold_cost * need_qty
			total_wood = total_wood - wood_cost * need_qty; //set total_wood = total_wood - wood_cost * need_qty
			if (total_gold < 0) { //if total_gold < 0 then
				total_gold = 0; //set total_gold = 0
			} //endif
			if (total_wood < 0) { //if total_wood < 0 then
				total_wood = 0; //set total_wood = 0
			} //endif
			 //
			 //
			 //
			 //
			 //
			return SetProduce(afford_qty,unitid,town); //return SetProduce(afford_qty,unitid,town)
		} //endfunction
		 //
		private void WaitForTown(int towns, int townid) { //function WaitForTown takes integer towns, integer townid returns nothing
			int i = 0; //local integer i = 0
			while (true) { //loop
				Sleep(10); //call Sleep(10)
				if (TownCount(townid) >= towns) { break; } //exitwhen TownCount(townid) >= towns
				i = i + 1; //set i = i + 1
				if (i == 12) { break; } //exitwhen i == 12
			} //endloop
		} //endfunction
		 //
		private bool StartExpansion(int qty, int hall) { //function StartExpansion takes integer qty, integer hall returns boolean
			int count; //local integer count
			int town; //local integer town
			unit peon; //local unit    peon
			int gold_cost; //local integer gold_cost
			count = TownCount(hall); //set count = TownCount(hall)
			if (count >= qty) { //if count >= qty then
				return true; //return true
			} //endif
			town = GetNextExpansion(); //set town = GetNextExpansion()
			if (town == -1) { //if town == -1 then
				return true; //return true
			} //endif
			take_exp = true; //set take_exp = true
			gold_cost = GetUnitGoldCost(hall); //set gold_cost = GetUnitGoldCost(hall)
			if (gold_cost > total_gold) { //if gold_cost > total_gold then
				return false; //return false
			} //endif
			total_gold = total_gold - gold_cost; //set total_gold = total_gold - gold_cost
			if (GetExpansionFoe() != null) { //if GetExpansionFoe() != null then
				return true; //return true
			} //endif
			peon = GetExpansionPeon(); //set peon = GetExpansionPeon()
			if (peon != null) { //if peon != null then
				return SetExpansion(peon,hall); //return SetExpansion(peon,hall)
			} //endif
			return true; //return true
		} //endfunction
		 //
		private void OneBuildLoop() { //function OneBuildLoop takes nothing returns nothing
			int index = 0; //local integer index = 0
			int qty; //local integer qty
			int id; //local integer id
			int tp; //local integer tp
			total_gold = GetGold() - gold_buffer; //set total_gold = GetGold() - gold_buffer
			total_wood = GetWood(); //set total_wood = GetWood()
			while (true) { //loop
				if (index == build_length) { break; } //exitwhen index == build_length
				qty = build_qty [index]; //set qty = build_qty [index]
				id = build_item[index]; //set id  = build_item[index]
				tp = build_type[index]; //set tp  = build_type[index]
				 //
				if (tp == BUILD_UNIT) { //if tp == BUILD_UNIT then
					if (!StartUnit(qty,id,build_town[index])) { //if not StartUnit(qty,id,build_town[index]) then
						return; //return
					} //endif
					 //
				} else if (tp == BUILD_UPGRADE) { //elseif tp == BUILD_UPGRADE then
					StartUpgrade(qty,id); //call StartUpgrade(qty,id)
					 //
				} else { //else
					if (!StartExpansion(qty,id)) { //if not StartExpansion(qty,id) then
						return; //return
					} //endif
				} //endif
				index = index + 1; //set index = index + 1
			} //endloop
		} //endfunction
		 //
		private void StaggerSleep(real base, real spread) { //function StaggerSleep takes real base, real spread returns nothing
			Sleep(base + spread * I2R(GetAiPlayer()) / I2R(GetPlayers())); //call Sleep(base + spread * I2R(GetAiPlayer()) / I2R(GetPlayers()))
		} //endfunction
		 //
		private void BuildLoop() { //function BuildLoop takes nothing returns nothing
			OneBuildLoop(); //call OneBuildLoop()
			StaggerSleep(1,2); //call StaggerSleep(1,2)
			while (true) { //loop
				OneBuildLoop(); //call OneBuildLoop()
				Sleep(2); //call Sleep(2)
			} //endloop
		} //endfunction
		 //
		private void StartBuildLoop() { //function StartBuildLoop takes nothing returns nothing
			StartThread(function BuildLoop); //call StartThread(function BuildLoop)
		} //endfunction
		 //
		private void SetInitialWave(int seconds) { //function SetInitialWave takes integer seconds returns nothing
			sleep_seconds = seconds; //set sleep_seconds = seconds
		} //endfunction
		 //
		private void AddSleepSeconds(int seconds) { //function AddSleepSeconds takes integer seconds returns nothing
			sleep_seconds = sleep_seconds + seconds; //set sleep_seconds = sleep_seconds + seconds
		} //endfunction
		 //
		private void SleepForever() { //function SleepForever takes nothing returns nothing
			Trace("going to sleep forever\n"); //call Trace("going to sleep forever\n")
			while (true) { //loop
				Sleep(100); //call Sleep(100)
			} //endloop
		} //endfunction
		 //
		private void PlayGame() { //function PlayGame takes nothing returns nothing
			StartBuildLoop(); //call StartBuildLoop()
			SleepForever(); //call SleepForever()
		} //endfunction
		 //
		private void ConvertNeeds(int unitid) { //function ConvertNeeds takes integer unitid returns nothing
			if (GetUnitCount(unitid) < 1) { //if GetUnitCount(unitid) < 1 then
				StartUnit(1,unitid,-1); //call StartUnit(1,unitid,-1)
			} //endif
		} //endfunction
		 //
		private void Conversions(int desire, int unitid) { //function Conversions takes integer desire, integer unitid returns nothing
			if (GetUnitCount(unitid) >= desire) { //if GetUnitCount(unitid) >= desire then
				return; //return
			} //endif
			if (unitid == HIPPO_RIDER) { //if unitid == HIPPO_RIDER then
				ConvertNeeds(ARCHER); //call ConvertNeeds(ARCHER)
				ConvertNeeds(HIPPO); //call ConvertNeeds(HIPPO)
				MergeUnits(desire,ARCHER,HIPPO,HIPPO_RIDER); //call MergeUnits(desire,ARCHER,HIPPO,HIPPO_RIDER)
			} else if (unitid == BLK_SPHINX) { //elseif unitid == BLK_SPHINX then
				ConvertNeeds(OBS_STATUE); //call ConvertNeeds(OBS_STATUE)
				ConvertUnits(desire,OBS_STATUE); //call ConvertUnits(desire,OBS_STATUE)
			} //endif
		} //endfunction
		 //
		private void SetAssaultGroup(int qty, int max, int unitid) { //function SetAssaultGroup takes integer qty, integer max, integer unitid returns nothing
			Conversions(max,unitid); //call Conversions(max,unitid)
			if (qty <= 0 && TownCountDone(unitid) == 0) { //if qty <= 0 and TownCountDone(unitid) == 0 then
				return; //return
			} //endif
			harass_qty[harass_length] = qty; //set harass_qty[harass_length] = qty
			harass_max[harass_length] = max; //set harass_max[harass_length] = max
			harass_units[harass_length] = unitid; //set harass_units[harass_length] = unitid
			harass_length = harass_length + 1; //set harass_length = harass_length + 1
		} //endfunction
		 //
		private void Interleave3(int e1, int m1, int h1, int u1, int e2, int m2, int h2, int u2, int e3, int m3, int h3, int u3) { //function Interleave3 takes integer e1, integer m1, integer h1, integer u1, integer e2, integer m2, integer h2, integer u2, integer e3, integer m3, integer h3, integer u3 returns nothing
			int i1 = 1; //local integer i1 = 1
			int i2 = 1; //local integer i2 = 1
			int i3 = 1; //local integer i3 = 1
			int q1; //local integer q1
			int q2; //local integer q2
			int q3; //local integer q3
			if (difficulty == EASY) { //if difficulty == EASY then
				q1 = e1; //set q1 = e1
				q2 = e2; //set q2 = e2
				q3 = e3; //set q3 = e3
			} else if (difficulty == NORMAL) { //elseif difficulty == NORMAL then
				q1 = m1; //set q1 = m1
				q2 = m2; //set q2 = m2
				q3 = m3; //set q3 = m3
			} else { //else
				q1 = h1; //set q1 = h1
				q2 = h2; //set q2 = h2
				q3 = h3; //set q3 = h3
			} //endif
			while (true) { //loop
				if (q1<=0 && q2<=0 && q3<=0) { break; } //exitwhen q1<=0 and q2<=0 and q3<=0
				if (q1 > 0) { //if q1 > 0 then
					SetAssaultGroup(i1,i1,u1); //call SetAssaultGroup(i1,i1,u1)
					q1 = q1 - 1; //set q1 = q1 - 1
					i1 = i1 + 1; //set i1 = i1 + 1
				} //endif
				if (q2 > 0) { //if q2 > 0 then
					SetAssaultGroup(i2,i2,u2); //call SetAssaultGroup(i2,i2,u2)
					q2 = q2 - 1; //set q2 = q2 - 1
					i2 = i2 + 1; //set i2 = i2 + 1
				} //endif
				if (q3 > 0) { //if q3 > 0 then
					SetAssaultGroup(i3,i3,u3); //call SetAssaultGroup(i3,i3,u3)
					q3 = q3 - 1; //set q3 = q3 - 1
					i3 = i3 + 1; //set i3 = i3 + 1
				} //endif
			} //endloop
		} //endfunction
		 //
		private void SetMeleeGroup(int unitid) { //function SetMeleeGroup takes integer unitid returns nothing
			if (unitid == hero_id) { //if unitid == hero_id then
				SetAssaultGroup(1,9,unitid); //call SetAssaultGroup(1,9,unitid)
			} else { //else
				SetAssaultGroup((TownCountDone(unitid)*3)/4,20,unitid); //call SetAssaultGroup((TownCountDone(unitid)*3)/4,20,unitid)
			} //endif
		} //endfunction
		 //
		private void CampaignDefender(int level, int qty, int unitid) { //function CampaignDefender takes integer level, integer qty, integer unitid returns nothing
			if (qty > 0 && difficulty >= level) { //if qty > 0 and difficulty >= level then
				defense_qty[defense_length] = qty; //set defense_qty[defense_length] = qty
				defense_units[defense_length] = unitid; //set defense_units[defense_length] = unitid
				defense_length = defense_length + 1; //set defense_length = defense_length + 1
				Conversions(qty,unitid); //call Conversions(qty,unitid)
				SetBuildUnit(qty,unitid); //call SetBuildUnit(qty,unitid)
			} //endif
		} //endfunction
		 //
		private void CampaignDefenderEx(int easy, int med, int hard, int unitid) { //function CampaignDefenderEx takes integer easy, integer med, integer hard, integer unitid returns nothing
			if (difficulty == EASY) { //if difficulty == EASY then
				CampaignDefender(EASY,easy,unitid); //call CampaignDefender(EASY,easy,unitid)
			} else if (difficulty == NORMAL) { //elseif difficulty == NORMAL then
				CampaignDefender(NORMAL,med,unitid); //call CampaignDefender(NORMAL,med,unitid)
			} else { //else
				CampaignDefender(HARD,hard,unitid); //call CampaignDefender(HARD,hard,unitid)
			} //endif
		} //endfunction
		 //
		private void CampaignAttacker(int level, int qty, int unitid) { //function CampaignAttacker takes integer level, integer qty, integer unitid returns nothing
			if (qty > 0 && difficulty >= level) { //if qty > 0 and difficulty >= level then
				SetAssaultGroup(qty,qty,unitid); //call SetAssaultGroup(qty,qty,unitid)
			} //endif
		} //endfunction
		 //
		private void CampaignAttackerEx(int easy, int med, int hard, int unitid) { //function CampaignAttackerEx takes integer easy, integer med, integer hard, integer unitid returns nothing
			if (difficulty == EASY) { //if difficulty == EASY then
				CampaignAttacker(EASY,easy,unitid); //call CampaignAttacker(EASY,easy,unitid)
			} else if (difficulty == NORMAL) { //elseif difficulty == NORMAL then
				CampaignAttacker(NORMAL,med,unitid); //call CampaignAttacker(NORMAL,med,unitid)
			} else { //else
				CampaignAttacker(HARD,hard,unitid); //call CampaignAttacker(HARD,hard,unitid)
			} //endif
		} //endfunction
		 //
		private void FormGroup(int seconds, bool testReady) { //function FormGroup takes integer seconds, boolean testReady returns nothing
			int index; //local integer index
			int count; //local integer count
			int unitid; //local integer unitid
			int desire; //local integer desire
			int readyPercent; //local integer readyPercent
			 //
			if (testReady == true) { //if testReady == true then
				readyPercent = 50; //set readyPercent = 50
				Trace("forming group, requiring healthy guys\n"); //call Trace("forming group, requiring healthy guys\n")
			} else { //else
				readyPercent = 0; //set readyPercent = 0
				Trace("forming group, unit health not important\n"); //call Trace("forming group, unit health not important\n")
			} //endif
			Trace("trying to gather forces\n"); //call Trace("trying to gather forces\n")
			while (true) { //loop
				SuicideSleep(seconds); //call SuicideSleep(seconds)
				InitAssault(); //call InitAssault()
				index = 0; //set index = 0
				while (true) { //loop
					if (index == harass_length) { break; } //exitwhen index == harass_length
					unitid = harass_units[index]; //set unitid = harass_units[index]
					desire = harass_max[index]; //set desire = harass_max[index]
					count = TownCountDone(unitid); //set count  = TownCountDone(unitid)
					Conversions(desire,unitid); //call Conversions(desire,unitid)
					if (count >= desire) { //if count >= desire then
						AddAssault(desire,unitid); //call AddAssault(desire,unitid)
					} else { //else
						desire = harass_qty[index]; //set desire = harass_qty[index]
						if (count < desire) { //if count < desire then
							AddAssault(desire,unitid); //call AddAssault(desire,unitid)
						} else { //else
							AddAssault(count,unitid); //call AddAssault(count,unitid)
						} //endif
					} //endif
					index = index + 1; //set index = index + 1
				} //endloop
				 //
				if (form_group_timeouts && (sleep_seconds < -60)) { //if form_group_timeouts and (sleep_seconds < -60) then
					Trace("exit form group -- timeout\n"); //call Trace("exit form group -- timeout\n")
				} else if (CaptainInCombat(true)) { //elseif CaptainInCombat(true) then
					Trace("exit form group -- can't form while already in combat\n"); //call Trace("exit form group -- can't form while already in combat\n")
				} else if (CaptainIsFull() && CaptainReadiness() >= readyPercent) { //elseif CaptainIsFull() and CaptainReadiness() >= readyPercent then
					Trace("exit form group -- ready\n"); //call Trace("exit form group -- ready\n")
				} //endif
				 //
				 //
				if (form_group_timeouts && (sleep_seconds < -60)) { break; } //exitwhen form_group_timeouts and (sleep_seconds < -60)
				if (CaptainInCombat(true)) { break; } //exitwhen CaptainInCombat(true)
				if (CaptainIsFull() && CaptainReadiness() >= readyPercent) { break; } //exitwhen CaptainIsFull() and CaptainReadiness() >= readyPercent
			} //endloop
		} //endfunction
		 //
		private int WavePrepare(int unitid) { //function WavePrepare takes integer unitid returns integer
			return GetUnitBuildTime(unitid); //return GetUnitBuildTime(unitid)
		} //endfunction
		 //
		private int PrepTime() { //function PrepTime takes nothing returns integer
			int unitid; //local integer unitid
			int missing; //local integer missing
			int prep; //local integer prep
			int count; //local integer count
			int largest = 30; //local integer largest = 30
			int index = 0; //local integer index = 0
			while (true) { //loop
				if (index == harass_length) { break; } //exitwhen index == harass_length
				unitid = harass_units[index]; //set unitid  = harass_units[index]
				missing = harass_qty[index] + IgnoredUnits(unitid) - TownCount(unitid); //set missing = harass_qty[index] + IgnoredUnits(unitid) - TownCount(unitid)
				prep = WavePrepare(unitid) * missing; //set prep    = WavePrepare(unitid) * missing
				if (prep > largest) { //if prep > largest then
					largest = prep; //set largest = prep
				} //endif
				index = index + 1; //set index = index + 1
			} //endloop
			TraceI("next wave will require around %d seconds to build and gather\n",largest); //call TraceI("next wave will require around %d seconds to build and gather\n",largest)
			return largest; //return largest
		} //endfunction
		 //
		private bool PrepSuicideOnPlayer(int seconds) { //function PrepSuicideOnPlayer takes integer seconds returns boolean
			int wave_prep = PrepTime(); //local integer wave_prep   = PrepTime()
			int save_length; //local integer save_length
			save_length = harass_length; //set save_length = harass_length
			harass_length = 0; //set harass_length = 0
			AddSleepSeconds(seconds); //call AddSleepSeconds(seconds)
			if (sleep_seconds-wave_prep > 0) { //if sleep_seconds-wave_prep > 0 then
				TraceI("going to sleep for %d seconds before gathering next attack wave\n",sleep_seconds-wave_prep); //call TraceI("going to sleep for %d seconds before gathering next attack wave\n",sleep_seconds-wave_prep)
				SuicideSleep(sleep_seconds-wave_prep); //call SuicideSleep(sleep_seconds-wave_prep)
			} //endif
			Trace("preparing suicide attack wave\n"); //call Trace("preparing suicide attack wave\n")
			harass_length = save_length; //set harass_length = save_length
			if (harass_length < 1) { //if harass_length < 1 then
				Trace("ERROR - no units specificed, exiting early\n"); //call Trace("ERROR - no units specificed, exiting early\n")
				return false; //return false
			} //endif
			return true; //return true
		} //endfunction
		 //
		private void SleepUntilAtGoal() { //function SleepUntilAtGoal takes nothing returns nothing
			while (true) { //loop
				if (CaptainRetreating()) { break; } //exitwhen CaptainRetreating()
				if (CaptainAtGoal()) { break; } //exitwhen CaptainAtGoal()
				if (CaptainIsHome()) { break; } //exitwhen CaptainIsHome()
				if (CaptainIsEmpty()) { break; } //exitwhen CaptainIsEmpty()
				SuicideSleep(3); //call SuicideSleep(3)
			} //endloop
		} //endfunction
		 //
		private void SleepInCombat() { //function SleepInCombat takes nothing returns nothing
			int count = 0; //local integer count = 0
			Trace("SleepInCombat\n"); //debug call Trace("SleepInCombat\n")
			while (true) { //loop
				while (true) { //loop
					if (!CaptainInCombat(true)) { break; } //exitwhen not CaptainInCombat(true)
					if (CaptainIsEmpty()) { break; } //exitwhen CaptainIsEmpty()
					SuicideSleep(1); //call SuicideSleep(1)
				} //endloop
				count = count + 1; //set count = count + 1
				if (count >= 8) { break; } //exitwhen count >= 8
				 //
				 //
			} //endloop
			Trace("exit SleepInCombat\n"); //debug call Trace("exit SleepInCombat\n")
		} //endfunction
		 //
		private void AttackMoveXYA(int x, int y) { //function AttackMoveXYA takes integer x, integer y returns nothing
			if (zep_next_wave) { //if zep_next_wave then
				LoadZepWave(x,y); //call LoadZepWave(x,y)
				zep_next_wave = false; //set zep_next_wave = false
			} //endif
			AttackMoveXY(x,y); //call AttackMoveXY(x,y)
			SleepUntilAtGoal(); //call SleepUntilAtGoal()
			SleepInCombat(); //call SleepInCombat()
		} //endfunction
		 //
		private void SuicideOnPlayerWave() { //function SuicideOnPlayerWave takes nothing returns nothing
			Trace("waiting for attack wave to enter combat\n"); //call Trace("waiting for attack wave to enter combat\n")
			while (true) { //loop
				 //
				if (allow_signal_abort && CommandsWaiting() != 0) { //if allow_signal_abort and CommandsWaiting() != 0 then
					Trace("ABORT -- attack wave override\n"); //call Trace("ABORT -- attack wave override\n")
				} //endif
				if (CaptainInCombat(true)) { //if CaptainInCombat(true) then
					Trace("done - captain has entered combat\n"); //call Trace("done - captain has entered combat\n")
				} //endif
				if (CaptainIsEmpty()) { //if CaptainIsEmpty() then
					Trace("done - all units are dead\n"); //call Trace("done - all units are dead\n")
				} //endif
				if (sleep_seconds < -300) { //if sleep_seconds < -300 then
					Trace("done - timeout, took too long to reach engage the enemy\n"); //call Trace("done - timeout, took too long to reach engage the enemy\n")
				} //endif
				 //
				if (allow_signal_abort && CommandsWaiting() != 0) { break; } //exitwhen allow_signal_abort and CommandsWaiting() != 0
				if (CaptainInCombat(true)) { break; } //exitwhen CaptainInCombat(true)
				if (CaptainIsEmpty()) { break; } //exitwhen CaptainIsEmpty()
				SuicideSleep(10); //call SuicideSleep(10)
				if (sleep_seconds < -300) { break; } //exitwhen sleep_seconds < -300
			} //endloop
			Trace("waiting for attack wave to die\n"); //call Trace("waiting for attack wave to die\n")
			while (true) { //loop
				 //
				if (allow_signal_abort && CommandsWaiting() != 0) { //if allow_signal_abort and CommandsWaiting() != 0 then
					Trace("ABORT - attack wave override\n"); //call Trace("ABORT - attack wave override\n")
				} //endif
				if (CaptainIsEmpty()) { //if CaptainIsEmpty() then
					Trace("done - all units are dead\n"); //call Trace("done - all units are dead\n")
				} //endif
				if (sleep_seconds < -300) { //if sleep_seconds < -300 then
					Trace("done - timeout, took too long to reach engage the enemy\n"); //call Trace("done - timeout, took too long to reach engage the enemy\n")
				} //endif
				 //
				if (allow_signal_abort && CommandsWaiting() != 0) { break; } //exitwhen allow_signal_abort and CommandsWaiting() != 0
				if (CaptainIsEmpty()) { break; } //exitwhen CaptainIsEmpty()
				SuicideSleep(10); //call SuicideSleep(10)
				if (sleep_seconds < -300) { break; } //exitwhen sleep_seconds < -300
			} //endloop
		} //endfunction
		 //
		private void CommonSuicideOnPlayer(bool standard, bool bldgs, int seconds, player p, int x, int y) { //function CommonSuicideOnPlayer takes boolean standard, boolean bldgs, integer seconds, player p, integer x, integer y returns nothing
			int save_peons; //local integer save_peons
			if (!PrepSuicideOnPlayer(seconds)) { //if not PrepSuicideOnPlayer(seconds) then
				return; //return
			} //endif
			save_peons = campaign_wood_peons; //set save_peons = campaign_wood_peons
			campaign_wood_peons = 0; //set campaign_wood_peons = 0
			while (true) { //loop
				 //
				if (allow_signal_abort && CommandsWaiting() != 0) { //if allow_signal_abort and CommandsWaiting() != 0 then
					Trace("ABORT -- attack wave override\n"); //call Trace("ABORT -- attack wave override\n")
				} //endif
				 //
				if (allow_signal_abort && CommandsWaiting() != 0) { break; } //exitwhen allow_signal_abort and CommandsWaiting() != 0
				while (true) { //loop
					if (allow_signal_abort && CommandsWaiting() != 0) { break; } //exitwhen allow_signal_abort and CommandsWaiting() != 0
					FormGroup(5,true); //call FormGroup(5,true)
					if (sleep_seconds <= 0) { break; } //exitwhen sleep_seconds <= 0
					TraceI("waiting %d seconds before suicide\n",sleep_seconds); //call TraceI("waiting %d seconds before suicide\n",sleep_seconds)
				} //endloop
				if (standard) { //if standard then
					if (bldgs) { //if bldgs then
						if (SuicidePlayer(p,sleep_seconds >= -60)) { break; } //exitwhen SuicidePlayer(p,sleep_seconds >= -60)
					} else { //else
						if (SuicidePlayerUnits(p,sleep_seconds >= -60)) { break; } //exitwhen SuicidePlayerUnits(p,sleep_seconds >= -60)
					} //endif
				} else { //else
					AttackMoveXYA(x,y); //call AttackMoveXYA(x,y)
				} //endif
				TraceI("waiting %d seconds before timeout\n",60+sleep_seconds); //call TraceI("waiting %d seconds before timeout\n",60+sleep_seconds)
				SuicideSleep(5); //call SuicideSleep(5)
			} //endloop
			campaign_wood_peons = save_peons; //set campaign_wood_peons = save_peons
			harass_length = 0; //set harass_length = 0
			SuicideOnPlayerWave(); //call SuicideOnPlayerWave()
		} //endfunction
		 //
		private void SuicideOnPlayer(int seconds, player p) { //function SuicideOnPlayer takes integer seconds, player p returns nothing
			CommonSuicideOnPlayer(true,true,seconds,p,0,0); //call CommonSuicideOnPlayer(true,true,seconds,p,0,0)
		} //endfunction
		 //
		private void SuicideOnUnits(int seconds, player p) { //function SuicideOnUnits takes integer seconds, player p returns nothing
			CommonSuicideOnPlayer(true,false,seconds,p,0,0); //call CommonSuicideOnPlayer(true,false,seconds,p,0,0)
		} //endfunction
		 //
		private void SuicideOnPoint(int seconds, player p, int x, int y) { //function SuicideOnPoint takes integer seconds, player p, integer x, integer y returns nothing
			CommonSuicideOnPlayer(false,false,seconds,p,x,y); //call CommonSuicideOnPlayer(false,false,seconds,p,x,y)
		} //endfunction
		 //
		private void SuicideUntilSignal(int seconds, player p) { //function SuicideUntilSignal takes integer seconds, player p returns nothing
			int save; //local integer save
			int wave_prep = PrepTime(); //local integer wave_prep = PrepTime()
			while (true) { //loop
				AddSleepSeconds(seconds); //call AddSleepSeconds(seconds)
				if (sleep_seconds-wave_prep > 0) { //if sleep_seconds-wave_prep > 0 then
					SuicideSleep(sleep_seconds-wave_prep); //call SuicideSleep(sleep_seconds-wave_prep)
				} //endif
				save = campaign_wood_peons; //set save = campaign_wood_peons
				campaign_wood_peons = 0; //set campaign_wood_peons = 0
				while (true) { //loop
					while (true) { //loop
						FormGroup(5, true); //call FormGroup(5, true)
						if (sleep_seconds <= 0) { break; } //exitwhen sleep_seconds <= 0
						if (CommandsWaiting() != 0) { break; } //exitwhen CommandsWaiting() != 0
					} //endloop
					if (SuicidePlayer(p,sleep_seconds >= -60)) { break; } //exitwhen SuicidePlayer(p,sleep_seconds >= -60)
					if (CommandsWaiting() != 0) { break; } //exitwhen CommandsWaiting() != 0
					SuicideSleep(3); //call SuicideSleep(3)
				} //endloop
				campaign_wood_peons = save; //set campaign_wood_peons = save
				while (true) { //loop
					if (CaptainIsEmpty()) { break; } //exitwhen CaptainIsEmpty()
					if (CommandsWaiting() != 0) { break; } //exitwhen CommandsWaiting() != 0
					SuicideSleep(5); //call SuicideSleep(5)
				} //endloop
				if (CommandsWaiting() != 0) { break; } //exitwhen CommandsWaiting() != 0
			} //endloop
		} //endfunction
		 //
		private void SuicideOnce(int easy, int med, int hard, int unitid) { //function SuicideOnce takes integer easy, integer med, integer hard, integer unitid returns nothing
			if (difficulty == EASY) { //if difficulty == EASY then
				SuicideUnit(easy,unitid); //call SuicideUnit(easy,unitid)
			} else if (difficulty == NORMAL) { //elseif difficulty == NORMAL then
				SuicideUnit(med,unitid); //call SuicideUnit(med,unitid)
			} else { //else
				SuicideUnit(hard,unitid); //call SuicideUnit(hard,unitid)
			} //endif
		} //endfunction
		 //
		private void SuicideUnitA(int unitid) { //function SuicideUnitA takes integer unitid returns nothing
			if (unitid != 0) { //if unitid != 0 then
				SuicideUnit(1,unitid); //call SuicideUnit(1,unitid)
			} //endif
			Sleep(0.1); //call Sleep(0.1)
		} //endfunction
		 //
		private void SuicideUnitB(int unitid, int playerid) { //function SuicideUnitB takes integer unitid, integer playerid returns nothing
			if (unitid != 0) { //if unitid != 0 then
				SuicideUnitEx(1,unitid,playerid); //call SuicideUnitEx(1,unitid,playerid)
			} //endif
			Sleep(0.1); //call Sleep(0.1)
		} //endfunction
		 //
		private void SuicideUnits(int u1, int u2, int u3, int u4, int u5, int u6, int u7, int u8, int u9, int uA) { //function SuicideUnits takes integer u1, integer u2, integer u3, integer u4, integer u5, integer u6, integer u7, integer u8, integer u9, integer uA returns nothing
			Trace("MASS SUICIDE - this script is now technically done\n"); //call Trace("MASS SUICIDE - this script is now technically done\n")
			PrepFullSuicide(); //call PrepFullSuicide()
			while (true) { //loop
				SuicideUnitA(u1); //call SuicideUnitA(u1)
				SuicideUnitA(u2); //call SuicideUnitA(u2)
				SuicideUnitA(u3); //call SuicideUnitA(u3)
				SuicideUnitA(u4); //call SuicideUnitA(u4)
				SuicideUnitA(u5); //call SuicideUnitA(u5)
				SuicideUnitA(u6); //call SuicideUnitA(u6)
				SuicideUnitA(u7); //call SuicideUnitA(u7)
				SuicideUnitA(u8); //call SuicideUnitA(u8)
				SuicideUnitA(u9); //call SuicideUnitA(u9)
				SuicideUnitA(uA); //call SuicideUnitA(uA)
			} //endloop
		} //endfunction
		 //
		private void SuicideUnitsEx(int playerid, int u1, int u2, int u3, int u4, int u5, int u6, int u7, int u8, int u9, int uA) { //function SuicideUnitsEx takes integer playerid, integer u1, integer u2, integer u3, integer u4, integer u5, integer u6, integer u7, integer u8, integer u9, integer uA returns nothing
			Trace("MASS SUICIDE - this script is now technically done\n"); //call Trace("MASS SUICIDE - this script is now technically done\n")
			PrepFullSuicide(); //call PrepFullSuicide()
			while (true) { //loop
				SuicideUnitB(u1,playerid); //call SuicideUnitB(u1,playerid)
				SuicideUnitB(u2,playerid); //call SuicideUnitB(u2,playerid)
				SuicideUnitB(u3,playerid); //call SuicideUnitB(u3,playerid)
				SuicideUnitB(u4,playerid); //call SuicideUnitB(u4,playerid)
				SuicideUnitB(u5,playerid); //call SuicideUnitB(u5,playerid)
				SuicideUnitB(u6,playerid); //call SuicideUnitB(u6,playerid)
				SuicideUnitB(u7,playerid); //call SuicideUnitB(u7,playerid)
				SuicideUnitB(u8,playerid); //call SuicideUnitB(u8,playerid)
				SuicideUnitB(u9,playerid); //call SuicideUnitB(u9,playerid)
				SuicideUnitB(uA,playerid); //call SuicideUnitB(uA,playerid)
			} //endloop
		} //endfunction
		 //
		private void SuicideOnPlayerEx(int easy, int med, int hard, player p) { //function SuicideOnPlayerEx takes integer easy, integer med, integer hard, player p returns nothing
			if (difficulty == EASY) { //if difficulty == EASY then
				SuicideOnPlayer(easy,p); //call SuicideOnPlayer(easy,p)
			} else if (difficulty == NORMAL) { //elseif difficulty == NORMAL then
				SuicideOnPlayer(med,p); //call SuicideOnPlayer(med,p)
			} else { //else
				SuicideOnPlayer(hard,p); //call SuicideOnPlayer(hard,p)
			} //endif
		} //endfunction
		 //
		private void SuicideOnUnitsEx(int easy, int med, int hard, player p) { //function SuicideOnUnitsEx takes integer easy, integer med, integer hard, player p returns nothing
			if (difficulty == EASY) { //if difficulty == EASY then
				SuicideOnUnits(easy,p); //call SuicideOnUnits(easy,p)
			} else if (difficulty == NORMAL) { //elseif difficulty == NORMAL then
				SuicideOnUnits(med,p); //call SuicideOnUnits(med,p)
			} else { //else
				SuicideOnUnits(hard,p); //call SuicideOnUnits(hard,p)
			} //endif
		} //endfunction
		 //
		private void SuicideOnPointEx(int easy, int med, int hard, player p, int x, int y) { //function SuicideOnPointEx takes integer easy, integer med, integer hard, player p, integer x, integer y returns nothing
			if (difficulty == EASY) { //if difficulty == EASY then
				SuicideOnPoint(easy,p,x,y); //call SuicideOnPoint(easy,p,x,y)
			} else if (difficulty == NORMAL) { //elseif difficulty == NORMAL then
				SuicideOnPoint(med,p,x,y); //call SuicideOnPoint(med,p,x,y)
			} else { //else
				SuicideOnPoint(hard,p,x,y); //call SuicideOnPoint(hard,p,x,y)
			} //endif
		} //endfunction
		 //
		private void ForeverSuicideOnPlayer(int seconds, player p) { //function ForeverSuicideOnPlayer takes integer seconds, player p returns nothing
			int length = harass_length; //local integer length = harass_length
			while (true) { //loop
				if (allow_signal_abort && CommandsWaiting() != 0) { break; } //exitwhen allow_signal_abort and CommandsWaiting() != 0
				SuicideOnPlayer(seconds,p); //call SuicideOnPlayer(seconds,p)
				harass_length = length; //set harass_length = length
			} //endloop
		} //endfunction
		 //
		private void CommonSleepUntilTargetDead(unit target, bool reform) { //function CommonSleepUntilTargetDead takes unit target, boolean reform returns nothing
			while (true) { //loop
				if (CaptainRetreating()) { break; } //exitwhen CaptainRetreating()
				if (CaptainReadinessHP() <= 40) { break; } //exitwhen CaptainReadinessHP() <= 40
				if (!UnitAlive(target)) { break; } //exitwhen not UnitAlive(target)
				if (UnitInvis(target) && !IsUnitDetected(target,ai_player)) { break; } //exitwhen UnitInvis(target) and not IsUnitDetected(target,ai_player)
				if (!TownThreatened()) { //if not TownThreatened() then
					AttackMoveKill(target); //call AttackMoveKill(target)
				} //endif
				SuicideSleep(3); //call SuicideSleep(3)
				if (reform && sleep_seconds < -40) { //if reform and sleep_seconds < -40 then
					if (CaptainInCombat(true)) { //if CaptainInCombat(true) then
						sleep_seconds = sleep_seconds + 5; //set sleep_seconds = sleep_seconds + 5
					} else { //else
						sleep_seconds = 0; //set sleep_seconds = 0
						FormGroup(1,false); //call FormGroup(1,false)
					} //endif
				} //endif
			} //endloop
		} //endfunction
		 //
		private void SleepUntilTargetDead(unit target) { //function SleepUntilTargetDead takes unit target returns nothing
			CommonSleepUntilTargetDead(target,false); //call CommonSleepUntilTargetDead(target,false)
		} //endfunction
		 //
		private void ReformUntilTargetDead(unit target) { //function ReformUntilTargetDead takes unit target returns nothing
			Trace("ReformUntilTargetDead\n"); //debug call Trace("ReformUntilTargetDead\n")
			CommonSleepUntilTargetDead(target,true); //call CommonSleepUntilTargetDead(target,true)
		} //endfunction
		 //
		private void AttackMoveKillA(unit target) { //function AttackMoveKillA takes unit target returns nothing
			if (target == null) { //if target == null then
				SuicideSleep(3); //call SuicideSleep(3)
				return; //return
			} //endif
			Trace("AttackMoveKillA\n"); //debug call Trace("AttackMoveKillA\n")
			AttackMoveKill(target); //call AttackMoveKill(target)
			ReformUntilTargetDead(target); //call ReformUntilTargetDead(target)
			SleepInCombat(); //call SleepInCombat()
		} //endfunction
		 //
		private void MinorCreepAttack() { //function MinorCreepAttack takes nothing returns nothing
			unit target = GetMinorCreep(); //local unit target = GetMinorCreep()
			SetAllianceTarget(target); //call SetAllianceTarget(target)
			FormGroup(3, true); //call FormGroup(3, true)
			AttackMoveKillA(target); //call AttackMoveKillA(target)
		} //endfunction
		 //
		private void MajorCreepAttack() { //function MajorCreepAttack takes nothing returns nothing
			unit target = GetMajorCreep(); //local unit target = GetMajorCreep()
			SetAllianceTarget(target); //call SetAllianceTarget(target)
			FormGroup(3,true); //call FormGroup(3,true)
			AttackMoveKillA(target); //call AttackMoveKillA(target)
		} //endfunction
		 //
		private void CreepAttackEx() { //function CreepAttackEx takes nothing returns nothing
			unit target = GetCreepCamp(min_creeps,max_creeps,allow_air_creeps); //local unit target = GetCreepCamp(min_creeps,max_creeps,allow_air_creeps)
			SetAllianceTarget(target); //call SetAllianceTarget(target)
			FormGroup(3,true); //call FormGroup(3,true)
			AttackMoveKillA(target); //call AttackMoveKillA(target)
		} //endfunction
		 //
		private void AnyPlayerAttack() { //function AnyPlayerAttack takes nothing returns nothing
			unit hall; //local unit hall
			hall = GetEnemyExpansion(); //set hall = GetEnemyExpansion()
			if (hall == null) { //if hall == null then
				StartGetEnemyBase(); //call StartGetEnemyBase()
				while (true) { //loop
					if (!WaitGetEnemyBase()) { break; } //exitwhen not WaitGetEnemyBase()
					SuicideSleep(1); //call SuicideSleep(1)
				} //endloop
				hall = GetEnemyBase(); //set hall = GetEnemyBase()
			} //endif
			SetAllianceTarget(hall); //call SetAllianceTarget(hall)
			FormGroup(3,true); //call FormGroup(3,true)
			AttackMoveKillA(hall); //call AttackMoveKillA(hall)
		} //endfunction
		 //
		private void ExpansionAttack() { //function ExpansionAttack takes nothing returns nothing
			unit creep = GetExpansionFoe(); //local unit creep = GetExpansionFoe()
			int x; //local integer x
			FormGroup(3, true); //call FormGroup(3, true)
			if (creep == null) { //if creep == null then
				x = GetExpansionX(); //set x = GetExpansionX()
				if (x != -1) { //if x != -1 then
					AttackMoveXYA(x,GetExpansionY()); //call AttackMoveXYA(x,GetExpansionY())
				} //endif
			} else { //else
				AttackMoveKillA(creep); //call AttackMoveKillA(creep)
			} //endif
		} //endfunction
		 //
		 //
		 //
		private void AddSiege() { //function AddSiege takes nothing returns nothing
			SetAssaultGroup(0, 9, SHADE); //call SetAssaultGroup( 0, 9, SHADE       )
			SetAssaultGroup(0, 9, MEAT_WAGON); //call SetAssaultGroup( 0, 9, MEAT_WAGON  )
			SetAssaultGroup(0, 9, MORTAR); //call SetAssaultGroup( 0, 9, MORTAR      )
			SetAssaultGroup(0, 9, TANK); //call SetAssaultGroup( 0, 9, TANK        )
			SetAssaultGroup(0, 9, BALLISTA); //call SetAssaultGroup( 0, 9, BALLISTA    )
			SetAssaultGroup(0, 9, CATAPULT); //call SetAssaultGroup( 0, 9, CATAPULT    )
		} //endfunction
		 //
		 //
		 //
		private int GetAllyCount(player whichPlayer) { //function GetAllyCount takes player whichPlayer returns integer
			int playerIndex = 0; //local integer    playerIndex = 0
			int count = 0; //local integer    count = 0
			player indexPlayer; //local player     indexPlayer
			while (true) { //loop
				indexPlayer = Player(playerIndex); //set indexPlayer = Player(playerIndex)
				if (whichPlayer != indexPlayer) { //if whichPlayer != indexPlayer then
					if (GetPlayerAlliance(whichPlayer,indexPlayer,ALLIANCE_PASSIVE)) { //if GetPlayerAlliance(whichPlayer,indexPlayer,ALLIANCE_PASSIVE) then
						if (GetPlayerAlliance(indexPlayer,whichPlayer,ALLIANCE_PASSIVE)) { //if GetPlayerAlliance(indexPlayer,whichPlayer,ALLIANCE_PASSIVE) then
							if (GetPlayerStructureCount(indexPlayer,true) > 0) { //if GetPlayerStructureCount(indexPlayer,true) > 0 then
								count = count + 1; //set count = count + 1
							} //endif
						} //endif
					} //endif
				} //endif
				playerIndex = playerIndex + 1; //set playerIndex = playerIndex + 1
				if (playerIndex == 12) { break; } //exitwhen playerIndex == 12
			} //endloop
			return count; //return count
		} //endfunction
		 //
		 //
		 //
		private void SingleMeleeAttack(bool needs_exp, bool has_siege, bool major_ok, bool air_units) { //function SingleMeleeAttack takes boolean needs_exp, boolean has_siege, boolean major_ok, boolean air_units returns nothing
			bool can_siege; //local boolean   can_siege
			real daytime; //local real      daytime
			unit hall; //local unit      hall
			unit mega; //local unit      mega
			unit creep; //local unit      creep
			unit common; //local unit      common
			int minimum; //local integer   minimum
			bool allies; //local boolean   allies
			Trace("===SingleMeleeAttack===\n"); //call Trace("===SingleMeleeAttack===\n")
			if (TownThreatened()) { //if TownThreatened() then
				Trace("sleep 2, town threatened\n"); //call Trace("sleep 2, town threatened\n")
				Sleep(2); //call Sleep(2)
				return; //return
			} //endif
			 //
			 //
			if (get_zeppelin && GetGold() > 300 && GetWood() > 100) { //if get_zeppelin and GetGold() > 300 and GetWood() > 100 then
				Trace("purchase zep\n"); //call Trace("purchase zep\n")
				PurchaseZeppelin(); //call PurchaseZeppelin()
				get_zeppelin = false; //set get_zeppelin = false
				ready_for_zeppelin = false; //set ready_for_zeppelin = false
				return; //return
			} //endif
			ready_for_zeppelin = true; //set ready_for_zeppelin = true
			 //
			 //
			allies = GetAllyCount(ai_player) > 0; //set allies = GetAllyCount(ai_player) > 0
			if (allies && MeleeDifficulty() != MELEE_NEWBIE) { //if allies and MeleeDifficulty() != MELEE_NEWBIE then
				common = GetAllianceTarget(); //set common = GetAllianceTarget()
				if (common != null) { //if common != null then
					Trace("join ally force\n"); //call Trace("join ally force\n")
					if (GetMegaTarget() != null) { //if GetMegaTarget() != null then
						AddSiege(); //call AddSiege()
					} //endif
					FormGroup(3,true); //call FormGroup(3,true)
					AttackMoveKillA(common); //call AttackMoveKillA(common)
					SetAllianceTarget(null); //call SetAllianceTarget(null)
					return; //return
				} //endif
			} //endif
			 //
			 //
			if (needs_exp) { //if needs_exp then
				Trace("needs exp\n"); //call Trace("needs exp\n")
				creep = GetExpansionFoe(); //set creep = GetExpansionFoe()
				if (creep != null) { //if creep != null then
					Trace("attack exp\n"); //call Trace("attack exp\n")
					SetAllianceTarget(creep); //call SetAllianceTarget(creep)
					FormGroup(3,true); //call FormGroup(3,true)
					AttackMoveKillA(creep); //call AttackMoveKillA(creep)
					Sleep(20); //call Sleep(20)
					take_exp = false; //set take_exp = false
					return; //return
				} //endif
			} //endif
			 //
			 //
			if (MeleeDifficulty() != MELEE_NEWBIE) { //if MeleeDifficulty() != MELEE_NEWBIE then
				mega = GetMegaTarget(); //set mega = GetMegaTarget()
				if (mega != null) { //if mega != null then
					Trace("MEGA TARGET!!!\n"); //call Trace("MEGA TARGET!!!\n")
					AddSiege(); //call AddSiege()
					FormGroup(3,true); //call FormGroup(3,true)
					AttackMoveKillA(mega); //call AttackMoveKillA(mega)
					return; //return
				} //endif
			} //endif
			 //
			 //
			hall = GetEnemyExpansion(); //set hall = GetEnemyExpansion()
			daytime = GetFloatGameState(GAME_STATE_TIME_OF_DAY); //set daytime = GetFloatGameState(GAME_STATE_TIME_OF_DAY)
			can_siege = has_siege and (air_units or (daytime>=4 and daytime<=12)); //set can_siege = has_siege and (air_units or (daytime>=4 and daytime<=12))
			if (hall!=null && (can_siege || !IsTowered(hall))) { //if hall!=null and (can_siege or not IsTowered(hall)) then
				Trace("test player town attack\n"); //call Trace("test player town attack\n")
				if (MeleeDifficulty() == MELEE_NEWBIE) { //if MeleeDifficulty() == MELEE_NEWBIE then
					minimum = 3; //set minimum = 3
				} else if (allies && MeleeDifficulty() == MELEE_NORMAL) { //elseif allies and MeleeDifficulty() == MELEE_NORMAL then
					minimum = 1; //set minimum = 1
				} else { //else
					minimum = 0; //set minimum = 0
				} //endif
				if (exp_seen >= minimum) { //if exp_seen >= minimum then
					Trace("do player town attack\n"); //call Trace("do player town attack\n")
					exp_seen = 0; //set exp_seen = 0
					AddSiege(); //call AddSiege()
					SetAllianceTarget(hall); //call SetAllianceTarget(hall)
					FormGroup(3,true); //call FormGroup(3,true)
					AttackMoveKillA(hall); //call AttackMoveKillA(hall)
					return; //return
				} //endif
				exp_seen = exp_seen + 1; //set exp_seen = exp_seen + 1
			} //endif
			 //
			 //
			if (can_siege) { //if can_siege then
				Trace("attack player's town\n"); //call Trace("attack player's town\n")
				AddSiege(); //call AddSiege()
				AnyPlayerAttack(); //call AnyPlayerAttack()
				return; //return
			} //endif
			 //
			 //
			if (min_creeps != -1) { //if min_creeps != -1 then
				TraceI("custom creep attack %d\n",max_creeps); //call TraceI("custom creep attack %d\n",max_creeps)
				CreepAttackEx(); //call CreepAttackEx()
				return; //return
			} //endif
			 //
			 //
			if (major_ok) { //if major_ok then
				Trace("major creep attack\n"); //call Trace("major creep attack\n")
				MajorCreepAttack(); //call MajorCreepAttack()
				return; //return
			} //endif
			Trace("minor creep attack\n"); //call Trace("minor creep attack\n")
			MinorCreepAttack(); //call MinorCreepAttack()
		} //endfunction
		 //
		private void GetZeppelin() { //function GetZeppelin takes nothing returns nothing
			if (ready_for_zeppelin) { //if ready_for_zeppelin then
				get_zeppelin = true; //set get_zeppelin = true
			} //endif
		} //endfunction
		 //
		private int FoodUsed() { //function FoodUsed takes nothing returns integer
			return GetPlayerState(ai_player,PLAYER_STATE_RESOURCE_FOOD_USED); //return GetPlayerState(ai_player,PLAYER_STATE_RESOURCE_FOOD_USED)
		} //endfunction
		 //
		private int FoodCap() { //function FoodCap takes nothing returns integer
			return GetPlayerState(ai_player,PLAYER_STATE_RESOURCE_FOOD_CAP); //return GetPlayerState(ai_player,PLAYER_STATE_RESOURCE_FOOD_CAP)
		} //endfunction
		 //
		private int FoodSpace() { //function FoodSpace takes nothing returns integer
			return FoodCap() - FoodUsed(); //return FoodCap() - FoodUsed()
		} //endfunction
		 //
		private int FoodAvail(int base) { //function FoodAvail takes integer base returns integer
			return GetFoodMade(racial_farm) * TownCount(racial_farm) + GetFoodMade(base) * TownCount(base); //return GetFoodMade(racial_farm) * TownCount(racial_farm) + GetFoodMade(base) * TownCount(base)
		} //endfunction
		 //
		private void BuildAttackers() { //function BuildAttackers takes nothing returns nothing
			int index = 0; //local integer index = 0
			int unitid; //local integer unitid
			int desire; //local integer desire
			int count; //local integer count
			while (true) { //loop
				if (index == harass_length) { break; } //exitwhen index == harass_length
				unitid = harass_units[index]; //set unitid = harass_units[index]
				desire = harass_qty[index] + IgnoredUnits(unitid); //set desire = harass_qty[index] + IgnoredUnits(unitid)
				count = TownCount(unitid); //set count  = TownCount(unitid)
				if (count != desire) { //if count != desire then
					if (!StartUnit(desire,unitid,-1)) { //if not StartUnit(desire,unitid,-1) then
						return; //return
					} //endif
				} //endif
				index = index + 1; //set index = index + 1
			} //endloop
		} //endfunction
		 //
		private void BuildDefenders() { //function BuildDefenders takes nothing returns nothing
			int index = 0; //local integer index = 0
			int unitid; //local integer unitid
			int qty; //local integer qty
			while (true) { //loop
				if (index == defense_length) { break; } //exitwhen index == defense_length
				unitid = defense_units[index]; //set unitid = defense_units[index]
				qty = defense_qty[index]; //set qty = defense_qty[index]
				Conversions(qty,unitid); //call Conversions(qty,unitid)
				AddDefenders(qty,unitid); //call AddDefenders(qty,unitid)
				index = index + 1; //set index = index + 1
			} //endloop
		} //endfunction
		 //
		private void CampaignBasicsA() { //function CampaignBasicsA takes nothing returns nothing
			int food_each = GetFoodMade(racial_farm); //local integer food_each = GetFoodMade(racial_farm)
			int on_wood; //local integer on_wood
			ClearHarvestAI(); //call ClearHarvestAI()
			if (CaptainInCombat(false)) { //if CaptainInCombat(false) then
				on_wood = 0; //set on_wood = 0
			} else { //else
				on_wood = campaign_wood_peons; //set on_wood = campaign_wood_peons
			} //endif
			HarvestGold(0,campaign_gold_peons); //call HarvestGold(0,campaign_gold_peons)
			HarvestWood(0,on_wood); //call HarvestWood(0,on_wood)
			if (harvest_town1) { //if harvest_town1 then
				HarvestGold(1,campaign_gold_peons); //call HarvestGold(1,campaign_gold_peons)
				HarvestWood(1,on_wood); //call HarvestWood(1,on_wood)
			} //endif
			if (harvest_town2) { //if harvest_town2 then
				HarvestGold(2,campaign_gold_peons); //call HarvestGold(2,campaign_gold_peons)
				HarvestWood(2,on_wood); //call HarvestWood(2,on_wood)
			} //endif
			if (harvest_town3) { //if harvest_town3 then
				HarvestGold(3,campaign_gold_peons); //call HarvestGold(3,campaign_gold_peons)
				HarvestWood(3,on_wood); //call HarvestWood(3,on_wood)
			} //endif
			if (do_campaign_farms && FoodUsed()+food_each-1 > food_each*(TownCount(racial_farm)+1)) { //if do_campaign_farms and FoodUsed()+food_each-1 > food_each*(TownCount(racial_farm)+1) then
				StartUnit(TownCount(racial_farm)+1,racial_farm,-1); //call StartUnit(TownCount(racial_farm)+1,racial_farm,-1)
			} //endif
			if (build_campaign_attackers) { //if build_campaign_attackers then
				BuildAttackers(); //call BuildAttackers()
			} //endif
			if (!CaptainInCombat(false)) { //if not CaptainInCombat(false) then
				BuildDefenders(); //call BuildDefenders()
			} //endif
			FillGuardPosts(); //call FillGuardPosts()
			ReturnGuardPosts(); //call ReturnGuardPosts()
		} //endfunction
		 //
		private void CampaignBasics() { //function CampaignBasics takes nothing returns nothing
			Sleep(1); //call Sleep(1)
			CampaignBasicsA(); //call CampaignBasicsA()
			StaggerSleep(1,5); //call StaggerSleep(1,5)
			while (true) { //loop
				CampaignBasicsA(); //call CampaignBasicsA()
				Sleep(campaign_basics_speed); //call Sleep(campaign_basics_speed)
			} //endloop
		} //endfunction
		 //
		private void CampaignAI(int farms, code heroes) { //function CampaignAI takes integer farms, code heroes returns nothing
			if (GetGameDifficulty() == MAP_DIFFICULTY_EASY) { //if GetGameDifficulty() == MAP_DIFFICULTY_EASY then
				difficulty = EASY; //set difficulty = EASY
				SetTargetHeroes(false); //call SetTargetHeroes(false)
				SetUnitsFlee(false); //call SetUnitsFlee(false)
			} else if (GetGameDifficulty() == MAP_DIFFICULTY_NORMAL) { //elseif GetGameDifficulty() == MAP_DIFFICULTY_NORMAL then
				difficulty = NORMAL; //set difficulty = NORMAL
				SetTargetHeroes(false); //call SetTargetHeroes(false)
				SetUnitsFlee(false); //call SetUnitsFlee(false)
			} else if (GetGameDifficulty() == MAP_DIFFICULTY_HARD) { //elseif GetGameDifficulty() == MAP_DIFFICULTY_HARD then
				difficulty = HARD; //set difficulty = HARD
				SetPeonsRepair(true); //call SetPeonsRepair(true)
			} else { //else
				difficulty = INSANE; //set difficulty = INSANE
			} //endif
			InitAI(); //call InitAI()
			InitBuildArray(); //call InitBuildArray()
			InitAssaultGroup(); //call InitAssaultGroup()
			CreateCaptains(); //call CreateCaptains()
			SetNewHeroes(false); //call SetNewHeroes(false)
			if (heroes != null) { //if heroes != null then
				SetHeroLevels(heroes); //call SetHeroLevels(heroes)
			} //endif
			SetHeroesFlee(false); //call SetHeroesFlee(false)
			SetGroupsFlee(false); //call SetGroupsFlee(false)
			SetSlowChopping(true); //call SetSlowChopping(true)
			GroupTimedLife(false); //call GroupTimedLife(false)
			SetCampaignAI(); //call SetCampaignAI()
			Sleep(0.1); //call Sleep(0.1)
			racial_farm = farms; //set racial_farm = farms
			StartThread(function CampaignBasics); //call StartThread(function CampaignBasics)
			StartBuildLoop(); //call StartBuildLoop()
		} //endfunction
		 //
		private void UnsummonAll() { //function UnsummonAll takes nothing returns nothing
			unit bldg; //local unit bldg
			while (true) { //loop
				bldg = GetBuilding(ai_player); //set bldg = GetBuilding(ai_player)
				if (bldg==null) { break; } //exitwhen bldg==null
				Unsummon(bldg); //call Unsummon(bldg)
				Sleep(2); //call Sleep(2)
			} //endloop
		} //endfunction
		 //
		 //
		 //
		private int SkillArrays() { //function SkillArrays takes nothing returns integer
			int level = GetHeroLevelAI(); //local integer level = GetHeroLevelAI()
			if (level > max_hero_level) { //if level > max_hero_level then
				max_hero_level = level; //set max_hero_level = level
			} //endif
			if (GetHeroId() == hero_id) { //if GetHeroId() == hero_id then
				return skills1[level]; //return skills1[level]
			} else if (GetHeroId() == hero_id2) { //elseif GetHeroId() == hero_id2 then
				return skills2[level]; //return skills2[level]
			} else { //else
				return skills3[level]; //return skills3[level]
			} //endif
		} //endfunction
		 //
		 //
		 //
		private void SetSkillArray(int index, int id) { //function SetSkillArray takes integer index, integer id returns nothing
			int i = 1; //local integer i = 1
			if (index == 1) { //if index == 1 then
				if (hero_id != id) { //if hero_id != id then
					return; //return
				} //endif
				while (true) { //loop
					skills1[i] = skill[i]; //set skills1[i] = skill[i]
					if (i == 10) { break; } //exitwhen i == 10
					i = i + 1; //set i = i + 1
				} //endloop
			} else if (index == 2) { //elseif index == 2 then
				if (hero_id2 != id) { //if hero_id2 != id then
					return; //return
				} //endif
				while (true) { //loop
					skills2[i] = skill[i]; //set skills2[i] = skill[i]
					if (i == 10) { break; } //exitwhen i == 10
					i = i + 1; //set i = i + 1
				} //endloop
			} else { //else
				if (hero_id3 != id) { //if hero_id3 != id then
					return; //return
				} //endif
				while (true) { //loop
					skills3[i] = skill[i]; //set skills3[i] = skill[i]
					if (i == 10) { break; } //exitwhen i == 10
					i = i + 1; //set i = i + 1
				} //endloop
			} //endif
		} //endfunction
		 //
		 //
		 //
		private void AwaitMeleeHeroes() { //function AwaitMeleeHeroes takes nothing returns nothing
			if (GetUnitCountDone(hero_id2) > 0) { //if GetUnitCountDone(hero_id2) > 0 then
				two_heroes = true; //set two_heroes = true
			} //endif
			while (true) { //loop
				if (GetUnitCountDone(hero_id)>0 && (take_exp || (!two_heroes || GetUnitCountDone(hero_id2)>0))) { break; } //exitwhen GetUnitCountDone(hero_id)>0 and (take_exp or (not two_heroes or GetUnitCountDone(hero_id2)>0))
				Sleep(1); //call Sleep(1)
			} //endloop
		} //endfunction
		 //
		 //
		 //
		private int PickMeleeHero(race raceid) { //function PickMeleeHero takes race raceid returns integer
			int first; //local integer first
			int second; //local integer second
			int third; //local integer third
			int last; //local integer last
			int[]heroes; //local integer array heroes
			 //
			if (raceid == RACE_HUMAN) { //if raceid == RACE_HUMAN then
				 //
				heroes[1] = ARCHMAGE; //set heroes[1] = ARCHMAGE
				heroes[2] = MTN_KING; //set heroes[2] = MTN_KING
				heroes[3] = PALADIN; //set heroes[3] = PALADIN
				heroes[4] = BLOOD_MAGE; //set heroes[4] = BLOOD_MAGE
				 //
			} else if (raceid == RACE_ORC) { //elseif raceid == RACE_ORC then
				 //
				heroes[1] = BLADE_MASTER; //set heroes[1] = BLADE_MASTER
				heroes[2] = FAR_SEER; //set heroes[2] = FAR_SEER
				heroes[3] = TAUREN_CHIEF; //set heroes[3] = TAUREN_CHIEF
				heroes[4] = SHADOW_HUNTER; //set heroes[4] = SHADOW_HUNTER
				 //
			} else if (raceid == RACE_NIGHTELF) { //elseif raceid == RACE_NIGHTELF then
				 //
				heroes[1] = DEMON_HUNTER; //set heroes[1] = DEMON_HUNTER
				heroes[2] = KEEPER; //set heroes[2] = KEEPER
				heroes[3] = MOON_BABE; //set heroes[3] = MOON_BABE
				heroes[4] = WARDEN; //set heroes[4] = WARDEN
				 //
			} else if (raceid == RACE_UNDEAD) { //elseif raceid == RACE_UNDEAD then
				 //
				heroes[1] = DEATH_KNIGHT; //set heroes[1] = DEATH_KNIGHT
				heroes[2] = DREAD_LORD; //set heroes[2] = DREAD_LORD
				heroes[3] = LICH; //set heroes[3] = LICH
				heroes[4] = CRYPT_LORD; //set heroes[4] = CRYPT_LORD
			} else { //else
				hero_id = 0; //set hero_id = 0
			} //endif
			if (VersionCompatible(VERSION_FROZEN_THRONE)) { //if VersionCompatible(VERSION_FROZEN_THRONE) then
				last = 4; //set last = 4
			} else { //else
				last = 3; //set last = 3
			} //endif
			first = GetRandomInt(1,last); //set first  = GetRandomInt(1,last)
			second = GetRandomInt(1,last-1); //set second = GetRandomInt(1,last-1)
			third = GetRandomInt(1,last-2); //set third  = GetRandomInt(1,last-2)
			hero_id = heroes[first]; //set hero_id        = heroes[first]
			heroes[first] = heroes[last]; //set heroes[first]  = heroes[last]
			hero_id2 = heroes[second]; //set hero_id2       = heroes[second]
			heroes[second] = heroes[last-1]; //set heroes[second] = heroes[last-1]
			hero_id3 = heroes[third]; //set hero_id3       = heroes[third]
			return hero_id; //return hero_id
		} //endfunction

	
	}
}

