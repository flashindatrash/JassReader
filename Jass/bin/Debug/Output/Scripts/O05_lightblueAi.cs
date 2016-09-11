using System;
using System.Collections.Generic;

namespace Jass {

	public class O05_lightblueAi {

		//
		//
		//
		public static player user = Player(3);//player user = Player(3)
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(MOON_WELL,null);//call CampaignAI(MOON_WELL,null)
			SetReplacements(2,2,4);//call SetReplacements(2,2,4)
			//
			campaign_wood_peons = 0;//set campaign_wood_peons = 0
			SetBuildUnit(1, WISP);//call SetBuildUnit( 1, WISP          )
			SetBuildUnit(1, ELF_ALTAR);//call SetBuildUnit( 1, ELF_ALTAR     )
			SetBuildUnit(1, HUNTERS_HALL);//call SetBuildUnit( 1, HUNTERS_HALL  )
			SetBuildUnit(8, WISP);//call SetBuildUnit( 8, WISP          )
			SetBuildUnitEx(3,3,3, ANCIENT_PROTECT);//call SetBuildUnitEx( 3,3,3, ANCIENT_PROTECT )
			CampaignDefender(EASY, 3, ARCHER);//call CampaignDefender( EASY, 3, ARCHER      )
			CampaignDefender(EASY, 2, HUNTRESS);//call CampaignDefender( EASY, 2, HUNTRESS    )
			SetBuildUpgrEx(0,0,1, UPG_BLESSING);//call SetBuildUpgrEx( 0,0,1, UPG_BLESSING	)
			//
			WaitForSignal();//call WaitForSignal()
			campaign_wood_peons = 0;//set campaign_wood_peons = 0
			//
			WaitForSignal();//call WaitForSignal()
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(3,3,5, ARCHER);//call CampaignAttackerEx( 3,3,5, ARCHER          )
			CampaignAttackerEx(1,1,1, ANCIENT_PROTECT);//call CampaignAttackerEx( 1,1,1, ANCIENT_PROTECT )
			SuicideOnPlayerEx(M6,M6,M6,user);//call SuicideOnPlayerEx(M6,M6,M6,user)
			SetBuildUpgrEx(0,0,1, UPG_STR_MOON);//call SetBuildUpgrEx( 0,0,1, UPG_STR_MOON	    )
			SetBuildUpgrEx(1,1,1, UPG_ULTRAVISION);//call SetBuildUpgrEx( 1,1,1, UPG_ULTRAVISION	    )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(3,3,4, ARCHER);//call CampaignAttackerEx( 3,3,4, ARCHER          )
			CampaignAttackerEx(2,2,3, ANCIENT_PROTECT);//call CampaignAttackerEx( 2,2,3, ANCIENT_PROTECT )
			SuicideOnPlayerEx(M8,M8,M7,user);//call SuicideOnPlayerEx(M8,M8,M7,user)
			SetBuildUpgrEx(0,0,1, UPG_MOON_ARMOR);//call SetBuildUpgrEx( 0,0,1, UPG_MOON_ARMOR	    )
			SetBuildUpgrEx(0,0,1, UPG_GLAIVE);//call SetBuildUpgrEx( 0,0,1, UPG_GLAIVE		    )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2,2,3, ARCHER);//call CampaignAttackerEx( 2,2,3, ARCHER          )
			CampaignAttackerEx(2,2,4, HUNTRESS);//call CampaignAttackerEx( 2,2,4, HUNTRESS        )
			CampaignAttackerEx(1,1,1, BALLISTA);//call CampaignAttackerEx( 1,1,1, BALLISTA        )
			CampaignAttackerEx(1,1,1, ANCIENT_PROTECT);//call CampaignAttackerEx( 1,1,1, ANCIENT_PROTECT )
			SuicideOnPlayerEx(M8,M8,M7,user);//call SuicideOnPlayerEx(M8,M8,M7,user)
			SetBuildUpgrEx(1,1,1, UPG_BOWS);//call SetBuildUpgrEx( 1,1,1, UPG_BOWS		    )
			SetBuildUpgrEx(1,1,2, UPG_STR_MOON);//call SetBuildUpgrEx( 1,1,2, UPG_STR_MOON	    )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(4,4,5, ARCHER);//call CampaignAttackerEx( 4,4,5, ARCHER          )
			CampaignAttackerEx(2,2,3, HUNTRESS);//call CampaignAttackerEx( 2,2,3, HUNTRESS        )
			CampaignAttackerEx(2,2,3, ANCIENT_PROTECT);//call CampaignAttackerEx( 2,2,3, ANCIENT_PROTECT )
			SuicideOnPlayerEx(M8,M8,M7,user);//call SuicideOnPlayerEx(M8,M8,M7,user)
			SetBuildUpgrEx(1,1,1, UPG_MARKSMAN);//call SetBuildUpgrEx( 1,1,1, UPG_MARKSMAN	    )
			SetBuildUpgrEx(1,1,2, UPG_MOON_ARMOR);//call SetBuildUpgrEx( 1,1,2, UPG_MOON_ARMOR	    )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(4,4,6, HUNTRESS);//call CampaignAttackerEx( 4,4,6, HUNTRESS        )
			CampaignAttackerEx(1,1,2, BALLISTA);//call CampaignAttackerEx( 1,1,2, BALLISTA        )
			CampaignAttackerEx(1,1,2, ANCIENT_PROTECT);//call CampaignAttackerEx( 1,1,2, ANCIENT_PROTECT )
			SuicideOnPlayerEx(M8,M8,M7,user);//call SuicideOnPlayerEx(M8,M8,M7,user)
			SetBuildUpgrEx(1,1,1, UPG_GLAIVE);//call SetBuildUpgrEx( 1,1,1, UPG_GLAIVE		    )
			SetBuildUpgrEx(1,1,1, UPG_BOLT);//call SetBuildUpgrEx( 1,1,1, UPG_BOLT		    )
			SetBuildUpgrEx(2,2,2, UPG_MOON_ARMOR);//call SetBuildUpgrEx( 2,2,2, UPG_MOON_ARMOR	    )
			SetBuildUpgrEx(2,2,2, UPG_STR_MOON);//call SetBuildUpgrEx( 2,2,2, UPG_STR_MOON	    )
			while (true) {//loop
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(3,3,5, ARCHER);//call CampaignAttackerEx( 3,3,5, ARCHER          )
				CampaignAttackerEx(3,3,4, ANCIENT_PROTECT);//call CampaignAttackerEx( 3,3,4, ANCIENT_PROTECT )
				SuicideOnPlayerEx(M8,M8,M7,user);//call SuicideOnPlayerEx(M8,M8,M7,user)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(1,1,2, ARCHER);//call CampaignAttackerEx( 1,1,2, ARCHER          )
				CampaignAttackerEx(2,2,3, HUNTRESS);//call CampaignAttackerEx( 2,2,3, HUNTRESS        )
				CampaignAttackerEx(2,2,3, BALLISTA);//call CampaignAttackerEx( 2,2,3, BALLISTA        )
				CampaignAttackerEx(1,1,2, ANCIENT_PROTECT);//call CampaignAttackerEx( 1,1,2, ANCIENT_PROTECT )
				SuicideOnPlayerEx(M8,M8,M7,user);//call SuicideOnPlayerEx(M8,M8,M7,user)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(5,5,8, HUNTRESS);//call CampaignAttackerEx( 5,5,8, HUNTRESS        )
				CampaignAttackerEx(1,1,2, BALLISTA);//call CampaignAttackerEx( 1,1,2, BALLISTA        )
				CampaignAttackerEx(2,2,3, ANCIENT_PROTECT);//call CampaignAttackerEx( 2,2,3, ANCIENT_PROTECT )
				SuicideOnPlayerEx(M8,M8,M7,user);//call SuicideOnPlayerEx(M8,M8,M7,user)
			}//endloop
		}//endfunction

	
	}
}

