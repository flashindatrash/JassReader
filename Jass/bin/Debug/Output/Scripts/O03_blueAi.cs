using System;
using System.Collections.Generic;

namespace Jass {

	public class O03_blueAi {

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
			CampaignDefenderEx(0, 0, 1, CommonAi.PRIEST);//call CampaignDefenderEx( 0,0,1, PRIEST		)
			CampaignDefenderEx(1, 1, 1, CommonAi.RIFLEMAN);//call CampaignDefenderEx( 1,1,1, RIFLEMAN	)
			CampaignDefenderEx(1, 1, 1, CommonAi.MORTAR);//call CampaignDefenderEx( 1,1,1, MORTAR		)
			CampaignDefenderEx(0, 0, 1, CommonAi.ARCHMAGE);//call CampaignDefenderEx( 0,0,1, ARCHMAGE	)
			WaitForSignal();//call WaitForSignal()
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(3, 3, 5, CommonAi.FOOTMAN);//call CampaignAttackerEx( 3,3,5, FOOTMAN		)
			CampaignAttackerEx(2, 2, 3, CommonAi.RIFLEMAN);//call CampaignAttackerEx( 2,2,3, RIFLEMAN	)
			CampaignAttackerEx(1, 1, 1, CommonAi.ARCHMAGE);//call CampaignAttackerEx( 1,1,1, ARCHMAGE	)
			SuicideOnPlayer(0, U08_tealAi.user);//call SuicideOnPlayer(0,user)
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_MELEE);//call SetBuildUpgrEx( 0,0,1, UPG_MELEE		)
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_ARMOR);//call SetBuildUpgrEx( 0,0,1, UPG_ARMOR		)
			SetBuildUpgrEx(0, 0, 2, CommonAi.UPG_MASONRY);//call SetBuildUpgrEx( 0,0,2, UPG_MASONRY		)
			SetBuildUpgrEx(1, 1, 1, CommonAi.UPG_DEFEND);//call SetBuildUpgrEx( 1,1,1, UPG_DEFEND		)
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_PRAYING);//call SetBuildUpgrEx( 0,0,1, UPG_PRAYING		)
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_SORCERY);//call SetBuildUpgrEx( 0,0,1, UPG_SORCERY		)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2, 2, 4, CommonAi.FOOTMAN);//call CampaignAttackerEx( 2,2,4, FOOTMAN		)
			CampaignAttackerEx(2, 2, 4, CommonAi.RIFLEMAN);//call CampaignAttackerEx( 2,2,4, RIFLEMAN	)
			SuicideOnPlayerEx(CommonAi.M9, CommonAi.M9, CommonAi.M8, U08_tealAi.user);//call SuicideOnPlayerEx(M9,M9,M8,user)
			SetBuildUpgrEx(1, 1, 1, CommonAi.UPG_LEATHER);//call SetBuildUpgrEx( 1,1,1, UPG_LEATHER		)
			SetBuildUpgrEx(1, 1, 1, CommonAi.UPG_RANGED);//call SetBuildUpgrEx( 1,1,1, UPG_RANGED		)
			SetBuildUpgrEx(1, 1, 1, CommonAi.UPG_GUN_RANGE);//call SetBuildUpgrEx( 1,1,1, UPG_GUN_RANGE	)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(4, 4, 6, CommonAi.FOOTMAN);//call CampaignAttackerEx( 4,4,6, FOOTMAN		)
			CampaignAttackerEx(2, 2, 3, CommonAi.RIFLEMAN);//call CampaignAttackerEx( 2,2,3, RIFLEMAN	)
			CampaignAttackerEx(1, 1, 1, CommonAi.MORTAR);//call CampaignAttackerEx( 1,1,1, MORTAR		)
			CampaignAttackerEx(1, 1, 1, CommonAi.ARCHMAGE);//call CampaignAttackerEx( 1,1,1, ARCHMAGE	)
			SuicideOnPlayerEx(CommonAi.M9, CommonAi.M9, CommonAi.M8, U08_tealAi.user);//call SuicideOnPlayerEx(M9,M9,M8,user)
			SetBuildUpgrEx(1, 1, 2, CommonAi.UPG_MELEE);//call SetBuildUpgrEx( 1,1,2, UPG_MELEE		)
			SetBuildUpgrEx(1, 1, 2, CommonAi.UPG_ARMOR);//call SetBuildUpgrEx( 1,1,2, UPG_ARMOR		)
			SetBuildUpgrEx(1, 1, 2, CommonAi.UPG_PRAYING);//call SetBuildUpgrEx( 1,1,2, UPG_PRAYING		)
			SetBuildUpgrEx(1, 1, 2, CommonAi.UPG_SORCERY);//call SetBuildUpgrEx( 1,1,2, UPG_SORCERY		)
			while (true) {//loop
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(3, 3, 4, CommonAi.FOOTMAN);//call CampaignAttackerEx( 3,3,4, FOOTMAN		)
				CampaignAttackerEx(3, 3, 2, CommonAi.RIFLEMAN);//call CampaignAttackerEx( 3,3,2, RIFLEMAN	)
				CampaignAttackerEx(2, 2, 2, CommonAi.MORTAR);//call CampaignAttackerEx( 2,2,2, MORTAR		)
				SuicideOnPlayerEx(CommonAi.M9, CommonAi.M9, CommonAi.M8, U08_tealAi.user);//call SuicideOnPlayerEx(M9,M9,M8,user)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(5, 5, 6, CommonAi.FOOTMAN);//call CampaignAttackerEx( 5,5,6, FOOTMAN		)
				CampaignAttackerEx(1, 1, 1, CommonAi.PRIEST);//call CampaignAttackerEx( 1,1,1, PRIEST		)
				CampaignAttackerEx(2, 2, 2, CommonAi.SORCERESS);//call CampaignAttackerEx( 2,2,2, SORCERESS	)
				CampaignAttackerEx(1, 1, 1, CommonAi.ARCHMAGE);//call CampaignAttackerEx( 1,1,1, ARCHMAGE	)
				SuicideOnPlayerEx(CommonAi.M9, CommonAi.M9, CommonAi.M8, U08_tealAi.user);//call SuicideOnPlayerEx(M9,M9,M8,user)
			}//endloop
		}//endfunction

	
	}
}

