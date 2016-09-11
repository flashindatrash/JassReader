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
			CampaignAI(HOUSE,null);//call CampaignAI(HOUSE,null)
			SetBuildUnitEx(2,2,2, ZEPPLIN);//call SetBuildUnitEx( 2,2,2, ZEPPLIN     )
			CampaignDefenderEx(2,2,2, FOOTMAN);//call CampaignDefenderEx( 2,2,2, FOOTMAN	)
			WaitForSignal();//call WaitForSignal()
			while (true) {//loop
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(1,1,1, FOOTMAN);//call CampaignAttackerEx( 1,1,1, FOOTMAN)
				CampaignAttackerEx(1,1,1, RIFLEMAN);//call CampaignAttackerEx( 1,1,1, RIFLEMAN)
				CampaignAttackerEx(1,1,1, PRIEST);//call CampaignAttackerEx( 1,1,1, PRIEST)
				CampaignAttackerEx(1,1,1, SORCERESS);//call CampaignAttackerEx( 1,1,1, SORCERESS)
				CampaignAttackerEx(1,1,1, KNIGHT);//call CampaignAttackerEx( 1,1,1, KNIGHT)
				SuicideOnPlayerEx(M2,M2,M2,user);//call SuicideOnPlayerEx(M2,M2,M2,user)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(5,5,5, FOOTMAN);//call CampaignAttackerEx( 5,5,5, FOOTMAN)
				CampaignAttackerEx(5,5,5, MORTAR);//call CampaignAttackerEx( 5,5,5, MORTAR)
				SuicideOnPlayerEx(M2,M2,M2,user);//call SuicideOnPlayerEx(M2,M2,M2,user)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(4,4,4, FOOTMAN);//call CampaignAttackerEx( 4,4,4, FOOTMAN)
				CampaignAttackerEx(2,2,2, RIFLEMAN);//call CampaignAttackerEx( 2,2,2, RIFLEMAN)
				SuicideOnPlayerEx(M2,M2,M2,user);//call SuicideOnPlayerEx(M2,M2,M2,user)
			}//endloop
		}//endfunction

	
	}
}

