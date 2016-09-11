using System;
using System.Collections.Generic;

namespace Jass {

	public class N04_greyAi {

		//
		//
		//
		public static player user = Player(1);//player user = Player(1)
		//
		//
		//
		private void stop_waves() {//function stop_waves takes nothing returns nothing
			SleepForever();//call SleepForever()
		}//endfunction
		//
		//
		//
		private void test() {//function test takes nothing returns nothing
			if (CommandsWaiting() > 0) {//if CommandsWaiting() > 0 then
				stop_waves();//call stop_waves()
			}//endif
		}//endfunction
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(CommonAi.HOUSE, null);//call CampaignAI(HOUSE,null)
			SetBuildUnit(2, CommonAi.ZEPPLIN);//call SetBuildUnit( 2, ZEPPLIN		)
			CampaignDefender(CommonAi.EASY, 1, CommonAi.FOOTMAN);//call CampaignDefender( EASY, 1, FOOTMAN		)
			CampaignDefender(CommonAi.EASY, 1, CommonAi.MORTAR);//call CampaignDefender( EASY, 1, MORTAR		)
			CampaignDefender(CommonAi.EASY, 1, CommonAi.RIFLEMAN);//call CampaignDefender( EASY, 1, RIFLEMAN	)
			CampaignDefender(CommonAi.EASY, 1, CommonAi.COPTER);//call CampaignDefender( EASY, 1, COPTER		)
			WaitForSignal();//call WaitForSignal()
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2, 2, 3, CommonAi.FOOTMAN);//call CampaignAttackerEx( 2,2,3, FOOTMAN     )
			SuicideOnPlayer(CommonAi.M4, U08_tealAi.user);//call SuicideOnPlayer(M4,user)
			test();//call test()
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(3, 3, 3, CommonAi.FOOTMAN);//call CampaignAttackerEx( 3,3,3, FOOTMAN		)
			CampaignAttackerEx(2, 2, 2, CommonAi.RIFLEMAN);//call CampaignAttackerEx( 2,2,2, RIFLEMAN	)
			SuicideOnPlayer(CommonAi.M4, U08_tealAi.user);//call SuicideOnPlayer(M4,user)
			test();//call test()
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(3, 3, 3, CommonAi.FOOTMAN);//call CampaignAttackerEx( 3,3,3, FOOTMAN     )
			CampaignAttackerEx(3, 3, 3, CommonAi.MORTAR);//call CampaignAttackerEx( 3,3,3, MORTAR		)
			CampaignAttackerEx(2, 2, 2, CommonAi.RIFLEMAN);//call CampaignAttackerEx( 2,2,2, RIFLEMAN	)
			SuicideOnPlayer(CommonAi.M4, U08_tealAi.user);//call SuicideOnPlayer(M4,user)
			test();//call test()
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(4, 4, 4, CommonAi.COPTER);//call CampaignAttackerEx( 4,4,4,    COPTER    )
			SuicideOnPlayer(CommonAi.M4, U08_tealAi.user);//call SuicideOnPlayer(M4,user)
			test();//call test()
			SleepForever();//call SleepForever()
		}//endfunction

	
	}
}

