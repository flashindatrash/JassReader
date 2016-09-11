using System;
using System.Collections.Generic;

namespace Jass {

	public class O03Bx04Ai {

		//
		//
		//
		public static int user = 7;//integer user = 7
		private void main() {//function main takes nothing returns nothing
			CampaignAI(CommonAi.BURROW, null);//call CampaignAI(BURROW,null)
			PrepFullSuicide();//call PrepFullSuicide()
			while (true) {//loop
				while (true) {//loop
					if (CommandsWaiting() == 0) { break; }//exitwhen CommandsWaiting() == 0
					user = GetLastCommand();//set user = GetLastCommand()
					PopLastCommand();//call PopLastCommand()
				}//endloop
				SuicideUnitB(CommonAi.GRUNT, U08_tealAi.user);//call SuicideUnitB(GRUNT,user)
				SuicideUnitB(CommonAi.SHAMAN, U08_tealAi.user);//call SuicideUnitB(SHAMAN,user)
				SuicideUnitB(CommonAi.RAIDER, U08_tealAi.user);//call SuicideUnitB(RAIDER,user)
				SuicideUnitB(CommonAi.KODO_BEAST, U08_tealAi.user);//call SuicideUnitB(KODO_BEAST,user)
				SuicideUnitB(CommonAi.CATAPULT, U08_tealAi.user);//call SuicideUnitB(CATAPULT,user)
			}//endloop
		}//endfunction

	
	}
}

