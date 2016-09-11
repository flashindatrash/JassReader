using System;
using System.Collections.Generic;

namespace Jass {

	public class H02x07Ai {

		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(ZIGGURAT_1,null);//call CampaignAI(ZIGGURAT_1,null)
			SetHarvestLumber(false);//call SetHarvestLumber(false)
			DoCampaignFarms(false);//call DoCampaignFarms(false)
			SetBuildUnitEx(1,1,1, UNDEAD_MINE);//call SetBuildUnitEx( 1,1,1, UNDEAD_MINE     )
			while (true) {//loop
				if (TownCountDone(NECROPOLIS_1) > 0) { break; }//exitwhen TownCountDone(NECROPOLIS_1) > 0
				Sleep(1);//call Sleep(1)
			}//endloop
			InitBuildArray();//call InitBuildArray()
			ResetCaptainLocs();//call ResetCaptainLocs()
			SetHarvestLumber(true);//call SetHarvestLumber(true)
			SetWoodPeons(2);//call SetWoodPeons(2)
			CampaignDefenderEx(1,1,2, GHOUL);//call CampaignDefenderEx( 1,1,2, GHOUL       )
			CampaignDefenderEx(1,1,2, CRYPT_FIEND);//call CampaignDefenderEx( 1,1,2, CRYPT_FIEND )
			SleepForever();//call SleepForever()
		}//endfunction

	
	}
}

