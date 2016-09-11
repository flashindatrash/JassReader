using System;
using System.Collections.Generic;

namespace Jass {

	public class H06x05Ai {

		//
		//
		//
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(BURROW,null);//call CampaignAI(BURROW,null)
			SetReplacements(1,1,3);//call SetReplacements(1,1,3)
			SetCaptainHome(DEFENSE_CAPTAIN,3885,906);//call SetCaptainHome(DEFENSE_CAPTAIN,3885,906)
			CampaignDefenderEx(0,0,1, CHAOS_GRUNT);//call CampaignDefenderEx( 0,0,1, CHAOS_GRUNT     )
			CampaignDefenderEx(0,0,1, CHAOS_WARLOCK);//call CampaignDefenderEx( 0,0,1, CHAOS_WARLOCK   )
			CampaignDefenderEx(0,0,1, SAGRANEL);//call CampaignDefenderEx( 0,0,1, SAGRANEL        )
			SleepForever();//call SleepForever()
		}//endfunction

	
	}
}

