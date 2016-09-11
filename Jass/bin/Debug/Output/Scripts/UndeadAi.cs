using System;
using System.Collections.Generic;

namespace Jass {

	public class UndeadAi {

		//
		//
		//
		public static int AG = 0;//integer AG          = 0
		public static int wave = 1;//integer wave        = 1
		public static bool halls = false;//boolean halls       = false
		public static bool citadel = false;//boolean citadel     = false
		public static bool grave = false;//boolean grave       = false
		public static bool melee = false;//boolean melee       = false
		public static bool ranged = false;//boolean ranged      = false
		public static bool C_aboms = false;//boolean C_aboms     = false
		public static bool M_aboms = false;//boolean M_aboms     = false
		public static bool banshees = false;//boolean banshees    = false
		public static bool sac_pit = false;//boolean sac_pit     = false
		public static bool boneyard = false;//boolean boneyard    = false
		public static bool fiends = false;//boolean fiends      = false
		public static bool slaught = false;//boolean slaught     = false
		public static bool temple = false;//boolean temple      = false
		public static bool wagons = false;//boolean wagons      = false
		//
		//
		//
		private void set_skills() {//function set_skills takes nothing returns nothing
			//
			if (hero_id == LICH) {//if hero_id == LICH then
				//
				skills1[1] = FROST_NOVA;//set skills1[ 1] = FROST_NOVA
				skills1[2] = FROST_ARMOR;//set skills1[ 2] = FROST_ARMOR
				skills1[3] = FROST_NOVA;//set skills1[ 3] = FROST_NOVA
				skills1[4] = DARK_RITUAL;//set skills1[ 4] = DARK_RITUAL
				skills1[5] = FROST_NOVA;//set skills1[ 5] = FROST_NOVA
				skills1[6] = DEATH_DECAY;//set skills1[ 6] = DEATH_DECAY
				skills1[7] = DARK_RITUAL;//set skills1[ 7] = DARK_RITUAL
				skills1[8] = DARK_RITUAL;//set skills1[ 8] = DARK_RITUAL
				skills1[9] = FROST_ARMOR;//set skills1[ 9] = FROST_ARMOR
				skills1[10] = FROST_ARMOR;//set skills1[10] = FROST_ARMOR
			}//endif
			//
			if (hero_id2 == LICH) {//if hero_id2 == LICH then
				//
				skills2[1] = FROST_NOVA;//set skills2[ 1] = FROST_NOVA
				skills2[2] = FROST_ARMOR;//set skills2[ 2] = FROST_ARMOR
				skills2[3] = FROST_NOVA;//set skills2[ 3] = FROST_NOVA
				skills2[4] = DARK_RITUAL;//set skills2[ 4] = DARK_RITUAL
				skills2[5] = FROST_NOVA;//set skills2[ 5] = FROST_NOVA
				skills2[6] = DEATH_DECAY;//set skills2[ 6] = DEATH_DECAY
				skills2[7] = DARK_RITUAL;//set skills2[ 7] = DARK_RITUAL
				skills2[8] = DARK_RITUAL;//set skills2[ 8] = DARK_RITUAL
				skills2[9] = FROST_ARMOR;//set skills2[ 9] = FROST_ARMOR
				skills2[10] = FROST_ARMOR;//set skills2[10] = FROST_ARMOR
			}//endif
			//
			if (hero_id == DREAD_LORD) {//if hero_id == DREAD_LORD then
				//
				skills1[1] = SLEEP;//set skills1[ 1] = SLEEP
				skills1[2] = VAMP_AURA;//set skills1[ 2] = VAMP_AURA
				skills1[3] = SLEEP;//set skills1[ 3] = SLEEP
				skills1[4] = CARRION_SWARM;//set skills1[ 4] = CARRION_SWARM
				skills1[5] = SLEEP;//set skills1[ 5] = SLEEP
				skills1[6] = INFERNO;//set skills1[ 6] = INFERNO
				skills1[7] = CARRION_SWARM;//set skills1[ 7] = CARRION_SWARM
				skills1[8] = CARRION_SWARM;//set skills1[ 8] = CARRION_SWARM
				skills1[9] = VAMP_AURA;//set skills1[ 9] = VAMP_AURA
				skills1[10] = VAMP_AURA;//set skills1[10] = VAMP_AURA
			}//endif
			//
			if (hero_id2 == DREAD_LORD) {//if hero_id2 == DREAD_LORD then
				//
				skills2[1] = CARRION_SWARM;//set skills2[ 1] = CARRION_SWARM
				skills2[2] = SLEEP;//set skills2[ 2] = SLEEP
				skills2[3] = CARRION_SWARM;//set skills2[ 3] = CARRION_SWARM
				skills2[4] = VAMP_AURA;//set skills2[ 4] = VAMP_AURA
				skills2[5] = CARRION_SWARM;//set skills2[ 5] = CARRION_SWARM
				skills2[6] = INFERNO;//set skills2[ 6] = INFERNO
				skills2[7] = VAMP_AURA;//set skills2[ 7] = VAMP_AURA
				skills2[8] = VAMP_AURA;//set skills2[ 8] = VAMP_AURA
				skills2[9] = SLEEP;//set skills2[ 9] = SLEEP
				skills2[10] = SLEEP;//set skills2[10] = SLEEP
			}//endif
			//
			if (hero_id == DEATH_KNIGHT) {//if hero_id == DEATH_KNIGHT then
				//
				skills1[1] = DEATH_COIL;//set skills1[ 1] = DEATH_COIL
				skills1[2] = UNHOLY_AURA;//set skills1[ 2] = UNHOLY_AURA
				skills1[3] = DEATH_COIL;//set skills1[ 3] = DEATH_COIL
				skills1[4] = UNHOLY_AURA;//set skills1[ 4] = UNHOLY_AURA
				skills1[5] = DEATH_COIL;//set skills1[ 5] = DEATH_COIL
				skills1[6] = ANIM_DEAD;//set skills1[ 6] = ANIM_DEAD
				skills1[7] = UNHOLY_AURA;//set skills1[ 7] = UNHOLY_AURA
				skills1[8] = DEATH_PACT;//set skills1[ 8] = DEATH_PACT
				skills1[9] = DEATH_PACT;//set skills1[ 9] = DEATH_PACT
				skills1[10] = DEATH_PACT;//set skills1[10] = DEATH_PACT
			}//endif
			//
			if (hero_id2 == DEATH_KNIGHT) {//if hero_id2 == DEATH_KNIGHT then
				//
				skills2[1] = DEATH_COIL;//set skills2[ 1] = DEATH_COIL
				skills2[2] = UNHOLY_AURA;//set skills2[ 2] = UNHOLY_AURA
				skills2[3] = DEATH_COIL;//set skills2[ 3] = DEATH_COIL
				skills2[4] = UNHOLY_AURA;//set skills2[ 4] = UNHOLY_AURA
				skills2[5] = DEATH_COIL;//set skills2[ 5] = DEATH_COIL
				skills2[6] = ANIM_DEAD;//set skills2[ 6] = ANIM_DEAD
				skills2[7] = UNHOLY_AURA;//set skills2[ 7] = UNHOLY_AURA
				skills2[8] = DEATH_PACT;//set skills2[ 8] = DEATH_PACT
				skills2[9] = DEATH_PACT;//set skills2[ 9] = DEATH_PACT
				skills2[10] = DEATH_PACT;//set skills2[10] = DEATH_PACT
			}//endif
		}//endfunction
		//
		//
		//
		private void setup_force() {//function setup_force takes nothing returns nothing
			AwaitMeleeHeroes();//call AwaitMeleeHeroes()
			//
			//
			if (wave==1) {//if wave==1 then
				AG = 4;//set AG = 4
				wave = 2;//set wave = 2
			} else if (wave==2) {//elseif wave==2 then
				AG = 5;//set AG = 5
				wave = 3;//set wave = 3
			} else {//else
				while (true) {//loop
					if (GetWood() < 200) {//if GetWood() < 200 then
						AG = GetUnitCountDone(GHOUL)-5;//set AG = GetUnitCountDone(GHOUL)-5
					} else {//else
						AG = GetUnitCountDone(GHOUL)-3;//set AG = GetUnitCountDone(GHOUL)-3
					}//endif
					if (AG < 0) {//if AG < 0 then
						AG = 0;//set AG = 0
					}//endif
					if (AG + 2*GetUnitCountDone(ABOMINATION) >= 4) { break; }//exitwhen AG + 2*GetUnitCountDone(ABOMINATION) >= 4
					Sleep(1);//call Sleep(1)
				}//endloop
			}//endif
			InitAssaultGroup();//call InitAssaultGroup()
			RemoveInjuries();//call RemoveInjuries()
			SetAssaultGroup(1, 9, hero_id);//call SetAssaultGroup( 1, 9, hero_id         )
			SetAssaultGroup(0, 9, hero_id2);//call SetAssaultGroup( 0, 9, hero_id2        )
			SetAssaultGroup(AG,AG, GHOUL);//call SetAssaultGroup(AG,AG, GHOUL           )
			SetAssaultGroup(0, 9, CRYPT_FIEND);//call SetAssaultGroup( 0, 9, CRYPT_FIEND     )
			SetAssaultGroup(0, 9, ABOMINATION);//call SetAssaultGroup( 0, 9, ABOMINATION     )
			SetAssaultGroup(0, 9, NECRO);//call SetAssaultGroup( 0, 9, NECRO           )
			SetAssaultGroup(0, 9, BANSHEE);//call SetAssaultGroup( 0, 9, BANSHEE         )
			SetAssaultGroup(0, 9, GARGOYLE);//call SetAssaultGroup( 0, 9, GARGOYLE        )
			SetAssaultGroup(0, 9, FROST_WYRM);//call SetAssaultGroup( 0, 9, FROST_WYRM      )
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
			bool wyrms;//local boolean wyrms
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
				wyrms = GetUnitCountDone(FROST_WYRM)>0;//set wyrms            = GetUnitCountDone(FROST_WYRM)>0
				air_units = wyrms || TownCountDone(GARGOYLE)>0;//set air_units        = wyrms or TownCountDone(GARGOYLE)>0
				major_ok = air_units || GetUnitCountDone(CRYPT_FIEND)>0;//set major_ok         = air_units or GetUnitCountDone(CRYPT_FIEND)>0
				needs_exp = take_exp && major_ok;//set needs_exp        = take_exp and major_ok
				has_siege = wyrms || GetUnitCountDone(MEAT_WAGON)>0;//set has_siege        = wyrms or GetUnitCountDone(MEAT_WAGON)>0
				allow_air_creeps = air_units || (major_ok && GetUpgradeLevel(UPG_FIEND_WEB)>0);//set allow_air_creeps = air_units or (major_ok and GetUpgradeLevel(UPG_FIEND_WEB)>0)
				SingleMeleeAttack(needs_exp,has_siege,major_ok,air_units);//call SingleMeleeAttack(needs_exp,has_siege,major_ok,air_units)
			}//endloop
		}//endfunction
		//
		//
		//
		private void undead_mine(int townid) {//function undead_mine takes integer townid returns nothing
			if (GetGold() < 1000 && TownHasMine(townid)) {//if GetGold() < 1000 and TownHasMine(townid) then
				SecondaryTown(townid, 1, UNDEAD_MINE);//call SecondaryTown( townid, 1, UNDEAD_MINE )
			}//endif
		}//endfunction
		//
		//
		//
		private void init_booleans() {//function init_booleans takes nothing returns nothing
			fiends = GetUnitCountDone(CRYPT_FIEND)>=2;//set fiends   = GetUnitCountDone(CRYPT_FIEND)>=2
			halls = TownCountDone(NECROPOLIS_2)>0;//set halls    = TownCountDone(NECROPOLIS_2)>0
			citadel = TownCountDone(NECROPOLIS_3)>0;//set citadel  = TownCountDone(NECROPOLIS_3)>0
			grave = GetUnitCountDone(GRAVEYARD)>0;//set grave    = GetUnitCountDone(GRAVEYARD)>0
			C_aboms = GetUnitCountDone(ABOMINATION)>0;//set C_aboms  = GetUnitCountDone(ABOMINATION)>0
			M_aboms = citadel && slaught && GetWood()>100;//set M_aboms  = citadel and slaught and GetWood()>100
			melee = C_aboms || GetUnitCountDone(GHOUL)>0;//set melee    = C_aboms or GetUnitCountDone(GHOUL)>0
			ranged = fiends || TownCountDone(GARGOYLE)>0;//set ranged   = fiends or TownCountDone(GARGOYLE)>0
			slaught = GetUnitCountDone(SLAUGHTERHOUSE)>0;//set slaught  = GetUnitCountDone(SLAUGHTERHOUSE)>0
			temple = GetUnitCountDone(DAMNED_TEMPLE)>0;//set temple   = GetUnitCountDone(DAMNED_TEMPLE)>0
			banshees = citadel && temple;//set banshees = citadel and temple
			sac_pit = GetUnitCountDone(SAC_PIT)>0;//set sac_pit  = GetUnitCountDone(SAC_PIT)>0
			boneyard = GetUnitCountDone(BONEYARD)>0;//set boneyard = GetUnitCountDone(BONEYARD)>0
			wagons = GetUnitCountDone(MEAT_WAGON)>0;//set wagons   = GetUnitCountDone(MEAT_WAGON)>0
		}//endfunction
		//
		//
		//
		private void upgrade_sequence() {//function upgrade_sequence takes nothing returns nothing
			//
			//
			if (grave && halls && GetUnitCount(CRYPT_FIEND)>0) {//if grave and halls and GetUnitCount(CRYPT_FIEND)>0 then
				SetBuildUpgr(1, UPG_FIEND_WEB);//call SetBuildUpgr( 1, UPG_FIEND_WEB )
				if (citadel) {//if citadel then
					SetBuildUpgr(1, UPG_GHOUL_FRENZY);//call SetBuildUpgr( 1, UPG_GHOUL_FRENZY )
					if (TownCountDone(GARGOYLE)>0) {//if TownCountDone(GARGOYLE)>0 then
						SetBuildUpgr(1, UPG_STONE_FORM);//call SetBuildUpgr( 1, UPG_STONE_FORM )
					}//endif
				}//endif
			}//endif
			//
			//
			if (grave) {//if grave then
				if (melee) {//if melee then
					SetBuildUpgr(1, UPG_UNHOLY_ARMOR);//call SetBuildUpgr( 1, UPG_UNHOLY_ARMOR )
					SetBuildUpgr(1, UPG_UNHOLY_STR);//call SetBuildUpgr( 1, UPG_UNHOLY_STR   )
				}//endif
				if (ranged) {//if ranged then
					SetBuildUpgr(1, UPG_CR_ATTACK);//call SetBuildUpgr( 1, UPG_CR_ATTACK )
					SetBuildUpgr(1, UPG_CR_ARMOR);//call SetBuildUpgr( 1, UPG_CR_ARMOR  )
				}//endif
				if (halls) {//if halls then
					if (melee) {//if melee then
						SetBuildUpgr(2, UPG_UNHOLY_ARMOR);//call SetBuildUpgr( 2, UPG_UNHOLY_ARMOR )
						SetBuildUpgr(2, UPG_UNHOLY_STR);//call SetBuildUpgr( 2, UPG_UNHOLY_STR   )
					}//endif
					if (ranged) {//if ranged then
						SetBuildUpgr(2, UPG_CR_ATTACK);//call SetBuildUpgr( 2, UPG_CR_ATTACK )
						SetBuildUpgr(2, UPG_CR_ARMOR);//call SetBuildUpgr( 2, UPG_CR_ARMOR  )
					}//endif
					if (citadel) {//if citadel then
						if (melee) {//if melee then
							SetBuildUpgr(3, UPG_UNHOLY_ARMOR);//call SetBuildUpgr( 3, UPG_UNHOLY_ARMOR )
							SetBuildUpgr(3, UPG_UNHOLY_STR);//call SetBuildUpgr( 3, UPG_UNHOLY_STR   )
						}//endif
						if (ranged) {//if ranged then
							SetBuildUpgr(3, UPG_CR_ATTACK);//call SetBuildUpgr( 3, UPG_CR_ATTACK )
							SetBuildUpgr(3, UPG_CR_ARMOR);//call SetBuildUpgr( 3, UPG_CR_ARMOR  )
						}//endif
					}//endif
				}//endif
			}//endif
			//
			//
			if (temple) {//if temple then
				if (GetUnitCount(NECRO)>=3) {//if GetUnitCount(NECRO)>=3 then
					SetBuildUpgr(1, UPG_NECROS);//call SetBuildUpgr( 1, UPG_NECROS )
					if (citadel) {//if citadel then
						SetBuildUpgr(2, UPG_NECROS);//call SetBuildUpgr( 2, UPG_NECROS )
					}//endif
					SetBuildUpgr(1, UPG_SKEL_LIFE);//call SetBuildUpgr( 1, UPG_SKEL_LIFE )
				}//endif
				if (GetUnitCount(BANSHEE)>0) {//if GetUnitCount(BANSHEE)>0 then
					SetBuildUpgr(1, UPG_BANSHEE);//call SetBuildUpgr( 1, UPG_BANSHEE )
					if (citadel) {//if citadel then
						SetBuildUpgr(2, UPG_BANSHEE);//call SetBuildUpgr( 2, UPG_BANSHEE )
					}//endif
				}//endif
			}//endif
			//
			//
			if (citadel && slaught && (C_aboms || wagons)) {//if citadel and slaught and (C_aboms or wagons) then
				SetBuildUpgr(1, UPG_PLAGUE);//call SetBuildUpgr( 1, UPG_PLAGUE )
			}//endif
			//
			//
			if (boneyard && GetUnitCount(FROST_WYRM)>0) {//if boneyard and GetUnitCount(FROST_WYRM)>0 then
				SetBuildUpgr(1, UPG_WYRM_BREATH);//call SetBuildUpgr( 1, UPG_WYRM_BREATH )
			}//endif
		}//endfunction
		//
		//
		//
		private void forces_sequence() {//function forces_sequence takes nothing returns nothing
			int farms = TownCountDone(ZIGGURAT_1) + TownCountDone(NECROPOLIS_1);//local integer farms = TownCountDone(ZIGGURAT_1) + TownCountDone(NECROPOLIS_1)
			int count;//local integer count
			//
			//
			if (farms < 4) {//if farms < 4 then
				return;//return
			}//endif
			FoodPool(12,  grave,CRYPT_FIEND,3,  grave and citadel,GARGOYLE,2);//call FoodPool( 12,  grave,CRYPT_FIEND,3,  grave and citadel,GARGOYLE,2 )
			//
			//
			if (farms < 6) {//if farms < 6 then
				return;//return
			}//endif
			if (sac_pit) {//if sac_pit then
				//
			}//endif
			FoodPool(8,  slaught,MEAT_WAGON,4,  boneyard,FROST_WYRM,7);//call FoodPool( 8,  slaught,MEAT_WAGON,4,  boneyard,FROST_WYRM,7 )
			//
			//
			if (farms < 7) {//if farms < 7 then
				return;//return
			}//endif
			if (banshees) {//if banshees then
				SetBuildUnit(3, NECRO);//call SetBuildUnit( 3, NECRO     )
				SetBuildUnit(2, BANSHEE);//call SetBuildUnit( 2, BANSHEE   )
			}//endif
		}//endfunction
		//
		//
		//
		private void build_melee(int pool) {//function build_melee takes integer pool returns nothing
			FoodPool(pool,  true,GHOUL,2,  M_aboms,ABOMINATION,4);//call FoodPool( pool,  true,GHOUL,2,  M_aboms,ABOMINATION,4 )
		}//endfunction
		//
		//
		//
		private void build_sequence() {//function build_sequence takes nothing returns nothing
			int mines = GetMinesOwned();//local integer mines = GetMinesOwned()
			InitBuildArray();//call InitBuildArray()
			init_booleans();//call init_booleans()
			MeleeTownHall(0, NECROPOLIS_1);//call MeleeTownHall( 0, NECROPOLIS_1 )
			SetBuildUnit(1, ACOLYTE);//call SetBuildUnit( 1, ACOLYTE           )
			undead_mine(0);//call undead_mine(0)
			SetBuildUnit(4, ACOLYTE);//call SetBuildUnit( 4, ACOLYTE           )
			BuildFactory(CRYPT);//call BuildFactory(    CRYPT             )
			SetBuildUnit(5, ACOLYTE);//call SetBuildUnit( 5, ACOLYTE           )
			SetBuildUnit(1, GHOUL);//call SetBuildUnit( 1, GHOUL             )
			SetBuildUnit(1, ZIGGURAT_1);//call SetBuildUnit( 1, ZIGGURAT_1        )
			SetBuildUnit(2, GHOUL);//call SetBuildUnit( 2, GHOUL             )
			SetBuildUnit(1, UNDEAD_ALTAR);//call SetBuildUnit( 1, UNDEAD_ALTAR      )
			SetBuildUnit(2, ZIGGURAT_1);//call SetBuildUnit( 2, ZIGGURAT_1        )
			build_melee(8);//call build_melee( 8 )
			SetBuildUnit(1, hero_id);//call SetBuildUnit( 1, hero_id           )
			build_melee(12);//call build_melee( 12 )
			SetBuildUpgr(1, UPG_CANNIBALIZE);//call SetBuildUpgr( 1, UPG_CANNIBALIZE   )
			SetBuildUnit(1, GRAVEYARD);//call SetBuildUnit( 1, GRAVEYARD         )
			build_melee(14);//call build_melee( 14 )
			SetBuildUnit(3, ZIGGURAT_1);//call SetBuildUnit( 3, ZIGGURAT_1        )
			build_melee(18);//call build_melee( 18 )
			SetBuildUpgr(1, UPG_UNHOLY_ARMOR);//call SetBuildUpgr( 1, UPG_UNHOLY_ARMOR  )
			if (!citadel) {//if not citadel then
				SetBuildUnit(2, CRYPT_FIEND);//call SetBuildUnit( 2, CRYPT_FIEND   )
			}//endif
			SetBuildUpgr(1, UPG_UNHOLY_STR);//call SetBuildUpgr( 1, UPG_UNHOLY_STR    )
			UpgradeAll(NECROPOLIS_1, NECROPOLIS_2);//call UpgradeAll( NECROPOLIS_1, NECROPOLIS_2 )
			forces_sequence();//call forces_sequence()
			upgrade_sequence();//call upgrade_sequence()
			SetBuildUnit(4, ZIGGURAT_1);//call SetBuildUnit( 4, ZIGGURAT_1        )
			SetBuildUnit(1, hero_id2);//call SetBuildUnit( 1, hero_id2          )
			undead_mine(1);//call undead_mine(1)
			BasicExpansion(mines < 2, UNDEAD_MINE);//call BasicExpansion( mines < 2, UNDEAD_MINE )
			MeleeTownHall(1, NECROPOLIS_1);//call MeleeTownHall( 1, NECROPOLIS_1     )
			if (GetUnitCountDone(UNDEAD_MINE) > 1) {//if GetUnitCountDone(UNDEAD_MINE) > 1 then
				SetBuildUnit(11, ACOLYTE);//call SetBuildUnit( 11, ACOLYTE      )
			}//endif
			UpgradeAll(ZIGGURAT_1, ZIGGURAT_2);//call UpgradeAll( ZIGGURAT_1, ZIGGURAT_2 )
			GuardSecondary(1, 2, ZIGGURAT_1);//call GuardSecondary( 1, 2, ZIGGURAT_1   )
			BuildFactory(SLAUGHTERHOUSE);//call BuildFactory(    SLAUGHTERHOUSE    )
			BuildFactory(DAMNED_TEMPLE);//call BuildFactory(    DAMNED_TEMPLE     )
			SetBuildUnit(1, NECROPOLIS_3);//call SetBuildUnit( 1, NECROPOLIS_3      )
			undead_mine(2);//call undead_mine(2)
			BasicExpansion(mines < 3, UNDEAD_MINE);//call BasicExpansion( mines < 3, UNDEAD_MINE )
			MeleeTownHall(2, NECROPOLIS_1);//call MeleeTownHall( 2, NECROPOLIS_1     )
			GuardSecondary(2, 2, ZIGGURAT_1);//call GuardSecondary( 2, 2, ZIGGURAT_1   )
			SetBuildUnit(1, SAC_PIT);//call SetBuildUnit( 1, SAC_PIT           )
			SetBuildUnit(1, BONEYARD);//call SetBuildUnit( 1, BONEYARD          )
			if (GetUnitCount(BONEYARD)>0 && GetUnitCount(ZEPPELIN)<3) {//if GetUnitCount(BONEYARD)>0 and GetUnitCount(ZEPPELIN)<3 then
				GetZeppelin();//call GetZeppelin()
			}//endif
		}//endfunction
		//
		//
		//
		private void harvest_gold(int townid) {//function harvest_gold takes integer townid returns nothing
			if (TownHasMine(townid)) {//if TownHasMine(townid) then
				HarvestGold(townid,5);//call HarvestGold(townid,5)
			}//endif
		}//endfunction
		//
		//
		//
		private void peon_assignment() {//function peon_assignment takes nothing returns nothing
			while (true) {//loop
				ClearHarvestAI();//call ClearHarvestAI()
				harvest_gold(0);//call harvest_gold(0)
				harvest_gold(1);//call harvest_gold(1)
				harvest_gold(2);//call harvest_gold(2)
				harvest_gold(3);//call harvest_gold(3)
				HarvestWood(0,GetUnitCountDone(GHOUL)-AG);//call HarvestWood(0,GetUnitCountDone(GHOUL)-AG)
				build_sequence();//call build_sequence()
				Sleep(3);//call Sleep(3)
			}//endloop
		}//endfunction
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			do_debug_cheats = GetAiPlayer()==1;//set do_debug_cheats = GetAiPlayer()==1
			PickMeleeHero(RACE_UNDEAD);//call PickMeleeHero(RACE_UNDEAD)
			set_skills();//call set_skills()
			StandardAI(function SkillArrays, function peon_assignment, function attack_sequence);//call StandardAI(function SkillArrays, function peon_assignment, function attack_sequence)
			PlayGame();//call PlayGame()
		}//endfunction

	
	}
}

