using System;
using System.Collections.Generic;

namespace Jass {

	public class N06x11Ai {

		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(BURROW,null);//call CampaignAI(BURROW,null)
			while (true) {//loop
				SuicideUnitEx(2, GHOUL, 0);//call SuicideUnitEx( 2, GHOUL, 0 )
				SuicideUnitEx(1, NECRO, 0);//call SuicideUnitEx( 1, NECRO, 0 )
				SuicideUnitEx(1, ABOMINATION, 0);//call SuicideUnitEx( 1, ABOMINATION, 0 )
				SuicideUnitEx(1, CRYPT_FIEND, 0);//call SuicideUnitEx( 1, CRYPT_FIEND, 0 )
				SuicideUnitEx(1, BANSHEE,     0);//call SuicideUnitEx( 1, BANSHEE,     0 )
				Sleep(1);//call Sleep(1)
			}//endloop
		}//endfunction

	
	}
}

