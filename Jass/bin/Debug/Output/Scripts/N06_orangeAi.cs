using System;
using System.Collections.Generic;

namespace Jass {

	public class N06_orangeAi {

		//
		//
		//
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(CORRUPT_WELL,null);//call CampaignAI(CORRUPT_WELL,null)
			SetReplacements(1,1,3);//call SetReplacements(1,1,3)
			CampaignDefenderEx(0,0,2, SKEL_BURNING);//call CampaignDefenderEx( 0,0,2, SKEL_BURNING	)
			CampaignDefenderEx(2,2,0, SKEL_ARCHER);//call CampaignDefenderEx( 2,2,0, SKEL_ARCHER		)
			CampaignDefenderEx(1,1,2, SKEL_MARKSMAN);//call CampaignDefenderEx( 1,1,2, SKEL_MARKSMAN	)
			CampaignDefenderEx(2,2,1, SKEL_WARRIOR);//call CampaignDefenderEx( 2,2,1, SKEL_WARRIOR	)
			CampaignDefenderEx(0,0,1, SKEL_GIANT);//call CampaignDefenderEx( 0,0,1, SKEL_GIANT		)
			WaitForSignal();//call WaitForSignal()
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(6,6,8, SKEL_WARRIOR);//call CampaignAttackerEx( 6,6,8, SKEL_WARRIOR	)
			CampaignAttackerEx(2,2,4, SKEL_ARCHER);//call CampaignAttackerEx( 2,2,4, SKEL_ARCHER		)
			SuicideOnPlayerEx(M7,M7,M6,user);//call SuicideOnPlayerEx(M7,M7,M6,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(6,6,8, SKEL_WARRIOR);//call CampaignAttackerEx( 6,6,8, SKEL_WARRIOR	)
			CampaignAttackerEx(2,2,4, SKEL_BURNING);//call CampaignAttackerEx( 2,2,4, SKEL_BURNING	)
			SuicideOnPlayerEx(M7,M7,M6,user);//call SuicideOnPlayerEx(M7,M7,M6,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2,2,4, SKEL_GIANT);//call CampaignAttackerEx( 2,2,4, SKEL_GIANT		)
			CampaignAttackerEx(2,2,4, SKEL_ARCHER);//call CampaignAttackerEx( 2,2,4, SKEL_ARCHER		)
			SuicideOnPlayerEx(M7,M7,M6,user);//call SuicideOnPlayerEx(M7,M7,M6,user)
			while (true) {//loop
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(10,10,12, SKEL_WARRIOR);//call CampaignAttackerEx( 10,10,12, SKEL_WARRIOR	)
				CampaignAttackerEx(1,1,2, SKEL_GIANT);//call CampaignAttackerEx( 1,1,2, SKEL_GIANT		)
				CampaignAttackerEx(3,3,5, SKEL_MARKSMAN);//call CampaignAttackerEx( 3,3,5, SKEL_MARKSMAN	)
				SuicideOnPlayerEx(M7,M7,M6,user);//call SuicideOnPlayerEx(M7,M7,M6,user)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(10,10,12, SKEL_WARRIOR);//call CampaignAttackerEx( 10,10,12, SKEL_WARRIOR	)
				CampaignAttackerEx(1,1,2, SKEL_GIANT);//call CampaignAttackerEx( 1,1,2, SKEL_GIANT		)
				CampaignAttackerEx(2,2,4, SKEL_ARCHER);//call CampaignAttackerEx( 2,2,4, SKEL_ARCHER		)
				SuicideOnPlayerEx(M7,M7,M6,user);//call SuicideOnPlayerEx(M7,M7,M6,user)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(10,10,12, SKEL_WARRIOR);//call CampaignAttackerEx( 10,10,12, SKEL_WARRIOR	)
				CampaignAttackerEx(1,1,2, SKEL_GIANT);//call CampaignAttackerEx( 1,1,2, SKEL_GIANT		)
				CampaignAttackerEx(3,3,5, SKEL_BURNING);//call CampaignAttackerEx( 3,3,5, SKEL_BURNING	)
				SuicideOnPlayerEx(M7,M7,M6,user);//call SuicideOnPlayerEx(M7,M7,M6,user)
			}//endloop
		}//endfunction

	
	}
}

