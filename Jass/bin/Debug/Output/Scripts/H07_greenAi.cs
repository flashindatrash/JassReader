using System;
using System.Collections.Generic;

namespace Jass {

	public class H07_greenAi {

		//
		//
		//
		public static player user = Player(1);//player user = Player(1)
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(CommonAi.ZIGGURAT_1, null);//call CampaignAI(ZIGGURAT_1,null)
			SetReplacements(1, 1, 3);//call SetReplacements(1,1,3)
			SetBuildUnitEx(0, 0, 1, CommonAi.NECROPOLIS_1);//call SetBuildUnitEx( 0,0,1, NECROPOLIS_1    )
			SetBuildUnitEx(1, 1, 1, CommonAi.ACOLYTE);//call SetBuildUnitEx( 1,1,1, ACOLYTE         )
			SetBuildUnitEx(0, 0, 1, CommonAi.UNDEAD_MINE);//call SetBuildUnitEx( 0,0,1, UNDEAD_MINE     )
			SetBuildUnitEx(0, 0, 7, CommonAi.ZIGGURAT_1);//call SetBuildUnitEx( 0,0,7, ZIGGURAT_1      )
			SetBuildUnitEx(0, 0, 1, CommonAi.CRYPT);//call SetBuildUnitEx( 0,0,1, CRYPT           )
			SetBuildUnitEx(0, 0, 1, CommonAi.UNDEAD_ALTAR);//call SetBuildUnitEx( 0,0,1, UNDEAD_ALTAR    )
			SetBuildUnitEx(0, 0, 1, CommonAi.GRAVEYARD);//call SetBuildUnitEx( 0,0,1, GRAVEYARD       )
			SetBuildUnitEx(0, 0, 1, CommonAi.NECROPOLIS_2);//call SetBuildUnitEx( 0,0,1, NECROPOLIS_2    )
			SetBuildUnitEx(0, 0, 1, CommonAi.SLAUGHTERHOUSE);//call SetBuildUnitEx( 0,0,1, SLAUGHTERHOUSE  )
			SetBuildUnitEx(0, 0, 1, CommonAi.DAMNED_TEMPLE);//call SetBuildUnitEx( 0,0,1, DAMNED_TEMPLE   )
			SetBuildUnitEx(5, 5, 5, CommonAi.ACOLYTE);//call SetBuildUnitEx( 5,5,5, ACOLYTE         )
			CampaignDefenderEx(1, 1, 1, CommonAi.GARGOYLE);//call CampaignDefenderEx( 1,1,1, GARGOYLE    )
			CampaignDefenderEx(2, 2, 1, CommonAi.GHOUL);//call CampaignDefenderEx( 2,2,1, GHOUL       )
			CampaignDefenderEx(0, 0, 1, CommonAi.NECRO);//call CampaignDefenderEx( 0,0,1, NECRO       )
			CampaignDefenderEx(0, 0, 1, CommonAi.ABOMINATION);//call CampaignDefenderEx( 0,0,1, ABOMINATION )
			CampaignDefenderEx(0, 0, 1, CommonAi.LICH);//call CampaignDefenderEx( 0,0,1, LICH	    )
			WaitForSignal();//call WaitForSignal()
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(3, 3, 4, CommonAi.GHOUL);//call CampaignAttackerEx( 3,3,4, GHOUL       )
			CampaignAttackerEx(2, 2, 3, CommonAi.NECRO);//call CampaignAttackerEx( 2,2,3, NECRO       )
			SuicideOnPlayer(0, U08_tealAi.user);//call SuicideOnPlayer(0,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(5, 5, 7, CommonAi.GARGOYLE);//call CampaignAttackerEx( 5,5,7, GARGOYLE    )
			SuicideOnPlayerEx(CommonAi.M3, CommonAi.M3, CommonAi.M2, U08_tealAi.user);//call SuicideOnPlayerEx(M3,M3,M2,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(4, 4, 6, CommonAi.GHOUL);//call CampaignAttackerEx( 4,4,6, GHOUL       )
			CampaignAttackerEx(0, 0, 1, CommonAi.ABOMINATION);//call CampaignAttackerEx( 0,0,1, ABOMINATION )
			CampaignAttackerEx(1, 1, 1, CommonAi.NECRO);//call CampaignAttackerEx( 1,1,1, NECRO       )
			CampaignAttackerEx(1, 1, 1, CommonAi.LICH);//call CampaignAttackerEx( 1,1,1, LICH        )
			SuicideOnPlayerEx(CommonAi.M4, CommonAi.M4, CommonAi.M3, U08_tealAi.user);//call SuicideOnPlayerEx(M4,M4,M3,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(6, 6, 9, CommonAi.GARGOYLE);//call CampaignAttackerEx( 6,6,9, GARGOYLE	)
			SuicideOnPlayerEx(CommonAi.M4, CommonAi.M4, CommonAi.M3, U08_tealAi.user);//call SuicideOnPlayerEx(M4,M4,M3,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(1, 1, 2, CommonAi.ABOMINATION);//call CampaignAttackerEx( 1,1,2, ABOMINATION )
			CampaignAttackerEx(1, 1, 1, CommonAi.NECRO);//call CampaignAttackerEx( 1,1,1, NECRO       )
			CampaignAttackerEx(1, 1, 1, CommonAi.MEAT_WAGON);//call CampaignAttackerEx( 1,1,1, MEAT_WAGON  )
			CampaignAttackerEx(1, 1, 1, CommonAi.LICH);//call CampaignAttackerEx( 1,1,1, LICH        )
			SuicideOnPlayerEx(CommonAi.M5, CommonAi.M5, CommonAi.M3, U08_tealAi.user);//call SuicideOnPlayerEx(M5,M5,M3,user)
			while (true) {//loop
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(8, 8, 12, CommonAi.GARGOYLE);//call CampaignAttackerEx( 8,8,12, GARGOYLE    )
				SuicideOnPlayerEx(CommonAi.M5, CommonAi.M5, CommonAi.M3, U08_tealAi.user);//call SuicideOnPlayerEx(M5,M5,M3,user)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(6, 6, 6, CommonAi.GHOUL);//call CampaignAttackerEx( 6,6,6, GHOUL       )
				CampaignAttackerEx(1, 1, 2, CommonAi.MEAT_WAGON);//call CampaignAttackerEx( 1,1,2, MEAT_WAGON  )
				CampaignAttackerEx(0, 0, 1, CommonAi.ABOMINATION);//call CampaignAttackerEx( 0,0,1, ABOMINATION )
				CampaignAttackerEx(1, 1, 2, CommonAi.NECRO);//call CampaignAttackerEx( 1,1,2, NECRO       )
				CampaignAttackerEx(1, 1, 1, CommonAi.LICH);//call CampaignAttackerEx( 1,1,1, LICH        )
				SuicideOnPlayerEx(CommonAi.M6, CommonAi.M6, CommonAi.M3, U08_tealAi.user);//call SuicideOnPlayerEx(M6,M6,M3,user)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(0, 0, 6, CommonAi.GHOUL);//call CampaignAttackerEx( 0,0,6, GHOUL       )
				CampaignAttackerEx(1, 1, 2, CommonAi.MEAT_WAGON);//call CampaignAttackerEx( 1,1,2, MEAT_WAGON  )
				CampaignAttackerEx(2, 2, 2, CommonAi.ABOMINATION);//call CampaignAttackerEx( 2,2,2, ABOMINATION )
				CampaignAttackerEx(1, 1, 2, CommonAi.NECRO);//call CampaignAttackerEx( 1,1,2, NECRO       )
				SuicideOnPlayerEx(CommonAi.M5, CommonAi.M5, CommonAi.M3, U08_tealAi.user);//call SuicideOnPlayerEx(M5,M5,M3,user)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(7, 7, 12, CommonAi.GARGOYLE);//call CampaignAttackerEx( 7,7,12, GARGOYLE	)
				SuicideOnPlayerEx(CommonAi.M5, CommonAi.M5, CommonAi.M3, U08_tealAi.user);//call SuicideOnPlayerEx(M5,M5,M3,user)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(0, 0, 6, CommonAi.GHOUL);//call CampaignAttackerEx( 0,0,6, GHOUL       )
				CampaignAttackerEx(1, 1, 2, CommonAi.ABOMINATION);//call CampaignAttackerEx( 1,1,2, ABOMINATION )
				CampaignAttackerEx(1, 1, 2, CommonAi.NECRO);//call CampaignAttackerEx( 1,1,2, NECRO       )
				CampaignAttackerEx(0, 0, 2, CommonAi.MEAT_WAGON);//call CampaignAttackerEx( 0,0,2, MEAT_WAGON  )
				CampaignAttackerEx(1, 1, 1, CommonAi.LICH);//call CampaignAttackerEx( 1,1,1, LICH        )
				SuicideOnPlayerEx(CommonAi.M5, CommonAi.M5, CommonAi.M3, U08_tealAi.user);//call SuicideOnPlayerEx(M5,M5,M3,user)
			}//endloop
		}//endfunction

	
	}
}

