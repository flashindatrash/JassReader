using System;
using System.Collections.Generic;

namespace Jass {

	public class U01x04Ai {

		//
		//
		//
		public static player user = PlayerEx(4);//player user = PlayerEx(4)
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(HOUSE,null);//call CampaignAI(HOUSE,null)
			SetReplacements(2,2,3);//call SetReplacements(2,2,3)
			do_campaign_farms = false;//set do_campaign_farms = false
			//
			//
			SleepForever();//call SleepForever()
		}//endfunction

	
	}
}

