using System;
using System.Collections.Generic;

namespace Jass {

	public class HumanAi {

		//
		//
		//
		//
		//
		//
		private void set_skills() {//function set_skills takes nothing returns nothing
			//
			if (hero_id == PALADIN) {//if hero_id == PALADIN then
				//
				skills1[10] = DIVINE_SHIELD;//set skills1[10] = DIVINE_SHIELD
			}//endif
			//
			if (hero_id2 == PALADIN) {//if hero_id2 == PALADIN then
				//
				skills2[10] = DIVINE_SHIELD;//set skills2[10] = DIVINE_SHIELD
			}//endif
			//
			if (hero_id == MTN_KING) {//if hero_id == MTN_KING then
				//
				skills1[10] = THUNDER_CLAP;//set skills1[10] = THUNDER_CLAP
			}//endif
			//
			if (hero_id2 == MTN_KING) {//if hero_id2 == MTN_KING then
				//
				skills2[10] = THUNDER_BOLT;//set skills2[10] = THUNDER_BOLT
			}//endif
			//
			if (hero_id == ARCHMAGE) {//if hero_id == ARCHMAGE then
				//
				skills1[10] = BLIZZARD;//set skills1[10] = BLIZZARD
			}//endif
			//
			if (hero_id2 == ARCHMAGE) {//if hero_id2 == ARCHMAGE then
				//
				skills2[10] = BLIZZARD;//set skills2[10] = BLIZZARD
			}//endif
		}//endfunction
		//
		//
		//
		private void setup_force() {//function setup_force takes nothing returns nothing
			int foot;//local integer foot
			int knight;//local integer knight
			AwaitMeleeHeroes();//call AwaitMeleeHeroes()
			while (true) {//loop
				foot = GetUnitCountDone(FOOTMAN);//set foot = GetUnitCountDone(FOOTMAN)
				if (foot >= 5) { break; }//exitwhen foot >= 5
				knight = GetUnitCountDone(KNIGHT);//set knight = GetUnitCountDone(KNIGHT)
				if (foot + 2*knight >= 6) { break; }//exitwhen foot + 2*knight >= 6
				Sleep(2);//call Sleep(2)
			}//endloop
			InitAssaultGroup();//call InitAssaultGroup()
			RemoveInjuries();//call RemoveInjuries()
			SetAssaultGroup(1, 9, hero_id);//call SetAssaultGroup( 1, 9, hero_id     )
			SetAssaultGroup(0, 9, hero_id2);//call SetAssaultGroup( 0, 9, hero_id2    )
			SetAssaultGroup(0, 9, FOOTMEN);//call SetAssaultGroup( 0, 9, FOOTMEN     )
			SetAssaultGroup(0, 9, KNIGHT);//call SetAssaultGroup( 0, 9, KNIGHT      )
			SetAssaultGroup(0, 9, RIFLEMEN);//call SetAssaultGroup( 0, 9, RIFLEMEN    )
			SetAssaultGroup(0, 9, PRIEST);//call SetAssaultGroup( 0, 9, PRIEST      )
			SetAssaultGroup(0, 9, SORCERESS);//call SetAssaultGroup( 0, 9, SORCERESS   )
			SetAssaultGroup(0, 9, GRYPHON);//call SetAssaultGroup( 0, 9, GRYPHON     )
			SetAssaultGroup(0, 9, COPTER);//call SetAssaultGroup( 0, 9, COPTER      )
			SetAssaultGroup(0, 9, MORTAR);//call SetAssaultGroup( 0, 9, MORTAR      )
			SetInitialWave(10);//call SetInitialWave(10)
		}//endfunction
		//
		//
		//
		private void attack_sequence() {//function attack_sequence takes nothing returns nothing
			bool needs_exp;//local boolean needs_exp
			bool has_siege;//local boolean has_siege
			bool major_ok;//local boolean major_ok
			bool air_units;//local boolean air_units
			while (true) {//loop
				if (GetUnitCountDone(hero_id)>0) { break; }//exitwhen GetUnitCountDone(hero_id)>0
				Sleep(2);//call Sleep(2)
			}//endloop
			StaggerSleep(0,2);//call StaggerSleep(0,2)
			while (true) {//loop
				while (true) {//loop
					if (!CaptainRetreating()) { break; }//exitwhen not CaptainRetreating()
					Sleep(2);//call Sleep(2)
				}//endloop
				setup_force();//call setup_force()
				major_ok = GetUnitCountDone(RIFLEMAN)>=2;//set major_ok         = GetUnitCountDone(RIFLEMAN)>=2
				needs_exp = take_exp and major_ok;//set needs_exp        = take_exp and major_ok
				has_siege = GetUnitCountDone(MORTAR)>0 or GetUnitCountDone(TANK)>0;//set has_siege        = GetUnitCountDone(MORTAR)>0 or GetUnitCountDone(TANK)>0
				air_units = GetUnitCountDone(COPTER)>0 or GetUnitCountDone(GRYPHON)>0;//set air_units        = GetUnitCountDone(COPTER)>0 or GetUnitCountDone(GRYPHON)>0
				allow_air_creeps = air_units or major_ok;//set allow_air_creeps = air_units or major_ok
				SingleMeleeAttack(needs_exp,has_siege,major_ok,air_units);//call SingleMeleeAttack(needs_exp,has_siege,major_ok,air_units)
			}//endloop
		}//endfunction
		//
		//
		//
		private void init_booleans() {//function init_booleans takes nothing returns nothing
			C_footmen = GetUnitCount(FOOTMEN);//set C_footmen   = GetUnitCount(FOOTMEN)
			C_priest = GetUnitCount(PRIEST);//set C_priest    = GetUnitCount(PRIEST)
			C_riflemen = GetUnitCount(RIFLEMAN);//set C_riflemen  = GetUnitCount(RIFLEMAN)
			C_gyro = GetUnitCount(COPTER);//set C_gyro      = GetUnitCount(COPTER)
			C_gryphon = GetUnitCount(GRYPHON);//set C_gryphon   = GetUnitCount(GRYPHON)
			keep = TownCountDone(KEEP)>0;//set keep        = TownCountDone(KEEP)>0
			castle = GetUnitCountDone(CASTLE)>0;//set castle      = GetUnitCountDone(CASTLE)>0
			mill = GetUnitCountDone(LUMBER_MILL)>0;//set mill        = GetUnitCountDone(LUMBER_MILL)>0
			smith = GetUnitCountDone(BLACKSMITH)>0;//set smith       = GetUnitCountDone(BLACKSMITH)>0
			barracks = GetUnitCountDone(BARRACKS)>0;//set barracks    = GetUnitCountDone(BARRACKS)>0
			knights = barracks and mill and smith and castle;//set knights     = barracks and mill and smith and castle
			workshop = GetUnitCountDone(WORKSHOP)>0;//set workshop    = GetUnitCountDone(WORKSHOP)>0
			sanctum = GetUnitCountDone(SANCTUM)>0;//set sanctum     = GetUnitCountDone(SANCTUM)>0
			aviary = GetUnitCountDone(AVIARY)>0;//set aviary      = GetUnitCountDone(AVIARY)>0
			priests = C_priest>0;//set priests     = C_priest>0
			sorcery = GetUnitCount(SORCERESS)>0;//set sorcery     = GetUnitCount(SORCERESS)>0
			if (workshop && (castle || GetUpgradeLevel(UPG_BOMBS)>0)) {//if workshop and (castle or GetUpgradeLevel(UPG_BOMBS)>0) then
				if (aviary) {//if aviary then
					max_rifle = 0;//set max_rifle   = 0
					max_gyro = 2;//set max_gyro    = 2
					max_gryphon = 2;//set max_gryphon = 2
				} else {//else
					max_rifle = 3;//set max_rifle   = 3
					max_gyro = 1;//set max_gyro    = 1
					max_gryphon = 0;//set max_gryphon = 0
				}//endif
			} else {//else
				if (aviary) {//if aviary then
					max_rifle = 1;//set max_rifle   = 1
					max_gyro = 0;//set max_gyro    = 0
					max_gryphon = 2;//set max_gryphon = 2
				} else {//else
					max_rifle = 4;//set max_rifle   = 4
					max_gyro = 0;//set max_gyro    = 0
					max_gryphon = 0;//set max_gryphon = 0
				}//endif
			}//endif
		}//endfunction
		//
		//
		//
		private void upgrade_sequence() {//function upgrade_sequence takes nothing returns nothing
			//
			//
			if (barracks) {//if barracks then
				SetBuildUpgr(1, UPG_DEFEND);//call SetBuildUpgr( 1, UPG_DEFEND )
				if (workshop) {//if workshop then
					SetBuildUpgr(1, UPG_GUN_RANGE);//call SetBuildUpgr( 1, UPG_GUN_RANGE )
				}//endif
				if (knights) {//if knights then
					SetBuildUpgr(1, UPG_BREEDING);//call SetBuildUpgr( 1, UPG_BREEDING )
				}//endif
			}//endif
			//
			//
			if (smith) {//if smith then
				SetBuildUpgr(1, UPG_MELEE);//call SetBuildUpgr( 1, UPG_MELEE   )
				SetBuildUpgr(1, UPG_ARMOR);//call SetBuildUpgr( 1, UPG_ARMOR   )
				SetBuildUpgr(1, UPG_RANGED);//call SetBuildUpgr( 1, UPG_RANGED  )
				SetBuildUpgr(1, UPG_LEATHER);//call SetBuildUpgr( 1, UPG_LEATHER )
				if (keep) {//if keep then
					SetBuildUpgr(2, UPG_MELEE);//call SetBuildUpgr( 2, UPG_MELEE   )
					SetBuildUpgr(2, UPG_ARMOR);//call SetBuildUpgr( 2, UPG_ARMOR   )
					SetBuildUpgr(2, UPG_RANGED);//call SetBuildUpgr( 2, UPG_RANGED  )
					SetBuildUpgr(2, UPG_LEATHER);//call SetBuildUpgr( 2, UPG_LEATHER )
					if (castle) {//if castle then
						SetBuildUpgr(3, UPG_MELEE);//call SetBuildUpgr( 3, UPG_MELEE   )
						SetBuildUpgr(3, UPG_ARMOR);//call SetBuildUpgr( 3, UPG_ARMOR   )
						SetBuildUpgr(3, UPG_RANGED);//call SetBuildUpgr( 3, UPG_RANGED  )
						SetBuildUpgr(3, UPG_LEATHER);//call SetBuildUpgr( 3, UPG_LEATHER )
					}//endif
				}//endif
			}//endif
			//
			//
			if (sanctum && priests) {//if sanctum and priests then
				SetBuildUpgr(1, UPG_PRAYING);//call SetBuildUpgr( 1, UPG_PRAYING )
				if (sorcery) {//if sorcery then
					SetBuildUpgr(1, UPG_SORCERY);//call SetBuildUpgr( 1, UPG_SORCERY )
				}//endif
				if (castle && priests) {//if castle and priests then
					SetBuildUpgr(2, UPG_PRAYING);//call SetBuildUpgr( 2, UPG_PRAYING  )
					if (sorcery) {//if sorcery then
						SetBuildUpgr(2, UPG_SORCERY);//call SetBuildUpgr( 2, UPG_SORCERY  )
						SetBuildUpgr(1, UPG_SENTINEL);//call SetBuildUpgr( 1, UPG_SENTINEL )
					}//endif
				}//endif
			}//endif
			//
			//
			if (mill && keep) {//if mill and keep then
				SetBuildUpgr(1, UPG_WOOD);//call SetBuildUpgr( 1, UPG_WOOD )
				if (castle) {//if castle then
					SetBuildUpgr(2, UPG_WOOD);//call SetBuildUpgr( 2, UPG_WOOD    )
					SetBuildUpgr(2, UPG_MASONRY);//call SetBuildUpgr( 2, UPG_MASONRY )
				}//endif
			}//endif
			//
			//
			if (workshop && C_gyro>0) {//if workshop and C_gyro>0 then
				SetBuildUpgr(1, UPG_BOMBS);//call SetBuildUpgr( 1, UPG_BOMBS )
			}//endif
			//
			//
			if (aviary && C_gryphon>0) {//if aviary and C_gryphon>0 then
				SetBuildUpgr(1, UPG_HAMMERS);//call SetBuildUpgr( 1, UPG_HAMMERS )
			}//endif
		}//endfunction
		//
		//
		//
		private void basic_ranged() {//function basic_ranged takes integer food returns nothing
			int C_rifle = GetUnitCount(COPTER);//local integer C_rifle = GetUnitCount(COPTER)
			int rifle;//local integer rifle
			int gyro;//local integer gyro
			int gryphon;//local integer gryphon
			rifle = (food - 2*C_gyro  - 4*C_gryphon) / 3;//set rifle   = (food - 2*C_gyro  - 4*C_gryphon) / 3
			gyro = (food - 3*C_rifle - 4*C_gryphon) / 2;//set gyro    = (food - 3*C_rifle - 4*C_gryphon) / 2
			gryphon = (food - 3*C_rifle - 2*C_gyro   ) / 4;//set gryphon = (food - 3*C_rifle - 2*C_gyro   ) / 4
			if (rifle > max_rifle) {//if rifle > max_rifle then
				rifle = max_rifle;//set rifle = max_rifle
			}//endif
			if (gyro > max_gyro) {//if gyro > max_gyro then
				gyro = max_gyro;//set gyro = max_gyro
			}//endif
			if (gryphon > max_gryphon) {//if gryphon > max_gryphon then
				gryphon = max_gryphon;//set gryphon = max_gryphon
			}//endif
			if (rifle <= max_rifle) {//if rifle <= max_rifle then
				SetBuildUnit(rifle,   RIFLEMAN);//call SetBuildUnit( rifle,   RIFLEMAN )
			}//endif
			if (gyro <= max_gyro) {//if gyro <= max_gyro then
				SetBuildUnit(gyro,    COPTER);//call SetBuildUnit( gyro,    COPTER   )
			}//endif
			if (gryphon <= max_gryphon) {//if gryphon <= max_gryphon then
				SetBuildUnit(gryphon, GRYPHON);//call SetBuildUnit( gryphon, GRYPHON  )
			}//endif
		}//endfunction
		//
		//
		//
		private void forces_sequence() {//function forces_sequence takes nothing returns nothing
			int farms = GetUnitCountDone(HOUSE) + 2*TownCountDone(TOWN_HALL);//local integer farms = GetUnitCountDone(HOUSE) + 2*TownCountDone(TOWN_HALL)
			//
			//
			if (farms < 9) {//if farms < 9 then
				return;//return
			}//endif
			if (knights) {//if knights then
				SetBuildUnit((8 - GetUnitCount(FOOTMAN)) / 2, KNIGHT);//call SetBuildUnit( (8 - GetUnitCount(FOOTMAN)) / 2, KNIGHT )
			}//endif
			//
			//
			if (farms < 10) {//if farms < 10 then
				return;//return
			}//endif
			if (workshop) {//if workshop then
				SetBuildUnit(2, MORTAR);//call SetBuildUnit( 2, MORTAR )
			}//endif
			//
			//
			if (farms < 11) {//if farms < 11 then
				return;//return
			}//endif
			if (sanctum) {//if sanctum then
				SetBuildUnit(3, PRIEST);//call SetBuildUnit( 3, PRIEST    )
			}//endif
			if (farms < 12) {//if farms < 12 then
				return;//return
			}//endif
			if (sanctum && GetUpgradeLevel(UPG_SORCERY)>=2) {//if sanctum and GetUpgradeLevel(UPG_SORCERY)>=2 then
				SetBuildUnit(3, SORCERESS);//call SetBuildUnit( 3, SORCERESS )
			} else {//else
				SetBuildUnit(1, SORCERESS);//call SetBuildUnit( 1, SORCERESS )
			}//endif
		}//endfunction
		//
		//
		//
		private void basic_melee() {//function basic_melee takes integer food returns nothing
			FoodPool(food,  true,FOOTMAN,2,  knights,KNIGHT,4);//call FoodPool( food,  true,FOOTMAN,2,  knights,KNIGHT,4 )
		}//endfunction
		//
		//
		//
		private void build_sequence() {//function build_sequence takes nothing returns nothing
			int mines = GetMinesOwned();//local integer mines = GetMinesOwned()
			InitBuildArray();//call InitBuildArray()
			init_booleans();//call init_booleans()
			MeleeTownHall(0, TOWN_HALL);//call MeleeTownHall( 0, TOWN_HALL )
			MeleeTownHall(1, TOWN_HALL);//call MeleeTownHall( 1, TOWN_HALL )
			SetBuildUnit(1, TOWN_HALL);//call SetBuildUnit( 1, TOWN_HALL     )
			SetBuildUnit(6, PEASANT);//call SetBuildUnit( 6, PEASANT       )
			BuildFactory(BARRACKS);//call BuildFactory(    BARRACKS      )
			SetBuildUnit(8, PEASANT);//call SetBuildUnit( 8, PEASANT       )
			SetBuildUnit(1, HOUSE);//call SetBuildUnit( 1, HOUSE         )
			SetBuildUnit(10, PEASANT);//call SetBuildUnit(10, PEASANT       )
			basic_melee(2);//call basic_melee( 2 )
			SetBuildUnit(1, HUMAN_ALTAR);//call SetBuildUnit( 1, HUMAN_ALTAR   )
			SetBuildUnit(11, PEASANT);//call SetBuildUnit(11, PEASANT       )
			SetBuildUnit(2, HOUSE);//call SetBuildUnit( 2, HOUSE         )
			basic_melee(6);//call basic_melee( 6 )
			SetBuildUnit(1, hero_id);//call SetBuildUnit( 1, hero_id       )
			SetBuildUnit(3, HOUSE);//call SetBuildUnit( 3, HOUSE         )
			basic_melee(10);//call basic_melee( 10 )
			if (startup) {//if startup then
				if (GetUnitCountDone(FOOTMAN)<5) {//if GetUnitCountDone(FOOTMAN)<5 then
					return;//return
				}//endif
				startup = false;//set startup = false
			}//endif
			SetBuildUpgr(1, UPG_DEFEND);//call SetBuildUpgr( 1, UPG_DEFEND    )
			SetBuildUnit(1, BLACKSMITH);//call SetBuildUnit( 1, BLACKSMITH    )
			SetBuildUnit(1, LUMBER_MILL);//call SetBuildUnit( 1, LUMBER_MILL   )
			SetBuildUnit(4, HOUSE);//call SetBuildUnit( 4, HOUSE         )
			basic_melee(12);//call basic_melee( 12 )
			basic_ranged(3);//call basic_ranged( 3 )
			SetBuildUpgr(1, UPG_ARMOR);//call SetBuildUpgr( 1, UPG_ARMOR     )
			SetBuildUnit(5, HOUSE);//call SetBuildUnit( 5, HOUSE         )
			basic_ranged(6);//call basic_ranged( 6 )
			SetBuildUnit(1, KEEP);//call SetBuildUnit( 1, KEEP          )
			basic_ranged(9);//call basic_ranged( 9 )
			SetBuildUpgr(1, UPG_MELEE);//call SetBuildUpgr( 1, UPG_MELEE     )
			basic_ranged(12);//call basic_ranged( 12 )
			UpgradeAll(WATCH_TOWER, GUARD_TOWER);//call UpgradeAll( WATCH_TOWER, GUARD_TOWER )
			SetBuildUnit(2, WATCH_TOWER);//call SetBuildUnit( 2, WATCH_TOWER   )
			SetBuildUpgr(1, UPG_RANGED);//call SetBuildUpgr( 1, UPG_RANGED    )
			BasicExpansion(mines < 2, TOWN_HALL);//call BasicExpansion( mines < 2, TOWN_HALL )
			SetBuildUnit(6, HOUSE);//call SetBuildUnit( 6, HOUSE         )
			GuardSecondary(1, 2, WATCH_TOWER);//call GuardSecondary( 1, 2, WATCH_TOWER )
			GuardSecondary(2, 2, WATCH_TOWER);//call GuardSecondary( 2, 2, WATCH_TOWER )
			SetBuildUpgr(1, UPG_LEATHER);//call SetBuildUpgr( 1, UPG_LEATHER   )
			SetBuildUpgr(1, UPG_WOOD);//call SetBuildUpgr( 1, UPG_WOOD      )
			SetBuildUnit(1, hero_id2);//call SetBuildUnit( 1, hero_id2      )
			if (mines > 1) {//if mines > 1 then
				SetBuildUnit(14, PEASANT);//call SetBuildUnit( 14, PEASANT  )
			}//endif
			forces_sequence();//call forces_sequence()
			upgrade_sequence();//call upgrade_sequence()
			BuildFactory(WORKSHOP);//call BuildFactory( WORKSHOP )
			if (GetUnitCount(MORTAR)<1) {//if GetUnitCount(MORTAR)<1 then
				return;//return
			}//endif
			BuildFactory(SANCTUM);//call BuildFactory( SANCTUM )
			SetBuildUnit(1, CASTLE);//call SetBuildUnit( 1, CASTLE        )
			SetBuildUnit(8, HOUSE);//call SetBuildUnit( 8, HOUSE         )
			SetBuildUnit(1, AVIARY);//call SetBuildUnit( 1, AVIARY        )
			if (GetUnitCount(AVIARY)>0 && GetUnitCount(ZEPPELIN)<3) {//if GetUnitCount(AVIARY)>0 and GetUnitCount(ZEPPELIN)<3 then
				GetZeppelin();//call GetZeppelin()
			}//endif
			MeleeTownHall(2, TOWN_HALL);//call MeleeTownHall( 2, TOWN_HALL )
			BasicExpansion(mines < 3, TOWN_HALL);//call BasicExpansion( mines < 3, TOWN_HALL )
		}//endfunction
		//
		//
		//
		private void peon_assignment() {//function peon_assignment takes nothing returns nothing
			int halls = TownCountDone(TOWN_HALL);//local integer halls = TownCountDone(TOWN_HALL)
			int T;//local integer T
			while (true) {//loop
				ClearHarvestAI();//call ClearHarvestAI()
				T = TownWithMine();//set T = TownWithMine()
				HarvestGold(T,5);//call HarvestGold(T,5)
				HarvestWood(0,2);//call HarvestWood(0,2)
				if (TownCountDone(TOWN_HALL)>1) {//if TownCountDone(TOWN_HALL)>1 then
					HarvestGold(T+1,4);//call HarvestGold(T+1,4)
				}//endif
				HarvestWood(0,15);//call HarvestWood(0,15)
				build_sequence();//call build_sequence()
				Sleep(3);//call Sleep(3)
			}//endloop
		}//endfunction
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			do_debug_cheats = GetAiPlayer()==1;//set do_debug_cheats = GetAiPlayer()==1
			PickMeleeHero(RACE_HUMAN);//call PickMeleeHero(RACE_HUMAN)
			set_skills();//call set_skills()
			StandardAI(function SkillArrays, function peon_assignment, function attack_sequence);//call StandardAI(function SkillArrays, function peon_assignment, function attack_sequence)
			PlayGame();//call PlayGame()
		}//endfunction

	
	}
}

