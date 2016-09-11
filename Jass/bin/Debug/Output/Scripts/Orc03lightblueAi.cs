using System;
using System.Collections.Generic;

namespace Jass {

	public class Orc03lightblueAi {

		//
		//
		//
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(null);//call CampaignAI(null)
			SetBuildUnit(1, CommonAi.PEASANT);//call SetBuildUnit( 1, PEASANT       )
			SetBuildUnit(1, CommonAi.TOWN_HALL);//call SetBuildUnit( 1, TOWN_HALL     )
			SetBuildUnit(1, CommonAi.KEEP);//call SetBuildUnit( 1, KEEP          )
			SetBuildUnit(1, CommonAi.BARRACKS);//call SetBuildUnit( 1, BARRACKS      )
			SetBuildUnit(4, CommonAi.FOOTMEN);//call SetBuildUnit( 4, FOOTMEN       )
			SetBuildUnit(1, CommonAi.CHURCH);//call SetBuildUnit( 1, CHURCH        )
			SetBuildUnit(1, CommonAi.PRIEST);//call SetBuildUnit( 1, PRIEST        )
			SetBuildUnit(1, CommonAi.SANCTUM);//call SetBuildUnit( 1, SANCTUM       )
			SetBuildUnit(1, CommonAi.SORCERESS);//call SetBuildUnit( 1, SORCERESS     )
			SetBuildUnit(3, CommonAi.PEASANT);//call SetBuildUnit( 3, PEASANT       )
			SetAssaultGroup(4, 4, CommonAi.FOOTMEN);//call SetAssaultGroup( 4, 4, FOOTMEN     )
			SetAssaultGroup(1, 1, CommonAi.PRIEST);//call SetAssaultGroup( 1, 1, PRIEST      )
			SetAssaultGroup(1, 1, CommonAi.SORCERESS);//call SetAssaultGroup( 1, 1, SORCERESS   )
			SuicideOnPlayer(1*60, Player(0));//call SuicideOnPlayer(1*60,Player(0))
			while (true) {//loop
				SuicideOnPlayer(6*60, Player(0));//call SuicideOnPlayer(6*60,Player(0))
			}//endloop
		}//endfunction

	
	}
}

