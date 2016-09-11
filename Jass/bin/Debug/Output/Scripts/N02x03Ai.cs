using System;
using System.Collections.Generic;

namespace Jass {

	public class N02x03Ai {

		//
		//
		//
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(NAGA_CORAL,null);//call CampaignAI(NAGA_CORAL,null)
			SetReplacements(1,1,3);//call SetReplacements(1,1,3)
			do_campaign_farms = false;//set do_campaign_farms = false
			SetAmphibious();//call SetAmphibious()
			SetBuildUnitEx(7, 7, 7, NAGA_SLAVE);//call SetBuildUnitEx( 7, 7, 7, NAGA_SLAVE    )
			CampaignDefenderEx(0, 0, 1, NAGA_COUATL);//call CampaignDefenderEx( 0, 0, 1, NAGA_COUATL	    )
			CampaignDefenderEx(0, 1, 1, NAGA_REAVER);//call CampaignDefenderEx( 0, 1, 1, NAGA_REAVER	    )
			CampaignDefenderEx(0, 1, 1, NAGA_SIREN);//call CampaignDefenderEx( 0, 1, 1, NAGA_SIREN	    )
			SetBuildUpgrEx(0,0,1, UPG_SIREN);//call SetBuildUpgrEx( 0,0,1, UPG_SIREN			)
			SetBuildUpgrEx(0,0,1, UPG_NAGA_ATTACK);//call SetBuildUpgrEx( 0,0,1, UPG_NAGA_ATTACK		)
			SetBuildUpgrEx(0,0,1, UPG_NAGA_ARMOR);//call SetBuildUpgrEx( 0,0,1, UPG_NAGA_ARMOR		)
			WaitForSignal();//call WaitForSignal()
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2,2,5, NAGA_COUATL);//call CampaignAttackerEx( 2,2,5, NAGA_COUATL       )
			SuicideOnPlayerEx(M10,M10,M7,user);//call SuicideOnPlayerEx(M10,M10,M7,user)
			SetBuildUpgrEx(0,0,2, UPG_SIREN);//call SetBuildUpgrEx( 0,0,2, UPG_SIREN			)
			SetBuildUpgrEx(0,0,2, UPG_NAGA_ATTACK);//call SetBuildUpgrEx( 0,0,2, UPG_NAGA_ATTACK		)
			SetBuildUpgrEx(0,0,2, UPG_NAGA_ARMOR);//call SetBuildUpgrEx( 0,0,2, UPG_NAGA_ARMOR		)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2, 2, 4, NAGA_COUATL);//call CampaignAttackerEx( 2, 2, 4, NAGA_COUATL		)
			CampaignAttackerEx(1, 1, 2, NAGA_SIREN);//call CampaignAttackerEx( 1, 1, 2, NAGA_SIREN		)
			SuicideOnPlayerEx(M7,M7,M4,user);//call SuicideOnPlayerEx(M7,M7,M4,user)
			//
			//
			while (true) {//loop
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(3, 3, 6, NAGA_COUATL);//call CampaignAttackerEx( 3, 3, 6, NAGA_COUATL		)
				CampaignAttackerEx(3, 3, 6, NAGA_REAVER);//call CampaignAttackerEx( 3, 3, 6, NAGA_REAVER		)
				SuicideOnPlayerEx(M8,M8,M4,user);//call SuicideOnPlayerEx(M8,M8,M4,user)
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(2, 2, 4, NAGA_COUATL);//call CampaignAttackerEx( 2, 2, 4, NAGA_COUATL		)
				CampaignAttackerEx(1, 1, 2, NAGA_SIREN);//call CampaignAttackerEx( 1, 1, 2, NAGA_SIREN		)
				SuicideOnPlayerEx(M8,M8,M3,user);//call SuicideOnPlayerEx(M8,M8,M3,user)
			}//endloop
		}//endfunction

	
	}
}

