using System;
using System.Collections.Generic;

namespace Jass {

	public class N01_lightblueAi {

		//
		//
		//
		public static player user = Player(1);//player user = Player(1)
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(HOUSE,null);//call CampaignAI(HOUSE,null)
			SetReplacements(1,1,3);//call SetReplacements(1,1,3)
			SetBuildUnit(5, PEASANT);//call SetBuildUnit( 5, PEASANT       )
			CampaignDefenderEx(1,1,1, FOOTMEN);//call CampaignDefenderEx( 1,1,1, FOOTMEN		)
			CampaignDefenderEx(0,0,1, RIFLEMAN);//call CampaignDefenderEx( 0,0,1, RIFLEMAN	)
			WaitForSignal();//call WaitForSignal()
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(3,3,5, FOOTMAN);//call CampaignAttackerEx( 3,3,5, FOOTMAN		)
			SuicideOnPlayer(0,user);//call SuicideOnPlayer(0,user)
			SetBuildUpgrEx(0,0,1, UPG_MELEE);//call SetBuildUpgrEx( 0,0,1, UPG_MELEE		)
			SetBuildUpgrEx(0,0,1, UPG_ARMOR);//call SetBuildUpgrEx( 0,0,1, UPG_ARMOR		)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(4,4,6, RIFLEMAN);//call CampaignAttackerEx( 4,4,6, RIFLEMAN	)
			SuicideOnPlayerEx(M7,M7,M6,user);//call SuicideOnPlayerEx(M7,M7,M6,user)
			SetBuildUpgrEx(0,0,1, UPG_LEATHER);//call SetBuildUpgrEx( 0,0,1, UPG_LEATHER		)
			SetBuildUpgrEx(0,0,1, UPG_RANGED);//call SetBuildUpgrEx( 0,0,1, UPG_RANGED		)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(4,4,6, FOOTMAN);//call CampaignAttackerEx( 4,4,6, FOOTMAN		)
			CampaignAttackerEx(2,2,3, RIFLEMAN);//call CampaignAttackerEx( 2,2,3, RIFLEMAN	)
			SuicideOnPlayerEx(M7,M7,M6,user);//call SuicideOnPlayerEx(M7,M7,M6,user)
			SetBuildUpgrEx(1,1,1, UPG_GUN_RANGE);//call SetBuildUpgrEx( 1,1,1, UPG_GUN_RANGE	)
			while (true) {//loop
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(3,3,4, FOOTMAN);//call CampaignAttackerEx( 3,3,4, FOOTMAN		)
				CampaignAttackerEx(3,3,2, RIFLEMAN);//call CampaignAttackerEx( 3,3,2, RIFLEMAN	)
				SuicideOnPlayerEx(M7,M7,M6,user);//call SuicideOnPlayerEx(M7,M7,M6,user)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(3,3,5, FOOTMAN);//call CampaignAttackerEx( 3,3,5, FOOTMAN		)
				CampaignAttackerEx(1,1,2, RIFLEMAN);//call CampaignAttackerEx( 1,1,2, RIFLEMAN	)
				SuicideOnPlayerEx(M7,M7,M6,user);//call SuicideOnPlayerEx(M7,M7,M6,user)
			}//endloop
		}//endfunction

	
	}
}

