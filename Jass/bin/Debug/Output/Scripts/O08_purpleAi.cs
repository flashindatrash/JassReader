using System;
using System.Collections.Generic;

namespace Jass {

	public class O08_purpleAi {

		//
		//
		//
		public static player user = Player(0);//player user	 = Player(0)
		public static player jaina = Player(9);//player jaina = Player(9)
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(BURROW,null);//call CampaignAI(BURROW,null)
			SetReplacements(1,1,3);//call SetReplacements(1,1,3)
			do_campaign_farms = false;//set do_campaign_farms = false
			SetBuildUnitEx(0,0,1, GREAT_HALL);//call SetBuildUnitEx	( 0,0,1, GREAT_HALL			)
			SetBuildUnit(1, CHAOS_PEON);//call SetBuildUnit	( 1, CHAOS_PEON				)
			SetBuildUnitEx(0,0,1, ORC_BARRACKS);//call SetBuildUnitEx	( 0,0,1, ORC_BARRACKS		)
			SetBuildUnitEx(0,0,5, BURROW);//call SetBuildUnitEx	( 0,0,5, BURROW				)
			SetBuildUnitEx(0,0,1, FORGE);//call SetBuildUnitEx	( 0,0,1, FORGE				)
			SetBuildUnit(8, CHAOS_PEON);//call SetBuildUnit	( 8, CHAOS_PEON				)
			SetBuildUnitEx(0,0,1, STRONGHOLD);//call SetBuildUnitEx	( 0,0,1, STRONGHOLD			)
			SetBuildUnitEx(0,0,1, BESTIARY);//call SetBuildUnitEx	( 0,0,1, BESTIARY			)
			SetBuildUnitEx(0,0,1, LODGE);//call SetBuildUnitEx	( 0,0,1, LODGE				)
			CampaignDefenderEx(0,0,1, CHAOS_GRUNT);//call CampaignDefenderEx( 0,0,1, CHAOS_GRUNT     )
			CampaignDefenderEx(0,0,1, CHAOS_WARLOCK);//call CampaignDefenderEx( 0,0,1, CHAOS_WARLOCK	)
			CampaignDefenderEx(1,1,0, CHAOS_RAIDER);//call CampaignDefenderEx( 1,1,0, CHAOS_RAIDER	)
			SetBuildUpgrEx(3,3,3, UPG_ORC_SPIKES);//call SetBuildUpgrEx( 3,3,3, UPG_ORC_SPIKES		)
			SetBuildUpgrEx(0,0,1, UPG_ORC_BERSERK);//call SetBuildUpgrEx( 0,0,1, UPG_ORC_BERSERK		)
			SetBuildUpgr(1, UPG_ORC_ENSNARE);//call SetBuildUpgr	( 1, UPG_ORC_ENSNARE		)
			WaitForSignal();//call WaitForSignal()
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(4,4,6, CHAOS_GRUNT);//call CampaignAttackerEx( 4,4,6, CHAOS_GRUNT		)
			SuicideOnPlayer(M3,user);//call SuicideOnPlayer(M3,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(3,3,4, CHAOS_GRUNT);//call CampaignAttackerEx( 3,3,4, CHAOS_GRUNT		)
			CampaignAttackerEx(2,2,3, CHAOS_RAIDER);//call CampaignAttackerEx( 2,2,3, CHAOS_RAIDER	)
			SuicideOnPlayerEx(M10,M10,M9,jaina);//call SuicideOnPlayerEx(M10,M10,M9,jaina)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2,2,3, CHAOS_GRUNT);//call CampaignAttackerEx( 2,2,3, CHAOS_GRUNT     )
			CampaignAttackerEx(1,1,2, CHAOS_RAIDER);//call CampaignAttackerEx( 1,1,2, CHAOS_RAIDER    )
			CampaignAttackerEx(1,1,2, CHAOS_WARLOCK);//call CampaignAttackerEx( 1,1,2, CHAOS_WARLOCK   )
			SuicideOnPlayerEx(M7,M7,M6,user);//call SuicideOnPlayerEx(M7,M7,M6,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(3,3,4, CHAOS_GRUNT);//call CampaignAttackerEx( 3,3,4, CHAOS_GRUNT     )
			CampaignAttackerEx(1,1,1, CHAOS_KODO);//call CampaignAttackerEx( 1,1,1, CHAOS_KODO		)
			CampaignAttackerEx(1,1,2, CATAPULT);//call CampaignAttackerEx( 1,1,2, CATAPULT		)
			SuicideOnPlayerEx(M6,M6,M7,jaina);//call SuicideOnPlayerEx(M6,M6,M7,jaina)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(4,4,6, CHAOS_RAIDER);//call CampaignAttackerEx( 4,4,6, CHAOS_RAIDER    )
			CampaignAttackerEx(2,2,3, CHAOS_WARLOCK);//call CampaignAttackerEx( 2,2,3, CHAOS_WARLOCK   )
			SuicideOnPlayerEx(M7,M7,M6,user);//call SuicideOnPlayerEx(M7,M7,M6,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(6,6,7, CHAOS_GRUNT);//call CampaignAttackerEx( 6,6,7, CHAOS_GRUNT     )
			CampaignAttackerEx(1,1,2, CATAPULT);//call CampaignAttackerEx( 1,1,2, CATAPULT		)
			CampaignAttackerEx(1,1,2, CHAOS_WARLOCK);//call CampaignAttackerEx( 1,1,2, CHAOS_WARLOCK   )
			SuicideOnPlayerEx(M6,M6,M7,jaina);//call SuicideOnPlayerEx(M6,M6,M7,jaina)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(4,4,7, CHAOS_RAIDER);//call CampaignAttackerEx( 4,4,7, CHAOS_RAIDER    )
			CampaignAttackerEx(1,1,1, CHAOS_KODO);//call CampaignAttackerEx( 1,1,1, CHAOS_KODO		)
			CampaignAttackerEx(1,1,2, CHAOS_WARLOCK);//call CampaignAttackerEx( 1,1,2, CHAOS_WARLOCK   )
			SuicideOnPlayerEx(M7,M7,M6,user);//call SuicideOnPlayerEx(M7,M7,M6,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(7,7,9, CHAOS_GRUNT);//call CampaignAttackerEx( 7,7,9, CHAOS_GRUNT		)
			CampaignAttackerEx(2,2,3, CHAOS_WARLOCK);//call CampaignAttackerEx( 2,2,3, CHAOS_WARLOCK   )
			SuicideOnPlayerEx(M6,M6,M7,jaina);//call SuicideOnPlayerEx(M6,M6,M7,jaina)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(4,4,5, CHAOS_GRUNT);//call CampaignAttackerEx( 4,4,5, CHAOS_GRUNT     )
			CampaignAttackerEx(1,1,2, CATAPULT);//call CampaignAttackerEx( 1,1,2, CATAPULT		)
			CampaignAttackerEx(1,1,2, CHAOS_WARLOCK);//call CampaignAttackerEx( 1,1,2, CHAOS_WARLOCK   )
			SuicideOnPlayerEx(M7,M7,M6,user);//call SuicideOnPlayerEx(M7,M7,M6,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(3,3,4, CHAOS_GRUNT);//call CampaignAttackerEx( 3,3,4, CHAOS_GRUNT     )
			CampaignAttackerEx(3,3,4, CHAOS_RAIDER);//call CampaignAttackerEx( 3,3,4, CHAOS_RAIDER    )
			CampaignAttackerEx(1,1,2, CHAOS_WARLOCK);//call CampaignAttackerEx( 1,1,2, CHAOS_WARLOCK   )
			SuicideOnPlayerEx(M6,M6,M7,jaina);//call SuicideOnPlayerEx(M6,M6,M7,jaina)
			while (true) {//loop
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(3,3,5, CHAOS_GRUNT);//call CampaignAttackerEx( 3,3,5, CHAOS_GRUNT     )
				CampaignAttackerEx(1,1,2, CHAOS_KODO);//call CampaignAttackerEx( 1,1,2, CHAOS_KODO		)
				CampaignAttackerEx(1,1,2, CATAPULT);//call CampaignAttackerEx( 1,1,2, CATAPULT		)
				CampaignAttackerEx(1,1,2, CHAOS_WARLOCK);//call CampaignAttackerEx( 1,1,2, CHAOS_WARLOCK   )
				SuicideOnPlayerEx(M7,M7,M6,user);//call SuicideOnPlayerEx(M7,M7,M6,user)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(3,3,4, CHAOS_GRUNT);//call CampaignAttackerEx( 3,3,4, CHAOS_GRUNT     )
				CampaignAttackerEx(3,3,4, CHAOS_RAIDER);//call CampaignAttackerEx( 3,3,4, CHAOS_RAIDER    )
				CampaignAttackerEx(1,1,2, CHAOS_WARLOCK);//call CampaignAttackerEx( 1,1,2, CHAOS_WARLOCK   )
				SuicideOnPlayerEx(M6,M6,M7,jaina);//call SuicideOnPlayerEx(M6,M6,M7,jaina)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(5,5,8, CHAOS_RAIDER);//call CampaignAttackerEx( 5,5,8, CHAOS_RAIDER	)
				SuicideOnPlayerEx(M7,M7,M6,user);//call SuicideOnPlayerEx(M7,M7,M6,user)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(6,6,8, CHAOS_GRUNT);//call CampaignAttackerEx( 6,6,8, CHAOS_GRUNT		)
				CampaignAttackerEx(3,3,4, CHAOS_WARLOCK);//call CampaignAttackerEx( 3,3,4, CHAOS_WARLOCK   )
				SuicideOnPlayerEx(M6,M6,M7,jaina);//call SuicideOnPlayerEx(M6,M6,M7,jaina)
			}//endloop
		}//endfunction

	
	}
}

