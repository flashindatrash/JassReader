using System;
using System.Collections.Generic;

namespace Jass {

	public class N04_brownAi {

		//
		//
		//
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(HOUSE,null);//call CampaignAI(HOUSE,null)
			SetReplacements(2,2,4);//call SetReplacements(2,2,4)
			do_campaign_farms = false;//set do_campaign_farms = false
			campaign_wood_peons = 6;//set campaign_wood_peons = 6
			campaign_gold_peons = 0;//set campaign_gold_peons = 0
			SetBuildUnit(6, PEASANT);//call SetBuildUnit( 6, PEASANT       )
			CampaignDefenderEx(1,1,1, FOOTMEN);//call CampaignDefenderEx( 1,1,1, FOOTMEN	)
			CampaignDefenderEx(1,1,1, PRIEST);//call CampaignDefenderEx( 1,1,1, PRIEST	)
			CampaignDefenderEx(0,0,1, RIFLEMAN);//call CampaignDefenderEx( 0,0,1, RIFLEMAN)
			CampaignDefenderEx(0,0,1, PALADIN);//call CampaignDefenderEx( 0,0,1, PALADIN	)
			WaitForSignal();//call WaitForSignal()
			allow_signal_abort = true;//set allow_signal_abort = true
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(4,4,6, FOOTMAN);//call CampaignAttackerEx( 4,4,6, FOOTMAN	)
			CampaignAttackerEx(1,1,1, PALADIN);//call CampaignAttackerEx( 1,1,1, PALADIN	)
			SuicideOnPlayer(M1,user);//call SuicideOnPlayer(M1,user)
			SetBuildUpgrEx(0,0,1, UPG_MELEE);//call SetBuildUpgrEx( 0,0,1, UPG_MELEE	)
			SetBuildUpgrEx(0,0,1, UPG_ARMOR);//call SetBuildUpgrEx( 0,0,1, UPG_ARMOR	)
			SetBuildUpgrEx(0,0,1, UPG_MASONRY);//call SetBuildUpgrEx( 0,0,1, UPG_MASONRY	)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(5,5,7, FOOTMAN);//call CampaignAttackerEx( 5,5,7, FOOTMAN	)
			CampaignAttackerEx(1,1,2, PRIEST);//call CampaignAttackerEx( 1,1,2, PRIEST	)
			SuicideOnPlayerEx(M6,M6,M5,user);//call SuicideOnPlayerEx(M6,M6,M5,user)
			SetBuildUpgrEx(1,1,1, UPG_DEFEND);//call SetBuildUpgrEx( 1,1,1, UPG_DEFEND	)
			SetBuildUpgrEx(0,0,1, UPG_PRAYING);//call SetBuildUpgrEx( 0,0,1, UPG_PRAYING	)
			while (true) {//loop
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(2,2,3, FOOTMAN);//call CampaignAttackerEx( 2,2,3, FOOTMAN	)
				CampaignAttackerEx(2,2,3, RIFLEMAN);//call CampaignAttackerEx( 2,2,3, RIFLEMAN)
				CampaignAttackerEx(1,1,1, PALADIN);//call CampaignAttackerEx( 1,1,1, PALADIN	)
				SuicideOnPlayerEx(M6,M6,M5,user);//call SuicideOnPlayerEx(M6,M6,M5,user)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(2,2,3, FOOTMAN);//call CampaignAttackerEx( 2,2,3, FOOTMAN	)
				CampaignAttackerEx(1,1,2, PRIEST);//call CampaignAttackerEx( 1,1,2, PRIEST	)
				CampaignAttackerEx(2,2,2, RIFLEMAN);//call CampaignAttackerEx( 2,2,2, RIFLEMAN)
				CampaignAttackerEx(0,0,1, PALADIN);//call CampaignAttackerEx( 0,0,1, PALADIN	)
				SuicideOnPlayerEx(M6,M6,M5,user);//call SuicideOnPlayerEx(M6,M6,M5,user)
				if (CommandsWaiting() !=0) { break; }//exitwhen CommandsWaiting() !=0
			}//endloop
			SleepForever();//call SleepForever()
		}//endfunction

	
	}
}

