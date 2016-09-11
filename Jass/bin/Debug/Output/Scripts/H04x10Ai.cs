using System;
using System.Collections.Generic;

namespace Jass {

	public class H04x10Ai {

		//
		//
		//
		public const int USER = 1;//constant integer USER = 1
		private void main() {//function main takes nothing returns nothing
			CampaignAI(CommonAi.HOUSE, null);//call CampaignAI(HOUSE,null)
			SuicideUnitsEx(U08x02Ai.USER, CommonAi.NAGA_MYRMIDON, CommonAi.NAGA_SIREN, CommonAi.NAGA_DRAGON, CommonAi.HIGH_SWORDMAN, CommonAi.HIGH_ARCHER, CommonAi.SORCERESS, CommonAi.PRIEST, CommonAi.SPELL_BREAKER, 'ncfs', CommonAi.NAGA_ROYAL);//call SuicideUnitsEx( USER, NAGA_MYRMIDON, NAGA_SIREN, NAGA_DRAGON, HIGH_SWORDMAN, HIGH_ARCHER, SORCERESS, PRIEST, SPELL_BREAKER, 'ncfs', NAGA_ROYAL)
		}//endfunction

	
	}
}

