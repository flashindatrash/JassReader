using System;
using System.Collections.Generic;

namespace Jass {

	public class N07_redAi {

		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(CommonAi.BURROW, null);//call CampaignAI(BURROW,null)
			SetReplacements(1, 1, 0);//call SetReplacements(1,1,0)
			SetGroupsFlee(true);//call SetGroupsFlee(true)
			SetHeroesFlee(true);//call SetHeroesFlee(true)
			SetUnitsFlee(true);//call SetUnitsFlee(true)
			SetPeonsRepair(true);//call SetPeonsRepair(true)
			SetSlowChopping(false);//call SetSlowChopping(false)
			SetBuildUnit(1, CommonAi.PEON);//call SetBuildUnit( 1, PEON          )
			SetBuildUnit(1, CommonAi.ORC_BARRACKS);//call SetBuildUnit( 1, ORC_BARRACKS  )
			SetBuildUnit(2, CommonAi.PEON);//call SetBuildUnit( 2, PEON          )
			SetBuildUnit(1, CommonAi.FORGE);//call SetBuildUnit( 1, FORGE         )
			SetBuildUnit(3, CommonAi.PEON);//call SetBuildUnit( 3, PEON          )
			SetBuildUnit(1, CommonAi.ORC_ALTAR);//call SetBuildUnit( 1, ORC_ALTAR     )
			SetBuildUnit(1, CommonAi.BESTIARY);//call SetBuildUnit( 1, BESTIARY      )
			SetBuildUnit(1, CommonAi.LODGE);//call SetBuildUnit( 1, LODGE         )
			SetBuildUnit(1, CommonAi.TOTEM);//call SetBuildUnit( 1, TOTEM         )
			SetBuildUnit(8, CommonAi.PEON);//call SetBuildUnit( 8, PEON          )
			CampaignDefenderEx(1, 1, 1, CommonAi.THRALL);//call CampaignDefenderEx( 1,1,1, THRALL          )
			CampaignDefenderEx(0, 0, 1, CommonAi.GRUNT);//call CampaignDefenderEx( 0,0,1, GRUNT           )
			CampaignDefenderEx(1, 1, 0, CommonAi.TAUREN);//call CampaignDefenderEx( 1,1,0, TAUREN          )
			CampaignDefenderEx(1, 1, 1, CommonAi.HEAD_HUNTER);//call CampaignDefenderEx( 1,1,1, HEAD_HUNTER     )
			CampaignDefenderEx(1, 1, 1, CommonAi.WITCH_DOCTOR);//call CampaignDefenderEx( 1,1,1, WITCH_DOCTOR    )
			CampaignDefenderEx(1, 1, 1, CommonAi.SHAMAN);//call CampaignDefenderEx( 1,1,1, SHAMAN          )
			while (true) {//loop
				if (GetUnitCount(FORTRESS)==0) { break; }//exitwhen GetUnitCount(FORTRESS)==0
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

