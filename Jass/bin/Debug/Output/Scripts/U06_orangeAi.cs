using System;
using System.Collections.Generic;

namespace Jass {

	public class U06_orangeAi {

		//
		//
		//
		public static player user = Player(3);//player user = Player(3)
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(PIG_FARM,null);//call CampaignAI(PIG_FARM,null)
			SetReplacements(1,1,3);//call SetReplacements(1,1,3)
			SetBuildUnitEx(0,0,1, GREAT_HALL);//call SetBuildUnitEx	( 0,0,1, GREAT_HALL			)
			SetBuildUnit(1, PEON);//call SetBuildUnit	( 1, PEON					)
			SetBuildUnitEx(0,0,1, ORC_BARRACKS);//call SetBuildUnitEx	( 0,0,1, ORC_BARRACKS		)
			SetBuildUnit(8, PEON);//call SetBuildUnit	( 8, PEON				    )
			CampaignDefenderEx(1,1,2, RAIDER);//call CampaignDefenderEx( 1,1,2, RAIDER          )
			CampaignDefenderEx(1,1,1, W2_WARLOCK);//call CampaignDefenderEx( 1,1,1, W2_WARLOCK      )
			CampaignDefenderEx(0,1,1, HEAD_HUNTER);//call CampaignDefenderEx( 0,1,1, HEAD_HUNTER     )
			WaitForSignal();//call WaitForSignal()
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2,2,3, GRUNT);//call CampaignAttackerEx( 2,2,3, GRUNT            )
			CampaignAttackerEx(1,1,2, HEAD_HUNTER);//call CampaignAttackerEx( 1,1,2, HEAD_HUNTER      )
			CampaignAttackerEx(1,1,2, W2_WARLOCK);//call CampaignAttackerEx( 1,1,2, W2_WARLOCK       )
			SuicideOnPlayerEx(M2,M2,M1,user);//call SuicideOnPlayerEx(M2,M2,M1,user)
			SetBuildUpgrEx(0,0,1, UPG_ORC_RANGED);//call SetBuildUpgrEx( 0,0,1, UPG_ORC_RANGED		)
			SetBuildUpgrEx(0,0,1, UPG_ORC_MELEE);//call SetBuildUpgrEx( 0,0,1, UPG_ORC_MELEE		)
			SetBuildUpgrEx(0,0,1, UPG_ORC_SPIKES);//call SetBuildUpgrEx( 0,0,1, UPG_ORC_SPIKES		)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2,2,4, GRUNT);//call CampaignAttackerEx( 2,2,4, GRUNT            )
			CampaignAttackerEx(2,2,2, RAIDER);//call CampaignAttackerEx( 2,2,2, RAIDER           )
			CampaignAttackerEx(1,1,2, W2_WARLOCK);//call CampaignAttackerEx( 1,1,2, W2_WARLOCK       )
			CampaignAttackerEx(0,0,1, CATAPULT);//call CampaignAttackerEx( 0,0,1, CATAPULT         )
			SuicideOnPlayerEx(M10,M10,M7,user);//call SuicideOnPlayerEx(M10,M10,M7,user)
			SetBuildUpgrEx(0,0,1, UPG_ORC_ARMOR);//call SetBuildUpgrEx( 0,0,1, UPG_ORC_ARMOR		)
			SetBuildUpgrEx(1,1,1, UPG_ORC_ENSNARE);//call SetBuildUpgrEx( 1,1,1, UPG_ORC_ENSNARE		)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2,2,4, GRUNT);//call CampaignAttackerEx( 2,2,4, GRUNT           )
			CampaignAttackerEx(1,1,2, W2_WARLOCK);//call CampaignAttackerEx( 1,1,2, W2_WARLOCK      )
			CampaignAttackerEx(2,2,2, HEAD_HUNTER);//call CampaignAttackerEx( 2,2,2, HEAD_HUNTER		)
			CampaignAttackerEx(1,1,2, CATAPULT);//call CampaignAttackerEx( 1,1,2, CATAPULT        )
			SuicideOnPlayerEx(M10,M10,M7,user);//call SuicideOnPlayerEx(M10,M10,M7,user)
			SetBuildUpgrEx(1,1,2, UPG_ORC_RANGED);//call SetBuildUpgrEx( 1,1,2, UPG_ORC_RANGED		)
			SetBuildUpgrEx(1,1,2, UPG_ORC_MELEE);//call SetBuildUpgrEx( 1,1,2, UPG_ORC_MELEE		)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2,2,4, RAIDER);//call CampaignAttackerEx( 2,2,4, RAIDER          )
			CampaignAttackerEx(2,2,3, W2_WARLOCK);//call CampaignAttackerEx( 2,2,3, W2_WARLOCK      )
			CampaignAttackerEx(2,2,2, HEAD_HUNTER);//call CampaignAttackerEx( 2,2,2, HEAD_HUNTER		)
			CampaignAttackerEx(0,0,1, CATAPULT);//call CampaignAttackerEx( 0,0,1, CATAPULT        )
			SuicideOnPlayerEx(M10,M10,M7,user);//call SuicideOnPlayerEx(M10,M10,M7,user)
			SetBuildUpgrEx(1,1,2, UPG_ORC_ARMOR);//call SetBuildUpgrEx( 1,1,2, UPG_ORC_ARMOR		)
			SetBuildUpgrEx(1,1,2, UPG_ORC_SPIKES);//call SetBuildUpgrEx( 1,1,2, UPG_ORC_SPIKES		)
			while (true) {//loop
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(2,2,4, GRUNT);//call CampaignAttackerEx( 2,2,4, GRUNT           )
				CampaignAttackerEx(1,1,2, W2_WARLOCK);//call CampaignAttackerEx( 1,1,2, W2_WARLOCK      )
				CampaignAttackerEx(2,2,2, HEAD_HUNTER);//call CampaignAttackerEx( 2,2,2, HEAD_HUNTER		)
				CampaignAttackerEx(1,1,2, CATAPULT);//call CampaignAttackerEx( 1,1,2, CATAPULT        )
				SuicideOnPlayerEx(M10,M10,M7,user);//call SuicideOnPlayerEx(M10,M10,M7,user)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(2,2,4, RAIDER);//call CampaignAttackerEx( 2,2,4, RAIDER          )
				CampaignAttackerEx(2,2,3, W2_WARLOCK);//call CampaignAttackerEx( 2,2,3, W2_WARLOCK      )
				CampaignAttackerEx(2,2,2, HEAD_HUNTER);//call CampaignAttackerEx( 2,2,2, HEAD_HUNTER		)
				CampaignAttackerEx(0,0,1, CATAPULT);//call CampaignAttackerEx( 0,0,1, CATAPULT        )
				SuicideOnPlayerEx(M10,M10,M7,user);//call SuicideOnPlayerEx(M10,M10,M7,user)
			}//endloop
		}//endfunction

	
	}
}

