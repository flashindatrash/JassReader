using System;
using System.Collections.Generic;

namespace Jass {

	public class U04b_darkgreenAi {

		//
		//
		//
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(ELF_FARM,null);//call CampaignAI(ELF_FARM,null)
			SetReplacements(0,1,3);//call SetReplacements(0,1,3)
			SetBuildUnitEx(0,0,1, TOWN_HALL);//call SetBuildUnitEx( 0,0,1, TOWN_HALL         )
			SetBuildUnitEx(2,2,2, PEASANT);//call SetBuildUnitEx( 2,2,2, PEASANT           )
			SetBuildUnitEx(0,0,1, ELF_HIGH_BARRACKS);//call SetBuildUnitEx( 0,0,1, ELF_HIGH_BARRACKS )
			SetBuildUnitEx(0,0,1, LUMBER_MILL);//call SetBuildUnitEx( 0,0,1, LUMBER_MILL       )
			SetBuildUnitEx(0,0,9, ELF_FARM);//call SetBuildUnitEx( 0,0,9, ELF_FARM          )
			SetBuildUnitEx(5,5,5, PEASANT);//call SetBuildUnitEx( 5,5,5, PEASANT           )
			SetBuildUnitEx(0,0,1, KEEP);//call SetBuildUnitEx( 0,0,1, KEEP	          )
			SetBuildUnitEx(0,0,1, SANCTUM);//call SetBuildUnitEx( 0,0,1, SANCTUM           )
			SetBuildUnitEx(0,0,1, CASTLE);//call SetBuildUnitEx( 0,0,1, CASTLE	          )
			CampaignDefenderEx(0,0,2, HIGH_FOOTMAN);//call CampaignDefenderEx( 0,0,2, HIGH_FOOTMAN	)
			CampaignDefenderEx(1,2,3, HIGH_ARCHER);//call CampaignDefenderEx( 1,2,3, HIGH_ARCHER		)
			CampaignDefenderEx(0,0,2, SORCERESS);//call CampaignDefenderEx( 0,0,2, SORCERESS		)
			CampaignDefenderEx(1,1,3, DRAGON_HAWK);//call CampaignDefenderEx( 1,1,3, DRAGON_HAWK		)
			WaitForSignal();//call WaitForSignal()
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(1,2,4, DRAGON_HAWK);//call CampaignAttackerEx( 1,2,4, DRAGON_HAWK		)
			CampaignAttackerEx(1,2,2, HIGH_FOOTMAN);//call CampaignAttackerEx( 1,2,2, HIGH_FOOTMAN	)
			CampaignAttackerEx(1,2,4, HIGH_ARCHER);//call CampaignAttackerEx( 1,2,4, HIGH_ARCHER		)
			SuicideOnPlayer(0,user);//call SuicideOnPlayer(0,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2,2,2, HIGH_FOOTMAN);//call CampaignAttackerEx( 2,2,2, HIGH_FOOTMAN	)
			CampaignAttackerEx(1,4,4, HIGH_ARCHER);//call CampaignAttackerEx( 1,4,4, HIGH_ARCHER		)
			CampaignAttackerEx(1,1,2, PRIEST);//call CampaignAttackerEx( 1,1,2, PRIEST			)
			CampaignAttackerEx(0,1,2, SORCERESS);//call CampaignAttackerEx( 0,1,2, SORCERESS		)
			SuicideOnPlayerEx(M8,M6,M4,user);//call SuicideOnPlayerEx(M8,M6,M4,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2,4,7, DRAGON_HAWK);//call CampaignAttackerEx( 2,4,7, DRAGON_HAWK		)
			SuicideOnPlayerEx(M8,M6,M4,user);//call SuicideOnPlayerEx(M8,M6,M4,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(1,4,4, HIGH_FOOTMAN);//call CampaignAttackerEx( 1,4,4, HIGH_FOOTMAN	)
			CampaignAttackerEx(1,4,6, HIGH_ARCHER);//call CampaignAttackerEx( 1,4,6, HIGH_ARCHER		)
			CampaignAttackerEx(1,0,2, PRIEST);//call CampaignAttackerEx( 1,0,2, PRIEST			)
			CampaignAttackerEx(0,2,2, SORCERESS);//call CampaignAttackerEx( 0,2,2, SORCERESS		)
			CampaignAttackerEx(0,1,2, BALLISTA);//call CampaignAttackerEx( 0,1,2, BALLISTA		)
			SuicideOnPlayerEx(M8,M6,M4,user);//call SuicideOnPlayerEx(M8,M6,M4,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2,4,6, DRAGON_HAWK);//call CampaignAttackerEx( 2,4,6, DRAGON_HAWK		)
			CampaignAttackerEx(2,4,6, HIGH_ARCHER);//call CampaignAttackerEx( 2,4,6, HIGH_ARCHER		)
			SuicideOnPlayerEx(M8,M6,M4,user);//call SuicideOnPlayerEx(M8,M6,M4,user)
			while (true) {//loop
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(2,4,6, HIGH_FOOTMAN);//call CampaignAttackerEx( 2,4,6, HIGH_FOOTMAN	)
				CampaignAttackerEx(2,2,4, HIGH_ARCHER);//call CampaignAttackerEx( 2,2,4, HIGH_ARCHER		)
				CampaignAttackerEx(1,2,2, PRIEST);//call CampaignAttackerEx( 1,2,2, PRIEST			)
				CampaignAttackerEx(0,1,2, SORCERESS);//call CampaignAttackerEx( 0,1,2, SORCERESS		)
				CampaignAttackerEx(0,1,2, BALLISTA);//call CampaignAttackerEx( 0,1,2, BALLISTA		)
				SuicideOnPlayerEx(M8,M6,M4,user);//call SuicideOnPlayerEx(M8,M6,M4,user)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(3,6,9, DRAGON_HAWK);//call CampaignAttackerEx( 3,6,9, DRAGON_HAWK		)
				SuicideOnPlayerEx(M8,M6,M4,user);//call SuicideOnPlayerEx(M8,M6,M4,user)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(1,4,6, DRAGON_HAWK);//call CampaignAttackerEx( 1,4,6, DRAGON_HAWK		)
				CampaignAttackerEx(2,2,4, HIGH_ARCHER);//call CampaignAttackerEx( 2,2,4, HIGH_ARCHER		)
				CampaignAttackerEx(1,2,2, PRIEST);//call CampaignAttackerEx( 1,2,2, PRIEST			)
				CampaignAttackerEx(0,1,2, SORCERESS);//call CampaignAttackerEx( 0,1,2, SORCERESS		)
				SuicideOnPlayerEx(M8,M6,M4,user);//call SuicideOnPlayerEx(M8,M6,M4,user)
			}//endloop
		}//endfunction

	
	}
}

