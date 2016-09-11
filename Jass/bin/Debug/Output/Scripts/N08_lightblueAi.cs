using System;
using System.Collections.Generic;

namespace Jass {

	public class N08_lightblueAi {

		//
		//
		//
		public static player user = Player(8);//player user = Player(8)
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(CommonAi.HOUSE, null);//call CampaignAI(HOUSE,null)
			SetBuildUnit(1, CommonAi.TOWN_HALL);//call SetBuildUnit( 1, TOWN_HALL     )
			SetBuildUnit(2, CommonAi.PEASANT);//call SetBuildUnit( 2, PEASANT       )
			SetBuildUnit(2, CommonAi.BARRACKS);//call SetBuildUnit( 2, BARRACKS      )
			SetBuildUnit(1, CommonAi.HUMAN_ALTAR);//call SetBuildUnit( 1, HUMAN_ALTAR   )
			SetBuildUnit(1, CommonAi.LUMBER_MILL);//call SetBuildUnit( 1, LUMBER_MILL   )
			SetBuildUnit(1, CommonAi.BLACKSMITH);//call SetBuildUnit( 1, BLACKSMITH    )
			SetBuildUnit(7, CommonAi.PEASANT);//call SetBuildUnit( 7, PEASANT       )
			SetBuildUnit(10, CommonAi.HOUSE);//call SetBuildUnit( 10, HOUSE		)
			SetBuildUnit(1, CommonAi.WORKSHOP);//call SetBuildUnit( 1, WORKSHOP      )
			SetBuildUnit(1, CommonAi.KEEP);//call SetBuildUnit( 1, KEEP          )
			SetBuildUnit(3, CommonAi.GUARD_TOWER);//call SetBuildUnit( 3, GUARD_TOWER	)
			SetBuildUnit(1, CommonAi.SANCTUM);//call SetBuildUnit( 1, SANCTUM       )
			SetBuildUnit(5, CommonAi.HOUSE);//call SetBuildUnit( 5, HOUSE	    	)
			SetBuildUnit(1, CommonAi.CASTLE);//call SetBuildUnit( 1, CASTLE        )
			CampaignDefender(CommonAi.EASY, 4, CommonAi.FOOTMAN);//call CampaignDefender (EASY, 4, FOOTMAN     )
			CampaignDefender(CommonAi.EASY, 1, CommonAi.KNIGHT);//call CampaignDefender (EASY, 1, KNIGHT      )
			CampaignDefender(CommonAi.EASY, 2, CommonAi.RIFLEMAN);//call CampaignDefender (EASY, 2, RIFLEMAN    )
			CampaignDefender(CommonAi.EASY, 1, CommonAi.COPTER);//call CampaignDefender (EASY, 1, COPTER		)
			CampaignDefender(CommonAi.EASY, 1, CommonAi.JAINA);//call CampaignDefender (EASY, 1, JAINA       )
		}//endfunction

	
	}
}

