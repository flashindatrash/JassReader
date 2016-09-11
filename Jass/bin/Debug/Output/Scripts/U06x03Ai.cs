using System;
using System.Collections.Generic;

namespace Jass {

	public class U06x03Ai {

		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(ZIGGURAT_1,null);//call CampaignAI(ZIGGURAT_1,null)
			SetReplacements(1,1,3);//call SetReplacements(1,1,3)
			campaign_wood_peons = 2;//set campaign_wood_peons = 2
			SetBuildUnit(1, ACOLYTE);//call SetBuildUnit( 1, ACOLYTE )
			CampaignDefenderEx(1, 1, 3, GHOUL);//call CampaignDefenderEx( 1, 1, 3, GHOUL     )
			SleepForever();//call SleepForever()
		}//endfunction

	
	}
}

