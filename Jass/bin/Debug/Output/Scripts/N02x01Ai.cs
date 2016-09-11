using System;
using System.Collections.Generic;

namespace Jass {

	public class N02x01Ai {

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
			SetBuildUnitEx(8, 8, 8, NAGA_SLAVE);//call SetBuildUnitEx( 8, 8, 8, NAGA_SLAVE    )
			CampaignDefenderEx(0, 0, 2, NAGA_SNAP_DRAGON);//call CampaignDefenderEx( 0, 0, 2, NAGA_SNAP_DRAGON  )
			CampaignDefenderEx(1, 1, 2, NAGA_REAVER);//call CampaignDefenderEx( 1, 1, 2, NAGA_REAVER	    )
			CampaignDefenderEx(0, 0, 1, NAGA_SIREN);//call CampaignDefenderEx( 0, 0, 1, NAGA_SIREN		)
			WaitForSignal();//call WaitForSignal()
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(1, 1, 2, NAGA_SIREN);//call CampaignAttackerEx( 1, 1, 2, NAGA_SIREN		)
			CampaignAttackerEx(3, 3, 5, NAGA_REAVER);//call CampaignAttackerEx( 3, 3, 5, NAGA_REAVER		)
			SuicideOnPlayerEx(M3,M3,M2,user);//call SuicideOnPlayerEx(M3,M3,M2,user)
			SetBuildUpgrEx(0,0,1, UPG_SIREN);//call SetBuildUpgrEx( 0,0,1, UPG_SIREN			)
			SetBuildUpgrEx(0,0,1, UPG_NAGA_ATTACK);//call SetBuildUpgrEx( 0,0,1, UPG_NAGA_ATTACK		)
			SetBuildUpgrEx(0,0,1, UPG_NAGA_ARMOR);//call SetBuildUpgrEx( 0,0,1, UPG_NAGA_ARMOR		)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2, 2, 4, NAGA_REAVER);//call CampaignAttackerEx( 2, 2, 4, NAGA_REAVER		)
			CampaignAttackerEx(2, 2, 4, NAGA_SNAP_DRAGON);//call CampaignAttackerEx( 2, 2, 4, NAGA_SNAP_DRAGON  )
			SuicideOnPlayerEx(M5,M5,M4,user);//call SuicideOnPlayerEx(M5,M5,M4,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(1, 1, 2, NAGA_SIREN);//call CampaignAttackerEx( 1, 1, 2, NAGA_SIREN		)
			CampaignAttackerEx(6, 6, 8, NAGA_REAVER);//call CampaignAttackerEx( 6, 6, 8, NAGA_REAVER		)
			SuicideOnPlayerEx(M7,M7,M4,user);//call SuicideOnPlayerEx(M7,M7,M4,user)
			//
			//
			while (true) {//loop
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(4, 4, 6, NAGA_REAVER);//call CampaignAttackerEx( 4, 4, 6, NAGA_REAVER		)
				CampaignAttackerEx(1, 1, 3, NAGA_SNAP_DRAGON);//call CampaignAttackerEx( 1, 1, 3, NAGA_SNAP_DRAGON  )
				SuicideOnPlayerEx(M8,M8,M4,user);//call SuicideOnPlayerEx(M8,M8,M4,user)
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(1, 1, 2, NAGA_SIREN);//call CampaignAttackerEx( 1, 1, 2, NAGA_SIREN		)
				CampaignAttackerEx(2, 2, 4, NAGA_REAVER);//call CampaignAttackerEx( 2, 2, 4, NAGA_REAVER		)
				CampaignAttackerEx(3, 3, 6, NAGA_SNAP_DRAGON);//call CampaignAttackerEx( 3, 3, 6, NAGA_SNAP_DRAGON  )
				SuicideOnPlayerEx(M8,M8,M4,user);//call SuicideOnPlayerEx(M8,M8,M4,user)
			}//endloop
		}//endfunction

	
	}
}

