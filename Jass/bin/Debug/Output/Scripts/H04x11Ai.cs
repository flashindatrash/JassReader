using System;
using System.Collections.Generic;

namespace Jass {

	public class H04x11Ai {

		//
		//
		//
		public const int USER = 7;//constant integer USER = 7
		private void main() {//function main takes nothing returns nothing
			CampaignAI(CommonAi.MOON_WELL, null);//call CampaignAI(MOON_WELL,null)
			SuicideUnitsEx(U08x02Ai.USER, CommonAi.HUNTRESS, CommonAi.ARCHER, CommonAi.DRUID_CLAW, CommonAi.DRUID_CLAW_M, CommonAi.DRUID_TALON, CommonAi.DRYAD, CommonAi.MOUNTAIN_GIANT, 'espv', 'even', 0);//call SuicideUnitsEx( USER, HUNTRESS, ARCHER, DRUID_CLAW, DRUID_CLAW_M, DRUID_TALON, DRYAD, MOUNTAIN_GIANT, 'espv', 'even', 0)
		}//endfunction

	
	}
}

