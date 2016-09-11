using System;
using System.Collections.Generic;

namespace Jass {

	public class N07x03Ai {

		//
		//
		//
		public static player targ = PlayerEx(1);//player targ = PlayerEx(1)
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(NAGA_CORAL,null);//call CampaignAI(NAGA_CORAL,null)
			SetAmphibious();//call SetAmphibious()
			SetReplacements(1,1,3);//call SetReplacements(1,1,3)
			SetRandomPaths(false);//call SetRandomPaths(false)
			SetCaptainHome(DEFENSE_CAPTAIN,-7872,7753);//call SetCaptainHome(DEFENSE_CAPTAIN,-7872,7753)
			SetCaptainHome(ATTACK_CAPTAIN,-3413,8287);//call SetCaptainHome(ATTACK_CAPTAIN,-3413,8287)
			CampaignDefenderEx(1, 1, 2, NAGA_MYRMIDON);//call CampaignDefenderEx( 1, 1, 2, NAGA_MYRMIDON )
			CampaignDefenderEx(0, 0, 1, NAGA_SIREN);//call CampaignDefenderEx( 0, 0, 1, NAGA_SIREN    )
			CampaignDefenderEx(0, 0, 2, NAGA_COUATL);//call CampaignDefenderEx( 0, 0, 2, NAGA_COUATL   )
			SetBuildUpgrEx(1,1,2, UPG_SIREN);//call SetBuildUpgrEx( 1,1,2, UPG_SIREN           )
			SetBuildUpgrEx(1,1,1, UPG_NAGA_ENSNARE);//call SetBuildUpgrEx( 1,1,1, UPG_NAGA_ENSNARE    )
			SetBuildUpgrEx(1,1,1, UPG_NAGA_ABOLISH);//call SetBuildUpgrEx( 1,1,1, UPG_NAGA_ABOLISH    )
			SetBuildUpgrEx(1,1,1, UPG_NAGA_ATTACK);//call SetBuildUpgrEx( 1,1,1, UPG_NAGA_ATTACK     )
			SetBuildUpgrEx(1,1,1, UPG_NAGA_ARMOR);//call SetBuildUpgrEx( 1,1,1, UPG_NAGA_ARMOR      )
			WaitForSignal();//call WaitForSignal()
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(5, 5, 6, NAGA_REAVER);//call CampaignAttackerEx( 5, 5, 6, NAGA_REAVER       )
			SuicideOnPlayer(M5,targ);//call SuicideOnPlayer(M5,targ)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(3, 3, 4, NAGA_COUATL);//call CampaignAttackerEx( 3, 3, 4, NAGA_COUATL       )
			SuicideOnPlayer(M5,targ);//call SuicideOnPlayer(M5,targ)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(1, 1, 2, NAGA_MYRMIDON);//call CampaignAttackerEx( 1, 1, 2, NAGA_MYRMIDON     )
			CampaignAttackerEx(2, 2, 3, NAGA_SIREN);//call CampaignAttackerEx( 2, 2, 3, NAGA_SIREN        )
			SuicideOnPlayer(M5,targ);//call SuicideOnPlayer(M5,targ)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(3, 3, 4, NAGA_REAVER);//call CampaignAttackerEx( 3, 3, 4, NAGA_REAVER       )
			CampaignAttackerEx(3, 3, 4, NAGA_DRAGON);//call CampaignAttackerEx( 3, 3, 4, NAGA_DRAGON       )
			CampaignAttackerEx(0, 0, 5, NAGA_COUATL);//call CampaignAttackerEx( 0, 0, 5, NAGA_COUATL      )
			SuicideOnPlayer(M5,targ);//call SuicideOnPlayer(M5,targ)
			while (true) {//loop
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(1, 1, 3, NAGA_MYRMIDON);//call CampaignAttackerEx( 1, 1, 3, NAGA_MYRMIDON     )
				CampaignAttackerEx(2, 2, 4, NAGA_SIREN);//call CampaignAttackerEx( 2, 2, 4, NAGA_SIREN        )
				CampaignAttackerEx(0, 0, 5, NAGA_COUATL);//call CampaignAttackerEx( 0, 0, 5, NAGA_COUATL      )
				SuicideOnPlayer(M5,targ);//call SuicideOnPlayer(M5,targ)
			}//endloop
		}//endfunction

	
	}
}

