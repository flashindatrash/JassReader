using System;
using System.Collections.Generic;

namespace Jass {

	public class N04_pinkAi {

		//
		//
		//
		public static player User = Player(1);//player User = Player(1)
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(CommonAi.ZIGGURAT_1, null);//call CampaignAI(ZIGGURAT_1,null)
			do_campaign_farms = false;//set do_campaign_farms = false
			CampaignDefender(CommonAi.EASY, 3, CommonAi.GARGOYLE);//call CampaignDefender( EASY, 3, GARGOYLE	)
			WaitForSignal();//call WaitForSignal()
			allow_signal_abort = true;//set allow_signal_abort = true
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2, 2, 3, CommonAi.GARGOYLE);//call CampaignAttackerEx( 2,2,3, GARGOYLE	)
			SuicideOnPlayerEx(CommonAi.M3, CommonAi.M3, CommonAi.M2, N04_pinkAi.User);//call SuicideOnPlayerEx(M3,M3,M2,User)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(3, 3, 4, CommonAi.GARGOYLE);//call CampaignAttackerEx( 3,3,4, GARGOYLE	)
			SuicideOnPlayerEx(CommonAi.M5, CommonAi.M5, CommonAi.M4, N04_pinkAi.User);//call SuicideOnPlayerEx(M5,M5,M4,User)
			while (true) {//loop
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(3, 3, 4, CommonAi.GARGOYLE);//call CampaignAttackerEx( 3,3,4, GARGOYLE	)
				SuicideOnPlayerEx(CommonAi.M5, CommonAi.M5, CommonAi.M4, N04_pinkAi.User);//call SuicideOnPlayerEx(M5,M5,M4,User)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(4, 4, 5, CommonAi.GARGOYLE);//call CampaignAttackerEx( 4,4,5, GARGOYLE	)
				SuicideOnPlayerEx(CommonAi.M5, CommonAi.M5, CommonAi.M4, N04_pinkAi.User);//call SuicideOnPlayerEx(M5,M5,M4,User)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(3, 3, 3, CommonAi.GARGOYLE);//call CampaignAttackerEx( 3,3,3, GARGOYLE	)
				SuicideOnPlayerEx(CommonAi.M5, CommonAi.M5, CommonAi.M4, N04_pinkAi.User);//call SuicideOnPlayerEx(M5,M5,M4,User)
				if (CommandsWaiting() !=0) { break; }//exitwhen CommandsWaiting() !=0
			}//endloop
			SleepForever();//call SleepForever()
		}//endfunction

	
	}
}

