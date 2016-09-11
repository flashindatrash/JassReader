using System;
using System.Collections.Generic;

namespace Jass {

	public class O06_lightblueAi {

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
			SetBuildUnitEx(3, 3, 3, CommonAi.PEASANT);//call SetBuildUnitEx( 3,3,3, PEASANT			)
			SetBuildUnitEx(0, 0, 1, CommonAi.BLACKSMITH);//call SetBuildUnitEx( 0,0,1, BLACKSMITH		)
			SetBuildUnitEx(4, 4, 4, CommonAi.PEASANT);//call SetBuildUnitEx( 4,4,4, PEASANT			)
			SetBuildUnitEx(0, 0, 1, CommonAi.KEEP);//call SetBuildUnitEx( 0,0,1, KEEP			)
			SetBuildUnitEx(0, 0, 1, CommonAi.SANCTUM);//call SetBuildUnitEx( 0,0,1, SANCTUM			)
			SetBuildUnitEx(0, 0, 1, CommonAi.CASTLE);//call SetBuildUnitEx( 0,0,1, CASTLE			)
			CampaignDefenderEx(2, 2, 2, CommonAi.RIFLEMAN);//call CampaignDefenderEx( 2,2,2, RIFLEMAN	)
			CampaignDefenderEx(1, 1, 1, CommonAi.SORCERESS);//call CampaignDefenderEx( 1,1,1, SORCERESS   )
			CampaignDefenderEx(0, 0, 1, CommonAi.ARCHMAGE);//call CampaignDefenderEx( 0,0,1, ARCHMAGE    )
			WaitForSignal();//call WaitForSignal()
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(5, 5, 7, CommonAi.FOOTMEN);//call CampaignAttackerEx( 5,5,7, FOOTMEN     )
			SuicideOnPlayerEx(CommonAi.M2, CommonAi.M2, CommonAi.M1, U08_tealAi.user);//call SuicideOnPlayerEx(M2,M2,M1,user)
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_MELEE);//call SetBuildUpgrEx( 0,0,1, UPG_MELEE		)
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_RANGED);//call SetBuildUpgrEx( 0,0,1, UPG_RANGED		)
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_PRAYING);//call SetBuildUpgrEx( 0,0,1, UPG_PRAYING		)
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_SORCERY);//call SetBuildUpgrEx( 0,0,1, UPG_SORCERY		)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2, 2, 4, CommonAi.KNIGHT);//call CampaignAttackerEx( 2,2,4, KNIGHT		)
			CampaignAttackerEx(1, 1, 2, CommonAi.PRIEST);//call CampaignAttackerEx( 1,1,2, PRIEST      )
			SuicideOnPlayerEx(CommonAi.M8, CommonAi.M8, CommonAi.M7, U08_tealAi.user);//call SuicideOnPlayerEx(M8,M8,M7,user)
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_LEATHER);//call SetBuildUpgrEx( 0,0,1, UPG_LEATHER		)
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_ARMOR);//call SetBuildUpgrEx( 0,0,1, UPG_ARMOR		)
			SetBuildUpgrEx(1, 1, 1, CommonAi.UPG_PRAYING);//call SetBuildUpgrEx( 1,1,1, UPG_PRAYING		)
			SetBuildUpgrEx(1, 1, 1, CommonAi.UPG_DEFEND);//call SetBuildUpgrEx( 1,1,1, UPG_DEFEND		)
			SetBuildUpgrEx(1, 1, 2, CommonAi.UPG_SORCERY);//call SetBuildUpgrEx( 1,1,2, UPG_SORCERY		)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(5, 5, 7, CommonAi.FOOTMAN);//call CampaignAttackerEx( 5,5,7, FOOTMAN     )
			CampaignAttackerEx(2, 2, 3, CommonAi.PRIEST);//call CampaignAttackerEx( 2,2,3, PRIEST      )
			CampaignAttackerEx(1, 1, 1, CommonAi.ARCHMAGE);//call CampaignAttackerEx( 1,1,1, ARCHMAGE    )
			SuicideOnPlayerEx(CommonAi.M7, CommonAi.M7, CommonAi.M6, U08_tealAi.user);//call SuicideOnPlayerEx(M7,M7,M6,user)
			SetBuildUpgrEx(1, 1, 2, CommonAi.UPG_MELEE);//call SetBuildUpgrEx( 1,1,2, UPG_MELEE		)
			SetBuildUpgrEx(1, 1, 2, CommonAi.UPG_RANGED);//call SetBuildUpgrEx( 1,1,2, UPG_RANGED		)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(3, 3, 5, CommonAi.KNIGHT);//call CampaignAttackerEx( 3,3,5,	KNIGHT		)
			CampaignAttackerEx(2, 2, 2, CommonAi.PRIEST);//call CampaignAttackerEx( 2,2,2,	PRIEST		)
			CampaignAttackerEx(1, 1, 2, CommonAi.SORCERESS);//call CampaignAttackerEx( 1,1,2,	SORCERESS	)
			SuicideOnPlayerEx(CommonAi.M8, CommonAi.M8, CommonAi.M7, U08_tealAi.user);//call SuicideOnPlayerEx(M8,M8,M7,user)
			SetBuildUpgrEx(1, 1, 2, CommonAi.UPG_LEATHER);//call SetBuildUpgrEx( 1,1,2, UPG_LEATHER		)
			SetBuildUpgrEx(1, 1, 2, CommonAi.UPG_ARMOR);//call SetBuildUpgrEx( 1,1,2, UPG_ARMOR		)
			SetBuildUpgrEx(2, 2, 2, CommonAi.UPG_SORCERY);//call SetBuildUpgrEx( 2,2,2, UPG_SORCERY		)
			while (true) {//loop
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(4, 4, 5, CommonAi.KNIGHT);//call CampaignAttackerEx( 4,4,5, KNIGHT		)
				CampaignAttackerEx(2, 2, 3, CommonAi.PRIEST);//call CampaignAttackerEx( 2,2,3, PRIEST      )
				CampaignAttackerEx(1, 1, 1, CommonAi.ARCHMAGE);//call CampaignAttackerEx( 1,1,1, ARCHMAGE    )
				SuicideOnPlayerEx(CommonAi.M7, CommonAi.M7, CommonAi.M6, U08_tealAi.user);//call SuicideOnPlayerEx(M7,M7,M6,user)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(6, 6, 8, CommonAi.KNIGHT);//call CampaignAttackerEx( 6,6,8, KNIGHT		)
				CampaignAttackerEx(2, 2, 3, CommonAi.PRIEST);//call CampaignAttackerEx( 2,2,3, PRIEST      )
				CampaignAttackerEx(2, 2, 3, CommonAi.SORCERESS);//call CampaignAttackerEx( 2,2,3, SORCERESS   )
				SuicideOnPlayerEx(CommonAi.M8, CommonAi.M8, CommonAi.M7, U08_tealAi.user);//call SuicideOnPlayerEx(M8,M8,M7,user)
			}//endloop
		}//endfunction

	
	}
}

