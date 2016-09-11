using System;
using System.Collections.Generic;

namespace Jass {

	public class N02_yellowAi {

		//
		//
		//
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(CommonAi.MOON_WELL, null);//call CampaignAI(MOON_WELL,null)
			SetCaptainHome(CommonAi.DEFENSE_CAPTAIN, 2534, -2171);//call SetCaptainHome(DEFENSE_CAPTAIN,2534,-2171)
			CampaignDefender(CommonAi.EASY, 3, CommonAi.ARCHER);//call CampaignDefender( EASY,	3, ARCHER   )
			SleepForever();//call SleepForever()
		}//endfunction

	
	}
}

