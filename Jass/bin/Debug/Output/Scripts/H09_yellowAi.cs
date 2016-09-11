using System;
using System.Collections.Generic;

namespace Jass {

	public class H09_yellowAi {

		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(CommonAi.ZIGGURAT_1, null);//call CampaignAI(ZIGGURAT_1,null)
			SuicideUnits(CommonAi.GHOUL, CommonAi.NECRO, CommonAi.ABOMINATION, CommonAi.GARGOYLE, CommonAi.CRYPT_FIEND, CommonAi.GHOUL, CommonAi.ABOMINATION, CommonAi.NECRO, CommonAi.GARGOYLE, CommonAi.CRYPT_FIEND);//call SuicideUnits( GHOUL, NECRO, ABOMINATION, GARGOYLE, CRYPT_FIEND, GHOUL, ABOMINATION, NECRO, GARGOYLE, CRYPT_FIEND )
		}//endfunction

	
	}
}

