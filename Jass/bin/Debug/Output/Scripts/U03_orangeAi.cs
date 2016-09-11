using System;
using System.Collections.Generic;

namespace Jass {

	public class U03_orangeAi {

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
			CampaignDefenderEx(1,3,5, HIGH_FOOTMEN);//call CampaignDefenderEx( 1,3,5, HIGH_FOOTMEN )
			SleepForever();//call SleepForever()
		}//endfunction

	
	}
}

