using System;
using System.Collections.Generic;

namespace Jass {

	public class O03Bx06Ai {

		//
		//
		//
		public static int user = 9;//integer user = 9
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
				SuicideUnitB(CommonAi.TAUREN, U08_tealAi.user);//call SuicideUnitB(TAUREN,user)
				SuicideUnitB(CommonAi.SPIRIT_WALKER, U08_tealAi.user);//call SuicideUnitB(SPIRIT_WALKER,user)
			}//endloop
		}//endfunction

	
	}
}

