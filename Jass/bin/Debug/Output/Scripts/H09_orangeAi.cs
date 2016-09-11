using System;
using System.Collections.Generic;

namespace Jass {

	public class H09_orangeAi {

		//
		//
		//
		public static player user = Player(2);//player user = Player(2)
		public static int upg_level = 1;//integer upg_level = 1
		//
		//
		//
		private void more_upgrades() {//function more_upgrades takes nothing returns nothing
			if (upg_level == 1) {//if upg_level == 1 then
				SetBuildUpgr(1, CommonAi.UPG_UNHOLY_STR);//call SetBuildUpgr( 1, UPG_UNHOLY_STR    )
				SetBuildUpgr(1, CommonAi.UPG_CANNIBALIZE);//call SetBuildUpgr( 1, UPG_CANNIBALIZE   )
			} else if (upg_level == 2) {//elseif upg_level == 2 then
				SetBuildUpgr(1, CommonAi.UPG_CR_ATTACK);//call SetBuildUpgr( 1, UPG_CR_ATTACK     )
			} else if (upg_level == 3) {//elseif upg_level == 3 then
				SetBuildUpgr(1, CommonAi.UPG_FIEND_WEB);//call SetBuildUpgr( 1, UPG_FIEND_WEB     )
				SetBuildUpgr(1, CommonAi.UPG_PLAGUE);//call SetBuildUpgr( 1, UPG_PLAGUE        )
				SetBuildUpgr(1, CommonAi.UPG_UNHOLY_ARMOR);//call SetBuildUpgr( 1, UPG_UNHOLY_ARMOR  )
				SetBuildUpgr(1, CommonAi.UPG_CR_ARMOR);//call SetBuildUpgr( 1, UPG_CR_ARMOR      )
			} else if (upg_level == 4) {//elseif upg_level == 4 then
				SetBuildUpgr(2, CommonAi.UPG_UNHOLY_STR);//call SetBuildUpgr( 2, UPG_UNHOLY_STR    )
				SetBuildUpgr(2, CommonAi.UPG_CR_ATTACK);//call SetBuildUpgr( 2, UPG_CR_ATTACK     )
			} else if (upg_level == 5) {//elseif upg_level == 5 then
				SetBuildUpgr(1, CommonAi.UPG_GHOUL_FRENZY);//call SetBuildUpgr( 1, UPG_GHOUL_FRENZY  )
			} else {//else
				return;//return
			}//endif
			upg_level = upg_level + 1;//set upg_level = upg_level + 1
		}//endfunction
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(CommonAi.ZIGGURAT_1, null);//call CampaignAI(ZIGGURAT_1,null)
			SetBuildUnit(1, CommonAi.ACOLYTE);//call SetBuildUnit( 1, ACOLYTE           )
			SetBuildUnit(1, CommonAi.NECROPOLIS_1);//call SetBuildUnit( 1, NECROPOLIS_1      )
			SetBuildUnit(1, CommonAi.UNDEAD_MINE);//call SetBuildUnit( 1, UNDEAD_MINE       )
			SetBuildUnit(1, CommonAi.CRYPT);//call SetBuildUnit( 1, CRYPT				)
			SetBuildUnit(1, CommonAi.GRAVEYARD);//call SetBuildUnit( 1, GRAVEYARD         )
			SetBuildUnit(1, CommonAi.NECROPOLIS_2);//call SetBuildUnit( 1, NECROPOLIS_2      )
			SetBuildUnit(2, CommonAi.CRYPT);//call SetBuildUnit( 2, CRYPT				)
			SetBuildUnit(1, CommonAi.SLAUGHTERHOUSE);//call SetBuildUnit( 1, SLAUGHTERHOUSE    )
			SetBuildUnit(1, CommonAi.NECROPOLIS_3);//call SetBuildUnit( 1, NECROPOLIS_3      )
			SetBuildUnit(5, CommonAi.ACOLYTE);//call SetBuildUnit( 5, ACOLYTE			)
			CampaignDefender(CommonAi.EASY, 2, CommonAi.GHOUL);//call CampaignDefender( EASY, 2, GHOUL       )
			CampaignDefender(CommonAi.EASY, 2, CommonAi.ABOMINATION);//call CampaignDefender( EASY, 2, ABOMINATION )
			CampaignDefender(CommonAi.EASY, 2, CommonAi.CRYPT_FIEND);//call CampaignDefender( EASY, 2, CRYPT_FIEND )
			WaitForSignal();//call WaitForSignal()
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttacker(CommonAi.EASY, 6, CommonAi.GHOUL);//call CampaignAttacker( EASY,    6, GHOUL        )
			CampaignAttacker(CommonAi.EASY, 2, CommonAi.ABOMINATION);//call CampaignAttacker( EASY,    2, ABOMINATION  )
			SuicideOnPlayer(0, U08_tealAi.user);//call SuicideOnPlayer(0,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttacker(CommonAi.EASY, 8, CommonAi.GHOUL);//call CampaignAttacker( EASY,    8, GHOUL        )
			CampaignAttacker(CommonAi.EASY, 4, CommonAi.CRYPT_FIEND);//call CampaignAttacker( EASY,    4, CRYPT_FIEND  )
			SuicideOnPlayer(5*60, U08_tealAi.user);//call SuicideOnPlayer(5*60,user)
			more_upgrades();//call more_upgrades()
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttacker(CommonAi.EASY, 12, CommonAi.GHOUL);//call CampaignAttacker( EASY,    12, GHOUL       )
			CampaignAttacker(CommonAi.EASY, 3, CommonAi.ABOMINATION);//call CampaignAttacker( EASY,    3, ABOMINATION  )
			CampaignAttacker(CommonAi.EASY, 1, CommonAi.MEAT_WAGON);//call CampaignAttacker( EASY,    1, MEAT_WAGON   )
			SuicideOnPlayer(6*60, U08_tealAi.user);//call SuicideOnPlayer(6*60,user)
			more_upgrades();//call more_upgrades()
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttacker(CommonAi.EASY, 12, CommonAi.GHOUL);//call CampaignAttacker( EASY,    12, GHOUL       )
			CampaignAttacker(CommonAi.EASY, 4, CommonAi.CRYPT_FIEND);//call CampaignAttacker( EASY,    4, CRYPT_FIEND  )
			SuicideOnPlayer(5*60, U08_tealAi.user);//call SuicideOnPlayer(5*60,user)
			more_upgrades();//call more_upgrades()
			//
			while (true) {//loop
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttacker(CommonAi.EASY, 6, CommonAi.GHOUL);//call CampaignAttacker( EASY,    6, GHOUL        )
				CampaignAttacker(CommonAi.EASY, 4, CommonAi.ABOMINATION);//call CampaignAttacker( EASY,    4, ABOMINATION  )
				CampaignAttacker(CommonAi.EASY, 2, CommonAi.MEAT_WAGON);//call CampaignAttacker( EASY,    2, MEAT_WAGON   )
				SuicideOnPlayer(6*60, U08_tealAi.user);//call SuicideOnPlayer(6*60,user)
				more_upgrades();//call more_upgrades()
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttacker(CommonAi.EASY, 6, CommonAi.ABOMINATION);//call CampaignAttacker( EASY,    6, ABOMINATION  )
				CampaignAttacker(CommonAi.EASY, 6, CommonAi.CRYPT_FIEND);//call CampaignAttacker( EASY,    6, CRYPT_FIEND  )
				SuicideOnPlayer(5*60, U08_tealAi.user);//call SuicideOnPlayer(5*60,user)
				more_upgrades();//call more_upgrades()
			}//endloop
		}//endfunction

	
	}
}

