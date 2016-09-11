using System;
using System.Collections.Generic;

namespace Jass {

	public class H09_tealAi {

		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(CommonAi.ZIGGURAT_1, null);//call CampaignAI(ZIGGURAT_1,null)
			SetReplacements(1, 1, 3);//call SetReplacements(1,1,3)
			SetBuildUnitEx(0, 0, 1, CommonAi.NECROPOLIS_1);//call SetBuildUnitEx( 0,0,1, NECROPOLIS_1      )
			SetBuildUnitEx(1, 1, 1, CommonAi.ACOLYTE);//call SetBuildUnitEx( 1,1,1, ACOLYTE           )
			SetBuildUnitEx(0, 0, 1, CommonAi.UNDEAD_MINE);//call SetBuildUnitEx( 0,0,1, UNDEAD_MINE       )
			SetBuildUnitEx(0, 0, 1, CommonAi.CRYPT);//call SetBuildUnitEx( 0,0,1, CRYPT				)
			SetBuildUnitEx(0, 0, 1, CommonAi.GRAVEYARD);//call SetBuildUnitEx( 0,0,1, GRAVEYARD         )
			SetBuildUnitEx(0, 0, 1, CommonAi.UNDEAD_ALTAR);//call SetBuildUnitEx( 0,0,1, UNDEAD_ALTAR      )
			SetBuildUnitEx(0, 0, 1, CommonAi.NECROPOLIS_2);//call SetBuildUnitEx( 0,0,1, NECROPOLIS_2      )
			SetBuildUnitEx(0, 0, 1, CommonAi.SLAUGHTERHOUSE);//call SetBuildUnitEx( 0,0,1, SLAUGHTERHOUSE    )
			SetBuildUnitEx(0, 0, 1, CommonAi.SAC_PIT);//call SetBuildUnitEx( 0,0,1, SAC_PIT           )
			SetBuildUnitEx(0, 0, 1, CommonAi.NECROPOLIS_3);//call SetBuildUnitEx( 0,0,1, NECROPOLIS_3      )
			SetBuildUnitEx(0, 0, 5, CommonAi.ACOLYTE);//call SetBuildUnitEx( 0,0,5, ACOLYTE			)
			CampaignDefenderEx(1, 1, 3, CommonAi.GHOUL);//call CampaignDefenderEx( 1,1,3, GHOUL       )
			CampaignDefenderEx(1, 1, 2, CommonAi.ABOMINATION);//call CampaignDefenderEx( 1,1,2, ABOMINATION )
			CampaignDefenderEx(0, 0, 2, CommonAi.CRYPT_FIEND);//call CampaignDefenderEx( 0,0,2, CRYPT_FIEND )
			SleepForever();//call SleepForever()
		}//endfunction

	
	}
}

