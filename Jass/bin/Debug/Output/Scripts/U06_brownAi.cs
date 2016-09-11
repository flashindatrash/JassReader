using System;
using System.Collections.Generic;

namespace Jass {

	public class U06_brownAi {

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
			CampaignDefenderEx(1, 1, 1, CommonAi.GRUNT);//call CampaignDefenderEx( 1,1,1, GRUNT        )
			CampaignDefenderEx(1, 1, 2, CommonAi.OGRE_MAGI);//call CampaignDefenderEx( 1,1,2, OGRE_MAGI    )
			SetBuildUpgr(1, CommonAi.UPG_ORC_ENSNARE);//call SetBuildUpgr( 1, UPG_ORC_ENSNARE		)
			WaitForSignal();//call WaitForSignal()
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2, 2, 3, CommonAi.GRUNT);//call CampaignAttackerEx( 2,2,3, GRUNT        )
			CampaignAttackerEx(1, 1, 2, CommonAi.OGRE_MAGI);//call CampaignAttackerEx( 1,1,2, OGRE_MAGI    )
			SuicideOnPlayerEx(CommonAi.M5, CommonAi.M5, CommonAi.M3, U08_tealAi.user);//call SuicideOnPlayerEx(M5,M5,M3,user)
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_ORC_MELEE);//call SetBuildUpgrEx( 0,0,1, UPG_ORC_MELEE		)
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_ORC_SPIKES);//call SetBuildUpgrEx( 0,0,1, UPG_ORC_SPIKES		)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(3, 3, 4, CommonAi.GRUNT);//call CampaignAttackerEx( 3,3,4, GRUNT        )
			CampaignAttackerEx(2, 2, 3, CommonAi.OGRE_MAGI);//call CampaignAttackerEx( 2,2,3, OGRE_MAGI    )
			CampaignAttackerEx(0, 0, 1, CommonAi.CATAPULT);//call CampaignAttackerEx( 0,0,1, CATAPULT     )
			SuicideOnPlayerEx(CommonAi.M10, CommonAi.M10, CommonAi.M7, U08_tealAi.user);//call SuicideOnPlayerEx(M10,M10,M7,user)
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_ORC_ARMOR);//call SetBuildUpgrEx( 0,0,1, UPG_ORC_ARMOR		)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(3, 3, 3, CommonAi.GRUNT);//call CampaignAttackerEx( 3,3,3, GRUNT        )
			CampaignAttackerEx(1, 1, 3, CommonAi.RAIDER);//call CampaignAttackerEx( 1,1,3, RAIDER       )
			CampaignAttackerEx(1, 1, 2, CommonAi.OGRE_MAGI);//call CampaignAttackerEx( 1,1,2, OGRE_MAGI    )
			CampaignAttackerEx(0, 0, 1, CommonAi.CATAPULT);//call CampaignAttackerEx( 0,0,1, CATAPULT     )
			SuicideOnPlayerEx(CommonAi.M10, CommonAi.M10, CommonAi.M7, U08_tealAi.user);//call SuicideOnPlayerEx(M10,M10,M7,user)
			SetBuildUpgrEx(1, 1, 2, CommonAi.UPG_ORC_MELEE);//call SetBuildUpgrEx( 1,1,2, UPG_ORC_MELEE		)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(0, 0, 3, CommonAi.GRUNT);//call CampaignAttackerEx( 0,0,3, GRUNT        )
			CampaignAttackerEx(3, 3, 5, CommonAi.RAIDER);//call CampaignAttackerEx( 3,3,5, RAIDER       )
			CampaignAttackerEx(2, 2, 2, CommonAi.OGRE_MAGI);//call CampaignAttackerEx( 2,2,2, OGRE_MAGI    )
			SuicideOnPlayerEx(CommonAi.M10, CommonAi.M10, CommonAi.M7, U08_tealAi.user);//call SuicideOnPlayerEx(M10,M10,M7,user)
			SetBuildUpgrEx(1, 1, 2, CommonAi.UPG_ORC_ARMOR);//call SetBuildUpgrEx( 1,1,2, UPG_ORC_ARMOR		)
			SetBuildUpgrEx(1, 1, 2, CommonAi.UPG_ORC_SPIKES);//call SetBuildUpgrEx( 1,1,2, UPG_ORC_SPIKES		)
			while (true) {//loop
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(3, 3, 3, CommonAi.GRUNT);//call CampaignAttackerEx( 3,3,3, GRUNT        )
				CampaignAttackerEx(1, 1, 3, CommonAi.RAIDER);//call CampaignAttackerEx( 1,1,3, RAIDER       )
				CampaignAttackerEx(1, 1, 2, CommonAi.OGRE_MAGI);//call CampaignAttackerEx( 1,1,2, OGRE_MAGI    )
				CampaignAttackerEx(0, 0, 1, CommonAi.CATAPULT);//call CampaignAttackerEx( 0,0,1, CATAPULT     )
				SuicideOnPlayerEx(CommonAi.M10, CommonAi.M10, CommonAi.M7, U08_tealAi.user);//call SuicideOnPlayerEx(M10,M10,M7,user)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(0, 0, 3, CommonAi.GRUNT);//call CampaignAttackerEx( 0,0,3, GRUNT        )
				CampaignAttackerEx(3, 3, 5, CommonAi.RAIDER);//call CampaignAttackerEx( 3,3,5, RAIDER       )
				CampaignAttackerEx(2, 2, 2, CommonAi.OGRE_MAGI);//call CampaignAttackerEx( 2,2,2, OGRE_MAGI    )
				SuicideOnPlayerEx(CommonAi.M10, CommonAi.M10, CommonAi.M7, U08_tealAi.user);//call SuicideOnPlayerEx(M10,M10,M7,user)
			}//endloop
		}//endfunction

	
	}
}

