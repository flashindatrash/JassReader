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
			CampaignAI(ZIGGURAT_1,null);//call CampaignAI(ZIGGURAT_1,null)
			SetReplacements(0,0,0);//call SetReplacements(0,0,0)
			SetCaptainHome(DEFENSE_CAPTAIN,2013,568);//call SetCaptainHome(DEFENSE_CAPTAIN,2013,568)
			SetCaptainHome(ATTACK_CAPTAIN,2010,570);//call SetCaptainHome(ATTACK_CAPTAIN,2010,570)
			CampaignDefenderEx(0,0,1, GHOUL);//call CampaignDefenderEx( 0,0,1, GHOUL       )
			WaitForSignal();//call WaitForSignal()
			//
			CampaignAttacker(EASY,    4, GARGOYLE);//call CampaignAttacker( EASY,    4, GARGOYLE		)
			SuicideOnPlayer(M3,attacked);//call SuicideOnPlayer(M3,attacked)
			ForeverSuicideOnPlayer(M2,attacked);//call ForeverSuicideOnPlayer(M2,attacked)
		}//endfunction

	
	}
}

