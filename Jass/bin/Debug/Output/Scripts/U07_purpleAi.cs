using System;
using System.Collections.Generic;

namespace Jass {

	public class U07_purpleAi {

		//
		//
		//
		public static player user = Player(6);//player user = Player(6)
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(CommonAi.HOUSE, null);//call CampaignAI(HOUSE,null)
			SetReplacements(2, 2, 4);//call SetReplacements(2,2,4)
			do_campaign_farms = false;//set do_campaign_farms = false
			SetCaptainHome(CommonAi.ATTACK_CAPTAIN, -2924, -3633);//call SetCaptainHome(ATTACK_CAPTAIN,-2924,-3633)
			SetCaptainHome(CommonAi.DEFENSE_CAPTAIN, -2184, -3257);//call SetCaptainHome(DEFENSE_CAPTAIN,-2184,-3257)
			SetBuildUnitEx(0, 0, 1, CommonAi.TOWN_HALL);//call SetBuildUnitEx( 0,0,1, TOWN_HALL		)
			SetBuildUnitEx(3, 3, 3, CommonAi.PEASANT);//call SetBuildUnitEx( 3,3,3, PEASANT			)
			SetBuildUnitEx(0, 0, 1, CommonAi.BARRACKS);//call SetBuildUnitEx( 0,0,1, BARRACKS		)
			SetBuildUnitEx(0, 0, 1, CommonAi.LUMBER_MILL);//call SetBuildUnitEx( 0,0,1, LUMBER_MILL		)
			SetBuildUnitEx(0, 0, 1, CommonAi.HUMAN_ALTAR);//call SetBuildUnitEx( 0,0,1, HUMAN_ALTAR		)
			SetBuildUnitEx(0, 0, 1, CommonAi.BLACKSMITH);//call SetBuildUnitEx( 0,0,1, BLACKSMITH		)
			SetBuildUnitEx(7, 7, 7, CommonAi.PEASANT);//call SetBuildUnitEx( 7,7,7, PEASANT			)
			SetBuildUnitEx(0, 0, 1, CommonAi.KEEP);//call SetBuildUnitEx( 0,0,1, KEEP			)
			SetBuildUnitEx(0, 0, 1, CommonAi.WORKSHOP);//call SetBuildUnitEx( 0,0,1, WORKSHOP		)
			SetBuildUnitEx(0, 0, 1, CommonAi.SANCTUM);//call SetBuildUnitEx( 0,0,1, SANCTUM			)
			CampaignDefenderEx(1, 1, 1, CommonAi.FOOTMAN);//call CampaignDefenderEx( 1,1,1, FOOTMAN     )
			CampaignDefenderEx(0, 0, 1, CommonAi.MORTAR);//call CampaignDefenderEx( 0,0,1, MORTAR      )
			CampaignDefenderEx(1, 1, 1, CommonAi.RIFLEMAN);//call CampaignDefenderEx( 1,1,1, RIFLEMAN    )
			WaitForSignal();//call WaitForSignal()
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(4, 4, 6, CommonAi.FOOTMEN);//call CampaignAttackerEx( 4,4,6, FOOTMEN     )
			CampaignAttackerEx(1, 1, 2, CommonAi.RIFLEMAN);//call CampaignAttackerEx( 1,1,2, RIFLEMAN    )
			CampaignAttackerEx(0, 0, 2, CommonAi.PRIEST);//call CampaignAttackerEx( 0,0,2, PRIEST      )
			SuicideOnPlayerEx(CommonAi.M4, CommonAi.M4, CommonAi.M2, U08_tealAi.user);//call SuicideOnPlayerEx(M4,M4,M2,user)
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_MELEE);//call SetBuildUpgrEx( 0,0,1, UPG_MELEE		)
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_RANGED);//call SetBuildUpgrEx( 0,0,1, UPG_RANGED		)
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_PRAYING);//call SetBuildUpgrEx( 0,0,1, UPG_PRAYING		)
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_MASONRY);//call SetBuildUpgrEx( 0,0,1, UPG_MASONRY		)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(4, 4, 5, CommonAi.FOOTMEN);//call CampaignAttackerEx( 4,4,5, FOOTMEN     )
			CampaignAttackerEx(1, 1, 3, CommonAi.RIFLEMAN);//call CampaignAttackerEx( 1,1,3, RIFLEMAN    )
			CampaignAttackerEx(0, 0, 2, CommonAi.MORTAR);//call CampaignAttackerEx( 0,0,2, MORTAR      )
			CampaignAttackerEx(1, 1, 2, CommonAi.PRIEST);//call CampaignAttackerEx( 1,1,2, PRIEST      )
			SuicideOnPlayerEx(CommonAi.M8, CommonAi.M8, CommonAi.M7, U08_tealAi.user);//call SuicideOnPlayerEx(M8,M8,M7,user)
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_GUN_RANGE);//call SetBuildUpgrEx( 0,0,1, UPG_GUN_RANGE	)
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_LEATHER);//call SetBuildUpgrEx( 0,0,1, UPG_LEATHER		)
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_ARMOR);//call SetBuildUpgrEx( 0,0,1, UPG_ARMOR		)
			SetBuildUpgrEx(1, 1, 1, CommonAi.UPG_PRAYING);//call SetBuildUpgrEx( 1,1,1, UPG_PRAYING		)
			SetBuildUpgrEx(1, 1, 1, CommonAi.UPG_DEFEND);//call SetBuildUpgrEx( 1,1,1, UPG_DEFEND		)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(0, 0, 4, CommonAi.FOOTMEN);//call CampaignAttackerEx( 0,0,4, FOOTMEN     )
			CampaignAttackerEx(5, 5, 8, CommonAi.RIFLEMAN);//call CampaignAttackerEx( 5,5,8, RIFLEMAN    )
			CampaignAttackerEx(1, 1, 2, CommonAi.MORTAR);//call CampaignAttackerEx( 1,1,2, MORTAR      )
			CampaignAttackerEx(1, 1, 2, CommonAi.PRIEST);//call CampaignAttackerEx( 1,1,2, PRIEST      )
			SuicideOnPlayerEx(CommonAi.M6, CommonAi.M6, CommonAi.M6, U08_tealAi.user);//call SuicideOnPlayerEx(M6,M6,M6,user)
			SetBuildUpgrEx(1, 1, 2, CommonAi.UPG_MELEE);//call SetBuildUpgrEx( 1,1,2, UPG_MELEE		)
			SetBuildUpgrEx(1, 1, 2, CommonAi.UPG_RANGED);//call SetBuildUpgrEx( 1,1,2, UPG_RANGED		)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(5, 5, 10, CommonAi.FOOTMEN);//call CampaignAttackerEx( 5,5,10, FOOTMEN	)
			CampaignAttackerEx(2, 2, 4, CommonAi.MORTAR);//call CampaignAttackerEx( 2,2,4, MORTAR      )
			CampaignAttackerEx(1, 1, 2, CommonAi.PRIEST);//call CampaignAttackerEx( 1,1,2, PRIEST      )
			SuicideOnPlayerEx(CommonAi.M8, CommonAi.M8, CommonAi.M7, U08_tealAi.user);//call SuicideOnPlayerEx(M8,M8,M7,user)
			SetBuildUpgrEx(1, 1, 2, CommonAi.UPG_LEATHER);//call SetBuildUpgrEx( 1,1,2, UPG_LEATHER		)
			SetBuildUpgrEx(1, 1, 2, CommonAi.UPG_ARMOR);//call SetBuildUpgrEx( 1,1,2, UPG_ARMOR		)
			while (true) {//loop
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(1, 1, 3, CommonAi.FOOTMEN);//call CampaignAttackerEx( 1,1,3, FOOTMEN     )
				CampaignAttackerEx(5, 5, 7, CommonAi.RIFLEMAN);//call CampaignAttackerEx( 5,5,7, RIFLEMAN    )
				CampaignAttackerEx(1, 1, 2, CommonAi.MORTAR);//call CampaignAttackerEx( 1,1,2, MORTAR      )
				CampaignAttackerEx(0, 0, 2, CommonAi.PRIEST);//call CampaignAttackerEx( 0,0,2, PRIEST      )
				SuicideOnPlayerEx(CommonAi.M6, CommonAi.M6, CommonAi.M6, U08_tealAi.user);//call SuicideOnPlayerEx(M6,M6,M6,user)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(4, 4, 7, CommonAi.FOOTMEN);//call CampaignAttackerEx( 4,4,7, FOOTMEN     )
				CampaignAttackerEx(2, 2, 3, CommonAi.RIFLEMAN);//call CampaignAttackerEx( 2,2,3, RIFLEMAN    )
				CampaignAttackerEx(2, 2, 3, CommonAi.PRIEST);//call CampaignAttackerEx( 2,2,3, PRIEST      )
				SuicideOnPlayerEx(CommonAi.M8, CommonAi.M8, CommonAi.M7, U08_tealAi.user);//call SuicideOnPlayerEx(M8,M8,M7,user)
			}//endloop
		}//endfunction

	
	}
}

