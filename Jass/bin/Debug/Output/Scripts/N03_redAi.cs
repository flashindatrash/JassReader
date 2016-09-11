using System;
using System.Collections.Generic;

namespace Jass {

	public class N03_redAi {

		//
		//
		//
		public static player user = Player(1);//player user = Player(1)
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(CommonAi.BURROW, null);//call CampaignAI(BURROW,null)
			SetReplacements(1, 2, 4);//call SetReplacements(1,2,4)
			SetBuildUnit(1, CommonAi.PEON);//call SetBuildUnit	( 1, PEON					)
			SetBuildUnitEx(0, 0, 1, CommonAi.GREAT_HALL);//call SetBuildUnitEx	( 0,0,1, GREAT_HALL			)
			SetBuildUnit(7, CommonAi.PEON);//call SetBuildUnit	( 7, PEON					)
			SetBuildUnitEx(0, 0, 1, CommonAi.ORC_BARRACKS);//call SetBuildUnitEx	( 0,0,1, ORC_BARRACKS		)
			SetBuildUnitEx(0, 0, 1, CommonAi.FORGE);//call SetBuildUnitEx	( 0,0,1, FORGE				)
			SetBuildUnitEx(0, 0, 1, CommonAi.STRONGHOLD);//call SetBuildUnitEx	( 0,0,1, STRONGHOLD			)
			SetBuildUnitEx(0, 0, 1, CommonAi.ORC_ALTAR);//call SetBuildUnitEx	( 0,0,1, ORC_ALTAR			)
			SetBuildUnitEx(0, 0, 1, CommonAi.LODGE);//call SetBuildUnitEx	( 0,0,1, LODGE				)
			SetBuildUnitEx(0, 0, 1, CommonAi.BESTIARY);//call SetBuildUnitEx	( 0,0,1, BESTIARY			)
			SetBuildUnitEx(0, 0, 1, CommonAi.FORTRESS);//call SetBuildUnitEx	( 0,0,1, FORTRESS			)
			CampaignDefenderEx(1, 1, 1, CommonAi.GRUNT);//call CampaignDefenderEx( 1,1,1, GRUNT			)
			CampaignDefenderEx(0, 0, 1, CommonAi.HEAD_HUNTER);//call CampaignDefenderEx( 0,0,1, HEAD_HUNTER		)
			CampaignDefenderEx(1, 1, 1, CommonAi.SHAMAN);//call CampaignDefenderEx( 1,1,1, SHAMAN			)
			CampaignDefenderEx(1, 1, 1, CommonAi.WITCH_DOCTOR);//call CampaignDefenderEx( 1,1,1, WITCH_DOCTOR	)
			CampaignDefenderEx(0, 0, 1, CommonAi.BLADE_MASTER);//call CampaignDefenderEx( 0,0,1, BLADE_MASTER	)
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_ORC_RANGED);//call SetBuildUpgrEx( 0,0,1, UPG_ORC_RANGED		)
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_ORC_MELEE);//call SetBuildUpgrEx( 0,0,1, UPG_ORC_MELEE		)
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_ORC_SPIKES);//call SetBuildUpgrEx( 0,0,1, UPG_ORC_SPIKES		)
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_ORC_ARMOR);//call SetBuildUpgrEx( 0,0,1, UPG_ORC_ARMOR		)
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_ORC_SHAMAN);//call SetBuildUpgrEx( 0,0,1, UPG_ORC_SHAMAN		)
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_ORC_DOCS);//call SetBuildUpgrEx( 0,0,1, UPG_ORC_DOCS		)
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_ORC_REGEN);//call SetBuildUpgrEx( 0,0,1, UPG_ORC_REGEN		)
			WaitForSignal();//call WaitForSignal()
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(3, 3, 4, CommonAi.GRUNT);//call CampaignAttackerEx( 3,3,4, GRUNT			)
			SuicideOnPlayerEx(CommonAi.M4, CommonAi.M4, CommonAi.M4, U08_tealAi.user);//call SuicideOnPlayerEx(M4,M4,M4,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(3, 3, 4, CommonAi.GRUNT);//call CampaignAttackerEx( 3,3,4, GRUNT			)
			CampaignAttackerEx(2, 2, 3, CommonAi.SHAMAN);//call CampaignAttackerEx( 2,2,3, SHAMAN			)
			SuicideOnPlayerEx(CommonAi.M4, CommonAi.M4, CommonAi.M4, U08_tealAi.user);//call SuicideOnPlayerEx(M4,M4,M4,user)
			SetBuildUpgrEx(1, 1, 2, CommonAi.UPG_ORC_SHAMAN);//call SetBuildUpgrEx( 1,1,2, UPG_ORC_SHAMAN		)
			SetBuildUpgrEx(1, 1, 2, CommonAi.UPG_ORC_RANGED);//call SetBuildUpgrEx( 1,1,2, UPG_ORC_RANGED		)
			SetBuildUpgrEx(1, 1, 2, CommonAi.UPG_ORC_MELEE);//call SetBuildUpgrEx( 1,1,2, UPG_ORC_MELEE		)
			SetBuildUpgrEx(1, 1, 2, CommonAi.UPG_ORC_SPIKES);//call SetBuildUpgrEx( 1,1,2, UPG_ORC_SPIKES		)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(3, 3, 4, CommonAi.GRUNT);//call CampaignAttackerEx( 3,3,4, GRUNT			)
			CampaignAttackerEx(2, 2, 3, CommonAi.WITCH_DOCTOR);//call CampaignAttackerEx( 2,2,3, WITCH_DOCTOR	)
			CampaignAttackerEx(1, 1, 1, CommonAi.BLADE_MASTER);//call CampaignAttackerEx( 1,1,1, BLADE_MASTER	)
			SuicideOnPlayerEx(CommonAi.M4, CommonAi.M4, CommonAi.M4, U08_tealAi.user);//call SuicideOnPlayerEx(M4,M4,M4,user)
			SetBuildUpgrEx(1, 1, 2, CommonAi.UPG_ORC_DOCS);//call SetBuildUpgrEx( 1,1,2, UPG_ORC_DOCS		)
			SetBuildUpgrEx(1, 1, 2, CommonAi.UPG_ORC_ARMOR);//call SetBuildUpgrEx( 1,1,2, UPG_ORC_ARMOR		)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2, 2, 2, CommonAi.GRUNT);//call CampaignAttackerEx( 2,2,2, GRUNT			)
			CampaignAttackerEx(2, 2, 2, CommonAi.HEAD_HUNTER);//call CampaignAttackerEx( 2,2,2, HEAD_HUNTER		)
			CampaignAttackerEx(2, 2, 3, CommonAi.SHAMAN);//call CampaignAttackerEx( 2,2,3, SHAMAN			)
			CampaignAttackerEx(1, 1, 2, CommonAi.CATAPULT);//call CampaignAttackerEx( 1,1,2, CATAPULT		)
			SuicideOnPlayerEx(CommonAi.M4, CommonAi.M4, CommonAi.M4, U08_tealAi.user);//call SuicideOnPlayerEx(M4,M4,M4,user)
			SetBuildUpgrEx(2, 2, 2, CommonAi.UPG_ORC_SHAMAN);//call SetBuildUpgrEx( 2,2,2, UPG_ORC_SHAMAN		)
			SetBuildUpgrEx(2, 2, 2, CommonAi.UPG_ORC_DOCS);//call SetBuildUpgrEx( 2,2,2, UPG_ORC_DOCS		)
			while (true) {//loop
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(3, 3, 3, CommonAi.GRUNT);//call CampaignAttackerEx( 3,3,3, GRUNT			)
				CampaignAttackerEx(2, 2, 2, CommonAi.HEAD_HUNTER);//call CampaignAttackerEx( 2,2,2, HEAD_HUNTER		)
				CampaignAttackerEx(2, 2, 3, CommonAi.WITCH_DOCTOR);//call CampaignAttackerEx( 2,2,3, WITCH_DOCTOR	)
				CampaignAttackerEx(1, 1, 1, CommonAi.BLADE_MASTER);//call CampaignAttackerEx( 1,1,1, BLADE_MASTER	)
				SuicideOnPlayerEx(CommonAi.M4, CommonAi.M4, CommonAi.M4, U08_tealAi.user);//call SuicideOnPlayerEx(M4,M4,M4,user)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(5, 5, 6, CommonAi.GRUNT);//call CampaignAttackerEx( 5,5,6, GRUNT			)
				CampaignAttackerEx(2, 2, 2, CommonAi.HEAD_HUNTER);//call CampaignAttackerEx( 2,2,2, HEAD_HUNTER		)
				CampaignAttackerEx(2, 2, 3, CommonAi.SHAMAN);//call CampaignAttackerEx( 2,2,3, SHAMAN			)
				CampaignAttackerEx(0, 0, 1, CommonAi.CATAPULT);//call CampaignAttackerEx( 0,0,1, CATAPULT		)
				SuicideOnPlayerEx(CommonAi.M4, CommonAi.M4, CommonAi.M4, U08_tealAi.user);//call SuicideOnPlayerEx(M4,M4,M4,user)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(2, 2, 4, CommonAi.GRUNT);//call CampaignAttackerEx( 2,2,4, GRUNT			)
				CampaignAttackerEx(2, 2, 2, CommonAi.HEAD_HUNTER);//call CampaignAttackerEx( 2,2,2, HEAD_HUNTER		)
				CampaignAttackerEx(2, 2, 3, CommonAi.SHAMAN);//call CampaignAttackerEx( 2,2,3, SHAMAN			)
				CampaignAttackerEx(2, 2, 3, CommonAi.WITCH_DOCTOR);//call CampaignAttackerEx( 2,2,3, WITCH_DOCTOR	)
				CampaignAttackerEx(1, 1, 1, CommonAi.BLADE_MASTER);//call CampaignAttackerEx( 1,1,1, BLADE_MASTER	)
				SuicideOnPlayerEx(CommonAi.M4, CommonAi.M4, CommonAi.M4, U08_tealAi.user);//call SuicideOnPlayerEx(M4,M4,M4,user)
			}//endloop
		}//endfunction

	
	}
}

