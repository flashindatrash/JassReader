using System;
using System.Collections.Generic;

namespace Jass {

	public class U03_brownAi {

		//
		//
		//
		public static player user = Player(3);//player user = Player(3)
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(CommonAi.ELF_FARM, null);//call CampaignAI(ELF_FARM,null)
			SetBuildUnit(1, CommonAi.TOWN_HALL);//call SetBuildUnit( 1, TOWN_HALL         )
			SetBuildUnit(2, CommonAi.PEASANT);//call SetBuildUnit( 2, PEASANT           )
			SetBuildUnit(1, CommonAi.ELF_HIGH_BARRACKS);//call SetBuildUnit( 1, ELF_HIGH_BARRACKS )
			SetBuildUnit(3, CommonAi.PEASANT);//call SetBuildUnit( 3, PEASANT           )
			SetBuildUnit(1, CommonAi.LUMBER_MILL);//call SetBuildUnit( 1, LUMBER_MILL       )
			SetBuildUnit(1, CommonAi.BLACKSMITH);//call SetBuildUnit( 1, BLACKSMITH        )
			SetBuildUnit(7, CommonAi.PEASANT);//call SetBuildUnit( 7, PEASANT           )
			CampaignDefender(CommonAi.EASY, 2, CommonAi.HIGH_FOOTMEN);//call CampaignDefender( EASY, 2, HIGH_FOOTMEN)
			CampaignDefender(CommonAi.EASY, 3, CommonAi.HIGH_ARCHER);//call CampaignDefender( EASY, 3, HIGH_ARCHER )
			CampaignDefender(CommonAi.EASY, 1, CommonAi.PRIEST);//call CampaignDefender( EASY, 1, PRIEST      )
			SleepForever();//call SleepForever()
		}//endfunction

	
	}
}

