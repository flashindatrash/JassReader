using System;
using System.Collections.Generic;

namespace Jass {

	public class U03_tealAi {

		//
		//
		//
		public static player user = Player(3);//player user = Player(3)
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(CommonAi.ELF_FARM, null);//call CampaignAI(ELF_FARM,null)
			SetReplacements(1, 1, 3);//call SetReplacements(1,1,3)
			do_campaign_farms = false;//set do_campaign_farms = false
			SetBuildUnitEx(0, 0, 1, CommonAi.TOWN_HALL);//call SetBuildUnitEx( 0,0,1, TOWN_HALL         )
			SetBuildUnitEx(2, 2, 2, CommonAi.PEASANT);//call SetBuildUnitEx( 2,2,2, PEASANT           )
			SetBuildUnitEx(0, 0, 1, CommonAi.ELF_HIGH_BARRACKS);//call SetBuildUnitEx( 0,0,1, ELF_HIGH_BARRACKS )
			SetBuildUnitEx(3, 3, 3, CommonAi.PEASANT);//call SetBuildUnitEx( 3,3,3, PEASANT           )
			SetBuildUnitEx(0, 0, 1, CommonAi.LUMBER_MILL);//call SetBuildUnitEx( 0,0,1, LUMBER_MILL       )
			SetBuildUnitEx(0, 0, 1, CommonAi.BLACKSMITH);//call SetBuildUnitEx( 0,0,1, BLACKSMITH	      )
			SetBuildUnitEx(0, 0, 1, CommonAi.KEEP);//call SetBuildUnitEx( 0,0,1, KEEP		      )
			SetBuildUnitEx(0, 0, 1, CommonAi.SANCTUM);//call SetBuildUnitEx( 0,0,1, SANCTUM           )
			CampaignDefenderEx(1, 1, 2, CommonAi.HIGH_SWORDMAN);//call CampaignDefenderEx( 1,1,2, HIGH_SWORDMAN )
			CampaignDefenderEx(0, 0, 5, CommonAi.HIGH_ARCHER);//call CampaignDefenderEx( 0,0,5, HIGH_ARCHER   )
			CampaignDefenderEx(1, 1, 2, CommonAi.PRIEST);//call CampaignDefenderEx( 1,1,2, PRIEST        )
			SleepForever();//call SleepForever()
		}//endfunction

	
	}
}

