using System;
using System.Collections.Generic;

namespace Jass {

	public class U08x03Ai {

		//
		//
		//
		public static player user = PlayerEx(1);//player user = PlayerEx(1)
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(CommonAi.NAGA_CORAL, null);//call CampaignAI(NAGA_CORAL,null)
			SetReplacements(1, 1, 2);//call SetReplacements(1,1,2)
			SetAmphibious();//call SetAmphibious()
			SetBuildUnitEx(1, 1, 1, CommonAi.NAGA_SLAVE);//call SetBuildUnitEx( 1, 1, 1, NAGA_SLAVE    )
			SetBuildUnitEx(0, 0, 1, CommonAi.NAGA_TEMPLE);//call SetBuildUnitEx( 0, 0, 1, NAGA_TEMPLE   )
			SetBuildUnitEx(0, 0, 1, CommonAi.NAGA_SHRINE);//call SetBuildUnitEx( 0, 0, 1, NAGA_SHRINE   )
			SetBuildUnitEx(0, 0, 1, CommonAi.NAGA_SPAWNING);//call SetBuildUnitEx( 0, 0, 1, NAGA_SPAWNING )
			SetBuildUnitEx(0, 0, 1, CommonAi.NAGA_ALTAR);//call SetBuildUnitEx( 0, 0, 1, NAGA_ALTAR    )
			SetBuildUnitEx(5, 5, 5, CommonAi.NAGA_SLAVE);//call SetBuildUnitEx( 5, 5, 5, NAGA_SLAVE    )
			SetBuildUnitEx(0, 0, 3, CommonAi.NAGA_GUARDIAN);//call SetBuildUnitEx( 0, 0, 3, NAGA_GUARDIAN )
			CampaignDefenderEx(1, 1, 0, CommonAi.NAGA_MYRMIDON);//call CampaignDefenderEx( 1,1,0, NAGA_MYRMIDON   )
			CampaignDefenderEx(0, 0, 1, CommonAi.NAGA_ROYAL);//call CampaignDefenderEx( 0,0,1, NAGA_ROYAL      )
			CampaignDefenderEx(1, 1, 1, CommonAi.NAGA_SIREN);//call CampaignDefenderEx( 1,1,1, NAGA_SIREN      )
			CampaignDefenderEx(0, 0, 1, CommonAi.NAGA_VASHJ);//call CampaignDefenderEx( 0,0,1, NAGA_VASHJ      )
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_SIREN);//call SetBuildUpgrEx( 0,0,1, UPG_SIREN           )
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_NAGA_ATTACK);//call SetBuildUpgrEx( 0,0,1, UPG_NAGA_ATTACK     )
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_NAGA_ARMOR);//call SetBuildUpgrEx( 0,0,1, UPG_NAGA_ARMOR      )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(4, 4, 6, CommonAi.NAGA_REAVER);//call CampaignAttackerEx( 4, 4, 6, NAGA_REAVER       )
			CampaignAttackerEx(0, 0, 1, CommonAi.NAGA_MYRMIDON);//call CampaignAttackerEx( 0, 0, 1, NAGA_MYRMIDON     )
			CampaignAttackerEx(0, 0, 1, CommonAi.NAGA_TURTLE);//call CampaignAttackerEx( 0, 0, 1, NAGA_TURTLE       )
			SuicideOnPlayerEx(CommonAi.M6, CommonAi.M6, CommonAi.M5, U08_tealAi.user);//call SuicideOnPlayerEx(M6,M6,M5,user)
			SetBuildUpgrEx(1, 1, 1, CommonAi.UPG_NAGA_ENSNARE);//call SetBuildUpgrEx( 1,1,1, UPG_NAGA_ENSNARE    )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2, 2, 4, CommonAi.NAGA_MYRMIDON);//call CampaignAttackerEx( 2, 2, 4, NAGA_MYRMIDON     )
			CampaignAttackerEx(2, 2, 4, CommonAi.NAGA_SNAP_DRAGON);//call CampaignAttackerEx( 2, 2, 4, NAGA_SNAP_DRAGON  )
			SuicideOnPlayerEx(CommonAi.M6, CommonAi.M6, CommonAi.M8, U08_tealAi.user);//call SuicideOnPlayerEx(M6,M6,M8,user)
			SetBuildUpgrEx(0, 0, 2, CommonAi.UPG_SIREN);//call SetBuildUpgrEx( 0,0,2, UPG_SIREN           )
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_NAGA_ABOLISH);//call SetBuildUpgrEx( 0,0,1, UPG_NAGA_ABOLISH    )
			SetBuildUpgrEx(0, 0, 2, CommonAi.UPG_NAGA_ATTACK);//call SetBuildUpgrEx( 0,0,2, UPG_NAGA_ATTACK     )
			SetBuildUpgrEx(0, 0, 2, CommonAi.UPG_NAGA_ARMOR);//call SetBuildUpgrEx( 0,0,2, UPG_NAGA_ARMOR      )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(4, 4, 4, CommonAi.NAGA_REAVER);//call CampaignAttackerEx( 4, 4, 4, NAGA_REAVER       )
			CampaignAttackerEx(0, 0, 2, CommonAi.NAGA_MYRMIDON);//call CampaignAttackerEx( 0, 0, 2, NAGA_MYRMIDON     )
			CampaignAttackerEx(2, 2, 2, CommonAi.NAGA_SNAP_DRAGON);//call CampaignAttackerEx( 2, 2, 2, NAGA_SNAP_DRAGON  )
			CampaignAttackerEx(1, 1, 1, CommonAi.NAGA_VASHJ);//call CampaignAttackerEx( 1, 1, 1, NAGA_VASHJ        )
			SuicideOnPlayerEx(CommonAi.M10, CommonAi.M10, CommonAi.M12, U08_tealAi.user);//call SuicideOnPlayerEx(M10,M10,M12,user)
			SetBuildUpgrEx(0, 0, 3, CommonAi.UPG_NAGA_ATTACK);//call SetBuildUpgrEx( 0,0,3, UPG_NAGA_ATTACK     )
			SetBuildUpgrEx(0, 0, 3, CommonAi.UPG_NAGA_ARMOR);//call SetBuildUpgrEx( 0,0,3, UPG_NAGA_ARMOR      )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(4, 4, 2, CommonAi.NAGA_MYRMIDON);//call CampaignAttackerEx( 4, 4, 2, NAGA_MYRMIDON     )
			CampaignAttackerEx(2, 2, 3, CommonAi.NAGA_SNAP_DRAGON);//call CampaignAttackerEx( 2, 2, 3, NAGA_SNAP_DRAGON  )
			CampaignAttackerEx(1, 1, 0, CommonAi.NAGA_VASHJ);//call CampaignAttackerEx( 1, 1, 0, NAGA_VASHJ        )
			SuicideOnPlayerEx(CommonAi.M8, CommonAi.M8, CommonAi.M7, U08_tealAi.user);//call SuicideOnPlayerEx(M8,M8,M7,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(5, 5, 7, CommonAi.NAGA_COUATL);//call CampaignAttackerEx( 5, 5, 7, NAGA_COUATL   )
			SuicideOnPlayerEx(CommonAi.M7, CommonAi.M7, CommonAi.M6, U08_tealAi.user);//call SuicideOnPlayerEx(M7,M7,M6,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(4, 4, 5, CommonAi.NAGA_SNAP_DRAGON);//call CampaignAttackerEx( 4, 4, 5, NAGA_SNAP_DRAGON  )
			CampaignAttackerEx(1, 1, 3, CommonAi.NAGA_SIREN);//call CampaignAttackerEx( 1, 1, 3, NAGA_SIREN        )
			CampaignAttackerEx(1, 1, 2, CommonAi.NAGA_TURTLE);//call CampaignAttackerEx( 1, 1, 2, NAGA_TURTLE       )
			CampaignAttackerEx(0, 0, 1, CommonAi.NAGA_VASHJ);//call CampaignAttackerEx( 0, 0, 1, NAGA_VASHJ        )
			SuicideOnPlayerEx(CommonAi.M8, CommonAi.M8, CommonAi.M13, U08_tealAi.user);//call SuicideOnPlayerEx(M8,M8,M13,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(1, 1, 2, CommonAi.NAGA_ROYAL);//call CampaignAttackerEx( 1, 1, 2, NAGA_ROYAL        )
			CampaignAttackerEx(1, 1, 2, CommonAi.NAGA_SIREN);//call CampaignAttackerEx( 1, 1, 2, NAGA_SIREN        )
			CampaignAttackerEx(2, 2, 3, CommonAi.NAGA_SNAP_DRAGON);//call CampaignAttackerEx( 2, 2, 3, NAGA_SNAP_DRAGON  )
			CampaignAttackerEx(1, 1, 2, CommonAi.NAGA_TURTLE);//call CampaignAttackerEx( 1, 1, 2, NAGA_TURTLE       )
			SuicideOnPlayerEx(CommonAi.M8, CommonAi.M8, CommonAi.M7, U08_tealAi.user);//call SuicideOnPlayerEx(M8,M8,M7,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(5, 5, 8, CommonAi.NAGA_COUATL);//call CampaignAttackerEx( 5, 5, 8, NAGA_COUATL   )
			SuicideOnPlayerEx(CommonAi.M11, CommonAi.M11, CommonAi.M6, U08_tealAi.user);//call SuicideOnPlayerEx(M11,M11,M6,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(4, 4, 2, CommonAi.NAGA_MYRMIDON);//call CampaignAttackerEx( 4, 4, 2, NAGA_MYRMIDON     )
			CampaignAttackerEx(2, 2, 3, CommonAi.NAGA_SNAP_DRAGON);//call CampaignAttackerEx( 2, 2, 3, NAGA_SNAP_DRAGON  )
			CampaignAttackerEx(1, 1, 1, CommonAi.NAGA_VASHJ);//call CampaignAttackerEx( 1, 1, 1, NAGA_VASHJ        )
			SuicideOnPlayerEx(CommonAi.M8, CommonAi.M8, CommonAi.M13, U08_tealAi.user);//call SuicideOnPlayerEx(M8,M8,M13,user)
			while (true) {//loop
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(5, 5, 9, CommonAi.NAGA_COUATL);//call CampaignAttackerEx( 5, 5, 9, NAGA_COUATL   )
				SuicideOnPlayerEx(CommonAi.M8, CommonAi.M8, CommonAi.M7, U08_tealAi.user);//call SuicideOnPlayerEx(M8,M8,M7,user)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(1, 1, 2, CommonAi.NAGA_ROYAL);//call CampaignAttackerEx( 1, 1, 2, NAGA_ROYAL        )
				CampaignAttackerEx(1, 1, 2, CommonAi.NAGA_SIREN);//call CampaignAttackerEx( 1, 1, 2, NAGA_SIREN        )
				CampaignAttackerEx(2, 2, 3, CommonAi.NAGA_SNAP_DRAGON);//call CampaignAttackerEx( 2, 2, 3, NAGA_SNAP_DRAGON  )
				CampaignAttackerEx(1, 1, 2, CommonAi.NAGA_TURTLE);//call CampaignAttackerEx( 1, 1, 2, NAGA_TURTLE       )
				SuicideOnPlayerEx(CommonAi.M8, CommonAi.M8, CommonAi.M6, U08_tealAi.user);//call SuicideOnPlayerEx(M8,M8,M6,user)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(0, 0, 2, CommonAi.NAGA_MYRMIDON);//call CampaignAttackerEx( 0, 0, 2, NAGA_MYRMIDON     )
				CampaignAttackerEx(4, 4, 4, CommonAi.NAGA_SNAP_DRAGON);//call CampaignAttackerEx( 4, 4, 4, NAGA_SNAP_DRAGON  )
				CampaignAttackerEx(1, 1, 3, CommonAi.NAGA_SIREN);//call CampaignAttackerEx( 1, 1, 3, NAGA_SIREN        )
				CampaignAttackerEx(1, 1, 2, CommonAi.NAGA_TURTLE);//call CampaignAttackerEx( 1, 1, 2, NAGA_TURTLE       )
				CampaignAttackerEx(1, 1, 1, CommonAi.NAGA_VASHJ);//call CampaignAttackerEx( 1, 1, 1, NAGA_VASHJ        )
				SuicideOnPlayerEx(CommonAi.M8, CommonAi.M8, CommonAi.M13, U08_tealAi.user);//call SuicideOnPlayerEx(M8,M8,M13,user)
			}//endloop
		}//endfunction

	
	}
}

