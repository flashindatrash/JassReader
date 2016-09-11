using System;
using System.Collections.Generic;

namespace Jass {

	public class U04_brownAi {

		//
		//
		//
		public static player user = Player(3);//player user = Player(3)
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(CommonAi.ELF_FARM, null);//call CampaignAI(ELF_FARM,null)
			SetReplacements(1, 1, 3);//call SetReplacements(1,1,3)
			do_campaign_farms = false;//set do_campaign_farms = false
			CampaignDefenderEx(0, 0, 1, CommonAi.HIGH_SWORDMAN);//call CampaignDefenderEx( 0,0,1, HIGH_SWORDMAN	)
			CampaignDefenderEx(1, 1, 2, CommonAi.HIGH_ARCHER);//call CampaignDefenderEx( 1,1,2, HIGH_ARCHER		)
			CampaignDefenderEx(0, 0, 1, CommonAi.PRIEST);//call CampaignDefenderEx( 0,0,1, PRIEST			)
			SleepForever();//call SleepForever()
		}//endfunction

	
	}
}

