using System;
using System.Collections.Generic;

namespace Jass {

	public class N06_brownAi {

		//
		//
		//
		public static player user = Player(1);//player user = Player(1)
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(CommonAi.CORRUPT_WELL, null);//call CampaignAI(CORRUPT_WELL,null)
			SetReplacements(1, 1, 3);//call SetReplacements(1,1,3)
			CampaignDefenderEx(1, 1, 1, CommonAi.POISON_TREANT);//call CampaignDefenderEx( 1,1,1, POISON_TREANT	)
			CampaignDefenderEx(2, 2, 1, CommonAi.SATYR);//call CampaignDefenderEx( 2,2,1, SATYR			)
			CampaignDefenderEx(0, 0, 1, CommonAi.SOULSTEALER);//call CampaignDefenderEx( 0,0,1, SOULSTEALER		)
			CampaignDefenderEx(0, 0, 1, CommonAi.SHADOWDANCER);//call CampaignDefenderEx( 0,0,1, SHADOWDANCER	)
			CampaignDefenderEx(0, 0, 1, CommonAi.HELLCALLER);//call CampaignDefenderEx( 0,0,1, HELLCALLER		)
			WaitForSignal();//call WaitForSignal()
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(1, 1, 1, CommonAi.HELLCALLER);//call CampaignAttackerEx( 1,1,1, HELLCALLER		)
			CampaignAttackerEx(3, 3, 5, CommonAi.SATYR);//call CampaignAttackerEx( 3,3,5, SATYR			)
			SuicideOnPlayer(40, U08_tealAi.user);//call SuicideOnPlayer(40,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(6, 6, 8, CommonAi.CORRUPT_TREANT);//call CampaignAttackerEx( 6,6,8, CORRUPT_TREANT	)
			CampaignAttackerEx(2, 2, 3, CommonAi.TRICKSTER);//call CampaignAttackerEx( 2,2,3, TRICKSTER		)
			SuicideOnPlayerEx(CommonAi.M9, CommonAi.M9, CommonAi.M8, U08_tealAi.user);//call SuicideOnPlayerEx(M9,M9,M8,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2, 2, 5, CommonAi.SHADOWDANCER);//call CampaignAttackerEx( 2,2,5, SHADOWDANCER	)
			CampaignAttackerEx(1, 1, 3, CommonAi.SOULSTEALER);//call CampaignAttackerEx( 1,1,3, SOULSTEALER		)
			CampaignAttackerEx(5, 5, 8, CommonAi.SATYR);//call CampaignAttackerEx( 5,5,8, SATYR			)
			SuicideOnPlayerEx(CommonAi.M8, CommonAi.M8, CommonAi.M6, U08_tealAi.user);//call SuicideOnPlayerEx(M8,M8,M6,user)
			while (true) {//loop
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(5, 5, 7, CommonAi.POISON_TREANT);//call CampaignAttackerEx( 5,5,7, POISON_TREANT	)
				CampaignAttackerEx(2, 2, 4, CommonAi.SOULSTEALER);//call CampaignAttackerEx( 2,2,4, SOULSTEALER		)
				SuicideOnPlayerEx(CommonAi.M8, CommonAi.M8, CommonAi.M6, U08_tealAi.user);//call SuicideOnPlayerEx(M8,M8,M6,user)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(2, 2, 3, CommonAi.SOULSTEALER);//call CampaignAttackerEx( 2,2,3, SOULSTEALER		)
				CampaignAttackerEx(4, 4, 6, CommonAi.TRICKSTER);//call CampaignAttackerEx( 4,4,6, TRICKSTER		)
				CampaignAttackerEx(1, 1, 1, CommonAi.HELLCALLER);//call CampaignAttackerEx( 1,1,1, HELLCALLER		)
				SuicideOnPlayerEx(CommonAi.M8, CommonAi.M8, CommonAi.M6, U08_tealAi.user);//call SuicideOnPlayerEx(M8,M8,M6,user)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(6, 6, 8, CommonAi.PLAGUE_TREANT);//call CampaignAttackerEx( 6,6,8, PLAGUE_TREANT	)
				CampaignAttackerEx(4, 4, 6, CommonAi.SHADOWDANCER);//call CampaignAttackerEx( 4,4,6, SHADOWDANCER	)
				SuicideOnPlayerEx(CommonAi.M8, CommonAi.M8, CommonAi.M6, U08_tealAi.user);//call SuicideOnPlayerEx(M8,M8,M6,user)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(4, 4, 6, CommonAi.SATYR);//call CampaignAttackerEx( 4,4,6, SATYR			)
				CampaignAttackerEx(3, 3, 6, CommonAi.TRICKSTER);//call CampaignAttackerEx( 3,3,6, TRICKSTER		)
				CampaignAttackerEx(2, 2, 3, CommonAi.SOULSTEALER);//call CampaignAttackerEx( 2,2,3, SOULSTEALER		)
				CampaignAttackerEx(0, 0, 1, CommonAi.HELLCALLER);//call CampaignAttackerEx( 0,0,1, HELLCALLER		)
				SuicideOnPlayerEx(CommonAi.M8, CommonAi.M8, CommonAi.M6, U08_tealAi.user);//call SuicideOnPlayerEx(M8,M8,M6,user)
			}//endloop
		}//endfunction

	
	}
}

