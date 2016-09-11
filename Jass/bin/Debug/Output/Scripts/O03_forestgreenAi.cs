using System;
using System.Collections.Generic;

namespace Jass {

	public class O03_forestgreenAi {

		//
		//
		//
		public static player user = Player(0);//player user = Player(0)
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(CommonAi.HOUSE, null);//call CampaignAI(HOUSE,null)
			SetReplacements(1, 1, 3);//call SetReplacements(1,1,3)
			SetBuildUnit(8, CommonAi.PEASANT);//call SetBuildUnit( 8, PEASANT       )
			CampaignDefenderEx(1, 1, 2, CommonAi.FOOTMEN);//call CampaignDefenderEx( 1,1,2, FOOTMEN		)
			CampaignDefenderEx(1, 1, 1, CommonAi.SORCERESS);//call CampaignDefenderEx( 1,1,1, SORCERESS	)
			WaitForSignal();//call WaitForSignal()
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(6, 6, 8, CommonAi.FOOTMAN);//call CampaignAttackerEx( 6,6,8, FOOTMAN		)
			CampaignAttackerEx(1, 1, 2, CommonAi.SORCERESS);//call CampaignAttackerEx( 1,1,2, SORCERESS	)
			SuicideOnPlayer(0, U08_tealAi.user);//call SuicideOnPlayer(0,user)
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_MELEE);//call SetBuildUpgrEx( 0,0,1, UPG_MELEE		)
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_ARMOR);//call SetBuildUpgrEx( 0,0,1, UPG_ARMOR		)
			SetBuildUpgrEx(0, 0, 2, CommonAi.UPG_MASONRY);//call SetBuildUpgrEx( 0,0,2, UPG_MASONRY		)
			SetBuildUpgrEx(1, 1, 1, CommonAi.UPG_DEFEND);//call SetBuildUpgrEx( 1,1,1, UPG_DEFEND		)
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_PRAYING);//call SetBuildUpgrEx( 0,0,1, UPG_PRAYING		)
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_SORCERY);//call SetBuildUpgrEx( 0,0,1, UPG_SORCERY		)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(6, 6, 8, CommonAi.FOOTMAN);//call CampaignAttackerEx( 6,6,8, FOOTMAN		)
			CampaignAttackerEx(1, 1, 2, CommonAi.PRIEST);//call CampaignAttackerEx( 1,1,2, PRIEST		)
			SuicideOnPlayerEx(CommonAi.M8, CommonAi.M8, CommonAi.M7, U08_tealAi.user);//call SuicideOnPlayerEx(M8,M8,M7,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(4, 4, 6, CommonAi.FOOTMAN);//call CampaignAttackerEx( 4,4,6, FOOTMAN		)
			CampaignAttackerEx(2, 2, 3, CommonAi.SORCERESS);//call CampaignAttackerEx( 2,2,3, SORCERESS	)
			SuicideOnPlayerEx(CommonAi.M8, CommonAi.M8, CommonAi.M7, U08_tealAi.user);//call SuicideOnPlayerEx(M8,M8,M7,user)
			SetBuildUpgrEx(1, 1, 2, CommonAi.UPG_MELEE);//call SetBuildUpgrEx( 1,1,2, UPG_MELEE		)
			SetBuildUpgrEx(1, 1, 2, CommonAi.UPG_ARMOR);//call SetBuildUpgrEx( 1,1,2, UPG_ARMOR		)
			SetBuildUpgrEx(2, 2, 2, CommonAi.UPG_PRAYING);//call SetBuildUpgrEx( 2,2,2, UPG_PRAYING		)
			SetBuildUpgrEx(2, 2, 2, CommonAi.UPG_SORCERY);//call SetBuildUpgrEx( 2,2,2, UPG_SORCERY		)
			while (true) {//loop
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(6, 6, 6, CommonAi.FOOTMAN);//call CampaignAttackerEx( 6,6,6, FOOTMAN		)
				CampaignAttackerEx(2, 2, 2, CommonAi.PRIEST);//call CampaignAttackerEx( 2,2,2, PRIEST		)
				CampaignAttackerEx(2, 2, 3, CommonAi.SORCERESS);//call CampaignAttackerEx( 2,2,3, SORCERESS	)
				SuicideOnPlayerEx(CommonAi.M8, CommonAi.M8, CommonAi.M7, U08_tealAi.user);//call SuicideOnPlayerEx(M8,M8,M7,user)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(5, 5, 6, CommonAi.FOOTMAN);//call CampaignAttackerEx( 5,5,6, FOOTMAN		)
				CampaignAttackerEx(2, 2, 2, CommonAi.PRIEST);//call CampaignAttackerEx( 2,2,2, PRIEST		)
				CampaignAttackerEx(3, 3, 3, CommonAi.SORCERESS);//call CampaignAttackerEx( 3,3,3, SORCERESS	)
				SuicideOnPlayerEx(CommonAi.M8, CommonAi.M8, CommonAi.M7, U08_tealAi.user);//call SuicideOnPlayerEx(M8,M8,M7,user)
			}//endloop
		}//endfunction

	
	}
}

