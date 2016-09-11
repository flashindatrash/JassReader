using System;
using System.Collections.Generic;

namespace Jass {

	public class U05b_grayAi {

		//
		//
		//
		public static player user = Player(3);//player user = Player(3)
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(HOUSE,null);//call CampaignAI(HOUSE,null)
			SetReplacements(0,1,3);//call SetReplacements(0,1,3)
			SetBuildUnitEx(0,0,1, TOWN_HALL);//call SetBuildUnitEx( 0,0,1, TOWN_HALL		)
			SetBuildUnitEx(3,3,3, PEASANT);//call SetBuildUnitEx( 3,3,3, PEASANT			)
			SetBuildUnitEx(0,0,1, BARRACKS);//call SetBuildUnitEx( 0,0,1, BARRACKS		)
			SetBuildUnitEx(0,0,1, LUMBER_MILL);//call SetBuildUnitEx( 0,0,1, LUMBER_MILL		)
			SetBuildUnitEx(0,0,13, HOUSE);//call SetBuildUnitEx( 0,0,13, HOUSE			)
			SetBuildUnitEx(0,0,1, HUMAN_ALTAR);//call SetBuildUnitEx( 0,0,1, HUMAN_ALTAR		)
			SetBuildUnitEx(3,3,3, PEASANT);//call SetBuildUnitEx( 3,3,3, PEASANT			)
			SetBuildUnitEx(0,0,1, BLACKSMITH);//call SetBuildUnitEx( 0,0,1, BLACKSMITH		)
			SetBuildUnitEx(0,0,1, KEEP);//call SetBuildUnitEx( 0,0,1, KEEP			)
			SetBuildUnitEx(0,0,1, WORKSHOP);//call SetBuildUnitEx( 0,0,1, WORKSHOP		)
			SetBuildUnitEx(4,4,4, PEASANT);//call SetBuildUnitEx( 4,4,4, PEASANT			)
			SetBuildUnitEx(0,0,1, WATCH_TOWER);//call SetBuildUnitEx( 0,0,1, WATCH_TOWER		)
			SetBuildUnitEx(0,0,3, GUARD_TOWER);//call SetBuildUnitEx( 0,0,3, GUARD_TOWER		)
			SetBuildUnitEx(0,0,1, CASTLE);//call SetBuildUnitEx( 0,0,1, CASTLE			)
			CampaignDefenderEx(1,2,4, FOOTMAN);//call CampaignDefenderEx( 1,2,4, FOOTMAN     )
			CampaignDefenderEx(0,1,1, MORTAR);//call CampaignDefenderEx( 0,1,1, MORTAR      )
			CampaignDefenderEx(1,1,3, RIFLEMAN);//call CampaignDefenderEx( 1,1,3, RIFLEMAN    )
			CampaignDefenderEx(0,0,1, MURADIN);//call CampaignDefenderEx( 0,0,1, MURADIN		)
			WaitForSignal();//call WaitForSignal()
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(1,2,3, RIFLEMAN);//call CampaignAttackerEx( 1,2,3, RIFLEMAN    )
			SuicideOnPlayerEx(M5,M4,0,user);//call SuicideOnPlayerEx(M5,M4,0,user)
			SetBuildUpgrEx(0,0,1, UPG_MELEE);//call SetBuildUpgrEx( 0,0,1, UPG_MELEE		)
			SetBuildUpgrEx(0,0,1, UPG_RANGED);//call SetBuildUpgrEx( 0,0,1, UPG_RANGED		)
			SetBuildUpgrEx(0,0,1, UPG_MASONRY);//call SetBuildUpgrEx( 0,0,1, UPG_MASONRY		)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(0,1,1, MURADIN);//call CampaignAttackerEx( 0,1,1, MURADIN     )
			CampaignAttackerEx(2,2,3, RIFLEMAN);//call CampaignAttackerEx( 2,2,3, RIFLEMAN    )
			CampaignAttackerEx(0,1,2, MORTAR);//call CampaignAttackerEx( 0,1,2, MORTAR      )
			SuicideOnPlayerEx(M10,M8,M4,user);//call SuicideOnPlayerEx(M10,M8,M4,user)
			SetBuildUpgrEx(0,0,1, UPG_GUN_RANGE);//call SetBuildUpgrEx( 0,0,1, UPG_GUN_RANGE	)
			SetBuildUpgrEx(0,0,1, UPG_LEATHER);//call SetBuildUpgrEx( 0,0,1, UPG_LEATHER		)
			SetBuildUpgrEx(0,0,1, UPG_ARMOR);//call SetBuildUpgrEx( 0,0,1, UPG_ARMOR		)
			SetBuildUpgrEx(0,1,1, UPG_DEFEND);//call SetBuildUpgrEx( 0,1,1, UPG_DEFEND		)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2,2,4, FOOTMEN);//call CampaignAttackerEx( 2,2,4, FOOTMEN     )
			CampaignAttackerEx(3,5,8, RIFLEMAN);//call CampaignAttackerEx( 3,5,8, RIFLEMAN    )
			SuicideOnPlayerEx(M10,M8,M4,user);//call SuicideOnPlayerEx(M10,M8,M4,user)
			SetBuildUpgrEx(0,1,2, UPG_MELEE);//call SetBuildUpgrEx( 0,1,2, UPG_MELEE		)
			SetBuildUpgrEx(0,1,2, UPG_RANGED);//call SetBuildUpgrEx( 0,1,2, UPG_RANGED		)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(1,1,1, MURADIN);//call CampaignAttackerEx( 1,1,1, MURADIN	)
			CampaignAttackerEx(0,2,4, MORTAR);//call CampaignAttackerEx( 0,2,4, MORTAR      )
			SuicideOnPlayerEx(M10,M8,M4,user);//call SuicideOnPlayerEx(M10,M8,M4,user)
			SetBuildUpgrEx(0,1,2, UPG_LEATHER);//call SetBuildUpgrEx( 0,1,2, UPG_LEATHER		)
			SetBuildUpgrEx(0,1,2, UPG_ARMOR);//call SetBuildUpgrEx( 0,1,2, UPG_ARMOR		)
			while (true) {//loop
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(1,1,1, MURADIN);//call CampaignAttackerEx( 1,1,1, MURADIN     )
				CampaignAttackerEx(3,5,7, RIFLEMAN);//call CampaignAttackerEx( 3,5,7, RIFLEMAN    )
				CampaignAttackerEx(1,1,2, MORTAR);//call CampaignAttackerEx( 1,1,2, MORTAR      )
				SuicideOnPlayerEx(M10,M8,M4,user);//call SuicideOnPlayerEx(M10,M8,M4,user)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(1,2,3, RIFLEMAN);//call CampaignAttackerEx( 1,2,3, RIFLEMAN    )
				CampaignAttackerEx(1,2,3, MORTAR);//call CampaignAttackerEx( 1,2,3, MORTAR	    )
				SuicideOnPlayerEx(M10,M8,M4,user);//call SuicideOnPlayerEx(M10,M8,M4,user)
			}//endloop
		}//endfunction

	
	}
}

