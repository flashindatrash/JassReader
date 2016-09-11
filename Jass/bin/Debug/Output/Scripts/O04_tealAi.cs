using System;
using System.Collections.Generic;

namespace Jass {

	public class O04_tealAi {

		//
		//
		//
		public static player user = Player(3);//player user = Player(3)
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(CommonAi.MOON_WELL, null);//call CampaignAI(MOON_WELL,null)
			campaign_wood_peons = 100;//set campaign_wood_peons = 100
			SetBuildUnit(5, CommonAi.WISP);//call SetBuildUnit( 5, WISP          )
			SetBuildUpgrEx(1, 1, 1, CommonAi.UPG_HIPPO_TAME);//call SetBuildUpgrEx( 1,1,1, UPG_HIPPO_TAME	)
			CampaignDefenderEx(1, 1, 2, CommonAi.ARCHER);//call CampaignDefenderEx( 1,1,2, ARCHER      )
			CampaignDefenderEx(1, 1, 1, CommonAi.DRYAD);//call CampaignDefenderEx( 1,1,1, DRYAD       )
			CampaignDefenderEx(1, 1, 2, CommonAi.HIPPO);//call CampaignDefenderEx( 1,1,2, HIPPO		)
			CampaignDefenderEx(1, 1, 2, CommonAi.HIPPO_RIDER);//call CampaignDefenderEx( 1,1,2, HIPPO_RIDER )
			WaitForSignal();//call WaitForSignal()
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2, 2, 3, CommonAi.HIPPO_RIDER);//call CampaignAttackerEx( 2,2,3, HIPPO_RIDER		)
			SuicideOnPlayerEx(CommonAi.M1, CommonAi.M1, 0, U08_tealAi.user);//call SuicideOnPlayerEx(M1,M1,0,user)
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_STR_MOON);//call SetBuildUpgrEx( 0,0,1, UPG_STR_MOON	)
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_STR_WILD);//call SetBuildUpgrEx( 0,0,1, UPG_STR_WILD	)
			SetBuildUpgrEx(1, 1, 1, CommonAi.UPG_ULTRAVISION);//call SetBuildUpgrEx( 1,1,1, UPG_ULTRAVISION	)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(4, 4, 5, CommonAi.HIPPO_RIDER);//call CampaignAttackerEx( 4,4,5, HIPPO_RIDER		)
			SuicideOnPlayerEx(CommonAi.M8, CommonAi.M8, CommonAi.M7, U08_tealAi.user);//call SuicideOnPlayerEx(M8,M8,M7,user)
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_MOON_ARMOR);//call SetBuildUpgrEx( 0,0,1, UPG_MOON_ARMOR	)
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_HIDES);//call SetBuildUpgrEx( 0,0,1, UPG_HIDES		)
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_GLAIVE);//call SetBuildUpgrEx( 0,0,1, UPG_GLAIVE		)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(1, 1, 2, CommonAi.BALLISTA);//call CampaignAttackerEx( 1,1,2, BALLISTA        )
			CampaignAttackerEx(4, 4, 5, CommonAi.ARCHER);//call CampaignAttackerEx( 4,4,5, ARCHER          )
			CampaignAttackerEx(3, 3, 5, CommonAi.DRYAD);//call CampaignAttackerEx( 3,3,5, DRYAD           )
			SuicideOnPlayerEx(CommonAi.M8, CommonAi.M8, CommonAi.M7, U08_tealAi.user);//call SuicideOnPlayerEx(M8,M8,M7,user)
			SetBuildUpgrEx(1, 1, 1, CommonAi.UPG_BOWS);//call SetBuildUpgrEx( 1,1,1, UPG_BOWS		)
			SetBuildUpgrEx(1, 1, 2, CommonAi.UPG_STR_MOON);//call SetBuildUpgrEx( 1,1,2, UPG_STR_MOON	)
			SetBuildUpgrEx(1, 1, 2, CommonAi.UPG_STR_WILD);//call SetBuildUpgrEx( 1,1,2, UPG_STR_WILD	)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(6, 6, 9, CommonAi.HIPPO_RIDER);//call CampaignAttackerEx( 6,6,9, HIPPO_RIDER		)
			SuicideOnPlayerEx(CommonAi.M8, CommonAi.M8, CommonAi.M7, U08_tealAi.user);//call SuicideOnPlayerEx(M8,M8,M7,user)
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_MARKSMAN);//call SetBuildUpgrEx( 0,0,1, UPG_MARKSMAN	)
			SetBuildUpgrEx(1, 1, 2, CommonAi.UPG_MOON_ARMOR);//call SetBuildUpgrEx( 1,1,2, UPG_MOON_ARMOR	)
			SetBuildUpgrEx(1, 1, 2, CommonAi.UPG_HIDES);//call SetBuildUpgrEx( 1,1,2, UPG_HIDES		)
			SetBuildUpgrEx(1, 1, 1, CommonAi.UPG_GLAIVE);//call SetBuildUpgrEx( 1,1,1, UPG_GLAIVE		)
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_BOLT);//call SetBuildUpgrEx( 0,0,1, UPG_BOLT		)
			while (true) {//loop
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(2, 2, 3, CommonAi.BALLISTA);//call CampaignAttackerEx( 2,2,3, BALLISTA        )
				CampaignAttackerEx(5, 5, 6, CommonAi.ARCHER);//call CampaignAttackerEx( 5,5,6, ARCHER          )
				CampaignAttackerEx(4, 4, 6, CommonAi.DRYAD);//call CampaignAttackerEx( 4,4,6, DRYAD           )
				SuicideOnPlayerEx(CommonAi.M8, CommonAi.M8, CommonAi.M7, U08_tealAi.user);//call SuicideOnPlayerEx(M8,M8,M7,user)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(7, 7, 10, CommonAi.HIPPO_RIDER);//call CampaignAttackerEx( 7,7,10, HIPPO_RIDER		)
				SuicideOnPlayerEx(CommonAi.M8, CommonAi.M8, CommonAi.M7, U08_tealAi.user);//call SuicideOnPlayerEx(M8,M8,M7,user)
			}//endloop
		}//endfunction

	
	}
}

