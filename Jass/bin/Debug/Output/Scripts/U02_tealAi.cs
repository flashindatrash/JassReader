using System;
using System.Collections.Generic;

namespace Jass {

	public class U02_tealAi {

		//
		//
		//
		public static player user = Player(3);//player user = Player(3)
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(CommonAi.HOUSE, null);//call CampaignAI(HOUSE,null)
			SetReplacements(0, 0, 3);//call SetReplacements(0,0,3)
			CampaignDefenderEx(1, 1, 2, CommonAi.FOOTMAN);//call CampaignDefenderEx(1,1,2, FOOTMAN     )
			SleepForever();//call SleepForever()
		}//endfunction

	
	}
}

