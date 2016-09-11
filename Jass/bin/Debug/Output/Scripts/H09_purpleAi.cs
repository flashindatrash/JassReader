using System;
using System.Collections.Generic;

namespace Jass {

	public class H09_purpleAi {

		//
		//
		//
		//
		//
		//
		private void after_sword() {//function after_sword takes nothing returns nothing
			//
			//
			//
			SetBuildUpgr(1,     UPG_FIEND_WEB);//call SetBuildUpgr  ( 1,     UPG_FIEND_WEB     )
			SetBuildUpgrEx(1,1,1, UPG_CANNIBALIZE);//call SetBuildUpgrEx( 1,1,1, UPG_CANNIBALIZE   )
			SetBuildUpgrEx(1,1,1, UPG_GHOUL_FRENZY);//call SetBuildUpgrEx( 1,1,1, UPG_GHOUL_FRENZY  )
			SetBuildUpgrEx(0,0,1, UPG_PLAGUE);//call SetBuildUpgrEx( 0,0,1, UPG_PLAGUE        )
			SetBuildUpgrEx(2,2,3, UPG_UNHOLY_STR);//call SetBuildUpgrEx( 2,2,3, UPG_UNHOLY_STR    )
			SetBuildUpgrEx(1,1,3, UPG_UNHOLY_ARMOR);//call SetBuildUpgrEx( 1,1,3, UPG_UNHOLY_ARMOR  )
			SetBuildUpgrEx(2,2,3, UPG_CR_ATTACK);//call SetBuildUpgrEx( 2,2,3, UPG_CR_ATTACK     )
			SetBuildUpgrEx(1,1,3, UPG_CR_ARMOR);//call SetBuildUpgrEx( 1,1,3, UPG_CR_ARMOR      )
			while (true) {//loop
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(2,2,8, GHOUL);//call CampaignAttackerEx( 2,2,8, GHOUL        )
				CampaignAttackerEx(2,2,4, ABOMINATION);//call CampaignAttackerEx( 2,2,4, ABOMINATION  )
				CampaignAttackerEx(1,1,2, MEAT_WAGON);//call CampaignAttackerEx( 1,1,2, MEAT_WAGON   )
				SuicideOnPlayerEx(M10,M10,M8,user);//call SuicideOnPlayerEx(M10,M10,M8,user)
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(2,2,6, ABOMINATION);//call CampaignAttackerEx( 2,2,6, ABOMINATION  )
				CampaignAttackerEx(4,4,6, CRYPT_FIEND);//call CampaignAttackerEx( 4,4,6, CRYPT_FIEND  )
				SuicideOnPlayerEx(M10,M10,M9,user);//call SuicideOnPlayerEx(M10,M10,M9,user)
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(0,2,8, GHOUL);//call CampaignAttackerEx( 0,2,8, GHOUL        )
				CampaignAttackerEx(0,0,4, ABOMINATION);//call CampaignAttackerEx( 0,0,4, ABOMINATION  )
				CampaignAttackerEx(2,2,6, CRYPT_FIEND);//call CampaignAttackerEx( 2,2,6, CRYPT_FIEND  )
				CampaignAttackerEx(3,3,5, MEAT_WAGON);//call CampaignAttackerEx( 3,3,5, MEAT_WAGON   )
				SuicideOnPlayerEx(M10,M10,M8,user);//call SuicideOnPlayerEx(M10,M10,M8,user)
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(4,4,8, ABOMINATION);//call CampaignAttackerEx( 4,4,8, ABOMINATION  )
				CampaignAttackerEx(0,0,2, CRYPT_FIEND);//call CampaignAttackerEx( 0,0,2, CRYPT_FIEND  )
				CampaignAttackerEx(1,1,2, MEAT_WAGON);//call CampaignAttackerEx( 1,1,2, MEAT_WAGON   )
				SuicideOnPlayerEx(M10,M10,M9,user);//call SuicideOnPlayerEx(M10,M10,M9,user)
			}//endloop
		}//endfunction
		//
		//
		//
		private void test_sword() {//function test_sword takes nothing returns nothing
			if (CommandsWaiting() > 0) {//if CommandsWaiting() > 0 then
				after_sword();//call after_sword()
			}//endif
		}//endfunction
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(ZIGGURAT_1,null);//call CampaignAI(ZIGGURAT_1,null)
			SetReplacements(1,1,3);//call SetReplacements(1,1,3)
			SetBuildUnitEx(5,5,5, ACOLYTE);//call SetBuildUnitEx( 5,5,5, ACOLYTE			)
			CampaignDefenderEx(1,1,2, GHOUL);//call CampaignDefenderEx( 1,1,2, GHOUL       )
			CampaignDefenderEx(0,0,1, ABOMINATION);//call CampaignDefenderEx( 0,0,1, ABOMINATION )
			CampaignDefenderEx(1,1,2, CRYPT_FIEND);//call CampaignDefenderEx( 1,1,2, CRYPT_FIEND )
			WaitForSignal();//call WaitForSignal()
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2,2,8,		GHOUL);//call CampaignAttackerEx( 2,2,8,		GHOUL        )
			CampaignAttackerEx(1,1,2,		ABOMINATION);//call CampaignAttackerEx( 1,1,2,		ABOMINATION  )
			SuicideOnPlayerEx(M4,M4,M2,user);//call SuicideOnPlayerEx(M4,M4,M2,user)
			test_sword();//call test_sword()
			SetBuildUpgrEx(0,0,1, UPG_UNHOLY_STR);//call SetBuildUpgrEx( 0,0,1, UPG_UNHOLY_STR    )
			SetBuildUpgrEx(0,0,1, UPG_CANNIBALIZE);//call SetBuildUpgrEx( 0,0,1, UPG_CANNIBALIZE   )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(4,4,10,	GHOUL);//call CampaignAttackerEx( 4,4,10,	GHOUL        )
			CampaignAttackerEx(2,2,4,		CRYPT_FIEND);//call CampaignAttackerEx( 2,2,4,		CRYPT_FIEND  )
			CampaignAttackerEx(0,0,1,		MEAT_WAGON);//call CampaignAttackerEx( 0,0,1,		MEAT_WAGON   )
			SuicideOnPlayerEx(M8,M8,M7,user);//call SuicideOnPlayerEx(M8,M8,M7,user)
			test_sword();//call test_sword()
			SetBuildUpgrEx(0,0,1, UPG_CR_ATTACK);//call SetBuildUpgrEx( 0,0,1, UPG_CR_ATTACK     )
			SetBuildUpgr(1,     UPG_FIEND_WEB);//call SetBuildUpgr  ( 1,     UPG_FIEND_WEB     )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(4,4,12,	GHOUL);//call CampaignAttackerEx( 4,4,12,	GHOUL		)
			CampaignAttackerEx(1,1,2,		ABOMINATION);//call CampaignAttackerEx( 1,1,2,		ABOMINATION )
			CampaignAttackerEx(1,1,2,		MEAT_WAGON);//call CampaignAttackerEx( 1,1,2,		MEAT_WAGON  )
			SuicideOnPlayerEx(M10,M10,M7,user);//call SuicideOnPlayerEx(M10,M10,M7,user)
			test_sword();//call test_sword()
			SetBuildUpgrEx(0,0,1, UPG_PLAGUE);//call SetBuildUpgrEx( 0,0,1, UPG_PLAGUE        )
			SetBuildUpgrEx(0,0,1, UPG_UNHOLY_ARMOR);//call SetBuildUpgrEx( 0,0,1, UPG_UNHOLY_ARMOR  )
			SetBuildUpgrEx(0,0,1, UPG_CR_ARMOR);//call SetBuildUpgrEx( 0,0,1, UPG_CR_ARMOR      )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(3,3,4,		GHOUL);//call CampaignAttackerEx( 3,3,4,		GHOUL       )
			CampaignAttackerEx(3,3,10,	CRYPT_FIEND);//call CampaignAttackerEx( 3,3,10,	CRYPT_FIEND )
			CampaignAttackerEx(0,0,1,		MEAT_WAGON);//call CampaignAttackerEx( 0,0,1,		MEAT_WAGON  )
			SuicideOnPlayerEx(M10,M10,M7,user);//call SuicideOnPlayerEx(M10,M10,M7,user)
			test_sword();//call test_sword()
			SetBuildUpgrEx(1,1,2, UPG_UNHOLY_STR);//call SetBuildUpgrEx( 1,1,2, UPG_UNHOLY_STR    )
			SetBuildUpgrEx(1,1,2, UPG_CR_ATTACK);//call SetBuildUpgrEx( 1,1,2, UPG_CR_ATTACK     )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(0,0,6, GHOUL);//call CampaignAttackerEx( 0,0,6, GHOUL        )
			CampaignAttackerEx(2,2,4, ABOMINATION);//call CampaignAttackerEx( 2,2,4, ABOMINATION  )
			CampaignAttackerEx(1,1,2, MEAT_WAGON);//call CampaignAttackerEx( 1,1,2, MEAT_WAGON   )
			SuicideOnPlayerEx(M8,M8,M7,user);//call SuicideOnPlayerEx(M8,M8,M7,user)
			test_sword();//call test_sword()
			SetBuildUpgrEx(1,1,2, UPG_UNHOLY_ARMOR);//call SetBuildUpgrEx( 1,1,2, UPG_UNHOLY_ARMOR  )
			SetBuildUpgrEx(1,1,2, UPG_CR_ARMOR);//call SetBuildUpgrEx( 1,1,2, UPG_CR_ARMOR      )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(4,4,10, ABOMINATION);//call CampaignAttackerEx( 4,4,10, ABOMINATION  )
			SuicideOnPlayerEx(M10,M10,M7,user);//call SuicideOnPlayerEx(M10,M10,M7,user)
			test_sword();//call test_sword()
			SetBuildUpgrEx(2,2,3, UPG_UNHOLY_STR);//call SetBuildUpgrEx( 2,2,3, UPG_UNHOLY_STR    )
			SetBuildUpgrEx(2,2,3, UPG_CR_ATTACK);//call SetBuildUpgrEx( 2,2,3, UPG_CR_ATTACK     )
			SetBuildUpgrEx(0,0,1, UPG_GHOUL_FRENZY);//call SetBuildUpgrEx( 0,0,1, UPG_GHOUL_FRENZY  )
			//
			while (true) {//loop
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(0,0,8, GHOUL);//call CampaignAttackerEx( 0,0,8, GHOUL        )
				CampaignAttackerEx(2,2,4, ABOMINATION);//call CampaignAttackerEx( 2,2,4, ABOMINATION  )
				CampaignAttackerEx(1,1,2, MEAT_WAGON);//call CampaignAttackerEx( 1,1,2, MEAT_WAGON   )
				SuicideOnPlayerEx(M8,M8,M7,user);//call SuicideOnPlayerEx(M8,M8,M7,user)
				test_sword();//call test_sword()
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(2,2,6, ABOMINATION);//call CampaignAttackerEx( 2,2,6, ABOMINATION  )
				CampaignAttackerEx(4,4,6, CRYPT_FIEND);//call CampaignAttackerEx( 4,4,6, CRYPT_FIEND  )
				SuicideOnPlayerEx(M8,M8,M7,user);//call SuicideOnPlayerEx(M8,M8,M7,user)
				test_sword();//call test_sword()
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(2,2,8, GHOUL);//call CampaignAttackerEx( 2,2,8, GHOUL        )
				CampaignAttackerEx(0,0,4, ABOMINATION);//call CampaignAttackerEx( 0,0,4, ABOMINATION  )
				CampaignAttackerEx(2,2,6, CRYPT_FIEND);//call CampaignAttackerEx( 2,2,6, CRYPT_FIEND  )
				CampaignAttackerEx(2,2,5, MEAT_WAGON);//call CampaignAttackerEx( 2,2,5, MEAT_WAGON   )
				SuicideOnPlayerEx(M8,M8,M7,user);//call SuicideOnPlayerEx(M8,M8,M7,user)
				test_sword();//call test_sword()
			}//endloop
		}//endfunction

	
	}
}

