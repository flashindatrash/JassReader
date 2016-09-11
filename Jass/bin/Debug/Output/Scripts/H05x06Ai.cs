using System;
using System.Collections.Generic;

namespace Jass {

	public class H05x06Ai {

		//
		//
		//
		public static player user = PlayerEx(1);//player user     = PlayerEx(1)
		public static player akama = PlayerEx(7);//player akama    = PlayerEx(7)
		public static player targ = user;//player targ     = user
		//
		//
		//
		private void switch_to_akama() {//function switch_to_akama takes nothing returns nothing
			while (true) {//loop
				if (CommandsWaiting() > 0) { break; }//exitwhen CommandsWaiting() > 0
				Sleep(1);//call Sleep(1)
			}//endloop
			targ = akama;//set targ = akama
			SetRandomPaths(false);//call SetRandomPaths(false)
			SetBuildUpgrEx(1,1,1, UPG_ORC_WAR_DRUMS);//call SetBuildUpgrEx( 1,1,1, UPG_ORC_WAR_DRUMS   )
			SetBuildUpgrEx(1,1,1, UPG_ORC_BERSERK);//call SetBuildUpgrEx( 1,1,1, UPG_ORC_BERSERK     )
			SetBuildUpgrEx(2,2,3, UPG_ORC_ARMOR);//call SetBuildUpgrEx( 2,2,3, UPG_ORC_ARMOR       )
			SetBuildUpgrEx(2,2,3, UPG_ORC_MELEE);//call SetBuildUpgrEx( 2,2,3, UPG_ORC_MELEE       )
		}//endfunction
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(CHAOS_BURROW,null);//call CampaignAI(CHAOS_BURROW,null)
			SetReplacements(1,1,3);//call SetReplacements(1,1,3)
			DoCampaignFarms(false);//call DoCampaignFarms(false)
			SetBuildUnitEx(0,0,1, GREAT_HALL);//call SetBuildUnitEx( 0,0,1, GREAT_HALL      )
			SetBuildUnitEx(1,1,1, CHAOS_PEON);//call SetBuildUnitEx( 1,1,1, CHAOS_PEON      )
			SetBuildUnitEx(0,0,2, ORC_BARRACKS);//call SetBuildUnitEx( 0,0,2, ORC_BARRACKS    )
			SetBuildUnitEx(0,0,5, CHAOS_BURROW);//call SetBuildUnitEx( 0,0,5, CHAOS_BURROW    )
			SetBuildUnitEx(0,0,1, FORGE);//call SetBuildUnitEx( 0,0,1, FORGE           )
			SetBuildUnitEx(8,8,8, CHAOS_PEON);//call SetBuildUnitEx( 8,8,8, CHAOS_PEON      )
			SetBuildUnitEx(0,0,1, STRONGHOLD);//call SetBuildUnitEx( 0,0,1, STRONGHOLD      )
			SetBuildUnitEx(0,0,2, BESTIARY);//call SetBuildUnitEx( 0,0,2, BESTIARY        )
			SetBuildUnitEx(0,0,2, LODGE);//call SetBuildUnitEx( 0,0,2, LODGE           )
			CampaignDefenderEx(1,1,2, CHAOS_GRUNT);//call CampaignDefenderEx( 1,1,2, CHAOS_GRUNT         )
			CampaignDefenderEx(0,0,2, CHAOS_WARLOCK);//call CampaignDefenderEx( 0,0,2, CHAOS_WARLOCK       )
			CampaignDefenderEx(1,1,1, CHAOS_RAIDER);//call CampaignDefenderEx( 1,1,1, CHAOS_RAIDER        )
			CampaignDefenderEx(0,0,1, CHAOS_BLADEMASTER);//call CampaignDefenderEx( 0,0,1, CHAOS_BLADEMASTER   )
			CampaignDefenderEx(0,0,2, ORC_DRAGON);//call CampaignDefenderEx( 0,0,2, ORC_DRAGON          )
			SetBuildUpgrEx(1,1,1, UPG_ORC_BURROWS);//call SetBuildUpgrEx( 1,1,1, UPG_ORC_BURROWS     )
			SetBuildUpgrEx(0,0,1, UPG_ORC_ARMOR);//call SetBuildUpgrEx( 0,0,1, UPG_ORC_ARMOR       )
			SetBuildUpgrEx(0,0,1, UPG_ORC_MELEE);//call SetBuildUpgrEx( 0,0,1, UPG_ORC_MELEE       )
			SetBuildUpgrEx(1,1,1, UPG_ORC_ENSNARE);//call SetBuildUpgrEx( 1,1,1, UPG_ORC_ENSNARE     )
			SetBuildUpgrEx(3,3,3, UPG_ORC_SPIKES);//call SetBuildUpgrEx( 3,3,3, UPG_ORC_SPIKES      )
			WaitForSignal();//call WaitForSignal()
			StartThread(function switch_to_akama);//call StartThread(function switch_to_akama)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(4,4,6, CHAOS_GRUNT);//call CampaignAttackerEx( 4,4,6, CHAOS_GRUNT     )
			SuicideOnPlayer(M2,targ);//call SuicideOnPlayer(M2,targ)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(3,3,5, CHAOS_GRUNT);//call CampaignAttackerEx( 3,3,5, CHAOS_GRUNT     )
			CampaignAttackerEx(2,2,3, CHAOS_RAIDER);//call CampaignAttackerEx( 2,2,3, CHAOS_RAIDER    )
			SuicideOnPlayerEx(M6,M6,M5,targ);//call SuicideOnPlayerEx(M6,M6,M5,targ)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2,2,4, CHAOS_GRUNT);//call CampaignAttackerEx( 2,2,4, CHAOS_GRUNT     )
			CampaignAttackerEx(1,1,2, CHAOS_RAIDER);//call CampaignAttackerEx( 1,1,2, CHAOS_RAIDER    )
			CampaignAttackerEx(1,1,2, CHAOS_WARLOCK);//call CampaignAttackerEx( 1,1,2, CHAOS_WARLOCK   )
			SuicideOnPlayerEx(M7,M7,M6,targ);//call SuicideOnPlayerEx(M7,M7,M6,targ)
			SetBuildUpgrEx(0,0,1, UPG_ORC_BERSERK);//call SetBuildUpgrEx( 0,0,1, UPG_ORC_BERSERK     )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(3,3,4, CHAOS_GRUNT);//call CampaignAttackerEx( 3,3,4, CHAOS_GRUNT     )
			CampaignAttackerEx(1,1,1, CHAOS_KODO);//call CampaignAttackerEx( 1,1,1, CHAOS_KODO      )
			CampaignAttackerEx(1,1,1, CHAOS_BLADEMASTER);//call CampaignAttackerEx( 1,1,1, CHAOS_BLADEMASTER)
			SuicideOnPlayerEx(M6,M6,M5,targ);//call SuicideOnPlayerEx(M6,M6,M5,targ)
			SetBuildUpgrEx(0,0,1, UPG_ORC_WAR_DRUMS);//call SetBuildUpgrEx( 0,0,1, UPG_ORC_WAR_DRUMS   )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(4,4,6, CHAOS_RAIDER);//call CampaignAttackerEx( 4,4,6, CHAOS_RAIDER    )
			CampaignAttackerEx(2,2,3, CHAOS_WARLOCK);//call CampaignAttackerEx( 2,2,3, CHAOS_WARLOCK   )
			SuicideOnPlayerEx(M7,M7,M6,targ);//call SuicideOnPlayerEx(M7,M7,M6,targ)
			SetBuildUpgrEx(1,1,2, UPG_ORC_ARMOR);//call SetBuildUpgrEx( 1,1,2, UPG_ORC_ARMOR       )
			SetBuildUpgrEx(1,1,2, UPG_ORC_MELEE);//call SetBuildUpgrEx( 1,1,2, UPG_ORC_MELEE       )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(6,6,7, CHAOS_GRUNT);//call CampaignAttackerEx( 6,6,7, CHAOS_GRUNT     )
			CampaignAttackerEx(1,1,1, CHAOS_BLADEMASTER);//call CampaignAttackerEx( 1,1,1, CHAOS_BLADEMASTER)
			CampaignAttackerEx(1,1,2, CHAOS_WARLOCK);//call CampaignAttackerEx( 1,1,2, CHAOS_WARLOCK   )
			SuicideOnPlayerEx(M6,M6,M5,targ);//call SuicideOnPlayerEx(M6,M6,M5,targ)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(4,4,7, CHAOS_RAIDER);//call CampaignAttackerEx( 4,4,7, CHAOS_RAIDER    )
			CampaignAttackerEx(1,1,1, CHAOS_KODO);//call CampaignAttackerEx( 1,1,1, CHAOS_KODO      )
			CampaignAttackerEx(1,1,2, CHAOS_WARLOCK);//call CampaignAttackerEx( 1,1,2, CHAOS_WARLOCK   )
			SuicideOnPlayerEx(M7,M7,M6,targ);//call SuicideOnPlayerEx(M7,M7,M6,targ)
			SetBuildUpgrEx(1,1,1, UPG_ORC_WAR_DRUMS);//call SetBuildUpgrEx( 1,1,1, UPG_ORC_WAR_DRUMS   )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(7,7,9, CHAOS_GRUNT);//call CampaignAttackerEx( 7,7,9, CHAOS_GRUNT     )
			CampaignAttackerEx(2,2,3, CHAOS_WARLOCK);//call CampaignAttackerEx( 2,2,3, CHAOS_WARLOCK   )
			SuicideOnPlayerEx(M6,M6,M5,targ);//call SuicideOnPlayerEx(M6,M6,M5,targ)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(4,4,5, CHAOS_GRUNT);//call CampaignAttackerEx( 4,4,5, CHAOS_GRUNT     )
			CampaignAttackerEx(1,1,1, CHAOS_BLADEMASTER);//call CampaignAttackerEx( 1,1,1, CHAOS_BLADEMASTER)
			CampaignAttackerEx(1,1,2, CHAOS_WARLOCK);//call CampaignAttackerEx( 1,1,2, CHAOS_WARLOCK   )
			SuicideOnPlayerEx(M7,M7,M6,targ);//call SuicideOnPlayerEx(M7,M7,M6,targ)
			SetBuildUpgrEx(1,1,3, UPG_ORC_ARMOR);//call SetBuildUpgrEx( 1,1,3, UPG_ORC_ARMOR       )
			SetBuildUpgrEx(1,1,3, UPG_ORC_MELEE);//call SetBuildUpgrEx( 1,1,3, UPG_ORC_MELEE       )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(3,3,4, CHAOS_GRUNT);//call CampaignAttackerEx( 3,3,4, CHAOS_GRUNT     )
			CampaignAttackerEx(3,3,4, CHAOS_RAIDER);//call CampaignAttackerEx( 3,3,4, CHAOS_RAIDER    )
			CampaignAttackerEx(1,1,2, CHAOS_WARLOCK);//call CampaignAttackerEx( 1,1,2, CHAOS_WARLOCK   )
			SuicideOnPlayerEx(M6,M6,M5,targ);//call SuicideOnPlayerEx(M6,M6,M5,targ)
			while (true) {//loop
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(3,3,5, CHAOS_GRUNT);//call CampaignAttackerEx( 3,3,5, CHAOS_GRUNT     )
				CampaignAttackerEx(1,1,2, CHAOS_KODO);//call CampaignAttackerEx( 1,1,2, CHAOS_KODO      )
				CampaignAttackerEx(1,1,1, CHAOS_BLADEMASTER);//call CampaignAttackerEx( 1,1,1, CHAOS_BLADEMASTER)
				CampaignAttackerEx(1,1,2, CHAOS_WARLOCK);//call CampaignAttackerEx( 1,1,2, CHAOS_WARLOCK   )
				SuicideOnPlayerEx(M7,M7,M6,targ);//call SuicideOnPlayerEx(M7,M7,M6,targ)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(3,3,4, CHAOS_GRUNT);//call CampaignAttackerEx( 3,3,4, CHAOS_GRUNT     )
				CampaignAttackerEx(3,3,4, CHAOS_RAIDER);//call CampaignAttackerEx( 3,3,4, CHAOS_RAIDER    )
				CampaignAttackerEx(1,1,2, CHAOS_WARLOCK);//call CampaignAttackerEx( 1,1,2, CHAOS_WARLOCK   )
				SuicideOnPlayerEx(M6,M6,M5,targ);//call SuicideOnPlayerEx(M6,M6,M5,targ)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(5,5,8, CHAOS_RAIDER);//call CampaignAttackerEx( 5,5,8, CHAOS_RAIDER    )
				CampaignAttackerEx(1,1,1, CHAOS_BLADEMASTER);//call CampaignAttackerEx( 1,1,1, CHAOS_BLADEMASTER)
				SuicideOnPlayerEx(M7,M7,M6,targ);//call SuicideOnPlayerEx(M7,M7,M6,targ)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(6,6,8, CHAOS_GRUNT);//call CampaignAttackerEx( 6,6,8, CHAOS_GRUNT     )
				CampaignAttackerEx(3,3,4, CHAOS_WARLOCK);//call CampaignAttackerEx( 3,3,4, CHAOS_WARLOCK   )
				SuicideOnPlayerEx(M6,M6,M5,targ);//call SuicideOnPlayerEx(M6,M6,M5,targ)
			}//endloop
		}//endfunction

	
	}
}

