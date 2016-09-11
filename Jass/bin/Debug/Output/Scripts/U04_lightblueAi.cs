using System;
using System.Collections.Generic;

namespace Jass {

	public class U04_lightblueAi {

		//
		//
		//
		public static player user = Player(3);//player user = Player(3)
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(CommonAi.ELF_FARM, null);//call CampaignAI(ELF_FARM,null)
			SetReplacements(1, 1, 3);//call SetReplacements(1,1,3)
			do_campaign_farms = false;//set do_campaign_farms = false
			SetBuildUnitEx(0, 0, 1, CommonAi.TOWN_HALL);//call SetBuildUnitEx( 0,0,1, TOWN_HALL         )
			SetBuildUnitEx(2, 2, 2, CommonAi.PEASANT);//call SetBuildUnitEx( 2,2,2, PEASANT           )
			SetBuildUnitEx(0, 0, 1, CommonAi.ELF_HIGH_BARRACKS);//call SetBuildUnitEx( 0,0,1, ELF_HIGH_BARRACKS )
			SetBuildUnitEx(2, 2, 2, CommonAi.ZEPPLIN);//call SetBuildUnitEx( 2,2,2, ZEPPLIN           )
			SetBuildUnitEx(0, 0, 1, CommonAi.LUMBER_MILL);//call SetBuildUnitEx( 0,0,1, LUMBER_MILL       )
			SetBuildUnitEx(5, 5, 5, CommonAi.PEASANT);//call SetBuildUnitEx( 5,5,5, PEASANT           )
			SetBuildUnitEx(0, 0, 1, CommonAi.KEEP);//call SetBuildUnitEx( 0,0,1, KEEP	          )
			SetBuildUnitEx(0, 0, 1, CommonAi.SANCTUM);//call SetBuildUnitEx( 0,0,1, SANCTUM           )
			SetBuildUnitEx(0, 0, 1, CommonAi.CASTLE);//call SetBuildUnitEx( 0,0,1, CASTLE	          )
			CampaignDefenderEx(0, 0, 1, CommonAi.HIGH_SWORDMAN);//call CampaignDefenderEx( 0,0,1, HIGH_SWORDMAN	)
			CampaignDefenderEx(1, 1, 1, CommonAi.HIGH_ARCHER);//call CampaignDefenderEx( 1,1,1, HIGH_ARCHER		)
			CampaignDefenderEx(0, 0, 1, CommonAi.SORCERESS);//call CampaignDefenderEx( 0,0,1, SORCERESS		)
			CampaignDefenderEx(0, 0, 1, CommonAi.DRAGON_HAWK);//call CampaignDefenderEx( 0,0,1, DRAGON_HAWK		)
			CampaignDefenderEx(1, 1, 1, CommonAi.SYLVANUS);//call CampaignDefenderEx( 1,1,1, SYLVANUS		)
			WaitForSignal();//call WaitForSignal()
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2, 2, 2, CommonAi.HIGH_SWORDMAN);//call CampaignAttackerEx( 2,2,2, HIGH_SWORDMAN	)
			CampaignAttackerEx(2, 2, 4, CommonAi.HIGH_ARCHER);//call CampaignAttackerEx( 2,2,4, HIGH_ARCHER		)
			SuicideOnPlayerEx(CommonAi.M4, CommonAi.M4, CommonAi.M1, U08_tealAi.user);//call SuicideOnPlayerEx(M4,M4,M1,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2, 2, 2, CommonAi.HIGH_SWORDMAN);//call CampaignAttackerEx( 2,2,2, HIGH_SWORDMAN	)
			CampaignAttackerEx(2, 2, 2, CommonAi.HIGH_ARCHER);//call CampaignAttackerEx( 2,2,2, HIGH_ARCHER		)
			CampaignAttackerEx(1, 1, 1, CommonAi.PRIEST);//call CampaignAttackerEx( 1,1,1, PRIEST			)
			CampaignAttackerEx(0, 0, 1, CommonAi.SYLVANUS);//call CampaignAttackerEx( 0,0,1, SYLVANUS		)
			SuicideOnPlayerEx(CommonAi.M8, CommonAi.M8, CommonAi.M5, U08_tealAi.user);//call SuicideOnPlayerEx(M8,M8,M5,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(3, 3, 6, CommonAi.DRAGON_HAWK);//call CampaignAttackerEx( 3,3,6, DRAGON_HAWK		)
			SuicideOnPlayerEx(CommonAi.M8, CommonAi.M8, CommonAi.M5, U08_tealAi.user);//call SuicideOnPlayerEx(M8,M8,M5,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2, 2, 2, CommonAi.HIGH_SWORDMAN);//call CampaignAttackerEx( 2,2,2, HIGH_SWORDMAN	)
			CampaignAttackerEx(3, 3, 4, CommonAi.HIGH_ARCHER);//call CampaignAttackerEx( 3,3,4, HIGH_ARCHER		)
			CampaignAttackerEx(1, 1, 2, CommonAi.SORCERESS);//call CampaignAttackerEx( 1,1,2, SORCERESS		)
			CampaignAttackerEx(0, 0, 2, CommonAi.BALLISTA);//call CampaignAttackerEx( 0,0,2, BALLISTA		)
			CampaignAttackerEx(1, 1, 1, CommonAi.SYLVANUS);//call CampaignAttackerEx( 1,1,1, SYLVANUS		)
			SuicideOnPlayerEx(CommonAi.M8, CommonAi.M8, CommonAi.M5, U08_tealAi.user);//call SuicideOnPlayerEx(M8,M8,M5,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(3, 3, 6, CommonAi.DRAGON_HAWK);//call CampaignAttackerEx( 3,3,6, DRAGON_HAWK		)
			CampaignAttackerEx(3, 3, 6, CommonAi.HIGH_ARCHER);//call CampaignAttackerEx( 3,3,6, HIGH_ARCHER		)
			SuicideOnPlayerEx(CommonAi.M8, CommonAi.M8, CommonAi.M5, U08_tealAi.user);//call SuicideOnPlayerEx(M8,M8,M5,user)
			while (true) {//loop
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(2, 2, 4, CommonAi.HIGH_SWORDMAN);//call CampaignAttackerEx( 2,2,4, HIGH_SWORDMAN	)
				CampaignAttackerEx(2, 2, 4, CommonAi.HIGH_ARCHER);//call CampaignAttackerEx( 2,2,4, HIGH_ARCHER		)
				CampaignAttackerEx(1, 1, 2, CommonAi.PRIEST);//call CampaignAttackerEx( 1,1,2, PRIEST			)
				CampaignAttackerEx(1, 1, 2, CommonAi.SORCERESS);//call CampaignAttackerEx( 1,1,2, SORCERESS		)
				CampaignAttackerEx(1, 1, 2, CommonAi.BALLISTA);//call CampaignAttackerEx( 1,1,2, BALLISTA		)
				CampaignAttackerEx(1, 1, 1, CommonAi.SYLVANUS);//call CampaignAttackerEx( 1,1,1, SYLVANUS		)
				SuicideOnPlayerEx(CommonAi.M8, CommonAi.M8, CommonAi.M5, U08_tealAi.user);//call SuicideOnPlayerEx(M8,M8,M5,user)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(5, 5, 9, CommonAi.DRAGON_HAWK);//call CampaignAttackerEx( 5,5,9, DRAGON_HAWK		)
				SuicideOnPlayerEx(CommonAi.M8, CommonAi.M8, CommonAi.M5, U08_tealAi.user);//call SuicideOnPlayerEx(M8,M8,M5,user)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(2, 2, 5, CommonAi.DRAGON_HAWK);//call CampaignAttackerEx( 2,2,5, DRAGON_HAWK		)
				CampaignAttackerEx(2, 2, 4, CommonAi.HIGH_ARCHER);//call CampaignAttackerEx( 2,2,4, HIGH_ARCHER		)
				CampaignAttackerEx(2, 2, 2, CommonAi.PRIEST);//call CampaignAttackerEx( 2,2,2, PRIEST			)
				CampaignAttackerEx(1, 1, 2, CommonAi.SORCERESS);//call CampaignAttackerEx( 1,1,2, SORCERESS		)
				CampaignAttackerEx(0, 0, 1, CommonAi.SYLVANUS);//call CampaignAttackerEx( 0,0,1, SYLVANUS		)
				SuicideOnPlayerEx(CommonAi.M8, CommonAi.M8, CommonAi.M5, U08_tealAi.user);//call SuicideOnPlayerEx(M8,M8,M5,user)
			}//endloop
		}//endfunction

	
	}
}

