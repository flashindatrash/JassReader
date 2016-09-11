using System;
using System.Collections.Generic;

namespace Jass {

	public class O08_VsPlayerAi {

		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(CommonAi.BURROW, null);//call CampaignAI(BURROW,null)
			while (true) {//loop
				SuicideUnitEx(1, CommonAi.INFERNAL, 0);//call SuicideUnitEx( 1, INFERNAL, 0 )
				Sleep(1);//call Sleep(1)
			}//endloop
		}//endfunction

	
	}
}

