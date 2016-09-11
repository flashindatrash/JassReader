using System;
using System.Collections.Generic;

namespace Jass {

	public class N08x11Ai {

		//
		//
		//
		public static player user = PlayerEx(2);//player user = PlayerEx(2)
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(CommonAi.ZIGGURAT_1, null);//call CampaignAI(ZIGGURAT_1,null)
			SetReplacements(1, 1, 3);//call SetReplacements(1,1,3)
			DoCampaignFarms(false);//call DoCampaignFarms(false)
			CampaignDefenderEx(1, 1, 2, CommonAi.NECRO);//call CampaignDefenderEx( 1, 1, 2, NECRO		)
			CampaignDefenderEx(1, 1, 2, CommonAi.BANSHEE);//call CampaignDefenderEx( 1, 1, 2, BANSHEE	)
			SleepForever();//call SleepForever()
		}//endfunction

	
	}
}

