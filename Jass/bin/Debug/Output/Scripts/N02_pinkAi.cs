using System;
using System.Collections.Generic;

namespace Jass {

	public class N02_pinkAi {

		//
		//
		//
		public static player attacked = Player(4);//player attacked = Player(4)
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(CommonAi.ZIGGURAT_1, null);//call CampaignAI(ZIGGURAT_1,null)
			SetReplacements(0, 0, 0);//call SetReplacements(0,0,0)
			SetCaptainHome(CommonAi.DEFENSE_CAPTAIN, 2013, 568);//call SetCaptainHome(DEFENSE_CAPTAIN,2013,568)
			SetCaptainHome(CommonAi.ATTACK_CAPTAIN, 2010, 570);//call SetCaptainHome(ATTACK_CAPTAIN,2010,570)
			CampaignDefenderEx(0, 0, 1, CommonAi.GHOUL);//call CampaignDefenderEx( 0,0,1, GHOUL       )
			WaitForSignal();//call WaitForSignal()
			//
			CampaignAttacker(CommonAi.EASY, 4, CommonAi.GARGOYLE);//call CampaignAttacker( EASY,    4, GARGOYLE		)
			SuicideOnPlayer(CommonAi.M3, N02_pinkAi.attacked);//call SuicideOnPlayer(M3,attacked)
			ForeverSuicideOnPlayer(CommonAi.M2, N02_pinkAi.attacked);//call ForeverSuicideOnPlayer(M2,attacked)
		}//endfunction

	
	}
}

