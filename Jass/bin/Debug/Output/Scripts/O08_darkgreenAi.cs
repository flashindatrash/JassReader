using System;
using System.Collections.Generic;

namespace Jass {

	public class O08_darkgreenAi {

		//
		//
		//
		public static player user = Player(0);//player user	 = Player(0)
		public static player jaina = Player(9);//player jaina = Player(9)
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(CommonAi.BURROW, null);//call CampaignAI(BURROW,null)
			SetReplacements(1, 1, 3);//call SetReplacements(1,1,3)
			do_campaign_farms = false;//set do_campaign_farms = false
			SetBuildUnitEx(0, 0, 1, CommonAi.GREAT_HALL);//call SetBuildUnitEx	( 0,0,1, GREAT_HALL			)
			SetBuildUnit(1, CommonAi.CHAOS_PEON);//call SetBuildUnit	( 1, CHAOS_PEON				)
			SetBuildUnitEx(0, 0, 1, CommonAi.ORC_BARRACKS);//call SetBuildUnitEx	( 0,0,1, ORC_BARRACKS		)
			SetBuildUnitEx(0, 0, 5, CommonAi.BURROW);//call SetBuildUnitEx	( 0,0,5, BURROW				)
			SetBuildUnitEx(0, 0, 1, CommonAi.FORGE);//call SetBuildUnitEx	( 0,0,1, FORGE				)
			SetBuildUnit(8, CommonAi.CHAOS_PEON);//call SetBuildUnit	( 8, CHAOS_PEON				)
			SetBuildUnitEx(0, 0, 1, CommonAi.STRONGHOLD);//call SetBuildUnitEx	( 0,0,1, STRONGHOLD			)
			SetBuildUnitEx(0, 0, 1, CommonAi.BESTIARY);//call SetBuildUnitEx	( 0,0,1, BESTIARY			)
			SetBuildUnitEx(0, 0, 1, CommonAi.LODGE);//call SetBuildUnitEx	( 0,0,1, LODGE				)
			CampaignDefenderEx(0, 0, 1, CommonAi.CHAOS_GRUNT);//call CampaignDefenderEx( 0,0,1, CHAOS_GRUNT     )
			CampaignDefenderEx(0, 0, 1, CommonAi.CHAOS_WARLOCK);//call CampaignDefenderEx( 0,0,1, CHAOS_WARLOCK	)
			CampaignDefenderEx(1, 1, 0, CommonAi.CHAOS_RAIDER);//call CampaignDefenderEx( 1,1,0, CHAOS_RAIDER	)
			SetBuildUpgrEx(3, 3, 3, CommonAi.UPG_ORC_SPIKES);//call SetBuildUpgrEx( 3,3,3, UPG_ORC_SPIKES		)
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_ORC_BERSERK);//call SetBuildUpgrEx( 0,0,1, UPG_ORC_BERSERK		)
			SetBuildUpgr(1, CommonAi.UPG_ORC_ENSNARE);//call SetBuildUpgr	( 1, UPG_ORC_ENSNARE		)
			WaitForSignal();//call WaitForSignal()
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(5, 5, 6, CommonAi.CHAOS_GRUNT);//call CampaignAttackerEx( 5,5,6, CHAOS_GRUNT		)
			SuicideOnPlayer(CommonAi.M3, O08_purpleAi.jaina);//call SuicideOnPlayer(M3,jaina)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2, 2, 3, CommonAi.CHAOS_GRUNT);//call CampaignAttackerEx( 2,2,3, CHAOS_GRUNT		)
			CampaignAttackerEx(2, 2, 3, CommonAi.CHAOS_RAIDER);//call CampaignAttackerEx( 2,2,3, CHAOS_RAIDER	)
			SuicideOnPlayerEx(CommonAi.M8, CommonAi.M8, CommonAi.M6, U08_tealAi.user);//call SuicideOnPlayerEx(M8,M8,M6,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(3, 3, 3, CommonAi.CHAOS_GRUNT);//call CampaignAttackerEx( 3,3,3, CHAOS_GRUNT     )
			CampaignAttackerEx(1, 1, 2, CommonAi.CHAOS_RAIDER);//call CampaignAttackerEx( 1,1,2, CHAOS_RAIDER    )
			CampaignAttackerEx(1, 1, 2, CommonAi.CHAOS_WARLOCK);//call CampaignAttackerEx( 1,1,2, CHAOS_WARLOCK   )
			SuicideOnPlayerEx(CommonAi.M8, CommonAi.M8, CommonAi.M6, O08_purpleAi.jaina);//call SuicideOnPlayerEx(M8,M8,M6,jaina)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(3, 3, 4, CommonAi.CHAOS_GRUNT);//call CampaignAttackerEx( 3,3,4, CHAOS_GRUNT     )
			CampaignAttackerEx(1, 1, 1, CommonAi.CHAOS_KODO);//call CampaignAttackerEx( 1,1,1, CHAOS_KODO		)
			CampaignAttackerEx(1, 1, 2, CommonAi.CATAPULT);//call CampaignAttackerEx( 1,1,2, CATAPULT		)
			SuicideOnPlayerEx(CommonAi.M8, CommonAi.M8, CommonAi.M6, U08_tealAi.user);//call SuicideOnPlayerEx(M8,M8,M6,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(6, 6, 7, CommonAi.CHAOS_RAIDER);//call CampaignAttackerEx( 6,6,7, CHAOS_RAIDER    )
			CampaignAttackerEx(2, 2, 3, CommonAi.CHAOS_WARLOCK);//call CampaignAttackerEx( 2,2,3, CHAOS_WARLOCK   )
			SuicideOnPlayerEx(CommonAi.M8, CommonAi.M8, CommonAi.M6, O08_purpleAi.jaina);//call SuicideOnPlayerEx(M8,M8,M6,jaina)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(4, 4, 6, CommonAi.CHAOS_GRUNT);//call CampaignAttackerEx( 4,4,6, CHAOS_GRUNT     )
			CampaignAttackerEx(1, 1, 2, CommonAi.CATAPULT);//call CampaignAttackerEx( 1,1,2, CATAPULT		)
			CampaignAttackerEx(1, 1, 2, CommonAi.CHAOS_WARLOCK);//call CampaignAttackerEx( 1,1,2, CHAOS_WARLOCK   )
			SuicideOnPlayerEx(CommonAi.M8, CommonAi.M8, CommonAi.M6, U08_tealAi.user);//call SuicideOnPlayerEx(M8,M8,M6,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(7, 7, 8, CommonAi.CHAOS_RAIDER);//call CampaignAttackerEx( 7,7,8, CHAOS_RAIDER    )
			CampaignAttackerEx(1, 1, 1, CommonAi.CHAOS_KODO);//call CampaignAttackerEx( 1,1,1, CHAOS_KODO		)
			CampaignAttackerEx(1, 1, 2, CommonAi.CHAOS_WARLOCK);//call CampaignAttackerEx( 1,1,2, CHAOS_WARLOCK   )
			SuicideOnPlayerEx(CommonAi.M8, CommonAi.M8, CommonAi.M6, O08_purpleAi.jaina);//call SuicideOnPlayerEx(M8,M8,M6,jaina)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(4, 4, 6, CommonAi.CHAOS_GRUNT);//call CampaignAttackerEx( 4,4,6, CHAOS_GRUNT    )
			CampaignAttackerEx(2, 2, 3, CommonAi.CHAOS_WARLOCK);//call CampaignAttackerEx( 2,2,3, CHAOS_WARLOCK   )
			SuicideOnPlayerEx(CommonAi.M8, CommonAi.M8, CommonAi.M6, U08_tealAi.user);//call SuicideOnPlayerEx(M8,M8,M6,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(4, 4, 5, CommonAi.CHAOS_GRUNT);//call CampaignAttackerEx( 4,4,5, CHAOS_GRUNT     )
			CampaignAttackerEx(1, 1, 2, CommonAi.CATAPULT);//call CampaignAttackerEx( 1,1,2, CATAPULT		)
			CampaignAttackerEx(1, 1, 2, CommonAi.CHAOS_WARLOCK);//call CampaignAttackerEx( 1,1,2, CHAOS_WARLOCK   )
			SuicideOnPlayerEx(CommonAi.M8, CommonAi.M8, CommonAi.M6, O08_purpleAi.jaina);//call SuicideOnPlayerEx(M8,M8,M6,jaina)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2, 2, 4, CommonAi.CHAOS_GRUNT);//call CampaignAttackerEx( 2,2,4, CHAOS_GRUNT     )
			CampaignAttackerEx(2, 2, 3, CommonAi.CHAOS_RAIDER);//call CampaignAttackerEx( 2,2,3, CHAOS_RAIDER    )
			CampaignAttackerEx(1, 1, 2, CommonAi.CHAOS_WARLOCK);//call CampaignAttackerEx( 1,1,2, CHAOS_WARLOCK   )
			SuicideOnPlayerEx(CommonAi.M8, CommonAi.M8, CommonAi.M6, U08_tealAi.user);//call SuicideOnPlayerEx(M8,M8,M6,user)
			while (true) {//loop
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(4, 4, 5, CommonAi.CHAOS_GRUNT);//call CampaignAttackerEx( 4,4,5, CHAOS_GRUNT     )
				CampaignAttackerEx(1, 1, 2, CommonAi.CHAOS_KODO);//call CampaignAttackerEx( 1,1,2, CHAOS_KODO		)
				CampaignAttackerEx(1, 1, 2, CommonAi.CATAPULT);//call CampaignAttackerEx( 1,1,2, CATAPULT		)
				CampaignAttackerEx(1, 1, 2, CommonAi.CHAOS_WARLOCK);//call CampaignAttackerEx( 1,1,2, CHAOS_WARLOCK   )
				SuicideOnPlayerEx(CommonAi.M8, CommonAi.M8, CommonAi.M6, O08_purpleAi.jaina);//call SuicideOnPlayerEx(M8,M8,M6,jaina)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(2, 2, 4, CommonAi.CHAOS_GRUNT);//call CampaignAttackerEx( 2,2,4, CHAOS_GRUNT     )
				CampaignAttackerEx(2, 2, 3, CommonAi.CHAOS_RAIDER);//call CampaignAttackerEx( 2,2,3, CHAOS_RAIDER    )
				CampaignAttackerEx(1, 1, 2, CommonAi.CHAOS_WARLOCK);//call CampaignAttackerEx( 1,1,2, CHAOS_WARLOCK   )
				SuicideOnPlayerEx(CommonAi.M8, CommonAi.M8, CommonAi.M6, U08_tealAi.user);//call SuicideOnPlayerEx(M8,M8,M6,user)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(8, 8, 9, CommonAi.CHAOS_RAIDER);//call CampaignAttackerEx( 8,8,9, CHAOS_RAIDER  )
				SuicideOnPlayerEx(CommonAi.M8, CommonAi.M8, CommonAi.M6, O08_purpleAi.jaina);//call SuicideOnPlayerEx(M8,M8,M6,jaina)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(4, 4, 7, CommonAi.CHAOS_GRUNT);//call CampaignAttackerEx( 4,4,7, CHAOS_GRUNT    )
				CampaignAttackerEx(2, 2, 4, CommonAi.CHAOS_WARLOCK);//call CampaignAttackerEx( 2,2,4, CHAOS_WARLOCK   )
				SuicideOnPlayerEx(CommonAi.M8, CommonAi.M8, CommonAi.M6, U08_tealAi.user);//call SuicideOnPlayerEx(M8,M8,M6,user)
			}//endloop
		}//endfunction

	
	}
}

