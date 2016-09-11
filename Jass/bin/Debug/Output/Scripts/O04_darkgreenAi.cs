using System;
using System.Collections.Generic;

namespace Jass {

	public class O04_darkgreenAi {

		//
		//
		//
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(MOON_WELL,null);//call CampaignAI(MOON_WELL,null)
			campaign_wood_peons = 100;//set campaign_wood_peons = 100
			SetBuildUnitEx(5,5,5, WISP);//call SetBuildUnitEx( 5,5,5, WISP            )
			CampaignDefenderEx(1,1,3, ARCHER);//call CampaignDefenderEx( 1,1,3, ARCHER      )
			CampaignDefenderEx(1,1,2, HUNTRESS);//call CampaignDefenderEx( 1,1,2, HUNTRESS    )
			WaitForSignal();//call WaitForSignal()
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(3,3,5, ARCHER);//call CampaignAttackerEx( 3,3,5, ARCHER          )
			SuicideOnPlayer(M4,user);//call SuicideOnPlayer(M4,user)
			SetBuildUpgrEx(0,0,1, UPG_STR_MOON);//call SetBuildUpgrEx( 0,0,1, UPG_STR_MOON	    )
			SetBuildUpgrEx(1,1,1, UPG_ULTRAVISION);//call SetBuildUpgrEx( 1,1,1, UPG_ULTRAVISION	    )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(3,3,4, ARCHER);//call CampaignAttackerEx( 3,3,4, ARCHER          )
			CampaignAttackerEx(2,2,3, HUNTRESS);//call CampaignAttackerEx( 2,2,3, HUNTRESS        )
			SuicideOnPlayerEx(M7,M7,M6,user);//call SuicideOnPlayerEx(M7,M7,M6,user)
			SetBuildUpgrEx(0,0,1, UPG_MOON_ARMOR);//call SetBuildUpgrEx( 0,0,1, UPG_MOON_ARMOR	    )
			SetBuildUpgrEx(0,0,1, UPG_GLAIVE);//call SetBuildUpgrEx( 0,0,1, UPG_GLAIVE		    )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2,2,3, ARCHER);//call CampaignAttackerEx( 2,2,3, ARCHER          )
			CampaignAttackerEx(2,2,4, HUNTRESS);//call CampaignAttackerEx( 2,2,4, HUNTRESS        )
			CampaignAttackerEx(1,1,1, BALLISTA);//call CampaignAttackerEx( 1,1,1, BALLISTA        )
			SuicideOnPlayerEx(M7,M7,M6,user);//call SuicideOnPlayerEx(M7,M7,M6,user)
			SetBuildUpgrEx(1,1,1, UPG_BOWS);//call SetBuildUpgrEx( 1,1,1, UPG_BOWS		    )
			SetBuildUpgrEx(1,1,2, UPG_STR_MOON);//call SetBuildUpgrEx( 1,1,2, UPG_STR_MOON	    )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(6,6,8, ARCHER);//call CampaignAttackerEx( 6,6,8, ARCHER          )
			CampaignAttackerEx(0,0,2, HUNTRESS);//call CampaignAttackerEx( 0,0,2, HUNTRESS        )
			CampaignAttackerEx(1,1,2, BALLISTA);//call CampaignAttackerEx( 1,1,2, BALLISTA        )
			SuicideOnPlayerEx(M7,M7,M6,user);//call SuicideOnPlayerEx(M7,M7,M6,user)
			SetBuildUpgrEx(0,0,1, UPG_MARKSMAN);//call SetBuildUpgrEx( 0,0,1, UPG_MARKSMAN	    )
			SetBuildUpgrEx(1,1,2, UPG_MOON_ARMOR);//call SetBuildUpgrEx( 1,1,2, UPG_MOON_ARMOR	    )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(5,5,7, HUNTRESS);//call CampaignAttackerEx( 5,5,7, HUNTRESS        )
			CampaignAttackerEx(0,0,2, BALLISTA);//call CampaignAttackerEx( 0,0,2, BALLISTA        )
			SuicideOnPlayerEx(M7,M7,M6,user);//call SuicideOnPlayerEx(M7,M7,M6,user)
			SetBuildUpgrEx(1,1,1, UPG_GLAIVE);//call SetBuildUpgrEx( 1,1,1, UPG_GLAIVE		    )
			SetBuildUpgrEx(0,0,1, UPG_BOLT);//call SetBuildUpgrEx( 0,0,1, UPG_BOLT		    )
			while (true) {//loop
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(3,3,5, ARCHER);//call CampaignAttackerEx( 3,3,5, ARCHER          )
				CampaignAttackerEx(3,3,5, HUNTRESS);//call CampaignAttackerEx( 3,3,5, HUNTRESS        )
				CampaignAttackerEx(1,1,2, BALLISTA);//call CampaignAttackerEx( 1,1,2, BALLISTA        )
				SuicideOnPlayerEx(M7,M7,M6,user);//call SuicideOnPlayerEx(M7,M7,M6,user)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(7,7,7, ARCHER);//call CampaignAttackerEx( 7,7,7, ARCHER          )
				CampaignAttackerEx(0,0,2, HUNTRESS);//call CampaignAttackerEx( 0,0,2, HUNTRESS        )
				CampaignAttackerEx(2,2,3, BALLISTA);//call CampaignAttackerEx( 2,2,3, BALLISTA        )
				SuicideOnPlayerEx(M7,M7,M6,user);//call SuicideOnPlayerEx(M7,M7,M6,user)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(5,5,8, HUNTRESS);//call CampaignAttackerEx( 5,5,8, HUNTRESS        )
				CampaignAttackerEx(1,1,2, BALLISTA);//call CampaignAttackerEx( 1,1,2, BALLISTA        )
				SuicideOnPlayerEx(M7,M7,M6,user);//call SuicideOnPlayerEx(M7,M7,M6,user)
			}//endloop
		}//endfunction

	
	}
}

