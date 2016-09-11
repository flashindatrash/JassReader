using System;
using System.Collections.Generic;

namespace Jass {

	public class U06x05Ai {

		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(CommonAi.ZIGGURAT_1, null);//call CampaignAI(ZIGGURAT_1,null)
			SetReplacements(1, 1, 3);//call SetReplacements(1,1,3)
			campaign_wood_peons = 2;//set campaign_wood_peons = 2
			SetBuildUnit(1, CommonAi.ACOLYTE);//call SetBuildUnit( 1, ACOLYTE )
			CampaignDefenderEx(2, 2, 3, CommonAi.GHOUL);//call CampaignDefenderEx( 2, 2, 3, GHOUL         )
			CampaignDefenderEx(1, 1, 3, CommonAi.CRYPT_FIEND);//call CampaignDefenderEx( 1, 1, 3, CRYPT_FIEND   )
			SleepForever();//call SleepForever()
		}//endfunction

	
	}
}

