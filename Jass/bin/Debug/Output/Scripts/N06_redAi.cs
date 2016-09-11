using System;
using System.Collections.Generic;

namespace Jass {

	public class N06_redAi {

		//
		//
		//
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(BURROW,null);//call CampaignAI(BURROW,null)
			SetReplacements(6,6,9);//call SetReplacements(6,6,9)
			SetCaptainHome(ATTACK_CAPTAIN,-4254,1509);//call SetCaptainHome(ATTACK_CAPTAIN,-4254,1509	)
			SetCaptainHome(DEFENSE_CAPTAIN,-3175,1434);//call SetCaptainHome(DEFENSE_CAPTAIN,-3175,1434	)
			CampaignDefenderEx(1,1,2, DOOMGUARD);//call CampaignDefenderEx( 1,1,2, DOOMGUARD		)
			WaitForSignal();//call WaitForSignal()
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(1,1,2, DOOMGUARD);//call CampaignAttackerEx( 1,1,2, DOOMGUARD		)
			SuicideOnPlayerEx(M12,M12,M11,user);//call SuicideOnPlayerEx(M12,M12,M11,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2,2,2, FELLHOUND);//call CampaignAttackerEx( 2,2,2, FELLHOUND		)
			CampaignAttackerEx(1,1,2, DOOMGUARD);//call CampaignAttackerEx( 1,1,2, DOOMGUARD		)
			SuicideOnPlayerEx(M5,M5,M4,user);//call SuicideOnPlayerEx(M5,M5,M4,user)
			while (true) {//loop
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(1,1,2, DOOMGUARD);//call CampaignAttackerEx( 1,1,2, DOOMGUARD		)
				SuicideOnPlayerEx(M5,M5,M4,user);//call SuicideOnPlayerEx(M5,M5,M4,user)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(2,2,2, FELLHOUND);//call CampaignAttackerEx( 2,2,2, FELLHOUND		)
				CampaignAttackerEx(1,1,2, DOOMGUARD);//call CampaignAttackerEx( 1,1,2, DOOMGUARD		)
				SuicideOnPlayerEx(M5,M5,M4,user);//call SuicideOnPlayerEx(M5,M5,M4,user)
			}//endloop
		}//endfunction

	
	}
}

