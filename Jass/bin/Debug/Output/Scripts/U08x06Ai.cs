using System;
using System.Collections.Generic;

namespace Jass {

	public class U08x06Ai {

		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(CommonAi.NAGA_CORAL, null);//call CampaignAI(NAGA_CORAL,null)
			SetAmphibious();//call SetAmphibious()
			SetBuildUnitEx(1, 1, 1, CommonAi.NAGA_TEMPLE);//call SetBuildUnitEx( 1,1,1, NAGA_TEMPLE     )
			SetBuildUnitEx(1, 1, 1, CommonAi.NAGA_SLAVE);//call SetBuildUnitEx( 1,1,1, NAGA_SLAVE      )
			SetBuildUnitEx(1, 1, 1, CommonAi.NAGA_SPAWNING);//call SetBuildUnitEx( 1,1,1, NAGA_SPAWNING   )
			SetBuildUnitEx(3, 3, 3, CommonAi.NAGA_SLAVE);//call SetBuildUnitEx( 3,3,3, NAGA_SLAVE      )
			//
			//
			//
			SleepForever();//call SleepForever()
		}//endfunction

	
	}
}

