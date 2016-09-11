using System;
using System.Collections.Generic;

namespace Jass {

	public class N04_pinkAi {

		//
		//
		//
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(ZIGGURAT_1,null);//call CampaignAI(ZIGGURAT_1,null)
			do_campaign_farms = false;//set do_campaign_farms = false
			CampaignDefender(EASY, 3, GARGOYLE);//call CampaignDefender( EASY, 3, GARGOYLE	)
			WaitForSignal();//call WaitForSignal()
			allow_signal_abort = true;//set allow_signal_abort = true
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2,2,3, GARGOYLE);//call CampaignAttackerEx( 2,2,3, GARGOYLE	)
			SuicideOnPlayerEx(M3,M3,M2,User);//call SuicideOnPlayerEx(M3,M3,M2,User)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(3,3,4, GARGOYLE);//call CampaignAttackerEx( 3,3,4, GARGOYLE	)
			SuicideOnPlayerEx(M5,M5,M4,User);//call SuicideOnPlayerEx(M5,M5,M4,User)
			while (true) {//loop
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(3,3,4, GARGOYLE);//call CampaignAttackerEx( 3,3,4, GARGOYLE	)
				SuicideOnPlayerEx(M5,M5,M4,User);//call SuicideOnPlayerEx(M5,M5,M4,User)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(4,4,5, GARGOYLE);//call CampaignAttackerEx( 4,4,5, GARGOYLE	)
				SuicideOnPlayerEx(M5,M5,M4,User);//call SuicideOnPlayerEx(M5,M5,M4,User)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(3,3,3, GARGOYLE);//call CampaignAttackerEx( 3,3,3, GARGOYLE	)
				SuicideOnPlayerEx(M5,M5,M4,User);//call SuicideOnPlayerEx(M5,M5,M4,User)
				if (CommandsWaiting() !=0) { break; }//exitwhen CommandsWaiting() !=0
			}//endloop
			SleepForever();//call SleepForever()
		}//endfunction

	
	}
}

