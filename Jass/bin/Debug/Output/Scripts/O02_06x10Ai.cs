using System;
using System.Collections.Generic;

namespace Jass {

	public class O02_06x10Ai {

		//
		//
		//
		public static player user = PlayerEx(03);//player user = PlayerEx(03)
		public const int ELITE_FOOTMAN = 'hcth';//constant integer ELITE_FOOTMAN  = 'hcth'
		public const int CHAPLIN = 'nchp';//constant integer CHAPLIN        = 'nchp'
		public const int HYDROMANCER = 'nhym';//constant integer HYDROMANCER    = 'nhym'
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(CommonAi.HOUSE, null);//call CampaignAI(HOUSE,null)
			SetReplacements(2, 2, 3);//call SetReplacements(2,2,3)
			SetCaptainHome(CommonAi.BOTH_CAPTAINS, -2075, 5240);//call SetCaptainHome(BOTH_CAPTAINS,-2075,5240)
			//
			//
			//
			//
			//
			//
			//
			//
			//
			//
			//
			//
			//
			//
			//
			//
			//
			//
			//
			//
			WaitForSignal();//call WaitForSignal()
		}//endfunction

	
	}
}

