using System;
using System.Collections.Generic;

namespace Jass {

	public class N07x04Ai {

		//
		//
		//
		public static player targ = PlayerEx(2);//player targ   = PlayerEx(2)
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(CommonAi.NAGA_CORAL, null);//call CampaignAI(NAGA_CORAL,null)
			SetAmphibious();//call SetAmphibious()
			SetReplacements(2, 2, 4);//call SetReplacements(2,2,4)
			SetBuildUnitEx(5, 5, 5, CommonAi.NAGA_SLAVE);//call SetBuildUnitEx( 5, 5, 5, NAGA_SLAVE    )
			CampaignDefenderEx(0, 0, 1, CommonAi.ILLIDAN);//call CampaignDefenderEx( 0, 0, 1, ILLIDAN       )
			CampaignDefenderEx(0, 0, 2, CommonAi.NAGA_REAVER);//call CampaignDefenderEx( 0, 0, 2, NAGA_REAVER   )
			CampaignDefenderEx(1, 1, 2, CommonAi.NAGA_MYRMIDON);//call CampaignDefenderEx( 1, 1, 2, NAGA_MYRMIDON )
			CampaignDefenderEx(1, 1, 1, CommonAi.NAGA_SIREN);//call CampaignDefenderEx( 1, 1, 1, NAGA_SIREN    )
			CampaignDefenderEx(1, 1, 2, CommonAi.NAGA_COUATL);//call CampaignDefenderEx( 1, 1, 2, NAGA_COUATL   )
			SetBuildUpgrEx(1, 1, 2, CommonAi.UPG_SIREN);//call SetBuildUpgrEx( 1,1,2, UPG_SIREN           )
			SetBuildUpgrEx(1, 1, 1, CommonAi.UPG_NAGA_ENSNARE);//call SetBuildUpgrEx( 1,1,1, UPG_NAGA_ENSNARE    )
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_NAGA_ATTACK);//call SetBuildUpgrEx( 0,0,1, UPG_NAGA_ATTACK     )
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_NAGA_ARMOR);//call SetBuildUpgrEx( 0,0,1, UPG_NAGA_ARMOR      )
			SetBuildUpgrEx(1, 1, 1, CommonAi.UPG_NAGA_ABOLISH);//call SetBuildUpgrEx( 1,1,1, UPG_NAGA_ABOLISH    )
			WaitForSignal();//call WaitForSignal()
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(6, 6, 8, CommonAi.NAGA_REAVER);//call CampaignAttackerEx( 6, 6, 8, NAGA_REAVER       )
			CampaignAttackerEx(1, 1, 2, CommonAi.NAGA_MYRMIDON);//call CampaignAttackerEx( 1, 1, 2, NAGA_MYRMIDON     )
			CampaignAttackerEx(0, 0, 1, CommonAi.NAGA_VASHJ);//call CampaignAttackerEx( 0, 0, 1, NAGA_VASHJ        )
			SuicideOnPlayerEx(CommonAi.M4, CommonAi.M4, CommonAi.M1, N07x04Ai.targ);//call SuicideOnPlayerEx(M4,M4,M1,targ)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(3, 3, 5, CommonAi.NAGA_REAVER);//call CampaignAttackerEx( 3, 3, 5, NAGA_REAVER       )
			CampaignAttackerEx(1, 1, 2, CommonAi.NAGA_TURTLE);//call CampaignAttackerEx( 1, 1, 2, NAGA_TURTLE       )
			CampaignAttackerEx(1, 1, 1, CommonAi.ILLIDAN);//call CampaignAttackerEx( 1, 1, 1, ILLIDAN           )
			SuicideOnPlayerEx(CommonAi.M5, CommonAi.M5, CommonAi.M3, N07x04Ai.targ);//call SuicideOnPlayerEx(M5,M5,M3,targ)
			SetBuildUpgrEx(1, 1, 2, CommonAi.UPG_NAGA_ATTACK);//call SetBuildUpgrEx( 1,1,2, UPG_NAGA_ATTACK     )
			SetBuildUpgrEx(1, 1, 2, CommonAi.UPG_NAGA_ARMOR);//call SetBuildUpgrEx( 1,1,2, UPG_NAGA_ARMOR      )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(3, 3, 5, CommonAi.NAGA_MYRMIDON);//call CampaignAttackerEx( 3, 3, 5, NAGA_MYRMIDON     )
			CampaignAttackerEx(1, 1, 2, CommonAi.NAGA_SIREN);//call CampaignAttackerEx( 1, 1, 2, NAGA_SIREN        )
			CampaignAttackerEx(1, 1, 3, CommonAi.NAGA_COUATL);//call CampaignAttackerEx( 1, 1, 3, NAGA_COUATL       )
			CampaignAttackerEx(0, 0, 1, CommonAi.NAGA_VASHJ);//call CampaignAttackerEx( 0, 0, 1, NAGA_VASHJ        )
			SuicideOnPlayerEx(CommonAi.M5, CommonAi.M5, CommonAi.M3, N07x04Ai.targ);//call SuicideOnPlayerEx(M5,M5,M3,targ)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2, 2, 4, CommonAi.NAGA_MYRMIDON);//call CampaignAttackerEx( 2, 2, 4, NAGA_MYRMIDON     )
			CampaignAttackerEx(4, 4, 6, CommonAi.NAGA_DRAGON);//call CampaignAttackerEx( 4, 4, 6, NAGA_DRAGON       )
			CampaignAttackerEx(1, 1, 1, CommonAi.ILLIDAN);//call CampaignAttackerEx( 1, 1, 1, ILLIDAN           )
			SuicideOnPlayerEx(CommonAi.M5, CommonAi.M5, CommonAi.M3, N07x04Ai.targ);//call SuicideOnPlayerEx(M5,M5,M3,targ)
			SetBuildUpgrEx(2, 2, 3, CommonAi.UPG_NAGA_ATTACK);//call SetBuildUpgrEx( 2,2,3, UPG_NAGA_ATTACK     )
			SetBuildUpgrEx(2, 2, 3, CommonAi.UPG_NAGA_ARMOR);//call SetBuildUpgrEx( 2,2,3, UPG_NAGA_ARMOR      )
			//
			while (true) {//loop
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(1, 1, 3, CommonAi.NAGA_TURTLE);//call CampaignAttackerEx( 1, 1, 3, NAGA_TURTLE       )
				CampaignAttackerEx(2, 2, 5, CommonAi.NAGA_COUATL);//call CampaignAttackerEx( 2, 2, 5, NAGA_COUATL       )
				CampaignAttackerEx(4, 4, 7, CommonAi.NAGA_SIREN);//call CampaignAttackerEx( 4, 4, 7, NAGA_SIREN        )
				CampaignAttackerEx(1, 1, 1, CommonAi.NAGA_VASHJ);//call CampaignAttackerEx( 1, 1, 1, NAGA_VASHJ        )
				SuicideOnPlayerEx(CommonAi.M5, CommonAi.M5, CommonAi.M3, N07x04Ai.targ);//call SuicideOnPlayerEx(M5,M5,M3,targ)
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(2, 2, 4, CommonAi.NAGA_MYRMIDON);//call CampaignAttackerEx( 2, 2, 4, NAGA_MYRMIDON     )
				CampaignAttackerEx(2, 2, 4, CommonAi.NAGA_DRAGON);//call CampaignAttackerEx( 2, 2, 4, NAGA_DRAGON       )
				CampaignAttackerEx(1, 1, 3, CommonAi.NAGA_TURTLE);//call CampaignAttackerEx( 1, 1, 3, NAGA_TURTLE       )
				CampaignAttackerEx(1, 1, 1, CommonAi.ILLIDAN);//call CampaignAttackerEx( 1, 1, 1, ILLIDAN           )
				SuicideOnPlayerEx(CommonAi.M5, CommonAi.M5, CommonAi.M3, N07x04Ai.targ);//call SuicideOnPlayerEx(M5,M5,M3,targ)
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(1, 1, 8, CommonAi.NAGA_COUATL);//call CampaignAttackerEx( 1, 1, 8, NAGA_COUATL      )
				SuicideOnPlayerEx(CommonAi.M5, CommonAi.M5, CommonAi.M3, N07x04Ai.targ);//call SuicideOnPlayerEx(M5,M5,M3,targ)
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(1, 1, 3, CommonAi.NAGA_TURTLE);//call CampaignAttackerEx( 1, 1, 3, NAGA_TURTLE       )
				CampaignAttackerEx(2, 2, 5, CommonAi.NAGA_MYRMIDON);//call CampaignAttackerEx( 2, 2, 5, NAGA_MYRMIDON     )
				CampaignAttackerEx(3, 3, 5, CommonAi.NAGA_SIREN);//call CampaignAttackerEx( 3, 3, 5, NAGA_SIREN        )
				CampaignAttackerEx(1, 1, 1, CommonAi.ILLIDAN);//call CampaignAttackerEx( 1, 1, 1, ILLIDAN           )
				SuicideOnPlayerEx(CommonAi.M5, CommonAi.M5, CommonAi.M3, N07x04Ai.targ);//call SuicideOnPlayerEx(M5,M5,M3,targ)
			}//endloop
		}//endfunction

	
	}
}

