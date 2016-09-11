using System;
using System.Collections.Generic;

namespace Jass {

	public class O03_gromAi {

		//
		//
		//
		public const int GO_AGRO = 1;//constant integer GO_AGRO        = 1
		public const int GO_KILL = 2;//constant integer GO_KILL        = 2
		public const int PLAYER_DIED = 3;//constant integer PLAYER_DIED    = 3
		public const int PLAYER_ASS = 4;//constant integer PLAYER_ASS     = 4
		public const int CLEAR_AGRO = 5;//constant integer CLEAR_AGRO     = 5
		public const int USER = 0;//constant integer USER           = 0
		public const int BLUE = 1;//constant integer BLUE           = 1
		public const int GRAY = 8;//constant integer GRAY           = 8
		public const int LIGHT_BLUE = 9;//constant integer LIGHT_BLUE     = 9
		public const int GREEN = 10;//constant integer GREEN          = 10
		public const int EASY_AGRO = 120;//constant integer EASY_AGRO      = 120
		public const int NORMAL_AGRO = 120;//constant integer NORMAL_AGRO    = 120
		public const int HARD_AGRO = 120;//constant integer HARD_AGRO      = 120
		public static int grom_target = -1;//integer grom_target             = -1
		public static int wave_index = 0;//integer wave_index              = 0
		public static int strength = 1;//integer strength                = 1
		public static bool agro_mode = true;//boolean agro_mode               = true
		public static bool[] alive;//boolean array alive
		public static bool[] needs_agro;//boolean array needs_agro
		//
		//
		//
		private void set_build_units(bool fplayer) {//function set_build_units takes boolean fplayer returns nothing
			if (!fplayer) {//if not fplayer then
				SetBuildUnit(1, PEON);//call SetBuildUnit( 1, PEON              )
				SetBuildUnit(1, GREAT_HALL);//call SetBuildUnit( 1, GREAT_HALL        )
				SetBuildUnit(1, ORC_BARRACKS);//call SetBuildUnit( 1, ORC_BARRACKS      )
				SetBuildUnit(1, STRONGHOLD);//call SetBuildUnit( 1, STRONGHOLD        )
				SetBuildUnit(1, ORC_ALTAR);//call SetBuildUnit( 1, ORC_ALTAR         )
				SetBuildUnit(1, FORGE);//call SetBuildUnit( 1, FORGE             )
				SetBuildUnit(1, BESTIARY);//call SetBuildUnit( 1, BESTIARY          )
				SetBuildUnit(7, PEON);//call SetBuildUnit( 7, PEON              )
			} else {//else
				SetBuildUnit(2, ORC_BARRACKS);//call SetBuildUnit( 2, ORC_BARRACKS		)
				SetBuildUnit(2, BESTIARY);//call SetBuildUnit( 2, BESTIARY			)
				SetBuildUnit(4, ORC_WATCH_TOWER);//call SetBuildUnit( 4, ORC_WATCH_TOWER   )
			}//endif
		}//endfunction
		//
		//
		//
		private void set_defenders(bool fplayer) {//function set_defenders takes boolean fplayer returns nothing
			if (!fplayer) {//if not fplayer then
				CampaignDefenderEx(1,1,1, GROM);//call CampaignDefenderEx( 1,1,1, GROM		)
				CampaignDefenderEx(2,2,2, GRUNT);//call CampaignDefenderEx( 2,2,2, GRUNT		)
				CampaignDefenderEx(2,2,2, HEAD_HUNTER);//call CampaignDefenderEx( 2,2,2, HEAD_HUNTER	)
				CampaignDefenderEx(4,4,4, RAIDER);//call CampaignDefenderEx( 4,4,4, RAIDER		)
			} else {//else
				CampaignDefenderEx(2,2,2, GRUNT);//call CampaignDefenderEx( 2,2,2, GRUNT		)
				CampaignDefenderEx(1,1,1, HEAD_HUNTER);//call CampaignDefenderEx( 1,1,1, HEAD_HUNTER	)
				CampaignDefenderEx(1,1,2, RAIDER);//call CampaignDefenderEx( 1,1,2, RAIDER		)
			}//endif
		}//endfunction
		//
		//
		//
		private void assault_wave() {//function assault_wave takes nothing returns nothing
			//
			if (grom_target == USER) {//if grom_target == USER then
				//
				CampaignAttackerEx(3,3,4, GRUNT);//call CampaignAttackerEx	( 3,3,4, GRUNT		 )
				CampaignAttackerEx(3,3,4, HEAD_HUNTER);//call CampaignAttackerEx	( 3,3,4, HEAD_HUNTER )
				CampaignAttackerEx(1,1,2, CATAPULT);//call CampaignAttackerEx	( 1,1,2, CATAPULT	 )
				CampaignAttackerEx(2,2,4, RAIDER);//call CampaignAttackerEx	( 2,2,4, RAIDER		 )
				SuicideOnPlayer(M5,Player(grom_target));//call SuicideOnPlayer(M5,Player(grom_target))
				//
			} else if (strength == 1) {//elseif strength == 1 then
				//
				CampaignAttackerEx(4,4,5, GRUNT);//call CampaignAttackerEx	( 4,4,5, GRUNT		 )
				SuicideOnPlayer(M5,Player(grom_target));//call SuicideOnPlayer(M5,Player(grom_target))
				strength = 2;//set strength = 2
				//
			} else if (strength == 2) {//elseif strength == 2 then
				//
				CampaignAttackerEx(3,3,4, GRUNT);//call CampaignAttackerEx	( 3,3,4, GRUNT		 )
				CampaignAttackerEx(2,2,2, HEAD_HUNTER);//call CampaignAttackerEx	( 2,2,2, HEAD_HUNTER )
				SuicideOnPlayer(M5,Player(grom_target));//call SuicideOnPlayer(M5,Player(grom_target))
				strength = 3;//set strength = 3
				//
			} else {//else
				//
				CampaignAttackerEx(3,3,4, RAIDER);//call CampaignAttackerEx	( 3,3,4, RAIDER		 )
				CampaignAttackerEx(2,2,2, HEAD_HUNTER);//call CampaignAttackerEx	( 2,2,2, HEAD_HUNTER )
				SuicideOnPlayer(M5,Player(grom_target));//call SuicideOnPlayer(M5,Player(grom_target))
				strength = 1;//set strength = 1
			}//endif
		}//endfunction
		//
		//
		//
		private void agro_wave() {//function agro_wave takes nothing returns nothing
			//
			if (strength==1) {//if strength==1 then
				//
				CampaignAttackerEx(4,4,5, GRUNT);//call CampaignAttackerEx	( 4,4,5, GRUNT       )
				SuicideOnPlayer(0,Player(grom_target));//call SuicideOnPlayer(0,Player(grom_target))
				//
			} else if (strength==2) {//elseif strength==2 then
				//
				CampaignAttackerEx(3,3,4, GRUNT);//call CampaignAttackerEx	( 3,3,4, GRUNT		 )
				CampaignAttackerEx(3,3,4, HEAD_HUNTER);//call CampaignAttackerEx	( 3,3,4, HEAD_HUNTER )
				SuicideOnPlayer(M3,Player(grom_target));//call SuicideOnPlayer(M3,Player(grom_target))
				//
			} else {//else
				//
				CampaignAttackerEx(3,3,4, GRUNT);//call CampaignAttackerEx	( 3,3,4, GRUNT		 )
				CampaignAttackerEx(3,3,4, HEAD_HUNTER);//call CampaignAttackerEx	( 3,3,4, HEAD_HUNTER )
				CampaignAttackerEx(3,3,4, RAIDER);//call CampaignAttackerEx	( 3,3,4, RAIDER		 )
				SuicideOnPlayer(M3,Player(grom_target));//call SuicideOnPlayer(M3,Player(grom_target))
			}//endif
		}//endfunction
		//
		//
		//
		private void init_arrays() {//function init_arrays takes nothing returns nothing
			int index = 0;//local integer index = 0
			while (true) {//loop
				alive[index] = false;//set alive      [index] = false
				needs_agro[index] = false;//set needs_agro [index] = false
				index = index + 1;//set index = index + 1
				if (index == 11) { break; }//exitwhen index == 11
			}//endloop
			alive[BLUE       ] = true;//set alive      [ BLUE       ] = true
			alive[GRAY       ] = true;//set alive      [ GRAY       ] = true
			alive[LIGHT_BLUE ] = true;//set alive      [ LIGHT_BLUE ] = true
			alive[GREEN      ] = true;//set alive      [ GREEN      ] = true
			needs_agro[BLUE       ] = true;//set needs_agro [ BLUE       ] = true
			needs_agro[GRAY       ] = true;//set needs_agro [ GRAY       ] = true
			needs_agro[LIGHT_BLUE ] = true;//set needs_agro [ LIGHT_BLUE ] = true
			needs_agro[GREEN      ] = true;//set needs_agro [ GREEN      ] = true
		}//endfunction
		//
		//
		//
		private void wait_for_start() {//function wait_for_start takes nothing returns nothing
			while (true) {//loop
				Trace("waiting for first command...\n");//call Trace("waiting for first command...\n")
				if (CommandsWaiting() != 0) { break; }//exitwhen CommandsWaiting() != 0
				Sleep(5);//call Sleep(5)
			}//endloop
			TraceI("...first command (%d) received.\n",GetLastCommand());//call TraceI("...first command (%d) received.\n",GetLastCommand())
		}//endfunction
		//
		//
		//
		private void possible_agro(int target) {//function possible_agro takes integer target returns nothing
			if (grom_target == -1 && alive[target] && needs_agro[target]) {//if grom_target == -1 and alive[target] and needs_agro[target] then
				grom_target = target;//set grom_target = target
				needs_agro[target] = false;//set needs_agro[target] = false
				TraceI("NOTICE: SET NEEDS_AGRO[%d] = FALSE\n",target);//call TraceI("NOTICE: SET NEEDS_AGRO[%d] = FALSE\n",target)
			}//endif
		}//endfunction
		//
		//
		//
		private void next_alive() {//function next_alive takes nothing returns nothing
			while (true) {//loop
				grom_target = wave_index;//set grom_target = wave_index
				wave_index = wave_index + 1;//set wave_index  = wave_index + 1
				if (wave_index == 11) {//if wave_index == 11 then
					wave_index = 0;//set wave_index = 0
					Sleep(1);//call Sleep(1)
				}//endif
				if (alive[grom_target]) { break; }//exitwhen alive[grom_target]
			}//endloop
			TraceI("Grom setting normal attack wave target = %d\n",grom_target);//call TraceI("Grom setting normal attack wave target = %d\n",grom_target)
		}//endfunction
		//
		//
		//
		private void go_agro() {//function go_agro takes nothing returns nothing
			if (grom_target != -1) {//if grom_target != -1 then
				Trace("Grom successful, sleeping for a while\n");//call Trace("Grom successful, sleeping for a while\n")
				if (difficulty==EASY) {//if difficulty==EASY then
					Sleep(EASY_AGRO);//call Sleep(EASY_AGRO)
				} else if (difficulty==NORMAL) {//elseif difficulty==NORMAL then
					Sleep(NORMAL_AGRO);//call Sleep(NORMAL_AGRO)
				} else {//else
					Sleep(HARD_AGRO);//call Sleep(HARD_AGRO)
				}//endif
				grom_target = -1;//set grom_target = -1
				strength = 1;//set strength    = 1
			}//endif
			possible_agro(BLUE);//call possible_agro( BLUE       )
			possible_agro(GRAY);//call possible_agro( GRAY       )
			possible_agro(LIGHT_BLUE);//call possible_agro( LIGHT_BLUE )
			possible_agro(GREEN);//call possible_agro( GREEN      )
			TraceI("changing agro target to %d\n",grom_target);//call TraceI("changing agro target to %d\n",grom_target)
		}//endfunction
		//
		//
		//
		private void process_commands() {//function process_commands takes nothing returns nothing
			int cmd;//local integer cmd
			int data;//local integer data
			while (true) {//loop
				if (CommandsWaiting() == 0) { break; }//exitwhen CommandsWaiting() == 0
				cmd = GetLastCommand();//set cmd  = GetLastCommand()
				data = GetLastData();//set data = GetLastData()
				PopLastCommand();//call PopLastCommand()
				TraceI("COMMAND = %d\n",cmd);//call TraceI("COMMAND = %d\n",cmd)
				TraceI("DATA = %d\n",data);//call TraceI("DATA = %d\n",data)
				//
				if (cmd == GO_AGRO) {//if cmd == GO_AGRO then
					//
					go_agro();//call go_agro()
					//
				} else if (cmd == GO_KILL) {//elseif cmd == GO_KILL then
					//
					Trace("agro waves complete, starting assault waves\n");//call Trace("agro waves complete, starting assault waves\n")
					agro_mode = false;//set agro_mode = false
					strength = 1;//set strength  = 1
					//
				} else if (cmd == PLAYER_DIED) {//elseif cmd == PLAYER_DIED then
					//
					TraceI("NOTICE: TOWN %d JUST DIED\n",data);//call TraceI("NOTICE: TOWN %d JUST DIED\n",data)
					alive[data] = false;//set alive[data] = false
					//
				} else if (cmd == PLAYER_ASS) {//elseif cmd == PLAYER_ASS then
					//
					Trace("player gonna get punished now!\n");//call Trace("player gonna get punished now!\n")
					set_build_units(true);//call set_build_units(true)
					set_defenders(true);//call set_defenders(true)
					alive[USER] = true;//set alive[USER] = true
					wave_index = USER;//set wave_index = USER
					//
				} else if (cmd == CLEAR_AGRO) {//elseif cmd == CLEAR_AGRO then
					//
					if (data == grom_target) {//if data == grom_target then
						TraceI("player agro'd Grom's target (%d) first\n",data);//call TraceI("player agro'd Grom's target (%d) first\n",data)
						go_agro();//call go_agro()
					} else {//else
						TraceI("player agro'd %d (not Grom's current target)\n",data);//call TraceI("player agro'd %d (not Grom's current target)\n",data)
					}//endif
					TraceI("NOTICE: SET NEEDS_AGRO[%d] = FALSE\n",data);//call TraceI("NOTICE: SET NEEDS_AGRO[%d] = FALSE\n",data)
					needs_agro[data] = false;//set needs_agro[data] = false
					//
				} else {//else
					//
					TraceI("WARNING: UNKNOWN COMMAND (%d)\n",cmd);//call TraceI("WARNING: UNKNOWN COMMAND (%d)\n",cmd)
				}//endif
			}//endloop
		}//endfunction
		//
		//
		//
		private void agro_loop() {//function agro_loop takes nothing returns nothing
			while (true) {//loop
				process_commands();//call process_commands()
				if (!agro_mode) { break; }//exitwhen not agro_mode
				if (grom_target == -1) {//if grom_target == -1 then
					Trace("ERROR: Grom has no agro target!\n");//call Trace("ERROR: Grom has no agro target!\n")
					return;//return
				}//endif
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttacker(EASY, 1, GROM);//call CampaignAttacker( EASY, 1, GROM )
				agro_wave();//call agro_wave()
				strength = strength + 1;//set strength = strength + 1
			}//endloop
		}//endfunction
		//
		//
		//
		private void wave_loop() {//function wave_loop takes nothing returns nothing
			while (true) {//loop
				process_commands();//call process_commands()
				next_alive();//call next_alive()
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttacker(EASY, 1, GROM);//call CampaignAttacker( EASY, 1, GROM )
				assault_wave();//call assault_wave()
			}//endloop
		}//endfunction
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(BURROW,null);//call CampaignAI(BURROW,null)
			init_arrays();//call init_arrays()
			set_build_units(false);//call set_build_units(false)
			set_defenders(false);//call set_defenders(false)
			wait_for_start();//call wait_for_start()
			agro_loop();//call agro_loop()
			wave_loop();//call wave_loop()
		}//endfunction

	
	}
}

