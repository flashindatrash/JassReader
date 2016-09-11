using System;
using System.Collections.Generic;

namespace Jass {

	public class O04_blueAi {

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
			CampaignDefenderEx(1, 1, 2, CommonAi.ARCHER);//call CampaignDefenderEx( 1,1,2, ARCHER      )
			CampaignDefenderEx(1, 1, 1, CommonAi.DRYAD);//call CampaignDefenderEx( 1,1,1, DRYAD       )
			CampaignDefenderEx(1, 1, 2, CommonAi.HUNTRESS);//call CampaignDefenderEx( 1,1,2, HUNTRESS    )
			SetBuildUpgrEx(1, 1, 2, CommonAi.UPG_STR_MOON);//call SetBuildUpgrEx( 1,1,2, UPG_STR_MOON	)
			SetBuildUpgrEx(1, 1, 2, CommonAi.UPG_STR_WILD);//call SetBuildUpgrEx( 1,1,2, UPG_STR_WILD	)
			SetBuildUpgrEx(1, 1, 2, CommonAi.UPG_MOON_ARMOR);//call SetBuildUpgrEx( 1,1,2, UPG_MOON_ARMOR	)
			SetBuildUpgrEx(1, 1, 2, CommonAi.UPG_HIDES);//call SetBuildUpgrEx( 1,1,2, UPG_HIDES		)
			SetBuildUpgrEx(1, 1, 1, CommonAi.UPG_BOWS);//call SetBuildUpgrEx( 1,1,1, UPG_BOWS		)
			SetBuildUpgrEx(1, 1, 1, CommonAi.UPG_ULTRAVISION);//call SetBuildUpgrEx( 1,1,1, UPG_ULTRAVISION	)
			WaitForSignal();//call WaitForSignal()
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(6, 6, 8, CommonAi.ARCHER);//call CampaignAttackerEx( 6,6,8, ARCHER      )
			SuicideOnPlayerEx(CommonAi.M2, CommonAi.M2, CommonAi.M1, U08_tealAi.user);//call SuicideOnPlayerEx(M2,M2,M1,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(6, 6, 8, CommonAi.ARCHER);//call CampaignAttackerEx( 6,6,8, ARCHER      )
			CampaignAttackerEx(4, 4, 6, CommonAi.DRYAD);//call CampaignAttackerEx( 4,4,6, DRYAD		)
			SuicideOnPlayerEx(CommonAi.M8, CommonAi.M8, CommonAi.M7, U08_tealAi.user);//call SuicideOnPlayerEx(M8,M8,M7,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(3, 3, 4, CommonAi.ARCHER);//call CampaignAttackerEx( 3,3,4, ARCHER      )
			CampaignAttackerEx(4, 4, 5, CommonAi.HUNTRESS);//call CampaignAttackerEx( 4,4,5, HUNTRESS    )
			CampaignAttackerEx(1, 1, 2, CommonAi.BALLISTA);//call CampaignAttackerEx( 1,1,2, BALLISTA    )
			SuicideOnPlayerEx(CommonAi.M8, CommonAi.M8, CommonAi.M7, U08_tealAi.user);//call SuicideOnPlayerEx(M8,M8,M7,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(5, 5, 6, CommonAi.ARCHER);//call CampaignAttackerEx( 5,5,6, ARCHER      )
			CampaignAttackerEx(3, 3, 4, CommonAi.DRYAD);//call CampaignAttackerEx( 3,3,4, DRYAD		)
			CampaignAttackerEx(1, 1, 2, CommonAi.BALLISTA);//call CampaignAttackerEx( 1,1,2, BALLISTA    )
			SuicideOnPlayerEx(CommonAi.M8, CommonAi.M8, CommonAi.M7, U08_tealAi.user);//call SuicideOnPlayerEx(M8,M8,M7,user)
			while (true) {//loop
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(3, 3, 4, CommonAi.ARCHER);//call CampaignAttackerEx( 3,3,4, ARCHER      )
				CampaignAttackerEx(4, 4, 5, CommonAi.HUNTRESS);//call CampaignAttackerEx( 4,4,5, HUNTRESS    )
				CampaignAttackerEx(2, 2, 3, CommonAi.BALLISTA);//call CampaignAttackerEx( 2,2,3, BALLISTA    )
				SuicideOnPlayerEx(CommonAi.M8, CommonAi.M8, CommonAi.M7, U08_tealAi.user);//call SuicideOnPlayerEx(M8,M8,M7,user)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(6, 6, 8, CommonAi.ARCHER);//call CampaignAttackerEx( 6,6,8, ARCHER      )
				CampaignAttackerEx(6, 6, 8, CommonAi.DRYAD);//call CampaignAttackerEx( 6,6,8, DRYAD		)
				CampaignAttackerEx(1, 1, 2, CommonAi.BALLISTA);//call CampaignAttackerEx( 1,1,2, BALLISTA    )
				SuicideOnPlayerEx(CommonAi.M8, CommonAi.M8, CommonAi.M7, U08_tealAi.user);//call SuicideOnPlayerEx(M8,M8,M7,user)
			}//endloop
		}//endfunction

	
	}
}

