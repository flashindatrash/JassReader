using System;
using System.Collections.Generic;

namespace Jass {

	public class H05_orangeAi {

		//
		//
		//
		public static player user = Player(1);//player user = Player(1)
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			do_campaign_farms = false;//set do_campaign_farms = false
			CampaignAI(CommonAi.ZIGGURAT_1, null);//call CampaignAI(ZIGGURAT_1,null)
			SetCaptainHome(CommonAi.ATTACK_CAPTAIN, 6235, 2786);//call SetCaptainHome(ATTACK_CAPTAIN,6235,2786)
			SetCaptainHome(CommonAi.DEFENSE_CAPTAIN, 5021, 2735);//call SetCaptainHome(DEFENSE_CAPTAIN,5021,2735)
			SetBuildUnit(1, CommonAi.NECROPOLIS_1);//call SetBuildUnit( 1,NECROPOLIS_1    )
			SetBuildUnit(1, CommonAi.ACOLYTE);//call SetBuildUnit( 1,ACOLYTE         )
			SetBuildUnit(2, CommonAi.ZIGGURAT_1);//call SetBuildUnit( 2,ZIGGURAT_1      )
			SetBuildUnit(1, CommonAi.UNDEAD_MINE);//call SetBuildUnit( 1,UNDEAD_MINE     )
			SetBuildUnit(1, CommonAi.UNDEAD_ALTAR);//call SetBuildUnit( 1,UNDEAD_ALTAR    )
			SetBuildUnit(1, CommonAi.GRAVEYARD);//call SetBuildUnit( 1,GRAVEYARD       )
			SetBuildUnit(2, CommonAi.CRYPT);//call SetBuildUnit( 2,CRYPT           )
			SetBuildUnit(5, CommonAi.ACOLYTE);//call SetBuildUnit( 5,ACOLYTE         )
			SetBuildUnit(8, CommonAi.ZIGGURAT_1);//call SetBuildUnit( 8,ZIGGURAT_1      )
			SetBuildUnit(1, CommonAi.NECROPOLIS_2);//call SetBuildUnit( 1,NECROPOLIS_2    )
			SetBuildUnit(1, CommonAi.SAC_PIT);//call SetBuildUnit( 1,SAC_PIT         )
			SetBuildUnit(1, CommonAi.DAMNED_TEMPLE);//call SetBuildUnit( 1,DAMNED_TEMPLE   )
			SetBuildUnit(1, CommonAi.SLAUGHTERHOUSE);//call SetBuildUnit( 1,SLAUGHTERHOUSE  )
			SetBuildUnit(8, CommonAi.ZIGGURAT_2);//call SetBuildUnit( 8,ZIGGURAT_2		 )
			SetBuildUnit(1, CommonAi.NECROPOLIS_3);//call SetBuildUnit( 1,NECROPOLIS_3    )
			CampaignDefenderEx(9, 9, 9, CommonAi.GHOUL);//call CampaignDefenderEx( 9,9,9, GHOUL		)
			CampaignDefenderEx(2, 4, 6, CommonAi.NECRO);//call CampaignDefenderEx( 2,4,6, NECRO       )
			CampaignDefenderEx(2, 3, 4, CommonAi.ABOMINATION);//call CampaignDefenderEx( 2,3,4, ABOMINATION )
			CampaignDefenderEx(2, 3, 4, CommonAi.MEAT_WAGON);//call CampaignDefenderEx( 2,3,4, MEAT_WAGON	)
			WaitForSignal();//call WaitForSignal()
			allow_signal_abort = true;//set allow_signal_abort = true
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(4, 4, 6, CommonAi.GHOUL);//call CampaignAttackerEx( 4,4,6, GHOUL       )
			SuicideOnPlayer(CommonAi.M3, U08_tealAi.user);//call SuicideOnPlayer(M3,user)
			ForeverSuicideOnPlayer(CommonAi.M2, U08_tealAi.user);//call ForeverSuicideOnPlayer(M2,user)
			SuicideUnits(CommonAi.MEAT_WAGON, CommonAi.ABOMINATION, CommonAi.GHOUL, CommonAi.NECRO, CommonAi.SKEL_WARRIOR, CommonAi.LICH, 0, 0, 0, 0);//call SuicideUnits( MEAT_WAGON, ABOMINATION, GHOUL, NECRO, SKEL_WARRIOR, LICH, 0, 0, 0, 0 )
		}//endfunction

	
	}
}

