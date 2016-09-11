using System;
using System.Collections.Generic;

namespace Jass {

	public class N06x07Ai {

		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(CommonAi.ZIGGURAT_1, null);//call CampaignAI(ZIGGURAT_1,null)
			SetBuildUnit(1, CommonAi.ACOLYTE);//call SetBuildUnit( 1, ACOLYTE )
			CampaignDefenderEx(1, 2, 3, CommonAi.GHOUL);//call CampaignDefenderEx( 1, 2, 3, GHOUL     )
			SleepForever();//call SleepForever()
		}//endfunction

	
	}
}

