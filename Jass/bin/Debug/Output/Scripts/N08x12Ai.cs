using System;
using System.Collections.Generic;

namespace Jass {

	public class N08x12Ai {

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
			SetBuildUpgrEx(1, 1, 1, CommonAi.BLK_SPHINX);//call SetBuildUpgrEx( 1,1,1, BLK_SPHINX          )
			CampaignDefenderEx(3, 3, 4, CommonAi.ABOMINATION);//call CampaignDefenderEx( 3, 3, 4, ABOMINATION	)
			CampaignDefenderEx(2, 2, 3, CommonAi.BLK_SPHINX);//call CampaignDefenderEx( 2, 2, 3, BLK_SPHINX	)
			CampaignDefenderEx(1, 1, 1, CommonAi.OBS_STATUE);//call CampaignDefenderEx( 1, 1, 1, OBS_STATUE	)
			SleepForever();//call SleepForever()
		}//endfunction

	
	}
}

