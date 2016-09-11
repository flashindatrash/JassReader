using System;
using System.Collections.Generic;

namespace Jass {

	public class U05x02Ai {

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
					SetProduce(count,GUARD_TOWER,-1);//call SetProduce(count,GUARD_TOWER,-1)
				}//endif
				Sleep(1);//call Sleep(1)
			}//endloop
		}//endfunction
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(HOUSE,null);//call CampaignAI(HOUSE,null)
			SetReplacements(2,2,3);//call SetReplacements(2,2,3)
			if (difficulty == HARD) {//if difficulty == HARD then
				delay = hard_delay;//set delay = hard_delay
			}//endif
			SetBuildUnitEx(1, 1, 1, PEASANT);//call SetBuildUnitEx( 1, 1, 1, PEASANT           )
			SetBuildUnitEx(0, 0, 1, TOWN_HALL);//call SetBuildUnitEx( 0, 0, 1, TOWN_HALL         )
			SetBuildUnitEx(0, 0, 2, BARRACKS);//call SetBuildUnitEx( 0, 0, 2, BARRACKS          )
			SetBuildUnitEx(0, 0, 1, HUMAN_ALTAR);//call SetBuildUnitEx( 0, 0, 1, HUMAN_ALTAR       )
			SetBuildUnitEx(0, 0, 1, LUMBER_MILL);//call SetBuildUnitEx( 0, 0, 1, LUMBER_MILL       )
			SetBuildUnitEx(0, 0, 1, BLACKSMITH);//call SetBuildUnitEx( 0, 0, 1, BLACKSMITH        )
			SetBuildUnitEx(8, 8, 8, PEASANT);//call SetBuildUnitEx( 8, 8, 8, PEASANT           )
			SetBuildUnitEx(0, 0, 1, KEEP);//call SetBuildUnitEx( 0, 0, 1, KEEP              )
			SetBuildUnitEx(0, 0, 1, ARCANE_VAULT);//call SetBuildUnitEx( 0, 0, 1, ARCANE_VAULT      )
			SetBuildUnitEx(0, 0, 1, CASTLE);//call SetBuildUnitEx( 0, 0, 1, CASTLE            )
			SetBuildUnitEx(0, 0, 1, WORKSHOP);//call SetBuildUnitEx( 0, 0, 1, WORKSHOP          )
			SetBuildUnitEx(0, 0, 1, AVIARY);//call SetBuildUnitEx( 0, 0, 1, AVIARY            )
			WaitForSignal();//call WaitForSignal()
			//
			SuicideOnce(4, 4, 4, FOOTMAN);//call SuicideOnce( 4, 4, 4, FOOTMAN      )
			SuicideOnce(2, 2, 2, KNIGHT);//call SuicideOnce( 2, 2, 2, KNIGHT       )
			SuicideOnce(1, 1, 1, MORTAR);//call SuicideOnce( 1, 1, 1, MORTAR       )
			SuicideOnce(2, 2, 4, RIFLEMAN);//call SuicideOnce( 2, 2, 4, RIFLEMAN     )
			SuicideOnce(1, 1, 1, GRYPHON);//call SuicideOnce( 1, 1, 1, GRYPHON      )
			SuicideOnce(1, 1, 1, GARITHOS);//call SuicideOnce( 1, 1, 1, GARITHOS     )
			WaitForSignal();//call WaitForSignal()
			//
			CampaignDefenderEx(1, 1, 1, FOOTMAN);//call CampaignDefenderEx( 1, 1, 1, FOOTMAN       )
			CampaignDefenderEx(1, 1, 1, KNIGHT);//call CampaignDefenderEx( 1, 1, 1, KNIGHT        )
			CampaignDefenderEx(0, 0, 1, RIFLEMAN);//call CampaignDefenderEx( 0, 0, 1, RIFLEMAN      )
			CampaignDefenderEx(0, 0, 1, GRYPHON);//call CampaignDefenderEx( 0, 0, 1, GRYPHON       )
			CampaignDefenderEx(0, 0, 1, GARITHOS);//call CampaignDefenderEx( 0, 0, 1, GARITHOS      )
			StartThread(function upgrade_towers);//call StartThread(function upgrade_towers)
			WaitForSignal();//call WaitForSignal()
			StartThread(function check_base_deaths);//call StartThread(function check_base_deaths)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(3,3,6, GRYPHON);//call CampaignAttackerEx( 3,3,6, GRYPHON     )
			SuicideOnPlayerEx(M4,M4,M4,user);//call SuicideOnPlayerEx(M4,M4,M4,user)
			SetBuildUpgrEx(1,1,1, UPG_LEATHER);//call SetBuildUpgrEx( 1,1,1, UPG_LEATHER     )
			SetBuildUpgrEx(1,1,1, UPG_ARMOR);//call SetBuildUpgrEx( 1,1,1, UPG_ARMOR       )
			SetBuildUpgrEx(1,1,1, UPG_DEFEND);//call SetBuildUpgrEx( 1,1,1, UPG_DEFEND      )
			SetBuildUpgrEx(1,1,1, UPG_FLAK);//call SetBuildUpgrEx( 1,1,1, UPG_FLAK        )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2,2,3, KNIGHT);//call CampaignAttackerEx( 2,2,3, KNIGHT      )
			CampaignAttackerEx(2,2,3, RIFLEMAN);//call CampaignAttackerEx( 2,2,3, RIFLEMAN    )
			CampaignAttackerEx(1,1,1, GARITHOS);//call CampaignAttackerEx( 1,1,1, GARITHOS    )
			SuicideOnPlayer(delay,user);//call SuicideOnPlayer(delay,user)
			SetBuildUpgrEx(1,1,1, UPG_HAMMERS);//call SetBuildUpgrEx( 1,1,1, UPG_HAMMERS     )
			SetBuildUpgrEx(0,0,1, UPG_BREEDING);//call SetBuildUpgrEx( 0,0,1, UPG_BREEDING    )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(0,0,2, KNIGHT);//call CampaignAttackerEx( 0,0,2, KNIGHT      )
			CampaignAttackerEx(4,4,6, GRYPHON);//call CampaignAttackerEx( 4,4,6, GRYPHON     )
			SuicideOnPlayer(delay,user);//call SuicideOnPlayer(delay,user)
			SetBuildUpgrEx(0,0,2, UPG_MELEE);//call SetBuildUpgrEx( 0,0,2, UPG_MELEE       )
			SetBuildUpgrEx(0,0,2, UPG_RANGED);//call SetBuildUpgrEx( 0,0,2, UPG_RANGED      )
			SetBuildUpgrEx(1,1,2, UPG_MASONRY);//call SetBuildUpgrEx( 1,1,2, UPG_MASONRY     )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(3,3,5, KNIGHT);//call CampaignAttackerEx( 3,3,5, KNIGHT      )
			CampaignAttackerEx(1,1,1, GARITHOS);//call CampaignAttackerEx( 1,1,1, GARITHOS    )
			CampaignAttackerEx(1,1,2, MORTAR);//call CampaignAttackerEx( 1,1,2, MORTAR      )
			SuicideOnPlayer(delay,user);//call SuicideOnPlayer(delay,user)
			SetBuildUpgrEx(0,0,2, UPG_LEATHER);//call SetBuildUpgrEx( 0,0,2, UPG_LEATHER     )
			SetBuildUpgrEx(0,0,2, UPG_ARMOR);//call SetBuildUpgrEx( 0,0,2, UPG_ARMOR       )
			SetBuildUpgrEx(1,1,1, UPG_BREEDING);//call SetBuildUpgrEx( 1,1,1, UPG_BREEDING    )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(3,3,4, COPTER);//call CampaignAttackerEx( 3,3,4, COPTER      )
			CampaignAttackerEx(3,3,5, GRYPHON);//call CampaignAttackerEx( 3,3,5, GRYPHON     )
			SuicideOnPlayer(delay,user);//call SuicideOnPlayer(delay,user)
			SetBuildUpgrEx(1,1,1, UPG_HAMMERS);//call SetBuildUpgrEx( 1,1,1, UPG_HAMMERS     )
			while (true) {//loop
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(4,4,6, KNIGHT);//call CampaignAttackerEx( 4,4,6, KNIGHT      )
				CampaignAttackerEx(1,1,1, GARITHOS);//call CampaignAttackerEx( 1,1,1, GARITHOS    )
				CampaignAttackerEx(1,1,2, RIFLEMAN);//call CampaignAttackerEx( 1,1,2, RIFLEMAN    )
				CampaignAttackerEx(1,1,2, MORTAR);//call CampaignAttackerEx( 1,1,2, MORTAR      )
				SuicideOnPlayer(delay,user);//call SuicideOnPlayer(delay,user)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(0,0,2, KNIGHT);//call CampaignAttackerEx( 0,0,2, KNIGHT      )
				CampaignAttackerEx(6,6,8, GRYPHON);//call CampaignAttackerEx( 6,6,8, GRYPHON     )
				CampaignAttackerEx(2,2,3, COPTER);//call CampaignAttackerEx( 2,2,3, COPTER      )
				SuicideOnPlayer(delay,user);//call SuicideOnPlayer(delay,user)
			}//endloop
		}//endfunction

	
	}
}

