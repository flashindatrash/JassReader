using System;
using System.Collections.Generic;

namespace Jass {

	public class N07x07Ai {

		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(ZIGGURAT_1,null);//call CampaignAI(ZIGGURAT_1,null)
			SetReplacements(1,1,3);//call SetReplacements(1,1,3)
			CampaignDefenderEx(0,0,1, NECRO);//call CampaignDefenderEx( 0,0,1, NECRO       )
			CampaignDefenderEx(0,0,1, BANSHEE);//call CampaignDefenderEx( 0,0,1, BANSHEE     )
			SleepForever();//call SleepForever()
		}//endfunction

	
	}
}

