using System;
using System.Collections.Generic;

namespace Jass {

	public class O03Bx09Ai {

		//
		//
		//
		public static int user = 4;//integer user = 4
		private void main() {//function main takes nothing returns nothing
			CampaignAI(CommonAi.HOUSE, null);//call CampaignAI(HOUSE,null)
			PrepFullSuicide();//call PrepFullSuicide()
			while (true) {//loop
				while (true) {//loop
					if (CommandsWaiting() == 0) { break; }//exitwhen CommandsWaiting() == 0
					user = GetLastCommand();//set user = GetLastCommand()
					PopLastCommand();//call PopLastCommand()
				}//endloop
				SuicideUnitB(CommonAi.FOOTMAN, U08_tealAi.user);//call SuicideUnitB(FOOTMAN,user)
				SuicideUnitB('h004', U08_tealAi.user);//call SuicideUnitB('h004',user)
				SuicideUnitB(CommonAi.RIFLEMAN, U08_tealAi.user);//call SuicideUnitB(RIFLEMAN,user)
				SuicideUnitB('h005', U08_tealAi.user);//call SuicideUnitB('h005',user)
				SuicideUnitB(CommonAi.KNIGHT, U08_tealAi.user);//call SuicideUnitB(KNIGHT,user)
				SuicideUnitB('h006', U08_tealAi.user);//call SuicideUnitB('h006',user)
				SuicideUnitB('h007', U08_tealAi.user);//call SuicideUnitB('h007',user)
				SuicideUnitB('nchp', U08_tealAi.user);//call SuicideUnitB('nchp',user)
				SuicideUnitB('nhym', U08_tealAi.user);//call SuicideUnitB('nhym',user)
			}//endloop
		}//endfunction

	
	}
}

