using System;
using System.Collections.Generic;

namespace Jass {

	public class O06_blueAi {

		//
		//
		//
		public static player user = Player(0);//player user = Player(0)
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(CommonAi.HOUSE, null);//call CampaignAI(HOUSE,null)
			SetReplacements(2, 2, 4);//call SetReplacements(2,2,4)
			do_campaign_farms = false;//set do_campaign_farms = false
			SetBuildUnitEx(0, 0, 1, CommonAi.TOWN_HALL);//call SetBuildUnitEx( 0,0,1, TOWN_HALL		)
			SetBuildUnitEx(3, 3, 3, CommonAi.PEASANT);//call SetBuildUnitEx( 3,3,3, PEASANT			)
			SetBuildUnitEx(0, 0, 2, CommonAi.BARRACKS);//call SetBuildUnitEx( 0,0,2, BARRACKS		)
			SetBuildUnitEx(0, 0, 1, CommonAi.LUMBER_MILL);//call SetBuildUnitEx( 0,0,1, LUMBER_MILL		)
			SetBuildUnitEx(0, 0, 1, CommonAi.HUMAN_ALTAR);//call SetBuildUnitEx( 0,0,1, HUMAN_ALTAR		)
			SetBuildUnitEx(0, 0, 1, CommonAi.BLACKSMITH);//call SetBuildUnitEx( 0,0,1, BLACKSMITH		)
			SetBuildUnitEx(5, 5, 5, CommonAi.PEASANT);//call SetBuildUnitEx( 5,5,5, PEASANT			)
			SetBuildUnitEx(2, 2, 2, CommonAi.ZEPPLIN);//call SetBuildUnitEx( 2,2,2, ZEPPLIN			)
			SetBuildUnitEx(0, 0, 1, CommonAi.KEEP);//call SetBuildUnitEx( 0,0,1, KEEP			)
			SetBuildUnitEx(0, 0, 1, CommonAi.WORKSHOP);//call SetBuildUnitEx( 0,0,1, WORKSHOP		)
			SetBuildUnitEx(0, 0, 1, CommonAi.CASTLE);//call SetBuildUnitEx( 0,0,1, CASTLE			)
			SetBuildUnitEx(0, 0, 1, CommonAi.AVIARY);//call SetBuildUnitEx( 0,0,1, AVIARY			)
			CampaignDefenderEx(1, 1, 1, CommonAi.GRYPHON);//call CampaignDefenderEx( 1,1,1, GRYPHON     )
			CampaignDefenderEx(0, 0, 1, CommonAi.MORTAR);//call CampaignDefenderEx( 0,0,1, MORTAR      )
			CampaignDefenderEx(1, 1, 1, CommonAi.RIFLEMAN);//call CampaignDefenderEx( 1,1,1, RIFLEMAN    )
			CampaignDefenderEx(0, 0, 1, CommonAi.MTN_KING);//call CampaignDefenderEx( 0,0,1, MTN_KING    )
			WaitForSignal();//call WaitForSignal()
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(4, 4, 6, CommonAi.RIFLEMAN);//call CampaignAttackerEx( 4,4,6, RIFLEMAN    )
			CampaignAttackerEx(1, 1, 2, CommonAi.MORTAR);//call CampaignAttackerEx( 1,1,2, MORTAR		)
			SuicideOnPlayerEx(CommonAi.M5, CommonAi.M5, CommonAi.M3, U08_tealAi.user);//call SuicideOnPlayerEx(M5,M5,M3,user)
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_MELEE);//call SetBuildUpgrEx( 0,0,1, UPG_MELEE		)
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_RANGED);//call SetBuildUpgrEx( 0,0,1, UPG_RANGED		)
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_MASONRY);//call SetBuildUpgrEx( 0,0,1, UPG_MASONRY		)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(4, 4, 6, CommonAi.GRYPHON);//call CampaignAttackerEx( 4,4,6, GRYPHON		)
			SuicideOnPlayerEx(CommonAi.M8, CommonAi.M8, CommonAi.M7, U08_tealAi.user);//call SuicideOnPlayerEx(M8,M8,M7,user)
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_GUN_RANGE);//call SetBuildUpgrEx( 0,0,1, UPG_GUN_RANGE	)
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_LEATHER);//call SetBuildUpgrEx( 0,0,1, UPG_LEATHER		)
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_ARMOR);//call SetBuildUpgrEx( 0,0,1, UPG_ARMOR		)
			SetBuildUpgrEx(1, 1, 1, CommonAi.UPG_BREEDING);//call SetBuildUpgrEx( 1,1,1, UPG_BREEDING	)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(5, 5, 6, CommonAi.RIFLEMAN);//call CampaignAttackerEx( 5,5,6, RIFLEMAN    )
			CampaignAttackerEx(1, 1, 2, CommonAi.MORTAR);//call CampaignAttackerEx( 1,1,2, MORTAR      )
			CampaignAttackerEx(1, 1, 1, CommonAi.MTN_KING);//call CampaignAttackerEx( 1,1,1, MTN_KING    )
			SuicideOnPlayerEx(CommonAi.M8, CommonAi.M8, CommonAi.M7, U08_tealAi.user);//call SuicideOnPlayerEx(M8,M8,M7,user)
			SetBuildUpgrEx(1, 1, 2, CommonAi.UPG_MELEE);//call SetBuildUpgrEx( 1,1,2, UPG_MELEE		)
			SetBuildUpgrEx(1, 1, 2, CommonAi.UPG_RANGED);//call SetBuildUpgrEx( 1,1,2, UPG_RANGED		)
			SetBuildUpgrEx(1, 1, 2, CommonAi.UPG_MASONRY);//call SetBuildUpgrEx( 1,1,2, UPG_MASONRY		)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(6, 6, 8, CommonAi.GRYPHON);//call CampaignAttackerEx( 6,6,8, GRYPHON		)
			SuicideOnPlayerEx(CommonAi.M8, CommonAi.M8, CommonAi.M7, U08_tealAi.user);//call SuicideOnPlayerEx(M8,M8,M7,user)
			SetBuildUpgrEx(1, 1, 2, CommonAi.UPG_LEATHER);//call SetBuildUpgrEx( 1,1,2, UPG_LEATHER		)
			SetBuildUpgrEx(1, 1, 2, CommonAi.UPG_ARMOR);//call SetBuildUpgrEx( 1,1,2, UPG_ARMOR		)
			SetBuildUpgrEx(1, 1, 1, CommonAi.UPG_HAMMERS);//call SetBuildUpgrEx( 1,1,1, UPG_HAMMERS		)
			while (true) {//loop
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(6, 6, 5, CommonAi.RIFLEMAN);//call CampaignAttackerEx( 6,6,5, RIFLEMAN    )
				CampaignAttackerEx(1, 1, 3, CommonAi.MORTAR);//call CampaignAttackerEx( 1,1,3, MORTAR      )
				CampaignAttackerEx(1, 1, 1, CommonAi.MTN_KING);//call CampaignAttackerEx( 1,1,1, MTN_KING    )
				SuicideOnPlayerEx(CommonAi.M8, CommonAi.M8, CommonAi.M7, U08_tealAi.user);//call SuicideOnPlayerEx(M8,M8,M7,user)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(6, 6, 8, CommonAi.GRYPHON);//call CampaignAttackerEx( 6,6,8, GRYPHON     )
				SuicideOnPlayerEx(CommonAi.M8, CommonAi.M8, CommonAi.M7, U08_tealAi.user);//call SuicideOnPlayerEx(M8,M8,M7,user)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(4, 4, 7, CommonAi.RIFLEMAN);//call CampaignAttackerEx( 4,4,7, RIFLEMAN   )
				CampaignAttackerEx(2, 2, 2, CommonAi.MORTAR);//call CampaignAttackerEx( 2,2,2, MORTAR      )
				CampaignAttackerEx(1, 1, 1, CommonAi.MTN_KING);//call CampaignAttackerEx( 1,1,1, MTN_KING    )
				SuicideOnPlayerEx(CommonAi.M8, CommonAi.M8, CommonAi.M7, U08_tealAi.user);//call SuicideOnPlayerEx(M8,M8,M7,user)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(3, 3, 5, CommonAi.GRYPHON);//call CampaignAttackerEx( 3,3,5, GRYPHON     )
				CampaignAttackerEx(4, 4, 6, CommonAi.RIFLEMAN);//call CampaignAttackerEx( 4,4,6, RIFLEMAN	)
				CampaignAttackerEx(1, 1, 2, CommonAi.MORTAR);//call CampaignAttackerEx( 1,1,2, MORTAR      )
				SuicideOnPlayerEx(CommonAi.M8, CommonAi.M8, CommonAi.M7, U08_tealAi.user);//call SuicideOnPlayerEx(M8,M8,M7,user)
			}//endloop
		}//endfunction

	
	}
}

