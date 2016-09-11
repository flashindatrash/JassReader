using System;
using System.Collections.Generic;

namespace Jass {

	public class OrcAi {

		//
		//
		//
		//
		//
		//
		private void set_skills() {//function set_skills takes nothing returns nothing
			//
			if (hero_id == BLADE_MASTER) {//if hero_id == BLADE_MASTER then
				//
				skills1[1] = MIRROR_IMAGE;//set skills1[ 1] = MIRROR_IMAGE
				skills1[2] = CRITICAL_STRIKE;//set skills1[ 2] = CRITICAL_STRIKE
				skills1[3] = CRITICAL_STRIKE;//set skills1[ 3] = CRITICAL_STRIKE
				skills1[4] = WIND_WALK;//set skills1[ 4] = WIND_WALK
				skills1[5] = MIRROR_IMAGE;//set skills1[ 5] = MIRROR_IMAGE
				skills1[6] = BLADE_STORM;//set skills1[ 6] = BLADE_STORM
				skills1[7] = CRITICAL_STRIKE;//set skills1[ 7] = CRITICAL_STRIKE
				skills1[8] = MIRROR_IMAGE;//set skills1[ 8] = MIRROR_IMAGE
				skills1[9] = WIND_WALK;//set skills1[ 9] = WIND_WALK
				skills1[10] = WIND_WALK;//set skills1[10] = WIND_WALK
			}//endif
			//
			if (hero_id2 == BLADE_MASTER) {//if hero_id2 == BLADE_MASTER then
				//
				skills2[1] = MIRROR_IMAGE;//set skills2[ 1] = MIRROR_IMAGE
				skills2[2] = CRITICAL_STRIKE;//set skills2[ 2] = CRITICAL_STRIKE
				skills2[3] = WIND_WALK;//set skills2[ 3] = WIND_WALK
				skills2[4] = CRITICAL_STRIKE;//set skills2[ 4] = CRITICAL_STRIKE
				skills2[5] = CRITICAL_STRIKE;//set skills2[ 5] = CRITICAL_STRIKE
				skills2[6] = BLADE_STORM;//set skills2[ 6] = BLADE_STORM
				skills2[7] = MIRROR_IMAGE;//set skills2[ 7] = MIRROR_IMAGE
				skills2[8] = MIRROR_IMAGE;//set skills2[ 8] = MIRROR_IMAGE
				skills2[9] = WIND_WALK;//set skills2[ 9] = WIND_WALK
				skills2[10] = WIND_WALK;//set skills2[10] = WIND_WALK
			}//endif
			//
			if (hero_id == FAR_SEER) {//if hero_id == FAR_SEER then
				//
				skills1[1] = CHAIN_LIGHTNING;//set skills1[ 1] = CHAIN_LIGHTNING
				skills1[2] = SPIRIT_WOLF;//set skills1[ 2] = SPIRIT_WOLF
				skills1[3] = CHAIN_LIGHTNING;//set skills1[ 3] = CHAIN_LIGHTNING
				skills1[4] = SPIRIT_WOLF;//set skills1[ 4] = SPIRIT_WOLF
				skills1[5] = CHAIN_LIGHTNING;//set skills1[ 5] = CHAIN_LIGHTNING
				skills1[6] = EARTHQUAKE;//set skills1[ 6] = EARTHQUAKE
				skills1[7] = SPIRIT_WOLF;//set skills1[ 7] = SPIRIT_WOLF
				skills1[8] = FAR_SIGHT;//set skills1[ 8] = FAR_SIGHT
				skills1[9] = FAR_SIGHT;//set skills1[ 9] = FAR_SIGHT
				skills1[10] = FAR_SIGHT;//set skills1[10] = FAR_SIGHT
			}//endif
			//
			if (hero_id2 == FAR_SEER) {//if hero_id2 == FAR_SEER then
				//
				skills2[1] = CHAIN_LIGHTNING;//set skills2[ 1] = CHAIN_LIGHTNING
				skills2[2] = SPIRIT_WOLF;//set skills2[ 2] = SPIRIT_WOLF
				skills2[3] = CHAIN_LIGHTNING;//set skills2[ 3] = CHAIN_LIGHTNING
				skills2[4] = SPIRIT_WOLF;//set skills2[ 4] = SPIRIT_WOLF
				skills2[5] = CHAIN_LIGHTNING;//set skills2[ 5] = CHAIN_LIGHTNING
				skills2[6] = EARTHQUAKE;//set skills2[ 6] = EARTHQUAKE
				skills2[7] = SPIRIT_WOLF;//set skills2[ 7] = SPIRIT_WOLF
				skills2[8] = FAR_SIGHT;//set skills2[ 8] = FAR_SIGHT
				skills2[9] = FAR_SIGHT;//set skills2[ 9] = FAR_SIGHT
				skills2[10] = FAR_SIGHT;//set skills2[10] = FAR_SIGHT
			}//endif
			//
			if (hero_id == TAUREN_CHIEF) {//if hero_id == TAUREN_CHIEF then
				//
				skills1[1] = SHOCKWAVE;//set skills1[ 1] = SHOCKWAVE
				skills1[2] = ENDURANE_AURA;//set skills1[ 2] = ENDURANE_AURA
				skills1[3] = SHOCKWAVE;//set skills1[ 3] = SHOCKWAVE
				skills1[4] = ENDURANE_AURA;//set skills1[ 4] = ENDURANE_AURA
				skills1[5] = SHOCKWAVE;//set skills1[ 5] = SHOCKWAVE
				skills1[6] = REINCARNATION;//set skills1[ 6] = REINCARNATION
				skills1[7] = ENDURANE_AURA;//set skills1[ 7] = ENDURANE_AURA
				skills1[8] = WAR_STOMP;//set skills1[ 8] = WAR_STOMP
				skills1[9] = WAR_STOMP;//set skills1[ 9] = WAR_STOMP
				skills1[10] = WAR_STOMP;//set skills1[10] = WAR_STOMP
			}//endif
			//
			if (hero_id2 == TAUREN_CHIEF) {//if hero_id2 == TAUREN_CHIEF then
				//
				skills2[1] = ENDURANE_AURA;//set skills2[ 1] = ENDURANE_AURA
				skills2[2] = WAR_STOMP;//set skills2[ 2] = WAR_STOMP
				skills2[3] = WAR_STOMP;//set skills2[ 3] = WAR_STOMP
				skills2[4] = ENDURANE_AURA;//set skills2[ 4] = ENDURANE_AURA
				skills2[5] = WAR_STOMP;//set skills2[ 5] = WAR_STOMP
				skills2[6] = REINCARNATION;//set skills2[ 6] = REINCARNATION
				skills2[7] = ENDURANE_AURA;//set skills2[ 7] = ENDURANE_AURA
				skills2[8] = SHOCKWAVE;//set skills2[ 8] = SHOCKWAVE
				skills2[9] = SHOCKWAVE;//set skills2[ 9] = SHOCKWAVE
				skills2[10] = SHOCKWAVE;//set skills2[10] = SHOCKWAVE
			}//endif
		}//endfunction
		//
		//
		//
		private void setup_force() {//function setup_force takes nothing returns nothing
			AwaitMeleeHeroes();//call AwaitMeleeHeroes()
			while (true) {//loop
				if (GetUnitCountDone(GRUNT)+GetUnitCountDone(RAIDER)+GetUnitCountDone(TAUREN) >= 4) { break; }//exitwhen GetUnitCountDone(GRUNT)+GetUnitCountDone(RAIDER)+GetUnitCountDone(TAUREN) >= 4
				Sleep(1);//call Sleep(1)
			}//endloop
			InitAssaultGroup();//call InitAssaultGroup()
			RemoveInjuries();//call RemoveInjuries()
			SetAssaultGroup(1, 9, hero_id);//call SetAssaultGroup( 1, 9, hero_id         )
			SetAssaultGroup(0, 9, hero_id2);//call SetAssaultGroup( 0, 9, hero_id2        )
			SetAssaultGroup(0, 9, GRUNT);//call SetAssaultGroup( 0, 9, GRUNT           )
			SetAssaultGroup(0, 9, RAIDER);//call SetAssaultGroup( 0, 9, RAIDER          )
			SetAssaultGroup(0, 9, TAUREN);//call SetAssaultGroup( 0, 9, TAUREN          )
			SetAssaultGroup(0, 9, HEAD_HUNTER);//call SetAssaultGroup( 0, 9, HEAD_HUNTER     )
			SetAssaultGroup(0, 9, WYVERN);//call SetAssaultGroup( 0, 9, WYVERN          )
			SetAssaultGroup(0, 9, WITCH_DOCTOR);//call SetAssaultGroup( 0, 9, WITCH_DOCTOR    )
			SetAssaultGroup(0, 9, SHAMAN);//call SetAssaultGroup( 0, 9, SHAMAN          )
			SetAssaultGroup(0, 9, KODO_BEAST);//call SetAssaultGroup( 0, 9, KODO_BEAST      )
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
				air_units = GetUnitCountDone(WYVERN)>0;//set air_units        = GetUnitCountDone(WYVERN)>0
				major_ok = air_units || GetUnitCountDone(HEAD_HUNTER)>=2;//set major_ok         = air_units or GetUnitCountDone(HEAD_HUNTER)>=2
				needs_exp = take_exp && major_ok;//set needs_exp        = take_exp and major_ok
				has_siege = GetUnitCountDone(CATAPULT)>0;//set has_siege        = GetUnitCountDone(CATAPULT)>0
				allow_air_creeps = major_ok;//set allow_air_creeps = major_ok
				SingleMeleeAttack(needs_exp,has_siege,major_ok,air_units);//call SingleMeleeAttack(needs_exp,has_siege,major_ok,air_units)
			}//endloop
		}//endfunction
		//
		//
		//
		private void init_booleans() {//function init_booleans takes nothing returns nothing
			C_hunters = GetUnitCount(HEAD_HUNTER);//set C_hunters  = GetUnitCount(HEAD_HUNTER)
			C_grunt = GetUnitCount(GRUNT);//set C_grunt    = GetUnitCount(GRUNT)
			C_raiders = GetUnitCount(RAIDER);//set C_raiders  = GetUnitCount(RAIDER)
			forge = GetUnitCountDone(FORGE)>0;//set forge      = GetUnitCountDone(FORGE)>0
			stronghold = TownCountDone(STRONGHOLD)>0;//set stronghold = TownCountDone(STRONGHOLD)>0
			fortress = TownCountDone(FORTRESS)>0;//set fortress   = TownCountDone(FORTRESS)>0
			bestiary = GetUnitCountDone(BESTIARY)>0;//set bestiary   = GetUnitCountDone(BESTIARY)>0
			lodge = GetUnitCountDone(LODGE)>0;//set lodge      = GetUnitCountDone(LODGE)>0
			totem = GetUnitCountDone(TOTEM)>0;//set totem      = GetUnitCountDone(TOTEM)>0
		}//endfunction
		//
		//
		//
		private void upgrade_sequence() {//function upgrade_sequence takes nothing returns nothing
			//
			//
			if (forge) {//if forge then
				SetBuildUpgr(1, UPG_ORC_ARMOR);//call SetBuildUpgr( 1, UPG_ORC_ARMOR  )
				SetBuildUpgr(1, UPG_ORC_MELEE);//call SetBuildUpgr( 1, UPG_ORC_MELEE  )
				SetBuildUpgr(1, UPG_ORC_RANGED);//call SetBuildUpgr( 1, UPG_ORC_RANGED )
				SetBuildUpgr(1, UPG_ORC_SPIKES);//call SetBuildUpgr( 1, UPG_ORC_SPIKES )
				if (C_hunters>=5) {//if C_hunters>=5 then
					SetBuildUpgr(1, UPG_ORC_REGEN);//call SetBuildUpgr( 1, UPG_ORC_REGEN )
				}//endif
				if (stronghold) {//if stronghold then
					SetBuildUpgr(2, UPG_ORC_ARMOR);//call SetBuildUpgr( 2, UPG_ORC_ARMOR  )
					SetBuildUpgr(2, UPG_ORC_MELEE);//call SetBuildUpgr( 2, UPG_ORC_MELEE  )
					SetBuildUpgr(2, UPG_ORC_RANGED);//call SetBuildUpgr( 2, UPG_ORC_RANGED )
					SetBuildUpgr(2, UPG_ORC_SPIKES);//call SetBuildUpgr( 2, UPG_ORC_SPIKES )
					if (fortress) {//if fortress then
						SetBuildUpgr(1, UPG_ORC_BERSERK);//call SetBuildUpgr( 1, UPG_ORC_BERSERK )
						SetBuildUpgr(3, UPG_ORC_ARMOR);//call SetBuildUpgr( 3, UPG_ORC_ARMOR   )
						SetBuildUpgr(3, UPG_ORC_MELEE);//call SetBuildUpgr( 3, UPG_ORC_MELEE   )
						SetBuildUpgr(3, UPG_ORC_RANGED);//call SetBuildUpgr( 3, UPG_ORC_RANGED  )
						SetBuildUpgr(3, UPG_ORC_SPIKES);//call SetBuildUpgr( 3, UPG_ORC_SPIKES  )
					}//endif
				}//endif
			}//endif
			//
			//
			if (bestiary) {//if bestiary then
				if (C_raiders>0) {//if C_raiders>0 then
					SetBuildUpgr(1, UPG_ORC_ENSNARE);//call SetBuildUpgr( 1, UPG_ORC_ENSNARE )
					SetBuildUpgr(1, UPG_ORC_PILLAGE);//call SetBuildUpgr( 1, UPG_ORC_PILLAGE )
				}//endif
				if (GetUnitCountDone(KODO_BEAST)>0) {//if GetUnitCountDone(KODO_BEAST)>0 then
					SetBuildUpgr(1, UPG_ORC_WAR_DRUMS);//call SetBuildUpgr( 1, UPG_ORC_WAR_DRUMS )
				}//endif
				if (GetUnitCountDone(WYVERN)>0) {//if GetUnitCountDone(WYVERN)>0 then
					SetBuildUpgr(1, UPG_ORC_VENOM);//call SetBuildUpgr( 1, UPG_ORC_VENOM )
				}//endif
			}//endif
			//
			//
			if (totem && GetUnitCount(TAUREN)>0) {//if totem and GetUnitCount(TAUREN)>0 then
				SetBuildUpgr(1, UPG_ORC_PULVERIZE);//call SetBuildUpgr( 1, UPG_ORC_PULVERIZE )
			}//endif
			//
			//
			if (lodge) {//if lodge then
				if (GetUnitCount(SHAMAN)>0) {//if GetUnitCount(SHAMAN)>0 then
					if (fortress) {//if fortress then
						SetBuildUpgr(3, UPG_ORC_SHAMAN);//call SetBuildUpgr( 3, UPG_ORC_SHAMAN )
					} else if (stronghold) {//elseif stronghold then
						SetBuildUpgr(2, UPG_ORC_SHAMAN);//call SetBuildUpgr( 2, UPG_ORC_SHAMAN )
					} else {//else
						SetBuildUpgr(1, UPG_ORC_SHAMAN);//call SetBuildUpgr( 1, UPG_ORC_SHAMAN )
					}//endif
				}//endif
				if (GetUnitCount(WITCH_DOCTOR)>0) {//if GetUnitCount(WITCH_DOCTOR)>0 then
					if (fortress) {//if fortress then
						SetBuildUpgr(3, UPG_ORC_DOCS);//call SetBuildUpgr( 3, UPG_ORC_DOCS )
					} else if (stronghold) {//elseif stronghold then
						SetBuildUpgr(2, UPG_ORC_DOCS);//call SetBuildUpgr( 2, UPG_ORC_DOCS )
					} else {//else
						SetBuildUpgr(1, UPG_ORC_DOCS);//call SetBuildUpgr( 1, UPG_ORC_DOCS )
					}//endif
				}//endif
			}//endif
		}//endfunction
		//
		//
		//
		private void forces_sequence() {//function forces_sequence takes nothing returns nothing
			int farms = GetUnitCountDone(BURROW) + TownCountDone(GREAT_HALL);//local integer farms = GetUnitCountDone(BURROW) + TownCountDone(GREAT_HALL)
			int count;//local integer count
			//
			//
			if (farms < 6) {//if farms < 6 then
				return;//return
			}//endif
			FoodPool(12,  true,HEAD_HUNTER,2,  forge and fortress,WYVERN,4);//call FoodPool( 12,  true,HEAD_HUNTER,2,  forge and fortress,WYVERN,4 )
			//
			//
			if (forge && stronghold) {//if forge and stronghold then
				SetBuildUnit(1, CATAPULT);//call SetBuildUnit( 1, CATAPULT )
			}//endif
			//
			//
			if (lodge) {//if lodge then
				SetBuildUnit(2, SHAMAN);//call SetBuildUnit( 2, SHAMAN )
			}//endif
			if (farms < 7) {//if farms < 7 then
				return;//return
			}//endif
			if (lodge) {//if lodge then
				SetBuildUnit(1, WITCH_DOCTOR);//call SetBuildUnit( 1, WITCH_DOCTOR )
			}//endif
			if (forge && bestiary) {//if forge and bestiary then
				SetBuildUnit(1, KODO_BEAST);//call SetBuildUnit( 1, KODO_BEAST )
			}//endif
			//
			//
			if (farms < 8) {//if farms < 8 then
				return;//return
			}//endif
			if (totem) {//if totem then
				SetBuildUnit(2, TAUREN);//call SetBuildUnit( 2, TAUREN )
			}//endif
		}//endfunction
		//
		//
		//
		private void build_melee(int pool) {//function build_melee takes integer pool returns nothing
			FoodPool(pool,  true,GRUNT,3,  bestiary,RAIDER,3);//call FoodPool( pool,  true,GRUNT,3,  bestiary,RAIDER,3 )
		}//endfunction
		//
		//
		//
		private void build_ranged(int pool) {//function build_ranged takes integer pool returns nothing
			FoodPool(pool,  true,HEAD_HUNTER,2,  forge and fortress,WYVERN,4);//call FoodPool( pool,  true,HEAD_HUNTER,2,  forge and fortress,WYVERN,4 )
		}//endfunction
		//
		//
		//
		private void build_sequence() {//function build_sequence takes nothing returns nothing
			int mines = GetMinesOwned();//local integer mines = GetMinesOwned()
			InitBuildArray();//call InitBuildArray()
			init_booleans();//call init_booleans()
			MeleeTownHall(0, GREAT_HALL);//call MeleeTownHall( 0, GREAT_HALL )
			MeleeTownHall(1, GREAT_HALL);//call MeleeTownHall( 1, GREAT_HALL )
			SetBuildUnit(6, PEON);//call SetBuildUnit( 6, PEON          )
			BuildFactory(ORC_BARRACKS);//call BuildFactory(    ORC_BARRACKS  )
			SetBuildUnit(1, BURROW);//call SetBuildUnit( 1, BURROW        )
			SetBuildUnit(10, PEON);//call SetBuildUnit(10, PEON          )
			SetBuildUnit(2, BURROW);//call SetBuildUnit( 2, BURROW        )
			SetBuildUnit(1, GRUNT);//call SetBuildUnit( 1, GRUNT         )
			SetBuildUnit(1, ORC_ALTAR);//call SetBuildUnit( 1, ORC_ALTAR     )
			SetBuildUnit(2, GRUNT);//call SetBuildUnit( 2, GRUNT         )
			SetBuildUnit(1, hero_id);//call SetBuildUnit( 1, hero_id       )
			build_melee(12);//call build_melee( 12 )
			SetBuildUnit(3, BURROW);//call SetBuildUnit( 3, BURROW        )
			SetBuildUnit(1, FORGE);//call SetBuildUnit( 1, FORGE         )
			build_melee(15);//call build_melee( 15 )
			SetBuildUpgr(1, UPG_ORC_ARMOR);//call SetBuildUpgr( 1, UPG_ORC_ARMOR )
			build_ranged(4);//call build_ranged( 4 )
			SetBuildUnit(1, STRONGHOLD);//call SetBuildUnit( 1, STRONGHOLD    )
			build_ranged(6);//call build_ranged( 6 )
			SetBuildUpgr(1, UPG_ORC_MELEE);//call SetBuildUpgr( 1, UPG_ORC_MELEE )
			build_ranged(8);//call build_ranged( 8 )
			SetBuildUnit(4, BURROW);//call SetBuildUnit( 4, BURROW        )
			build_ranged(10);//call build_ranged( 10 )
			SetBuildUpgr(1, UPG_ORC_RANGED);//call SetBuildUpgr( 1, UPG_ORC_RANGED)
			SetBuildUnit(1, hero_id2);//call SetBuildUnit( 1, hero_id2      )
			BasicExpansion(mines < 2, GREAT_HALL);//call BasicExpansion( mines < 2, GREAT_HALL )
			if (mines > 1) {//if mines > 1 then
				SetBuildUnit(15, PEON);//call SetBuildUnit(15, PEON      )
			}//endif
			forces_sequence();//call forces_sequence()
			upgrade_sequence();//call upgrade_sequence()
			GuardSecondary(1, 1, BURROW);//call GuardSecondary( 1, 1, BURROW          )
			GuardSecondary(1, 1, ORC_WATCH_TOWER);//call GuardSecondary( 1, 1, ORC_WATCH_TOWER )
			GuardSecondary(2, 1, BURROW);//call GuardSecondary( 2, 1, BURROW          )
			GuardSecondary(2, 1, ORC_WATCH_TOWER);//call GuardSecondary( 2, 1, ORC_WATCH_TOWER )
			BuildFactory(BESTIARY);//call BuildFactory(    BESTIARY      )
			SetBuildUnit(1, FORTRESS);//call SetBuildUnit( 1, FORTRESS      )
			if (C_raiders > 0) {//if C_raiders > 0 then
				SetBuildUnit(1, TOTEM);//call SetBuildUnit( 1, TOTEM     )
			}//endif
			if (GetUnitCount(FORTRESS)>0 && GetUnitCount(ZEPPELIN)<3) {//if GetUnitCount(FORTRESS)>0 and GetUnitCount(ZEPPELIN)<3 then
				GetZeppelin();//call GetZeppelin()
			}//endif
			MeleeTownHall(2, GREAT_HALL);//call MeleeTownHall( 2, GREAT_HALL )
			BasicExpansion(mines < 3, GREAT_HALL);//call BasicExpansion( mines < 3, GREAT_HALL )
		}//endfunction
		//
		//
		//
		private void peon_assignment() {//function peon_assignment takes nothing returns nothing
			int T;//local integer T
			while (true) {//loop
				ClearHarvestAI();//call ClearHarvestAI()
				T = TownWithMine();//set T = TownWithMine()
				HarvestGold(T,5);//call HarvestGold(T,5)
				HarvestWood(0,5);//call HarvestWood(0,5)
				if (TownCountDone(GREAT_HALL)>1) {//if TownCountDone(GREAT_HALL)>1 then
					HarvestGold(T+1,4);//call HarvestGold(T+1,4)
				}//endif
				HarvestWood(0,10);//call HarvestWood(0,10)
				build_sequence();//call build_sequence()
				Sleep(3);//call Sleep(3)
			}//endloop
		}//endfunction
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			do_debug_cheats = GetAiPlayer()==1;//set do_debug_cheats = GetAiPlayer()==1
			PickMeleeHero(RACE_ORC);//call PickMeleeHero(RACE_ORC)
			set_skills();//call set_skills()
			StandardAI(function SkillArrays, function peon_assignment, function attack_sequence);//call StandardAI(function SkillArrays, function peon_assignment, function attack_sequence)
			PlayGame();//call PlayGame()
		}//endfunction

	
	}
}

