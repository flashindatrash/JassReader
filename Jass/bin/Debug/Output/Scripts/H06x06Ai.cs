using System;
using System.Collections.Generic;

namespace Jass {

	public class H06x06Ai {

		//
		//
		//
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(BURROW,null);//call CampaignAI(BURROW,null)
			SetReplacements(1,1,3);//call SetReplacements(1,1,3)
			campaign_wood_peons = 3;//set campaign_wood_peons = 3
			SetBuildUnitEx(3,3,3, CHAOS_PEON);//call SetBuildUnitEx ( 3,3,3, CHAOS_PEON         )
			CampaignDefenderEx(0,0,1, CHAOS_GRUNT);//call CampaignDefenderEx( 0,0,1, CHAOS_GRUNT     )
			CampaignDefenderEx(0,0,1, CHAOS_WARLOCK);//call CampaignDefenderEx( 0,0,1, CHAOS_WARLOCK   )
			CampaignDefenderEx(1,1,0, CHAOS_RAIDER);//call CampaignDefenderEx( 1,1,0, CHAOS_RAIDER    )
			CampaignDefenderEx(0,0,1, CHAOS_BLADEMASTER);//call CampaignDefenderEx( 0,0,1, CHAOS_BLADEMASTER)
			WaitForSignal();//call WaitForSignal()
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(3,3,4, CHAOS_RAIDER);//call CampaignAttackerEx( 3,3,4, CHAOS_RAIDER    )
			SuicideOnUnitsEx(M2,M2,M2,user);//call SuicideOnUnitsEx(M2,M2,M2,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(3,3,4, CHAOS_GRUNT);//call CampaignAttackerEx( 3,3,4, CHAOS_GRUNT     )
			CampaignAttackerEx(2,2,3, CHAOS_RAIDER);//call CampaignAttackerEx( 2,2,3, CHAOS_RAIDER    )
			SuicideOnUnitsEx(M5,M5,M3,user);//call SuicideOnUnitsEx(M5,M5,M3,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2,2,3, CHAOS_GRUNT);//call CampaignAttackerEx( 2,2,3, CHAOS_GRUNT     )
			CampaignAttackerEx(1,1,2, CHAOS_RAIDER);//call CampaignAttackerEx( 1,1,2, CHAOS_RAIDER    )
			CampaignAttackerEx(1,1,2, CHAOS_WARLOCK);//call CampaignAttackerEx( 1,1,2, CHAOS_WARLOCK   )
			SuicideOnUnitsEx(M5,M5,M3,user);//call SuicideOnUnitsEx(M5,M5,M3,user)
			while (true) {//loop
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(3,3,5, CHAOS_GRUNT);//call CampaignAttackerEx( 3,3,5, CHAOS_GRUNT     )
				CampaignAttackerEx(0,0,1, CHAOS_BLADEMASTER);//call CampaignAttackerEx( 0,0,1, CHAOS_BLADEMASTER)
				CampaignAttackerEx(1,1,2, CHAOS_WARLOCK);//call CampaignAttackerEx( 1,1,2, CHAOS_WARLOCK   )
				SuicideOnUnitsEx(M5,M5,M3,user);//call SuicideOnUnitsEx(M5,M5,M3,user)
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(2,2,4, CHAOS_GRUNT);//call CampaignAttackerEx( 2,2,4, CHAOS_GRUNT     )
				CampaignAttackerEx(2,2,4, CHAOS_RAIDER);//call CampaignAttackerEx( 2,2,4, CHAOS_RAIDER    )
				CampaignAttackerEx(1,1,2, CHAOS_WARLOCK);//call CampaignAttackerEx( 1,1,2, CHAOS_WARLOCK   )
				SuicideOnUnitsEx(M5,M5,M3,user);//call SuicideOnUnitsEx(M5,M5,M3,user)
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(4,4,6, CHAOS_RAIDER);//call CampaignAttackerEx( 4,4,6, CHAOS_RAIDER    )
				CampaignAttackerEx(0,0,1, CHAOS_BLADEMASTER);//call CampaignAttackerEx( 0,0,1, CHAOS_BLADEMASTER)
				SuicideOnUnitsEx(M5,M5,M3,user);//call SuicideOnUnitsEx(M5,M5,M3,user)
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(4,4,6, CHAOS_GRUNT);//call CampaignAttackerEx( 4,4,6, CHAOS_GRUNT     )
				CampaignAttackerEx(2,2,4, CHAOS_WARLOCK);//call CampaignAttackerEx( 2,2,4, CHAOS_WARLOCK   )
				SuicideOnUnitsEx(M5,M5,M3,user);//call SuicideOnUnitsEx(M5,M5,M3,user)
			}//endloop
		}//endfunction

	
	}
}

