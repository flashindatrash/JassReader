using System;
using System.Collections.Generic;

namespace Jass {

	public class H07_grayAi {

		//
		//
		//
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(CommonAi.HOUSE, null);//call CampaignAI(HOUSE,null)
			SetBuildUnit(1, CommonAi.TOWN_HALL);//call SetBuildUnit( 1, TOWN_HALL 		)
			SetBuildUnit(1, CommonAi.PEASANT);//call SetBuildUnit( 1, PEASANT			)
			SetBuildUnit(1, CommonAi.BARRACKS);//call SetBuildUnit( 1, BARRACKS			)
			SetBuildUnit(1, CommonAi.BLACKSMITH);//call SetBuildUnit( 1, BLACKSMITH		)
			SetBuildUnit(1, CommonAi.KEEP);//call SetBuildUnit( 1, KEEP      		)
			SetBuildUnit(1, CommonAi.WORKSHOP);//call SetBuildUnit( 1, WORKSHOP          )
			SetBuildUnit(2, CommonAi.PEASANT);//call SetBuildUnit( 2, PEASANT			)
			SleepForever();//call SleepForever()
		}//endfunction

	
	}
}

