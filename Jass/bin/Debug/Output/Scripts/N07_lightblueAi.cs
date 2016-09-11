using System;
using System.Collections.Generic;

namespace Jass {

	public class N07_lightblueAi {

		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(CommonAi.HOUSE, null);//call CampaignAI(HOUSE,null)
			SetReplacements(1, 1, 0);//call SetReplacements(1,1,0)
			SetGroupsFlee(true);//call SetGroupsFlee(true)
			SetHeroesFlee(true);//call SetHeroesFlee(true)
			SetUnitsFlee(true);//call SetUnitsFlee(true)
			SetPeonsRepair(true);//call SetPeonsRepair(true)
			SetSlowChopping(false);//call SetSlowChopping(false)
			SetBuildUnit(1, CommonAi.PEASANT);//call SetBuildUnit( 1, PEASANT       )
			SetBuildUnit(1, CommonAi.BARRACKS);//call SetBuildUnit( 1, BARRACKS      )
			SetBuildUnit(2, CommonAi.PEASANT);//call SetBuildUnit( 2, PEASANT       )
			SetBuildUnit(1, CommonAi.LUMBER_MILL);//call SetBuildUnit( 1, LUMBER_MILL   )
			SetBuildUnit(3, CommonAi.PEASANT);//call SetBuildUnit( 3, PEASANT       )
			SetBuildUnit(1, CommonAi.BLACKSMITH);//call SetBuildUnit( 1, BLACKSMITH    )
			SetBuildUnit(1, CommonAi.HUMAN_ALTAR);//call SetBuildUnit( 1, HUMAN_ALTAR   )
			SetBuildUnit(1, CommonAi.WORKSHOP);//call SetBuildUnit( 1, WORKSHOP      )
			SetBuildUnit(1, CommonAi.SANCTUM);//call SetBuildUnit( 1, SANCTUM       )
			SetBuildUnit(8, CommonAi.PEASANT);//call SetBuildUnit( 8, PEASANT       )
			CampaignDefenderEx(1, 1, 1, CommonAi.JAINA);//call CampaignDefenderEx( 1,1,1, JAINA       )
			CampaignDefenderEx(0, 0, 1, CommonAi.FOOTMEN);//call CampaignDefenderEx( 0,0,1, FOOTMEN     )
			CampaignDefenderEx(1, 1, 0, CommonAi.KNIGHT);//call CampaignDefenderEx( 1,1,0, KNIGHT		)
			CampaignDefenderEx(1, 1, 1, CommonAi.RIFLEMEN);//call CampaignDefenderEx( 1,1,1, RIFLEMEN    )
			CampaignDefenderEx(1, 1, 1, CommonAi.PRIEST);//call CampaignDefenderEx( 1,1,1, PRIEST      )
			CampaignDefenderEx(1, 1, 1, CommonAi.SORCERESS);//call CampaignDefenderEx( 1,1,1, SORCERESS   )
			while (true) {//loop
				if (GetUnitCount(CASTLE)==0) { break; }//exitwhen GetUnitCount(CASTLE)==0
				Sleep(5);//call Sleep(5)
			}//endloop
			InitBuildArray();//call InitBuildArray()
			do_campaign_farms = false;//set do_campaign_farms   = false
			campaign_gold_peons = 0;//set campaign_gold_peons = 0
			campaign_wood_peons = 0;//set campaign_wood_peons = 0
			SleepForever();//call SleepForever()
		}//endfunction

	
	}
}

