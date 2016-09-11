using System;
using System.Collections.Generic;

namespace Jass {

	public class N06_brownAi {

		//
		//
		//
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(CORRUPT_WELL,null);//call CampaignAI(CORRUPT_WELL,null)
			SetReplacements(1,1,3);//call SetReplacements(1,1,3)
			CampaignDefenderEx(1,1,1, POISON_TREANT);//call CampaignDefenderEx( 1,1,1, POISON_TREANT	)
			CampaignDefenderEx(2,2,1, SATYR);//call CampaignDefenderEx( 2,2,1, SATYR			)
			CampaignDefenderEx(0,0,1, SOULSTEALER);//call CampaignDefenderEx( 0,0,1, SOULSTEALER		)
			CampaignDefenderEx(0,0,1, SHADOWDANCER);//call CampaignDefenderEx( 0,0,1, SHADOWDANCER	)
			CampaignDefenderEx(0,0,1, HELLCALLER);//call CampaignDefenderEx( 0,0,1, HELLCALLER		)
			WaitForSignal();//call WaitForSignal()
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(1,1,1, HELLCALLER);//call CampaignAttackerEx( 1,1,1, HELLCALLER		)
			CampaignAttackerEx(3,3,5, SATYR);//call CampaignAttackerEx( 3,3,5, SATYR			)
			SuicideOnPlayer(40,user);//call SuicideOnPlayer(40,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(6,6,8, CORRUPT_TREANT);//call CampaignAttackerEx( 6,6,8, CORRUPT_TREANT	)
			CampaignAttackerEx(2,2,3, TRICKSTER);//call CampaignAttackerEx( 2,2,3, TRICKSTER		)
			SuicideOnPlayerEx(M9,M9,M8,user);//call SuicideOnPlayerEx(M9,M9,M8,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2,2,5, SHADOWDANCER);//call CampaignAttackerEx( 2,2,5, SHADOWDANCER	)
			CampaignAttackerEx(1,1,3, SOULSTEALER);//call CampaignAttackerEx( 1,1,3, SOULSTEALER		)
			CampaignAttackerEx(5,5,8, SATYR);//call CampaignAttackerEx( 5,5,8, SATYR			)
			SuicideOnPlayerEx(M8,M8,M6,user);//call SuicideOnPlayerEx(M8,M8,M6,user)
			while (true) {//loop
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(5,5,7, POISON_TREANT);//call CampaignAttackerEx( 5,5,7, POISON_TREANT	)
				CampaignAttackerEx(2,2,4, SOULSTEALER);//call CampaignAttackerEx( 2,2,4, SOULSTEALER		)
				SuicideOnPlayerEx(M8,M8,M6,user);//call SuicideOnPlayerEx(M8,M8,M6,user)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(2,2,3, SOULSTEALER);//call CampaignAttackerEx( 2,2,3, SOULSTEALER		)
				CampaignAttackerEx(4,4,6, TRICKSTER);//call CampaignAttackerEx( 4,4,6, TRICKSTER		)
				CampaignAttackerEx(1,1,1, HELLCALLER);//call CampaignAttackerEx( 1,1,1, HELLCALLER		)
				SuicideOnPlayerEx(M8,M8,M6,user);//call SuicideOnPlayerEx(M8,M8,M6,user)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(6,6,8, PLAGUE_TREANT);//call CampaignAttackerEx( 6,6,8, PLAGUE_TREANT	)
				CampaignAttackerEx(4,4,6, SHADOWDANCER);//call CampaignAttackerEx( 4,4,6, SHADOWDANCER	)
				SuicideOnPlayerEx(M8,M8,M6,user);//call SuicideOnPlayerEx(M8,M8,M6,user)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(4,4,6, SATYR);//call CampaignAttackerEx( 4,4,6, SATYR			)
				CampaignAttackerEx(3,3,6, TRICKSTER);//call CampaignAttackerEx( 3,3,6, TRICKSTER		)
				CampaignAttackerEx(2,2,3, SOULSTEALER);//call CampaignAttackerEx( 2,2,3, SOULSTEALER		)
				CampaignAttackerEx(0,0,1, HELLCALLER);//call CampaignAttackerEx( 0,0,1, HELLCALLER		)
				SuicideOnPlayerEx(M8,M8,M6,user);//call SuicideOnPlayerEx(M8,M8,M6,user)
			}//endloop
		}//endfunction

	
	}
}

