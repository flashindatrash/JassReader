using System;
using System.Collections.Generic;

namespace Jass {

	public class U06_redAi {

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
			SetBuildUnitEx(0, 0, 2, CommonAi.ORC_BARRACKS);//call SetBuildUnitEx	( 0,0,2, ORC_BARRACKS		)
			SetBuildUnit(8, CommonAi.PEON);//call SetBuildUnit	( 8, PEON				    )
			CampaignDefenderEx(1, 1, 2, CommonAi.GRUNT);//call CampaignDefenderEx( 1,1,2, GRUNT       )
			CampaignDefenderEx(1, 1, 1, CommonAi.ORC_DRAGON);//call CampaignDefenderEx( 1,1,1, ORC_DRAGON  )
			CampaignDefenderEx(1, 1, 1, CommonAi.W2_WARLOCK);//call CampaignDefenderEx( 1,1,1, W2_WARLOCK  )
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_ORC_RANGED);//call SetBuildUpgrEx( 0,0,1, UPG_ORC_RANGED		)
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_ORC_MELEE);//call SetBuildUpgrEx( 0,0,1, UPG_ORC_MELEE		)
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_ORC_SPIKES);//call SetBuildUpgrEx( 0,0,1, UPG_ORC_SPIKES		)
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_ORC_BERSERK);//call SetBuildUpgrEx( 0,0,1, UPG_ORC_BERSERK		)
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_ORC_ENSNARE);//call SetBuildUpgrEx( 0,0,1, UPG_ORC_ENSNARE		)
			WaitForSignal();//call WaitForSignal()
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(1, 1, 2, CommonAi.ORC_DRAGON);//call CampaignAttackerEx( 1,1,2, ORC_DRAGON       )
			SuicideOnPlayerEx(CommonAi.M1, CommonAi.M1, 0, U08_tealAi.user);//call SuicideOnPlayerEx(M1,M1,0,user)
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_ORC_ARMOR);//call SetBuildUpgrEx( 0,0,1, UPG_ORC_ARMOR		)
			SetBuildUpgrEx(1, 1, 2, CommonAi.UPG_ORC_RANGED);//call SetBuildUpgrEx( 1,1,2, UPG_ORC_RANGED		)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2, 2, 4, CommonAi.GRUNT);//call CampaignAttackerEx( 2,2,4, GRUNT            )
			CampaignAttackerEx(1, 1, 2, CommonAi.ORC_DRAGON);//call CampaignAttackerEx( 1,1,2, ORC_DRAGON       )
			SuicideOnPlayerEx(CommonAi.M10, CommonAi.M10, CommonAi.M8, U08_tealAi.user);//call SuicideOnPlayerEx(M10,M10,M8,user)
			SetBuildUpgrEx(1, 1, 2, CommonAi.UPG_ORC_MELEE);//call SetBuildUpgrEx( 1,1,2, UPG_ORC_MELEE		)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(1, 1, 2, CommonAi.ORC_DRAGON);//call CampaignAttackerEx( 1,1,2, ORC_DRAGON      )
			SuicideOnPlayerEx(CommonAi.M10, CommonAi.M10, CommonAi.M8, U08_tealAi.user);//call SuicideOnPlayerEx(M10,M10,M8,user)
			SetBuildUpgrEx(1, 1, 2, CommonAi.UPG_ORC_ARMOR);//call SetBuildUpgrEx( 1,1,2, UPG_ORC_ARMOR		)
			SetBuildUpgrEx(1, 1, 2, CommonAi.UPG_ORC_SPIKES);//call SetBuildUpgrEx( 1,1,2, UPG_ORC_SPIKES		)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(3, 3, 4, CommonAi.RAIDER);//call CampaignAttackerEx( 3,3,4, RAIDER          )
			CampaignAttackerEx(1, 1, 2, CommonAi.ORC_DRAGON);//call CampaignAttackerEx( 1,1,2, ORC_DRAGON      )
			CampaignAttackerEx(1, 1, 2, CommonAi.W2_WARLOCK);//call CampaignAttackerEx( 1,1,2, W2_WARLOCK		)
			SuicideOnPlayerEx(CommonAi.M10, CommonAi.M10, CommonAi.M8, U08_tealAi.user);//call SuicideOnPlayerEx(M10,M10,M8,user)
			SetBuildUpgrEx(0, 0, 3, CommonAi.UPG_ORC_ARMOR);//call SetBuildUpgrEx( 0,0,3, UPG_ORC_ARMOR		)
			SetBuildUpgrEx(0, 0, 3, CommonAi.UPG_ORC_RANGED);//call SetBuildUpgrEx( 0,0,3, UPG_ORC_RANGED		)
			SetBuildUpgrEx(0, 0, 3, CommonAi.UPG_ORC_MELEE);//call SetBuildUpgrEx( 0,0,3, UPG_ORC_MELEE		)
			SetBuildUpgrEx(0, 0, 3, CommonAi.UPG_ORC_SPIKES);//call SetBuildUpgrEx( 0,0,3, UPG_ORC_SPIKES		)
			while (true) {//loop
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(1, 1, 2, CommonAi.ORC_DRAGON);//call CampaignAttackerEx( 1,1,2, ORC_DRAGON      )
				SuicideOnPlayerEx(CommonAi.M10, CommonAi.M10, CommonAi.M8, U08_tealAi.user);//call SuicideOnPlayerEx(M10,M10,M8,user)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(3, 3, 4, CommonAi.RAIDER);//call CampaignAttackerEx( 3,3,4, RAIDER          )
				CampaignAttackerEx(1, 1, 2, CommonAi.ORC_DRAGON);//call CampaignAttackerEx( 1,1,2, ORC_DRAGON      )
				CampaignAttackerEx(1, 1, 2, CommonAi.HEAD_HUNTER);//call CampaignAttackerEx( 1,1,2, HEAD_HUNTER		)
				SuicideOnPlayerEx(CommonAi.M10, CommonAi.M10, CommonAi.M8, U08_tealAi.user);//call SuicideOnPlayerEx(M10,M10,M8,user)
			}//endloop
		}//endfunction

	
	}
}

