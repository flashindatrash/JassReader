using System;
using System.Collections.Generic;

namespace Jass {

	public class Orc03warsongAi {

		//
		//
		//
		private int heroes() {//function heroes takes nothing returns integer
			int level = GetHeroLevelAI();//local integer level = GetHeroLevelAI()
			if (level == 2 || level == 3 || level == 7) {//if level == 2 or level == 3 or level == 7 then
				return 'AOcr';//return 'AOcr'
			}//endif
			if (level == 4 || level == 6 || level == 8) {//if level == 4 or level == 6 or level == 8 then
				return 'AOmi';//return 'AOmi'
			}//endif
			if (level == 5) {//if level == 5 then
				return 'AOww';//return 'AOww'
			}//endif
			return 'AOwk';//return 'AOwk'
		}//endfunction
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(function heroes);//call CampaignAI(function heroes)
			SetBuildUnit(1, CommonAi.PEON);//call SetBuildUnit( 1, PEON          )
			SetBuildUnit(1, CommonAi.GREAT_HALL);//call SetBuildUnit( 1, GREAT_HALL    )
			SetBuildUnit(1, CommonAi.STRONGHOLD);//call SetBuildUnit( 1, STRONGHOLD    )
			SetBuildUnit(1, CommonAi.ORC_ALTAR);//call SetBuildUnit( 1, ORC_ALTAR     )
			SetBuildUnit(1, CommonAi.BLADE_MASTER);//call SetBuildUnit( 1, BLADE_MASTER  )
			SetBuildUnit(1, CommonAi.ORC_BARRACKS);//call SetBuildUnit( 1, ORC_BARRACKS  )
			SetBuildUnit(4, CommonAi.GRUNT);//call SetBuildUnit( 4, GRUNT         )
			SetBuildUnit(3, CommonAi.PEON);//call SetBuildUnit( 3, PEON          )
			SetAssaultGroup(1, 1, CommonAi.BLADE_MASTER);//call SetAssaultGroup( 1, 1, BLADE_MASTER   )
			SetAssaultGroup(4, 4, CommonAi.GRUNT);//call SetAssaultGroup( 4, 4, GRUNT          )
			SuicideOnPlayer(0, Player(1));//call SuicideOnPlayer(0,Player(1))
			SuicideOnPlayer(7*60, Player(3));//call SuicideOnPlayer(7*60,Player(3))
			SuicideOnPlayer(8*60, Player(2));//call SuicideOnPlayer(8*60,Player(2))
			SuicideOnPlayer(9*60, Player(9));//call SuicideOnPlayer(9*60,Player(9))
			SleepForever();//call SleepForever()
		}//endfunction

	
	}
}

