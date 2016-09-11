using System;
using System.Collections.Generic;

namespace Jass {

	public class H05_orangeAi {

		//
		//
		//
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			do_campaign_farms = false;//set do_campaign_farms = false
			CampaignAI(ZIGGURAT_1,null);//call CampaignAI(ZIGGURAT_1,null)
			SetCaptainHome(ATTACK_CAPTAIN,6235,2786);//call SetCaptainHome(ATTACK_CAPTAIN,6235,2786)
			SetCaptainHome(DEFENSE_CAPTAIN,5021,2735);//call SetCaptainHome(DEFENSE_CAPTAIN,5021,2735)
			SetBuildUnit(1,NECROPOLIS_1);//call SetBuildUnit( 1,NECROPOLIS_1    )
			SetBuildUnit(1,ACOLYTE);//call SetBuildUnit( 1,ACOLYTE         )
			SetBuildUnit(2,ZIGGURAT_1);//call SetBuildUnit( 2,ZIGGURAT_1      )
			SetBuildUnit(1,UNDEAD_MINE);//call SetBuildUnit( 1,UNDEAD_MINE     )
			SetBuildUnit(1,UNDEAD_ALTAR);//call SetBuildUnit( 1,UNDEAD_ALTAR    )
			SetBuildUnit(1,GRAVEYARD);//call SetBuildUnit( 1,GRAVEYARD       )
			SetBuildUnit(2,CRYPT);//call SetBuildUnit( 2,CRYPT           )
			SetBuildUnit(5,ACOLYTE);//call SetBuildUnit( 5,ACOLYTE         )
			SetBuildUnit(8,ZIGGURAT_1);//call SetBuildUnit( 8,ZIGGURAT_1      )
			SetBuildUnit(1,NECROPOLIS_2);//call SetBuildUnit( 1,NECROPOLIS_2    )
			SetBuildUnit(1,SAC_PIT);//call SetBuildUnit( 1,SAC_PIT         )
			SetBuildUnit(1,DAMNED_TEMPLE);//call SetBuildUnit( 1,DAMNED_TEMPLE   )
			SetBuildUnit(1,SLAUGHTERHOUSE);//call SetBuildUnit( 1,SLAUGHTERHOUSE  )
			SetBuildUnit(8,ZIGGURAT_2);//call SetBuildUnit( 8,ZIGGURAT_2		 )
			SetBuildUnit(1,NECROPOLIS_3);//call SetBuildUnit( 1,NECROPOLIS_3    )
			CampaignDefenderEx(9,9,9, GHOUL);//call CampaignDefenderEx( 9,9,9, GHOUL		)
			CampaignDefenderEx(2,4,6, NECRO);//call CampaignDefenderEx( 2,4,6, NECRO       )
			CampaignDefenderEx(2,3,4, ABOMINATION);//call CampaignDefenderEx( 2,3,4, ABOMINATION )
			CampaignDefenderEx(2,3,4, MEAT_WAGON);//call CampaignDefenderEx( 2,3,4, MEAT_WAGON	)
			WaitForSignal();//call WaitForSignal()
			allow_signal_abort = true;//set allow_signal_abort = true
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(4,4,6, GHOUL);//call CampaignAttackerEx( 4,4,6, GHOUL       )
			SuicideOnPlayer(M3,user);//call SuicideOnPlayer(M3,user)
			ForeverSuicideOnPlayer(M2,user);//call ForeverSuicideOnPlayer(M2,user)
			SuicideUnits(MEAT_WAGON, ABOMINATION, GHOUL, NECRO, SKEL_WARRIOR, LICH, 0, 0, 0, 0);//call SuicideUnits( MEAT_WAGON, ABOMINATION, GHOUL, NECRO, SKEL_WARRIOR, LICH, 0, 0, 0, 0 )
		}//endfunction

	
	}
}

