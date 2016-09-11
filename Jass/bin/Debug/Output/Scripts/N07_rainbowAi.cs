using System;
using System.Collections.Generic;

namespace Jass {

	public class N07_rainbowAi {

		//
		//
		//
		//
		//
		//
		private void add_wave(int whero, int wtype) {//function add_wave takes integer whero, integer wtype returns nothing
			if (difficulty == HARD) {//if difficulty == HARD then
			} else {//else
			}//endif
			wave_count = wave_count + 1;//set wave_count = wave_count + 1
		}//endfunction
		//
		//
		//
		private void pit_stop(int ensecs, int hsecs) {//function pit_stop takes integer ensecs, integer hsecs returns nothing
			if (difficulty==HARD) {//if difficulty==HARD then
			} else {//else
			}//endif
			wave_count = wave_count + 1;//set wave_count = wave_count + 1
		}//endfunction
		//
		//
		//
		private void loop_waves() {//function loop_waves takes nothing returns nothing
			wave_restart = wave_count;//set wave_restart = wave_count
		}//endfunction
		//
		//
		//
		private void setup_waves() {//function setup_waves takes integer sequence returns nothing
			TraceI("***** setup_waves (group %d) *****\n",sequence);//call TraceI("***** setup_waves (group %d) *****\n",sequence)
			wave_count = 0;//set wave_count = 0
			//
			if (sequence == 1) {//if sequence == 1 then
				//
				add_wave(0,          BASIC_WAVE1);//call add_wave( 0,          BASIC_WAVE1      )
				add_wave(0,          BASIC_WAVE2);//call add_wave( 0,          BASIC_WAVE2      )
				add_wave(0,          ANTIMAGIC_WAVE);//call add_wave( 0,          ANTIMAGIC_WAVE   )
				add_wave(LICH,       POSSESS_WAVE);//call add_wave( LICH,       POSSESS_WAVE     )
				pit_stop(20, 20);//call pit_stop( 20, 20 )
				add_wave(0,          ANTI_AIR_WAVE);//call add_wave( 0,          ANTI_AIR_WAVE    )
				add_wave(0,          AIR_WAVE);//call add_wave( 0,          AIR_WAVE         )
				pit_stop(30, 30);//call pit_stop( 30, 30 )
				add_wave(DREAD_LORD, ANTIMAGIC_WAVE);//call add_wave( DREAD_LORD, ANTIMAGIC_WAVE   )
				add_wave(LICH,       POSSESS_WAVE);//call add_wave( LICH,       POSSESS_WAVE     )
				pit_stop(30, 30);//call pit_stop( 30, 30 )
				loop_waves();//call loop_waves()
				add_wave(PIT_LORD,   F_U1_WAVE);//call add_wave( PIT_LORD,   F_U1_WAVE        )
				pit_stop(40, 30);//call pit_stop( 40, 30 )
				add_wave(DREAD_LORD, F_U2_WAVE);//call add_wave( DREAD_LORD, F_U2_WAVE        )
				pit_stop(40, 30);//call pit_stop( 40, 30 )
				add_wave(PIT_LORD,   F_U3_WAVE);//call add_wave( PIT_LORD,   F_U3_WAVE        )
				//
			} else if (sequence == 2) {//elseif sequence == 2 then
				//
				add_wave(0,          BASIC_WAVE1);//call add_wave( 0,          BASIC_WAVE1      )
				add_wave(0,          BASIC_WAVE2);//call add_wave( 0,          BASIC_WAVE2      )
				add_wave(DREAD_LORD, SIEGE_WAVE);//call add_wave( DREAD_LORD, SIEGE_WAVE       )
				add_wave(LICH,       SKELETON_WAVE);//call add_wave( LICH,       SKELETON_WAVE    )
				pit_stop(30, 30);//call pit_stop( 30, 30 )
				add_wave(0,          ANTI_AIR_WAVE);//call add_wave( 0,          ANTI_AIR_WAVE    )
				add_wave(0,          AIR_WAVE);//call add_wave( 0,          AIR_WAVE         )
				pit_stop(30, 30);//call pit_stop( 30, 30 )
				add_wave(LICH,       SKELETON_WAVE);//call add_wave( LICH,       SKELETON_WAVE    )
				add_wave(DREAD_LORD, SIEGE_WAVE);//call add_wave( DREAD_LORD, SIEGE_WAVE       )
				pit_stop(60, 30);//call pit_stop( 60, 30 )
				loop_waves();//call loop_waves()
				add_wave(PIT_LORD,   F_U1_WAVE);//call add_wave( PIT_LORD,   F_U1_WAVE        )
				pit_stop(40, 30);//call pit_stop( 40, 30 )
				add_wave(DREAD_LORD, F_U2_WAVE);//call add_wave( DREAD_LORD, F_U2_WAVE        )
				pit_stop(40, 30);//call pit_stop( 40, 30 )
				add_wave(PIT_LORD,   F_U3_WAVE);//call add_wave( PIT_LORD,   F_U3_WAVE        )
				//
				//
				add_wave(0,          BASIC_WAVE1);//call add_wave( 0,          BASIC_WAVE1      )
				add_wave(0,          BASIC_WAVE2);//call add_wave( 0,          BASIC_WAVE2      )
				pit_stop(60, 40);//call pit_stop( 60, 40 )
				add_wave(0,          AIR_WAVE);//call add_wave( 0,          AIR_WAVE         )
				add_wave(LICH,       SKELETON_WAVE);//call add_wave( LICH,       SKELETON_WAVE    )
				pit_stop(60, 40);//call pit_stop( 60, 40 )
				add_wave(0,          PLAGUE_WAVE);//call add_wave( 0,          PLAGUE_WAVE      )
				add_wave(DREAD_LORD, BURNING_WAVE);//call add_wave( DREAD_LORD, BURNING_WAVE     )
				pit_stop(60, 40);//call pit_stop( 60, 40 )
				add_wave(0,          ANTIMAGIC_WAVE);//call add_wave( 0,          ANTIMAGIC_WAVE   )
				add_wave(0,          POSSESS_WAVE);//call add_wave( 0,          POSSESS_WAVE     )
				pit_stop(60, 40);//call pit_stop( 60, 40 )
				add_wave(DREAD_LORD, SIEGE_WAVE);//call add_wave( DREAD_LORD, SIEGE_WAVE       )
				add_wave(LICH,       SKELETON_WAVE);//call add_wave( LICH,       SKELETON_WAVE    )
				pit_stop(60, 40);//call pit_stop( 60, 40 )
				loop_waves();//call loop_waves()
				add_wave(PIT_LORD,   F_U1_WAVE);//call add_wave( PIT_LORD,   F_U1_WAVE        )
				add_wave(DREAD_LORD, F_U2_WAVE);//call add_wave( DREAD_LORD, F_U2_WAVE        )
				add_wave(PIT_LORD,   F_U3_WAVE);//call add_wave( PIT_LORD,   F_U3_WAVE        )
			}//endif
		}//endfunction
		//
		//
		//
		private void wave_units(int norm, int hard, int unitid) {//function wave_units takes integer norm, integer hard, integer unitid returns nothing
			int adding;//local integer adding
			int index;//local integer index
			if (difficulty==HARD) {//if difficulty==HARD then
				adding = hard;//set adding = hard
			} else {//else
				adding = norm;//set adding = norm
			}//endif
			if (adding < 1) {//if adding < 1 then
				return;//return
			}//endif
			//
			//
			index = 0;//set index = 0
			while (true) {//loop
				if (index == harass_length) { break; }//exitwhen index == harass_length
				if (harass_units[index] == unitid) {//if harass_units[index] == unitid then
					harass_qty[index] = harass_qty[index] + adding;//set harass_qty[index] = harass_qty[index] + adding
					harass_max[index] = harass_max[index] + adding;//set harass_max[index] = harass_max[index] + adding
					return;//return
				}//endif
				index = index + 1;//set index = index + 1
			}//endloop
			//
			//
			harass_length = harass_length + 1;//set harass_length = harass_length + 1
		}//endfunction
		//
		//
		//
		private void do_BONUS_LOVE() {//function do_BONUS_LOVE takes nothing returns nothing
			wave_units(1, 1, MEAT_WAGON);//call wave_units( 1, 1, MEAT_WAGON       )
		}//endfunction
		//
		//
		//
		private void do_EVERY_WAVE_FIRST() {//function do_EVERY_WAVE_FIRST takes nothing returns nothing
		}//endfunction
		//
		//
		//
		private void do_EVERY_WAVE_LAST() {//function do_EVERY_WAVE_LAST takes integer heroid returns nothing
			if (heroid != 0) {//if heroid != 0 then
				wave_units(1, 1, heroid);//call wave_units( 1, 1, heroid       )
				wave_units(1, 1, BANSHEE);//call wave_units( 1, 1, BANSHEE      )
			}//endif
		}//endfunction
		//
		//
		//
		private void do_BASIC_WAVE1() {//function do_BASIC_WAVE1 takes nothing returns nothing
			wave_units(6,10, GHOULZ);//call wave_units( 6,10, GHOULZ           )
			wave_units(4, 6, CRYPT_FIEND);//call wave_units( 4, 6, CRYPT_FIEND      )
		}//endfunction
		//
		//
		//
		private void do_BASIC_WAVE2() {//function do_BASIC_WAVE2 takes nothing returns nothing
			wave_units(0, 1, MEAT_WAGON);//call wave_units( 0, 1, MEAT_WAGON       )
			wave_units(8,12, GHOULZ);//call wave_units( 8,12, GHOULZ           )
			wave_units(5, 7, CRYPT_FIEND);//call wave_units( 5, 7, CRYPT_FIEND      )
		}//endfunction
		//
		//
		//
		private void do_POSSESS_WAVE() {//function do_POSSESS_WAVE takes nothing returns nothing
			wave_units(2, 3, ABOMINATION);//call wave_units( 2, 3, ABOMINATION      )
			wave_units(8,10, BANSHEE_POSSESS);//call wave_units( 8,10, BANSHEE_POSSESS  )
		}//endfunction
		//
		//
		//
		private void do_ANTIMAGIC_WAVE() {//function do_ANTIMAGIC_WAVE takes nothing returns nothing
			wave_units(0, 1, MEAT_WAGON);//call wave_units( 0, 1, MEAT_WAGON       )
			wave_units(2, 3, DOOMGUARD);//call wave_units( 2, 3, DOOMGUARD        )
			wave_units(6, 8, FELLHOUND);//call wave_units( 6, 8, FELLHOUND        )
		}//endfunction
		//
		//
		//
		private void do_AIR_WAVE() {//function do_AIR_WAVE takes nothing returns nothing
			wave_units(6, 8, GARGOYLE);//call wave_units( 6, 8, GARGOYLE         )
			wave_units(4, 5, FROST_WYRM);//call wave_units( 4, 5, FROST_WYRM       )
		}//endfunction
		//
		//
		//
		private void do_ANTI_AIR_WAVE() {//function do_ANTI_AIR_WAVE takes nothing returns nothing
			wave_units(1, 2, DOOMGUARD);//call wave_units( 1, 2, DOOMGUARD        )
			wave_units(5, 7, CRYPT_FIEND);//call wave_units( 5, 7, CRYPT_FIEND      )
			wave_units(7, 9, GARGOYLE);//call wave_units( 7, 9, GARGOYLE         )
		}//endfunction
		//
		//
		//
		private void do_SIEGE_WAVE() {//function do_SIEGE_WAVE takes nothing returns nothing
			wave_units(5, 7, MEAT_WAGON);//call wave_units( 5, 7, MEAT_WAGON       )
			wave_units(5, 7, ABOMINATION);//call wave_units( 5, 7, ABOMINATION      )
			wave_units(2, 3, FROST_WYRM);//call wave_units( 2, 3, FROST_WYRM       )
		}//endfunction
		//
		//
		//
		private void do_BURNING_WAVE() {//function do_BURNING_WAVE takes nothing returns nothing
			wave_units(1, 2, DOOMGUARD);//call wave_units( 1, 2, DOOMGUARD        )
			wave_units(6, 8, BUILD_INFERNAL);//call wave_units( 6, 8, BUILD_INFERNAL   )
		}//endfunction
		//
		//
		//
		private void do_PLAGUE_WAVE() {//function do_PLAGUE_WAVE takes nothing returns nothing
			wave_units(1, 2, MEAT_WAGON);//call wave_units( 1, 2, MEAT_WAGON       )
			wave_units(4, 6, GHOULZ);//call wave_units( 4, 6, GHOULZ           )
			wave_units(5, 7, ABOMINATION);//call wave_units( 5, 7, ABOMINATION      )
			wave_units(3, 4, NECRO);//call wave_units( 3, 4, NECRO            )
		}//endfunction
		//
		//
		//
		private void do_SKELETON_WAVE() {//function do_SKELETON_WAVE takes nothing returns nothing
			wave_units(0, 1, MEAT_WAGON);//call wave_units( 0, 1, MEAT_WAGON       )
			wave_units(4, 6, ABOMINATION);//call wave_units( 4, 6, ABOMINATION      )
			wave_units(8,10, NECRO);//call wave_units( 8,10, NECRO            )
		}//endfunction
		//
		//
		//
		private void do_F_U1_WAVE() {//function do_F_U1_WAVE takes nothing returns nothing
			wave_units(1, 2, MEAT_WAGON);//call wave_units( 1, 2, MEAT_WAGON       )
			wave_units(2, 3, DOOMGUARD);//call wave_units( 2, 3, DOOMGUARD        )
			wave_units(5, 7, FELLHOUND);//call wave_units( 5, 7, FELLHOUND        )
			wave_units(2, 3, BANSHEE_CURSE);//call wave_units( 2, 3, BANSHEE_CURSE    )
			wave_units(2, 3, FROST_WYRM);//call wave_units( 2, 3, FROST_WYRM       )
			wave_units(2, 3, NECRO);//call wave_units( 2, 3, NECRO            )
		}//endfunction
		//
		//
		//
		private void do_F_U2_WAVE() {//function do_F_U2_WAVE takes nothing returns nothing
			wave_units(1, 2, MEAT_WAGON);//call wave_units( 1, 2, MEAT_WAGON       )
			wave_units(2, 3, BUILD_INFERNAL);//call wave_units( 2, 3, BUILD_INFERNAL   )
			wave_units(3, 5, ABOMINATION);//call wave_units( 3, 5, ABOMINATION      )
			wave_units(4, 6, CRYPT_FIEND);//call wave_units( 4, 6, CRYPT_FIEND      )
			wave_units(2, 3, BANSHEE_CURSE);//call wave_units( 2, 3, BANSHEE_CURSE    )
			wave_units(2, 3, NECRO);//call wave_units( 2, 3, NECRO            )
		}//endfunction
		//
		//
		//
		private void do_F_U3_WAVE() {//function do_F_U3_WAVE takes nothing returns nothing
			wave_units(2, 3, MEAT_WAGON);//call wave_units( 2, 3, MEAT_WAGON       )
			wave_units(2, 3, BUILD_INFERNAL);//call wave_units( 2, 3, BUILD_INFERNAL   )
			wave_units(3, 4, BANSHEE_POSSESS);//call wave_units( 3, 4, BANSHEE_POSSESS  )
			wave_units(3, 4, DOOMGUARD);//call wave_units( 3, 4, DOOMGUARD        )
			wave_units(4, 5, FELLHOUND);//call wave_units( 4, 5, FELLHOUND        )
			wave_units(2, 3, FROST_WYRM);//call wave_units( 2, 3, FROST_WYRM       )
			wave_units(1, 1, LICH);//call wave_units( 1, 1, LICH             )
			wave_units(2, 3, NECRO);//call wave_units( 2, 3, NECRO            )
		}//endfunction
		//
		//
		//
		private int bonus_waves(int allow, int factor, int base, int cap) {//function bonus_waves takes integer allow, integer factor, integer base, integer cap returns integer
			int trees = GetPlayerUnitTypeCount( USER, ANCIENT_PROTECT );//local integer trees = GetPlayerUnitTypeCount( USER, ANCIENT_PROTECT )
			int result;//local integer result
			if (trees <= allow || factor <= 0) {//if trees <= allow or factor <= 0 then
				return base;//return base
			}//endif
			result = base + (trees - allow) / factor + 1;//set result = base + (trees - allow) / factor + 1
			if (result > cap) {//if result > cap then
				return cap;//return cap
			}//endif
			return result;//return result
		}//endfunction
		//
		//
		//
		private void consider_bonus_love() {//function consider_bonus_love takes nothing returns nothing
			int times;//local integer times
			if (difficulty==HARD) {//if difficulty==HARD then
				times = bonus_waves( HARD_ALLOW_TREES, HARD_TREE_FACTOR, HARD_BASE_BONUS, HARD_BONUS_CAP );//set times = bonus_waves( HARD_ALLOW_TREES, HARD_TREE_FACTOR, HARD_BASE_BONUS, HARD_BONUS_CAP )
			} else {//else
				times = bonus_waves( NORM_ALLOW_TREES, NORM_TREE_FACTOR, NORM_BASE_BONUS, NORM_BONUS_CAP );//set times = bonus_waves( NORM_ALLOW_TREES, NORM_TREE_FACTOR, NORM_BASE_BONUS, NORM_BONUS_CAP )
			}//endif
			TraceI("Bonus love = %d\n",times);//call TraceI("Bonus love = %d\n",times)
			while (true) {//loop
				if (times <= 0) { break; }//exitwhen times <= 0
				do_BONUS_LOVE();//call do_BONUS_LOVE()
				times = times - 1;//set times = times - 1
			}//endloop
		}//endfunction
		//
		//
		//
		private void check_abort() {//function check_abort takes nothing returns nothing
			if (CommandsWaiting() == 0) {//if CommandsWaiting() == 0 then
				return;//return
			}//endif
			if (GetLastCommand()==CMD_STOP) {//if GetLastCommand()==CMD_STOP then
				Trace("***** ABORT *****\n");//call Trace("***** ABORT *****\n")
				aborting = true;//set aborting = true
				SleepForever();//call SleepForever()
			} else {//else
				Trace("***** UNEXPECTED COMMAND *****\n");//call Trace("***** UNEXPECTED COMMAND *****\n")
				PopLastCommand();//call PopLastCommand()
			}//endif
		}//endfunction
		//
		//
		//
		private void form_wave() {//function form_wave takes nothing returns nothing
			int index;//local integer index
			index = 0;//set index = 0
			while (true) {//loop
				if (index == harass_length) { break; }//exitwhen index == harass_length
				AddAssault(harass_max[index],harass_units[index]);//call AddAssault(harass_max[index],harass_units[index])
				index = index + 1;//set index = index + 1
			}//endloop
		}//endfunction
		//
		//
		//
		private void suicide_wave() {//function suicide_wave takes nothing returns nothing
			int index;//local integer index
			int count;//local integer count
			int desire;//local integer desire
			int unitid;//local integer unitid
			int length = harass_length;//local integer length = harass_length
			harass_length = 0;//set harass_length = 0
			index = 0;//set index = 0
			while (true) {//loop
				if (index == length) { break; }//exitwhen index == length
				TraceI("wave cycle %d\n",index+1);//call TraceI("wave cycle %d\n",index+1)
				desire = harass_max[index];//set desire = harass_max[index]
				unitid = harass_units[index];//set unitid = harass_units[index]
				if (unitid==LICH) {//if unitid==LICH then
					send_lich = true;//set send_lich = true
				} else if (unitid==DREAD_LORD) {//elseif unitid==DREAD_LORD then
					send_lord = true;//set send_lord = true
				} else if (unitid==PIT_LORD) {//elseif unitid==PIT_LORD then
					send_azga = true;//set send_azga = true
				}//endif
				sleep_seconds = sleep_seconds-2;//set sleep_seconds = sleep_seconds-2
				count = 0;//set count = 0
				while (true) {//loop
					SuicideUnitEx(1,unitid,target);//call SuicideUnitEx(1,unitid,target)
					Sleep(0.1);//call Sleep(0.1)
					count = count + 1;//set count = count + 1
					if (count==20) { break; }//exitwhen count==20
				}//endloop
				index = index + 1;//set index = index + 1
			}//endloop
			Trace("all waves sent\n");//call Trace("all waves sent\n")
		}//endfunction
		//
		//
		//
		private void suicide_unit() {//function suicide_unit takes integer unitid returns nothing
			SuicideUnitEx(1,unitid,target);//call SuicideUnitEx(1,unitid,target)
			SuicideUnitEx(1,SKEL_WARRIOR,target);//call SuicideUnitEx(1,SKEL_WARRIOR,target)
			Sleep(0.1);//call Sleep(0.1)
		}//endfunction
		//
		//
		//
		private void possessions() {//function possessions takes nothing returns nothing
			sleep_seconds = sleep_seconds - 1;//set sleep_seconds = sleep_seconds - 1
			suicide_unit(INFERNAL);//call suicide_unit( INFERNAL      )
			suicide_unit(FOOTMAN);//call suicide_unit( FOOTMAN       )
			suicide_unit(RIFLEMAN);//call suicide_unit( RIFLEMAN      )
			suicide_unit(SORCERESS);//call suicide_unit( SORCERESS     )
			suicide_unit(PRIEST);//call suicide_unit( PRIEST        )
			suicide_unit(MORTAR);//call suicide_unit( MORTAR        )
			suicide_unit(ELEMENTAL);//call suicide_unit( ELEMENTAL     )
			suicide_unit(KNIGHT);//call suicide_unit( KNIGHT        )
			suicide_unit(GRYPHON);//call suicide_unit( GRYPHON       )
			suicide_unit(MILITIA);//call suicide_unit( MILITIA       )
			sleep_seconds = sleep_seconds - 1;//set sleep_seconds = sleep_seconds - 1
			suicide_unit(GRUNT);//call suicide_unit( GRUNT         )
			suicide_unit(HEAD_HUNTER);//call suicide_unit( HEAD_HUNTER   )
			suicide_unit(TAUREN);//call suicide_unit( TAUREN        )
			suicide_unit(WITCH_DOCTOR);//call suicide_unit( WITCH_DOCTOR  )
			suicide_unit(KODO_BEAST);//call suicide_unit( KODO_BEAST    )
			suicide_unit(RAIDER);//call suicide_unit( RAIDER        )
			suicide_unit(SHAMAN);//call suicide_unit( SHAMAN        )
			suicide_unit(WYVERN);//call suicide_unit( WYVERN        )
			suicide_unit(SHANDRIS);//call suicide_unit( SHANDRIS      )
			suicide_unit(ENT);//call suicide_unit( ENT           )
			sleep_seconds = sleep_seconds - 1;//set sleep_seconds = sleep_seconds - 1
			suicide_unit(ARCHER);//call suicide_unit( ARCHER        )
			suicide_unit(DRUID_TALON);//call suicide_unit( DRUID_TALON   )
			suicide_unit(DRUID_TALON_M);//call suicide_unit( DRUID_TALON_M )
			suicide_unit(DRUID_CLAW);//call suicide_unit( DRUID_CLAW    )
			suicide_unit(DRUID_CLAW_M);//call suicide_unit( DRUID_CLAW_M  )
			suicide_unit(DRYAD);//call suicide_unit( DRYAD         )
			suicide_unit(HIPPO);//call suicide_unit( HIPPO         )
			suicide_unit(HIPPO_RIDER);//call suicide_unit( HIPPO_RIDER   )
			suicide_unit(HUNTRESS);//call suicide_unit( HUNTRESS      )
			suicide_unit(CHIMAERA);//call suicide_unit( CHIMAERA      )
		}//endfunction
		//
		//
		//
		private bool send_hero(bool send, int heroid) {//function send_hero takes boolean send, integer heroid returns boolean
			if (!send || GetUnitCountDone(heroid) < 1) {//if not send or GetUnitCountDone(heroid) < 1 then
				return false;//return false
			}//endif
			SuicideUnitEx(1, heroid, target);//call SuicideUnitEx( 1, heroid, target )
			return true;//return true
		}//endfunction
		//
		//
		//
		private void hero_failsafe() {//function hero_failsafe takes nothing returns nothing
			while (true) {//loop
				send_lich = send_hero( send_lich, LICH       );//set send_lich = send_hero( send_lich, LICH       )
				Sleep(0.5);//call Sleep(0.5)
				send_lord = send_hero( send_lord, DREAD_LORD );//set send_lord = send_hero( send_lord, DREAD_LORD )
				Sleep(0.5);//call Sleep(0.5)
				send_azga = send_hero( send_azga, PIT_LORD   );//set send_azga = send_hero( send_azga, PIT_LORD   )
				Sleep(0.5);//call Sleep(0.5)
			}//endloop
		}//endfunction
		//
		//
		//
		private void send_waves() {//function send_waves takes nothing returns nothing
			int index = 0;//local integer index = 0
			while (true) {//loop
				if (GetUnitCountDone(CRYPT)>0) { break; }//exitwhen GetUnitCountDone(CRYPT)>0
				Sleep(1);//call Sleep(1)
			}//endloop
			while (true) {//loop
				check_abort();//call check_abort()
				InitAssaultGroup();//call InitAssaultGroup()
				TraceI("next wave = %d\n",wave_type[index]);//call TraceI("next wave = %d\n",wave_type[index])
				TraceI("strength  = %d\n",strength);//call TraceI("strength  = %d\n",strength)
				if (wave_type[index]!=PIT_STOP_WAVE) {//if wave_type[index]!=PIT_STOP_WAVE then
					do_EVERY_WAVE_FIRST();//call do_EVERY_WAVE_FIRST()
					if (index >= 2) {//if index >= 2 then
						consider_bonus_love();//call consider_bonus_love()
					}//endif
				}//endif
				if (wave_type[index]==BASIC_WAVE1) {//if wave_type[index]==BASIC_WAVE1 then
					do_BASIC_WAVE1();//call do_BASIC_WAVE1()
				} else if (wave_type[index]==BASIC_WAVE2) {//elseif wave_type[index]==BASIC_WAVE2 then
					do_BASIC_WAVE2();//call do_BASIC_WAVE2()
				} else if (wave_type[index]==AIR_WAVE) {//elseif wave_type[index]==AIR_WAVE then
					do_AIR_WAVE();//call do_AIR_WAVE()
				} else if (wave_type[index]==ANTI_AIR_WAVE) {//elseif wave_type[index]==ANTI_AIR_WAVE then
					do_ANTI_AIR_WAVE();//call do_ANTI_AIR_WAVE()
				} else if (wave_type[index]==ANTIMAGIC_WAVE) {//elseif wave_type[index]==ANTIMAGIC_WAVE then
					do_ANTIMAGIC_WAVE();//call do_ANTIMAGIC_WAVE()
				} else if (wave_type[index]==SIEGE_WAVE) {//elseif wave_type[index]==SIEGE_WAVE then
					do_SIEGE_WAVE();//call do_SIEGE_WAVE()
				} else if (wave_type[index]==POSSESS_WAVE) {//elseif wave_type[index]==POSSESS_WAVE then
					do_POSSESS_WAVE();//call do_POSSESS_WAVE()
				} else if (wave_type[index]==SKELETON_WAVE) {//elseif wave_type[index]==SKELETON_WAVE then
					do_SKELETON_WAVE();//call do_SKELETON_WAVE()
				} else if (wave_type[index]==PLAGUE_WAVE) {//elseif wave_type[index]==PLAGUE_WAVE then
					do_PLAGUE_WAVE();//call do_PLAGUE_WAVE()
				} else if (wave_type[index]==BURNING_WAVE) {//elseif wave_type[index]==BURNING_WAVE then
					do_BURNING_WAVE();//call do_BURNING_WAVE()
				} else if (wave_type[index]==F_U1_WAVE) {//elseif wave_type[index]==F_U1_WAVE then
					do_F_U1_WAVE();//call do_F_U1_WAVE()
				} else if (wave_type[index]==F_U2_WAVE) {//elseif wave_type[index]==F_U2_WAVE then
					do_F_U2_WAVE();//call do_F_U2_WAVE()
				} else if (wave_type[index]==F_U3_WAVE) {//elseif wave_type[index]==F_U3_WAVE then
					do_F_U3_WAVE();//call do_F_U3_WAVE()
				} else if (wave_type[index]==PIT_STOP_WAVE) {//elseif wave_type[index]==PIT_STOP_WAVE then
					//
				} else {//else
					Trace("**UNKNOWN WAVE CONTENTS**\n");//call Trace("**UNKNOWN WAVE CONTENTS**\n")
					do_BASIC_WAVE1();//call do_BASIC_WAVE1()
				}//endif
				if (wave_type[index]!=PIT_STOP_WAVE) {//if wave_type[index]!=PIT_STOP_WAVE then
					do_EVERY_WAVE_LAST(wave_hero[index]);//call do_EVERY_WAVE_LAST(wave_hero[index])
					if (at_stage1) {//if at_stage1 then
						at_stage1 = false;//set at_stage1 = false
						SetCaptainHome(BOTH_CAPTAINS,stage_x2,stage_y2);//call SetCaptainHome(BOTH_CAPTAINS,stage_x2,stage_y2)
					} else {//else
						at_stage1 = true;//set at_stage1 = true
						SetCaptainHome(BOTH_CAPTAINS,stage_x1,stage_y1);//call SetCaptainHome(BOTH_CAPTAINS,stage_x1,stage_y1)
					}//endif
				}//endif
				AddSleepSeconds(wave_sleep[index]);//call AddSleepSeconds(wave_sleep[index])
				while (true) {//loop
					TraceI("forming wave (T%+d seconds)\n",-sleep_seconds);//call TraceI("forming wave (T%+d seconds)\n",-sleep_seconds)
					check_abort();//call check_abort()
					possessions();//call possessions()
					form_wave();//call form_wave()
					if (sleep_seconds <= 0) { break; }//exitwhen sleep_seconds <= 0
				}//endloop
				suicide_wave();//call suicide_wave()
				index = index + 1;//set index = index + 1
				if (index==wave_count) {//if index==wave_count then
					index = wave_restart;//set index = wave_restart
				}//endif
			}//endloop
		}//endfunction
		//
		//
		//
		private void get_commands() {//function get_commands takes nothing returns nothing
			int cmd;//local integer cmd
			int data;//local integer data
			while (true) {//loop
				while (true) {//loop
					if (CommandsWaiting() != 0) { break; }//exitwhen CommandsWaiting() != 0
					Sleep(1);//call Sleep(1)
				}//endloop
				cmd = GetLastCommand();//set cmd  = GetLastCommand()
				data = GetLastData();//set data = GetLastData()
				PopLastCommand();//call PopLastCommand()
				if (cmd == CMD_SET_X1) {//if cmd == CMD_SET_X1 then
					TraceI("CMD_SET_X1 (%d)\n",data);//call TraceI("CMD_SET_X1 (%d)\n",data)
					stage_x1 = data;//set stage_x1 = data
				} else if (cmd == CMD_SET_Y1) {//elseif cmd == CMD_SET_Y1 then
					TraceI("CMD_SET_Y1 (%d)\n",data);//call TraceI("CMD_SET_Y1 (%d)\n",data)
					stage_y1 = data;//set stage_y1 = data
				} else if (cmd == CMD_SET_X2) {//elseif cmd == CMD_SET_X2 then
					TraceI("CMD_SET_X2 (%d)\n",data);//call TraceI("CMD_SET_X2 (%d)\n",data)
					stage_x2 = data;//set stage_x2 = data
					need_stage2 = false;//set need_stage2 = false
				} else if (cmd == CMD_SET_Y2) {//elseif cmd == CMD_SET_Y2 then
					TraceI("CMD_SET_Y2 (%d)\n",data);//call TraceI("CMD_SET_Y2 (%d)\n",data)
					stage_y2 = data;//set stage_y2 = data
					need_stage2 = false;//set need_stage2 = false
				} else if (cmd == CMD_SET_SEQUENCE) {//elseif cmd == CMD_SET_SEQUENCE then
					TraceI("CMD_SET_SEQUENCE (%d)\n",data);//call TraceI("CMD_SET_SEQUENCE (%d)\n",data)
					if (data==2) {//if data==2 then
						harvest_ghouls = 5;//set harvest_ghouls = 5
					} else {//else
						harvest_ghouls = 13;//set harvest_ghouls = 13
					}//endif
					setup_waves(data);//call setup_waves(data)
				} else if (cmd == CMD_SET_TARGET) {//elseif cmd == CMD_SET_TARGET then
					TraceI("CMD_SET_TARGET (%d)\n",data);//call TraceI("CMD_SET_TARGET (%d)\n",data)
					target = data;//set target = data
					if (need_stage2) {//if need_stage2 then
						stage_x2 = stage_x1;//set stage_x2 = stage_x1
						stage_y2 = stage_y1;//set stage_y2 = stage_y1
					}//endif
					SetCaptainHome(BOTH_CAPTAINS,stage_x1,stage_y1);//call SetCaptainHome(BOTH_CAPTAINS,stage_x1,stage_y1)
					send_waves();//call send_waves()
				} else {//else
					TraceI("unknown command (%d)\n",cmd);//call TraceI("unknown command (%d)\n",cmd)
					TraceI("unknown data (%d)\n",data);//call TraceI("unknown data (%d)\n",data)
				}//endif
			}//endloop
		}//endfunction
		//
		//
		//
		private void start_unit(int qty, int unitid, bool wait) {//function start_unit takes integer qty, integer unitid, boolean wait returns nothing
			SetBuildUnit(qty, unitid);//call SetBuildUnit( qty, unitid )
			while (true) {//loop
				if (TownCount(unitid) >= qty) { break; }//exitwhen TownCount(unitid) >= qty
				Sleep(2);//call Sleep(2)
			}//endloop
			if (!wait) {//if not wait then
				return;//return
			}//endif
			while (true) {//loop
				if (TownCountDone(unitid) >= qty) { break; }//exitwhen TownCountDone(unitid) >= qty
				Sleep(1);//call Sleep(1)
			}//endloop
		}//endfunction
		//
		//
		//
		private void define_town() {//function define_town takes nothing returns nothing
			do_campaign_farms = false;//set do_campaign_farms       = false
			campaign_wood_peons = 15;//set campaign_wood_peons     = 15
			campaign_basics_speed = 3;//set campaign_basics_speed   = 3
			SetSlowChopping(false);//call SetSlowChopping(false)
			start_unit(1, ACOLYTE,        true);//call start_unit( 1, ACOLYTE,        true  )
			start_unit(1, NECROPOLIS_1,   false);//call start_unit( 1, NECROPOLIS_1,   false )
			start_unit(2, CRYPT,          false);//call start_unit( 2, CRYPT,          false )
			start_unit(1, GRAVEYARD,      false);//call start_unit( 1, GRAVEYARD,      false )
			start_unit(1, UNDEAD_ALTAR,   false);//call start_unit( 1, UNDEAD_ALTAR,   false )
			start_unit(4, ZIGGURAT_1,     false);//call start_unit( 4, ZIGGURAT_1,     false )
			SetBuildUnit(harvest_ghouls, GHOUL);//call SetBuildUnit( harvest_ghouls, GHOUL )
			start_unit(1, NECROPOLIS_2,   true);//call start_unit( 1, NECROPOLIS_2,   true  )
			start_unit(2, SLAUGHTERHOUSE, false);//call start_unit( 2, SLAUGHTERHOUSE, false )
			start_unit(1, DAMNED_TEMPLE,  false);//call start_unit( 1, DAMNED_TEMPLE,  false )
			start_unit(1, SAC_PIT,        false);//call start_unit( 1, SAC_PIT,        false )
			start_unit(1, NECROPOLIS_3,   true);//call start_unit( 1, NECROPOLIS_3,   true  )
			start_unit(1, BONEYARD,       false);//call start_unit( 1, BONEYARD,       false )
			start_unit(4, ZIGGURAT_2,     false);//call start_unit( 4, ZIGGURAT_2,     false )
			start_unit(4, ACOLYTE,        false);//call start_unit( 4, ACOLYTE,        false )
			while (true) {//loop
				if (aborting && GetUnitCountDone(ACOLYTE)>0) { break; }//exitwhen aborting and GetUnitCountDone(ACOLYTE)>0
				Sleep(5);//call Sleep(5)
			}//endloop
			Trace("***** UNSUMMON TOWN *****\n");//call Trace("***** UNSUMMON TOWN *****\n")
			InitBuildArray();//call InitBuildArray()
			InitAssaultGroup();//call InitAssaultGroup()
			UnsummonAll();//call UnsummonAll()
			SleepForever();//call SleepForever()
		}//endfunction
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			TraceI("***** rainbow main started for %d *****\n",GetAiPlayer());//call TraceI("***** rainbow main started for %d *****\n",GetAiPlayer())
			do_debug_cheats = true;//set do_debug_cheats = true
			Cheat("aitrace");//call Cheat("aitrace")
			//
		}//endif
		CampaignAI(ZIGGURAT_1,null);//call CampaignAI(ZIGGURAT_1,null)
		StartThread(function define_town);//call StartThread(function define_town)
		StartThread(function hero_failsafe);//call StartThread(function hero_failsafe)
		get_commands();//call get_commands()
	}//endfunction

	
	}
}

