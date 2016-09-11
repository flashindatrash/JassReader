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
			CampaignAI(HOUSE,null);//call CampaignAI(HOUSE,null)
			SetReplacements(1,1,3);//call SetReplacements(1,1,3)
			CampaignDefenderEx(1,1,3, FOOTMAN);//call CampaignDefenderEx(1,1,3, FOOTMAN     )
			WaitForSignal();//call WaitForSignal()
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2,2,6, FOOTMEN);//call CampaignAttackerEx( 2,2,6, FOOTMEN     )
			SuicideOnPlayer(0,user);//call SuicideOnPlayer(0,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2,2,7, FOOTMEN);//call CampaignAttackerEx( 2,2,7, FOOTMEN     )
			SuicideOnPlayer(M3,user);//call SuicideOnPlayer(M3,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2,2,6, FOOTMEN);//call CampaignAttackerEx( 2,2,6, FOOTMEN     )
			SuicideOnPlayer(M3,user);//call SuicideOnPlayer(M3,user)
			while (true) {//loop
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(3,3,7, FOOTMEN);//call CampaignAttackerEx( 3,3,7, FOOTMEN     )
				SuicideOnPlayer(M3,user);//call SuicideOnPlayer(M3,user)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(4,4,6, FOOTMEN);//call CampaignAttackerEx( 4,4,6, FOOTMEN     )
				SuicideOnPlayer(M3,user);//call SuicideOnPlayer(M3,user)
			}//endloop
		}//endfunction

	
	}
}

