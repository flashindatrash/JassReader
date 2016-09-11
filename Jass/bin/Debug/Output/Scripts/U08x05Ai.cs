using System;
using System.Collections.Generic;

namespace Jass {

	public class U08x05Ai {

		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(CommonAi.NAGA_CORAL, null);//call CampaignAI(NAGA_CORAL,null)
			SetAmphibious();//call SetAmphibious()
			DoCampaignFarms(false);//call DoCampaignFarms(false)
			SetPeonsRepair(true);//call SetPeonsRepair(true)
			SetReplacements(9, 9, 9);//call SetReplacements(9,9,9)
			SetCaptainHome(CommonAi.BOTH_CAPTAINS, 3300, 5700);//call SetCaptainHome(BOTH_CAPTAINS,3300,5700)
			campaign_wood_peons = 3;//set campaign_wood_peons = 3
			SetBuildUnitEx(1, 1, 1, CommonAi.NAGA_TEMPLE);//call SetBuildUnitEx( 1,1,1, NAGA_TEMPLE     )
			SetBuildUnitEx(1, 1, 1, CommonAi.NAGA_SLAVE);//call SetBuildUnitEx( 1,1,1, NAGA_SLAVE      )
			SetBuildUnitEx(1, 1, 1, CommonAi.NAGA_SPAWNING);//call SetBuildUnitEx( 1,1,1, NAGA_SPAWNING   )
			SetBuildUnitEx(1, 1, 1, CommonAi.NAGA_SHRINE);//call SetBuildUnitEx( 1,1,1, NAGA_SHRINE     )
			SetBuildUnitEx(3, 3, 3, CommonAi.NAGA_SLAVE);//call SetBuildUnitEx( 3,3,3, NAGA_SLAVE      )
			SetBuildUnitEx(3, 3, 3, CommonAi.NAGA_GUARDIAN);//call SetBuildUnitEx( 3,3,3, NAGA_GUARDIAN   )
			//
			//
			CampaignDefenderEx(2, 2, 2, CommonAi.NAGA_ROYAL);//call CampaignDefenderEx( 2,2,2, NAGA_ROYAL          )
			CampaignDefenderEx(8, 8, 8, CommonAi.NAGA_SNAP_DRAGON);//call CampaignDefenderEx( 8,8,8, NAGA_SNAP_DRAGON    )
			CampaignDefenderEx(3, 3, 3, CommonAi.NAGA_SIREN);//call CampaignDefenderEx( 3,3,3, NAGA_SIREN          )
			CampaignDefenderEx(8, 8, 8, CommonAi.NAGA_COUATL);//call CampaignDefenderEx( 8,8,8, NAGA_COUATL         )
			SleepForever();//call SleepForever()
		}//endfunction

	
	}
}

