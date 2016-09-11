using System;
using System.Collections.Generic;

namespace Jass {

	public class H06x07Ai {

		//
		//
		//
		public static player user = PlayerEx(1);//player user = PlayerEx(1)
		public const int NERATHOR = 'O000';//constant integer NERATHOR       = 'O000'
		public const int ORC_JUGG = 'ojgn';//constant integer ORC_JUGG       = 'ojgn'
		public const int ORC_FRIGATE = 'odes';//constant integer ORC_FRIGATE    = 'odes'
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(BURROW,null);//call CampaignAI(BURROW,null)
			SetReplacements(1,1,3);//call SetReplacements(1,1,3)
			campaign_wood_peons = 3;//set campaign_wood_peons = 3
			SetCaptainHome(BOTH_CAPTAINS,2167,8137);//call SetCaptainHome(BOTH_CAPTAINS,2167,8137)
			CampaignDefenderEx(1,1,1, CHAOS_GRUNT);//call CampaignDefenderEx( 1,1,1, CHAOS_GRUNT     )
			CampaignDefenderEx(1,1,1, CHAOS_WARLOCK);//call CampaignDefenderEx( 1,1,1, CHAOS_WARLOCK   )
			CampaignDefenderEx(1,1,1, CHAOS_KODO);//call CampaignDefenderEx( 1,1,1, CHAOS_KODO      )
			CampaignDefenderEx(0,0,1, NERATHOR);//call CampaignDefenderEx( 0,0,1, NERATHOR        )
			SetBuildUpgrEx(0,0,1, UPG_ORC_ARMOR);//call SetBuildUpgrEx( 0,0,1, UPG_ORC_ARMOR       )
			SetBuildUpgrEx(0,0,1, UPG_ORC_MELEE);//call SetBuildUpgrEx( 0,0,1, UPG_ORC_MELEE       )
			SetBuildUpgrEx(1,1,1, UPG_ORC_SPIKES);//call SetBuildUpgrEx( 1,1,1, UPG_ORC_SPIKES      )
			WaitForSignal();//call WaitForSignal()
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2,2,4, CHAOS_GRUNT);//call CampaignAttackerEx( 2,2,4, CHAOS_GRUNT     )
			CampaignAttackerEx(0,0,1, NERATHOR);//call CampaignAttackerEx( 0,0,1, NERATHOR        )
			SuicideOnUnitsEx(M2,M2,M2,user);//call SuicideOnUnitsEx(M2,M2,M2,user)
			while (true) {//loop
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(3,3,5, CHAOS_GRUNT);//call CampaignAttackerEx( 3,3,5, CHAOS_GRUNT     )
				CampaignAttackerEx(1,1,1, CHAOS_KODO);//call CampaignAttackerEx( 1,1,1, CHAOS_KODO      )
				CampaignAttackerEx(1,1,2, CHAOS_WARLOCK);//call CampaignAttackerEx( 1,1,2, CHAOS_WARLOCK   )
				SuicideOnUnitsEx(M5,M5,M3,user);//call SuicideOnUnitsEx(M5,M5,M3,user)
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(3,3,4, CHAOS_GRUNT);//call CampaignAttackerEx( 3,3,4, CHAOS_GRUNT     )
				CampaignAttackerEx(1,1,1, NERATHOR);//call CampaignAttackerEx( 1,1,1, NERATHOR        )
				CampaignAttackerEx(1,1,2, CHAOS_WARLOCK);//call CampaignAttackerEx( 1,1,2, CHAOS_WARLOCK   )
				SuicideOnUnitsEx(M5,M5,M3,user);//call SuicideOnUnitsEx(M5,M5,M3,user)
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(3,3,5, CHAOS_GRUNT);//call CampaignAttackerEx( 3,3,5, CHAOS_GRUNT     )
				CampaignAttackerEx(1,1,1, CHAOS_KODO);//call CampaignAttackerEx( 1,1,1, CHAOS_KODO      )
				CampaignAttackerEx(1,1,2, CHAOS_WARLOCK);//call CampaignAttackerEx( 1,1,2, CHAOS_WARLOCK   )
				SuicideOnUnitsEx(M5,M5,M3,user);//call SuicideOnUnitsEx(M5,M5,M3,user)
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(6,6,8, CHAOS_GRUNT);//call CampaignAttackerEx( 6,6,8, CHAOS_GRUNT     )
				CampaignAttackerEx(3,3,4, CHAOS_WARLOCK);//call CampaignAttackerEx( 3,3,4, CHAOS_WARLOCK   )
				CampaignAttackerEx(0,0,1, NERATHOR);//call CampaignAttackerEx( 0,0,1, NERATHOR        )
				SuicideOnUnitsEx(M5,M5,M3,user);//call SuicideOnUnitsEx(M5,M5,M3,user)
			}//endloop
		}//endfunction

	
	}
}

