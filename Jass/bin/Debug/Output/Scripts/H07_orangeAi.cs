using System;
using System.Collections.Generic;

namespace Jass {

	public class H07_orangeAi {

		//
		//
		//
		public static player attacked = Player(8);//player attacked = Player(8)
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(CommonAi.ZIGGURAT_1, null);//call CampaignAI(ZIGGURAT_1,null)
			SetBuildUnit(1, CommonAi.ACOLYTE);//call SetBuildUnit( 1, ACOLYTE			)
			SetBuildUnit(1, CommonAi.NECROPOLIS_1);//call SetBuildUnit( 1, NECROPOLIS_1		)
			SetBuildUnit(1, CommonAi.CRYPT);//call SetBuildUnit( 1, CRYPT				)
			SetBuildUnit(1, CommonAi.GRAVEYARD);//call SetBuildUnit( 1, GRAVEYARD         )
			SetBuildUnit(2, CommonAi.CRYPT);//call SetBuildUnit( 2, CRYPT				)
			CampaignDefender(CommonAi.EASY, 2, CommonAi.CRYPT_FIEND);//call CampaignDefender( EASY, 2, CRYPT_FIEND )
			CampaignDefender(CommonAi.EASY, 2, CommonAi.GHOUL);//call CampaignDefender( EASY, 2, GHOUL       )
			WaitForSignal();//call WaitForSignal()
			//
			CampaignAttacker(CommonAi.EASY, 3, CommonAi.GHOUL);//call CampaignAttacker( EASY,    3, GHOUL	     )
			CampaignAttacker(CommonAi.EASY, 1, CommonAi.PIT_FIEND);//call CampaignAttacker( EASY,    1, PIT_FIEND     )
			SuicideOnPlayer(0, N02_pinkAi.attacked);//call SuicideOnPlayer(0,attacked)
			ForeverSuicideOnPlayer(3*60, N02_pinkAi.attacked);//call ForeverSuicideOnPlayer(3*60,attacked)
		}//endfunction

	
	}
}

