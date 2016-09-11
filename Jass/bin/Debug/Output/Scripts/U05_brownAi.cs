using System;
using System.Collections.Generic;

namespace Jass {

	public class U05_brownAi {

		//
		//
		//
		public static player user = Player(3);//player user = Player(3)
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(ELF_FARM,null);//call CampaignAI(ELF_FARM,null)
			do_campaign_farms = false;//set do_campaign_farms = false
			SetReplacements(1,1,3);//call SetReplacements(1,1,3)
			SetCaptainHome(BOTH_CAPTAINS,-4963,-5986);//call SetCaptainHome(BOTH_CAPTAINS,-4963,-5986)
			SetBuildUnitEx(0,0,1, TOWN_HALL);//call SetBuildUnitEx( 0,0,1, TOWN_HALL			)
			SetBuildUnitEx(2,2,2, PEASANT);//call SetBuildUnitEx( 2,2,2, PEASANT				)
			SetBuildUnitEx(0,0,1, HUMAN_ALTAR);//call SetBuildUnitEx( 0,0,1, HUMAN_ALTAR			)
			SetBuildUnitEx(0,0,1, KEEP);//call SetBuildUnitEx( 0,0,1, KEEP				)
			SetBuildUnitEx(0,0,1, CASTLE);//call SetBuildUnitEx( 0,0,1, CASTLE				)
			CampaignDefenderEx(1,1,1, HIGH_SWORDMAN);//call CampaignDefenderEx( 1,1,1, HIGH_SWORDMAN	)
			CampaignDefenderEx(0,0,1, HIGH_ARCHER);//call CampaignDefenderEx( 0,0,1, HIGH_ARCHER		)
			CampaignDefenderEx(0,0,1, PRIEST);//call CampaignDefenderEx( 0,0,1, PRIEST			)
			CampaignDefenderEx(0,0,1, SORCERESS);//call CampaignDefenderEx( 0,0,1, SORCERESS		)
			CampaignDefenderEx(1,1,2, DRAGON_HAWK);//call CampaignDefenderEx( 1,1,2, DRAGON_HAWK		)
			SetBuildUpgrEx(1,1,2, UPG_SORCERY);//call SetBuildUpgrEx( 1,1,2, UPG_SORCERY			)
			SetBuildUpgrEx(1,1,2, UPG_PRAYING);//call SetBuildUpgrEx( 1,1,2, UPG_PRAYING			)
			SleepForever();//call SleepForever()
		}//endfunction

	
	}
}

