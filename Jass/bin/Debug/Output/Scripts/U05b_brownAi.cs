using System;
using System.Collections.Generic;

namespace Jass {

	public class U05b_brownAi {

		//
		//
		//
		public static player user = Player(3);//player user = Player(3)
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(ELF_FARM,null);//call CampaignAI(ELF_FARM,null)
			SetReplacements(0,1,3);//call SetReplacements(0,1,3)
			SetBuildUnitEx(0,0,1, TOWN_HALL);//call SetBuildUnitEx( 0,0,1, TOWN_HALL			)
			SetBuildUnitEx(2,2,2, PEASANT);//call SetBuildUnitEx( 2,2,2, PEASANT				)
			SetBuildUnitEx(0,0,1, ELF_HIGH_BARRACKS);//call SetBuildUnitEx( 0,0,1, ELF_HIGH_BARRACKS	)
			SetBuildUnitEx(0,0,14, ELF_FARM);//call SetBuildUnitEx( 0,0,14, ELF_FARM			)
			SetBuildUnitEx(0,0,1, LUMBER_MILL);//call SetBuildUnitEx( 0,0,1, LUMBER_MILL			)
			SetBuildUnitEx(0,0,1, BLACKSMITH);//call SetBuildUnitEx( 0,0,1, BLACKSMITH			)
			SetBuildUnitEx(0,0,1, HUMAN_ALTAR);//call SetBuildUnitEx( 0,0,1, HUMAN_ALTAR			)
			SetBuildUnitEx(0,0,1, KEEP);//call SetBuildUnitEx( 0,0,1, KEEP				)
			SetBuildUnitEx(0,0,1, SANCTUM);//call SetBuildUnitEx( 0,0,1, SANCTUM				)
			SetBuildUnitEx(0,0,1, CASTLE);//call SetBuildUnitEx( 0,0,1, CASTLE				)
			CampaignDefenderEx(1,1,3, HIGH_SWORDMAN);//call CampaignDefenderEx( 1,1,3, HIGH_SWORDMAN	)
			CampaignDefenderEx(1,1,4, HIGH_ARCHER);//call CampaignDefenderEx( 1,1,4, HIGH_ARCHER		)
			CampaignDefenderEx(0,1,1, PRIEST);//call CampaignDefenderEx( 0,1,1, PRIEST			)
			CampaignDefenderEx(0,1,1, SORCERESS);//call CampaignDefenderEx( 0,1,1, SORCERESS		)
			CampaignDefenderEx(0,2,4, DRAGON_HAWK);//call CampaignDefenderEx( 0,2,4, DRAGON_HAWK		)
			SetBuildUpgrEx(0,0,2, UPG_SORCERY);//call SetBuildUpgrEx( 0,0,2, UPG_SORCERY			)
			SetBuildUpgrEx(0,0,2, UPG_PRAYING);//call SetBuildUpgrEx( 0,0,2, UPG_PRAYING			)
			SleepForever();//call SleepForever()
		}//endfunction

	
	}
}

