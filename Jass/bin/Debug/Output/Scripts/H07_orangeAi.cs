using System;
using System.Collections.Generic;

namespace Jass {

	public class H07_orangeAi {

		//
		//
		//
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(ZIGGURAT_1,null);//call CampaignAI(ZIGGURAT_1,null)
			SetBuildUnit(1, ACOLYTE);//call SetBuildUnit( 1, ACOLYTE			)
			SetBuildUnit(1, NECROPOLIS_1);//call SetBuildUnit( 1, NECROPOLIS_1		)
			SetBuildUnit(1, CRYPT);//call SetBuildUnit( 1, CRYPT				)
			SetBuildUnit(1, GRAVEYARD);//call SetBuildUnit( 1, GRAVEYARD         )
			SetBuildUnit(2, CRYPT);//call SetBuildUnit( 2, CRYPT				)
			CampaignDefender(EASY, 2, CRYPT_FIEND);//call CampaignDefender( EASY, 2, CRYPT_FIEND )
			CampaignDefender(EASY, 2, GHOUL);//call CampaignDefender( EASY, 2, GHOUL       )
			WaitForSignal();//call WaitForSignal()
			//
			CampaignAttacker(EASY,    3, GHOUL);//call CampaignAttacker( EASY,    3, GHOUL	     )
			CampaignAttacker(EASY,    1, PIT_FIEND);//call CampaignAttacker( EASY,    1, PIT_FIEND     )
			SuicideOnPlayer(0,attacked);//call SuicideOnPlayer(0,attacked)
			ForeverSuicideOnPlayer(3*60,attacked);//call ForeverSuicideOnPlayer(3*60,attacked)
		}//endfunction

	
	}
}

