using System;
using System.Collections.Generic;

namespace Jass {

	public class N05x04Ai {

		//
		//
		//
		public static player user = PlayerEx(2);//player user = PlayerEx(2)
		private void main() {//function main takes nothing returns nothing
			CampaignAI(CommonAi.NAGA_CORAL, null);//call CampaignAI(NAGA_CORAL,null)
			SetAmphibious();//call SetAmphibious()
			SetBuildUnitEx(1, 1, 1, CommonAi.NAGA_SLAVE);//call SetBuildUnitEx( 1, 1, 1, NAGA_SLAVE )
			SetBuildUpgrEx(1, 1, 2, CommonAi.UPG_SIREN);//call SetBuildUpgrEx( 1,1,2, UPG_SIREN			)
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_NAGA_ENSNARE);//call SetBuildUpgrEx( 0,0,1, UPG_NAGA_ENSNARE	)
			SetBuildUpgrEx(0, 0, 2, CommonAi.UPG_NAGA_ATTACK);//call SetBuildUpgrEx( 0,0,2, UPG_NAGA_ATTACK		)
			SetBuildUpgrEx(0, 0, 2, CommonAi.UPG_NAGA_ARMOR);//call SetBuildUpgrEx( 0,0,2, UPG_NAGA_ARMOR		)
			SetBuildUpgrEx(1, 1, 1, CommonAi.UPG_NAGA_ABOLISH);//call SetBuildUpgrEx( 1,1,1, UPG_NAGA_ABOLISH	)
			CampaignDefenderEx(1, 1, 1, CommonAi.NAGA_MYRMIDON);//call CampaignDefenderEx( 1, 1, 1, NAGA_MYRMIDON )
			CampaignDefenderEx(1, 1, 1, CommonAi.NAGA_SIREN);//call CampaignDefenderEx( 1, 1, 1, NAGA_SIREN    )
			CampaignDefenderEx(0, 0, 2, CommonAi.NAGA_COUATL);//call CampaignDefenderEx( 0, 0, 2, NAGA_COUATL	)
			CampaignDefenderEx(0, 0, 1, CommonAi.NAGA_ROYAL);//call CampaignDefenderEx( 0, 0, 1, NAGA_ROYAL    )
			CampaignDefenderEx(0, 0, 1, CommonAi.NAGA_TURTLE);//call CampaignDefenderEx( 0, 0, 1, NAGA_TURTLE   )
			CampaignDefenderEx(1, 1, 1, CommonAi.ILLIDAN);//call CampaignDefenderEx( 1, 1, 1, ILLIDAN		)
			WaitForSignal();//call WaitForSignal()
			while (true) {//loop
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(4, 4, 6, CommonAi.NAGA_REAVER);//call CampaignAttackerEx( 4, 4, 6, NAGA_REAVER	)
				CampaignAttackerEx(1, 1, 1, CommonAi.ILLIDAN);//call CampaignAttackerEx( 1, 1, 1, ILLIDAN		)
				SuicideOnPlayerEx(CommonAi.M2, CommonAi.M2, CommonAi.M1, U08_tealAi.user);//call SuicideOnPlayerEx(M2,M2,M1,user)
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(3, 3, 5, CommonAi.NAGA_COUATL);//call CampaignAttackerEx( 3, 3, 5, NAGA_COUATL	)
				SuicideOnPlayerEx(CommonAi.M6, CommonAi.M6, CommonAi.M4, U08_tealAi.user);//call SuicideOnPlayerEx(M6,M6,M4,user)
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(4, 4, 8, CommonAi.NAGA_REAVER);//call CampaignAttackerEx( 4, 4, 8, NAGA_REAVER	)
				CampaignAttackerEx(1, 1, 2, CommonAi.NAGA_TURTLE);//call CampaignAttackerEx( 1, 1, 2, NAGA_TURTLE	)
				CampaignAttackerEx(1, 1, 1, CommonAi.ILLIDAN);//call CampaignAttackerEx( 1, 1, 1, ILLIDAN		)
				SuicideOnPlayerEx(CommonAi.M6, CommonAi.M6, CommonAi.M4, U08_tealAi.user);//call SuicideOnPlayerEx(M6,M6,M4,user)
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(3, 3, 5, CommonAi.NAGA_COUATL);//call CampaignAttackerEx( 3, 3, 5, NAGA_COUATL	)
				SuicideOnPlayerEx(CommonAi.M6, CommonAi.M6, CommonAi.M4, U08_tealAi.user);//call SuicideOnPlayerEx(M6,M6,M4,user)
			}//endloop
		}//endfunction

	
	}
}

