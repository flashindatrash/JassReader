using System;
using System.Collections.Generic;

namespace Jass {

	public class H09_purpleAi {

		//
		//
		//
		public static player user = Player(1);//player user = Player(1)
		//
		//
		//
		private void after_sword() {//function after_sword takes nothing returns nothing
			//
			//
			//
			SetBuildUpgr(1, CommonAi.UPG_FIEND_WEB);//call SetBuildUpgr  ( 1,     UPG_FIEND_WEB     )
			SetBuildUpgrEx(1, 1, 1, CommonAi.UPG_CANNIBALIZE);//call SetBuildUpgrEx( 1,1,1, UPG_CANNIBALIZE   )
			SetBuildUpgrEx(1, 1, 1, CommonAi.UPG_GHOUL_FRENZY);//call SetBuildUpgrEx( 1,1,1, UPG_GHOUL_FRENZY  )
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_PLAGUE);//call SetBuildUpgrEx( 0,0,1, UPG_PLAGUE        )
			SetBuildUpgrEx(2, 2, 3, CommonAi.UPG_UNHOLY_STR);//call SetBuildUpgrEx( 2,2,3, UPG_UNHOLY_STR    )
			SetBuildUpgrEx(1, 1, 3, CommonAi.UPG_UNHOLY_ARMOR);//call SetBuildUpgrEx( 1,1,3, UPG_UNHOLY_ARMOR  )
			SetBuildUpgrEx(2, 2, 3, CommonAi.UPG_CR_ATTACK);//call SetBuildUpgrEx( 2,2,3, UPG_CR_ATTACK     )
			SetBuildUpgrEx(1, 1, 3, CommonAi.UPG_CR_ARMOR);//call SetBuildUpgrEx( 1,1,3, UPG_CR_ARMOR      )
			while (true) {//loop
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(2, 2, 8, CommonAi.GHOUL);//call CampaignAttackerEx( 2,2,8, GHOUL        )
				CampaignAttackerEx(2, 2, 4, CommonAi.ABOMINATION);//call CampaignAttackerEx( 2,2,4, ABOMINATION  )
				CampaignAttackerEx(1, 1, 2, CommonAi.MEAT_WAGON);//call CampaignAttackerEx( 1,1,2, MEAT_WAGON   )
				SuicideOnPlayerEx(CommonAi.M10, CommonAi.M10, CommonAi.M8, U08_tealAi.user);//call SuicideOnPlayerEx(M10,M10,M8,user)
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(2, 2, 6, CommonAi.ABOMINATION);//call CampaignAttackerEx( 2,2,6, ABOMINATION  )
				CampaignAttackerEx(4, 4, 6, CommonAi.CRYPT_FIEND);//call CampaignAttackerEx( 4,4,6, CRYPT_FIEND  )
				SuicideOnPlayerEx(CommonAi.M10, CommonAi.M10, CommonAi.M9, U08_tealAi.user);//call SuicideOnPlayerEx(M10,M10,M9,user)
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(0, 2, 8, CommonAi.GHOUL);//call CampaignAttackerEx( 0,2,8, GHOUL        )
				CampaignAttackerEx(0, 0, 4, CommonAi.ABOMINATION);//call CampaignAttackerEx( 0,0,4, ABOMINATION  )
				CampaignAttackerEx(2, 2, 6, CommonAi.CRYPT_FIEND);//call CampaignAttackerEx( 2,2,6, CRYPT_FIEND  )
				CampaignAttackerEx(3, 3, 5, CommonAi.MEAT_WAGON);//call CampaignAttackerEx( 3,3,5, MEAT_WAGON   )
				SuicideOnPlayerEx(CommonAi.M10, CommonAi.M10, CommonAi.M8, U08_tealAi.user);//call SuicideOnPlayerEx(M10,M10,M8,user)
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(4, 4, 8, CommonAi.ABOMINATION);//call CampaignAttackerEx( 4,4,8, ABOMINATION  )
				CampaignAttackerEx(0, 0, 2, CommonAi.CRYPT_FIEND);//call CampaignAttackerEx( 0,0,2, CRYPT_FIEND  )
				CampaignAttackerEx(1, 1, 2, CommonAi.MEAT_WAGON);//call CampaignAttackerEx( 1,1,2, MEAT_WAGON   )
				SuicideOnPlayerEx(CommonAi.M10, CommonAi.M10, CommonAi.M9, U08_tealAi.user);//call SuicideOnPlayerEx(M10,M10,M9,user)
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
			CampaignAI(CommonAi.ZIGGURAT_1, null);//call CampaignAI(ZIGGURAT_1,null)
			SetReplacements(1, 1, 3);//call SetReplacements(1,1,3)
			SetBuildUnitEx(5, 5, 5, CommonAi.ACOLYTE);//call SetBuildUnitEx( 5,5,5, ACOLYTE			)
			CampaignDefenderEx(1, 1, 2, CommonAi.GHOUL);//call CampaignDefenderEx( 1,1,2, GHOUL       )
			CampaignDefenderEx(0, 0, 1, CommonAi.ABOMINATION);//call CampaignDefenderEx( 0,0,1, ABOMINATION )
			CampaignDefenderEx(1, 1, 2, CommonAi.CRYPT_FIEND);//call CampaignDefenderEx( 1,1,2, CRYPT_FIEND )
			WaitForSignal();//call WaitForSignal()
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2, 2, 8, CommonAi.GHOUL);//call CampaignAttackerEx( 2,2,8,		GHOUL        )
			CampaignAttackerEx(1, 1, 2, CommonAi.ABOMINATION);//call CampaignAttackerEx( 1,1,2,		ABOMINATION  )
			SuicideOnPlayerEx(CommonAi.M4, CommonAi.M4, CommonAi.M2, U08_tealAi.user);//call SuicideOnPlayerEx(M4,M4,M2,user)
			test_sword();//call test_sword()
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_UNHOLY_STR);//call SetBuildUpgrEx( 0,0,1, UPG_UNHOLY_STR    )
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_CANNIBALIZE);//call SetBuildUpgrEx( 0,0,1, UPG_CANNIBALIZE   )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(4, 4, 10, CommonAi.GHOUL);//call CampaignAttackerEx( 4,4,10,	GHOUL        )
			CampaignAttackerEx(2, 2, 4, CommonAi.CRYPT_FIEND);//call CampaignAttackerEx( 2,2,4,		CRYPT_FIEND  )
			CampaignAttackerEx(0, 0, 1, CommonAi.MEAT_WAGON);//call CampaignAttackerEx( 0,0,1,		MEAT_WAGON   )
			SuicideOnPlayerEx(CommonAi.M8, CommonAi.M8, CommonAi.M7, U08_tealAi.user);//call SuicideOnPlayerEx(M8,M8,M7,user)
			test_sword();//call test_sword()
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_CR_ATTACK);//call SetBuildUpgrEx( 0,0,1, UPG_CR_ATTACK     )
			SetBuildUpgr(1, CommonAi.UPG_FIEND_WEB);//call SetBuildUpgr  ( 1,     UPG_FIEND_WEB     )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(4, 4, 12, CommonAi.GHOUL);//call CampaignAttackerEx( 4,4,12,	GHOUL		)
			CampaignAttackerEx(1, 1, 2, CommonAi.ABOMINATION);//call CampaignAttackerEx( 1,1,2,		ABOMINATION )
			CampaignAttackerEx(1, 1, 2, CommonAi.MEAT_WAGON);//call CampaignAttackerEx( 1,1,2,		MEAT_WAGON  )
			SuicideOnPlayerEx(CommonAi.M10, CommonAi.M10, CommonAi.M7, U08_tealAi.user);//call SuicideOnPlayerEx(M10,M10,M7,user)
			test_sword();//call test_sword()
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_PLAGUE);//call SetBuildUpgrEx( 0,0,1, UPG_PLAGUE        )
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_UNHOLY_ARMOR);//call SetBuildUpgrEx( 0,0,1, UPG_UNHOLY_ARMOR  )
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_CR_ARMOR);//call SetBuildUpgrEx( 0,0,1, UPG_CR_ARMOR      )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(3, 3, 4, CommonAi.GHOUL);//call CampaignAttackerEx( 3,3,4,		GHOUL       )
			CampaignAttackerEx(3, 3, 10, CommonAi.CRYPT_FIEND);//call CampaignAttackerEx( 3,3,10,	CRYPT_FIEND )
			CampaignAttackerEx(0, 0, 1, CommonAi.MEAT_WAGON);//call CampaignAttackerEx( 0,0,1,		MEAT_WAGON  )
			SuicideOnPlayerEx(CommonAi.M10, CommonAi.M10, CommonAi.M7, U08_tealAi.user);//call SuicideOnPlayerEx(M10,M10,M7,user)
			test_sword();//call test_sword()
			SetBuildUpgrEx(1, 1, 2, CommonAi.UPG_UNHOLY_STR);//call SetBuildUpgrEx( 1,1,2, UPG_UNHOLY_STR    )
			SetBuildUpgrEx(1, 1, 2, CommonAi.UPG_CR_ATTACK);//call SetBuildUpgrEx( 1,1,2, UPG_CR_ATTACK     )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(0, 0, 6, CommonAi.GHOUL);//call CampaignAttackerEx( 0,0,6, GHOUL        )
			CampaignAttackerEx(2, 2, 4, CommonAi.ABOMINATION);//call CampaignAttackerEx( 2,2,4, ABOMINATION  )
			CampaignAttackerEx(1, 1, 2, CommonAi.MEAT_WAGON);//call CampaignAttackerEx( 1,1,2, MEAT_WAGON   )
			SuicideOnPlayerEx(CommonAi.M8, CommonAi.M8, CommonAi.M7, U08_tealAi.user);//call SuicideOnPlayerEx(M8,M8,M7,user)
			test_sword();//call test_sword()
			SetBuildUpgrEx(1, 1, 2, CommonAi.UPG_UNHOLY_ARMOR);//call SetBuildUpgrEx( 1,1,2, UPG_UNHOLY_ARMOR  )
			SetBuildUpgrEx(1, 1, 2, CommonAi.UPG_CR_ARMOR);//call SetBuildUpgrEx( 1,1,2, UPG_CR_ARMOR      )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(4, 4, 10, CommonAi.ABOMINATION);//call CampaignAttackerEx( 4,4,10, ABOMINATION  )
			SuicideOnPlayerEx(CommonAi.M10, CommonAi.M10, CommonAi.M7, U08_tealAi.user);//call SuicideOnPlayerEx(M10,M10,M7,user)
			test_sword();//call test_sword()
			SetBuildUpgrEx(2, 2, 3, CommonAi.UPG_UNHOLY_STR);//call SetBuildUpgrEx( 2,2,3, UPG_UNHOLY_STR    )
			SetBuildUpgrEx(2, 2, 3, CommonAi.UPG_CR_ATTACK);//call SetBuildUpgrEx( 2,2,3, UPG_CR_ATTACK     )
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_GHOUL_FRENZY);//call SetBuildUpgrEx( 0,0,1, UPG_GHOUL_FRENZY  )
			//
			while (true) {//loop
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(0, 0, 8, CommonAi.GHOUL);//call CampaignAttackerEx( 0,0,8, GHOUL        )
				CampaignAttackerEx(2, 2, 4, CommonAi.ABOMINATION);//call CampaignAttackerEx( 2,2,4, ABOMINATION  )
				CampaignAttackerEx(1, 1, 2, CommonAi.MEAT_WAGON);//call CampaignAttackerEx( 1,1,2, MEAT_WAGON   )
				SuicideOnPlayerEx(CommonAi.M8, CommonAi.M8, CommonAi.M7, U08_tealAi.user);//call SuicideOnPlayerEx(M8,M8,M7,user)
				test_sword();//call test_sword()
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(2, 2, 6, CommonAi.ABOMINATION);//call CampaignAttackerEx( 2,2,6, ABOMINATION  )
				CampaignAttackerEx(4, 4, 6, CommonAi.CRYPT_FIEND);//call CampaignAttackerEx( 4,4,6, CRYPT_FIEND  )
				SuicideOnPlayerEx(CommonAi.M8, CommonAi.M8, CommonAi.M7, U08_tealAi.user);//call SuicideOnPlayerEx(M8,M8,M7,user)
				test_sword();//call test_sword()
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(2, 2, 8, CommonAi.GHOUL);//call CampaignAttackerEx( 2,2,8, GHOUL        )
				CampaignAttackerEx(0, 0, 4, CommonAi.ABOMINATION);//call CampaignAttackerEx( 0,0,4, ABOMINATION  )
				CampaignAttackerEx(2, 2, 6, CommonAi.CRYPT_FIEND);//call CampaignAttackerEx( 2,2,6, CRYPT_FIEND  )
				CampaignAttackerEx(2, 2, 5, CommonAi.MEAT_WAGON);//call CampaignAttackerEx( 2,2,5, MEAT_WAGON   )
				SuicideOnPlayerEx(CommonAi.M8, CommonAi.M8, CommonAi.M7, U08_tealAi.user);//call SuicideOnPlayerEx(M8,M8,M7,user)
				test_sword();//call test_sword()
			}//endloop
		}//endfunction

	
	}
}

