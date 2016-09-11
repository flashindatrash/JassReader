using System;
using System.Collections.Generic;

namespace Jass {

	public class DemoAi {

		//
		//
		//
		//
		private void set_build(int qty, int id) {//function set_build takes integer qty, integer id returns nothing
			build_qty[build_index] = qty;//set build_qty[build_index] = qty
			build_item[build_index] = id;//set build_item[build_index] = id
			build_type[build_index] = NORMAL;//set build_type[build_index] = NORMAL
			build_index = build_index + 1;//set build_index = build_index + 1
		}//endfunction
		//
		private void set_upgrd(int qty, int id) {//function set_upgrd takes integer qty, integer id returns nothing
			build_qty[build_index] = qty;//set build_qty[build_index] = qty
			build_item[build_index] = id;//set build_item[build_index] = id
			build_type[build_index] = UPGRADE;//set build_type[build_index] = UPGRADE
			build_index = build_index + 1;//set build_index = build_index + 1
		}//endfunction
		//
		private void set_assault(int qty, int id) {//function set_assault takes integer qty, integer id returns nothing
			assault_qty[assault_index] = qty;//set assault_qty[assault_index] = qty
			assault_qty[assault_index] = qty;//set assault_qty[assault_index] = qty
			assault_item[assault_index] = id;//set assault_item[assault_index] = id
			assault_index = assault_index + 1;//set assault_index = assault_index + 1
		}//endfunction
		//
		private void paladin_sequence() {//function paladin_sequence takes nothing returns nothing
			build_index = 0;//set build_index = 0
			set_build(1, town_hall);//call set_build(1, town_hall )
			set_build(4, peon);//call set_build(4, peon      )
			set_build(7, peon);//call set_build(7, peon      )
			set_build(1, house);//call set_build(1, house     )
			set_build(9, peon);//call set_build(9, peon      )
			set_build(1, garrison);//call set_build(1, garrison  )
			set_build(1, paladin);//call set_build(1, paladin   )
			set_build(1, smith);//call set_build(1, smith     )
			set_build(1, footman);//call set_build(1, footman   )
			set_build(2, house);//call set_build(2, house     )
			set_upgrd(1, Uweapons);//call set_upgrd(1, Uweapons  )
			set_build(4, footman);//call set_build(4, footman   )
			set_upgrd(1, Uarmor);//call set_upgrd(1, Uarmor    )
			set_build(3, rifle);//call set_build(3, rifle     )
			//
			set_build(6, footman);//call set_build(6, footman   )
			set_build(4, rifle);//call set_build(4, rifle     )
			set_upgrd(2, Uweapons);//call set_upgrd(2, Uweapons  )
			set_build(6, rifle);//call set_build(6, rifle     )
			//
			set_build(1, mill);//call set_build(1, mill      )
			set_upgrd(2, Uarmor);//call set_upgrd(2, Uarmor    )
			set_build(3, house);//call set_build(3, house     )
			return;//return
			set_build(6, peon);//call set_build(6, peon      )
			set_build(1, house);//call set_build(1, house     )
			set_build(4, footman);//call set_build(4, footman   )
			//
			set_build(2, rifle);//call set_build(2, rifle     )
			set_build(1, keep);//call set_build(1, keep      )
			set_build(2, house);//call set_build(2, house     )
			set_build(5, footman);//call set_build(5, footman   )
			set_build(4, rifle);//call set_build(4, rifle     )
			//
			set_build(1, armory);//call set_build(1, armory    )
			set_upgrd(2, Uarmor);//call set_upgrd(2, Uarmor    )
			set_build(1, altar);//call set_build(1, altar     )
			set_upgrd(1, Uranged);//call set_upgrd(1, Uranged   )
			set_build(1, church);//call set_build(1, church    )
			set_upgrd(2, Uranged);//call set_upgrd(2, Uranged   )
			set_upgrd(3, Uweapons);//call set_upgrd(3, Uweapons  )
			set_build(1, priest);//call set_build(1, priest    )
			//
			set_build(6, footman);//call set_build(6, footman   )
			set_build(5, rifle);//call set_build(5, rifle     )
			set_build(2, priest);//call set_build(2, priest    )
			//
			set_build(3, priest);//call set_build(3, priest    )
			set_build(6, rifle);//call set_build(6, rifle     )
			set_build(3, house);//call set_build(3, house     )
			//
			set_upgrd(3, Uranged);//call set_upgrd(3, Uranged   )
			set_upgrd(3, Uarmor);//call set_upgrd(3, Uarmor    )
			set_build(1, castle);//call set_build(1, castle    )
			set_build(7, rifle);//call set_build(7, rifle     )
			set_build(4, priest);//call set_build(4, priest    )
			set_build(8, rifle);//call set_build(8, rifle     )
			set_build(2, knight);//call set_build(2, knight    )
			set_build(4, house);//call set_build(4, house     )
			set_build(1, sanctum);//call set_build(1, sanctum   )
			set_build(4, knight);//call set_build(4, knight    )
			set_build(5, house);//call set_build(5, house     )
			set_build(1, caster);//call set_build(1, caster    )
			set_build(5, knight);//call set_build(5, knight    )
			set_build(2, caster);//call set_build(2, caster    )
			set_build(9, rifle);//call set_build(9, rifle     )
			set_build(3, caster);//call set_build(3, caster    )
			set_build(6, house);//call set_build(6, house     )
			set_build(11, rifle);//call set_build(11, rifle    )
			set_build(5, priest);//call set_build(5, priest    )
			set_upgrd(1, Ubldgs);//call set_upgrd(1, Ubldgs    )
			set_upgrd(1, Uartillery);//call set_upgrd(1, Uartillery)
			set_upgrd(2, Uartillery);//call set_upgrd(2, Uartillery)
			set_upgrd(3, Uartillery);//call set_upgrd(3, Uartillery)
			set_upgrd(2, Ubldgs);//call set_upgrd(2, Ubldgs    )
			set_upgrd(3, Ubldgs);//call set_upgrd(3, Ubldgs    )
			set_build(0,0);//call set_build(0,0)
		}//endfunction
		//
		private void paladin_assault() {//function paladin_assault takes nothing returns nothing
			assault_index = 0;//set assault_index = 0
			if (assaultN <= 1) {//if assaultN <= 1 then
				set_assault(1, paladin);//call set_assault(1, paladin     )
				set_assault(4, footman);//call set_assault(4, footman     )
				set_assault(3, rifle);//call set_assault(3, rifle       )
			} else if (assaultN <= 2) {//elseif assaultN <= 2 then
				set_assault(1, paladin);//call set_assault(1, paladin     )
				set_assault(6, footman);//call set_assault(6, footman     )
				set_assault(6, rifle);//call set_assault(6, rifle       )
			}//endif
			set_assault(0,0);//call set_assault(0,0)
		}//endfunction
		//
		private int hero_levels() {//function hero_levels takes nothing returns integer
			int hero = GetHeroId();//local integer hero = GetHeroId()
			int level = GetHeroLevelAI();//local integer level = GetHeroLevelAI()
			//
			if (hero == paladin) {//if hero == paladin then
				//
				//
				//
				if (level <= 4) {//if level <= 4 then
					return 'AHre';//return 'AHre'
				}//endif
				//
				if (level <= 7) {//if level <= 7 then
					return 'AHad';//return 'AHad'
				}//endif
				//
				return 'AHex';//return 'AHex'
			}//endif
			if (hero == 'Edem') {//if hero == 'Edem' then
				if (level == 1) {//if level == 1 then
					return 'AEso';//return 'AEso'
				}//endif
				if (level == 2) {//if level == 2 then
					return 'AEfl';//return 'AEfl'
				}//endif
				if (level == 3) {//if level == 3 then
					return 'AEso';//return 'AEso'
				}//endif
				if (level == 4) {//if level == 4 then
					return 'AEfl';//return 'AEfl'
				}//endif
				if (level == 5) {//if level == 5 then
					return 'AEme';//return 'AEme'
				}//endif
			}//endif
			return 0;//return 0
		}//endfunction
		//
		private bool set_upgrade(int level, int upgid) {//function set_upgrade takes integer level, integer upgid returns boolean
			int gold_cost;//local integer gold_cost
			int wood_cost;//local integer wood_cost
			int stone_cost;//local integer stone_cost
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
			stone_cost = GetUpgradeStoneCost(upgid);//set stone_cost = GetUpgradeStoneCost(upgid)
			//
			//
			//
			return total_stones < stone_cost or SetUpgrade(upgid);//return total_stones < stone_cost or SetUpgrade(upgid)
		}//endfunction
		//
		private bool set_start(int ask_qty, int unitid) {//function set_start takes integer ask_qty, integer unitid returns boolean
			int have_qty;//local integer have_qty
			int need_qty;//local integer need_qty
			int afford_gold;//local integer afford_gold
			int afford_wood;//local integer afford_wood
			int afford_stones;//local integer afford_stones
			int afford_qty;//local integer afford_qty
			int gold_cost;//local integer gold_cost
			int wood_cost;//local integer wood_cost
			int stone_cost;//local integer stone_cost
			//
			//
			//
			have_qty = GetUnitCount(unitid);//set have_qty = GetUnitCount(unitid)
			if (have_qty >= ask_qty) {//if have_qty >= ask_qty then
				return true;//return true
			}//endif
			need_qty = ask_qty - have_qty;//set need_qty = ask_qty - have_qty
			//
			//
			//
			//
			gold_cost = GetUnitGoldCost(unitid);//set gold_cost = GetUnitGoldCost(unitid)
			wood_cost = GetUnitWoodCost(unitid);//set wood_cost = GetUnitWoodCost(unitid)
			stone_cost = GetUnitStoneCost(unitid);//set stone_cost = GetUnitStoneCost(unitid)
			if (gold_cost == 0) {//if gold_cost == 0 then
				afford_gold = need_qty;//set afford_gold = need_qty
			} else {//else
				afford_gold = total_gold / gold_cost;//set afford_gold = total_gold / gold_cost
			}//endif
			if (wood_cost == 0) {//if wood_cost == 0 then
				afford_wood = need_qty;//set afford_wood = need_qty
			} else {//else
				afford_wood = total_wood / wood_cost;//set afford_wood = total_wood / wood_cost
			}//endif
			afford_qty = need_qty;//set afford_qty = need_qty
			if (afford_gold < afford_qty) {//if afford_gold < afford_qty then
				afford_qty = afford_gold;//set afford_qty = afford_gold
			}//endif
			if (afford_wood < afford_qty) {//if afford_wood < afford_qty then
				afford_qty = afford_wood;//set afford_qty = afford_wood
			}//endif
			if (stone_cost > 0) {//if stone_cost > 0 then
				afford_stones = total_stones / stone_cost;//set afford_stones = total_stones / stone_cost
				if (afford_stones < 1) {//if afford_stones < 1 then
					return true;//return true
				}//endif
				if (afford_stones < afford_qty) {//if afford_stones < afford_qty then
					afford_qty = afford_stones;//set afford_qty = afford_stones
				}//endif
			} else {//else
				if (afford_qty < 1) {//if afford_qty < 1 then
					return false;//return false
				}//endif
			}//endif
			//
			//
			//
			//
			total_gold = total_gold   - gold_cost  * need_qty;//set total_gold   = total_gold   - gold_cost  * need_qty
			total_stones = total_stones - stone_cost * need_qty;//set total_stones = total_stones - stone_cost * need_qty
			//
			//
			//
			//
			//
			return SetProduce(afford_qty,unitid);//return SetProduce(afford_qty,unitid)
		}//endfunction
		//
		private bool set_start_peons(int max) {//function set_start_peons takes integer max returns boolean
			int have = GetUnitCount(peon);//local integer have = GetUnitCount(peon)
			if (have >= max) {//if have >= max then
				return true;//return true
			}//endif
			if (GetAiMineBusy()) {//if GetAiMineBusy() then
				return true;//return true
			}//endif
			return set_start(have + 1,peon);//return set_start(have + 1,peon)
		}//endfunction
		//
		private void setup_assault() {//function setup_assault takes nothing returns nothing
			int index = 0;//local integer index = 0
			int qty;//local integer qty
			StartAssault();//call StartAssault()
			while (true) {//loop
				qty = assault_qty[index];//set qty = assault_qty[index]
				if (qty == 0) { break; }//exitwhen qty == 0
				AddAssault(qty,assault_item[index]);//call AddAssault(qty,assault_item[index])
				index = index + 1;//set index = index + 1
			}//endloop
		}//endfunction
		//
		private void assault_sequence() {//function assault_sequence takes nothing returns nothing
			//
			//
			if (assault_state <= AWAIT_TROOPS) {//if assault_state <= AWAIT_TROOPS then
				if (assault_timer == 0) {//if assault_timer == 0 then
					assault_timer = 6;//set assault_timer = 6
				} else {//else
					assault_timer = assault_timer - 1;//set assault_timer = assault_timer - 1
					return;//return
				}//endif
			}//endif
			//
			//
			if (assault_state == NO_CREEPS) {//if assault_state == NO_CREEPS then
				if (GetUnitCount(rifle) == 8) {//if GetUnitCount(rifle) == 8 then
					if (assaultN < 100) {//if assaultN < 100 then
						assaultN = 100;//set assaultN = 100
					}//endif
					setup_assault();//call setup_assault()
					if (AttackEnemy()) {//if AttackEnemy() then
						assault_state = END_ASSAULT;//set assault_state = END_ASSAULT
					}//endif
				}//endif
			} else if (assault_state == CHECK_CREEPS) {//elseif assault_state == CHECK_CREEPS then
				if (CreepsOnMap()) {//if CreepsOnMap() then
					paladin_assault();//call paladin_assault()
					assault_state = AWAIT_TROOPS;//set assault_state = AWAIT_TROOPS
				} else {//else
					assault_state = NO_CREEPS;//set assault_state = NO_CREEPS
					CaptainGoHome();//call CaptainGoHome()
				}//endif
			} else if (assault_state == AWAIT_TROOPS) {//elseif assault_state == AWAIT_TROOPS then
				setup_assault();//call setup_assault()
				creep_target = AcquireStones();//set creep_target = AcquireStones()
				if (creep_target != null) {//if creep_target != null then
					assault_state = KILL_CREEP;//set assault_state = KILL_CREEP
				}//endif
			} else if (assault_state == KILL_CREEP) {//elseif assault_state == KILL_CREEP then
				if (!UnitAlive(creep_target)) {//if not UnitAlive(creep_target) then
					assault_state = AWAIT_BATTLE;//set assault_state = AWAIT_BATTLE
				}//endif
			} else if (assault_state == AWAIT_BATTLE) {//elseif assault_state == AWAIT_BATTLE then
				if (!CaptainInCombat()) {//if not CaptainInCombat() then
					assault_state = AWAIT_GOAL;//set assault_state = AWAIT_GOAL
				}//endif
			} else if (assault_state == AWAIT_GOAL) {//elseif assault_state == AWAIT_GOAL then
				if (CaptainAtGoal()) {//if CaptainAtGoal() then
					assault_state = RETURN_HOME;//set assault_state = RETURN_HOME
					CaptainGoHome();//call CaptainGoHome()
				}//endif
			} else if (assault_state == RETURN_HOME) {//elseif assault_state == RETURN_HOME then
				if (CaptainIsHome()) {//if CaptainIsHome() then
					assault_state = AWAIT_HEALING;//set assault_state = AWAIT_HEALING
				}//endif
			} else if (assault_state == AWAIT_HEALING) {//elseif assault_state == AWAIT_HEALING then
				if (CaptainHealth() >= 50) {//if CaptainHealth() >= 50 then
					assaultN = assaultN + 1;//set assaultN = assaultN + 1
					assault_state = CHECK_CREEPS;//set assault_state = CHECK_CREEPS
					assault_timer = 0;//set assault_timer = 0
				}//endif
			}//endif
		}//endfunction
		//
		private void peon_assignments() {//function peon_assignments takes nothing returns nothing
			if (peon_timer > 0) {//if peon_timer > 0 then
				peon_timer = peon_timer - 1;//set peon_timer = peon_timer - 1
				return;//return
			}//endif
			peon_timer = PEON_ASSIGNMENT;//set peon_timer = PEON_ASSIGNMENT
			ClearHarvestAI();//call ClearHarvestAI()
			HarvestGold(2);//call HarvestGold(2)
			HarvestWood(2);//call HarvestWood(2)
			HarvestGold(1);//call HarvestGold(1)
			HarvestWood(1);//call HarvestWood(1)
			HarvestGold(1);//call HarvestGold(1)
			HarvestWood(1);//call HarvestWood(1)
			HarvestGold(1);//call HarvestGold(1)
		}//endfunction
		//
		private bool run_build_sequence() {//function run_build_sequence takes nothing returns boolean
			int index = 0;//local integer index = 0
			int qty;//local integer qty
			int id;//local integer id
			bool built;//local boolean built
			total_gold = GetGold();//set total_gold = GetGold()
			total_wood = GetWood();//set total_wood = GetWood()
			total_stones = GetStones();//set total_stones = GetStones()
			peon_assignments();//call peon_assignments()
			while (true) {//loop
				//
				//
				//
				qty = build_qty[index];//set qty = build_qty[index]
				if (qty == 0) { break; }//exitwhen qty == 0
				id = build_item[index];//set id = build_item[index]
				//
				//
				//
				built = false;//set built = false
				if (id == town_hall) {//if id == town_hall then
					if (GetUnitCount(keep) != 0 || GetUnitCount(castle) != 0) {//if GetUnitCount(keep) != 0 or GetUnitCount(castle) != 0 then
						built = true;//set built = true
					}//endif
				} else if (id == keep) {//elseif id == keep then
					if (GetUnitCount(castle) != 0) {//if GetUnitCount(castle) != 0 then
						built = true;//set built = true
					}//endif
				}//endif
				//
				//
				//
				if (!built) {//if not built then
					//
					//
					//
					if (build_type[index] == NORMAL) {//if build_type[index] == NORMAL then
						//
						//
						//
						//
						if (id == peon) {//if id == peon then
							if (!set_start_peons(qty)) {//if not set_start_peons(qty) then
								return false;//return false
							}//endif
							//
							//
							//
						} else {//else
							if (!set_start(qty,id)) {//if not set_start(qty,id) then
								return false;//return false
							}//endif
						}//endif
					} else {//else
						//
						//
						//
						if (!set_upgrade(qty,id)) {//if not set_upgrade(qty,id) then
							return false;//return false
						}//endif
					}//endif
				}//endif
				index = index + 1;//set index = index + 1
			}//endloop
			return true;//return true
		}//endfunction
		//
		//
		//
		private void assault_loop() {//function assault_loop takes nothing returns nothing
			while (true) {//loop
				assault_sequence();//call assault_sequence()
				Sleep(5);//call Sleep(5)
			}//endloop
		}//endfunction
		private void build_loop() {//function build_loop takes nothing returns nothing
			while (true) {//loop
				run_build_sequence();//call run_build_sequence()
				Sleep(2);//call Sleep(2)
			}//endloop
		}//endfunction
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			InitAI();//call InitAI()
			SetHeroLevels(function hero_levels);//call SetHeroLevels(function hero_levels)
			CreateCaptains();//call CreateCaptains()
			paladin_sequence();//call paladin_sequence()
			StartThread(function assault_loop);//call StartThread(function assault_loop)
			StartThread(function build_loop);//call StartThread(function build_loop)
			while (true) {//loop
				if (assault_state == END_ASSAULT) { break; }//exitwhen assault_state == END_ASSAULT
				Sleep(10);//call Sleep(10)
			}//endloop
		}//endfunction

	
	}
}

