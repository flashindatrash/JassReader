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
			CampaignAI(BURROW,null);//call CampaignAI(BURROW,null)
			SetReplacements(1,2,4);//call SetReplacements(1,2,4)
			SetBuildUnit(1, PEON);//call SetBuildUnit	( 1, PEON					)
			SetBuildUnitEx(0,0,1, GREAT_HALL);//call SetBuildUnitEx	( 0,0,1, GREAT_HALL			)
			SetBuildUnit(7, PEON);//call SetBuildUnit	( 7, PEON					)
			SetBuildUnitEx(0,0,1, ORC_BARRACKS);//call SetBuildUnitEx	( 0,0,1, ORC_BARRACKS		)
			SetBuildUnitEx(0,0,1, FORGE);//call SetBuildUnitEx	( 0,0,1, FORGE				)
			SetBuildUnitEx(0,0,1, STRONGHOLD);//call SetBuildUnitEx	( 0,0,1, STRONGHOLD			)
			SetBuildUnitEx(0,0,1, ORC_ALTAR);//call SetBuildUnitEx	( 0,0,1, ORC_ALTAR			)
			SetBuildUnitEx(0,0,1, LODGE);//call SetBuildUnitEx	( 0,0,1, LODGE				)
			SetBuildUnitEx(0,0,1, BESTIARY);//call SetBuildUnitEx	( 0,0,1, BESTIARY			)
			SetBuildUnitEx(0,0,1, FORTRESS);//call SetBuildUnitEx	( 0,0,1, FORTRESS			)
			CampaignDefenderEx(1,1,1, GRUNT);//call CampaignDefenderEx( 1,1,1, GRUNT			)
			CampaignDefenderEx(0,0,1, HEAD_HUNTER);//call CampaignDefenderEx( 0,0,1, HEAD_HUNTER		)
			CampaignDefenderEx(1,1,1, SHAMAN);//call CampaignDefenderEx( 1,1,1, SHAMAN			)
			CampaignDefenderEx(1,1,1, WITCH_DOCTOR);//call CampaignDefenderEx( 1,1,1, WITCH_DOCTOR	)
			CampaignDefenderEx(0,0,1, BLADE_MASTER);//call CampaignDefenderEx( 0,0,1, BLADE_MASTER	)
			SetBuildUpgrEx(0,0,1, UPG_ORC_RANGED);//call SetBuildUpgrEx( 0,0,1, UPG_ORC_RANGED		)
			SetBuildUpgrEx(0,0,1, UPG_ORC_MELEE);//call SetBuildUpgrEx( 0,0,1, UPG_ORC_MELEE		)
			SetBuildUpgrEx(0,0,1, UPG_ORC_SPIKES);//call SetBuildUpgrEx( 0,0,1, UPG_ORC_SPIKES		)
			SetBuildUpgrEx(0,0,1, UPG_ORC_ARMOR);//call SetBuildUpgrEx( 0,0,1, UPG_ORC_ARMOR		)
			SetBuildUpgrEx(0,0,1, UPG_ORC_SHAMAN);//call SetBuildUpgrEx( 0,0,1, UPG_ORC_SHAMAN		)
			SetBuildUpgrEx(0,0,1, UPG_ORC_DOCS);//call SetBuildUpgrEx( 0,0,1, UPG_ORC_DOCS		)
			SetBuildUpgrEx(0,0,1, UPG_ORC_REGEN);//call SetBuildUpgrEx( 0,0,1, UPG_ORC_REGEN		)
			WaitForSignal();//call WaitForSignal()
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(3,3,4, GRUNT);//call CampaignAttackerEx( 3,3,4, GRUNT			)
			SuicideOnPlayerEx(M4,M4,M4,user);//call SuicideOnPlayerEx(M4,M4,M4,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(3,3,4, GRUNT);//call CampaignAttackerEx( 3,3,4, GRUNT			)
			CampaignAttackerEx(2,2,3, SHAMAN);//call CampaignAttackerEx( 2,2,3, SHAMAN			)
			SuicideOnPlayerEx(M4,M4,M4,user);//call SuicideOnPlayerEx(M4,M4,M4,user)
			SetBuildUpgrEx(1,1,2, UPG_ORC_SHAMAN);//call SetBuildUpgrEx( 1,1,2, UPG_ORC_SHAMAN		)
			SetBuildUpgrEx(1,1,2, UPG_ORC_RANGED);//call SetBuildUpgrEx( 1,1,2, UPG_ORC_RANGED		)
			SetBuildUpgrEx(1,1,2, UPG_ORC_MELEE);//call SetBuildUpgrEx( 1,1,2, UPG_ORC_MELEE		)
			SetBuildUpgrEx(1,1,2, UPG_ORC_SPIKES);//call SetBuildUpgrEx( 1,1,2, UPG_ORC_SPIKES		)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(3,3,4, GRUNT);//call CampaignAttackerEx( 3,3,4, GRUNT			)
			CampaignAttackerEx(2,2,3, WITCH_DOCTOR);//call CampaignAttackerEx( 2,2,3, WITCH_DOCTOR	)
			CampaignAttackerEx(1,1,1, BLADE_MASTER);//call CampaignAttackerEx( 1,1,1, BLADE_MASTER	)
			SuicideOnPlayerEx(M4,M4,M4,user);//call SuicideOnPlayerEx(M4,M4,M4,user)
			SetBuildUpgrEx(1,1,2, UPG_ORC_DOCS);//call SetBuildUpgrEx( 1,1,2, UPG_ORC_DOCS		)
			SetBuildUpgrEx(1,1,2, UPG_ORC_ARMOR);//call SetBuildUpgrEx( 1,1,2, UPG_ORC_ARMOR		)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2,2,2, GRUNT);//call CampaignAttackerEx( 2,2,2, GRUNT			)
			CampaignAttackerEx(2,2,2, HEAD_HUNTER);//call CampaignAttackerEx( 2,2,2, HEAD_HUNTER		)
			CampaignAttackerEx(2,2,3, SHAMAN);//call CampaignAttackerEx( 2,2,3, SHAMAN			)
			CampaignAttackerEx(1,1,2, CATAPULT);//call CampaignAttackerEx( 1,1,2, CATAPULT		)
			SuicideOnPlayerEx(M4,M4,M4,user);//call SuicideOnPlayerEx(M4,M4,M4,user)
			SetBuildUpgrEx(2,2,2, UPG_ORC_SHAMAN);//call SetBuildUpgrEx( 2,2,2, UPG_ORC_SHAMAN		)
			SetBuildUpgrEx(2,2,2, UPG_ORC_DOCS);//call SetBuildUpgrEx( 2,2,2, UPG_ORC_DOCS		)
			while (true) {//loop
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(3,3,3, GRUNT);//call CampaignAttackerEx( 3,3,3, GRUNT			)
				CampaignAttackerEx(2,2,2, HEAD_HUNTER);//call CampaignAttackerEx( 2,2,2, HEAD_HUNTER		)
				CampaignAttackerEx(2,2,3, WITCH_DOCTOR);//call CampaignAttackerEx( 2,2,3, WITCH_DOCTOR	)
				CampaignAttackerEx(1,1,1, BLADE_MASTER);//call CampaignAttackerEx( 1,1,1, BLADE_MASTER	)
				SuicideOnPlayerEx(M4,M4,M4,user);//call SuicideOnPlayerEx(M4,M4,M4,user)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(5,5,6, GRUNT);//call CampaignAttackerEx( 5,5,6, GRUNT			)
				CampaignAttackerEx(2,2,2, HEAD_HUNTER);//call CampaignAttackerEx( 2,2,2, HEAD_HUNTER		)
				CampaignAttackerEx(2,2,3, SHAMAN);//call CampaignAttackerEx( 2,2,3, SHAMAN			)
				CampaignAttackerEx(0,0,1, CATAPULT);//call CampaignAttackerEx( 0,0,1, CATAPULT		)
				SuicideOnPlayerEx(M4,M4,M4,user);//call SuicideOnPlayerEx(M4,M4,M4,user)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(2,2,4, GRUNT);//call CampaignAttackerEx( 2,2,4, GRUNT			)
				CampaignAttackerEx(2,2,2, HEAD_HUNTER);//call CampaignAttackerEx( 2,2,2, HEAD_HUNTER		)
				CampaignAttackerEx(2,2,3, SHAMAN);//call CampaignAttackerEx( 2,2,3, SHAMAN			)
				CampaignAttackerEx(2,2,3, WITCH_DOCTOR);//call CampaignAttackerEx( 2,2,3, WITCH_DOCTOR	)
				CampaignAttackerEx(1,1,1, BLADE_MASTER);//call CampaignAttackerEx( 1,1,1, BLADE_MASTER	)
				SuicideOnPlayerEx(M4,M4,M4,user);//call SuicideOnPlayerEx(M4,M4,M4,user)
			}//endloop
		}//endfunction

	
	}
}

