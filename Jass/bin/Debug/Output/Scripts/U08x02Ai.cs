using System;
using System.Collections.Generic;

namespace Jass {

	public class U08x02Ai {

		//
		//
		//
		public const int ILLIDAN_TOWN_X = 4400;//constant integer ILLIDAN_TOWN_X     = 4400
		public const int ILLIDAN_TOWN_Y = 6300;//constant integer ILLIDAN_TOWN_Y     = 6300
		public const int ILLIDAN_DEF_X = 5050;//constant integer ILLIDAN_DEF_X      = 5050
		public const int ILLIDAN_DEF_Y = 6600;//constant integer ILLIDAN_DEF_Y      = 6600
		public const player USER = PlayerEx(1);//constant player USER                = PlayerEx(1)
		public const int OFFSET_X = 600;//constant integer OFFSET_X           = 600
		public const int OFFSET_Y = 500;//constant integer OFFSET_Y           = 500
		public const int NAGA_COUATL2 = 'n000';//constant integer NAGA_COUATL2       = 'n000'
		public const int NAGA_REAVER2 = 'n001';//constant integer NAGA_REAVER2       = 'n001'
		public const int NAGA_ROYAL2 = 'n002';//constant integer NAGA_ROYAL2        = 'n002'
		public const int NAGA_MYRMIDON2 = 'n003';//constant integer NAGA_MYRMIDON2     = 'n003'
		public const int NAGA_SNAP_DRAGON2 = 'n004';//constant integer NAGA_SNAP_DRAGON2  = 'n004'
		public const int NAGA_TURTLE2 = 'n005';//constant integer NAGA_TURTLE2       = 'n005'
		public const int NAGA_SIREN2 = 'n007';//constant integer NAGA_SIREN2        = 'n007'
		public const int BUCKET_COUATL = 0;//constant integer BUCKET_COUATL      = 0
		public const int BUCKET_SNAP_DRAGON = 1;//constant integer BUCKET_SNAP_DRAGON = 1
		public const int BUCKET_REAVER = 2;//constant integer BUCKET_REAVER      = 2
		public const int BUCKET_MYRMIDON = 3;//constant integer BUCKET_MYRMIDON    = 3
		public const int BUCKET_SIREN = 4;//constant integer BUCKET_SIREN       = 4
		public const int BUCKET_TURTLE = 5;//constant integer BUCKET_TURTLE      = 5
		public const int BUCKET_ROYAL = 6;//constant integer BUCKET_ROYAL       = 6
		public const int BUCKET_END = 7;//constant integer BUCKET_END         = 7
		public const int SET_TOWN_1_X = 1;//constant integer SET_TOWN_1_X       =  1
		public const int SET_TOWN_1_Y = 2;//constant integer SET_TOWN_1_Y       =  2
		public const int SET_TOWN_2_X = 3;//constant integer SET_TOWN_2_X       =  3
		public const int SET_TOWN_2_Y = 4;//constant integer SET_TOWN_2_Y       =  4
		public const int SET_TOWN_3_X = 5;//constant integer SET_TOWN_3_X       =  5
		public const int SET_TOWN_3_Y = 6;//constant integer SET_TOWN_3_Y       =  6
		public const int SET_TOWN_4_X = 7;//constant integer SET_TOWN_4_X       =  7
		public const int SET_TOWN_4_Y = 8;//constant integer SET_TOWN_4_Y       =  8
		public const int PEONS_LOST = 9;//constant integer PEONS_LOST         =  9
		public const int SLOT_LOST = 10;//constant integer SLOT_LOST          = 10
		public const int SLOT_GAINED = 11;//constant integer SLOT_GAINED        = 11
		public const int SLOT_STEPPED_ON = 12;//constant integer SLOT_STEPPED_ON    = 12
		public const int STARTUP_CMDS = 12;//constant integer STARTUP_CMDS       = 12
		public const bool NORMAL_ATTACK = true;//constant boolean NORMAL_ATTACK      = true
		public const bool PEON_ATTACK = false;//constant boolean PEON_ATTACK        = false
		public const int NO_CONTROL = 1;//constant integer NO_CONTROL         = 1
		public const int ILLIDAN_CONTROL = 2;//constant integer ILLIDAN_CONTROL    = 2
		public const int ARTHAS_CONTROL = 3;//constant integer ARTHAS_CONTROL     = 3
		public const int NOT_POSSIBLE = 1;//constant integer NOT_POSSIBLE       = 1
		public const int START_SLOT = 2;//constant integer START_SLOT         = 2
		public static int startup = 0;//integer startup                     = 0
		public static bool first_attack = true;//boolean first_attack                = true
		public static int action_state = SLOT_LOST;//integer action_state                = SLOT_LOST
		public static int next_slot = -1;//integer next_slot                   = -1
		public static int attack_delay = 1;//integer attack_delay                = 1
		public static int attack_index = 0;//integer attack_index                = 0
		public static bool rebuild_Illidan = true;//boolean rebuild_Illidan             = true
		public static bool stepped_on = false;//boolean stepped_on                  = false
		public static bool suicide_mode = false;//boolean suicide_mode                = false
		public static bool did_suicide = false;//boolean did_suicide                 = false
		public static bool timeout_failure = false;//boolean timeout_failure             = false
		public static int[] town_x;//integer array town_x
		public static int[] town_y;//integer array town_y
		public static bool[] peons_lost;//boolean array peons_lost
		public static bool[] slot_owned;//boolean array slot_owned
		public static int[] slot_control;//integer array slot_control
		public static int[] Illidan0;//integer array Illidan0
		public static int[] Illidan1;//integer array Illidan1
		public static int[] Illidan2;//integer array Illidan2
		public static int[] Illidan3;//integer array Illidan3
		public static int[] attack_min_COPs;//integer array attack_min_COPs
		public static int[] attack_max_COPs;//integer array attack_max_COPs
		public static int[] attack_qty;//integer array attack_qty
		public static int[] attack_bucket;//integer array attack_bucket
		public static int[] bucket_qty;//integer array bucket_qty
		public static int[] bucket_unitid;//integer array bucket_unitid
		public static float[] food_factor;//real array food_factor
		public static float dragon_factor;//real dragon_factor
		//
		//
		//
		private void set_attack_group(int min_COPs, int max_COPs, int normal, int hard, int idx) {//function set_attack_group takes integer min_COPs, integer max_COPs, integer normal, integer hard, integer idx returns nothing
			attack_min_COPs[attack_index] = min_COPs;//set attack_min_COPs[attack_index] = min_COPs
			attack_max_COPs[attack_index] = max_COPs;//set attack_max_COPs[attack_index] = max_COPs
			attack_bucket[attack_index] = idx;//set attack_bucket[attack_index]   = idx
			if (difficulty==EASY || difficulty==NORMAL) {//if difficulty==EASY or difficulty==NORMAL then
				attack_qty[attack_index] = normal;//set attack_qty[attack_index] = normal
			} else {//else
				attack_qty[attack_index] = hard;//set attack_qty[attack_index] = hard
			}//endif
			attack_index = attack_index + 1;//set attack_index = attack_index + 1
		}//endfunction
		//
		//
		//
		private int wave_time(int norm, int hard) {//function wave_time takes integer norm, integer hard returns integer
			if (difficulty==EASY || difficulty==NORMAL) {//if difficulty==EASY or difficulty==NORMAL then
				return norm;//return norm
			} else {//else
				return hard;//return hard
			}//endif
		}//endfunction
		//
		//
		//
		private float balance_factor(float norm, float hard) {//function balance_factor takes real norm, real hard returns real
			if (difficulty==EASY || difficulty==NORMAL) {//if difficulty==EASY or difficulty==NORMAL then
				return norm;//return norm
			} else {//else
				return hard;//return hard
			}//endif
		}//endfunction
		//
		//
		//
		private void balance_info() {//function balance_info takes nothing returns nothing
			food_factor[0] = balance_factor( 0.40, 0.50 );//set food_factor[0] = balance_factor( 0.40, 0.50 )
			food_factor[1] = balance_factor( 0.45, 0.55 );//set food_factor[1] = balance_factor( 0.45, 0.55 )
			food_factor[2] = balance_factor( 0.50, 0.60 );//set food_factor[2] = balance_factor( 0.50, 0.60 )
			food_factor[3] = balance_factor( 0.50, 0.60 );//set food_factor[3] = balance_factor( 0.50, 0.60 )
			food_factor[4] = balance_factor( 0.50, 0.60 );//set food_factor[4] = balance_factor( 0.50, 0.60 )
			dragon_factor = balance_factor( 1.00, 1.50 );//set dragon_factor  = balance_factor( 1.00, 1.50 )
			//
			//
			Illidan0[0] = wave_time( M1, M1 );//set Illidan0[0] = wave_time( M1, M1 )
			Illidan0[1] = wave_time( M1, M1 );//set Illidan0[1] = wave_time( M1, M1 )
			Illidan0[2] = wave_time( M1, M1 );//set Illidan0[2] = wave_time( M1, M1 )
			Illidan0[3] = wave_time( M1, M1 );//set Illidan0[3] = wave_time( M1, M1 )
			Illidan0[4] = wave_time( M1, M1 );//set Illidan0[4] = wave_time( M1, M1 )
			//
			//
			Illidan1[0] = wave_time( M3, M3 );//set Illidan1[0] = wave_time( M3, M3 )
			Illidan1[1] = wave_time( M3, M3 );//set Illidan1[1] = wave_time( M3, M3 )
			Illidan1[2] = wave_time( M2, M2 );//set Illidan1[2] = wave_time( M2, M2 )
			Illidan1[3] = wave_time( M2, M2 );//set Illidan1[3] = wave_time( M2, M2 )
			Illidan2[0] = wave_time( M4, M4 );//set Illidan2[0] = wave_time( M4, M4 )
			Illidan2[1] = wave_time( M4, M4 );//set Illidan2[1] = wave_time( M4, M4 )
			Illidan2[2] = wave_time( M3, M2 );//set Illidan2[2] = wave_time( M3, M2 )
			Illidan2[3] = NOT_POSSIBLE;//set Illidan2[3] = NOT_POSSIBLE
			//
			//
			Illidan3[0] = wave_time( M5, M5 );//set Illidan3[0] = wave_time( M5, M5 )
			Illidan3[1] = wave_time( M5, M5 );//set Illidan3[1] = wave_time( M5, M5 )
			Illidan3[2] = NOT_POSSIBLE;//set Illidan3[2] = NOT_POSSIBLE
			Illidan3[3] = NOT_POSSIBLE;//set Illidan3[3] = NOT_POSSIBLE
			//
			//
			//
			set_attack_group(0, 3, 0, 0, U08x02Ai.BUCKET_COUATL);//call set_attack_group(  0,   3,   0,   0, BUCKET_COUATL      )
			//
			set_attack_group(0, 3, 1, 1, U08x02Ai.BUCKET_SNAP_DRAGON);//call set_attack_group(  0,   3,   1,   1, BUCKET_SNAP_DRAGON )
			set_attack_group(0, 1, 2, 2, U08x02Ai.BUCKET_REAVER);//call set_attack_group(  0,   1,   2,   2, BUCKET_REAVER      )
			set_attack_group(2, 3, 1, 1, U08x02Ai.BUCKET_MYRMIDON);//call set_attack_group(  2,   3,   1,   1, BUCKET_MYRMIDON    )
			set_attack_group(2, 3, 0, 1, U08x02Ai.BUCKET_ROYAL);//call set_attack_group(  2,   3,   0,   1, BUCKET_ROYAL       )
			set_attack_group(0, 3, 1, 1, U08x02Ai.BUCKET_SIREN);//call set_attack_group(  0,   3,   1,   1, BUCKET_SIREN       )
			set_attack_group(0, 3, 1, 1, U08x02Ai.BUCKET_SNAP_DRAGON);//call set_attack_group(  0,   3,   1,   1, BUCKET_SNAP_DRAGON )
			set_attack_group(0, 1, 2, 2, U08x02Ai.BUCKET_REAVER);//call set_attack_group(  0,   1,   2,   2, BUCKET_REAVER      )
			set_attack_group(2, 3, 1, 1, U08x02Ai.BUCKET_MYRMIDON);//call set_attack_group(  2,   3,   1,   1, BUCKET_MYRMIDON    )
			set_attack_group(3, 3, 1, 0, U08x02Ai.BUCKET_ROYAL);//call set_attack_group(  3,   3,   1,   0, BUCKET_ROYAL       )
			set_attack_group(0, 3, 2, 2, U08x02Ai.BUCKET_SNAP_DRAGON);//call set_attack_group(  0,   3,   2,   2, BUCKET_SNAP_DRAGON )
			set_attack_group(0, 3, 2, 2, U08x02Ai.BUCKET_SIREN);//call set_attack_group(  0,   3,   2,   2, BUCKET_SIREN       )
			set_attack_group(0, 3, 2, 2, U08x02Ai.BUCKET_TURTLE);//call set_attack_group(  0,   3,   2,   2, BUCKET_TURTLE      )
			set_attack_group(0, 3, 2, 2, U08x02Ai.BUCKET_MYRMIDON);//call set_attack_group(  0,   3,   2,   2, BUCKET_MYRMIDON    )
			set_attack_group(0, 3, 3, 3, U08x02Ai.BUCKET_SNAP_DRAGON);//call set_attack_group(  0,   3,   3,   3, BUCKET_SNAP_DRAGON )
			//
			set_attack_group(0, 3, 99, 99, U08x02Ai.BUCKET_MYRMIDON);//call set_attack_group(  0,   3,  99,  99, BUCKET_MYRMIDON    )
		}//endfunction
		//
		//
		//
		private void unit_info() {//function unit_info takes nothing returns nothing
			bucket_unitid[BUCKET_COUATL      ] = NAGA_COUATL2;//set bucket_unitid[ BUCKET_COUATL      ] = NAGA_COUATL2
			bucket_unitid[BUCKET_SNAP_DRAGON ] = NAGA_SNAP_DRAGON2;//set bucket_unitid[ BUCKET_SNAP_DRAGON ] = NAGA_SNAP_DRAGON2
			bucket_unitid[BUCKET_REAVER      ] = NAGA_REAVER2;//set bucket_unitid[ BUCKET_REAVER      ] = NAGA_REAVER2
			bucket_unitid[BUCKET_MYRMIDON    ] = NAGA_MYRMIDON2;//set bucket_unitid[ BUCKET_MYRMIDON    ] = NAGA_MYRMIDON2
			bucket_unitid[BUCKET_SIREN       ] = NAGA_SIREN2;//set bucket_unitid[ BUCKET_SIREN       ] = NAGA_SIREN2
			bucket_unitid[BUCKET_TURTLE      ] = NAGA_TURTLE2;//set bucket_unitid[ BUCKET_TURTLE      ] = NAGA_TURTLE2
			bucket_unitid[BUCKET_ROYAL       ] = NAGA_ROYAL2;//set bucket_unitid[ BUCKET_ROYAL       ] = NAGA_ROYAL2
		}//endfunction
		//
		//
		//
		private int slots_controlled(int who) {//function slots_controlled takes integer who returns integer
			int sum = 0;//local integer sum = 0
			int i = 1;//local integer i = 1
			while (true) {//loop
				if (slot_control[i] == who) {//if slot_control[i] == who then
					sum = sum + 1;//set sum = sum + 1
				}//endif
				i = i + 1;//set i = i + 1
				if (i > 4) { break; }//exitwhen i > 4
			}//endloop
			return sum;//return sum
		}//endfunction
		//
		//
		//
		private void message_loop() {//function message_loop takes nothing returns nothing
			int cmd;//local integer cmd
			int data;//local integer data
			int i = 1;//local integer i = 1
			while (true) {//loop
				town_x[i] = 0;//set town_x[i] = 0
				town_y[i] = 0;//set town_y[i] = 0
				peons_lost[i] = false;//set peons_lost[i]   = false
				slot_owned[i] = true;//set slot_owned[i]   = true
				slot_control[i] = NO_CONTROL;//set slot_control[i] = NO_CONTROL
				i = i + 1;//set i = i + 1
				if (i > 4) { break; }//exitwhen i > 4
			}//endloop
			while (true) {//loop
				while (true) {//loop
					if (CommandsWaiting() > 0) { break; }//exitwhen CommandsWaiting() > 0
					Sleep(0.1);//call Sleep(0.1)
				}//endloop
				cmd = GetLastCommand();//set cmd  = GetLastCommand()
				data = GetLastData();//set data = GetLastData()
				PopLastCommand();//call PopLastCommand()
				startup = startup + 1;//set startup = startup + 1
				TraceIII("COMMAND[%d] (%d, %d)\n", U08x02Ai.startup, cmd, data);//call TraceIII("COMMAND[%d] (%d,%d)\n",startup,cmd,data)
				//
				if (cmd == SET_TOWN_1_X) {//if cmd == SET_TOWN_1_X then
					//
					town_x[1] = data;//set town_x[1] = data
					//
				} else if (cmd == SET_TOWN_1_Y) {//elseif cmd == SET_TOWN_1_Y then
					//
					town_y[1] = data;//set town_y[1] = data
					//
				} else if (cmd == SET_TOWN_2_X) {//elseif cmd == SET_TOWN_2_X then
					//
					town_x[2] = data;//set town_x[2] = data
					//
				} else if (cmd == SET_TOWN_2_Y) {//elseif cmd == SET_TOWN_2_Y then
					//
					town_y[2] = data;//set town_y[2] = data
					//
				} else if (cmd == SET_TOWN_3_X) {//elseif cmd == SET_TOWN_3_X then
					//
					town_x[3] = data;//set town_x[3] = data
					//
				} else if (cmd == SET_TOWN_3_Y) {//elseif cmd == SET_TOWN_3_Y then
					//
					town_y[3] = data;//set town_y[3] = data
					//
				} else if (cmd == SET_TOWN_4_X) {//elseif cmd == SET_TOWN_4_X then
					//
					town_x[4] = data;//set town_x[4] = data
					//
				} else if (cmd == SET_TOWN_4_Y) {//elseif cmd == SET_TOWN_4_Y then
					//
					town_y[4] = data;//set town_y[4] = data
					//
				} else if (cmd == PEONS_LOST) {//elseif cmd == PEONS_LOST then
					//
					TraceI("PEONS_LOST %d\n", data);//call TraceI("PEONS_LOST %d\n",data)
					peons_lost[data] = true;//set peons_lost[data]   = true
					//
				} else if (cmd == SLOT_LOST) {//elseif cmd == SLOT_LOST then
					//
					TraceI("SLOT_LOST %d\n", data);//call TraceI("SLOT_LOST %d\n",data)
					slot_owned[data] = false;//set slot_owned[data] = false
					if (next_slot == -1) {//if next_slot == -1 then
						next_slot = data;//set next_slot = data
					}//endif
					//
				} else if (cmd == SLOT_GAINED) {//elseif cmd == SLOT_GAINED then
					//
					TraceI("SLOT_GAINED %d\n", data);//call TraceI("SLOT_GAINED %d\n",data)
					slot_owned[data] = true;//set slot_owned[data] = true
					peons_lost[data] = false;//set peons_lost[data] = false
					stepped_on = false;//set stepped_on       = false
					if (startup > STARTUP_CMDS) {//if startup > STARTUP_CMDS then
						slot_control[data] = ILLIDAN_CONTROL;//set slot_control[data] = ILLIDAN_CONTROL
					}//endif
					//
				} else if (cmd == SLOT_STEPPED_ON) {//elseif cmd == SLOT_STEPPED_ON then
					//
					Trace("SLOT_STEPPED_ON\n");//call Trace("SLOT_STEPPED_ON\n")
					stepped_on = true;//set stepped_on = true
				}//endif
				//
				//
				if ((cmd==PEONS_LOST || cmd==SLOT_LOST) && (startup > STARTUP_CMDS)) {//if (cmd==PEONS_LOST or cmd==SLOT_LOST) and (startup > STARTUP_CMDS) then
					slot_control[data] = ARTHAS_CONTROL;//set slot_control[data] = ARTHAS_CONTROL
					if (slots_controlled(ARTHAS_CONTROL) >= 2) {//if slots_controlled(ARTHAS_CONTROL) >= 2 then
						Trace("ATTACK NOW\n");//call Trace("ATTACK NOW\n")
						sleep_seconds = 1;//set sleep_seconds = 1
					}//endif
				}//endif
				TraceI("Arthas has %d slots\n", slots_controlled(ARTHAS_CONTROL));//call TraceI("Arthas has %d slots\n",slots_controlled(ARTHAS_CONTROL))
				TraceI("Illidan has %d slots\n", slots_controlled(ILLIDAN_CONTROL));//call TraceI("Illidan has %d slots\n",slots_controlled(ILLIDAN_CONTROL))
			}//endloop
		}//endfunction
		//
		//
		//
		private void get_start_commands() {//function get_start_commands takes nothing returns nothing
			while (true) {//loop
				if (startup >= STARTUP_CMDS) { break; }//exitwhen startup >= STARTUP_CMDS
				Sleep(1);//call Sleep(1)
			}//endloop
			Trace("all startup commands received\n");//call Trace("all startup commands received\n")
		}//endfunction
		//
		//
		//
		private void pick_next_slot() {//function pick_next_slot takes nothing returns nothing
			int count = 0;//local integer count = 0
			int[] needed;//local integer array needed
			int i;//local integer i
			int debug1;//local integer debug1
			i = 1;//set i = 1
			while (true) {//loop
				if (slot_owned[i]) {//if slot_owned[i] then
					debug1 = 10;//set debug1 = 10
				} else {//else
					debug1 = 0;//set debug1 = 0
				}//endif
				if (peons_lost[i]) {//if peons_lost[i] then
					debug1 = debug1 + 1;//set debug1 = debug1 + 1
				}//endif
				TraceIII("slot[%d] owned/lost=%02d control=%d\n", i, debug1, slot_control[i]);//call TraceIII("slot[%d] owned/lost=%02d control=%d\n",i,debug1,slot_control[i])
				i = i + 1;//set i = i + 1
				if (i > 4) { break; }//exitwhen i > 4
			}//endloop
			//
			//
			i = 1;//set i = 1
			while (true) {//loop
				if (slot_owned[i] && peons_lost[i]) {//if slot_owned[i] and peons_lost[i] then
					count = count + 1;//set count = count + 1
					needed[count] = i;//set needed[count] = i
				}//endif
				i = i + 1;//set i = i + 1
				if (i > 4) { break; }//exitwhen i > 4
			}//endloop
			if (count != 0) {//if count != 0 then
				next_slot = needed[GetRandomInt(1,count)];//set next_slot = needed[GetRandomInt(1,count)]
				action_state = PEONS_LOST;//set action_state = PEONS_LOST
				return;//return
			}//endif
			//
			//
			if (!slot_owned[1]) {//if not slot_owned[1] then
				next_slot = 1;//set next_slot = 1
				action_state = SLOT_LOST;//set action_state = SLOT_LOST
				return;//return
			}//endif
			//
			//
			i = 2;//set i = 2
			while (true) {//loop
				if ((!slot_owned[i]) && (slot_control[i] == NO_CONTROL)) {//if (not slot_owned[i]) and (slot_control[i] == NO_CONTROL) then
					count = count + 1;//set count = count + 1
					needed[count] = i;//set needed[count] = i
				}//endif
				i = i + 1;//set i = i + 1
				if (i > 4) { break; }//exitwhen i > 4
			}//endloop
			if (count != 0) {//if count != 0 then
				next_slot = needed[GetRandomInt(1,count)];//set next_slot = needed[GetRandomInt(1,count)]
				action_state = SLOT_LOST;//set action_state = SLOT_LOST
				return;//return
			}//endif
			//
			//
			i = 2;//set i = 2
			while (true) {//loop
				if (!slot_owned[i]) {//if not slot_owned[i] then
					count = count + 1;//set count = count + 1
					needed[count] = i;//set needed[count] = i
				}//endif
				i = i + 1;//set i = i + 1
				if (i > 4) { break; }//exitwhen i > 4
			}//endloop
			if (count == 0) {//if count == 0 then
				SleepForever();//call SleepForever()
			}//endif
			next_slot = needed[GetRandomInt(1,count)];//set next_slot = needed[GetRandomInt(1,count)]
			action_state = SLOT_LOST;//set action_state = SLOT_LOST
		}//endfunction
		//
		//
		//
		private int Illidan_count(bool onlyDone) {//function Illidan_count takes boolean onlyDone returns integer
			if (GetUnitCountDone(ILLIDAN) > 0 || GetUnitCountDone(ILLIDAN_DEMON) > 0) {//if GetUnitCountDone(ILLIDAN) > 0 or GetUnitCountDone(ILLIDAN_DEMON) > 0 then
				return 1;//return 1
			}//endif
			if (onlyDone) {//if onlyDone then
				return 0;//return 0
			}//endif
			if (GetUnitCount(ILLIDAN) > 0 || GetUnitCount(ILLIDAN_DEMON) > 0) {//if GetUnitCount(ILLIDAN) > 0 or GetUnitCount(ILLIDAN_DEMON) > 0 then
				return 1;//return 1
			}//endif
			return 0;//return 0
		}//endfunction
		//
		//
		//
		private void attack_move(int dx, int dy) {//function attack_move takes integer dx, integer dy returns nothing
			if (CaptainIsEmpty() || Illidan_count(true) < 1) {//if CaptainIsEmpty() or Illidan_count(true) < 1 then
				if (CaptainIsEmpty()) {//if CaptainIsEmpty() then
					TraceI("SKIP attack_move [empty=1, Illidan=%d]\n", Illidan_count(true));//call TraceI("SKIP attack_move [empty=1, Illidan=%d]\n",Illidan_count(true))
				} else {//else
					TraceI("SKIP attack_move [empty=0, Illidan=%d]\n", Illidan_count(true));//call TraceI("SKIP attack_move [empty=0, Illidan=%d]\n",Illidan_count(true))
				}//endif
				return;//return
			}//endif
			TraceII("attack_move( %d, %d )\n", dx, dy);//call TraceII("attack_move( %d, %d )\n",dx,dy)
			AttackMoveXY(town_x[next_slot]+dx, town_y[next_slot]+dy);//call AttackMoveXY( town_x[next_slot]+dx, town_y[next_slot]+dy )
			Sleep(5);//call Sleep(5)
			SleepUntilAtGoal();//call SleepUntilAtGoal()
			SleepInCombat();//call SleepInCombat()
			RemoveInjuries();//call RemoveInjuries()
		}//endfunction
		//
		//
		//
		private void set_attack_rate() {//function set_attack_rate takes nothing returns nothing
			int Islots = slots_controlled(ILLIDAN_CONTROL);//local integer Islots = slots_controlled(ILLIDAN_CONTROL)
			int Aslots = slots_controlled(ARTHAS_CONTROL);//local integer Aslots = slots_controlled(ARTHAS_CONTROL)
			if (Aslots >= 0 && Aslots <= 3) {//if Aslots >= 0 and Aslots <= 3 then
				if (Islots == 0) {//if Islots == 0 then
					attack_delay = Illidan0[Aslots];//set attack_delay = Illidan0[Aslots]
				} else if (Islots == 1) {//elseif Islots == 1 then
					attack_delay = Illidan1[Aslots];//set attack_delay = Illidan1[Aslots]
				} else if (Islots == 2) {//elseif Islots == 2 then
					attack_delay = Illidan2[Aslots];//set attack_delay = Illidan2[Aslots]
				} else if (Islots == 3) {//elseif Islots == 3 then
					attack_delay = Illidan3[Aslots];//set attack_delay = Illidan3[Aslots]
				} else {//else
					attack_delay = NOT_POSSIBLE;//set attack_delay = NOT_POSSIBLE
				}//endif
			} else {//else
				attack_delay = NOT_POSSIBLE;//set attack_delay = NOT_POSSIBLE
			}//endif
			TraceI("set_attack_rate = %d seconds\n", U08x02Ai.attack_delay);//call TraceI("set_attack_rate = %d seconds\n",attack_delay)
		}//endfunction
		//
		//
		//
		private void Illidan_attack(bool normal_attack) {//function Illidan_attack takes boolean normal_attack returns nothing
			int last_x;//local integer last_x
			int last_y;//local integer last_y
			int dx;//local integer dx
			int dy;//local integer dy
			int i;//local integer i
			if (normal_attack) {//if normal_attack then
				TraceI("Illidan_attack: normal attack (in %d seconds)\n", U08x02Ai.attack_delay);//call TraceI("Illidan_attack: normal attack (in %d seconds)\n",attack_delay)
				sleep_seconds = attack_delay;//set sleep_seconds = attack_delay
			} else {//else
				Trace("Illidan_attack: QUICK attack\n");//call Trace("Illidan_attack: QUICK attack\n")
				sleep_seconds = 1;//set sleep_seconds = 1
			}//endif
			Trace("Illidan_attack: wait for Illidan\n");//call Trace("Illidan_attack: wait for Illidan\n")
			while (true) {//loop
				if (Illidan_count(true) > 0) { break; }//exitwhen Illidan_count(true) > 0
				SuicideSleep(1);//call SuicideSleep(1)
			}//endloop
			Trace("Illidan_attack: Illidan ready to attack, form group\n");//call Trace("Illidan_attack: Illidan ready to attack, form group\n")
			while (true) {//loop
				FormGroup(1, false);//call FormGroup(1,false)
				if (sleep_seconds < 1) { break; }//exitwhen sleep_seconds < 1
				TraceI("Illidan_attack: exit in %d seconds\n", CommonAi.sleep_seconds);//call TraceI("Illidan_attack: exit in %d seconds\n",sleep_seconds)
				SuicideSleep(5);//call SuicideSleep(5)
				if (Illidan_count(true) < 1) {//if Illidan_count(true) < 1 then
					TraceI("Illidan dead, suspend Illidan_attack for %d seconds\n", CommonAi.sleep_seconds);//call TraceI("Illidan dead, suspend Illidan_attack for %d seconds\n",sleep_seconds)
					Sleep(CommonAi.sleep_seconds);//call Sleep(sleep_seconds)
					return;//return
				}//endif
			}//endloop
			if (first_attack) {//if first_attack then
				first_attack = false;//set first_attack = false
			} else {//else
				pick_next_slot();//call pick_next_slot()
				TraceI("Illidan_attack: next_slot = %d\n", U08x02Ai.next_slot);//call TraceI("Illidan_attack: next_slot = %d\n",next_slot)
			}//endif
			last_x = town_x[next_slot];//set last_x = town_x[next_slot]
			last_y = town_y[next_slot];//set last_y = town_y[next_slot]
			SetCaptainHome(CommonAi.ATTACK_CAPTAIN, last_x, last_y);//call SetCaptainHome(ATTACK_CAPTAIN,last_x,last_y)
			attack_move(0, 0);//call attack_move(0,0)
			attack_move(+OFFSET_X, +OFFSET_Y);//call attack_move(+OFFSET_X,+OFFSET_Y)
			attack_move(+OFFSET_X, -OFFSET_Y);//call attack_move(+OFFSET_X,-OFFSET_Y)
			attack_move(-OFFSET_X, -OFFSET_Y);//call attack_move(-OFFSET_X,-OFFSET_Y)
			attack_move(-OFFSET_X, +OFFSET_Y);//call attack_move(-OFFSET_X,+OFFSET_Y)
			attack_move(+OFFSET_X, +OFFSET_Y);//call attack_move(+OFFSET_X,+OFFSET_Y)
			attack_move(0, 0);//call attack_move(0,0)
			if (next_slot == 1) {//if next_slot == 1 then
				dx = 0;//set dx = 0
				dy = +1000;//set dy = +1000
			} else if (next_slot == 2) {//elseif next_slot == 2 then
				dx = +1000;//set dx = +1000
				dy = 0;//set dy = 0
			} else if (next_slot == 3) {//elseif next_slot == 3 then
				dx = 0;//set dx = 0
				dy = -1000;//set dy = -1000
			} else {//else
				dx = -1000;//set dx = -1000
				dy = 0;//set dy = 0
			}//endif
			Trace("prepare for last move\n");//call Trace("prepare for last move\n")
			rebuild_Illidan = false;//set rebuild_Illidan = false
			Sleep(20);//call Sleep(20)
			rebuild_Illidan = true;//set rebuild_Illidan = true
			Trace("wait for Illidan to finish COP\n");//call Trace("wait for Illidan to finish COP\n")
			while (true) {//loop
				if (!stepped_on) { break; }//exitwhen not stepped_on
				Sleep(1);//call Sleep(1)
			}//endloop
		}//endfunction
		//
		//
		//
		private void send_captain_home() {//function send_captain_home takes nothing returns nothing
			SetCaptainHome(CommonAi.ATTACK_CAPTAIN, U08x02Ai.ILLIDAN_TOWN_X, U08x02Ai.ILLIDAN_TOWN_Y);//call SetCaptainHome(ATTACK_CAPTAIN,ILLIDAN_TOWN_X,ILLIDAN_TOWN_Y)
			TeleportCaptain(U08x02Ai.ILLIDAN_TOWN_X, U08x02Ai.ILLIDAN_TOWN_Y);//call TeleportCaptain(ILLIDAN_TOWN_X,ILLIDAN_TOWN_Y)
			ClearCaptainTargets();//call ClearCaptainTargets()
		}//endfunction
		//
		//
		//
		private void let_Illidan_die() {//function let_Illidan_die takes nothing returns nothing
			int timeout = 0;//local integer timeout = 0
			int force_size;//local integer force_size
			int temp;//local integer temp
			Trace("start let_Illidan_die\n");//call Trace("start let_Illidan_die\n")
			while (true) {//loop
				if (Illidan_count(true) > 0) { break; }//exitwhen Illidan_count(true) > 0
				Sleep(1);//call Sleep(1)
			}//endloop
			Trace("let_Illidan_die: revived\n");//call Trace("let_Illidan_die: revived\n")
			while (true) {//loop
				if (Illidan_count(true) < 1) { break; }//exitwhen Illidan_count(true) < 1
				Sleep(1);//call Sleep(1)
			}//endloop
			Trace("let_Illidan_die: Illidan dead, suicide what's left\n");//call Trace("let_Illidan_die: Illidan dead, suicide what's left\n")
			suicide_mode = true;//set suicide_mode = true
			stepped_on = false;//set stepped_on = false
			InitAssaultGroup();//call InitAssaultGroup()
			while (true) {//loop
				if (SuicidePlayer(USER,false)) { break; }//exitwhen SuicidePlayer(USER,false)
				Sleep(1);//call Sleep(1)
			}//endloop
			Trace("let_Illidan_die: target picked, waiting to enter combat\n");//call Trace("let_Illidan_die: target picked, waiting to enter combat\n")
			while (true) {//loop
				if (CaptainIsEmpty() || CaptainInCombat(true)) { break; }//exitwhen CaptainIsEmpty() or CaptainInCombat(true)
				Sleep(1);//call Sleep(1)
				if (timeout - (timeout/5)*5 == 0) {//if timeout - (timeout/5)*5 == 0 then
					TraceI("timeout in %d seconds\n", M1-timeout);//call TraceI("timeout in %d seconds\n",M1-timeout)
				}//endif
				timeout = timeout + 1;//set timeout = timeout + 1
				if (timeout >= M1) { break; }//exitwhen timeout >= M1
			}//endloop
			Trace("let_Illidan_die: waiting to die\n");//call Trace("let_Illidan_die: waiting to die\n")
			force_size = CaptainGroupSize();//set force_size = CaptainGroupSize()
			timeout = 0;//set timeout = 0
			while (true) {//loop
				if (CaptainIsEmpty()) { break; }//exitwhen CaptainIsEmpty()
				Sleep(1);//call Sleep(1)
				if (timeout - (timeout/5)*5 == 0) {//if timeout - (timeout/5)*5 == 0 then
					TraceI("timeout in %d seconds\n", M1-timeout);//call TraceI("timeout in %d seconds\n",M1-timeout)
				}//endif
				temp = CaptainGroupSize();//set temp = CaptainGroupSize()
				if (force_size != temp) {//if force_size != temp then
					force_size = temp;//set force_size = temp
					timeout = 0;//set timeout = 0
				} else {//else
					timeout = timeout + 1;//set timeout = timeout + 1
					if (timeout >= M1) { break; }//exitwhen timeout >= M1
				}//endif
			}//endloop
			Trace("let_Illidan_die: suicide done, changing force size\n");//call Trace("let_Illidan_die: suicide done, changing force size\n")
			send_captain_home();//call send_captain_home()
			suicide_mode = false;//set suicide_mode = false
		}//endfunction
		//
		//
		//
		private void extra_attackers() {//function extra_attackers takes nothing returns nothing
			int COPs = slots_controlled(ARTHAS_CONTROL);//local integer COPs = slots_controlled(ARTHAS_CONTROL)
			float Arthas_factor = food_factor[COPs];//local real Arthas_factor = food_factor[COPs]
			float player_food = GetPlayerState(USER,PLAYER_STATE_RESOURCE_FOOD_USED) * Arthas_factor;//local real player_food = GetPlayerState(USER,PLAYER_STATE_RESOURCE_FOOD_USED) * Arthas_factor
			float Illidan_food = 0;//local real Illidan_food = 0
			int idx;//local integer idx
			int food_each;//local integer food_each
			int count;//local integer count
			int use;//local integer use
			int i;//local integer i
			TraceI("calculating extra attackers versus %d food\n", R2I(player_food));//call TraceI("calculating extra attackers versus %d food\n",R2I(player_food))
			//
			//
			i = 0;//set i = 0
			while (true) {//loop
				bucket_qty[i] = 0;//set bucket_qty[i] = 0
				i = i + 1;//set i = i + 1
				if (i >= BUCKET_END) { break; }//exitwhen i >= BUCKET_END
			}//endloop
			//
			//
			i = 0;//set i = 0
			while (true) {//loop
				if (i >= attack_index) { break; }//exitwhen i >= attack_index
				count = attack_qty[i];//set count     = attack_qty[i]
				idx = attack_bucket[i];//set idx       = attack_bucket[i]
				food_each = GetFoodUsed(bucket_unitid[idx]);//set food_each = GetFoodUsed(bucket_unitid[idx])
				if ((COPs < attack_min_COPs[i]) || (COPs > attack_max_COPs[i])) {//if (COPs < attack_min_COPs[i]) or (COPs > attack_max_COPs[i]) then
					count = 0;//set count = 0
				}//endif
				if (count > 0 && food_each > 0) {//if count > 0 and food_each > 0 then
					use = R2I( (player_food - Illidan_food) / food_each );//set use = R2I( (player_food - Illidan_food) / food_each )
					if (use > count) {//if use > count then
						use = count;//set use = count
					} else if (use < 0) {//elseif use < 0 then
						use = 0;//set use = 0
					}//endif
				} else {//else
					use = count;//set use = count
				}//endif
				TraceII("add %d of entry %d\n", use, i);//call TraceII("add %d of entry %d\n",use,i)
				if (use > 0) {//if use > 0 then
					bucket_qty[idx] = bucket_qty[idx] + use;//set bucket_qty[idx] = bucket_qty[idx] + use
					Illidan_food = Illidan_food + use * food_each;//set Illidan_food = Illidan_food + use * food_each
				}//endif
				if (use != count) { break; }//exitwhen use != count
				i = i + 1;//set i = i + 1
			}//endloop
			//
			//
			i = 0;//set i = 0
			while (true) {//loop
				count = bucket_qty[i];//set count = bucket_qty[i]
				TraceII("use %d of bucket %d\n", count, i);//call TraceII("use %d of bucket %d\n",count,i)
				if (count > 0) {//if count > 0 then
					SetAssaultGroup(count, count, bucket_unitid[i]);//call SetAssaultGroup(count,count,bucket_unitid[i])
				}//endif
				i = i + 1;//set i = i + 1
				if (i >= BUCKET_END) { break; }//exitwhen i >= BUCKET_END
			}//endloop
		}//endfunction
		//
		//
		//
		private void set_Illidan_force() {//function set_Illidan_force takes nothing returns nothing
			InitAssaultGroup();//call InitAssaultGroup()
			Trace("set_Illidan_force: clear force, wait for rebuild_Illidan\n");//call Trace("set_Illidan_force: clear force, wait for rebuild_Illidan\n")
			while (true) {//loop
				if (rebuild_Illidan) { break; }//exitwhen rebuild_Illidan
				Sleep(1);//call Sleep(1)
			}//endloop
			SetAssaultGroup(1, 1, CommonAi.ILLIDAN);//call SetAssaultGroup(1,1,ILLIDAN)
			attack_qty[0] = R2I( GetPlayerUnitTypeCount(USER,FROST_WYRM) * dragon_factor );//set attack_qty[0] = R2I( GetPlayerUnitTypeCount(USER,FROST_WYRM) * dragon_factor )
			TraceI("rebuild_Illidan ok, dragon factor calls for %d couatls\n", attack_qty[0]);//call TraceI("rebuild_Illidan ok, dragon factor calls for %d couatls\n",attack_qty[0])
			extra_attackers();//call extra_attackers()
		}//endfunction
		//
		//
		//
		private void Illidan_force() {//function Illidan_force takes nothing returns nothing
			while (true) {//loop
				Trace("Illidan_force: top of loop\n");//call Trace("Illidan_force: top of loop\n")
				set_Illidan_force();//call set_Illidan_force()
				Trace("Illidan_force: call let_Illidan_die\n");//call Trace("Illidan_force: call let_Illidan_die\n")
				let_Illidan_die();//call let_Illidan_die()
			}//endloop
		}//endfunction
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(CommonAi.NAGA_CORAL, null);//call CampaignAI(NAGA_CORAL,null)
			unit_info();//call unit_info()
			balance_info();//call balance_info()
			SetCaptainHome(CommonAi.DEFENSE_CAPTAIN, U08x02Ai.ILLIDAN_DEF_X, U08x02Ai.ILLIDAN_DEF_Y);//call SetCaptainHome(DEFENSE_CAPTAIN,ILLIDAN_DEF_X,ILLIDAN_DEF_Y)
			DoCampaignFarms(false);//call DoCampaignFarms(false)
			GroupTimedLife(true);//call GroupTimedLife(true)
			SetAmphibious();//call SetAmphibious()
			SetReplacements(9, 9, 9);//call SetReplacements(9,9,9)
			SetPeonsRepair(true);//call SetPeonsRepair(true)
			SetFormGroupTimeouts(false);//call SetFormGroupTimeouts(false)
			SetHeroesTakeItems(true);//call SetHeroesTakeItems(true)
			SetWoodPeons(3);//call SetWoodPeons(3)
			SetGoldPeons(0);//call SetGoldPeons(0)
			StartThread(function message_loop);//call StartThread(function message_loop)
			StartThread(function Illidan_force);//call StartThread(function Illidan_force)
			get_start_commands();//call get_start_commands()
			send_captain_home();//call send_captain_home()
			attack_delay = 30;//set attack_delay = 30
			Illidan_attack(U08x02Ai.NORMAL_ATTACK);//call Illidan_attack(NORMAL_ATTACK)
			SetBuildUnitEx(1, 1, 1, CommonAi.NAGA_TEMPLE);//call SetBuildUnitEx( 1,1,1, NAGA_TEMPLE     )
			SetBuildUnitEx(1, 1, 1, CommonAi.NAGA_SLAVE);//call SetBuildUnitEx( 1,1,1, NAGA_SLAVE      )
			SetBuildUnitEx(1, 1, 1, CommonAi.NAGA_ALTAR);//call SetBuildUnitEx( 1,1,1, NAGA_ALTAR      )
			SetBuildUnitEx(2, 2, 2, CommonAi.NAGA_SLAVE);//call SetBuildUnitEx( 2,2,2, NAGA_SLAVE      )
			SetBuildUnitEx(1, 1, 1, CommonAi.NAGA_SPAWNING);//call SetBuildUnitEx( 1,1,1, NAGA_SPAWNING   )
			SetBuildUnitEx(3, 3, 3, CommonAi.NAGA_SLAVE);//call SetBuildUnitEx( 3,3,3, NAGA_SLAVE      )
			SetBuildUnitEx(1, 1, 1, CommonAi.NAGA_SHRINE);//call SetBuildUnitEx( 1,1,1, NAGA_SHRINE     )
			SetBuildUpgrEx(1, 1, 1, CommonAi.UPG_SIREN);//call SetBuildUpgrEx( 1,1,1, UPG_SIREN           )
			SetBuildUpgrEx(1, 1, 1, CommonAi.UPG_NAGA_ENSNARE);//call SetBuildUpgrEx( 1,1,1, UPG_NAGA_ENSNARE    )
			SetBuildUpgrEx(1, 1, 1, CommonAi.UPG_NAGA_ABOLISH);//call SetBuildUpgrEx( 1,1,1, UPG_NAGA_ABOLISH    )
			SetBuildUpgrEx(2, 2, 2, CommonAi.UPG_SIREN);//call SetBuildUpgrEx( 2,2,2, UPG_SIREN           )
			//
			//
			CampaignDefenderEx(1, 1, 1, CommonAi.ILLIDAN);//call CampaignDefenderEx( 1,1,1, ILLIDAN             )
			CampaignDefenderEx(1, 1, 1, CommonAi.NAGA_SNAP_DRAGON);//call CampaignDefenderEx( 1,1,1, NAGA_SNAP_DRAGON    )
			CampaignDefenderEx(1, 1, 1, CommonAi.NAGA_SIREN);//call CampaignDefenderEx( 1,1,1, NAGA_SIREN          )
			CampaignDefenderEx(1, 1, 1, CommonAi.NAGA_MYRMIDON);//call CampaignDefenderEx( 1,1,1, NAGA_MYRMIDON       )
			CampaignDefenderEx(1, 1, 1, CommonAi.NAGA_TURTLE);//call CampaignDefenderEx( 1,1,1, NAGA_TURTLE         )
			CampaignDefenderEx(1, 1, 1, U08x02Ai.NAGA_COUATL2);//call CampaignDefenderEx( 1,1,1, NAGA_COUATL2        )
			CampaignDefenderEx(1, 1, 1, CommonAi.NAGA_ROYAL);//call CampaignDefenderEx( 1,1,1, NAGA_ROYAL          )
			while (true) {//loop
				if (suicide_mode) {//if suicide_mode then
					Trace("main loop - suicide mode\n");//call Trace("main loop - suicide mode\n")
					while (true) {//loop
						if (!suicide_mode) { break; }//exitwhen not suicide_mode
						Sleep(1);//call Sleep(1)
					}//endloop
					did_suicide = true;//set did_suicide = true
				} else {//else
					Trace("main loop - normal mode\n");//call Trace("main loop - normal mode\n")
				}//endif
				set_attack_rate();//call set_attack_rate()
				Trace("main loop: call set_Illidan_force\n");//call Trace("main loop: call set_Illidan_force\n")
				set_Illidan_force();//call set_Illidan_force()
				//
				Trace("main loop: call Illidan_attack\n");//call Trace("main loop: call Illidan_attack\n")
				if ((action_state == PEONS_LOST) || did_suicide || timeout_failure) {//if (action_state == PEONS_LOST) or did_suicide or timeout_failure then
					did_suicide = false;//set did_suicide = false
					timeout_failure = false;//set timeout_failure = false
					Illidan_attack(U08x02Ai.PEON_ATTACK);//call Illidan_attack(PEON_ATTACK)
				} else {//else
					Illidan_attack(U08x02Ai.NORMAL_ATTACK);//call Illidan_attack(NORMAL_ATTACK)
				}//endif
			}//endloop
		}//endfunction

	
	}
}

