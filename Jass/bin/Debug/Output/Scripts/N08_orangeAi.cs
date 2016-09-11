using System;
using System.Collections.Generic;

namespace Jass {

	public class N08_orangeAi {

		//
		//
		//
		public static player user = Player(1);//player user = Player(1)
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(CommonAi.BURROW, null);//call CampaignAI(BURROW,null)
			SetReplacements(6, 6, 9);//call SetReplacements(6,6,9)
			CampaignDefenderEx(2, 2, 3, CommonAi.DOOMGUARD);//call CampaignDefenderEx( 2,2,3, DOOMGUARD	)
			WaitForSignal();//call WaitForSignal()
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2, 2, 4, CommonAi.DOOMGUARD);//call CampaignAttackerEx( 2,2,4, DOOMGUARD	)
			SuicideOnPlayerEx(CommonAi.M7, CommonAi.M7, CommonAi.M6, U08_tealAi.user);//call SuicideOnPlayerEx(M7,M7,M6,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(6, 6, 8, CommonAi.FELLHOUND);//call CampaignAttackerEx( 6,6,8, FELLHOUND	)
			CampaignAttackerEx(1, 1, 2, CommonAi.DOOMGUARD);//call CampaignAttackerEx( 1,1,2, DOOMGUARD	)
			SuicideOnPlayerEx(CommonAi.M7, CommonAi.M7, CommonAi.M6, U08_tealAi.user);//call SuicideOnPlayerEx(M7,M7,M6,user)
			while (true) {//loop
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(3, 3, 4, CommonAi.DOOMGUARD);//call CampaignAttackerEx( 3,3,4, DOOMGUARD	)
				CampaignAttackerEx(2, 2, 3, CommonAi.FELLHOUND);//call CampaignAttackerEx( 2,2,3, FELLHOUND	)
				SuicideOnPlayerEx(CommonAi.M7, CommonAi.M7, CommonAi.M6, U08_tealAi.user);//call SuicideOnPlayerEx(M7,M7,M6,user)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(8, 8, 9, CommonAi.FELLHOUND);//call CampaignAttackerEx( 8,8,9, FELLHOUND	)
				CampaignAttackerEx(1, 1, 2, CommonAi.DOOMGUARD);//call CampaignAttackerEx( 1,1,2, DOOMGUARD	)
				SuicideOnPlayerEx(CommonAi.M7, CommonAi.M7, CommonAi.M6, U08_tealAi.user);//call SuicideOnPlayerEx(M7,M7,M6,user)
			}//endloop
		}//endfunction

	
	}
}

