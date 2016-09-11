using System;
using System.Collections.Generic;

namespace Jass {

	public class H06x08Ai {

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
			CampaignDefenderEx(1,1,1, CHAOS_WARLOCK);//call CampaignDefenderEx( 1,1,1, CHAOS_WARLOCK   )
			CampaignDefenderEx(1,1,0, CHAOS_RAIDER);//call CampaignDefenderEx( 1,1,0, CHAOS_RAIDER    )
			CampaignDefenderEx(0,0,1, CHAOS_GROM);//call CampaignDefenderEx( 0,0,1, CHAOS_GROM      )
			SetBuildUpgrEx(0,0,1, UPG_ORC_ARMOR);//call SetBuildUpgrEx( 0,0,1, UPG_ORC_ARMOR       )
			SetBuildUpgrEx(0,0,1, UPG_ORC_MELEE);//call SetBuildUpgrEx( 0,0,1, UPG_ORC_MELEE       )
			SetBuildUpgrEx(1,1,1, UPG_ORC_SPIKES);//call SetBuildUpgrEx( 1,1,1, UPG_ORC_SPIKES      )
			WaitForSignal();//call WaitForSignal()
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(5,5,6, CHAOS_RAIDER);//call CampaignAttackerEx( 5,5,6, CHAOS_RAIDER    )
			SuicideOnUnitsEx(M2,M2,M2,user);//call SuicideOnUnitsEx(M2,M2,M2,user)
			while (true) {//loop
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(4,4,5, CHAOS_RAIDER);//call CampaignAttackerEx( 4,4,5, CHAOS_RAIDER    )
				CampaignAttackerEx(0,0,1, CHAOS_GROM);//call CampaignAttackerEx( 0,0,1, CHAOS_GROM      )
				SuicideOnUnitsEx(M5,M5,M3,user);//call SuicideOnUnitsEx(M5,M5,M3,user)
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(2,2,4, CHAOS_GRUNT);//call CampaignAttackerEx( 2,2,4, CHAOS_GRUNT     )
				CampaignAttackerEx(3,3,4, CHAOS_RAIDER);//call CampaignAttackerEx( 3,3,4, CHAOS_RAIDER    )
				CampaignAttackerEx(1,1,2, CHAOS_WARLOCK);//call CampaignAttackerEx( 1,1,2, CHAOS_WARLOCK   )
				SuicideOnUnitsEx(M5,M5,M3,user);//call SuicideOnUnitsEx(M5,M5,M3,user)
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(3,3,5, CHAOS_RAIDER);//call CampaignAttackerEx( 3,3,5, CHAOS_RAIDER    )
				CampaignAttackerEx(1,1,2, CHAOS_WARLOCK);//call CampaignAttackerEx( 1,1,2, CHAOS_WARLOCK   )
				CampaignAttackerEx(0,0,1, CHAOS_GROM);//call CampaignAttackerEx( 0,0,1, CHAOS_GROM      )
				SuicideOnUnitsEx(M5,M5,M3,user);//call SuicideOnUnitsEx(M5,M5,M3,user)
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(5,5,6, CHAOS_GRUNT);//call CampaignAttackerEx( 5,5,6, CHAOS_GRUNT     )
				CampaignAttackerEx(2,2,4, CHAOS_WARLOCK);//call CampaignAttackerEx( 2,2,4, CHAOS_WARLOCK   )
				CampaignAttackerEx(1,1,1, CHAOS_KODO);//call CampaignAttackerEx( 1,1,1, CHAOS_KODO      )
				SuicideOnUnitsEx(M5,M5,M3,user);//call SuicideOnUnitsEx(M5,M5,M3,user)
			}//endloop
		}//endfunction

	
	}
}

