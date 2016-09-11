using System;
using System.Collections.Generic;

namespace Jass {

	public class U04x02Ai {

		//
		//
		//
		public static player user = PlayerEx(4);//player user = PlayerEx(4)
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(CommonAi.HOUSE, null);//call CampaignAI(HOUSE,null)
			SetReplacements(1, 1, 3);//call SetReplacements(1,1,3)
			CampaignDefenderEx(1, 1, 2, CommonAi.HIGH_SWORDMAN);//call CampaignDefenderEx( 1,1,2, HIGH_SWORDMAN   )
			SleepForever();//call SleepForever()
		}//endfunction

	
	}
}

