using System;
using System.Collections.Generic;

namespace Jass {

	public class N05x09Ai {

		//
		//
		//
		//
		//
		//
		private void after_quest() {//function after_quest takes nothing returns nothing
			//
			//
			//
			SetBuildUpgrEx(2,2,2, UPG_SIREN);//call SetBuildUpgrEx( 2,2,2, UPG_SIREN			)
			SetBuildUpgrEx(1,1,1, UPG_NAGA_ENSNARE);//call SetBuildUpgrEx( 1,1,1, UPG_NAGA_ENSNARE	)
			SetBuildUpgrEx(1,1,2, UPG_NAGA_ATTACK);//call SetBuildUpgrEx( 1,1,2, UPG_NAGA_ATTACK		)
			SetBuildUpgrEx(1,1,2, UPG_NAGA_ARMOR);//call SetBuildUpgrEx( 1,1,2, UPG_NAGA_ARMOR		)
			SetBuildUpgrEx(1,1,1, UPG_NAGA_ABOLISH);//call SetBuildUpgrEx( 1,1,1, UPG_NAGA_ABOLISH	)
			while (true) {//loop
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(2, 2, 4, NAGA_MYRMIDON);//call CampaignAttackerEx( 2, 2, 4, NAGA_MYRMIDON	)
				CampaignAttackerEx(0, 0, 1, NAGA_VASHJ);//call CampaignAttackerEx( 0, 0, 1, NAGA_VASHJ	)
				SuicideOnPlayerEx(M7,M7,M6,user);//call SuicideOnPlayerEx(M7,M7,M6,user)
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(2, 2, 5, NAGA_MYRMIDON);//call CampaignAttackerEx( 2, 2, 5, NAGA_MYRMIDON	)
				CampaignAttackerEx(1, 1, 4, NAGA_SIREN);//call CampaignAttackerEx( 1, 1, 4, NAGA_SIREN    )
				CampaignAttackerEx(0, 0, 1, NAGA_VASHJ);//call CampaignAttackerEx( 0, 0, 1, NAGA_VASHJ	)
				SuicideOnPlayerEx(M6,M6,M4,user);//call SuicideOnPlayerEx(M6,M6,M4,user)
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(2, 2, 5, NAGA_MYRMIDON);//call CampaignAttackerEx( 2, 2, 5, NAGA_MYRMIDON	)
				CampaignAttackerEx(1, 1, 4, NAGA_SIREN);//call CampaignAttackerEx( 1, 1, 4, NAGA_SIREN    )
				CampaignAttackerEx(1, 1, 1, NAGA_VASHJ);//call CampaignAttackerEx( 1, 1, 1, NAGA_VASHJ	)
				SuicideOnPlayerEx(M6,M6,M4,user);//call SuicideOnPlayerEx(M6,M6,M4,user)
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(3, 3, 5, NAGA_MYRMIDON);//call CampaignAttackerEx( 3, 3, 5, NAGA_MYRMIDON	)
				CampaignAttackerEx(1, 1, 4, NAGA_SIREN);//call CampaignAttackerEx( 1, 1, 4, NAGA_SIREN    )
				CampaignAttackerEx(0, 0, 1, NAGA_VASHJ);//call CampaignAttackerEx( 0, 0, 1, NAGA_VASHJ	)
				SuicideOnPlayerEx(M6,M6,M4,user);//call SuicideOnPlayerEx(M6,M6,M4,user)
			}//endloop
		}//endfunction
		//
		//
		//
		private void test_quest() {//function test_quest takes nothing returns nothing
			if (CommandsWaiting() > 0) {//if CommandsWaiting() > 0 then
				after_quest();//call after_quest()
			}//endif
		}//endfunction
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(NAGA_CORAL,null);//call CampaignAI(NAGA_CORAL,null)
			SetAmphibious();//call SetAmphibious()
			SetBuildUnitEx(1, 1, 1, NAGA_SLAVE);//call SetBuildUnitEx( 1, 1, 1, NAGA_SLAVE )
			SetBuildUpgrEx(1,1,2, UPG_SIREN);//call SetBuildUpgrEx( 1,1,2, UPG_SIREN			)
			SetBuildUpgrEx(0,0,1, UPG_NAGA_ENSNARE);//call SetBuildUpgrEx( 0,0,1, UPG_NAGA_ENSNARE	)
			SetBuildUpgrEx(0,0,1, UPG_NAGA_ATTACK);//call SetBuildUpgrEx( 0,0,1, UPG_NAGA_ATTACK		)
			SetBuildUpgrEx(0,0,1, UPG_NAGA_ARMOR);//call SetBuildUpgrEx( 0,0,1, UPG_NAGA_ARMOR		)
			SetBuildUpgrEx(0,0,1, UPG_NAGA_ABOLISH);//call SetBuildUpgrEx( 0,0,1, UPG_NAGA_ABOLISH	)
			CampaignDefenderEx(0, 1, 2, NAGA_MYRMIDON);//call CampaignDefenderEx( 0, 1, 2, NAGA_MYRMIDON )
			CampaignDefenderEx(1, 1, 1, NAGA_SIREN);//call CampaignDefenderEx( 1, 1, 1, NAGA_SIREN    )
			CampaignDefenderEx(0, 0, 2, NAGA_COUATL);//call CampaignDefenderEx( 0, 0, 2, NAGA_COUATL	)
			CampaignDefenderEx(0, 0, 1, NAGA_ROYAL);//call CampaignDefenderEx( 0, 0, 1, NAGA_ROYAL    )
			CampaignDefenderEx(1, 1, 1, NAGA_VASHJ);//call CampaignDefenderEx( 1, 1, 1, NAGA_VASHJ    )
			while (true) {//loop
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(5, 5, 3, NAGA_REAVER);//call CampaignAttackerEx( 5, 5, 3, NAGA_REAVER	)
				CampaignAttackerEx(0, 0, 1, NAGA_MYRMIDON);//call CampaignAttackerEx( 0, 0, 1, NAGA_MYRMIDON	)
				CampaignAttackerEx(1, 1, 3, NAGA_SIREN);//call CampaignAttackerEx( 1, 1, 3, NAGA_SIREN    )
				SuicideOnPlayerEx(M2,M2,M1,user);//call SuicideOnPlayerEx(M2,M2,M1,user)
				test_quest();//call test_quest()
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(5, 5, 5, NAGA_REAVER);//call CampaignAttackerEx( 5, 5, 5, NAGA_REAVER   )
				CampaignAttackerEx(0, 0, 2, NAGA_SIREN);//call CampaignAttackerEx( 0, 0, 2, NAGA_SIREN    )
				CampaignAttackerEx(1, 1, 1, NAGA_VASHJ);//call CampaignAttackerEx( 1, 1, 1, NAGA_VASHJ	)
				SuicideOnPlayerEx(M4,M4,M3,user);//call SuicideOnPlayerEx(M4,M4,M3,user)
				test_quest();//call test_quest()
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(4, 4, 6, NAGA_REAVER);//call CampaignAttackerEx( 4, 4, 6, NAGA_REAVER	)
				CampaignAttackerEx(1, 1, 3, NAGA_SIREN);//call CampaignAttackerEx( 1, 1, 3, NAGA_SIREN    )
				CampaignAttackerEx(0, 0, 1, NAGA_VASHJ);//call CampaignAttackerEx( 0, 0, 1, NAGA_VASHJ	)
				SuicideOnPlayerEx(M4,M4,M3,user);//call SuicideOnPlayerEx(M4,M4,M3,user)
				test_quest();//call test_quest()
			}//endloop
		}//endfunction

	
	}
}

