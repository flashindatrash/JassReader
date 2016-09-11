using System;
using System.Collections.Generic;

namespace Jass {

	public class O08_VsJainaAi {

		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(CommonAi.BURROW, null);//call CampaignAI(BURROW,null)
			while (true) {//loop
				SuicideUnitEx(1, CommonAi.INFERNAL, 9);//call SuicideUnitEx( 1, INFERNAL, 9 )
				Sleep(1);//call Sleep(1)
			}//endloop
		}//endfunction

	
	}
}

