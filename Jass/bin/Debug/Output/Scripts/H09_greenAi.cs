using System;
using System.Collections.Generic;

namespace Jass {

	public class H09_greenAi {

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
			SetBuildUpgrEx(1,1,1, UPG_SKEL_LIFE);//call SetBuildUpgrEx( 1,1,1, UPG_SKEL_LIFE     )
			SetBuildUpgrEx(1,1,1, UPG_GHOUL_FRENZY);//call SetBuildUpgrEx( 1,1,1, UPG_GHOUL_FRENZY  )
			SetBuildUpgrEx(1,1,1, UPG_STONE_FORM);//call SetBuildUpgrEx( 1,1,1, UPG_STONE_FORM    )
			SetBuildUpgrEx(0,0,1, UPG_PLAGUE);//call SetBuildUpgrEx( 0,0,1, UPG_PLAGUE        )
			SetBuildUpgrEx(1,1,1, UPG_WYRM_BREATH);//call SetBuildUpgrEx( 1,1,1, UPG_WYRM_BREATH   )
			SetBuildUpgrEx(2,2,2, UPG_NECROS);//call SetBuildUpgrEx( 2,2,2, UPG_NECROS        )
			SetBuildUpgrEx(0,0,3, UPG_UNHOLY_STR);//call SetBuildUpgrEx( 0,0,3, UPG_UNHOLY_STR    )
			SetBuildUpgrEx(0,0,3, UPG_UNHOLY_ARMOR);//call SetBuildUpgrEx( 0,0,3, UPG_UNHOLY_ARMOR  )
			SetBuildUpgrEx(0,0,3, UPG_CR_ATTACK);//call SetBuildUpgrEx( 0,0,3, UPG_CR_ATTACK     )
			SetBuildUpgrEx(0,0,3, UPG_CR_ARMOR);//call SetBuildUpgrEx( 0,0,3, UPG_CR_ARMOR      )
			while (true) {//loop
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(1,1,1, MALGANIS);//call CampaignAttackerEx( 1,1,1, MALGANIS     )
				CampaignAttackerEx(2,2,5, CRYPT_FIEND);//call CampaignAttackerEx( 2,2,5, CRYPT_FIEND  )
				CampaignAttackerEx(0,0,1, ABOMINATION);//call CampaignAttackerEx( 0,0,1, ABOMINATION  )
				CampaignAttackerEx(2,2,3, NECRO);//call CampaignAttackerEx( 2,2,3, NECRO        )
				CampaignAttackerEx(1,1,4, MEAT_WAGON);//call CampaignAttackerEx( 1,1,4, MEAT_WAGON   )
				SuicideOnPlayerEx(M8,M8,M8,user);//call SuicideOnPlayerEx(M8,M8,M8,user)
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(0,0,1, MALGANIS);//call CampaignAttackerEx( 0,0,1, MALGANIS     )
				CampaignAttackerEx(0,0,2, ABOMINATION);//call CampaignAttackerEx( 0,0,2, ABOMINATION  )
				CampaignAttackerEx(2,2,8, GARGOYLE);//call CampaignAttackerEx( 2,2,8, GARGOYLE     )
				CampaignAttackerEx(2,2,3, FROST_WYRM);//call CampaignAttackerEx( 2,2,3, FROST_WYRM   )
				CampaignAttackerEx(0,0,1, MEAT_WAGON);//call CampaignAttackerEx( 0,0,1, MEAT_WAGON   )
				SuicideOnPlayerEx(M10,M10,M8,user);//call SuicideOnPlayerEx(M10,M10,M8,user)
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(1,1,1, MALGANIS);//call CampaignAttackerEx( 1,1,1, MALGANIS     )
				CampaignAttackerEx(2,2,4, ABOMINATION);//call CampaignAttackerEx( 2,2,4, ABOMINATION  )
				CampaignAttackerEx(1,1,3, MEAT_WAGON);//call CampaignAttackerEx( 1,1,3, MEAT_WAGON   )
				CampaignAttackerEx(0,0,4, CRYPT_FIEND);//call CampaignAttackerEx( 0,0,4, CRYPT_FIEND  )
				CampaignAttackerEx(0,0,3, NECRO);//call CampaignAttackerEx( 0,0,3, NECRO        )
				CampaignAttackerEx(2,2,6, GHOUL);//call CampaignAttackerEx( 2,2,6, GHOUL        )
				SuicideOnPlayerEx(M8,M8,M8,user);//call SuicideOnPlayerEx(M8,M8,M8,user)
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(0,0,1, MALGANIS);//call CampaignAttackerEx( 0,0,1, MALGANIS     )
				CampaignAttackerEx(8,8,8, GARGOYLE);//call CampaignAttackerEx( 8,8,8, GARGOYLE     )
				CampaignAttackerEx(1,1,3, FROST_WYRM);//call CampaignAttackerEx( 1,1,3, FROST_WYRM   )
				SuicideOnPlayerEx(M10,M10,M8,user);//call SuicideOnPlayerEx(M10,M10,M8,user)
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
			campaign_wood_peons = 1;//set campaign_wood_peons = 1
			SetBuildUnitEx(0,0,1, NECROPOLIS_1);//call SetBuildUnitEx( 0,0,1, NECROPOLIS_1	)
			SetBuildUnitEx(1,1,1, ACOLYTE);//call SetBuildUnitEx( 1,1,1, ACOLYTE			)
			SetBuildUnitEx(0,0,1, UNDEAD_MINE);//call SetBuildUnitEx( 0,0,1, UNDEAD_MINE		)
			SetBuildUnitEx(0,0,1, GRAVEYARD);//call SetBuildUnitEx( 0,0,1, GRAVEYARD		)
			SetBuildUnitEx(0,0,8, ZIGGURAT_1);//call SetBuildUnitEx( 0,0,8, ZIGGURAT_1		)
			SetBuildUnitEx(0,0,1, NECROPOLIS_2);//call SetBuildUnitEx( 0,0,1, NECROPOLIS_2	)
			SetBuildUnitEx(0,0,1, CRYPT);//call SetBuildUnitEx( 0,0,1, CRYPT           )
			SetBuildUnitEx(0,0,1, SLAUGHTERHOUSE);//call SetBuildUnitEx( 0,0,1, SLAUGHTERHOUSE	)
			SetBuildUnitEx(0,0,1, DAMNED_TEMPLE);//call SetBuildUnitEx( 0,0,1, DAMNED_TEMPLE	)
			SetBuildUnitEx(0,0,1, NECROPOLIS_3);//call SetBuildUnitEx( 0,0,1, NECROPOLIS_3	)
			SetBuildUnitEx(0,0,1, SLAUGHTERHOUSE);//call SetBuildUnitEx( 0,0,1, SLAUGHTERHOUSE	)
			SetBuildUnitEx(0,0,5, ACOLYTE);//call SetBuildUnitEx( 0,0,5, ACOLYTE			)
			SetBuildUnitEx(0,0,8, ZIGGURAT_2);//call SetBuildUnitEx( 0,0,8, ZIGGURAT_2		)
			CampaignDefenderEx(0,0,1, ABOMINATION);//call CampaignDefenderEx( 0,0,1, ABOMINATION	)
			CampaignDefenderEx(0,0,1, NECRO);//call CampaignDefenderEx( 0,0,1, NECRO		)
			CampaignDefenderEx(1,1,1, GHOUL);//call CampaignDefenderEx( 1,1,1, GHOUL		)
			CampaignDefenderEx(1,1,0, GARGOYLE);//call CampaignDefenderEx( 1,1,0, GARGOYLE	)
			CampaignDefenderEx(0,0,1, CRYPT_FIEND);//call CampaignDefenderEx( 0,0,1, CRYPT_FIEND	)
			CampaignDefenderEx(0,0,1, MALGANIS);//call CampaignDefenderEx( 0,0,1, MALGANIS	)
			WaitForSignal();//call WaitForSignal()
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(4,4,6, GHOUL);//call CampaignAttackerEx( 4,4,6, GHOUL        )
			CampaignAttackerEx(0,0,3, ABOMINATION);//call CampaignAttackerEx( 0,0,3, ABOMINATION  )
			CampaignAttackerEx(1,1,2, NECRO);//call CampaignAttackerEx( 1,1,2, NECRO        )
			SuicideOnPlayerEx(M8,M8,M7,user);//call SuicideOnPlayerEx(M8,M8,M7,user)
			test_sword();//call test_sword()
			SetBuildUpgr(1, UPG_FIEND_WEB);//call SetBuildUpgr( 1, UPG_FIEND_WEB     )
			SetBuildUpgrEx(1,1,1, UPG_CANNIBALIZE);//call SetBuildUpgrEx( 1,1,1, UPG_CANNIBALIZE   )
			SetBuildUpgrEx(1,1,1, UPG_UNHOLY_STR);//call SetBuildUpgrEx( 1,1,1, UPG_UNHOLY_STR    )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2,2,4, GHOUL);//call CampaignAttackerEx( 2,2,4, GHOUL        )
			CampaignAttackerEx(2,2,4, CRYPT_FIEND);//call CampaignAttackerEx( 2,2,4, CRYPT_FIEND  )
			CampaignAttackerEx(2,2,4, GARGOYLE);//call CampaignAttackerEx( 2,2,4, GARGOYLE     )
			SuicideOnPlayerEx(M10,M10,M7,user);//call SuicideOnPlayerEx(M10,M10,M7,user)
			test_sword();//call test_sword()
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2,2,12, GHOUL);//call CampaignAttackerEx( 2,2,12, GHOUL       )
			CampaignAttackerEx(1,1,3, NECRO);//call CampaignAttackerEx( 1,1,3, NECRO        )
			CampaignAttackerEx(2,2,3, CRYPT_FIEND);//call CampaignAttackerEx( 2,2,3, CRYPT_FIEND  )
			SuicideOnPlayerEx(M8,M8,M7,user);//call SuicideOnPlayerEx(M8,M8,M7,user)
			test_sword();//call test_sword()
			SetBuildUpgrEx(1,1,1, UPG_CR_ATTACK);//call SetBuildUpgrEx( 1,1,1, UPG_CR_ATTACK     )
			SetBuildUpgrEx(1,1,1, UPG_SKEL_LIFE);//call SetBuildUpgrEx( 1,1,1, UPG_SKEL_LIFE     )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(3,3,2, CRYPT_FIEND);//call CampaignAttackerEx( 3,3,2, CRYPT_FIEND  )
			CampaignAttackerEx(1,1,3, ABOMINATION);//call CampaignAttackerEx( 1,1,3, ABOMINATION  )
			CampaignAttackerEx(2,2,4, MEAT_WAGON);//call CampaignAttackerEx( 2,2,4, MEAT_WAGON   )
			SuicideOnPlayerEx(M10,M10,M7,user);//call SuicideOnPlayerEx(M10,M10,M7,user)
			test_sword();//call test_sword()
			SetBuildUpgrEx(0,0,1, UPG_PLAGUE);//call SetBuildUpgrEx( 0,0,1, UPG_PLAGUE        )
			SetBuildUpgrEx(1,1,1, UPG_UNHOLY_ARMOR);//call SetBuildUpgrEx( 1,1,1, UPG_UNHOLY_ARMOR  )
			SetBuildUpgrEx(1,1,1, UPG_CR_ARMOR);//call SetBuildUpgrEx( 1,1,1, UPG_CR_ARMOR      )
			SetBuildUpgrEx(1,1,1, UPG_NECROS);//call SetBuildUpgrEx( 1,1,1, UPG_NECROS        )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(0,0,4, ABOMINATION);//call CampaignAttackerEx( 0,0,4, ABOMINATION  )
			CampaignAttackerEx(4,4,6, GARGOYLE);//call CampaignAttackerEx( 4,4,6, GARGOYLE     )
			CampaignAttackerEx(0,0,2, MEAT_WAGON);//call CampaignAttackerEx( 0,0,2, MEAT_WAGON   )
			SuicideOnPlayerEx(M8,M8,M7,user);//call SuicideOnPlayerEx(M8,M8,M7,user)
			test_sword();//call test_sword()
			SetBuildUpgrEx(2,2,2, UPG_UNHOLY_STR);//call SetBuildUpgrEx( 2,2,2, UPG_UNHOLY_STR		)
			SetBuildUpgrEx(2,2,2, UPG_CR_ATTACK);//call SetBuildUpgrEx( 2,2,2, UPG_CR_ATTACK		)
			SetBuildUpgrEx(1,1,1, UPG_GHOUL_FRENZY);//call SetBuildUpgrEx( 1,1,1, UPG_GHOUL_FRENZY	)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(4,4,12, GARGOYLE);//call CampaignAttackerEx( 4,4,12, GARGOYLE		)
			CampaignAttackerEx(1,1,2, FROST_WYRM);//call CampaignAttackerEx( 1,1,2, FROST_WYRM		)
			SuicideOnPlayerEx(M10,M10,M7,user);//call SuicideOnPlayerEx(M10,M10,M7,user)
			test_sword();//call test_sword()
			SetBuildUpgrEx(2,2,2, UPG_UNHOLY_ARMOR);//call SetBuildUpgrEx( 2,2,2, UPG_UNHOLY_ARMOR  )
			SetBuildUpgrEx(2,2,2, UPG_CR_ARMOR);//call SetBuildUpgrEx( 2,2,2, UPG_CR_ARMOR      )
			SetBuildUpgrEx(1,1,1, UPG_STONE_FORM);//call SetBuildUpgrEx( 1,1,1, UPG_STONE_FORM    )
			SetBuildUpgrEx(2,2,2, UPG_NECROS);//call SetBuildUpgrEx( 2,2,2, UPG_NECROS        )
			SetBuildUpgrEx(1,1,1, UPG_WYRM_BREATH);//call SetBuildUpgrEx( 1,1,1, UPG_WYRM_BREATH   )
			while (true) {//loop
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(3,3,5, CRYPT_FIEND);//call CampaignAttackerEx( 3,3,5, CRYPT_FIEND  )
				CampaignAttackerEx(0,0,1, ABOMINATION);//call CampaignAttackerEx( 0,0,1, ABOMINATION  )
				CampaignAttackerEx(2,2,3, NECRO);//call CampaignAttackerEx( 2,2,3, NECRO        )
				CampaignAttackerEx(2,2,4, MEAT_WAGON);//call CampaignAttackerEx( 2,2,4, MEAT_WAGON   )
				SuicideOnPlayerEx(M8,M8,M7,user);//call SuicideOnPlayerEx(M8,M8,M7,user)
				test_sword();//call test_sword()
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(0,0,2, ABOMINATION);//call CampaignAttackerEx( 0,0,2, ABOMINATION  )
				CampaignAttackerEx(3,3,8, GARGOYLE);//call CampaignAttackerEx( 3,3,8, GARGOYLE     )
				CampaignAttackerEx(1,1,3, FROST_WYRM);//call CampaignAttackerEx( 1,1,3, FROST_WYRM   )
				CampaignAttackerEx(0,0,1, MEAT_WAGON);//call CampaignAttackerEx( 0,0,1, MEAT_WAGON   )
				SuicideOnPlayerEx(M10,M10,M7,user);//call SuicideOnPlayerEx(M10,M10,M7,user)
				test_sword();//call test_sword()
			}//endloop
		}//endfunction

	
	}
}

