using System;
using System.Collections.Generic;

namespace Jass {

	public class U04b_grayAi {

		//
		//
		//
		public static player user = Player(3);//player user = Player(3)
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(ELF_FARM,null);//call CampaignAI(ELF_FARM,null)
			SetReplacements(0,1,3);//call SetReplacements(0,1,3)
			SetBuildUnitEx(1,2,3, ZEPPLIN);//call SetBuildUnitEx( 1,2,3, ZEPPLIN         )
			CampaignDefenderEx(1,1,1, SYLVANUS);//call CampaignDefenderEx( 1,1,1, SYLVANUS    )
			SleepForever();//call SleepForever()
		}//endfunction

	
	}
}

