using System;
using System.Collections.Generic;

namespace Jass {

	public class O03Bx08Ai {

		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(HOUSE,null);//call CampaignAI(HOUSE,null)
			PrepFullSuicide();//call PrepFullSuicide()
			while (true) {//loop
				while (true) {//loop
					if (CommandsWaiting() == 0) { break; }//exitwhen CommandsWaiting() == 0
					user = GetLastCommand();//set user = GetLastCommand()
					PopLastCommand();//call PopLastCommand()
				}//endloop
				SuicideUnitB(FOOTMAN,user);//call SuicideUnitB(FOOTMAN,user)
				SuicideUnitB('h004',user);//call SuicideUnitB('h004',user)
				SuicideUnitB(RIFLEMAN,user);//call SuicideUnitB(RIFLEMAN,user)
				SuicideUnitB('h005',user);//call SuicideUnitB('h005',user)
				SuicideUnitB(KNIGHT,user);//call SuicideUnitB(KNIGHT,user)
				SuicideUnitB('h006',user);//call SuicideUnitB('h006',user)
				SuicideUnitB('h007',user);//call SuicideUnitB('h007',user)
				SuicideUnitB('nchp',user);//call SuicideUnitB('nchp',user)
				SuicideUnitB('nhym',user);//call SuicideUnitB('nhym',user)
			}//endloop
		}//endfunction

	
	}
}

