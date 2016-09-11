using System;
using System.Collections.Generic;

namespace Jass {

	public class O03_grayAi {

		//
		//
		//
		public static player user = Player(0);//player user = Player(0)
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(HOUSE,null);//call CampaignAI(HOUSE,null)
			SetReplacements(1,1,3);//call SetReplacements(1,1,3)
			SetBuildUnit(8, PEASANT);//call SetBuildUnit( 8, PEASANT       )
			CampaignDefenderEx(1,1,1, RIFLEMAN);//call CampaignDefenderEx( 1,1,1, RIFLEMAN	)
			CampaignDefenderEx(1,1,1, MORTAR);//call CampaignDefenderEx( 1,1,1, MORTAR		)
			WaitForSignal();//call WaitForSignal()
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(4,4,5, RIFLEMAN);//call CampaignAttackerEx( 4,4,5, RIFLEMAN	)
			CampaignAttackerEx(1,1,2, MORTAR);//call CampaignAttackerEx( 1,1,2, MORTAR		)
			SuicideOnPlayer(0,user);//call SuicideOnPlayer(0,user)
			SetBuildUpgrEx(0,0,1, UPG_LEATHER);//call SetBuildUpgrEx( 0,0,1, UPG_LEATHER		)
			SetBuildUpgrEx(0,0,1, UPG_RANGED);//call SetBuildUpgrEx( 0,0,1, UPG_RANGED		)
			SetBuildUpgrEx(0,0,2, UPG_MASONRY);//call SetBuildUpgrEx( 0,0,2, UPG_MASONRY		)
			SetBuildUpgrEx(1,1,1, UPG_DEFEND);//call SetBuildUpgrEx( 1,1,1, UPG_DEFEND		)
			SetBuildUpgrEx(0,0,1, UPG_GUN_RANGE);//call SetBuildUpgrEx( 0,0,1, UPG_GUN_RANGE	)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(4,4,6, RIFLEMAN);//call CampaignAttackerEx( 4,4,6, RIFLEMAN	)
			CampaignAttackerEx(1,1,1, MTN_KING);//call CampaignAttackerEx( 1,1,1, MTN_KING 	)
			SuicideOnPlayerEx(M8,M8,M8,user);//call SuicideOnPlayerEx(M8,M8,M8,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(5,5,6, RIFLEMAN);//call CampaignAttackerEx( 5,5,6, RIFLEMAN	)
			CampaignAttackerEx(2,2,3, MORTAR);//call CampaignAttackerEx( 2,2,3, MORTAR		)
			SuicideOnPlayerEx(M8,M8,M8,user);//call SuicideOnPlayerEx(M8,M8,M8,user)
			SetBuildUpgrEx(1,1,2, UPG_LEATHER);//call SetBuildUpgrEx( 1,1,2, UPG_LEATHER		)
			SetBuildUpgrEx(1,1,2, UPG_RANGED);//call SetBuildUpgrEx( 1,1,2, UPG_RANGED		)
			SetBuildUpgrEx(1,1,1, UPG_GUN_RANGE);//call SetBuildUpgrEx( 1,1,1, UPG_GUN_RANGE	)
			while (true) {//loop
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(5,5,6, RIFLEMAN);//call CampaignAttackerEx( 5,5,6, RIFLEMAN	)
				CampaignAttackerEx(1,1,2, MORTAR);//call CampaignAttackerEx( 1,1,2, MORTAR		)
				CampaignAttackerEx(1,1,1, MTN_KING);//call CampaignAttackerEx( 1,1,1, MTN_KING 	)
				SuicideOnPlayerEx(M8,M8,M8,user);//call SuicideOnPlayerEx(M8,M8,M8,user)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(6,6,6, RIFLEMAN);//call CampaignAttackerEx( 6,6,6, RIFLEMAN	)
				CampaignAttackerEx(2,2,3, MORTAR);//call CampaignAttackerEx( 2,2,3, MORTAR		)
				SuicideOnPlayerEx(M8,M8,M8,user);//call SuicideOnPlayerEx(M8,M8,M8,user)
			}//endloop
		}//endfunction

	
	}
}

