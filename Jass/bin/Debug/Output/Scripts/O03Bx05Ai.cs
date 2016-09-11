using System;
using System.Collections.Generic;

namespace Jass {

	public class O03Bx05Ai {

		//
		//
		//
		public static int user = 8;//integer user = 8
		private void main() {//function main takes nothing returns nothing
			CampaignAI(CommonAi.BURROW, null);//call CampaignAI(BURROW,null)
			PrepFullSuicide();//call PrepFullSuicide()
			while (true) {//loop
				while (true) {//loop
					if (CommandsWaiting() == 0) { break; }//exitwhen CommandsWaiting() == 0
					user = GetLastCommand();//set user = GetLastCommand()
					PopLastCommand();//call PopLastCommand()
				}//endloop
				SuicideUnitB('nogo', U08_tealAi.user);//call SuicideUnitB('nogo',user)
				SuicideUnitB('nogn', U08_tealAi.user);//call SuicideUnitB('nogn',user)
				SuicideUnitB(CommonAi.BERSERKER, U08_tealAi.user);//call SuicideUnitB(BERSERKER,user)
				SuicideUnitB(CommonAi.WITCH_DOCTOR, U08_tealAi.user);//call SuicideUnitB(WITCH_DOCTOR,user)
			}//endloop
		}//endfunction

	
	}
}

