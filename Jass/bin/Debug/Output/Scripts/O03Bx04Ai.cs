using System;
using System.Collections.Generic;

namespace Jass {

	public class O03Bx04Ai {

		//
		//
		//
		public static int user = 7;//integer user = 7
		private void main() {//function main takes nothing returns nothing
			CampaignAI(BURROW,null);//call CampaignAI(BURROW,null)
			PrepFullSuicide();//call PrepFullSuicide()
			while (true) {//loop
				while (true) {//loop
					if (CommandsWaiting() == 0) { break; }//exitwhen CommandsWaiting() == 0
					user = GetLastCommand();//set user = GetLastCommand()
					PopLastCommand();//call PopLastCommand()
				}//endloop
				SuicideUnitB(GRUNT,user);//call SuicideUnitB(GRUNT,user)
				SuicideUnitB(SHAMAN,user);//call SuicideUnitB(SHAMAN,user)
				SuicideUnitB(RAIDER,user);//call SuicideUnitB(RAIDER,user)
				SuicideUnitB(KODO_BEAST,user);//call SuicideUnitB(KODO_BEAST,user)
				SuicideUnitB(CATAPULT,user);//call SuicideUnitB(CATAPULT,user)
			}//endloop
		}//endfunction

	
	}
}

