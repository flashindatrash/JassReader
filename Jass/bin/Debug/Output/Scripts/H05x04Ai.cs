using System;
using System.Collections.Generic;

namespace Jass {

	public class H05x04Ai {

		//
		//
		//
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(CHAOS_BURROW,null);//call CampaignAI(CHAOS_BURROW,null)
			SetReplacements(3,3,5);//call SetReplacements(3,3,5)
			DoCampaignFarms(false);//call DoCampaignFarms(false)
			SetBuildUnitEx(0,0,1, GREAT_HALL);//call SetBuildUnitEx	( 0,0,1, GREAT_HALL			)
			SetBuildUnit(1, CHAOS_PEON);//call SetBuildUnit	( 1, CHAOS_PEON				)
			SetBuildUnitEx(0,0,2, ORC_BARRACKS);//call SetBuildUnitEx	( 0,0,2, ORC_BARRACKS		)
			SetBuildUnitEx(0,0,5, CHAOS_BURROW);//call SetBuildUnitEx	( 0,0,5, CHAOS_BURROW		)
			SetBuildUnitEx(0,0,1, FORGE);//call SetBuildUnitEx	( 0,0,1, FORGE				)
			SetBuildUnit(8, CHAOS_PEON);//call SetBuildUnit	( 8, CHAOS_PEON				)
			SetBuildUnitEx(0,0,1, STRONGHOLD);//call SetBuildUnitEx	( 0,0,1, STRONGHOLD			)
			SetBuildUnitEx(0,0,2, BESTIARY);//call SetBuildUnitEx	( 0,0,2, BESTIARY			)
			SetBuildUnitEx(0,0,2, LODGE);//call SetBuildUnitEx	( 0,0,2, LODGE				)
			CampaignDefenderEx(0,0,2, CHAOS_GRUNT);//call CampaignDefenderEx( 0,0,2, CHAOS_GRUNT     )
			CampaignDefenderEx(0,0,2, CHAOS_WARLOCK);//call CampaignDefenderEx( 0,0,2, CHAOS_WARLOCK	)
			CampaignDefenderEx(1,1,1, CHAOS_RAIDER);//call CampaignDefenderEx( 1,1,1, CHAOS_RAIDER	)
			CampaignDefenderEx(1,1,1, CHAOS_GROM);//call CampaignDefenderEx( 1,1,1, CHAOS_GROM		)
			CampaignDefenderEx(1,1,3, ORC_DRAGON);//call CampaignDefenderEx( 1,1,3, ORC_DRAGON		)
			SetBuildUpgrEx(1,1,1, UPG_ORC_BURROWS);//call SetBuildUpgrEx( 1,1,1, UPG_ORC_BURROWS		)
			SetBuildUpgrEx(0,0,1, UPG_ORC_ARMOR);//call SetBuildUpgrEx( 0,0,1, UPG_ORC_ARMOR		)
			SetBuildUpgrEx(0,0,1, UPG_ORC_MELEE);//call SetBuildUpgrEx( 0,0,1, UPG_ORC_MELEE		)
			SetBuildUpgrEx(1,1,1, UPG_ORC_ENSNARE);//call SetBuildUpgrEx( 1,1,1, UPG_ORC_ENSNARE		)
			SetBuildUpgrEx(3,3,3, UPG_ORC_SPIKES);//call SetBuildUpgrEx( 3,3,3, UPG_ORC_SPIKES		)
			WaitForSignal();//call WaitForSignal()
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(1,1,1, ORC_DRAGON);//call CampaignAttackerEx( 1,1,1, ORC_DRAGON		)
			SuicideOnPlayer(M5,user);//call SuicideOnPlayer(M5,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(3,3,5, CHAOS_GRUNT);//call CampaignAttackerEx( 3,3,5, CHAOS_GRUNT		)
			CampaignAttackerEx(1,1,1, CHAOS_GROM);//call CampaignAttackerEx( 1,1,1, CHAOS_GROM		)
			SuicideOnPlayerEx(M6,M6,M5,user);//call SuicideOnPlayerEx(M6,M6,M5,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(1,1,2, ORC_DRAGON);//call CampaignAttackerEx( 1,1,2, ORC_DRAGON		)
			SuicideOnPlayerEx(M7,M7,M6,user);//call SuicideOnPlayerEx(M7,M7,M6,user)
			SetBuildUpgrEx(0,0,1, UPG_ORC_BERSERK);//call SetBuildUpgrEx( 0,0,1, UPG_ORC_BERSERK		)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(7,7,9, CHAOS_RAIDER);//call CampaignAttackerEx( 7,7,9, CHAOS_RAIDER    )
			SuicideOnPlayerEx(M6,M6,M5,user);//call SuicideOnPlayerEx(M6,M6,M5,user)
			SetBuildUpgrEx(0,0,1, UPG_ORC_WAR_DRUMS);//call SetBuildUpgrEx( 0,0,1, UPG_ORC_WAR_DRUMS	)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(1,1,2, ORC_DRAGON);//call CampaignAttackerEx( 1,1,2, ORC_DRAGON		)
			SuicideOnPlayerEx(M7,M7,M6,user);//call SuicideOnPlayerEx(M7,M7,M6,user)
			SetBuildUpgrEx(1,1,2, UPG_ORC_ARMOR);//call SetBuildUpgrEx( 1,1,2, UPG_ORC_ARMOR		)
			SetBuildUpgrEx(1,1,2, UPG_ORC_MELEE);//call SetBuildUpgrEx( 1,1,2, UPG_ORC_MELEE		)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(1,1,1, CHAOS_GROM);//call CampaignAttackerEx( 1,1,1, CHAOS_GROM		)
			CampaignAttackerEx(3,3,4, CHAOS_WARLOCK);//call CampaignAttackerEx( 3,3,4, CHAOS_WARLOCK   )
			SuicideOnPlayerEx(M6,M6,M5,user);//call SuicideOnPlayerEx(M6,M6,M5,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(5,5,7, CHAOS_RAIDER);//call CampaignAttackerEx( 5,5,7, CHAOS_RAIDER    )
			CampaignAttackerEx(1,1,1, CHAOS_KODO);//call CampaignAttackerEx( 1,1,1, CHAOS_KODO		)
			SuicideOnPlayerEx(M7,M7,M6,user);//call SuicideOnPlayerEx(M7,M7,M6,user)
			SetBuildUpgrEx(1,1,1, UPG_ORC_WAR_DRUMS);//call SetBuildUpgrEx( 1,1,1, UPG_ORC_WAR_DRUMS	)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(1,1,2, ORC_DRAGON);//call CampaignAttackerEx( 1,1,2, ORC_DRAGON		)
			CampaignAttackerEx(2,2,3, CHAOS_GRUNT);//call CampaignAttackerEx( 2,2,3, CHAOS_GRUNT     )
			SuicideOnPlayerEx(M6,M6,M5,user);//call SuicideOnPlayerEx(M6,M6,M5,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(3,3,5, CHAOS_GRUNT);//call CampaignAttackerEx( 3,3,5, CHAOS_GRUNT     )
			CampaignAttackerEx(1,1,2, CHAOS_KODO);//call CampaignAttackerEx( 1,1,2, CHAOS_KODO		)
			SuicideOnPlayerEx(M7,M7,M6,user);//call SuicideOnPlayerEx(M7,M7,M6,user)
			SetBuildUpgrEx(1,1,3, UPG_ORC_ARMOR);//call SetBuildUpgrEx( 1,1,3, UPG_ORC_ARMOR		)
			SetBuildUpgrEx(1,1,3, UPG_ORC_MELEE);//call SetBuildUpgrEx( 1,1,3, UPG_ORC_MELEE		)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(5,5,7, CHAOS_RAIDER);//call CampaignAttackerEx( 5,5,7, CHAOS_RAIDER    )
			CampaignAttackerEx(1,1,1, CHAOS_GROM);//call CampaignAttackerEx( 1,1,1, CHAOS_GROM		)
			SuicideOnPlayerEx(M6,M6,M5,user);//call SuicideOnPlayerEx(M6,M6,M5,user)
			while (true) {//loop
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(1,1,2, ORC_DRAGON);//call CampaignAttackerEx( 1,1,2, ORC_DRAGON		)
				CampaignAttackerEx(2,2,3, CHAOS_GRUNT);//call CampaignAttackerEx( 2,2,3, CHAOS_GRUNT     )
				SuicideOnPlayerEx(M7,M7,M6,user);//call SuicideOnPlayerEx(M7,M7,M6,user)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(1,1,1, CHAOS_GROM);//call CampaignAttackerEx( 1,1,1, CHAOS_GROM		)
				CampaignAttackerEx(3,3,4, CHAOS_WARLOCK);//call CampaignAttackerEx( 3,3,4, CHAOS_WARLOCK   )
				SuicideOnPlayerEx(M6,M6,M5,user);//call SuicideOnPlayerEx(M6,M6,M5,user)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(1,1,2, ORC_DRAGON);//call CampaignAttackerEx( 1,1,2, ORC_DRAGON		)
				CampaignAttackerEx(2,2,3, CHAOS_RAIDER);//call CampaignAttackerEx( 2,2,3, CHAOS_RAIDER    )
				SuicideOnPlayerEx(M7,M7,M6,user);//call SuicideOnPlayerEx(M7,M7,M6,user)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(5,5,7, CHAOS_RAIDER);//call CampaignAttackerEx( 5,5,7, CHAOS_RAIDER    )
				CampaignAttackerEx(1,1,1, CHAOS_GROM);//call CampaignAttackerEx( 1,1,1, CHAOS_GROM		)
				SuicideOnPlayerEx(M6,M6,M5,user);//call SuicideOnPlayerEx(M6,M6,M5,user)
			}//endloop
		}//endfunction

	
	}
}

