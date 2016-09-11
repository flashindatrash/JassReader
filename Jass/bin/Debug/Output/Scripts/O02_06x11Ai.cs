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
			CampaignAI(CommonAi.HOUSE, null);//call CampaignAI(HOUSE,null)
			SetReplacements(2, 2, 3);//call SetReplacements(2,2,3)
			SetCaptainHome(CommonAi.BOTH_CAPTAINS, 1158, 8175);//call SetCaptainHome(BOTH_CAPTAINS,1158,8175)
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
			CampaignDefenderEx(2, 2, 2, O02_06x11Ai.ELITE_FOOTMAN);//call CampaignDefenderEx( 2,2,2, ELITE_FOOTMAN )
			CampaignDefenderEx(1, 1, 1, CommonAi.KNIGHT);//call CampaignDefenderEx( 1,1,1, KNIGHT        )
			CampaignDefenderEx(1, 1, 1, O02_06x11Ai.HYDROMANCER);//call CampaignDefenderEx( 1,1,1, HYDROMANCER   )
			CampaignDefenderEx(1, 1, 1, O02_06x11Ai.CHAPLIN);//call CampaignDefenderEx( 1,1,1, CHAPLIN       )
			CampaignDefenderEx(1, 1, 1, CommonAi.RIFLEMAN);//call CampaignDefenderEx( 1,1,1, RIFLEMAN      )
			WaitForSignal();//call WaitForSignal()
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(5, 5, 5, O02_06x11Ai.ELITE_FOOTMAN);//call CampaignAttackerEx( 5,5,5, ELITE_FOOTMAN )
			CampaignAttackerEx(5, 5, 5, CommonAi.RIFLEMAN);//call CampaignAttackerEx( 5,5,5, RIFLEMAN      )
			CampaignAttackerEx(3, 3, 3, O02_06x11Ai.CHAPLIN);//call CampaignAttackerEx( 3,3,3, CHAPLIN       )
			SuicideOnPlayerEx(CommonAi.M2, CommonAi.M2, CommonAi.M2, U08_tealAi.user);//call SuicideOnPlayerEx(M2,M2,M2,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(5, 5, 5, CommonAi.KNIGHT);//call CampaignAttackerEx( 5,5,5, KNIGHT        )
			CampaignAttackerEx(5, 5, 5, CommonAi.RIFLEMAN);//call CampaignAttackerEx( 5,5,5, RIFLEMAN      )
			CampaignAttackerEx(2, 2, 2, CommonAi.TANK);//call CampaignAttackerEx( 2,2,2, TANK          )
			CampaignAttackerEx(3, 3, 3, O02_06x11Ai.HYDROMANCER);//call CampaignAttackerEx( 3,3,3, HYDROMANCER   )
			SuicideOnPlayerEx(CommonAi.M3, CommonAi.M3, CommonAi.M3, U08_tealAi.user);//call SuicideOnPlayerEx(M3,M3,M3,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(7, 7, 7, CommonAi.GRYPHON);//call CampaignAttackerEx( 7,7,7, GRYPHON       )
			CampaignAttackerEx(4, 4, 4, CommonAi.TANK);//call CampaignAttackerEx( 4,4,4, TANK          )
			CampaignAttackerEx(4, 4, 4, CommonAi.KNIGHT);//call CampaignAttackerEx( 4,4,4, KNIGHT        )
			CampaignAttackerEx(4, 4, 4, O02_06x11Ai.HYDROMANCER);//call CampaignAttackerEx( 4,4,4, HYDROMANCER   )
			SuicideOnPlayerEx(CommonAi.M4, CommonAi.M4, CommonAi.M4, U08_tealAi.user);//call SuicideOnPlayerEx(M4,M4,M4,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(6, 6, 6, CommonAi.KNIGHT);//call CampaignAttackerEx( 6,6,6, KNIGHT        )
			CampaignAttackerEx(7, 7, 7, CommonAi.GRYPHON);//call CampaignAttackerEx( 7,7,7, GRYPHON       )
			CampaignAttackerEx(4, 4, 4, O02_06x11Ai.HYDROMANCER);//call CampaignAttackerEx( 4,4,4, HYDROMANCER   )
			CampaignAttackerEx(3, 3, 3, O02_06x11Ai.CHAPLIN);//call CampaignAttackerEx( 3,3,3, CHAPLIN       )
			SuicideOnPlayerEx(CommonAi.M3, CommonAi.M3, CommonAi.M3, U08_tealAi.user);//call SuicideOnPlayerEx(M3,M3,M3,user)
			while (true) {//loop
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(8, 8, 8, O02_06x11Ai.ELITE_FOOTMAN);//call CampaignAttackerEx( 8,8,8, ELITE_FOOTMAN )
				CampaignAttackerEx(6, 6, 6, CommonAi.RIFLEMAN);//call CampaignAttackerEx( 6,6,6, RIFLEMAN      )
				CampaignAttackerEx(4, 4, 4, O02_06x11Ai.CHAPLIN);//call CampaignAttackerEx( 4,4,4, CHAPLIN       )
				SuicideOnPlayerEx(CommonAi.M4, CommonAi.M4, CommonAi.M4, U08_tealAi.user);//call SuicideOnPlayerEx(M4,M4,M4,user)
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(6, 6, 6, CommonAi.GRYPHON);//call CampaignAttackerEx( 6,6,6, GRYPHON       )
				CampaignAttackerEx(4, 4, 4, O02_06x11Ai.CHAPLIN);//call CampaignAttackerEx( 4,4,4, CHAPLIN       )
				CampaignAttackerEx(5, 5, 5, CommonAi.TANK);//call CampaignAttackerEx( 5,5,5, TANK          )
				SuicideOnPlayerEx(CommonAi.M4, CommonAi.M4, CommonAi.M4, U08_tealAi.user);//call SuicideOnPlayerEx(M4,M4,M4,user)
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(6, 6, 6, CommonAi.KNIGHT);//call CampaignAttackerEx( 6,6,6, KNIGHT        )
				CampaignAttackerEx(4, 4, 4, O02_06x11Ai.CHAPLIN);//call CampaignAttackerEx( 4,4,4, CHAPLIN       )
				CampaignAttackerEx(5, 5, 5, CommonAi.RIFLEMAN);//call CampaignAttackerEx( 5,5,5, RIFLEMAN      )
				CampaignAttackerEx(4, 4, 4, O02_06x11Ai.HYDROMANCER);//call CampaignAttackerEx( 4,4,4, HYDROMANCER   )
				SuicideOnPlayerEx(CommonAi.M3, CommonAi.M3, CommonAi.M3, U08_tealAi.user);//call SuicideOnPlayerEx(M3,M3,M3,user)
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(9, 9, 9, O02_06x11Ai.ELITE_FOOTMAN);//call CampaignAttackerEx( 9,9,9, ELITE_FOOTMAN )
				CampaignAttackerEx(5, 5, 5, CommonAi.RIFLEMAN);//call CampaignAttackerEx( 5,5,5, RIFLEMAN      )
				CampaignAttackerEx(4, 4, 4, O02_06x11Ai.CHAPLIN);//call CampaignAttackerEx( 4,4,4, CHAPLIN       )
				CampaignAttackerEx(4, 4, 4, O02_06x11Ai.HYDROMANCER);//call CampaignAttackerEx( 4,4,4, HYDROMANCER   )
				SuicideOnPlayerEx(CommonAi.M4, CommonAi.M4, CommonAi.M4, U08_tealAi.user);//call SuicideOnPlayerEx(M4,M4,M4,user)
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(9, 9, 9, CommonAi.GRYPHON);//call CampaignAttackerEx( 9,9,9, GRYPHON       )
				CampaignAttackerEx(6, 6, 6, CommonAi.KNIGHT);//call CampaignAttackerEx( 6,6,6, KNIGHT        )
				CampaignAttackerEx(4, 4, 4, O02_06x11Ai.CHAPLIN);//call CampaignAttackerEx( 4,4,4, CHAPLIN       )
				CampaignAttackerEx(4, 4, 4, O02_06x11Ai.HYDROMANCER);//call CampaignAttackerEx( 4,4,4, HYDROMANCER   )
				CampaignAttackerEx(5, 5, 5, CommonAi.TANK);//call CampaignAttackerEx( 5,5,5, TANK          )
				SuicideOnPlayerEx(CommonAi.M4, CommonAi.M4, CommonAi.M4, U08_tealAi.user);//call SuicideOnPlayerEx(M4,M4,M4,user)
			}//endloop
		}//endfunction

	
	}
}

