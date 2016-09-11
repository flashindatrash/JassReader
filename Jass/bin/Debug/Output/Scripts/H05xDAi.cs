using System;
using System.Collections.Generic;

namespace Jass {

	public class H05xDAi {

		//
		//
		//
		public const int SET_SLOT = 1;//constant integer SET_SLOT       = 1
		public const int TURN_ON = 2;//constant integer TURN_ON        = 2
		public const int TURN_OFF = 3;//constant integer TURN_OFF       = 3
		public const int CAPT_X = 4;//constant integer CAPT_X         = 4
		public const int CAPT_Y = 5;//constant integer CAPT_Y         = 5
		public const int FEL_GUARD = 'nfgu';//constant integer FEL_GUARD      = 'nfgu'
		public const int BLOODFIEND = 'nfgb';//constant integer BLOODFIEND     = 'nfgb'
		public const int FEL_BEAST = 'npfl';//constant integer FEL_BEAST      = 'npfl'
		public const int ELDER_VOID = 'nvde';//constant integer ELDER_VOID     = 'nvde'
		public const int GREATER_VOID = 'nvdg';//constant integer GREATER_VOID   = 'nvdg'
		public const int NETHER_DRAKE = 'nndk';//constant integer NETHER_DRAKE   = 'nndk'
		public const int NETHER_HATCH = 'nnht';//constant integer NETHER_HATCH   = 'nnht'
		public const int OVERLORD = 'nfov';//constant integer OVERLORD       = 'nfov'
		public const int SORCEROR = 'ners';//constant integer SORCEROR       = 'ners'
		public const int DIABOLIST = 'nerd';//constant integer DIABOLIST      = 'nerd'
		public const int FEL_RAVAGER = 'npfm';//constant integer FEL_RAVAGER    = 'npfm'
		public const int ERE_WARLOCK = 'nerw';//constant integer ERE_WARLOCK    = 'nerw'
		public const int NETHER_DRAGON = 'nndr';//constant integer NETHER_DRAGON  = 'nndr'
		public const int TORMENTOR = 'ndqv';//constant integer TORMENTOR      = 'ndqv'
		public const int TEMPTRESS = 'ndqt';//constant integer TEMPTRESS      = 'ndqt'
		public const int MAIDEN = 'ndqp';//constant integer MAIDEN         = 'ndqp'
		public const int QUEEN = 'ndqs';//constant integer QUEEN          = 'ndqs'
		public const int ILLIDAN_SLOT = 11;//constant integer ILLIDAN_SLOT   = 11
		public static int slot = 0;//integer slot                    = 0
		public static bool gate_open = false;//boolean gate_open               = false
		public static bool suicide_off = true;//boolean suicide_off             = true
		public static int[] suicide_list;//integer array suicide_list
		public static int next_suicide = 0;//integer next_suicide            = 0
		public static int next_declare = 0;//integer next_declare            = 0
		//
		//
		//
		private void suicide_next() {//function suicide_next takes nothing returns nothing
			int unitid;//local integer unitid
			if (suicide_off) {//if suicide_off then
				if (gate_open) {//if gate_open then
					suicide_off = false;//set suicide_off = false
				} else {//else
					return;//return
				}//endif
			}//endif
			unitid = suicide_list[next_suicide];//set unitid = suicide_list[next_suicide]
			if (unitid == -1) {//if unitid == -1 then
				unitid = suicide_list[0];//set unitid = suicide_list[0]
				next_suicide = 0;//set next_suicide = 0
			}//endif
			SuicideUnitEx(3, unitid, H05xDAi.ILLIDAN_SLOT);//call SuicideUnitEx(3,unitid,ILLIDAN_SLOT)
			next_suicide = next_suicide + 1;//set next_suicide = next_suicide + 1
		}//endfunction
		//
		//
		//
		private void declare_unit(int unitid) {//function declare_unit takes integer unitid returns nothing
			suicide_list[next_declare] = unitid;//set suicide_list[next_declare] = unitid
			next_declare = next_declare + 1;//set next_declare = next_declare + 1
			suicide_list[next_declare] = -1;//set suicide_list[next_declare] = -1
		}//endfunction
		//
		//
		//
		private void command_loop() {//function command_loop takes nothing returns nothing
			int x = -1;//local integer x = -1
			int y = -1;//local integer y = -1
			int cmd;//local integer cmd
			int data;//local integer data
			while (true) {//loop
				while (true) {//loop
					suicide_next();//call suicide_next()
					Sleep(0.1);//call Sleep(0.1)
					if (CommandsWaiting() > 0) { break; }//exitwhen CommandsWaiting() > 0
				}//endloop
				cmd = GetLastCommand();//set cmd  = GetLastCommand()
				data = GetLastData();//set data = GetLastData()
				PopLastCommand();//call PopLastCommand()
				//
				if (cmd == SET_SLOT) {//if cmd == SET_SLOT then
					//
					slot = data;//set slot = data
					//
				} else if (cmd == TURN_ON) {//elseif cmd == TURN_ON then
					//
					gate_open = true;//set gate_open = true
					//
				} else if (cmd == TURN_OFF) {//elseif cmd == TURN_OFF then
					//
					gate_open = false;//set gate_open = false
					//
				} else if (cmd == CAPT_X) {//elseif cmd == CAPT_X then
					//
					x = data;//set x = data
					//
				} else if (cmd == CAPT_Y) {//elseif cmd == CAPT_Y then
					//
					y = data;//set y = data
				}//endif
				//
				if ((cmd == CAPT_X || cmd == CAPT_Y) && (x != -1 && y != -1)) {//if (cmd == CAPT_X or cmd == CAPT_Y) and (x != -1 and y != -1) then
					SetCaptainHome(CommonAi.BOTH_CAPTAINS, x, y);//call SetCaptainHome(BOTH_CAPTAINS,x,y)
				}//endif
			}//endloop
		}//endfunction
		//
		//
		//
		private void send_one(int unitid, int seconds) {//function send_one takes integer unitid, integer seconds returns nothing
			SetProduce(1, unitid, -1);//call SetProduce(1,unitid,-1)
			Sleep(seconds);//call Sleep(seconds)
		}//endfunction
		//
		//
		//
		private void send(int unitid, int seconds) {//function send takes integer unitid, integer seconds returns nothing
			if (gate_open) {//if gate_open then
				send_one(unitid, seconds);//call send_one(unitid,seconds)
			}//endif
		}//endfunction
		//
		//
		//
		private void send_group(int qty, int unitid) {//function send_group takes integer qty, integer unitid returns nothing
			if (gate_open) {//if gate_open then
				while (true) {//loop
					if (qty <= 0) { break; }//exitwhen qty <= 0
					qty = qty - 1;//set qty = qty - 1
					send_one(unitid, 2);//call send_one(unitid,2)
				}//endloop
			}//endif
		}//endfunction
		//
		//
		//
		private void send_sleep(int seconds) {//function send_sleep takes integer seconds returns nothing
			if (gate_open) {//if gate_open then
				Sleep(seconds);//call Sleep(seconds)
			}//endif
		}//endfunction
		//
		//
		//
		//
		//
		//
		private void gate1_normal() {//function gate1_normal takes nothing returns nothing
			send_sleep(15);//call send_sleep(15)
			send_group(4, H05xDAi.FEL_BEAST);//call send_group( 4, FEL_BEAST       )
			send_group(3, CommonAi.FELLHOUND);//call send_group( 3, FELLHOUND       )
			send_sleep(15);//call send_sleep(15)
			send_group(6, H05xDAi.FEL_GUARD);//call send_group( 6, FEL_GUARD       )
			send_group(1, H05xDAi.DIABOLIST);//call send_group( 1, DIABOLIST       )
			send_group(4, H05xDAi.BLOODFIEND);//call send_group( 4, BLOODFIEND      )
			send_sleep(20);//call send_sleep(20)
			send_group(6, H05xDAi.FEL_BEAST);//call send_group( 6, FEL_BEAST       )
			send_group(1, H05xDAi.GREATER_VOID);//call send_group( 1, GREATER_VOID    )
			send_group(4, CommonAi.FELLHOUND);//call send_group( 4, FELLHOUND       )
			send_sleep(20);//call send_sleep(20)
			send_group(5, H05xDAi.FEL_GUARD);//call send_group( 5, FEL_GUARD       )
			send_group(3, H05xDAi.BLOODFIEND);//call send_group( 3, BLOODFIEND      )
			send_group(1, H05xDAi.OVERLORD);//call send_group( 1, OVERLORD        )
			send_group(3, H05xDAi.BLOODFIEND);//call send_group( 3, BLOODFIEND      )
			send_group(1, CommonAi.DOOMGUARD);//call send_group( 1, DOOMGUARD       )
			send_group(4, H05xDAi.FEL_BEAST);//call send_group( 4, FEL_BEAST       )
			send_group(1, H05xDAi.ELDER_VOID);//call send_group( 1, ELDER_VOID      )
			send_group(7, H05xDAi.FEL_BEAST);//call send_group( 7, FEL_BEAST       )
		}//endfunction
		//
		//
		//
		private void gate2_normal() {//function gate2_normal takes nothing returns nothing
			send_sleep(5);//call send_sleep(5)
			send_group(4, H05xDAi.NETHER_HATCH);//call send_group( 4, NETHER_HATCH    )
			send_sleep(20);//call send_sleep(20)
			send_group(6, H05xDAi.FEL_BEAST);//call send_group( 6, FEL_BEAST       )
			send_group(3, CommonAi.FELLHOUND);//call send_group( 3, FELLHOUND       )
			send_sleep(20);//call send_sleep(20)
			send_group(3, H05xDAi.NETHER_HATCH);//call send_group( 3, NETHER_HATCH    )
			send_group(1, H05xDAi.GREATER_VOID);//call send_group( 1, GREATER_VOID    )
			send_group(3, H05xDAi.NETHER_HATCH);//call send_group( 3, NETHER_HATCH    )
			send_group(1, H05xDAi.NETHER_DRAKE);//call send_group( 1, NETHER_DRAKE    )
			send_sleep(20);//call send_sleep(20)
			send_group(5, H05xDAi.FEL_BEAST);//call send_group( 5, FEL_BEAST       )
			send_group(3, CommonAi.FELLHOUND);//call send_group( 3, FELLHOUND       )
			send_group(1, H05xDAi.FEL_RAVAGER);//call send_group( 1, FEL_RAVAGER     )
			send_group(1, H05xDAi.DIABOLIST);//call send_group( 1, DIABOLIST       )
			send_sleep(20);//call send_sleep(20)
			send_group(4, H05xDAi.NETHER_HATCH);//call send_group( 4, NETHER_HATCH    )
			send_group(2, H05xDAi.GREATER_VOID);//call send_group( 2, GREATER_VOID    )
			send_group(3, H05xDAi.NETHER_DRAKE);//call send_group( 3, NETHER_DRAKE    )
			send_sleep(5);//call send_sleep(5)
			send_group(1, CommonAi.INFERNAL);//call send_group( 1, INFERNAL        )
			send_group(1, H05xDAi.ELDER_VOID);//call send_group( 1, ELDER_VOID      )
			send_group(1, CommonAi.INFERNAL);//call send_group( 1, INFERNAL        )
		}//endfunction
		//
		//
		//
		private void gate3_normal() {//function gate3_normal takes nothing returns nothing
			send_sleep(5);//call send_sleep(5)
			send_group(6, H05xDAi.TORMENTOR);//call send_group( 6, TORMENTOR       )
			send_group(1, H05xDAi.TEMPTRESS);//call send_group( 1, TEMPTRESS       )
			send_sleep(20);//call send_sleep(20)
			send_group(5, H05xDAi.BLOODFIEND);//call send_group( 5, BLOODFIEND      )
			send_group(1, H05xDAi.OVERLORD);//call send_group( 1, OVERLORD        )
			send_group(1, H05xDAi.DIABOLIST);//call send_group( 1, DIABOLIST       )
			send_sleep(20);//call send_sleep(20)
			send_group(5, H05xDAi.TORMENTOR);//call send_group( 5, TORMENTOR       )
			send_group(2, H05xDAi.TEMPTRESS);//call send_group( 2, TEMPTRESS       )
			send_group(1, H05xDAi.MAIDEN);//call send_group( 1, MAIDEN          )
			send_group(5, H05xDAi.TORMENTOR);//call send_group( 5, TORMENTOR       )
			send_group(1, H05xDAi.QUEEN);//call send_group( 1, QUEEN           )
			send_sleep(20);//call send_sleep(20)
			send_group(4, H05xDAi.BLOODFIEND);//call send_group( 4, BLOODFIEND      )
			send_group(2, H05xDAi.OVERLORD);//call send_group( 2, OVERLORD        )
			send_group(1, CommonAi.DOOMGUARD);//call send_group( 1, DOOMGUARD       )
			send_group(5, H05xDAi.BLOODFIEND);//call send_group( 5, BLOODFIEND      )
			send_sleep(10);//call send_sleep(10)
			send_group(1, CommonAi.DOOMGUARD);//call send_group( 1, DOOMGUARD       )
			send_group(1, H05xDAi.ERE_WARLOCK);//call send_group( 1, ERE_WARLOCK     )
			send_group(1, H05xDAi.QUEEN);//call send_group( 1, QUEEN           )
			send_group(8, H05xDAi.TORMENTOR);//call send_group( 8, TORMENTOR       )
		}//endfunction
		//
		//
		//
		private void gate4_normal() {//function gate4_normal takes nothing returns nothing
			send_sleep(5);//call send_sleep(5)
			send_group(2, CommonAi.INFERNAL);//call send_group( 2, INFERNAL        )
			send_sleep(5);//call send_sleep(5)
			send_group(1, CommonAi.DOOMGUARD);//call send_group( 1, DOOMGUARD       )
			send_sleep(15);//call send_sleep(15)
			send_group(2, H05xDAi.FEL_BEAST);//call send_group( 2, FEL_BEAST       )
			send_group(4, CommonAi.FELLHOUND);//call send_group( 4, FELLHOUND       )
			send_group(1, H05xDAi.FEL_RAVAGER);//call send_group( 1, FEL_RAVAGER     )
			send_group(1, H05xDAi.QUEEN);//call send_group( 1, QUEEN           )
			send_group(1, H05xDAi.MAIDEN);//call send_group( 1, MAIDEN          )
			send_sleep(20);//call send_sleep(20)
			send_group(5, H05xDAi.NETHER_DRAKE);//call send_group( 5, NETHER_DRAKE    )
			send_group(1, H05xDAi.NETHER_DRAGON);//call send_group( 1, NETHER_DRAGON   )
			send_group(1, CommonAi.DOOMGUARD);//call send_group( 1, DOOMGUARD       )
			send_group(1, CommonAi.INFERNAL);//call send_group( 1, INFERNAL        )
			send_sleep(20);//call send_sleep(20)
			send_group(1, CommonAi.INFERNAL);//call send_group( 1, INFERNAL        )
			send_sleep(10);//call send_sleep(10)
			send_group(1, H05xDAi.QUEEN);//call send_group( 1, QUEEN           )
			send_sleep(10);//call send_sleep(10)
			send_group(1, CommonAi.DOOMGUARD);//call send_group( 1, DOOMGUARD       )
			send_sleep(15);//call send_sleep(15)
			send_group(5, H05xDAi.FEL_BEAST);//call send_group( 5, FEL_BEAST       )
			send_group(2, CommonAi.FELLHOUND);//call send_group( 2, FELLHOUND       )
			send_group(2, H05xDAi.FEL_RAVAGER);//call send_group( 2, FEL_RAVAGER     )
			send_group(1, H05xDAi.TEMPTRESS);//call send_group( 1, TEMPTRESS       )
			send_group(1, H05xDAi.MAIDEN);//call send_group( 1, MAIDEN          )
			send_group(5, H05xDAi.FEL_BEAST);//call send_group( 5, FEL_BEAST       )
		}//endfunction
		//
		//
		//
		//
		//
		//
		private void gate1_hard() {//function gate1_hard takes nothing returns nothing
			send_sleep(10);//call send_sleep(10)
			send_group(8, H05xDAi.FEL_BEAST);//call send_group( 8, FEL_BEAST       )
			send_group(2, CommonAi.FELLHOUND);//call send_group( 2, FELLHOUND       )
			send_group(2, H05xDAi.GREATER_VOID);//call send_group( 2, GREATER_VOID    )
			send_sleep(10);//call send_sleep(10)
			send_group(6, H05xDAi.FEL_GUARD);//call send_group( 6, FEL_GUARD       )
			send_group(6, H05xDAi.BLOODFIEND);//call send_group( 6, BLOODFIEND      )
			send_group(2, CommonAi.DOOMGUARD);//call send_group( 2, DOOMGUARD       )
			send_sleep(10);//call send_sleep(10)
			send_group(8, H05xDAi.FEL_BEAST);//call send_group( 8, FEL_BEAST       )
			send_group(4, H05xDAi.FEL_RAVAGER);//call send_group( 4, FEL_RAVAGER     )
			send_group(2, H05xDAi.GREATER_VOID);//call send_group( 2, GREATER_VOID    )
			send_group(2, H05xDAi.ELDER_VOID);//call send_group( 2, ELDER_VOID      )
			send_sleep(10);//call send_sleep(10)
			send_group(2, CommonAi.DOOMGUARD);//call send_group( 2, DOOMGUARD       )
			send_group(5, H05xDAi.BLOODFIEND);//call send_group( 5, BLOODFIEND      )
			send_group(5, H05xDAi.FEL_GUARD);//call send_group( 5, FEL_GUARD       )
			send_group(2, H05xDAi.OVERLORD);//call send_group( 2, OVERLORD        )
			send_group(2, CommonAi.DOOMGUARD);//call send_group( 2, DOOMGUARD       )
			send_group(5, H05xDAi.BLOODFIEND);//call send_group( 5, BLOODFIEND      )
			send_group(1, H05xDAi.OVERLORD);//call send_group( 1, OVERLORD        )
			send_group(2, CommonAi.DOOMGUARD);//call send_group( 2, DOOMGUARD       )
			send_group(3, H05xDAi.FEL_GUARD);//call send_group( 3, FEL_GUARD       )
		}//endfunction
		//
		//
		//
		private void gate2_hard() {//function gate2_hard takes nothing returns nothing
			send_sleep(5);//call send_sleep(5)
			send_group(4, H05xDAi.NETHER_HATCH);//call send_group( 4, NETHER_HATCH    )
			send_group(2, H05xDAi.NETHER_DRAKE);//call send_group( 2, NETHER_DRAKE    )
			send_sleep(5);//call send_sleep(5)
			send_group(4, CommonAi.FELLHOUND);//call send_group( 4, FELLHOUND       )
			send_group(6, H05xDAi.FEL_BEAST);//call send_group( 6, FEL_BEAST       )
			send_group(3, H05xDAi.FEL_RAVAGER);//call send_group( 3, FEL_RAVAGER     )
			send_group(2, H05xDAi.DIABOLIST);//call send_group( 2, DIABOLIST       )
			send_sleep(5);//call send_sleep(5)
			send_group(6, H05xDAi.NETHER_DRAKE);//call send_group( 6, NETHER_DRAKE    )
			send_group(3, H05xDAi.NETHER_HATCH);//call send_group( 3, NETHER_HATCH    )
			send_group(3, H05xDAi.GREATER_VOID);//call send_group( 3, GREATER_VOID    )
			send_group(3, H05xDAi.NETHER_DRAKE);//call send_group( 3, NETHER_DRAKE    )
			send_group(3, H05xDAi.ELDER_VOID);//call send_group( 3, ELDER_VOID      )
			send_sleep(5);//call send_sleep(5)
			send_group(5, CommonAi.FELLHOUND);//call send_group( 5, FELLHOUND       )
			send_group(5, H05xDAi.FEL_BEAST);//call send_group( 5, FEL_BEAST       )
			send_group(2, H05xDAi.DIABOLIST);//call send_group( 2, DIABOLIST       )
			send_group(2, H05xDAi.FEL_RAVAGER);//call send_group( 2, FEL_RAVAGER     )
			send_group(3, H05xDAi.ERE_WARLOCK);//call send_group( 3, ERE_WARLOCK     )
			send_sleep(5);//call send_sleep(5)
			send_group(4, H05xDAi.ELDER_VOID);//call send_group( 4, ELDER_VOID      )
			send_group(3, CommonAi.INFERNAL);//call send_group( 3, INFERNAL        )
			send_group(3, H05xDAi.NETHER_DRAKE);//call send_group( 3, NETHER_DRAKE    )
			send_sleep(5);//call send_sleep(5)
			send_group(1, H05xDAi.DIABOLIST);//call send_group( 1, DIABOLIST       )
			send_group(2, H05xDAi.FEL_RAVAGER);//call send_group( 2, FEL_RAVAGER     )
			send_group(1, H05xDAi.ERE_WARLOCK);//call send_group( 1, ERE_WARLOCK     )
			send_group(5, CommonAi.FELLHOUND);//call send_group( 5, FELLHOUND       )
		}//endfunction
		//
		//
		//
		private void gate3_hard() {//function gate3_hard takes nothing returns nothing
			send_sleep(5);//call send_sleep(5)
			send_group(6, H05xDAi.TORMENTOR);//call send_group( 6, TORMENTOR       )
			send_group(4, H05xDAi.TEMPTRESS);//call send_group( 4, TEMPTRESS       )
			send_group(3, H05xDAi.MAIDEN);//call send_group( 3, MAIDEN          )
			send_group(2, H05xDAi.QUEEN);//call send_group( 2, QUEEN           )
			send_sleep(5);//call send_sleep(5)
			send_group(3, H05xDAi.BLOODFIEND);//call send_group( 3, BLOODFIEND      )
			send_group(2, H05xDAi.OVERLORD);//call send_group( 2, OVERLORD        )
			send_group(1, H05xDAi.DIABOLIST);//call send_group( 1, DIABOLIST       )
			send_group(3, H05xDAi.BLOODFIEND);//call send_group( 3, BLOODFIEND      )
			send_group(3, H05xDAi.OVERLORD);//call send_group( 3, OVERLORD        )
			send_group(2, H05xDAi.ERE_WARLOCK);//call send_group( 2, ERE_WARLOCK     )
			send_group(3, H05xDAi.BLOODFIEND);//call send_group( 3, BLOODFIEND      )
			send_group(3, H05xDAi.OVERLORD);//call send_group( 3, OVERLORD        )
			send_group(2, CommonAi.DOOMGUARD);//call send_group( 2, DOOMGUARD       )
			send_sleep(5);//call send_sleep(5)
			send_group(2, H05xDAi.QUEEN);//call send_group( 2, QUEEN           )
			send_group(6, H05xDAi.TORMENTOR);//call send_group( 6, TORMENTOR       )
			send_group(4, H05xDAi.TEMPTRESS);//call send_group( 4, TEMPTRESS       )
			send_group(3, H05xDAi.MAIDEN);//call send_group( 3, MAIDEN          )
			send_group(3, H05xDAi.QUEEN);//call send_group( 3, QUEEN           )
			send_sleep(5);//call send_sleep(5)
			send_group(4, H05xDAi.BLOODFIEND);//call send_group( 4, BLOODFIEND      )
			send_group(3, CommonAi.DOOMGUARD);//call send_group( 3, DOOMGUARD       )
			send_group(2, H05xDAi.ERE_WARLOCK);//call send_group( 2, ERE_WARLOCK     )
			send_group(3, H05xDAi.QUEEN);//call send_group( 3, QUEEN           )
			send_group(8, H05xDAi.TORMENTOR);//call send_group( 8, TORMENTOR       )
			send_group(3, H05xDAi.TEMPTRESS);//call send_group( 3, TEMPTRESS       )
		}//endfunction
		//
		//
		//
		private void gate4_hard() {//function gate4_hard takes nothing returns nothing
			send_sleep(2);//call send_sleep(2)
			send_group(4, CommonAi.INFERNAL);//call send_group( 4, INFERNAL        )
			send_sleep(5);//call send_sleep(5)
			send_group(3, CommonAi.DOOMGUARD);//call send_group( 3, DOOMGUARD       )
			send_sleep(5);//call send_sleep(5)
			send_group(2, H05xDAi.FEL_BEAST);//call send_group( 2, FEL_BEAST       )
			send_group(5, CommonAi.FELLHOUND);//call send_group( 5, FELLHOUND       )
			send_group(4, H05xDAi.FEL_RAVAGER);//call send_group( 4, FEL_RAVAGER     )
			send_group(3, H05xDAi.QUEEN);//call send_group( 3, QUEEN           )
			send_group(2, H05xDAi.MAIDEN);//call send_group( 2, MAIDEN          )
			send_sleep(5);//call send_sleep(5)
			send_group(5, H05xDAi.NETHER_DRAKE);//call send_group( 5, NETHER_DRAKE    )
			send_group(3, H05xDAi.NETHER_DRAGON);//call send_group( 3, NETHER_DRAGON   )
			send_group(2, CommonAi.DOOMGUARD);//call send_group( 2, DOOMGUARD       )
			send_group(2, CommonAi.INFERNAL);//call send_group( 2, INFERNAL        )
			send_group(2, H05xDAi.NETHER_DRAKE);//call send_group( 2, NETHER_DRAKE    )
			send_sleep(8);//call send_sleep(8)
			send_group(2, H05xDAi.FEL_BEAST);//call send_group( 2, FEL_BEAST       )
			send_group(4, CommonAi.FELLHOUND);//call send_group( 4, FELLHOUND       )
			send_group(4, H05xDAi.FEL_RAVAGER);//call send_group( 4, FEL_RAVAGER     )
			send_group(2, H05xDAi.TEMPTRESS);//call send_group( 2, TEMPTRESS       )
			send_group(3, H05xDAi.QUEEN);//call send_group( 3, QUEEN           )
			send_group(3, H05xDAi.FEL_RAVAGER);//call send_group( 3, FEL_RAVAGER     )
			send_sleep(5);//call send_sleep(5)
			send_group(4, CommonAi.INFERNAL);//call send_group( 4, INFERNAL        )
			send_group(3, CommonAi.DOOMGUARD);//call send_group( 3, DOOMGUARD       )
			send_group(5, CommonAi.INFERNAL);//call send_group( 5, INFERNAL        )
			send_group(3, H05xDAi.QUEEN);//call send_group( 3, QUEEN           )
			send_group(5, CommonAi.INFERNAL);//call send_group( 5, INFERNAL        )
		}//endfunction
		//
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(CommonAi.BURROW, null);//call CampaignAI(BURROW,null)
			SetReplacements(0, 0, 0);//call SetReplacements(0,0,0)
			declare_unit(H05xDAi.FEL_GUARD);//call declare_unit( FEL_GUARD        )
			declare_unit(H05xDAi.BLOODFIEND);//call declare_unit( BLOODFIEND       )
			declare_unit(H05xDAi.FEL_BEAST);//call declare_unit( FEL_BEAST        )
			declare_unit(H05xDAi.ELDER_VOID);//call declare_unit( ELDER_VOID       )
			declare_unit(H05xDAi.GREATER_VOID);//call declare_unit( GREATER_VOID     )
			declare_unit(H05xDAi.NETHER_DRAKE);//call declare_unit( NETHER_DRAKE     )
			declare_unit(H05xDAi.NETHER_HATCH);//call declare_unit( NETHER_HATCH     )
			declare_unit(H05xDAi.OVERLORD);//call declare_unit( OVERLORD         )
			declare_unit(H05xDAi.SORCEROR);//call declare_unit( SORCEROR         )
			declare_unit(H05xDAi.DIABOLIST);//call declare_unit( DIABOLIST        )
			declare_unit(H05xDAi.FEL_RAVAGER);//call declare_unit( FEL_RAVAGER      )
			declare_unit(H05xDAi.ERE_WARLOCK);//call declare_unit( ERE_WARLOCK      )
			declare_unit(H05xDAi.NETHER_DRAGON);//call declare_unit( NETHER_DRAGON    )
			declare_unit(H05xDAi.TORMENTOR);//call declare_unit( TORMENTOR        )
			declare_unit(H05xDAi.TEMPTRESS);//call declare_unit( TEMPTRESS        )
			declare_unit(H05xDAi.MAIDEN);//call declare_unit( MAIDEN           )
			declare_unit(H05xDAi.QUEEN);//call declare_unit( QUEEN            )
			declare_unit(CommonAi.INFERNAL);//call declare_unit( INFERNAL         )
			declare_unit(CommonAi.DOOMGUARD);//call declare_unit( DOOMGUARD        )
			declare_unit(CommonAi.FELLHOUND);//call declare_unit( FELLHOUND        )
			StartThread(function command_loop);//call StartThread(function command_loop)
			while (true) {//loop
				while (true) {//loop
					if (gate_open) { break; }//exitwhen gate_open
					Sleep(0.5);//call Sleep(0.5)
				}//endloop
				if (difficulty == HARD) {//if difficulty == HARD then
					if (slot == 1) {//if slot == 1 then
						gate1_hard();//call gate1_hard()
					} else if (slot == 2) {//elseif slot == 2 then
						gate2_hard();//call gate2_hard()
					} else if (slot == 3) {//elseif slot == 3 then
						gate3_hard();//call gate3_hard()
					} else if (slot == 4) {//elseif slot == 4 then
						gate4_hard();//call gate4_hard()
					}//endif
				} else {//else
					if (slot == 1) {//if slot == 1 then
						gate1_normal();//call gate1_normal()
					} else if (slot == 2) {//elseif slot == 2 then
						gate2_normal();//call gate2_normal()
					} else if (slot == 3) {//elseif slot == 3 then
						gate3_normal();//call gate3_normal()
					} else if (slot == 4) {//elseif slot == 4 then
						gate4_normal();//call gate4_normal()
					}//endif
				}//endif
				while (true) {//loop
					if (!gate_open) { break; }//exitwhen not gate_open
					Sleep(0.5);//call Sleep(0.5)
				}//endloop
			}//endloop
		}//endfunction

	
	}
}

