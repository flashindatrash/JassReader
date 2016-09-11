using System;
using System.Collections.Generic;

namespace Jass {

	public class N04x04Ai {

		//
		//
		//
		public static player user = PlayerEx(2);//player user = PlayerEx(2)
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(NAGA_CORAL,null);//call CampaignAI(NAGA_CORAL,null)
			campaign_wood_peons = 3;//set campaign_wood_peons = 3
			SetReplacements(5,5,5);//call SetReplacements(5,5,5)
			do_campaign_farms = false;//set do_campaign_farms = false
			SetAmphibious();//call SetAmphibious()
			SetCaptainHome(ATTACK_CAPTAIN,3428,4113);//call SetCaptainHome(ATTACK_CAPTAIN,3428,4113)
			SetBuildUnitEx(1, 1, 1, NAGA_SLAVE);//call SetBuildUnitEx( 1, 1, 1, NAGA_SLAVE    )
			SetBuildUnitEx(1, 1, 1, NAGA_TEMPLE);//call SetBuildUnitEx( 1, 1, 1, NAGA_TEMPLE   )
			SetBuildUnitEx(1, 1, 1, NAGA_SHRINE);//call SetBuildUnitEx( 1, 1, 1, NAGA_SHRINE   )
			SetBuildUnitEx(1, 1, 1, NAGA_SPAWNING);//call SetBuildUnitEx( 1, 1, 1, NAGA_SPAWNING )
			SetBuildUnitEx(1, 1, 1, NAGA_ALTAR);//call SetBuildUnitEx( 1, 1, 1, NAGA_ALTAR    )
			SetBuildUnitEx(3, 3, 3, NAGA_SLAVE);//call SetBuildUnitEx( 3, 3, 3, NAGA_SLAVE    )
			SetBuildUnitEx(3, 3, 3, NAGA_GUARDIAN);//call SetBuildUnitEx( 3, 3, 3, NAGA_GUARDIAN )
			CampaignDefenderEx(1,1,2, NAGA_MYRMIDON);//call CampaignDefenderEx( 1,1,2, NAGA_MYRMIDON   )
			CampaignDefenderEx(1,1,1, NAGA_SIREN);//call CampaignDefenderEx( 1,1,1, NAGA_SIREN      )
			CampaignDefenderEx(2,2,3, NAGA_REAVER);//call CampaignDefenderEx( 2,2,3, NAGA_REAVER     )
			CampaignDefenderEx(1,1,1, NAGA_VASHJ);//call CampaignDefenderEx( 1,1,1, NAGA_VASHJ      )
			SetBuildUpgrEx(0,0,1, UPG_SIREN);//call SetBuildUpgrEx( 0,0,1, UPG_SIREN           )
			SetBuildUpgrEx(0,0,1, UPG_NAGA_ATTACK);//call SetBuildUpgrEx( 0,0,1, UPG_NAGA_ATTACK     )
			SetBuildUpgrEx(0,0,1, UPG_NAGA_ARMOR);//call SetBuildUpgrEx( 0,0,1, UPG_NAGA_ARMOR      )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(1, 1, 1, NAGA_VASHJ);//call CampaignAttackerEx( 1, 1, 1, NAGA_VASHJ        )
			CampaignAttackerEx(4, 4, 6, NAGA_REAVER);//call CampaignAttackerEx( 4, 4, 6, NAGA_REAVER       )
			CampaignAttackerEx(0, 0, 1, NAGA_MYRMIDON);//call CampaignAttackerEx( 0, 0, 1, NAGA_MYRMIDON		)
			SuicideOnPlayer(M3,user);//call SuicideOnPlayer(M3,user)
			SetBuildUpgrEx(1,1,1, UPG_NAGA_ENSNARE);//call SetBuildUpgrEx( 1,1,1, UPG_NAGA_ENSNARE    )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2, 2, 5, NAGA_REAVER);//call CampaignAttackerEx( 2, 2, 5, NAGA_REAVER       )
			CampaignAttackerEx(3, 3, 4, NAGA_SNAP_DRAGON);//call CampaignAttackerEx( 3, 3, 4, NAGA_SNAP_DRAGON  )
			CampaignAttackerEx(0, 0, 1, NAGA_MYRMIDON);//call CampaignAttackerEx( 0, 0, 1, NAGA_MYRMIDON		)
			SuicideOnPlayerEx(M5,M5,M4,user);//call SuicideOnPlayerEx(M5,M5,M4,user)
			SetBuildUpgrEx(0,0,2, UPG_SIREN);//call SetBuildUpgrEx( 0,0,2, UPG_SIREN           )
			SetBuildUpgrEx(0,0,1, UPG_NAGA_ABOLISH);//call SetBuildUpgrEx( 0,0,1, UPG_NAGA_ABOLISH    )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(5, 5, 6, NAGA_REAVER);//call CampaignAttackerEx( 5, 5, 6, NAGA_REAVER       )
			CampaignAttackerEx(1, 1, 1, NAGA_VASHJ);//call CampaignAttackerEx( 1, 1, 1, NAGA_VASHJ        )
			CampaignAttackerEx(1, 1, 1, NAGA_TURTLE);//call CampaignAttackerEx( 1, 1, 1, NAGA_TURTLE       )
			SuicideOnPlayerEx(M5,M5,M4,user);//call SuicideOnPlayerEx(M5,M5,M4,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2, 2, 3, NAGA_MYRMIDON);//call CampaignAttackerEx( 2, 2, 3, NAGA_MYRMIDON     )
			CampaignAttackerEx(4, 4, 4, NAGA_SNAP_DRAGON);//call CampaignAttackerEx( 4, 4, 4, NAGA_SNAP_DRAGON  )
			CampaignAttackerEx(1, 1, 3, NAGA_SIREN);//call CampaignAttackerEx( 1, 1, 3, NAGA_SIREN        )
			CampaignAttackerEx(1, 1, 1, NAGA_TURTLE);//call CampaignAttackerEx( 1, 1, 1, NAGA_TURTLE       )
			SuicideOnPlayerEx(M5,M5,M4,user);//call SuicideOnPlayerEx(M5,M5,M4,user)
			//
			while (true) {//loop
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(1, 1, 1, NAGA_VASHJ);//call CampaignAttackerEx( 1, 1, 1, NAGA_VASHJ        )
				CampaignAttackerEx(2, 2, 2, NAGA_MYRMIDON);//call CampaignAttackerEx( 2, 2, 2, NAGA_MYRMIDON     )
				CampaignAttackerEx(2, 2, 3, NAGA_SNAP_DRAGON);//call CampaignAttackerEx( 2, 2, 3, NAGA_SNAP_DRAGON  )
				SuicideOnPlayerEx(M5,M5,M4,user);//call SuicideOnPlayerEx(M5,M5,M4,user)
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(4, 4, 6, NAGA_REAVER);//call CampaignAttackerEx( 4, 4, 6, NAGA_REAVER       )
				CampaignAttackerEx(2, 2, 3, NAGA_SIREN);//call CampaignAttackerEx( 2, 2, 3, NAGA_SIREN        )
				CampaignAttackerEx(1, 1, 2, NAGA_TURTLE);//call CampaignAttackerEx( 1, 1, 2, NAGA_TURTLE       )
				SuicideOnPlayerEx(M5,M5,M4,user);//call SuicideOnPlayerEx(M5,M5,M4,user)
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(0, 0, 1, NAGA_VASHJ);//call CampaignAttackerEx( 0, 0, 1, NAGA_VASHJ        )
				CampaignAttackerEx(4, 4, 5, NAGA_MYRMIDON);//call CampaignAttackerEx( 4, 4, 5, NAGA_MYRMIDON     )
				CampaignAttackerEx(2, 2, 3, NAGA_SNAP_DRAGON);//call CampaignAttackerEx( 2, 2, 3, NAGA_SNAP_DRAGON  )
				SuicideOnPlayerEx(M5,M5,M4,user);//call SuicideOnPlayerEx(M5,M5,M4,user)
			}//endloop
		}//endfunction

	
	}
}

