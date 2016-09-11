using System;
using System.Collections.Generic;

namespace Jass {

	public class Orc03tealAi {

		//
		//
		//
		private int heroes() {//function heroes takes nothing returns integer
			int level = GetHeroLevelAI();//local integer level = GetHeroLevelAI()
			if (level == 2 || level == 3 || level == 5) {//if level == 2 or level == 3 or level == 5 then
				return 'AHad';//return 'AHad'
			}//endif
			if (level == 4 || level == 6 || level == 11) {//if level == 4 or level == 6 or level == 11 then
				return 'AHds';//return 'AHds'
			}//endif
			if (level == 9) {//if level == 9 then
				return 'AHre';//return 'AHre'
			}//endif
			return 'AHhb';//return 'AHhb'
		}//endfunction
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(function heroes);//call CampaignAI(function heroes)
			SetBuildUnit(1, PEASANT);//call SetBuildUnit( 1, PEASANT       )
			SetBuildUnit(1, TOWN_HALL);//call SetBuildUnit( 1, TOWN_HALL     )
			SetBuildUnit(1, KEEP);//call SetBuildUnit( 1, KEEP          )
			SetBuildUnit(1, HUMAN_ALTAR);//call SetBuildUnit( 1, HUMAN_ALTAR   )
			SetBuildUnit(1, PALADIN);//call SetBuildUnit( 1, PALADIN       )
			SetBuildUnit(1, BARRACKS);//call SetBuildUnit( 1, BARRACKS      )
			SetBuildUnit(4, FOOTMEN);//call SetBuildUnit( 4, FOOTMEN       )
			SetBuildUnit(1, CHURCH);//call SetBuildUnit( 1, CHURCH        )
			SetBuildUnit(1, PRIEST);//call SetBuildUnit( 1, PRIEST        )
			SetBuildUnit(3, PEASANT);//call SetBuildUnit( 3, PEASANT       )
			SetAssaultGroup(1, 1, PALADIN);//call SetAssaultGroup( 1, 1, PALADIN     )
			SetAssaultGroup(4, 4, FOOTMEN);//call SetAssaultGroup( 4, 4, FOOTMEN     )
			SetAssaultGroup(1, 1, PRIEST);//call SetAssaultGroup( 1, 1, PRIEST      )
			SuicideOnPlayer(1*60,Player(0));//call SuicideOnPlayer(1*60,Player(0))
			while (true) {//loop
				SuicideOnPlayer(7*60,Player(0));//call SuicideOnPlayer(7*60,Player(0))
			}//endloop
		}//endfunction

	
	}
}

