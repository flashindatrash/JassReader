using System;
using System.Collections.Generic;

namespace Jass {

	public class H04_greenAi {

		//
		//
		//
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(ZIGGURAT_1,null);//call CampaignAI(ZIGGURAT_1,null)
			campaign_wood_peons = 2;//set campaign_wood_peons = 2
			SetReplacements(1,1,3);//call SetReplacements(1,1,3)
			SetBuildUnitEx(1,1,1, ACOLYTE);//call SetBuildUnitEx( 1,1,1, ACOLYTE           )
			SetBuildUnitEx(0,0,1, NECROPOLIS_1);//call SetBuildUnitEx( 0,0,1, NECROPOLIS_1      )
			SetBuildUnitEx(0,0,1, CRYPT);//call SetBuildUnitEx( 0,0,1, CRYPT             )
			SetBuildUnitEx(0,0,1, GRAVEYARD);//call SetBuildUnitEx( 0,0,1, GRAVEYARD         )
			SetBuildUnitEx(0,0,6, ZIGGURAT_1);//call SetBuildUnitEx( 0,0,6, ZIGGURAT_1        )
			SetBuildUnitEx(0,0,1, NECROPOLIS_2);//call SetBuildUnitEx( 0,0,1, NECROPOLIS_2      )
			SetBuildUnitEx(0,0,6, ZIGGURAT_2);//call SetBuildUnitEx( 0,0,6, ZIGGURAT_2        )
			SetBuildUnitEx(5,5,5, ACOLYTE);//call SetBuildUnitEx( 5,5,5, ACOLYTE           )
			CampaignDefenderEx(1,1,3, GHOUL);//call CampaignDefenderEx (1,1,3, GHOUL	)
			CampaignDefenderEx(0,0,2, NECRO);//call CampaignDefenderEx (0,0,2, NECRO	)
			WaitForSignal();//call WaitForSignal()
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(3,3,6, GHOUL);//call CampaignAttackerEx( 3,3,6, GHOUL   )
			CampaignAttackerEx(0,0,1, NECRO);//call CampaignAttackerEx( 0,0,1, NECRO   )
			SuicideOnPlayerEx(M5,M5,M1,user);//call SuicideOnPlayerEx(M5,M5,M1,user)
			SetBuildUpgrEx(0,0,1, UPG_CANNIBALIZE);//call SetBuildUpgrEx( 0,0,1, UPG_CANNIBALIZE )
			SetBuildUpgrEx(0,0,1, UPG_SKEL_LIFE);//call SetBuildUpgrEx( 0,0,1, UPG_SKEL_LIFE   )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(4,4,7, GHOUL);//call CampaignAttackerEx( 4,4,7, GHOUL	)
			CampaignAttackerEx(0,0,2, NECRO);//call CampaignAttackerEx( 0,0,2, NECRO   )
			SuicideOnPlayerEx(M6,M6,M3,user);//call SuicideOnPlayerEx(M6,M6,M3,user)
			SetBuildUpgrEx(0,0,1, UPG_UNHOLY_STR);//call SetBuildUpgrEx( 0,0,1, UPG_UNHOLY_STR  )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(1,1,12, GHOUL);//call CampaignAttackerEx( 1,1,12, GHOUL	)
			CampaignAttackerEx(2,2,0, NECRO);//call CampaignAttackerEx( 2,2,0, NECRO	)
			SuicideOnPlayerEx(M5,M5,M3,user);//call SuicideOnPlayerEx(M5,M5,M3,user)
			SetBuildUpgrEx(0,0,1, UPG_NECROS);//call SetBuildUpgrEx( 0,0,1, UPG_NECROS		)
			SetBuildUpgrEx(0,0,1, UPG_UNHOLY_ARMOR);//call SetBuildUpgrEx( 0,0,1, UPG_UNHOLY_ARMOR)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(5,5,2, GHOUL);//call CampaignAttackerEx( 5,5,2, GHOUL   )
			CampaignAttackerEx(0,0,6, NECRO);//call CampaignAttackerEx( 0,0,6, NECRO   )
			SuicideOnPlayerEx(M5,M5,M4,user);//call SuicideOnPlayerEx(M5,M5,M4,user)
			SetBuildUpgrEx(0,0,2, UPG_UNHOLY_STR);//call SetBuildUpgrEx( 0,0,2, UPG_UNHOLY_STR  )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(3,3,12, GHOUL);//call CampaignAttackerEx( 3,3,12, GHOUL  )
			CampaignAttackerEx(2,2,2, NECRO);//call CampaignAttackerEx( 2,2,2, NECRO   )
			SuicideOnPlayerEx(M6,M6,M3,user);//call SuicideOnPlayerEx(M6,M6,M3,user)
			SetBuildUpgrEx(0,0,2, UPG_UNHOLY_ARMOR);//call SetBuildUpgrEx( 0,0,2, UPG_UNHOLY_ARMOR)
			while (true) {//loop
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(6,6,6, GHOUL);//call CampaignAttackerEx( 6,6,6, GHOUL   )
				CampaignAttackerEx(0,0,6, NECRO);//call CampaignAttackerEx( 0,0,6, NECRO   )
				SuicideOnPlayerEx(M5,M5,M4,user);//call SuicideOnPlayerEx(M5,M5,M4,user)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(4,4,12, GHOUL);//call CampaignAttackerEx( 4,4,12, GHOUL	)
				CampaignAttackerEx(2,2,2, NECRO);//call CampaignAttackerEx( 2,2,2, NECRO	)
				SuicideOnPlayerEx(M6,M6,M3,user);//call SuicideOnPlayerEx(M6,M6,M3,user)
			}//endloop
		}//endfunction

	
	}
}

