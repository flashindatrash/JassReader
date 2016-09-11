using System;
using System.Collections.Generic;

namespace Jass {

	public class O03_lightblueAi {

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
			CampaignDefenderEx(1,1,2, FOOTMEN);//call CampaignDefenderEx( 1,1,2, FOOTMEN	)
			CampaignDefenderEx(1,1,1, PRIEST);//call CampaignDefenderEx( 1,1,1, PRIEST	)
			CampaignDefenderEx(0,0,1, PALADIN);//call CampaignDefenderEx( 0,0,1, PALADIN	)
			WaitForSignal();//call WaitForSignal()
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(6,6,8, FOOTMAN);//call CampaignAttackerEx( 6,6,8, FOOTMAN	)
			CampaignAttackerEx(1,1,1, PALADIN);//call CampaignAttackerEx( 1,1,1, PALADIN	)
			SuicideOnPlayer(0,user);//call SuicideOnPlayer(0,user)
			SetBuildUpgrEx(0,0,1, UPG_MELEE);//call SetBuildUpgrEx( 0,0,1, UPG_MELEE	)
			SetBuildUpgrEx(0,0,1, UPG_ARMOR);//call SetBuildUpgrEx( 0,0,1, UPG_ARMOR	)
			SetBuildUpgrEx(0,0,2, UPG_MASONRY);//call SetBuildUpgrEx( 0,0,2, UPG_MASONRY	)
			SetBuildUpgrEx(1,1,1, UPG_DEFEND);//call SetBuildUpgrEx( 1,1,1, UPG_DEFEND	)
			SetBuildUpgrEx(0,0,1, UPG_PRAYING);//call SetBuildUpgrEx( 0,0,1, UPG_PRAYING	)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(6,6,7, FOOTMAN);//call CampaignAttackerEx( 6,6,7, FOOTMAN	)
			CampaignAttackerEx(2,2,3, PRIEST);//call CampaignAttackerEx( 2,2,3, PRIEST	)
			SuicideOnPlayerEx(M8,M8,M7,user);//call SuicideOnPlayerEx(M8,M8,M7,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(6,6,8, FOOTMAN);//call CampaignAttackerEx( 6,6,8, FOOTMAN	)
			CampaignAttackerEx(1,1,1, PALADIN);//call CampaignAttackerEx( 1,1,1, PALADIN	)
			SuicideOnPlayerEx(M8,M8,M7,user);//call SuicideOnPlayerEx(M8,M8,M7,user)
			SetBuildUpgrEx(1,1,2, UPG_MELEE);//call SetBuildUpgrEx( 1,1,2, UPG_MELEE	)
			SetBuildUpgrEx(1,1,2, UPG_ARMOR);//call SetBuildUpgrEx( 1,1,2, UPG_ARMOR	)
			SetBuildUpgrEx(1,1,2, UPG_PRAYING);//call SetBuildUpgrEx( 1,1,2, UPG_PRAYING	)
			while (true) {//loop
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(6,6,8, FOOTMAN);//call CampaignAttackerEx( 6,6,8, FOOTMAN	)
				CampaignAttackerEx(2,2,2, PRIEST);//call CampaignAttackerEx( 2,2,2, PRIEST	)
				CampaignAttackerEx(1,1,1, PALADIN);//call CampaignAttackerEx( 1,1,1, PALADIN	)
				SuicideOnPlayerEx(M8,M8,M7,user);//call SuicideOnPlayerEx(M8,M8,M7,user)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(6,6,7, FOOTMAN);//call CampaignAttackerEx( 6,6,7, FOOTMAN	)
				CampaignAttackerEx(2,2,3, PRIEST);//call CampaignAttackerEx( 2,2,3, PRIEST	)
				CampaignAttackerEx(1,1,1, PALADIN);//call CampaignAttackerEx( 1,1,1, PALADIN	)
				SuicideOnPlayerEx(M8,M8,M7,user);//call SuicideOnPlayerEx(M8,M8,M7,user)
			}//endloop
		}//endfunction

	
	}
}

