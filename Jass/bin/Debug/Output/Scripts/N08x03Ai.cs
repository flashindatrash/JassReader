using System;
using System.Collections.Generic;

namespace Jass {

	public class N08x03Ai {

		//
		//
		//
		public const int SWISP = 'e001';//constant integer SWISP          = 'e001'
		public const int SHUNTRESS = 'e000';//constant integer SHUNTRESS      = 'e000'
		public const int SARCHER = 'e005';//constant integer SARCHER        = 'e005'
		public const int SANCIENTWAR = 'e009';//constant integer SANCIENTWAR    = 'e009'
		public const int SPROTECTOR = 'e008';//constant integer SPROTECTOR     = 'e008'
		public const int SMOONWELL = 'e007';//constant integer SMOONWELL      = 'e007'
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(CommonAi.MOON_WELL, null);//call CampaignAI(MOON_WELL,null)
			SetReplacements(9, 9, 9);//call SetReplacements(9,9,9)
			DoCampaignFarms(false);//call DoCampaignFarms(false)
			SetPeonsRepair(true);//call SetPeonsRepair(true)
			SetBuildUnitEx(2, 2, 2, N08x03Ai.SWISP);//call SetBuildUnitEx( 2,2,2, SWISP           )
			SetBuildUnitEx(2, 2, 2, N08x03Ai.SPROTECTOR);//call SetBuildUnitEx( 2,2,2, SPROTECTOR      )
			SetBuildUnitEx(1, 1, 1, N08x03Ai.SANCIENTWAR);//call SetBuildUnitEx( 1,1,1, SANCIENTWAR     )
			SetBuildUnitEx(2, 2, 2, N08x03Ai.SMOONWELL);//call SetBuildUnitEx( 2,2,2, SMOONWELL       )
			CampaignDefenderEx(1, 1, 1, N08x03Ai.SARCHER);//call CampaignDefenderEx( 1, 1, 1, SARCHER	)
			CampaignDefenderEx(1, 1, 1, N08x03Ai.SHUNTRESS);//call CampaignDefenderEx( 1, 1, 1, SHUNTRESS	)
			SleepForever();//call SleepForever()
		}//endfunction

	
	}
}

