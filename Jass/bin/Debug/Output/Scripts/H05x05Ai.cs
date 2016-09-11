using System;
using System.Collections.Generic;

namespace Jass {

	public class H05x05Ai {

		//
		//
		//
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(CHAOS_BURROW,null);//call CampaignAI(CHAOS_BURROW,null)
			SetReplacements(1,1,3);//call SetReplacements(1,1,3)
			DoCampaignFarms(false);//call DoCampaignFarms(false)
			SetBuildUnit(6, CHAOS_PEON);//call SetBuildUnit	( 6, CHAOS_PEON				)
			CampaignDefenderEx(0,0,2, CHAOS_GRUNT);//call CampaignDefenderEx( 0,0,2, CHAOS_GRUNT     )
			CampaignDefenderEx(1,1,2, CHAOS_WARLOCK);//call CampaignDefenderEx( 1,1,2, CHAOS_WARLOCK	)
			CampaignDefenderEx(1,1,1, CHAOS_RAIDER);//call CampaignDefenderEx( 1,1,1, CHAOS_RAIDER	)
			SetBuildUpgrEx(0,0,1, UPG_ORC_ARMOR);//call SetBuildUpgrEx( 0,0,1, UPG_ORC_ARMOR		)
			SetBuildUpgrEx(0,0,1, UPG_ORC_MELEE);//call SetBuildUpgrEx( 0,0,1, UPG_ORC_MELEE		)
			SetBuildUpgrEx(1,1,1, UPG_ORC_BURROWS);//call SetBuildUpgrEx( 1,1,1, UPG_ORC_BURROWS		)
			SetBuildUpgrEx(1,1,1, UPG_ORC_ENSNARE);//call SetBuildUpgrEx( 1,1,1, UPG_ORC_ENSNARE		)
			SetBuildUpgrEx(3,3,3, UPG_ORC_SPIKES);//call SetBuildUpgrEx( 3,3,3, UPG_ORC_SPIKES		)
			WaitForSignal();//call WaitForSignal()
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(3,3,3, CHAOS_GRUNT);//call CampaignAttackerEx( 3,3,3, CHAOS_GRUNT		)
			SuicideOnPlayer(M2,user);//call SuicideOnPlayer(M2,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(3,3,3, CHAOS_RAIDER);//call CampaignAttackerEx( 3,3,3, CHAOS_RAIDER	)
			SuicideOnPlayerEx(M1,M1,M1,user);//call SuicideOnPlayerEx(M1,M1,M1,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2,2,2, CHAOS_GRUNT);//call CampaignAttackerEx( 2,2,2, CHAOS_GRUNT     )
			CampaignAttackerEx(1,1,1, CHAOS_WARLOCK);//call CampaignAttackerEx( 1,1,1, CHAOS_WARLOCK   )
			SuicideOnPlayerEx(M1,M1,M1,user);//call SuicideOnPlayerEx(M1,M1,M1,user)
			while (true) {//loop
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(3,3,3, CHAOS_GRUNT);//call CampaignAttackerEx( 3,3,3, CHAOS_GRUNT     )
				CampaignAttackerEx(1,1,1, CHAOS_KODO);//call CampaignAttackerEx( 1,1,1, CHAOS_KODO		)
				SuicideOnPlayerEx(M1,M1,M1,user);//call SuicideOnPlayerEx(M1,M1,M1,user)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(3,3,3, CHAOS_RAIDER);//call CampaignAttackerEx( 3,3,3, CHAOS_RAIDER	)
				SuicideOnPlayerEx(M1,M1,M1,user);//call SuicideOnPlayerEx(M1,M1,M1,user)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(2,2,2, CHAOS_GRUNT);//call CampaignAttackerEx( 2,2,2, CHAOS_GRUNT     )
				CampaignAttackerEx(1,1,1, CHAOS_WARLOCK);//call CampaignAttackerEx( 1,1,1, CHAOS_WARLOCK   )
				SuicideOnPlayerEx(M1,M1,M1,user);//call SuicideOnPlayerEx(M1,M1,M1,user)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(2,2,2, CHAOS_GRUNT);//call CampaignAttackerEx( 2,2,2, CHAOS_GRUNT		)
				CampaignAttackerEx(2,2,2, CHAOS_RAIDER);//call CampaignAttackerEx( 2,2,2, CHAOS_RAIDER	)
				SuicideOnPlayerEx(M1,M1,M1,user);//call SuicideOnPlayerEx(M1,M1,M1,user)
			}//endloop
		}//endfunction

	
	}
}

