using System;
using System.Collections.Generic;

namespace Jass {

	public class H06x05Ai {

		//
		//
		//
		public static player user = PlayerEx(1);//player user = PlayerEx(1)
		public const int SAGRANEL = 'N00A';//constant integer SAGRANEL       = 'N00A'
		public const int ORC_JUGG = 'ojgn';//constant integer ORC_JUGG       = 'ojgn'
		public const int ORC_FRIGATE = 'odes';//constant integer ORC_FRIGATE    = 'odes'
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

