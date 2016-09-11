using System;
using System.Collections.Generic;

namespace Jass {

	public class ElfAi {

		//
		//
		//
		//
		//
		//
		private void set_skills() {//function set_skills takes nothing returns nothing
			//
			if (hero_id == MOON_CHICK) {//if hero_id == MOON_CHICK then
				//
				skills1[10] = SCOUT;//set skills1[10] = SCOUT
			}//endif
			//
			if (hero_id2 == MOON_CHICK) {//if hero_id2 == MOON_CHICK then
				//
				skills2[10] = SCOUT;//set skills2[10] = SCOUT
			}//endif
			//
			if (hero_id == KEEPER) {//if hero_id == KEEPER then
				//
				skills1[10] = THORNS_AURA;//set skills1[10] = THORNS_AURA
			}//endif
			//
			if (hero_id2 == KEEPER) {//if hero_id2 == KEEPER then
				//
				skills2[10] = FORCE_NATURE;//set skills2[10] = FORCE_NATURE
			}//endif
			//
			if (hero_id == DEMON_HUNTER) {//if hero_id == DEMON_HUNTER then
				//
				skills1[10] = IMMOLATION;//set skills1[10] = IMMOLATION
			}//endif
			//
			if (hero_id2 == DEMON_HUNTER) {//if hero_id2 == DEMON_HUNTER then
				//
				skills2[10] = IMMOLATION;//set skills2[10] = IMMOLATION
			}//endif
		}//endfunction
		//
		//
		//
		private void setup_force() {//function setup_force takes nothing returns nothing
			AwaitMeleeHeroes();//call AwaitMeleeHeroes()
			InitMeleeGroup();//call InitMeleeGroup()
			SetMeleeGroup(hero_id);//call SetMeleeGroup( hero_id     )
			SetMeleeGroup(hero_id2);//call SetMeleeGroup( hero_id2    )
			SetMeleeGroup(ARCHER);//call SetMeleeGroup( ARCHER      )
			SetMeleeGroup(HUNTRESS);//call SetMeleeGroup( HUNTRESS    )
			SetMeleeGroup(DRUID_TALON);//call SetMeleeGroup( DRUID_TALON )
			SetMeleeGroup(DRUID_CLAW);//call SetMeleeGroup( DRUID_CLAW  )
			SetMeleeGroup(DRYAD);//call SetMeleeGroup( DRYAD       )
			SetMeleeGroup(HIPPO);//call SetMeleeGroup( HIPPO       )
			SetMeleeGroup(HIPPO_RIDER);//call SetMeleeGroup( HIPPO_RIDER )
			SetMeleeGroup(CHIMAERA);//call SetMeleeGroup( CHIMAERA    )
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
			int chim;//local integer chim
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
				major_ok = GetUnitCountDone(HUNTRESS)>=2;//set major_ok         = GetUnitCountDone(HUNTRESS)>=2
				needs_exp = take_exp and (major_ok or GetGoldOwned()<2000);//set needs_exp        = take_exp and (major_ok or GetGoldOwned()<2000)
				chim = GetUnitCountDone(CHIMAERA);//set chim             = GetUnitCountDone(CHIMAERA)
				has_siege = GetUnitCountDone(BALLISTA)>0 or chim>0;//set has_siege        = GetUnitCountDone(BALLISTA)>0 or chim>0
				air_units = GetUnitCountDone(HIPPO_RIDER)>0;//set air_units        = GetUnitCountDone(HIPPO_RIDER)>0
				allow_air_creeps = air_units or GetUnitCountDone(ARCHER)>0;//set allow_air_creeps = air_units or GetUnitCountDone(ARCHER)>0
				SingleMeleeAttack(needs_exp,has_siege,major_ok,air_units);//call SingleMeleeAttack(needs_exp,has_siege,major_ok,air_units)
			}//endloop
		}//endfunction
		//
		//
		//
		private void init_booleans() {//function init_booleans takes nothing returns nothing
			C_huntress = GetUnitCount(HUNTRESS);//set C_huntress  = GetUnitCount(HUNTRESS)
			C_archers = GetUnitCount(ARCHER);//set C_archers   = GetUnitCount(ARCHER)
			C_dryads = GetUnitCount(DRYAD);//set C_dryads    = GetUnitCount(DRYAD)
			C_chimaera = GetUnitCount(CHIMAERA);//set C_chimaera  = GetUnitCount(CHIMAERA)
			lore = GetUnitCountDone(ANCIENT_LORE)>0;//set lore        = GetUnitCountDone(ANCIENT_LORE)>0
			wind = GetUnitCountDone(ANCIENT_WIND)>0;//set wind        = GetUnitCountDone(ANCIENT_WIND)>0
			ages = TownCountDone(TREE_AGES)>0;//set ages        = TownCountDone(TREE_AGES)>0
			eternity = TownCountDone(TREE_ETERNITY)>0;//set eternity    = TownCountDone(TREE_ETERNITY)>0
			war = GetUnitCountDone(ANCIENT_WAR)>0;//set war         = GetUnitCountDone(ANCIENT_WAR)>0
			hunters = GetUnitCountDone(HUNTERS_HALL)>0;//set hunters     = GetUnitCountDone(HUNTERS_HALL)>0
			ballista = GetUnitCount(BALLISTA)>0;//set ballista    = GetUnitCount(BALLISTA)>0
			claws = TownCount(DRUID_CLAW)>0;//set claws       = TownCount(DRUID_CLAW)>0
			roost = GetUnitCountDone(CHIMAERA_ROOST)>0;//set roost       = GetUnitCountDone(CHIMAERA_ROOST)>0
			use_bears = lore and GetUpgradeLevel(UPG_DRUID_CLAW)>=2;//set use_bears   = lore and GetUpgradeLevel(UPG_DRUID_CLAW)>=2
		}//endfunction
		//
		//
		//
		private void upgrade_sequence() {//function upgrade_sequence takes nothing returns nothing
			//
			//
			if (hunters) {//if hunters then
				SetBuildUpgr(1, UPG_STR_MOON);//call SetBuildUpgr( 1, UPG_STR_MOON   )
				SetBuildUpgr(1, UPG_MOON_ARMOR);//call SetBuildUpgr( 1, UPG_MOON_ARMOR )
				if (ages) {//if ages then
					SetBuildUpgr(2, UPG_STR_MOON);//call SetBuildUpgr( 2, UPG_STR_MOON   )
					SetBuildUpgr(2, UPG_MOON_ARMOR);//call SetBuildUpgr( 2, UPG_MOON_ARMOR )
					if (eternity) {//if eternity then
						SetBuildUpgr(3, UPG_STR_MOON);//call SetBuildUpgr( 3, UPG_STR_MOON   )
						SetBuildUpgr(3, UPG_MOON_ARMOR);//call SetBuildUpgr( 3, UPG_MOON_ARMOR )
					}//endif
				}//endif
				SetBuildUpgr(1, UPG_STR_WILD);//call SetBuildUpgr( 1, UPG_STR_WILD )
				SetBuildUpgr(1, UPG_HIDES);//call SetBuildUpgr( 1, UPG_HIDES    )
				if (ages) {//if ages then
					SetBuildUpgr(2, UPG_STR_WILD);//call SetBuildUpgr( 2, UPG_STR_WILD )
					SetBuildUpgr(2, UPG_HIDES);//call SetBuildUpgr( 2, UPG_HIDES    )
					if (eternity) {//if eternity then
						SetBuildUpgr(3, UPG_STR_WILD);//call SetBuildUpgr( 3, UPG_STR_WILD )
						SetBuildUpgr(3, UPG_HIDES);//call SetBuildUpgr( 3, UPG_HIDES    )
						if (ballista) {//if ballista then
							SetBuildUpgr(1, UPG_ULTRAVISION);//call SetBuildUpgr( 1, UPG_ULTRAVISION )
						}//endif
					}//endif
				}//endif
			}//endif
			//
			//
			if (war) {//if war then
				if (ages) {//if ages then
					SetBuildUpgr(1, UPG_BOWS);//call SetBuildUpgr( 1, UPG_BOWS )
					if (hunters) {//if hunters then
						SetBuildUpgr(1, UPG_BOLT);//call SetBuildUpgr( 1, UPG_BOLT )
						if (eternity) {//if eternity then
							SetBuildUpgr(1, UPG_GLAIVE);//call SetBuildUpgr( 1, UPG_GLAIVE   )
							SetBuildUpgr(1, UPG_MARKSMAN);//call SetBuildUpgr( 1, UPG_MARKSMAN )
							SetBuildUpgr(1, UPG_SCOUT);//call SetBuildUpgr( 1, UPG_SCOUT    )
						}//endif
					}//endif
				}//endif
			}//endif
			//
			//
			if (lore) {//if lore then
				SetBuildUpgr(1, UPG_DRUID_CLAW);//call SetBuildUpgr( 1, UPG_DRUID_CLAW )
				if (eternity) {//if eternity then
					SetBuildUpgr(2, UPG_DRUID_CLAW);//call SetBuildUpgr( 2, UPG_DRUID_CLAW )
				}//endif
				SetBuildUpgr(1, UPG_ABOLISH);//call SetBuildUpgr( 1, UPG_ABOLISH )
			}//endif
			//
			//
			if (lore) {//if lore then
				SetBuildUpgr(1, UPG_DRUID_TALON);//call SetBuildUpgr( 1, UPG_DRUID_TALON )
				if (eternity) {//if eternity then
					SetBuildUpgr(2, UPG_DRUID_TALON);//call SetBuildUpgr( 2, UPG_DRUID_TALON )
				}//endif
			}//endif
			//
			//
			if (roost && GetUnitCount(CHIMAERA)>0) {//if roost and GetUnitCount(CHIMAERA)>0 then
				SetBuildUpgr(1, UPG_CHIM_ACID);//call SetBuildUpgr( 1, UPG_CHIM_ACID )
			}//endif
		}//endfunction
		//
		//
		//
		private void forces_sequence() {//function forces_sequence takes nothing returns nothing
			int farms = GetUnitCountDone(MOON_WELL) + TownCountDone(TREE_LIFE);//local integer farms = GetUnitCountDone(MOON_WELL) + TownCountDone(TREE_LIFE)
			int siege_avail;//local integer siege_avail
			int count;//local integer count
			//
			//
			if (farms < 6) {//if farms < 6 then
				return;//return
			}//endif
			FoodPool(18,  true,HUNTRESS,3,  lore,DRUID_CLAW,4);//call FoodPool( 18,  true,HUNTRESS,3,  lore,DRUID_CLAW,4 )
			//
			//
			FoodPool(4,  hunters and ages,BALLISTA,4,  roost,CHIMAERA,5);//call FoodPool( 4,  hunters and ages,BALLISTA,4,  roost,CHIMAERA,5 )
			if (farms < 7) {//if farms < 7 then
				return;//return
			}//endif
			FoodPool(10,  hunters and ages,BALLISTA,4,  roost,CHIMAERA,5);//call FoodPool( 10,  hunters and ages,BALLISTA,4,  roost,CHIMAERA,5 )
			//
			//
			//
			if (wind) {//if wind then
				SetBuildUnit(2, DRUID_TALON);//call SetBuildUnit( 2, DRUID_TALON )
			}//endif
		}//endfunction
		//
		//
		//
		private void build_sequence() {//function build_sequence takes nothing returns nothing
			int mines = GetMinesOwned();//local integer mines = GetMinesOwned()
			InitBuildArray();//call InitBuildArray()
			init_booleans();//call init_booleans()
			MeleeTownHall(0, TREE_LIFE);//call MeleeTownHall( 0, TREE_LIFE )
			MeleeTownHall(1, TREE_LIFE);//call MeleeTownHall( 1, TREE_LIFE )
			SetBuildUnit(5, WISP);//call SetBuildUnit( 5, WISP              )
			SetBuildUnit(1, ANCIENT_WAR);//call SetBuildUnit( 1, ANCIENT_WAR       )
			SetBuildUnit(1, MOON_WELL);//call SetBuildUnit( 1, MOON_WELL         )
			SetBuildUnit(9, WISP);//call SetBuildUnit( 9, WISP              )
			SetBuildUnit(2, MOON_WELL);//call SetBuildUnit( 2, MOON_WELL         )
			SetBuildUnit(1, ARCHER);//call SetBuildUnit( 1, ARCHER            )
			SetBuildUnit(10, WISP);//call SetBuildUnit(10, WISP              )
			SetBuildUnit(1, ELF_ALTAR);//call SetBuildUnit( 1, ELF_ALTAR         )
			SetBuildUnit(2, ARCHER);//call SetBuildUnit( 2, ARCHER            )
			SetBuildUnit(11, WISP);//call SetBuildUnit(11, WISP              )
			SetBuildUnit(3, ARCHER);//call SetBuildUnit( 3, ARCHER            )
			SetBuildUnit(1, hero_id);//call SetBuildUnit( 1, hero_id           )
			FoodPool(8,  true,ARCHER,2,  lore,DRYAD,3);//call FoodPool( 8,  true,ARCHER,2,  lore,DRYAD,3 )
			SetBuildUnit(3, MOON_WELL);//call SetBuildUnit( 3, MOON_WELL         )
			SetBuildUnit(1, HUNTERS_HALL);//call SetBuildUnit( 1, HUNTERS_HALL      )
			FoodPool(12,  true,ARCHER,2,  lore,DRYAD,3);//call FoodPool( 12,  true,ARCHER,2,  lore,DRYAD,3 )
			SetBuildUnit(1, HUNTRESS);//call SetBuildUnit( 1, HUNTRESS          )
			SetBuildUpgr(1, UPG_MOON_ARMOR);//call SetBuildUpgr( 1, UPG_MOON_ARMOR    )
			SetBuildUnit(2, HUNTRESS);//call SetBuildUnit( 2, HUNTRESS          )
			SetBuildUnit(1, TREE_AGES);//call SetBuildUnit( 1, TREE_AGES         )
			FoodPool(9,  true,HUNTRESS,3,  use_bears,DRUID_CLAW,4);//call FoodPool( 9,  true,HUNTRESS,3,  use_bears,DRUID_CLAW,4 )
			SetBuildUpgr(1, UPG_STR_MOON);//call SetBuildUpgr( 1, UPG_STR_MOON      )
			FoodPool(12,  true,HUNTRESS,3,  use_bears,DRUID_CLAW,4);//call FoodPool( 12,  true,HUNTRESS,3,  use_bears,DRUID_CLAW,4 )
			SetBuildUnit(4, MOON_WELL);//call SetBuildUnit( 4, MOON_WELL         )
			SetBuildUnit(2, ANCIENT_WAR);//call SetBuildUnit( 2, ANCIENT_WAR       )
			SetBuildUpgr(2, UPG_STR_MOON);//call SetBuildUpgr( 2, UPG_STR_MOON      )
			SetBuildUpgr(1, UPG_BOWS);//call SetBuildUpgr( 1, UPG_BOWS          )
			SetBuildUnit(1, hero_id2);//call SetBuildUnit( 1, hero_id2          )
			BasicExpansion(mines < 2, TREE_LIFE);//call BasicExpansion( mines < 2, TREE_LIFE )
			GuardSecondary(1, 2, ANCIENT_PROTECT);//call GuardSecondary( 1, 2, ANCIENT_PROTECT )
			GuardSecondary(2, 2, ANCIENT_PROTECT);//call GuardSecondary( 2, 2, ANCIENT_PROTECT )
			forces_sequence();//call forces_sequence()
			upgrade_sequence();//call upgrade_sequence()
			if (mines > 1) {//if mines > 1 then
				SetBuildUnit(16, WISP);//call SetBuildUnit( 16, WISP )
			}//endif
			SetBuildUnit(5, MOON_WELL);//call SetBuildUnit( 5, MOON_WELL         )
			SetBuildUnit(1, ANCIENT_LORE);//call SetBuildUnit( 1, ANCIENT_LORE      )
			SetBuildUnit(1, ANCIENT_WIND);//call SetBuildUnit( 1, ANCIENT_WIND      )
			SetBuildUnit(1, TREE_ETERNITY);//call SetBuildUnit( 1, TREE_ETERNITY     )
			SetBuildUnit(1, CHIMAERA_ROOST);//call SetBuildUnit( 1, CHIMAERA_ROOST    )
			SetBuildUnit(6, MOON_WELL);//call SetBuildUnit( 6, MOON_WELL         )
			if (GetUnitCount(CHIMAERA_ROOST)>0 && GetUnitCount(ZEPPELIN)<3) {//if GetUnitCount(CHIMAERA_ROOST)>0 and GetUnitCount(ZEPPELIN)<3 then
				GetZeppelin();//call GetZeppelin()
			}//endif
			MeleeTownHall(2, TREE_LIFE);//call MeleeTownHall( 2, TREE_LIFE )
			BasicExpansion(mines < 3, TREE_LIFE);//call BasicExpansion( mines < 3, TREE_LIFE )
		}//endfunction
		//
		//
		//
		private void peon_assignment() {//function peon_assignment takes nothing returns nothing
			int T;//local integer T
			while (true) {//loop
				ClearHarvestAI();//call ClearHarvestAI()
				T = TownWithMine();//set T = TownWithMine()
				HarvestGold(T,4);//call HarvestGold(T,4)
				HarvestWood(0,1);//call HarvestWood(0,1)
				HarvestGold(T,1);//call HarvestGold(T,1)
				HarvestWood(0,2);//call HarvestWood(0,2)
				if (GetUnitCountDone(ELF_MINE)>1) {//if GetUnitCountDone(ELF_MINE)>1 then
					HarvestGold(T+1,5);//call HarvestGold(T+1,5)
				}//endif
				HarvestWood(1,20);//call HarvestWood(1,20)
				build_sequence();//call build_sequence()
				Sleep(3);//call Sleep(3)
			}//endloop
		}//endfunction
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			do_debug_cheats = GetAiPlayer()==1;//set do_debug_cheats = GetAiPlayer()==1
			PickMeleeHero(RACE_NIGHTELF);//call PickMeleeHero(RACE_NIGHTELF)
			set_skills();//call set_skills()
			StandardAI(function SkillArrays, function peon_assignment, function attack_sequence);//call StandardAI(function SkillArrays, function peon_assignment, function attack_sequence)
			PlayGame();//call PlayGame()
		}//endfunction

	
	}
}

