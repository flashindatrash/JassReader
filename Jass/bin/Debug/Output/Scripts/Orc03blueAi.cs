using System;
using System.Collections.Generic;

namespace Jass {

	public class Orc03blueAi {

		//
		//
		//
		private int heroes() {//function heroes takes nothing returns integer
			int level = GetHeroLevelAI();//local integer level = GetHeroLevelAI()
			if (level == 2 || level == 6 || level == 9) {//if level == 2 or level == 6 or level == 9 then
				return 'AHwe';//return 'AHwe'
			}//endif
			if (level == 3 || level == 5 || level == 8) {//if level == 3 or level == 5 or level == 8 then
				return 'AHbz';//return 'AHbz'
			}//endif
			if (level == 7) {//if level == 7 then
				return 'AHmt';//return 'AHmt'
			}//endif
			return 'AHab';//return 'AHab'
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
			SetBuildUnit(1, ARCHMAGE);//call SetBuildUnit( 1, ARCHMAGE      )
			SetBuildUnit(1, BARRACKS);//call SetBuildUnit( 1, BARRACKS      )
			SetBuildUnit(2, FOOTMEN);//call SetBuildUnit( 2, FOOTMEN       )
			SetBuildUnit(1, BLACKSMITH);//call SetBuildUnit( 1, BLACKSMITH    )
			SetBuildUnit(2, RIFLEMEN);//call SetBuildUnit( 2, RIFLEMEN      )
			SetBuildUnit(1, CHURCH);//call SetBuildUnit( 1, CHURCH        )
			SetBuildUnit(1, PRIEST);//call SetBuildUnit( 1, PRIEST        )
			SetBuildUnit(3, PEASANT);//call SetBuildUnit( 3, PEASANT       )
			SetAssaultGroup(1, 1, ARCHMAGE);//call SetAssaultGroup( 1, 1, ARCHMAGE    )
			SetAssaultGroup(2, 2, FOOTMEN);//call SetAssaultGroup( 2, 2, FOOTMEN     )
			SetAssaultGroup(2, 2, RIFLEMEN);//call SetAssaultGroup( 2, 2, RIFLEMEN    )
			SetAssaultGroup(1, 1, PRIEST);//call SetAssaultGroup( 1, 1, PRIEST      )
			SuicideOnPlayer(1*60,Player(0));//call SuicideOnPlayer(1*60,Player(0))
			while (true) {//loop
				SuicideOnPlayer(9*60,Player(0));//call SuicideOnPlayer(9*60,Player(0))
			}//endloop
		}//endfunction

	
	}
}

