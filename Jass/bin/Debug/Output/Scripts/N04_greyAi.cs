using System;
using System.Collections.Generic;

namespace Jass {

	public class N04_greyAi {

		//
		//
		//
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
			CampaignAI(HOUSE,null);//call CampaignAI(HOUSE,null)
			SetBuildUnit(2, ZEPPLIN);//call SetBuildUnit( 2, ZEPPLIN		)
			CampaignDefender(EASY, 1, FOOTMAN);//call CampaignDefender( EASY, 1, FOOTMAN		)
			CampaignDefender(EASY, 1, MORTAR);//call CampaignDefender( EASY, 1, MORTAR		)
			CampaignDefender(EASY, 1, RIFLEMAN);//call CampaignDefender( EASY, 1, RIFLEMAN	)
			CampaignDefender(EASY, 1, COPTER);//call CampaignDefender( EASY, 1, COPTER		)
			WaitForSignal();//call WaitForSignal()
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2,2,3, FOOTMAN);//call CampaignAttackerEx( 2,2,3, FOOTMAN     )
			SuicideOnPlayer(M4,user);//call SuicideOnPlayer(M4,user)
			test();//call test()
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(3,3,3, FOOTMAN);//call CampaignAttackerEx( 3,3,3, FOOTMAN		)
			CampaignAttackerEx(2,2,2, RIFLEMAN);//call CampaignAttackerEx( 2,2,2, RIFLEMAN	)
			SuicideOnPlayer(M4,user);//call SuicideOnPlayer(M4,user)
			test();//call test()
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(3,3,3, FOOTMAN);//call CampaignAttackerEx( 3,3,3, FOOTMAN     )
			CampaignAttackerEx(3,3,3, MORTAR);//call CampaignAttackerEx( 3,3,3, MORTAR		)
			CampaignAttackerEx(2,2,2, RIFLEMAN);//call CampaignAttackerEx( 2,2,2, RIFLEMAN	)
			SuicideOnPlayer(M4,user);//call SuicideOnPlayer(M4,user)
			test();//call test()
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(4,4,4,    COPTER);//call CampaignAttackerEx( 4,4,4,    COPTER    )
			SuicideOnPlayer(M4,user);//call SuicideOnPlayer(M4,user)
			test();//call test()
			SleepForever();//call SleepForever()
		}//endfunction

	
	}
}

