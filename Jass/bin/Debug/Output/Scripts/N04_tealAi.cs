using System;
using System.Collections.Generic;

namespace Jass {

	public class N04_tealAi {

		//
		//
		//
		public static player user = Player(1);//player user = Player(1)
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(CommonAi.BURROW, null);//call CampaignAI(BURROW,null)
			do_campaign_farms = false;//set do_campaign_farms = false
			campaign_wood_peons = 2;//set campaign_wood_peons = 2
			campaign_gold_peons = 0;//set campaign_gold_peons = 0
			SetBuildUnit(2, CommonAi.PEON);//call SetBuildUnit( 2, PEON			)
			SetBuildUnit(2, CommonAi.ZEPPLIN);//call SetBuildUnit( 2, ZEPPLIN		)
			CampaignDefender(CommonAi.EASY, 1, CommonAi.GRUNT);//call CampaignDefender( EASY, 1, GRUNT			)
			CampaignDefender(CommonAi.EASY, 1, CommonAi.HEAD_HUNTER);//call CampaignDefender( EASY, 1, HEAD_HUNTER		)
			CampaignDefender(CommonAi.EASY, 1, CommonAi.RAIDER);//call CampaignDefender( EASY, 1, RAIDER			)
			CampaignDefender(CommonAi.EASY, 1, CommonAi.WYVERN);//call CampaignDefender( EASY, 1, WYVERN			)
			CampaignDefender(CommonAi.EASY, 1, CommonAi.CATAPULT);//call CampaignDefender( EASY, 1, CATAPULT		)
			WaitForSignal();//call WaitForSignal()
			allow_signal_abort = true;//set allow_signal_abort = true
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2, 2, 3, CommonAi.WYVERN);//call CampaignAttackerEx( 2,2,3, WYVERN		)
			SuicideOnPlayer(CommonAi.M1, U08_tealAi.user);//call SuicideOnPlayer(M1,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2, 2, 3, CommonAi.GRUNT);//call CampaignAttackerEx( 2,2,3, GRUNT       )
			SuicideOnPlayerEx(CommonAi.M5, CommonAi.M5, CommonAi.M4, U08_tealAi.user);//call SuicideOnPlayerEx(M5,M5,M4,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(3, 3, 3, CommonAi.HEAD_HUNTER);//call CampaignAttackerEx( 3,3,3, HEAD_HUNTER	)
			CampaignAttackerEx(2, 2, 2, CommonAi.WYVERN);//call CampaignAttackerEx( 2,2,2, WYVERN		)
			SuicideOnPlayerEx(CommonAi.M5, CommonAi.M5, CommonAi.M4, U08_tealAi.user);//call SuicideOnPlayerEx(M5,M5,M4,user)
			while (true) {//loop
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(3, 3, 3, CommonAi.GRUNT);//call CampaignAttackerEx( 3,3,3, GRUNT        )
				CampaignAttackerEx(3, 3, 3, CommonAi.HEAD_HUNTER);//call CampaignAttackerEx( 3,3,3, HEAD_HUNTER  )
				CampaignAttackerEx(2, 2, 2, CommonAi.CATAPULT);//call CampaignAttackerEx( 2,2,2, CATAPULT     )
				SuicideOnPlayerEx(CommonAi.M5, CommonAi.M5, CommonAi.M4, U08_tealAi.user);//call SuicideOnPlayerEx(M5,M5,M4,user)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(4, 4, 4, CommonAi.WYVERN);//call CampaignAttackerEx( 4,4,4,    WYVERN    )
				SuicideOnPlayerEx(CommonAi.M5, CommonAi.M5, CommonAi.M4, U08_tealAi.user);//call SuicideOnPlayerEx(M5,M5,M4,user)
				if (CommandsWaiting() !=0) { break; }//exitwhen CommandsWaiting() !=0
			}//endloop
			SleepForever();//call SleepForever()
		}//endfunction

	
	}
}

