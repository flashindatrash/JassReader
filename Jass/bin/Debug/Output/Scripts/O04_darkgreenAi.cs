using System;
using System.Collections.Generic;

namespace Jass {

	public class O04_darkgreenAi {

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
			SetBuildUnitEx(5, 5, 5, CommonAi.WISP);//call SetBuildUnitEx( 5,5,5, WISP            )
			CampaignDefenderEx(1, 1, 3, CommonAi.ARCHER);//call CampaignDefenderEx( 1,1,3, ARCHER      )
			CampaignDefenderEx(1, 1, 2, CommonAi.HUNTRESS);//call CampaignDefenderEx( 1,1,2, HUNTRESS    )
			WaitForSignal();//call WaitForSignal()
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(3, 3, 5, CommonAi.ARCHER);//call CampaignAttackerEx( 3,3,5, ARCHER          )
			SuicideOnPlayer(CommonAi.M4, U08_tealAi.user);//call SuicideOnPlayer(M4,user)
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_STR_MOON);//call SetBuildUpgrEx( 0,0,1, UPG_STR_MOON	    )
			SetBuildUpgrEx(1, 1, 1, CommonAi.UPG_ULTRAVISION);//call SetBuildUpgrEx( 1,1,1, UPG_ULTRAVISION	    )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(3, 3, 4, CommonAi.ARCHER);//call CampaignAttackerEx( 3,3,4, ARCHER          )
			CampaignAttackerEx(2, 2, 3, CommonAi.HUNTRESS);//call CampaignAttackerEx( 2,2,3, HUNTRESS        )
			SuicideOnPlayerEx(CommonAi.M7, CommonAi.M7, CommonAi.M6, U08_tealAi.user);//call SuicideOnPlayerEx(M7,M7,M6,user)
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_MOON_ARMOR);//call SetBuildUpgrEx( 0,0,1, UPG_MOON_ARMOR	    )
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_GLAIVE);//call SetBuildUpgrEx( 0,0,1, UPG_GLAIVE		    )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2, 2, 3, CommonAi.ARCHER);//call CampaignAttackerEx( 2,2,3, ARCHER          )
			CampaignAttackerEx(2, 2, 4, CommonAi.HUNTRESS);//call CampaignAttackerEx( 2,2,4, HUNTRESS        )
			CampaignAttackerEx(1, 1, 1, CommonAi.BALLISTA);//call CampaignAttackerEx( 1,1,1, BALLISTA        )
			SuicideOnPlayerEx(CommonAi.M7, CommonAi.M7, CommonAi.M6, U08_tealAi.user);//call SuicideOnPlayerEx(M7,M7,M6,user)
			SetBuildUpgrEx(1, 1, 1, CommonAi.UPG_BOWS);//call SetBuildUpgrEx( 1,1,1, UPG_BOWS		    )
			SetBuildUpgrEx(1, 1, 2, CommonAi.UPG_STR_MOON);//call SetBuildUpgrEx( 1,1,2, UPG_STR_MOON	    )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(6, 6, 8, CommonAi.ARCHER);//call CampaignAttackerEx( 6,6,8, ARCHER          )
			CampaignAttackerEx(0, 0, 2, CommonAi.HUNTRESS);//call CampaignAttackerEx( 0,0,2, HUNTRESS        )
			CampaignAttackerEx(1, 1, 2, CommonAi.BALLISTA);//call CampaignAttackerEx( 1,1,2, BALLISTA        )
			SuicideOnPlayerEx(CommonAi.M7, CommonAi.M7, CommonAi.M6, U08_tealAi.user);//call SuicideOnPlayerEx(M7,M7,M6,user)
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_MARKSMAN);//call SetBuildUpgrEx( 0,0,1, UPG_MARKSMAN	    )
			SetBuildUpgrEx(1, 1, 2, CommonAi.UPG_MOON_ARMOR);//call SetBuildUpgrEx( 1,1,2, UPG_MOON_ARMOR	    )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(5, 5, 7, CommonAi.HUNTRESS);//call CampaignAttackerEx( 5,5,7, HUNTRESS        )
			CampaignAttackerEx(0, 0, 2, CommonAi.BALLISTA);//call CampaignAttackerEx( 0,0,2, BALLISTA        )
			SuicideOnPlayerEx(CommonAi.M7, CommonAi.M7, CommonAi.M6, U08_tealAi.user);//call SuicideOnPlayerEx(M7,M7,M6,user)
			SetBuildUpgrEx(1, 1, 1, CommonAi.UPG_GLAIVE);//call SetBuildUpgrEx( 1,1,1, UPG_GLAIVE		    )
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_BOLT);//call SetBuildUpgrEx( 0,0,1, UPG_BOLT		    )
			while (true) {//loop
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(3, 3, 5, CommonAi.ARCHER);//call CampaignAttackerEx( 3,3,5, ARCHER          )
				CampaignAttackerEx(3, 3, 5, CommonAi.HUNTRESS);//call CampaignAttackerEx( 3,3,5, HUNTRESS        )
				CampaignAttackerEx(1, 1, 2, CommonAi.BALLISTA);//call CampaignAttackerEx( 1,1,2, BALLISTA        )
				SuicideOnPlayerEx(CommonAi.M7, CommonAi.M7, CommonAi.M6, U08_tealAi.user);//call SuicideOnPlayerEx(M7,M7,M6,user)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(7, 7, 7, CommonAi.ARCHER);//call CampaignAttackerEx( 7,7,7, ARCHER          )
				CampaignAttackerEx(0, 0, 2, CommonAi.HUNTRESS);//call CampaignAttackerEx( 0,0,2, HUNTRESS        )
				CampaignAttackerEx(2, 2, 3, CommonAi.BALLISTA);//call CampaignAttackerEx( 2,2,3, BALLISTA        )
				SuicideOnPlayerEx(CommonAi.M7, CommonAi.M7, CommonAi.M6, U08_tealAi.user);//call SuicideOnPlayerEx(M7,M7,M6,user)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(5, 5, 8, CommonAi.HUNTRESS);//call CampaignAttackerEx( 5,5,8, HUNTRESS        )
				CampaignAttackerEx(1, 1, 2, CommonAi.BALLISTA);//call CampaignAttackerEx( 1,1,2, BALLISTA        )
				SuicideOnPlayerEx(CommonAi.M7, CommonAi.M7, CommonAi.M6, U08_tealAi.user);//call SuicideOnPlayerEx(M7,M7,M6,user)
			}//endloop
		}//endfunction

	
	}
}

