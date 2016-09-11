using System;
using System.Collections.Generic;

namespace Jass {

	public class U04x06Ai {

		//
		//
		//
		public static player user = PlayerEx(4);//player user = PlayerEx(4)
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(NAGA_CORAL,null);//call CampaignAI(NAGA_CORAL,null)
			SetReplacements(2,2,3);//call SetReplacements(2,2,3)
			SetAmphibious();//call SetAmphibious()
			SetBuildUnitEx(1, 1, 1, NAGA_SLAVE);//call SetBuildUnitEx( 1, 1, 1, NAGA_SLAVE    )
			SetBuildUnitEx(0, 0, 1, NAGA_TEMPLE);//call SetBuildUnitEx( 0, 0, 1, NAGA_TEMPLE   )
			SetBuildUnitEx(0, 0, 1, NAGA_SHRINE);//call SetBuildUnitEx( 0, 0, 1, NAGA_SHRINE   )
			SetBuildUnitEx(0, 0, 1, NAGA_SPAWNING);//call SetBuildUnitEx( 0, 0, 1, NAGA_SPAWNING )
			SetBuildUnitEx(0, 0, 1, NAGA_ALTAR);//call SetBuildUnitEx( 0, 0, 1, NAGA_ALTAR    )
			SetBuildUnitEx(5, 5, 5, NAGA_SLAVE);//call SetBuildUnitEx( 5, 5, 5, NAGA_SLAVE    )
			SetBuildUnitEx(0, 0, 3, NAGA_GUARDIAN);//call SetBuildUnitEx( 0, 0, 3, NAGA_GUARDIAN )
			CampaignDefenderEx(1,1,1, NAGA_MYRMIDON);//call CampaignDefenderEx( 1,1,1, NAGA_MYRMIDON   )
			CampaignDefenderEx(0,0,1, NAGA_ROYAL);//call CampaignDefenderEx( 0,0,1, NAGA_ROYAL      )
			CampaignDefenderEx(1,1,1, NAGA_SIREN);//call CampaignDefenderEx( 1,1,1, NAGA_SIREN      )
			CampaignDefenderEx(0,0,2, NAGA_REAVER);//call CampaignDefenderEx( 0,0,2, NAGA_REAVER     )
			CampaignDefenderEx(0,0,1, NAGA_VASHJ);//call CampaignDefenderEx( 0,0,1, NAGA_VASHJ      )
			SetBuildUpgrEx(0,0,1, UPG_SIREN);//call SetBuildUpgrEx( 0,0,1, UPG_SIREN           )
			SetBuildUpgrEx(0,0,1, UPG_NAGA_ATTACK);//call SetBuildUpgrEx( 0,0,1, UPG_NAGA_ATTACK     )
			SetBuildUpgrEx(0,0,1, UPG_NAGA_ARMOR);//call SetBuildUpgrEx( 0,0,1, UPG_NAGA_ARMOR      )
			WaitForSignal();//call WaitForSignal()
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2, 2, 3, NAGA_MYRMIDON);//call CampaignAttackerEx( 2, 2, 3, NAGA_MYRMIDON )
			SuicideOnPlayerEx(M3,M3,M2,user);//call SuicideOnPlayerEx(M3,M3,M2,user)
			SetBuildUpgrEx(1,1,1, UPG_NAGA_ENSNARE);//call SetBuildUpgrEx( 1,1,1, UPG_NAGA_ENSNARE    )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(4, 4, 7, NAGA_COUATL);//call CampaignAttackerEx( 4, 4, 7, NAGA_COUATL   )
			SuicideOnPlayerEx(M6,M6,M5,user);//call SuicideOnPlayerEx(M6,M6,M5,user)
			SetBuildUpgrEx(0,0,2, UPG_SIREN);//call SetBuildUpgrEx( 0,0,2, UPG_SIREN           )
			SetBuildUpgrEx(0,0,1, UPG_NAGA_ABOLISH);//call SetBuildUpgrEx( 0,0,1, UPG_NAGA_ABOLISH    )
			SetBuildUpgrEx(0,0,2, UPG_NAGA_ATTACK);//call SetBuildUpgrEx( 0,0,2, UPG_NAGA_ATTACK     )
			SetBuildUpgrEx(0,0,2, UPG_NAGA_ARMOR);//call SetBuildUpgrEx( 0,0,2, UPG_NAGA_ARMOR      )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(4, 4, 6, NAGA_REAVER);//call CampaignAttackerEx( 4, 4, 6, NAGA_REAVER       )
			CampaignAttackerEx(2, 2, 3, NAGA_SNAP_DRAGON);//call CampaignAttackerEx( 2, 2, 3, NAGA_SNAP_DRAGON  )
			CampaignAttackerEx(1, 1, 1, NAGA_VASHJ);//call CampaignAttackerEx( 1, 1, 1, NAGA_VASHJ        )
			SuicideOnPlayerEx(M6,M6,M5,user);//call SuicideOnPlayerEx(M6,M6,M5,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2, 2, 3, NAGA_MYRMIDON);//call CampaignAttackerEx( 2, 2, 3, NAGA_MYRMIDON     )
			CampaignAttackerEx(2, 2, 3, NAGA_SIREN);//call CampaignAttackerEx( 2, 2, 3, NAGA_SIREN        )
			CampaignAttackerEx(1, 1, 2, NAGA_TURTLE);//call CampaignAttackerEx( 1, 1, 2, NAGA_TURTLE       )
			SuicideOnPlayerEx(M6,M6,M5,user);//call SuicideOnPlayerEx(M6,M6,M5,user)
			SetBuildUpgrEx(0,0,3, UPG_NAGA_ATTACK);//call SetBuildUpgrEx( 0,0,3, UPG_NAGA_ATTACK     )
			SetBuildUpgrEx(0,0,3, UPG_NAGA_ARMOR);//call SetBuildUpgrEx( 0,0,3, UPG_NAGA_ARMOR      )
			//
			while (true) {//loop
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(5, 5, 7, NAGA_COUATL);//call CampaignAttackerEx( 5, 5, 7, NAGA_COUATL   )
				SuicideOnPlayerEx(M6,M6,M5,user);//call SuicideOnPlayerEx(M6,M6,M5,user)
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(1, 1, 1, NAGA_VASHJ);//call CampaignAttackerEx( 1, 1, 1, NAGA_VASHJ        )
				CampaignAttackerEx(1, 1, 2, NAGA_MYRMIDON);//call CampaignAttackerEx( 1, 1, 2, NAGA_MYRMIDON     )
				CampaignAttackerEx(1, 1, 2, NAGA_SIREN);//call CampaignAttackerEx( 1, 1, 2, NAGA_SIREN        )
				CampaignAttackerEx(2, 2, 3, NAGA_SNAP_DRAGON);//call CampaignAttackerEx( 2, 2, 3, NAGA_SNAP_DRAGON  )
				SuicideOnPlayerEx(M6,M6,M5,user);//call SuicideOnPlayerEx(M6,M6,M5,user)
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(3, 3, 4, NAGA_MYRMIDON);//call CampaignAttackerEx( 3, 3, 4, NAGA_MYRMIDON     )
				CampaignAttackerEx(2, 2, 3, NAGA_SNAP_DRAGON);//call CampaignAttackerEx( 2, 2, 3, NAGA_SNAP_DRAGON  )
				CampaignAttackerEx(1, 1, 2, NAGA_TURTLE);//call CampaignAttackerEx( 1, 1, 2, NAGA_TURTLE       )
				SuicideOnPlayerEx(M6,M6,M5,user);//call SuicideOnPlayerEx(M6,M6,M5,user)
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(5, 5, 7, NAGA_COUATL);//call CampaignAttackerEx( 5, 5, 7, NAGA_COUATL   )
				SuicideOnPlayerEx(M6,M6,M5,user);//call SuicideOnPlayerEx(M6,M6,M5,user)
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(2, 2, 3, NAGA_SIREN);//call CampaignAttackerEx( 2, 2, 3, NAGA_SIREN        )
				CampaignAttackerEx(3, 3, 5, NAGA_MYRMIDON);//call CampaignAttackerEx( 3, 3, 5, NAGA_MYRMIDON     )
				CampaignAttackerEx(1, 1, 2, NAGA_TURTLE);//call CampaignAttackerEx( 1, 1, 2, NAGA_TURTLE       )
				SuicideOnPlayerEx(M6,M6,M5,user);//call SuicideOnPlayerEx(M6,M6,M5,user)
			}//endloop
		}//endfunction

	
	}
}

