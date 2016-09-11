using System;
using System.Collections.Generic;

namespace Jass {

	public class U06_light_blueAi {

		//
		//
		//
		public static player user = Player(3);//player user = Player(3)
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(CommonAi.PIG_FARM, null);//call CampaignAI(PIG_FARM,null)
			SetReplacements(1, 1, 3);//call SetReplacements(1,1,3)
			SetBuildUnitEx(0, 0, 1, CommonAi.GREAT_HALL);//call SetBuildUnitEx	( 0,0,1, GREAT_HALL			)
			SetBuildUnit(1, CommonAi.PEON);//call SetBuildUnit	( 1, PEON					)
			SetBuildUnitEx(0, 0, 1, CommonAi.ORC_BARRACKS);//call SetBuildUnitEx	( 0,0,1, ORC_BARRACKS		)
			SetBuildUnit(8, CommonAi.PEON);//call SetBuildUnit	( 8, PEON				    )
			CampaignDefenderEx(1, 1, 2, CommonAi.SAPPER);//call CampaignDefenderEx( 1,1,2, SAPPER			)
			CampaignDefenderEx(1, 1, 2, CommonAi.HEAD_HUNTER);//call CampaignDefenderEx( 1,1,2, HEAD_HUNTER		)
			CampaignDefenderEx(0, 0, 2, CommonAi.GRUNT);//call CampaignDefenderEx( 0,0,2, GRUNT			)
			WaitForSignal();//call WaitForSignal()
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2, 2, 3, CommonAi.GRUNT);//call CampaignAttackerEx( 2,2,3, GRUNT           )
			CampaignAttackerEx(1, 1, 2, CommonAi.HEAD_HUNTER);//call CampaignAttackerEx( 1,1,2, HEAD_HUNTER     )
			CampaignAttackerEx(1, 1, 2, CommonAi.SAPPER);//call CampaignAttackerEx( 1,1,2, SAPPER			)
			SuicideOnPlayerEx(CommonAi.M9, CommonAi.M9, CommonAi.M5, U08_tealAi.user);//call SuicideOnPlayerEx(M9,M9,M5,user)
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_ORC_RANGED);//call SetBuildUpgrEx( 0,0,1, UPG_ORC_RANGED		)
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_ORC_MELEE);//call SetBuildUpgrEx( 0,0,1, UPG_ORC_MELEE		)
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_ORC_SPIKES);//call SetBuildUpgrEx( 0,0,1, UPG_ORC_SPIKES		)
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_ORC_BERSERK);//call SetBuildUpgrEx( 0,0,1, UPG_ORC_BERSERK		)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2, 2, 4, CommonAi.GRUNT);//call CampaignAttackerEx( 2,2,4, GRUNT           )
			CampaignAttackerEx(2, 2, 2, CommonAi.HEAD_HUNTER);//call CampaignAttackerEx( 2,2,2, HEAD_HUNTER     )
			CampaignAttackerEx(2, 2, 3, CommonAi.SAPPER);//call CampaignAttackerEx( 2,2,3, SAPPER			)
			SuicideOnPlayerEx(CommonAi.M10, CommonAi.M10, CommonAi.M7, U08_tealAi.user);//call SuicideOnPlayerEx(M10,M10,M7,user)
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_ORC_ARMOR);//call SetBuildUpgrEx( 0,0,1, UPG_ORC_ARMOR		)
			SetBuildUpgrEx(1, 1, 2, CommonAi.UPG_ORC_RANGED);//call SetBuildUpgrEx( 1,1,2, UPG_ORC_RANGED		)
			SetBuildUpgrEx(1, 1, 2, CommonAi.UPG_ORC_MELEE);//call SetBuildUpgrEx( 1,1,2, UPG_ORC_MELEE		)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2, 2, 4, CommonAi.GRUNT);//call CampaignAttackerEx( 2,2,4, GRUNT       )
			CampaignAttackerEx(1, 1, 3, CommonAi.SAPPER);//call CampaignAttackerEx( 1,1,3, SAPPER      )
			CampaignAttackerEx(2, 2, 2, CommonAi.HEAD_HUNTER);//call CampaignAttackerEx( 2,2,2, HEAD_HUNTER	)
			SuicideOnPlayerEx(CommonAi.M10, CommonAi.M10, CommonAi.M7, U08_tealAi.user);//call SuicideOnPlayerEx(M10,M10,M7,user)
			SetBuildUpgrEx(1, 1, 2, CommonAi.UPG_ORC_ARMOR);//call SetBuildUpgrEx( 1,1,2, UPG_ORC_ARMOR		)
			SetBuildUpgrEx(1, 1, 2, CommonAi.UPG_ORC_SPIKES);//call SetBuildUpgrEx( 1,1,2, UPG_ORC_SPIKES		)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(0, 0, 6, CommonAi.GRUNT);//call CampaignAttackerEx( 0,0,6, GRUNT		)
			CampaignAttackerEx(2, 2, 3, CommonAi.SAPPER);//call CampaignAttackerEx( 2,2,3, SAPPER      )
			CampaignAttackerEx(4, 4, 4, CommonAi.HEAD_HUNTER);//call CampaignAttackerEx( 4,4,4, HEAD_HUNTER	)
			SuicideOnPlayerEx(CommonAi.M10, CommonAi.M10, CommonAi.M7, U08_tealAi.user);//call SuicideOnPlayerEx(M10,M10,M7,user)
			SetBuildUpgrEx(0, 0, 3, CommonAi.UPG_ORC_ARMOR);//call SetBuildUpgrEx( 0,0,3, UPG_ORC_ARMOR		)
			SetBuildUpgrEx(0, 0, 3, CommonAi.UPG_ORC_RANGED);//call SetBuildUpgrEx( 0,0,3, UPG_ORC_RANGED		)
			SetBuildUpgrEx(0, 0, 3, CommonAi.UPG_ORC_MELEE);//call SetBuildUpgrEx( 0,0,3, UPG_ORC_MELEE		)
			SetBuildUpgrEx(0, 0, 3, CommonAi.UPG_ORC_SPIKES);//call SetBuildUpgrEx( 0,0,3, UPG_ORC_SPIKES		)
			while (true) {//loop
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(2, 2, 4, CommonAi.GRUNT);//call CampaignAttackerEx( 2,2,4, GRUNT       )
				CampaignAttackerEx(1, 1, 3, CommonAi.SAPPER);//call CampaignAttackerEx( 1,1,3, SAPPER      )
				CampaignAttackerEx(2, 2, 2, CommonAi.HEAD_HUNTER);//call CampaignAttackerEx( 2,2,2, HEAD_HUNTER	)
				SuicideOnPlayerEx(CommonAi.M10, CommonAi.M10, CommonAi.M7, U08_tealAi.user);//call SuicideOnPlayerEx(M10,M10,M7,user)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(0, 0, 6, CommonAi.GRUNT);//call CampaignAttackerEx( 0,0,6, GRUNT		)
				CampaignAttackerEx(2, 2, 3, CommonAi.SAPPER);//call CampaignAttackerEx( 2,2,3, SAPPER      )
				CampaignAttackerEx(4, 4, 4, CommonAi.HEAD_HUNTER);//call CampaignAttackerEx( 4,4,4, HEAD_HUNTER	)
				SuicideOnPlayerEx(CommonAi.M10, CommonAi.M10, CommonAi.M7, U08_tealAi.user);//call SuicideOnPlayerEx(M10,M10,M7,user)
			}//endloop
		}//endfunction

	
	}
}

