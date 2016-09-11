using System;
using System.Collections.Generic;

namespace Jass {

	public class N08_Light_BlueAi {

		//
		//
		//
		public static player user = Player(8);//player user = Player(8)
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(HOUSE,null);//call CampaignAI(HOUSE,null)
			SetBuildUnit(1, TOWN_HALL);//call SetBuildUnit( 1, TOWN_HALL     )
			SetBuildUnit(2, PEASANT);//call SetBuildUnit( 2, PEASANT       )
			SetBuildUnit(2, BARRACKS);//call SetBuildUnit( 2, BARRACKS      )
			SetBuildUnit(1, HUMAN_ALTAR);//call SetBuildUnit( 1, HUMAN_ALTAR   )
			SetBuildUnit(1, LUMBER_MILL);//call SetBuildUnit( 1, LUMBER_MILL   )
			SetBuildUnit(1, BLACKSMITH);//call SetBuildUnit( 1, BLACKSMITH    )
			SetBuildUnit(7, PEASANT);//call SetBuildUnit( 7, PEASANT       )
			SetBuildUnit(10, HOUSE);//call SetBuildUnit( 10, HOUSE		)
			SetBuildUnit(1, WORKSHOP);//call SetBuildUnit( 1, WORKSHOP      )
			SetBuildUnit(1, KEEP);//call SetBuildUnit( 1, KEEP          )
			SetBuildUnit(3, GUARD_TOWER);//call SetBuildUnit( 3, GUARD_TOWER	)
			SetBuildUnit(1, SANCTUM);//call SetBuildUnit( 1, SANCTUM       )
			SetBuildUnit(5, HOUSE);//call SetBuildUnit( 5, HOUSE	    	)
			SetBuildUnit(1, CASTLE);//call SetBuildUnit( 1, CASTLE        )
			CampaignDefender(EASY, 4, FOOTMAN);//call CampaignDefender (EASY, 4, FOOTMAN     )
			CampaignDefender(EASY, 1, KNIGHT);//call CampaignDefender (EASY, 1, KNIGHT      )
			CampaignDefender(EASY, 2, RIFLEMAN);//call CampaignDefender (EASY, 2, RIFLEMAN    )
			CampaignDefender(EASY, 1, COPTER);//call CampaignDefender (EASY, 1, COPTER		)
			CampaignDefender(EASY, 1, JAINA);//call CampaignDefender (EASY, 1, JAINA       )
		}//endfunction

	
	}
}

