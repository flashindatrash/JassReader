using System;
using System.Collections.Generic;

namespace Jass {

	public class N04_tealAi {

		//
		//
		//
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(BURROW,null);//call CampaignAI(BURROW,null)
			do_campaign_farms = false;//set do_campaign_farms = false
			campaign_wood_peons = 2;//set campaign_wood_peons = 2
			campaign_gold_peons = 0;//set campaign_gold_peons = 0
			SetBuildUnit(2, PEON);//call SetBuildUnit( 2, PEON			)
			SetBuildUnit(2, ZEPPLIN);//call SetBuildUnit( 2, ZEPPLIN		)
			CampaignDefender(EASY, 1, GRUNT);//call CampaignDefender( EASY, 1, GRUNT			)
			CampaignDefender(EASY, 1, HEAD_HUNTER);//call CampaignDefender( EASY, 1, HEAD_HUNTER		)
			CampaignDefender(EASY, 1, RAIDER);//call CampaignDefender( EASY, 1, RAIDER			)
			CampaignDefender(EASY, 1, WYVERN);//call CampaignDefender( EASY, 1, WYVERN			)
			CampaignDefender(EASY, 1, CATAPULT);//call CampaignDefender( EASY, 1, CATAPULT		)
			WaitForSignal();//call WaitForSignal()
			allow_signal_abort = true;//set allow_signal_abort = true
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2,2,3, WYVERN);//call CampaignAttackerEx( 2,2,3, WYVERN		)
			SuicideOnPlayer(M1,user);//call SuicideOnPlayer(M1,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2,2,3, GRUNT);//call CampaignAttackerEx( 2,2,3, GRUNT       )
			SuicideOnPlayerEx(M5,M5,M4,user);//call SuicideOnPlayerEx(M5,M5,M4,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(3,3,3, HEAD_HUNTER);//call CampaignAttackerEx( 3,3,3, HEAD_HUNTER	)
			CampaignAttackerEx(2,2,2, WYVERN);//call CampaignAttackerEx( 2,2,2, WYVERN		)
			SuicideOnPlayerEx(M5,M5,M4,user);//call SuicideOnPlayerEx(M5,M5,M4,user)
			while (true) {//loop
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(3,3,3, GRUNT);//call CampaignAttackerEx( 3,3,3, GRUNT        )
				CampaignAttackerEx(3,3,3, HEAD_HUNTER);//call CampaignAttackerEx( 3,3,3, HEAD_HUNTER  )
				CampaignAttackerEx(2,2,2, CATAPULT);//call CampaignAttackerEx( 2,2,2, CATAPULT     )
				SuicideOnPlayerEx(M5,M5,M4,user);//call SuicideOnPlayerEx(M5,M5,M4,user)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(4,4,4,    WYVERN);//call CampaignAttackerEx( 4,4,4,    WYVERN    )
				SuicideOnPlayerEx(M5,M5,M4,user);//call SuicideOnPlayerEx(M5,M5,M4,user)
				if (CommandsWaiting() !=0) { break; }//exitwhen CommandsWaiting() !=0
			}//endloop
			SleepForever();//call SleepForever()
		}//endfunction

	
	}
}

