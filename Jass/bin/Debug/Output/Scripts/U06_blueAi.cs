using System;
using System.Collections.Generic;

namespace Jass {

	public class U06_blueAi {

		//
		//
		//
		public static player user = Player(3);//player user = Player(3)
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(PIG_FARM,null);//call CampaignAI(PIG_FARM,null)
			SetReplacements(1,1,3);//call SetReplacements(1,1,3)
			SetBuildUnitEx(0,0,1, GREAT_HALL);//call SetBuildUnitEx	( 0,0,1, GREAT_HALL			)
			SetBuildUnit(1, PEON);//call SetBuildUnit	( 1, PEON					)
			SetBuildUnitEx(0,0,1, ORC_BARRACKS);//call SetBuildUnitEx	( 0,0,1, ORC_BARRACKS		)
			SetBuildUnit(8, PEON);//call SetBuildUnit	( 8, PEON				    )
			CampaignDefenderEx(1,1,3, HEAD_HUNTER);//call CampaignDefenderEx( 1,1,3, HEAD_HUNTER		)
			CampaignDefenderEx(0,0,2, GRUNT);//call CampaignDefenderEx( 0,0,2, GRUNT			)
			SetBuildUpgrEx(0,0,1, UPG_ORC_ARMOR);//call SetBuildUpgrEx( 0,0,1, UPG_ORC_ARMOR		)
			SetBuildUpgrEx(0,0,1, UPG_ORC_RANGED);//call SetBuildUpgrEx( 0,0,1, UPG_ORC_RANGED		)
			SetBuildUpgrEx(0,0,1, UPG_ORC_MELEE);//call SetBuildUpgrEx( 0,0,1, UPG_ORC_MELEE		)
			SetBuildUpgrEx(0,0,1, UPG_ORC_SPIKES);//call SetBuildUpgrEx( 0,0,1, UPG_ORC_SPIKES		)
			SleepForever();//call SleepForever()
		}//endfunction

	
	}
}

