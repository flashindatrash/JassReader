using System;
using System.Collections.Generic;

namespace Jass {

	public class O03Bx05Ai {

		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(BURROW,null);//call CampaignAI(BURROW,null)
			PrepFullSuicide();//call PrepFullSuicide()
			while (true) {//loop
				while (true) {//loop
					if (CommandsWaiting() == 0) { break; }//exitwhen CommandsWaiting() == 0
					user = GetLastCommand();//set user = GetLastCommand()
					PopLastCommand();//call PopLastCommand()
				}//endloop
				SuicideUnitB('nogo',user);//call SuicideUnitB('nogo',user)
				SuicideUnitB('nogn',user);//call SuicideUnitB('nogn',user)
				SuicideUnitB(BERSERKER,user);//call SuicideUnitB(BERSERKER,user)
				SuicideUnitB(WITCH_DOCTOR,user);//call SuicideUnitB(WITCH_DOCTOR,user)
			}//endloop
		}//endfunction

	
	}
}

