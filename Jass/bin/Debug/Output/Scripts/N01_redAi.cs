using System;
using System.Collections.Generic;

namespace Jass {

	public class N01_redAi {

		//
		//
		//
		public static player user = Player(1);//player user = Player(1)
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(CommonAi.BURROW, null);//call CampaignAI(BURROW,null)
			SetReplacements(1, 1, 3);//call SetReplacements(1,1,3)
			campaign_wood_peons = 100;//set campaign_wood_peons = 100
			campaign_gold_peons = 0;//set campaign_gold_peons = 0
			SetBuildUnit(2, CommonAi.PEON);//call SetBuildUnit	( 2, PEON				)
			CampaignDefenderEx(1, 1, 0, CommonAi.HEAD_HUNTER);//call CampaignDefenderEx( 1,1,0, HEAD_HUNTER	)
			CampaignDefenderEx(0, 0, 1, CommonAi.GRUNT);//call CampaignDefenderEx( 0,0,1, GRUNT		)
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_ORC_SPIKES);//call SetBuildUpgrEx( 0,0,1, UPG_ORC_SPIKES	)
			WaitForSignal();//call WaitForSignal()
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2, 2, 3, CommonAi.GRUNT);//call CampaignAttackerEx( 2,2,3, GRUNT       )
			SuicideOnPlayerEx(CommonAi.M6, CommonAi.M6, CommonAi.M5, U08_tealAi.user);//call SuicideOnPlayerEx(M6,M6,M5,user)
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_ORC_ARMOR);//call SetBuildUpgrEx( 0,0,1, UPG_ORC_ARMOR	)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2, 2, 3, CommonAi.HEAD_HUNTER);//call CampaignAttackerEx( 2,2,3, HEAD_HUNTER )
			SuicideOnPlayerEx(CommonAi.M6, CommonAi.M6, CommonAi.M5, U08_tealAi.user);//call SuicideOnPlayerEx(M6,M6,M5,user)
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_ORC_RANGED);//call SetBuildUpgrEx( 0,0,1, UPG_ORC_RANGED	)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2, 2, 3, CommonAi.GRUNT);//call CampaignAttackerEx( 2,2,3, GRUNT       )
			SuicideOnPlayerEx(CommonAi.M6, CommonAi.M6, CommonAi.M5, U08_tealAi.user);//call SuicideOnPlayerEx(M6,M6,M5,user)
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_ORC_MELEE);//call SetBuildUpgrEx( 0,0,1, UPG_ORC_MELEE	)
			while (true) {//loop
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(2, 2, 3, CommonAi.GRUNT);//call CampaignAttackerEx( 2,2,3, GRUNT		)
				CampaignAttackerEx(0, 0, 1, CommonAi.HEAD_HUNTER);//call CampaignAttackerEx( 0,0,1, HEAD_HUNTER	)
				SuicideOnPlayerEx(CommonAi.M6, CommonAi.M6, CommonAi.M5, U08_tealAi.user);//call SuicideOnPlayerEx(M6,M6,M5,user)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(4, 4, 6, CommonAi.GRUNT);//call CampaignAttackerEx( 4,4,6, GRUNT       )
				SuicideOnPlayerEx(CommonAi.M6, CommonAi.M6, CommonAi.M5, U08_tealAi.user);//call SuicideOnPlayerEx(M6,M6,M5,user)
			}//endloop
		}//endfunction

	
	}
}

