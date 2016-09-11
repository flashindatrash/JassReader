using System;
using System.Collections.Generic;

namespace Jass {

	public class U02_blueAi {

		//
		//
		//
		public static player user = Player(3);//player user = Player(3)
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(CommonAi.HOUSE, null);//call CampaignAI(HOUSE,null)
			SetReplacements(1, 1, 3);//call SetReplacements(1,1,3)
			CampaignDefenderEx(1, 1, 3, CommonAi.FOOTMAN);//call CampaignDefenderEx(1,1,3, FOOTMAN     )
			WaitForSignal();//call WaitForSignal()
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2, 2, 6, CommonAi.FOOTMEN);//call CampaignAttackerEx( 2,2,6, FOOTMEN     )
			SuicideOnPlayer(0, U08_tealAi.user);//call SuicideOnPlayer(0,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2, 2, 7, CommonAi.FOOTMEN);//call CampaignAttackerEx( 2,2,7, FOOTMEN     )
			SuicideOnPlayer(CommonAi.M3, U08_tealAi.user);//call SuicideOnPlayer(M3,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2, 2, 6, CommonAi.FOOTMEN);//call CampaignAttackerEx( 2,2,6, FOOTMEN     )
			SuicideOnPlayer(CommonAi.M3, U08_tealAi.user);//call SuicideOnPlayer(M3,user)
			while (true) {//loop
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(3, 3, 7, CommonAi.FOOTMEN);//call CampaignAttackerEx( 3,3,7, FOOTMEN     )
				SuicideOnPlayer(CommonAi.M3, U08_tealAi.user);//call SuicideOnPlayer(M3,user)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(4, 4, 6, CommonAi.FOOTMEN);//call CampaignAttackerEx( 4,4,6, FOOTMEN     )
				SuicideOnPlayer(CommonAi.M3, U08_tealAi.user);//call SuicideOnPlayer(M3,user)
			}//endloop
		}//endfunction

	
	}
}

