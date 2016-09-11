using System;
using System.Collections.Generic;

namespace Jass {

	public class N04x06Ai {

		//
		//
		//
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(NAGA_CORAL,null);//call CampaignAI(NAGA_CORAL,null)
			SetReplacements(5,5,5);//call SetReplacements(5,5,5)
			do_campaign_farms = false;//set do_campaign_farms = false
			SetAmphibious();//call SetAmphibious()
			SetBuildUnitEx(1, 1, 1, NAGA_SLAVE);//call SetBuildUnitEx( 1, 1, 1, NAGA_SLAVE    )
			SetBuildUnitEx(1, 1, 1, NAGA_TEMPLE);//call SetBuildUnitEx( 1, 1, 1, NAGA_TEMPLE   )
			SetBuildUnitEx(1, 1, 1, NAGA_SHRINE);//call SetBuildUnitEx( 1, 1, 1, NAGA_SHRINE   )
			SetBuildUnitEx(1, 1, 1, NAGA_SPAWNING);//call SetBuildUnitEx( 1, 1, 1, NAGA_SPAWNING )
			SetBuildUnitEx(5, 5, 5, NAGA_SLAVE);//call SetBuildUnitEx( 5, 5, 5, NAGA_SLAVE    )
			SetBuildUnitEx(3, 3, 3, NAGA_GUARDIAN);//call SetBuildUnitEx( 3, 3, 3, NAGA_GUARDIAN )
			SetBuildUpgrEx(0,0,1, UPG_SIREN);//call SetBuildUpgrEx( 0,0,1, UPG_SIREN           )
			SetBuildUpgrEx(0,0,1, UPG_NAGA_ATTACK);//call SetBuildUpgrEx( 0,0,1, UPG_NAGA_ATTACK     )
			SetBuildUpgrEx(0,0,1, UPG_NAGA_ARMOR);//call SetBuildUpgrEx( 0,0,1, UPG_NAGA_ARMOR      )
			CampaignDefenderEx(1,1,1, NAGA_MYRMIDON);//call CampaignDefenderEx( 1,1,1, NAGA_MYRMIDON   )
			CampaignDefenderEx(3,3,4, NAGA_COUATL);//call CampaignDefenderEx( 3,3,4, NAGA_COUATL     )
			CampaignDefenderEx(1,1,1, NAGA_REAVER);//call CampaignDefenderEx( 1,1,1, NAGA_REAVER     )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(6, 6, 6, NAGA_REAVER);//call CampaignAttackerEx( 6, 6, 6, NAGA_REAVER   )
			CampaignAttackerEx(1, 1, 2, NAGA_MYRMIDON);//call CampaignAttackerEx( 1, 1, 2, NAGA_MYRMIDON )
			SuicideOnPlayer(M1,user);//call SuicideOnPlayer(M1,user)
			SetBuildUpgrEx(1,1,1, UPG_NAGA_ENSNARE);//call SetBuildUpgrEx( 1,1,1, UPG_NAGA_ENSNARE    )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(4, 4, 6, NAGA_COUATL);//call CampaignAttackerEx( 4, 4, 6, NAGA_COUATL   )
			SuicideOnPlayerEx(M5,M5,M4,user);//call SuicideOnPlayerEx(M5,M5,M4,user)
			SetBuildUpgrEx(0,0,2, UPG_SIREN);//call SetBuildUpgrEx( 0,0,2, UPG_SIREN           )
			SetBuildUpgrEx(0,0,1, UPG_NAGA_ABOLISH);//call SetBuildUpgrEx( 0,0,1, UPG_NAGA_ABOLISH    )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(5, 5, 6, NAGA_REAVER);//call CampaignAttackerEx( 5, 5, 6, NAGA_REAVER   )
			CampaignAttackerEx(1, 1, 1, NAGA_TURTLE);//call CampaignAttackerEx( 1, 1, 1, NAGA_TURTLE   )
			CampaignAttackerEx(2, 2, 3, NAGA_SIREN);//call CampaignAttackerEx( 2, 2, 3, NAGA_SIREN    )
			SuicideOnPlayerEx(M5,M5,M4,user);//call SuicideOnPlayerEx(M5,M5,M4,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2, 2, 4, NAGA_MYRMIDON);//call CampaignAttackerEx( 2, 2, 4, NAGA_MYRMIDON )
			CampaignAttackerEx(1, 1, 1, NAGA_TURTLE);//call CampaignAttackerEx( 1, 1, 1, NAGA_TURTLE   )
			SuicideOnPlayerEx(M5,M5,M4,user);//call SuicideOnPlayerEx(M5,M5,M4,user)
			//
			while (true) {//loop
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(4, 4, 6, NAGA_COUATL);//call CampaignAttackerEx( 4, 4, 6, NAGA_COUATL      )
				SuicideOnPlayerEx(M5,M5,M4,user);//call SuicideOnPlayerEx(M5,M5,M4,user)
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(2, 2, 2, NAGA_MYRMIDON);//call CampaignAttackerEx( 2, 2, 2, NAGA_MYRMIDON     )
				CampaignAttackerEx(1, 1, 2, NAGA_TURTLE);//call CampaignAttackerEx( 1, 1, 2, NAGA_TURTLE       )
				SuicideOnPlayerEx(M5,M5,M4,user);//call SuicideOnPlayerEx(M5,M5,M4,user)
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(5, 5, 6, NAGA_REAVER);//call CampaignAttackerEx( 5, 5, 6, NAGA_REAVER       )
				CampaignAttackerEx(2, 2, 3, NAGA_SIREN);//call CampaignAttackerEx( 2, 2, 3, NAGA_SIREN        )
				CampaignAttackerEx(1, 1, 1, NAGA_TURTLE);//call CampaignAttackerEx( 1, 1, 1, NAGA_TURTLE       )
				SuicideOnPlayerEx(M5,M5,M4,user);//call SuicideOnPlayerEx(M5,M5,M4,user)
			}//endloop
		}//endfunction

	
	}
}

