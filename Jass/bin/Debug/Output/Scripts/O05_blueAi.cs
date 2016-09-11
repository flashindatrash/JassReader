using System;
using System.Collections.Generic;

namespace Jass {

	public class O05_blueAi {

		//
		//
		//
		public static player user = Player(3);//player user = Player(3)
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(CommonAi.MOON_WELL, null);//call CampaignAI(MOON_WELL,null)
			SetReplacements(2, 2, 4);//call SetReplacements(2,2,4)
			campaign_wood_peons = 0;//set campaign_wood_peons = 0
			SetBuildUnit(1, CommonAi.TREE_LIFE);//call SetBuildUnit( 1, TREE_LIFE     )
			SetBuildUnit(1, CommonAi.WISP);//call SetBuildUnit( 1, WISP          )
			SetBuildUnit(1, CommonAi.ELF_ALTAR);//call SetBuildUnit( 1, ELF_ALTAR     )
			SetBuildUnit(1, CommonAi.HUNTERS_HALL);//call SetBuildUnit( 1, HUNTERS_HALL  )
			SetBuildUnit(8, CommonAi.WISP);//call SetBuildUnit( 8, WISP          )
			CampaignDefenderEx(1, 1, 2, CommonAi.ARCHER);//call CampaignDefenderEx( 1,1,2, ARCHER      )
			CampaignDefenderEx(1, 1, 1, CommonAi.DRYAD);//call CampaignDefenderEx( 1,1,1, DRYAD       )
			CampaignDefenderEx(1, 1, 2, CommonAi.HUNTRESS);//call CampaignDefenderEx( 1,1,2, HUNTRESS    )
			//
			WaitForSignal();//call WaitForSignal()
			campaign_wood_peons = 100;//set campaign_wood_peons = 100
			//
			WaitForSignal();//call WaitForSignal()
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(4, 4, 6, CommonAi.ARCHER);//call CampaignAttackerEx( 4,4,6, ARCHER      )
			CampaignAttackerEx(2, 2, 3, CommonAi.HUNTRESS);//call CampaignAttackerEx( 2,2,3, HUNTRESS    )
			SuicideOnPlayerEx(CommonAi.M2, CommonAi.M2, CommonAi.M2, U08_tealAi.user);//call SuicideOnPlayerEx(M2,M2,M2,user)
			SetBuildUpgrEx(1, 1, 1, CommonAi.UPG_ULTRAVISION);//call SetBuildUpgrEx( 1,1,1, UPG_ULTRAVISION	)
			SetBuildUpgrEx(1, 1, 1, CommonAi.UPG_ABOLISH);//call SetBuildUpgrEx( 1,1,1, UPG_ABOLISH		)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(6, 6, 8, CommonAi.ARCHER);//call CampaignAttackerEx( 6,6,8, ARCHER      )
			CampaignAttackerEx(4, 4, 6, CommonAi.DRYAD);//call CampaignAttackerEx( 4,4,6, DRYAD		)
			SuicideOnPlayerEx(CommonAi.M8, CommonAi.M8, CommonAi.M7, U08_tealAi.user);//call SuicideOnPlayerEx(M8,M8,M7,user)
			SetBuildUpgrEx(1, 1, 1, CommonAi.UPG_BOWS);//call SetBuildUpgrEx( 1,1,1, UPG_BOWS		)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(3, 3, 4, CommonAi.ARCHER);//call CampaignAttackerEx( 3,3,4, ARCHER      )
			CampaignAttackerEx(4, 4, 5, CommonAi.HUNTRESS);//call CampaignAttackerEx( 4,4,5, HUNTRESS    )
			CampaignAttackerEx(1, 1, 2, CommonAi.BALLISTA);//call CampaignAttackerEx( 1,1,2, BALLISTA    )
			SuicideOnPlayerEx(CommonAi.M8, CommonAi.M8, CommonAi.M7, U08_tealAi.user);//call SuicideOnPlayerEx(M8,M8,M7,user)
			SetBuildUpgrEx(1, 1, 1, CommonAi.UPG_GLAIVE);//call SetBuildUpgrEx( 1,1,1, UPG_GLAIVE		)
			SetBuildUpgrEx(1, 1, 1, CommonAi.UPG_STR_MOON);//call SetBuildUpgrEx( 1,1,1, UPG_STR_MOON	)
			SetBuildUpgrEx(1, 1, 1, CommonAi.UPG_STR_WILD);//call SetBuildUpgrEx( 1,1,1, UPG_STR_WILD	)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(5, 5, 6, CommonAi.ARCHER);//call CampaignAttackerEx( 5,5,6, ARCHER      )
			CampaignAttackerEx(3, 3, 4, CommonAi.DRYAD);//call CampaignAttackerEx( 3,3,4, DRYAD		)
			CampaignAttackerEx(1, 1, 2, CommonAi.BALLISTA);//call CampaignAttackerEx( 1,1,2, BALLISTA    )
			SuicideOnPlayerEx(CommonAi.M8, CommonAi.M8, CommonAi.M7, U08_tealAi.user);//call SuicideOnPlayerEx(M8,M8,M7,user)
			SetBuildUpgrEx(1, 1, 1, CommonAi.UPG_MOON_ARMOR);//call SetBuildUpgrEx( 1,1,1, UPG_MOON_ARMOR	)
			SetBuildUpgrEx(1, 1, 1, CommonAi.UPG_HIDES);//call SetBuildUpgrEx( 1,1,1, UPG_HIDES		)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(4, 4, 5, CommonAi.HUNTRESS);//call CampaignAttackerEx( 4,4,5, HUNTRESS    )
			CampaignAttackerEx(2, 2, 3, CommonAi.BALLISTA);//call CampaignAttackerEx( 2,2,3, BALLISTA    )
			SuicideOnPlayerEx(CommonAi.M8, CommonAi.M8, CommonAi.M7, U08_tealAi.user);//call SuicideOnPlayerEx(M8,M8,M7,user)
			SetBuildUpgrEx(2, 2, 2, CommonAi.UPG_STR_MOON);//call SetBuildUpgrEx( 2,2,2, UPG_STR_MOON	)
			SetBuildUpgrEx(2, 2, 2, CommonAi.UPG_STR_WILD);//call SetBuildUpgrEx( 2,2,2, UPG_STR_WILD	)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(5, 5, 6, CommonAi.ARCHER);//call CampaignAttackerEx( 5,5,6, ARCHER      )
			CampaignAttackerEx(3, 3, 4, CommonAi.DRYAD);//call CampaignAttackerEx( 3,3,4, DRYAD		)
			CampaignAttackerEx(1, 1, 2, CommonAi.BALLISTA);//call CampaignAttackerEx( 1,1,2, BALLISTA    )
			SuicideOnPlayerEx(CommonAi.M8, CommonAi.M8, CommonAi.M7, U08_tealAi.user);//call SuicideOnPlayerEx(M8,M8,M7,user)
			SetBuildUpgrEx(1, 1, 1, CommonAi.UPG_BOLT);//call SetBuildUpgrEx( 1,1,1, UPG_BOLT		)
			SetBuildUpgrEx(1, 1, 1, CommonAi.UPG_MARKSMAN);//call SetBuildUpgrEx( 1,1,1, UPG_MARKSMAN	)
			SetBuildUpgrEx(2, 2, 2, CommonAi.UPG_MOON_ARMOR);//call SetBuildUpgrEx( 2,2,2, UPG_MOON_ARMOR	)
			SetBuildUpgrEx(2, 2, 2, CommonAi.UPG_HIDES);//call SetBuildUpgrEx( 2,2,2, UPG_HIDES		)
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

