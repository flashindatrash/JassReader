using System;
using System.Collections.Generic;

namespace Jass {

	public class IslandtestAi {

		//
		//
		//
		public static player user = Player(0);//player user = Player(0)
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(CommonAi.HOUSE, null);//call CampaignAI(HOUSE,null)
			SetBuildUnitEx(2, 2, 2, CommonAi.ZEPPLIN);//call SetBuildUnitEx( 2,2,2, ZEPPLIN     )
			CampaignDefenderEx(2, 2, 2, CommonAi.FOOTMAN);//call CampaignDefenderEx( 2,2,2, FOOTMAN	)
			WaitForSignal();//call WaitForSignal()
			while (true) {//loop
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(1, 1, 1, CommonAi.FOOTMAN);//call CampaignAttackerEx( 1,1,1, FOOTMAN)
				CampaignAttackerEx(1, 1, 1, CommonAi.RIFLEMAN);//call CampaignAttackerEx( 1,1,1, RIFLEMAN)
				CampaignAttackerEx(1, 1, 1, CommonAi.PRIEST);//call CampaignAttackerEx( 1,1,1, PRIEST)
				CampaignAttackerEx(1, 1, 1, CommonAi.SORCERESS);//call CampaignAttackerEx( 1,1,1, SORCERESS)
				CampaignAttackerEx(1, 1, 1, CommonAi.KNIGHT);//call CampaignAttackerEx( 1,1,1, KNIGHT)
				SuicideOnPlayerEx(CommonAi.M2, CommonAi.M2, CommonAi.M2, U08_tealAi.user);//call SuicideOnPlayerEx(M2,M2,M2,user)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(5, 5, 5, CommonAi.FOOTMAN);//call CampaignAttackerEx( 5,5,5, FOOTMAN)
				CampaignAttackerEx(5, 5, 5, CommonAi.MORTAR);//call CampaignAttackerEx( 5,5,5, MORTAR)
				SuicideOnPlayerEx(CommonAi.M2, CommonAi.M2, CommonAi.M2, U08_tealAi.user);//call SuicideOnPlayerEx(M2,M2,M2,user)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(4, 4, 4, CommonAi.FOOTMAN);//call CampaignAttackerEx( 4,4,4, FOOTMAN)
				CampaignAttackerEx(2, 2, 2, CommonAi.RIFLEMAN);//call CampaignAttackerEx( 2,2,2, RIFLEMAN)
				SuicideOnPlayerEx(CommonAi.M2, CommonAi.M2, CommonAi.M2, U08_tealAi.user);//call SuicideOnPlayerEx(M2,M2,M2,user)
			}//endloop
		}//endfunction

	
	}
}

