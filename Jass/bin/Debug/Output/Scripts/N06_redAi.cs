using System;
using System.Collections.Generic;

namespace Jass {

	public class N06_redAi {

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
			SetCaptainHome(CommonAi.ATTACK_CAPTAIN, -4254, 1509);//call SetCaptainHome(ATTACK_CAPTAIN,-4254,1509	)
			SetCaptainHome(CommonAi.DEFENSE_CAPTAIN, -3175, 1434);//call SetCaptainHome(DEFENSE_CAPTAIN,-3175,1434	)
			CampaignDefenderEx(1, 1, 2, CommonAi.DOOMGUARD);//call CampaignDefenderEx( 1,1,2, DOOMGUARD		)
			WaitForSignal();//call WaitForSignal()
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(1, 1, 2, CommonAi.DOOMGUARD);//call CampaignAttackerEx( 1,1,2, DOOMGUARD		)
			SuicideOnPlayerEx(CommonAi.M12, CommonAi.M12, CommonAi.M11, U08_tealAi.user);//call SuicideOnPlayerEx(M12,M12,M11,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2, 2, 2, CommonAi.FELLHOUND);//call CampaignAttackerEx( 2,2,2, FELLHOUND		)
			CampaignAttackerEx(1, 1, 2, CommonAi.DOOMGUARD);//call CampaignAttackerEx( 1,1,2, DOOMGUARD		)
			SuicideOnPlayerEx(CommonAi.M5, CommonAi.M5, CommonAi.M4, U08_tealAi.user);//call SuicideOnPlayerEx(M5,M5,M4,user)
			while (true) {//loop
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(1, 1, 2, CommonAi.DOOMGUARD);//call CampaignAttackerEx( 1,1,2, DOOMGUARD		)
				SuicideOnPlayerEx(CommonAi.M5, CommonAi.M5, CommonAi.M4, U08_tealAi.user);//call SuicideOnPlayerEx(M5,M5,M4,user)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(2, 2, 2, CommonAi.FELLHOUND);//call CampaignAttackerEx( 2,2,2, FELLHOUND		)
				CampaignAttackerEx(1, 1, 2, CommonAi.DOOMGUARD);//call CampaignAttackerEx( 1,1,2, DOOMGUARD		)
				SuicideOnPlayerEx(CommonAi.M5, CommonAi.M5, CommonAi.M4, U08_tealAi.user);//call SuicideOnPlayerEx(M5,M5,M4,user)
			}//endloop
		}//endfunction

	
	}
}

