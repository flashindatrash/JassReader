using System;
using System.Collections.Generic;

namespace Jass {

	public class U04b_brownAi {

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
			SetBuildUnitEx(0, 0, 1, CommonAi.TOWN_HALL);//call SetBuildUnitEx( 0,0,1, TOWN_HALL         )
			SetBuildUnitEx(2, 2, 2, CommonAi.PEASANT);//call SetBuildUnitEx( 2,2,2, PEASANT           )
			SetBuildUnitEx(0, 0, 1, CommonAi.ELF_HIGH_BARRACKS);//call SetBuildUnitEx( 0,0,1, ELF_HIGH_BARRACKS )
			SetBuildUnitEx(2, 2, 2, CommonAi.ZEPPLIN);//call SetBuildUnitEx( 2,2,2, ZEPPLIN           )
			SetBuildUnitEx(0, 0, 1, CommonAi.LUMBER_MILL);//call SetBuildUnitEx( 0,0,1, LUMBER_MILL       )
			SetBuildUnitEx(0, 0, 9, CommonAi.ELF_FARM);//call SetBuildUnitEx( 0,0,9, ELF_FARM          )
			SetBuildUnitEx(5, 5, 5, CommonAi.PEASANT);//call SetBuildUnitEx( 5,5,5, PEASANT           )
			SetBuildUnitEx(0, 0, 1, CommonAi.KEEP);//call SetBuildUnitEx( 0,0,1, KEEP	          )
			SetBuildUnitEx(0, 0, 1, CommonAi.SANCTUM);//call SetBuildUnitEx( 0,0,1, SANCTUM           )
			SetBuildUnitEx(0, 0, 1, CommonAi.CASTLE);//call SetBuildUnitEx( 0,0,1, CASTLE	          )
			CampaignDefenderEx(1, 1, 3, CommonAi.HIGH_FOOTMAN);//call CampaignDefenderEx( 1,1,3, HIGH_FOOTMAN	)
			CampaignDefenderEx(1, 1, 4, CommonAi.HIGH_ARCHER);//call CampaignDefenderEx( 1,1,4, HIGH_ARCHER		)
			CampaignDefenderEx(0, 0, 1, CommonAi.PRIEST);//call CampaignDefenderEx( 0,0,1, PRIEST			)
			CampaignDefenderEx(0, 0, 1, CommonAi.BALLISTA);//call CampaignDefenderEx( 0,0,1, BALLISTA		)
			WaitForSignal();//call WaitForSignal()
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(1, 1, 2, CommonAi.HIGH_FOOTMAN);//call CampaignAttackerEx( 1,1,2, HIGH_FOOTMAN	)
			CampaignAttackerEx(1, 2, 4, CommonAi.HIGH_ARCHER);//call CampaignAttackerEx( 1,2,4, HIGH_ARCHER		)
			SuicideOnPlayerEx(CommonAi.M9, CommonAi.M6, CommonAi.M3, U08_tealAi.user);//call SuicideOnPlayerEx(M9,M6,M3,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(1, 1, 3, CommonAi.HIGH_FOOTMAN);//call CampaignAttackerEx( 1,1,3, HIGH_FOOTMAN	)
			CampaignAttackerEx(2, 3, 3, CommonAi.HIGH_ARCHER);//call CampaignAttackerEx( 2,3,3, HIGH_ARCHER		)
			SuicideOnPlayerEx(CommonAi.M10, CommonAi.M8, CommonAi.M4, U08_tealAi.user);//call SuicideOnPlayerEx(M10,M8,M4,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(0, 1, 4, CommonAi.HIGH_FOOTMAN);//call CampaignAttackerEx( 0,1,4, HIGH_FOOTMAN	)
			CampaignAttackerEx(2, 3, 4, CommonAi.HIGH_ARCHER);//call CampaignAttackerEx( 2,3,4, HIGH_ARCHER		)
			CampaignAttackerEx(1, 1, 1, CommonAi.PRIEST);//call CampaignAttackerEx( 1,1,1, PRIEST			)
			CampaignAttackerEx(0, 1, 2, CommonAi.BALLISTA);//call CampaignAttackerEx( 0,1,2, BALLISTA		)
			SuicideOnPlayerEx(CommonAi.M10, CommonAi.M8, CommonAi.M4, U08_tealAi.user);//call SuicideOnPlayerEx(M10,M8,M4,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2, 4, 4, CommonAi.HIGH_FOOTMAN);//call CampaignAttackerEx( 2,4,4, HIGH_FOOTMAN	)
			CampaignAttackerEx(2, 2, 4, CommonAi.HIGH_ARCHER);//call CampaignAttackerEx( 2,2,4, HIGH_ARCHER		)
			CampaignAttackerEx(0, 1, 1, CommonAi.PRIEST);//call CampaignAttackerEx( 0,1,1, PRIEST			)
			SuicideOnPlayerEx(CommonAi.M10, CommonAi.M8, CommonAi.M4, U08_tealAi.user);//call SuicideOnPlayerEx(M10,M8,M4,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2, 3, 4, CommonAi.HIGH_FOOTMAN);//call CampaignAttackerEx( 2,3,4, HIGH_FOOTMAN	)
			CampaignAttackerEx(1, 3, 4, CommonAi.HIGH_ARCHER);//call CampaignAttackerEx( 1,3,4, HIGH_ARCHER		)
			CampaignAttackerEx(1, 1, 2, CommonAi.PRIEST);//call CampaignAttackerEx( 1,1,2, PRIEST			)
			CampaignAttackerEx(0, 1, 2, CommonAi.BALLISTA);//call CampaignAttackerEx( 0,1,2, BALLISTA		)
			SuicideOnPlayerEx(CommonAi.M10, CommonAi.M8, CommonAi.M4, U08_tealAi.user);//call SuicideOnPlayerEx(M10,M8,M4,user)
			while (true) {//loop
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(1, 2, 2, CommonAi.HIGH_FOOTMAN);//call CampaignAttackerEx( 1,2,2, HIGH_FOOTMAN)
				CampaignAttackerEx(3, 5, 7, CommonAi.HIGH_ARCHER);//call CampaignAttackerEx( 3,5,7, HIGH_ARCHER )
				CampaignAttackerEx(1, 1, 2, CommonAi.PRIEST);//call CampaignAttackerEx( 1,1,2, PRIEST      )
				SuicideOnPlayerEx(CommonAi.M10, CommonAi.M8, CommonAi.M4, U08_tealAi.user);//call SuicideOnPlayerEx(M10,M8,M4,user)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(3, 4, 8, CommonAi.HIGH_FOOTMAN);//call CampaignAttackerEx( 3,4,8, HIGH_FOOTMAN)
				CampaignAttackerEx(0, 2, 2, CommonAi.HIGH_ARCHER);//call CampaignAttackerEx( 0,2,2, HIGH_ARCHER )
				CampaignAttackerEx(1, 3, 4, CommonAi.PRIEST);//call CampaignAttackerEx( 1,3,4, PRIEST      )
				CampaignAttackerEx(0, 1, 2, CommonAi.BALLISTA);//call CampaignAttackerEx( 0,1,2, BALLISTA )
				SuicideOnPlayerEx(CommonAi.M10, CommonAi.M8, CommonAi.M4, U08_tealAi.user);//call SuicideOnPlayerEx(M10,M8,M4,user)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(2, 2, 5, CommonAi.HIGH_FOOTMAN);//call CampaignAttackerEx( 2,2,5, HIGH_FOOTMAN)
				CampaignAttackerEx(1, 3, 3, CommonAi.HIGH_ARCHER);//call CampaignAttackerEx( 1,3,3, HIGH_ARCHER )
				CampaignAttackerEx(1, 1, 2, CommonAi.PRIEST);//call CampaignAttackerEx( 1,1,2, PRIEST      )
				SuicideOnPlayerEx(CommonAi.M10, CommonAi.M8, CommonAi.M4, U08_tealAi.user);//call SuicideOnPlayerEx(M10,M8,M4,user)
			}//endloop
		}//endfunction

	
	}
}

