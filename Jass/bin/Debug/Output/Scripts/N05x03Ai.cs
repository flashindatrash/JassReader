using System;
using System.Collections.Generic;

namespace Jass {

	public class N05x03Ai {

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
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_NAGA_ATTACK);//call SetBuildUpgrEx( 0,0,1, UPG_NAGA_ATTACK		)
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_NAGA_ARMOR);//call SetBuildUpgrEx( 0,0,1, UPG_NAGA_ARMOR		)
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_NAGA_ABOLISH);//call SetBuildUpgrEx( 0,0,1, UPG_NAGA_ABOLISH	)
			CampaignDefenderEx(1, 1, 2, CommonAi.NAGA_MYRMIDON);//call CampaignDefenderEx( 1, 1, 2, NAGA_MYRMIDON		)
			CampaignDefenderEx(1, 1, 2, CommonAi.NAGA_SIREN);//call CampaignDefenderEx( 1, 1, 2, NAGA_SIREN        )
			CampaignDefenderEx(1, 1, 2, CommonAi.NAGA_REAVER);//call CampaignDefenderEx( 1, 1, 2, NAGA_REAVER       )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(4, 4, 6, CommonAi.NAGA_REAVER);//call CampaignAttackerEx( 4, 4, 6, NAGA_REAVER		)
			CampaignAttackerEx(1, 1, 2, CommonAi.NAGA_MYRMIDON);//call CampaignAttackerEx( 1, 1, 2, NAGA_MYRMIDON     )
			SuicideOnPlayerEx(30, 30, 30, U08_tealAi.user);//call SuicideOnPlayerEx(30,30,30,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(4, 4, 6, CommonAi.NAGA_REAVER);//call CampaignAttackerEx( 4, 4, 6, NAGA_REAVER	)
			CampaignAttackerEx(1, 1, 2, CommonAi.NAGA_MYRMIDON);//call CampaignAttackerEx( 1, 1, 2, NAGA_MYRMIDON )
			SuicideOnPlayerEx(CommonAi.M4, CommonAi.M4, CommonAi.M3, U08_tealAi.user);//call SuicideOnPlayerEx(M4,M4,M3,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(4, 4, 6, CommonAi.NAGA_REAVER);//call CampaignAttackerEx( 4, 4, 6, NAGA_REAVER	)
			CampaignAttackerEx(2, 2, 4, CommonAi.NAGA_DRAGON);//call CampaignAttackerEx( 2, 2, 4, NAGA_DRAGON   )
			SuicideOnPlayerEx(CommonAi.M4, CommonAi.M4, CommonAi.M3, U08_tealAi.user);//call SuicideOnPlayerEx(M4,M4,M3,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(1, 1, 4, CommonAi.NAGA_MYRMIDON);//call CampaignAttackerEx( 1, 1, 4, NAGA_MYRMIDON	)
			CampaignAttackerEx(2, 2, 3, CommonAi.NAGA_DRAGON);//call CampaignAttackerEx( 2, 2, 3, NAGA_DRAGON   )
			SuicideOnPlayerEx(CommonAi.M4, CommonAi.M4, CommonAi.M3, U08_tealAi.user);//call SuicideOnPlayerEx(M4,M4,M3,user)
		}//endfunction

	
	}
}

