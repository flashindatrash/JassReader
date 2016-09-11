using System;
using System.Collections.Generic;

namespace Jass {

	public class U05b_tealAi {

		//
		//
		//
		public static player user = Player(3);//player user = Player(3)
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(CommonAi.ELF_FARM, null);//call CampaignAI(ELF_FARM,null)
			SetReplacements(0, 1, 3);//call SetReplacements(0,1,3)
			SetBuildUnitEx(0, 0, 1, CommonAi.TOWN_HALL);//call SetBuildUnitEx( 0,0,1, TOWN_HALL			)
			SetBuildUnitEx(2, 2, 2, CommonAi.PEASANT);//call SetBuildUnitEx( 2,2,2, PEASANT				)
			SetBuildUnitEx(0, 0, 2, CommonAi.ELF_HIGH_BARRACKS);//call SetBuildUnitEx( 0,0,2, ELF_HIGH_BARRACKS	)
			SetBuildUnitEx(0, 0, 13, CommonAi.ELF_FARM);//call SetBuildUnitEx( 0,0,13, ELF_FARM			)
			SetBuildUnitEx(0, 0, 1, CommonAi.LUMBER_MILL);//call SetBuildUnitEx( 0,0,1, LUMBER_MILL			)
			SetBuildUnitEx(5, 5, 5, CommonAi.PEASANT);//call SetBuildUnitEx( 5,5,5, PEASANT				)
			SetBuildUnitEx(0, 0, 1, CommonAi.BLACKSMITH);//call SetBuildUnitEx( 0,0,1, BLACKSMITH			)
			SetBuildUnitEx(0, 0, 1, CommonAi.HUMAN_ALTAR);//call SetBuildUnitEx( 0,0,1, HUMAN_ALTAR			)
			SetBuildUnitEx(0, 0, 1, CommonAi.KEEP);//call SetBuildUnitEx( 0,0,1, KEEP				)
			SetBuildUnitEx(0, 0, 1, CommonAi.SANCTUM);//call SetBuildUnitEx( 0,0,1, SANCTUM				)
			SetBuildUnitEx(0, 0, 1, CommonAi.CASTLE);//call SetBuildUnitEx( 0,0,1, CASTLE				)
			CampaignDefenderEx(1, 1, 3, CommonAi.HIGH_SWORDMAN);//call CampaignDefenderEx( 1,1,3, HIGH_SWORDMAN	)
			CampaignDefenderEx(1, 1, 4, CommonAi.HIGH_ARCHER);//call CampaignDefenderEx( 1,1,4, HIGH_ARCHER		)
			CampaignDefenderEx(0, 0, 1, CommonAi.PRIEST);//call CampaignDefenderEx( 0,0,1, PRIEST			)
			CampaignDefenderEx(0, 0, 1, CommonAi.SORCERESS);//call CampaignDefenderEx( 0,0,1, SORCERESS		)
			CampaignDefenderEx(0, 2, 4, CommonAi.DRAGON_HAWK);//call CampaignDefenderEx( 0,2,4, DRAGON_HAWK		)
			CampaignDefenderEx(0, 0, 1, CommonAi.ARCHMAGE);//call CampaignDefenderEx( 0,0,1, ARCHMAGE		)
			WaitForSignal();//call WaitForSignal()
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(1, 1, 2, CommonAi.HIGH_SWORDMAN);//call CampaignAttackerEx( 1,1,2, HIGH_SWORDMAN	)
			CampaignAttackerEx(1, 2, 4, CommonAi.HIGH_ARCHER);//call CampaignAttackerEx( 1,2,4, HIGH_ARCHER		)
			SuicideOnPlayerEx(CommonAi.M10, CommonAi.M8, CommonAi.M5, U08_tealAi.user);//call SuicideOnPlayerEx(M10,M8,M5,user)
			SetBuildUpgrEx(0, 1, 1, CommonAi.UPG_SORCERY);//call SetBuildUpgrEx( 0,1,1, UPG_SORCERY			)
			SetBuildUpgrEx(0, 1, 1, CommonAi.UPG_PRAYING);//call SetBuildUpgrEx( 0,1,1, UPG_PRAYING			)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(1, 1, 3, CommonAi.HIGH_SWORDMAN);//call CampaignAttackerEx( 1,1,3, HIGH_SWORDMAN	)
			CampaignAttackerEx(2, 3, 3, CommonAi.HIGH_ARCHER);//call CampaignAttackerEx( 2,3,3, HIGH_ARCHER		)
			CampaignDefenderEx(0, 2, 4, CommonAi.DRAGON_HAWK);//call CampaignDefenderEx( 0,2,4, DRAGON_HAWK		)
			SuicideOnPlayerEx(CommonAi.M10, CommonAi.M8, CommonAi.M4, U08_tealAi.user);//call SuicideOnPlayerEx(M10,M8,M4,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(0, 1, 4, CommonAi.HIGH_SWORDMAN);//call CampaignAttackerEx( 0,1,4, HIGH_SWORDMAN	)
			CampaignAttackerEx(2, 3, 4, CommonAi.HIGH_ARCHER);//call CampaignAttackerEx( 2,3,4, HIGH_ARCHER		)
			CampaignAttackerEx(1, 1, 1, CommonAi.PRIEST);//call CampaignAttackerEx( 1,1,1, PRIEST			)
			CampaignAttackerEx(0, 0, 1, CommonAi.SORCERESS);//call CampaignAttackerEx( 0,0,1, SORCERESS		)
			CampaignAttackerEx(0, 1, 2, CommonAi.BALLISTA);//call CampaignAttackerEx( 0,1,2, BALLISTA		)
			SuicideOnPlayerEx(CommonAi.M10, CommonAi.M8, CommonAi.M4, U08_tealAi.user);//call SuicideOnPlayerEx(M10,M8,M4,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2, 4, 4, CommonAi.HIGH_SWORDMAN);//call CampaignAttackerEx( 2,4,4, HIGH_SWORDMAN	)
			CampaignAttackerEx(2, 2, 4, CommonAi.HIGH_ARCHER);//call CampaignAttackerEx( 2,2,4, HIGH_ARCHER		)
			CampaignAttackerEx(0, 1, 1, CommonAi.PRIEST);//call CampaignAttackerEx( 0,1,1, PRIEST			)
			CampaignDefenderEx(0, 2, 4, CommonAi.DRAGON_HAWK);//call CampaignDefenderEx( 0,2,4, DRAGON_HAWK		)
			SuicideOnPlayerEx(CommonAi.M10, CommonAi.M8, CommonAi.M4, U08_tealAi.user);//call SuicideOnPlayerEx(M10,M8,M4,user)
			SetBuildUpgrEx(0, 0, 2, CommonAi.UPG_SORCERY);//call SetBuildUpgrEx( 0,0,2, UPG_SORCERY			)
			SetBuildUpgrEx(0, 0, 2, CommonAi.UPG_PRAYING);//call SetBuildUpgrEx( 0,0,2, UPG_PRAYING			)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2, 3, 4, CommonAi.HIGH_SWORDMAN);//call CampaignAttackerEx( 2,3,4, HIGH_SWORDMAN	)
			CampaignAttackerEx(1, 3, 4, CommonAi.HIGH_ARCHER);//call CampaignAttackerEx( 1,3,4, HIGH_ARCHER		)
			CampaignAttackerEx(1, 1, 2, CommonAi.PRIEST);//call CampaignAttackerEx( 1,1,2, PRIEST			)
			CampaignAttackerEx(0, 0, 1, CommonAi.SORCERESS);//call CampaignAttackerEx( 0,0,1, SORCERESS		)
			CampaignDefenderEx(0, 2, 4, CommonAi.DRAGON_HAWK);//call CampaignDefenderEx( 0,2,4, DRAGON_HAWK		)
			CampaignAttackerEx(0, 1, 2, CommonAi.BALLISTA);//call CampaignAttackerEx( 0,1,2, BALLISTA		)
			SuicideOnPlayerEx(CommonAi.M10, CommonAi.M8, CommonAi.M4, U08_tealAi.user);//call SuicideOnPlayerEx(M10,M8,M4,user)
			while (true) {//loop
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(1, 2, 2, CommonAi.HIGH_SWORDMAN);//call CampaignAttackerEx( 1,2,2, HIGH_SWORDMAN	)
				CampaignAttackerEx(3, 5, 7, CommonAi.HIGH_ARCHER);//call CampaignAttackerEx( 3,5,7, HIGH_ARCHER		)
				CampaignAttackerEx(1, 1, 2, CommonAi.PRIEST);//call CampaignAttackerEx( 1,1,2, PRIEST			)
				CampaignAttackerEx(0, 1, 1, CommonAi.SORCERESS);//call CampaignAttackerEx( 0,1,1, SORCERESS		)
				CampaignDefenderEx(0, 2, 4, CommonAi.DRAGON_HAWK);//call CampaignDefenderEx( 0,2,4, DRAGON_HAWK		)
				SuicideOnPlayerEx(CommonAi.M10, CommonAi.M8, CommonAi.M4, U08_tealAi.user);//call SuicideOnPlayerEx(M10,M8,M4,user)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(3, 4, 8, CommonAi.HIGH_SWORDMAN);//call CampaignAttackerEx( 3,4,8, HIGH_SWORDMAN	)
				CampaignAttackerEx(0, 2, 2, CommonAi.HIGH_ARCHER);//call CampaignAttackerEx( 0,2,2, HIGH_ARCHER		)
				CampaignAttackerEx(1, 3, 4, CommonAi.PRIEST);//call CampaignAttackerEx( 1,3,4, PRIEST			)
				CampaignAttackerEx(0, 0, 1, CommonAi.SORCERESS);//call CampaignAttackerEx( 0,0,1, SORCERESS		)
				CampaignAttackerEx(0, 1, 2, CommonAi.BALLISTA);//call CampaignAttackerEx( 0,1,2, BALLISTA		)
				SuicideOnPlayerEx(CommonAi.M10, CommonAi.M8, CommonAi.M4, U08_tealAi.user);//call SuicideOnPlayerEx(M10,M8,M4,user)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(2, 2, 5, CommonAi.HIGH_SWORDMAN);//call CampaignAttackerEx( 2,2,5, HIGH_SWORDMAN	)
				CampaignAttackerEx(1, 3, 3, CommonAi.HIGH_ARCHER);//call CampaignAttackerEx( 1,3,3, HIGH_ARCHER		)
				CampaignAttackerEx(1, 1, 2, CommonAi.PRIEST);//call CampaignAttackerEx( 1,1,2, PRIEST			)
				CampaignAttackerEx(1, 2, 4, CommonAi.SORCERESS);//call CampaignAttackerEx( 1,2,4, SORCERESS		)
				CampaignDefenderEx(0, 2, 4, CommonAi.DRAGON_HAWK);//call CampaignDefenderEx( 0,2,4, DRAGON_HAWK		)
				SuicideOnPlayerEx(CommonAi.M10, CommonAi.M8, CommonAi.M4, U08_tealAi.user);//call SuicideOnPlayerEx(M10,M8,M4,user)
			}//endloop
		}//endfunction

	
	}
}

