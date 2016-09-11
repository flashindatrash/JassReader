using System;
using System.Collections.Generic;

namespace Jass {

	public class O02_06x11Ai {

		//
		//
		//
		public static player user = PlayerEx(03);//player user = PlayerEx(03)
		public const int ELITE_FOOTMAN = 'hcth';//constant integer ELITE_FOOTMAN  = 'hcth'
		public const int CHAPLIN = 'nchp';//constant integer CHAPLIN        = 'nchp'
		public const int HYDROMANCER = 'nhym';//constant integer HYDROMANCER    = 'nhym'
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(HOUSE,null);//call CampaignAI(HOUSE,null)
			SetReplacements(2,2,3);//call SetReplacements(2,2,3)
			SetCaptainHome(BOTH_CAPTAINS,1158,8175);//call SetCaptainHome(BOTH_CAPTAINS,1158,8175)
			//
			//
			//
			//
			//
			//
			//
			//
			//
			//
			//
			//
			//
			//
			//
			CampaignDefenderEx(2,2,2, ELITE_FOOTMAN);//call CampaignDefenderEx( 2,2,2, ELITE_FOOTMAN )
			CampaignDefenderEx(1,1,1, KNIGHT);//call CampaignDefenderEx( 1,1,1, KNIGHT        )
			CampaignDefenderEx(1,1,1, HYDROMANCER);//call CampaignDefenderEx( 1,1,1, HYDROMANCER   )
			CampaignDefenderEx(1,1,1, CHAPLIN);//call CampaignDefenderEx( 1,1,1, CHAPLIN       )
			CampaignDefenderEx(1,1,1, RIFLEMAN);//call CampaignDefenderEx( 1,1,1, RIFLEMAN      )
			WaitForSignal();//call WaitForSignal()
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(5,5,5, ELITE_FOOTMAN);//call CampaignAttackerEx( 5,5,5, ELITE_FOOTMAN )
			CampaignAttackerEx(5,5,5, RIFLEMAN);//call CampaignAttackerEx( 5,5,5, RIFLEMAN      )
			CampaignAttackerEx(3,3,3, CHAPLIN);//call CampaignAttackerEx( 3,3,3, CHAPLIN       )
			SuicideOnPlayerEx(M2,M2,M2,user);//call SuicideOnPlayerEx(M2,M2,M2,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(5,5,5, KNIGHT);//call CampaignAttackerEx( 5,5,5, KNIGHT        )
			CampaignAttackerEx(5,5,5, RIFLEMAN);//call CampaignAttackerEx( 5,5,5, RIFLEMAN      )
			CampaignAttackerEx(2,2,2, TANK);//call CampaignAttackerEx( 2,2,2, TANK          )
			CampaignAttackerEx(3,3,3, HYDROMANCER);//call CampaignAttackerEx( 3,3,3, HYDROMANCER   )
			SuicideOnPlayerEx(M3,M3,M3,user);//call SuicideOnPlayerEx(M3,M3,M3,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(7,7,7, GRYPHON);//call CampaignAttackerEx( 7,7,7, GRYPHON       )
			CampaignAttackerEx(4,4,4, TANK);//call CampaignAttackerEx( 4,4,4, TANK          )
			CampaignAttackerEx(4,4,4, KNIGHT);//call CampaignAttackerEx( 4,4,4, KNIGHT        )
			CampaignAttackerEx(4,4,4, HYDROMANCER);//call CampaignAttackerEx( 4,4,4, HYDROMANCER   )
			SuicideOnPlayerEx(M4,M4,M4,user);//call SuicideOnPlayerEx(M4,M4,M4,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(6,6,6, KNIGHT);//call CampaignAttackerEx( 6,6,6, KNIGHT        )
			CampaignAttackerEx(7,7,7, GRYPHON);//call CampaignAttackerEx( 7,7,7, GRYPHON       )
			CampaignAttackerEx(4,4,4, HYDROMANCER);//call CampaignAttackerEx( 4,4,4, HYDROMANCER   )
			CampaignAttackerEx(3,3,3, CHAPLIN);//call CampaignAttackerEx( 3,3,3, CHAPLIN       )
			SuicideOnPlayerEx(M3,M3,M3,user);//call SuicideOnPlayerEx(M3,M3,M3,user)
			while (true) {//loop
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(8,8,8, ELITE_FOOTMAN);//call CampaignAttackerEx( 8,8,8, ELITE_FOOTMAN )
				CampaignAttackerEx(6,6,6, RIFLEMAN);//call CampaignAttackerEx( 6,6,6, RIFLEMAN      )
				CampaignAttackerEx(4,4,4, CHAPLIN);//call CampaignAttackerEx( 4,4,4, CHAPLIN       )
				SuicideOnPlayerEx(M4,M4,M4,user);//call SuicideOnPlayerEx(M4,M4,M4,user)
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(6,6,6, GRYPHON);//call CampaignAttackerEx( 6,6,6, GRYPHON       )
				CampaignAttackerEx(4,4,4, CHAPLIN);//call CampaignAttackerEx( 4,4,4, CHAPLIN       )
				CampaignAttackerEx(5,5,5, TANK);//call CampaignAttackerEx( 5,5,5, TANK          )
				SuicideOnPlayerEx(M4,M4,M4,user);//call SuicideOnPlayerEx(M4,M4,M4,user)
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(6,6,6, KNIGHT);//call CampaignAttackerEx( 6,6,6, KNIGHT        )
				CampaignAttackerEx(4,4,4, CHAPLIN);//call CampaignAttackerEx( 4,4,4, CHAPLIN       )
				CampaignAttackerEx(5,5,5, RIFLEMAN);//call CampaignAttackerEx( 5,5,5, RIFLEMAN      )
				CampaignAttackerEx(4,4,4, HYDROMANCER);//call CampaignAttackerEx( 4,4,4, HYDROMANCER   )
				SuicideOnPlayerEx(M3,M3,M3,user);//call SuicideOnPlayerEx(M3,M3,M3,user)
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(9,9,9, ELITE_FOOTMAN);//call CampaignAttackerEx( 9,9,9, ELITE_FOOTMAN )
				CampaignAttackerEx(5,5,5, RIFLEMAN);//call CampaignAttackerEx( 5,5,5, RIFLEMAN      )
				CampaignAttackerEx(4,4,4, CHAPLIN);//call CampaignAttackerEx( 4,4,4, CHAPLIN       )
				CampaignAttackerEx(4,4,4, HYDROMANCER);//call CampaignAttackerEx( 4,4,4, HYDROMANCER   )
				SuicideOnPlayerEx(M4,M4,M4,user);//call SuicideOnPlayerEx(M4,M4,M4,user)
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(9,9,9, GRYPHON);//call CampaignAttackerEx( 9,9,9, GRYPHON       )
				CampaignAttackerEx(6,6,6, KNIGHT);//call CampaignAttackerEx( 6,6,6, KNIGHT        )
				CampaignAttackerEx(4,4,4, CHAPLIN);//call CampaignAttackerEx( 4,4,4, CHAPLIN       )
				CampaignAttackerEx(4,4,4, HYDROMANCER);//call CampaignAttackerEx( 4,4,4, HYDROMANCER   )
				CampaignAttackerEx(5,5,5, TANK);//call CampaignAttackerEx( 5,5,5, TANK          )
				SuicideOnPlayerEx(M4,M4,M4,user);//call SuicideOnPlayerEx(M4,M4,M4,user)
			}//endloop
		}//endfunction

	
	}
}

