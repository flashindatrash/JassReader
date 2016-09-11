using System;
using System.Collections.Generic;

namespace Jass {

	public class N04_greenAi {

		//
		//
		//
		public static player user = Player(1);//player user = Player(1)
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(CORRUPT_WELL,null);//call CampaignAI(CORRUPT_WELL,null)
			SetReplacements(1,1,3);//call SetReplacements(1,1,3)
			CampaignDefenderEx(1,1,1, SKEL_WARRIOR);//call CampaignDefenderEx( 1,1,1, SKEL_WARRIOR	)
			CampaignDefenderEx(0,0,1, SHADOWDANCER);//call CampaignDefenderEx( 0,0,1, SHADOWDANCER	)
			CampaignDefenderEx(1,1,1, TRICKSTER);//call CampaignDefenderEx( 1,1,1, TRICKSTER		)
			CampaignDefenderEx(0,0,1, SOULSTEALER);//call CampaignDefenderEx( 0,0,1, SOULSTEALER		)
			CampaignDefenderEx(1,1,1, SATYR);//call CampaignDefenderEx( 1,1,1, SATYR			)
			WaitForSignal();//call WaitForSignal()
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(3,3,4, SATYR);//call CampaignAttackerEx( 3,3,4, SATYR			)
			CampaignAttackerEx(1,1,2, TRICKSTER);//call CampaignAttackerEx( 1,1,2, TRICKSTER		)
			SuicideOnPlayerEx(M2,M2,M1,user);//call SuicideOnPlayerEx(M2,M2,M1,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(8,8,10, SKEL_WARRIOR);//call CampaignAttackerEx( 8,8,10, SKEL_WARRIOR	)
			SuicideOnPlayerEx(M5,M5,M4,user);//call SuicideOnPlayerEx(M5,M5,M4,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(3,3,4, SATYR);//call CampaignAttackerEx( 3,3,4, SATYR			)
			CampaignAttackerEx(1,1,2, SHADOWDANCER);//call CampaignAttackerEx( 1,1,2, SHADOWDANCER	)
			SuicideOnPlayerEx(M5,M5,M4,user);//call SuicideOnPlayerEx(M5,M5,M4,user)
			while (true) {//loop
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(5,5,6, SATYR);//call CampaignAttackerEx( 5,5,6, SATYR		)
				CampaignAttackerEx(1,1,2, TRICKSTER);//call CampaignAttackerEx( 1,1,2, TRICKSTER	)
				SuicideOnPlayerEx(M5,M5,M4,user);//call SuicideOnPlayerEx(M5,M5,M4,user)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(3,3,4, SKEL_WARRIOR);//call CampaignAttackerEx( 3,3,4, SKEL_WARRIOR	)
				CampaignAttackerEx(1,1,2, SHADOWDANCER);//call CampaignAttackerEx( 1,1,2, SHADOWDANCER	)
				SuicideOnPlayerEx(M5,M5,M4,user);//call SuicideOnPlayerEx(M5,M5,M4,user)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(3,3,4, SATYR);//call CampaignAttackerEx( 3,3,4, SATYR			)
				CampaignAttackerEx(1,1,2, SOULSTEALER);//call CampaignAttackerEx( 1,1,2, SOULSTEALER		)
				SuicideOnPlayerEx(M5,M5,M4,user);//call SuicideOnPlayerEx(M5,M5,M4,user)
			}//endloop
		}//endfunction

	
	}
}

