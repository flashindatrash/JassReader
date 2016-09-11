using System;
using System.Collections.Generic;

namespace Jass {

	public class U03_grayAi {

		//
		//
		//
		public static player user = Player(3);//player user = Player(3)
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(CommonAi.HOUSE, null);//call CampaignAI(HOUSE,null)
			SetReplacements(0, 1, 3);//call SetReplacements(0,1,3)
			SetBuildUnitEx(0, 0, 0, CommonAi.TOWN_HALL);//call SetBuildUnitEx( 0,0,0, TOWN_HALL       )
			SetBuildUnitEx(0, 0, 0, CommonAi.PEASANT);//call SetBuildUnitEx( 0,0,0, PEASANT         )
			SetBuildUnitEx(0, 0, 1, CommonAi.BARRACKS);//call SetBuildUnitEx( 0,0,1, BARRACKS		)
			SetBuildUnitEx(0, 0, 8, CommonAi.HOUSE);//call SetBuildUnitEx( 0,0,8, HOUSE			)
			SetBuildUnitEx(0, 0, 1, CommonAi.WORKSHOP);//call SetBuildUnitEx( 0,0,1, WORKSHOP	    )
			SetBuildUnitEx(0, 0, 1, CommonAi.BLACKSMITH);//call SetBuildUnitEx( 0,0,1, BLACKSMITH      )
			CampaignDefenderEx(1, 1, 3, CommonAi.RIFLEMEN);//call CampaignDefenderEx( 1,1,3, RIFLEMEN )
			CampaignDefenderEx(0, 1, 2, CommonAi.MORTAR);//call CampaignDefenderEx( 0,1,2, MORTAR  )
			SleepForever();//call SleepForever()
		}//endfunction

	
	}
}

