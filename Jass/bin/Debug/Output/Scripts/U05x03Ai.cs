using System;
using System.Collections.Generic;

namespace Jass {

	public class U05x03Ai {

		//
		//
		//
		public static player user = PlayerEx(4);//player user = PlayerEx(4)
		public static int delay = M5;//integer delay       = M5
		public static int hard_delay = M4;//integer hard_delay  = M4
		public static int fast_delay = M3;//integer fast_delay  = M3
		//
		//
		//
		private void check_base_deaths() {//function check_base_deaths takes nothing returns nothing
			if (difficulty == HARD) {//if difficulty == HARD then
				return;//return
			}//endif
			while (true) {//loop
				if (CommandsWaiting() != 0) { break; }//exitwhen CommandsWaiting() != 0
				Trace("check_base_deaths waiting for signal...\n");//call Trace("check_base_deaths waiting for signal...\n")
				Sleep(10);//call Sleep(10)
			}//endloop
			PopLastCommand();//call PopLastCommand()
			delay = fast_delay;//set delay = fast_delay
		}//endfunction
		//
		//
		//
		private void upgrade_towers() {//function upgrade_towers takes nothing returns nothing
			int count;//local integer count
			while (true) {//loop
				count = TownCountDone(WATCH_TOWER);//set count = TownCountDone(WATCH_TOWER)
				if (count > 0) {//if count > 0 then
					SetProduce(count, CommonAi.GUARD_TOWER, -1);//call SetProduce(count,GUARD_TOWER,-1)
				}//endif
				Sleep(1);//call Sleep(1)
			}//endloop
		}//endfunction
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(CommonAi.HOUSE, null);//call CampaignAI(HOUSE,null)
			SetReplacements(2, 2, 4);//call SetReplacements(2,2,4)
			if (difficulty == HARD) {//if difficulty == HARD then
				delay = hard_delay;//set delay = hard_delay
			}//endif
			SetBuildUnitEx(0, 0, 1, CommonAi.TOWN_HALL);//call SetBuildUnitEx( 0,0,1, TOWN_HALL       )
			SetBuildUnitEx(3, 3, 3, CommonAi.PEASANT);//call SetBuildUnitEx( 3,3,3, PEASANT         )
			SetBuildUnitEx(0, 0, 2, CommonAi.BARRACKS);//call SetBuildUnitEx( 0,0,2, BARRACKS        )
			SetBuildUnitEx(0, 0, 1, CommonAi.LUMBER_MILL);//call SetBuildUnitEx( 0,0,1, LUMBER_MILL     )
			SetBuildUnitEx(0, 0, 1, CommonAi.HUMAN_ALTAR);//call SetBuildUnitEx( 0,0,1, HUMAN_ALTAR     )
			SetBuildUnitEx(0, 0, 1, CommonAi.BLACKSMITH);//call SetBuildUnitEx( 0,0,1, BLACKSMITH      )
			SetBuildUnitEx(7, 7, 7, CommonAi.PEASANT);//call SetBuildUnitEx( 7,7,7, PEASANT         )
			SetBuildUnitEx(0, 0, 1, CommonAi.KEEP);//call SetBuildUnitEx( 0,0,1, KEEP            )
			SetBuildUnitEx(0, 0, 1, CommonAi.WORKSHOP);//call SetBuildUnitEx( 0,0,1, WORKSHOP        )
			SetBuildUnitEx(0, 0, 1, CommonAi.CASTLE);//call SetBuildUnitEx( 0,0,1, CASTLE          )
			WaitForSignal();//call WaitForSignal()
			//
			SuicideOnce(4, 4, 4, CommonAi.FOOTMAN);//call SuicideOnce( 4, 4, 4, FOOTMAN      )
			SuicideOnce(2, 2, 2, CommonAi.KNIGHT);//call SuicideOnce( 2, 2, 2, KNIGHT       )
			SuicideOnce(1, 1, 2, CommonAi.MORTAR);//call SuicideOnce( 1, 1, 2, MORTAR       )
			SuicideOnce(2, 2, 2, CommonAi.RIFLEMAN);//call SuicideOnce( 2, 2, 2, RIFLEMAN     )
			WaitForSignal();//call WaitForSignal()
			//
			CampaignDefenderEx(1, 1, 1, CommonAi.KNIGHT);//call CampaignDefenderEx( 1,1,1, KNIGHT      )
			CampaignDefenderEx(1, 1, 1, CommonAi.RIFLEMAN);//call CampaignDefenderEx( 1,1,1, RIFLEMAN    )
			CampaignDefenderEx(0, 0, 1, CommonAi.COPTER);//call CampaignDefenderEx( 0,0,1, COPTER      )
			StartThread(function upgrade_towers);//call StartThread(function upgrade_towers)
			WaitForSignal();//call WaitForSignal()
			StartThread(function check_base_deaths);//call StartThread(function check_base_deaths)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(4, 4, 6, CommonAi.FOOTMAN);//call CampaignAttackerEx( 4,4,6, FOOTMAN     )
			CampaignAttackerEx(2, 2, 4, CommonAi.RIFLEMAN);//call CampaignAttackerEx( 2,2,4, RIFLEMAN    )
			SuicideOnPlayerEx(CommonAi.M1, CommonAi.M1, CommonAi.M1, U08_tealAi.user);//call SuicideOnPlayerEx(M1,M1,M1,user)
			SetBuildUpgrEx(1, 1, 1, CommonAi.UPG_MELEE);//call SetBuildUpgrEx( 1,1,1, UPG_MELEE       )
			SetBuildUpgrEx(1, 1, 1, CommonAi.UPG_RANGED);//call SetBuildUpgrEx( 1,1,1, UPG_RANGED      )
			SetBuildUpgrEx(1, 1, 1, CommonAi.UPG_MASONRY);//call SetBuildUpgrEx( 1,1,1, UPG_MASONRY     )
			SetBuildUpgrEx(1, 1, 1, CommonAi.UPG_DEFEND);//call SetBuildUpgrEx( 1,1,1, UPG_DEFEND      )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(1, 1, 2, CommonAi.STEAM_TANK);//call CampaignAttackerEx( 1,1,2, STEAM_TANK  )
			CampaignAttackerEx(4, 4, 4, CommonAi.RIFLEMAN);//call CampaignAttackerEx( 4,4,4, RIFLEMAN    )
			SuicideOnPlayer(U05x11Ai.delay, U08_tealAi.user);//call SuicideOnPlayer(delay,user)
			SetBuildUpgrEx(1, 1, 1, CommonAi.UPG_GUN_RANGE);//call SetBuildUpgrEx( 1,1,1, UPG_GUN_RANGE   )
			SetBuildUpgrEx(1, 1, 1, CommonAi.UPG_LEATHER);//call SetBuildUpgrEx( 1,1,1, UPG_LEATHER     )
			SetBuildUpgrEx(1, 1, 1, CommonAi.UPG_ARMOR);//call SetBuildUpgrEx( 1,1,1, UPG_ARMOR       )
			SetBuildUpgrEx(1, 1, 1, CommonAi.UPG_BREEDING);//call SetBuildUpgrEx( 1,1,1, UPG_BREEDING    )
			SetBuildUpgrEx(1, 1, 1, CommonAi.UPG_BOMBS);//call SetBuildUpgrEx( 1,1,1, UPG_BOMBS       )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(6, 6, 8, CommonAi.FOOTMAN);//call CampaignAttackerEx( 6,6,8, FOOTMAN     )
			CampaignAttackerEx(3, 3, 6, CommonAi.RIFLEMAN);//call CampaignAttackerEx( 3,3,6, RIFLEMAN    )
			CampaignAttackerEx(2, 2, 3, CommonAi.MORTAR);//call CampaignAttackerEx( 2,2,3, MORTAR      )
			SuicideOnPlayer(U05x11Ai.delay, U08_tealAi.user);//call SuicideOnPlayer(delay,user)
			SetBuildUpgrEx(0, 0, 2, CommonAi.UPG_MELEE);//call SetBuildUpgrEx( 0,0,2, UPG_MELEE       )
			SetBuildUpgrEx(0, 0, 2, CommonAi.UPG_RANGED);//call SetBuildUpgrEx( 0,0,2, UPG_RANGED      )
			SetBuildUpgrEx(1, 1, 2, CommonAi.UPG_MASONRY);//call SetBuildUpgrEx( 1,1,2, UPG_MASONRY     )
			SetBuildUpgrEx(1, 1, 1, CommonAi.UPG_TANK);//call SetBuildUpgrEx( 1,1,1, UPG_TANK        )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2, 2, 3, CommonAi.ROCKET_TANK);//call CampaignAttackerEx( 2,2,3, ROCKET_TANK )
			CampaignAttackerEx(2, 2, 4, CommonAi.FOOTMAN);//call CampaignAttackerEx( 2,2,4, FOOTMAN     )
			CampaignAttackerEx(3, 3, 6, CommonAi.RIFLEMAN);//call CampaignAttackerEx( 3,3,6, RIFLEMAN    )
			SuicideOnPlayer(U05x11Ai.delay, U08_tealAi.user);//call SuicideOnPlayer(delay,user)
			SetBuildUpgrEx(0, 0, 2, CommonAi.UPG_LEATHER);//call SetBuildUpgrEx( 0,0,2, UPG_LEATHER     )
			SetBuildUpgrEx(0, 0, 2, CommonAi.UPG_ARMOR);//call SetBuildUpgrEx( 0,0,2, UPG_ARMOR       )
			SetBuildUpgrEx(1, 1, 1, CommonAi.UPG_BREEDING);//call SetBuildUpgrEx( 1,1,1, UPG_BREEDING    )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(4, 4, 6, CommonAi.KNIGHT);//call CampaignAttackerEx( 4,4,6, KNIGHT      )
			CampaignAttackerEx(2, 2, 4, CommonAi.RIFLEMAN);//call CampaignAttackerEx( 2,2,4, RIFLEMAN    )
			CampaignAttackerEx(1, 1, 1, CommonAi.MORTAR);//call CampaignAttackerEx( 1,1,1, MORTAR      )
			SuicideOnPlayer(U05x11Ai.delay, U08_tealAi.user);//call SuicideOnPlayer(delay,user)
			while (true) {//loop
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(2, 2, 3, CommonAi.ROCKET_TANK);//call CampaignAttackerEx( 2,2,3, ROCKET_TANK )
				CampaignAttackerEx(2, 2, 5, CommonAi.KNIGHT);//call CampaignAttackerEx( 2,2,5, KNIGHT      )
				CampaignAttackerEx(3, 3, 5, CommonAi.RIFLEMAN);//call CampaignAttackerEx( 3,3,5, RIFLEMAN    )
				SuicideOnPlayer(U05x11Ai.delay, U08_tealAi.user);//call SuicideOnPlayer(delay,user)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(5, 5, 7, CommonAi.KNIGHT);//call CampaignAttackerEx( 5,5,7, KNIGHT      )
				CampaignAttackerEx(2, 2, 4, CommonAi.RIFLEMAN);//call CampaignAttackerEx( 2,2,4, RIFLEMAN    )
				CampaignAttackerEx(1, 1, 2, CommonAi.MORTAR);//call CampaignAttackerEx( 1,1,2, MORTAR      )
				SuicideOnPlayer(U05x11Ai.delay, U08_tealAi.user);//call SuicideOnPlayer(delay,user)
			}//endloop
		}//endfunction

	
	}
}

