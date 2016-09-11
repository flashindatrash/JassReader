using System;
using System.Collections.Generic;

namespace Jass {

	public class H07_purpleAi {

		//
		//
		//
		public static player attacked = Player(8);//player attacked = Player(8)
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(CommonAi.ZIGGURAT_1, null);//call CampaignAI(ZIGGURAT_1,null)
			SetReplacements(1, 1, 3);//call SetReplacements(1,1,3)
			SetBuildUnitEx(0, 0, 1, CommonAi.ACOLYTE);//call SetBuildUnitEx( 0,0,1, ACOLYTE				)
			CampaignDefenderEx(0, 0, 2, CommonAi.CRYPT_FIEND);//call CampaignDefenderEx( 0,0,2, CRYPT_FIEND )
			CampaignDefenderEx(1, 1, 2, CommonAi.GHOUL);//call CampaignDefenderEx( 1,1,2, GHOUL       )
			WaitForSignal();//call WaitForSignal()
			//
			CampaignAttacker(CommonAi.EASY, 2, CommonAi.GHOUL);//call CampaignAttacker( EASY,    2, GHOUL		)
			CampaignAttacker(CommonAi.EASY, 1, CommonAi.CRYPT_FIEND);//call CampaignAttacker( EASY,    1, CRYPT_FIEND	)
			SuicideOnPlayer(0, N02_pinkAi.attacked);//call SuicideOnPlayer(0,attacked)
			ForeverSuicideOnPlayer(3*60, N02_pinkAi.attacked);//call ForeverSuicideOnPlayer(3*60,attacked)
		}//endfunction

	
	}
}

