using System;
using System.Collections.Generic;

namespace Jass {

	public class N06_greenAi {

		//
		//
		//
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(ZIGGURAT_1,null);//call CampaignAI(ZIGGURAT_1,null)
			SetReplacements(0,1,3);//call SetReplacements(0,1,3)
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
			CampaignDefenderEx(0,0,1, ABOMINATION);//call CampaignDefenderEx( 0,0,1, ABOMINATION	)
			CampaignDefenderEx(0,0,1, NECRO);//call CampaignDefenderEx( 0,0,1, NECRO		)
			CampaignDefenderEx(1,1,1, GHOUL);//call CampaignDefenderEx( 1,1,1, GHOUL		)
			CampaignDefenderEx(0,1,0, GARGOYLE);//call CampaignDefenderEx( 0,1,0, GARGOYLE	)
			CampaignDefenderEx(0,0,1, CRYPT_FIEND);//call CampaignDefenderEx( 0,0,1, CRYPT_FIEND	)
			CampaignDefenderEx(0,0,1, LICH);//call CampaignDefenderEx( 0,0,1, LICH		)
			WaitForSignal();//call WaitForSignal()
			//
			//
			//
			//
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(3,4,6, GHOUL);//call CampaignAttackerEx( 3,4,6, GHOUL       )
			CampaignAttackerEx(0,0,3, ABOMINATION);//call CampaignAttackerEx( 0,0,3, ABOMINATION )
			CampaignAttackerEx(1,1,2, NECRO);//call CampaignAttackerEx( 1,1,2, NECRO       )
			SuicideOnPlayerEx(M10,M8,M6,user);//call SuicideOnPlayerEx(M10,M8,M6,user)
			SetBuildUpgr(1, UPG_FIEND_WEB);//call SetBuildUpgr( 1, UPG_FIEND_WEB			)
			SetBuildUpgrEx(0,1,1, UPG_CANNIBALIZE);//call SetBuildUpgrEx( 0,1,1, UPG_CANNIBALIZE )
			SetBuildUpgrEx(0,1,1, UPG_UNHOLY_STR);//call SetBuildUpgrEx( 0,1,1, UPG_UNHOLY_STR  )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2,2,4, GHOUL);//call CampaignAttackerEx( 2,2,4, GHOUL       )
			CampaignAttackerEx(0,2,4, CRYPT_FIEND);//call CampaignAttackerEx( 0,2,4, CRYPT_FIEND )
			CampaignAttackerEx(2,2,4, GARGOYLE);//call CampaignAttackerEx( 2,2,4, GARGOYLE    )
			SuicideOnPlayerEx(M12,M10,M6,user);//call SuicideOnPlayerEx(M12,M10,M6,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(0,1,1, LICH);//call CampaignAttackerEx( 0,1,1, LICH		)
			CampaignAttackerEx(4,2,12, GHOUL);//call CampaignAttackerEx( 4,2,12, GHOUL      )
			CampaignAttackerEx(0,1,3, NECRO);//call CampaignAttackerEx( 0,1,3, NECRO       )
			CampaignAttackerEx(1,2,3, CRYPT_FIEND);//call CampaignAttackerEx( 1,2,3, CRYPT_FIEND )
			SuicideOnPlayerEx(M10,M8,M6,user);//call SuicideOnPlayerEx(M10,M8,M6,user)
			SetBuildUpgrEx(0,1,1, UPG_CR_ATTACK);//call SetBuildUpgrEx( 0,1,1, UPG_CR_ATTACK     )
			SetBuildUpgrEx(0,1,1, UPG_SKEL_LIFE);//call SetBuildUpgrEx( 0,1,1, UPG_SKEL_LIFE     )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2,3,2, CRYPT_FIEND);//call CampaignAttackerEx( 2,3,2, CRYPT_FIEND  )
			CampaignAttackerEx(1,1,3, ABOMINATION);//call CampaignAttackerEx( 1,1,3, ABOMINATION  )
			CampaignAttackerEx(1,2,4, MEAT_WAGON);//call CampaignAttackerEx( 1,2,4, MEAT_WAGON   )
			SuicideOnPlayerEx(M12,M10,M6,user);//call SuicideOnPlayerEx(M12,M10,M6,user)
			SetBuildUpgrEx(0,0,1, UPG_PLAGUE);//call SetBuildUpgrEx( 0,0,1, UPG_PLAGUE        )
			SetBuildUpgrEx(0,1,1, UPG_UNHOLY_ARMOR);//call SetBuildUpgrEx( 0,1,1, UPG_UNHOLY_ARMOR  )
			SetBuildUpgrEx(0,1,1, UPG_CR_ARMOR);//call SetBuildUpgrEx( 0,1,1, UPG_CR_ARMOR      )
			SetBuildUpgrEx(0,1,1, UPG_NECROS);//call SetBuildUpgrEx( 0,1,1, UPG_NECROS        )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(1,1,1, LICH);//call CampaignAttackerEx( 1,1,1, LICH		)
			CampaignAttackerEx(0,0,4, ABOMINATION);//call CampaignAttackerEx( 0,0,4, ABOMINATION )
			CampaignAttackerEx(1,4,6, GARGOYLE);//call CampaignAttackerEx( 1,4,6, GARGOYLE    )
			CampaignAttackerEx(0,0,2, MEAT_WAGON);//call CampaignAttackerEx( 0,0,2, MEAT_WAGON  )
			SuicideOnPlayerEx(M10,M8,M6,user);//call SuicideOnPlayerEx(M10,M8,M6,user)
			SetBuildUpgrEx(1,2,2, UPG_UNHOLY_STR);//call SetBuildUpgrEx( 1,2,2, UPG_UNHOLY_STR    )
			SetBuildUpgrEx(1,2,2, UPG_CR_ATTACK);//call SetBuildUpgrEx( 1,2,2, UPG_CR_ATTACK     )
			SetBuildUpgrEx(0,1,1, UPG_GHOUL_FRENZY);//call SetBuildUpgrEx( 0,1,1, UPG_GHOUL_FRENZY  )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(4,4,12, GARGOYLE);//call CampaignAttackerEx( 4,4,12, GARGOYLE	)
			CampaignAttackerEx(0,1,2, FROST_WYRM);//call CampaignAttackerEx( 0,1,2, FROST_WYRM	)
			SuicideOnPlayerEx(M12,M10,M6,user);//call SuicideOnPlayerEx(M12,M10,M6,user)
			SetBuildUpgrEx(1,2,2, UPG_UNHOLY_ARMOR);//call SetBuildUpgrEx( 1,2,2, UPG_UNHOLY_ARMOR  )
			SetBuildUpgrEx(1,2,2, UPG_CR_ARMOR);//call SetBuildUpgrEx( 1,2,2, UPG_CR_ARMOR      )
			SetBuildUpgrEx(0,1,1, UPG_STONE_FORM);//call SetBuildUpgrEx( 0,1,1, UPG_STONE_FORM    )
			SetBuildUpgrEx(1,2,2, UPG_NECROS);//call SetBuildUpgrEx( 1,2,2, UPG_NECROS        )
			SetBuildUpgrEx(0,1,1, UPG_WYRM_BREATH);//call SetBuildUpgrEx( 0,1,1, UPG_WYRM_BREATH   )
			while (true) {//loop
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(0,1,1, LICH);//call CampaignAttackerEx( 0,1,1, LICH		)
				CampaignAttackerEx(2,3,5, CRYPT_FIEND);//call CampaignAttackerEx( 2,3,5, CRYPT_FIEND )
				CampaignAttackerEx(0,0,1, ABOMINATION);//call CampaignAttackerEx( 0,0,1, ABOMINATION )
				CampaignAttackerEx(1,2,3, NECRO);//call CampaignAttackerEx( 1,2,3, NECRO       )
				CampaignAttackerEx(1,2,4, MEAT_WAGON);//call CampaignAttackerEx( 1,2,4, MEAT_WAGON  )
				SuicideOnPlayerEx(M8,M6,M6,user);//call SuicideOnPlayerEx(M8,M6,M6,user)
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(1,1,1, LICH);//call CampaignAttackerEx( 1,1,1, LICH		)
				CampaignAttackerEx(0,0,2, ABOMINATION);//call CampaignAttackerEx( 0,0,2, ABOMINATION )
				CampaignAttackerEx(2,3,8, GARGOYLE);//call CampaignAttackerEx( 2,3,8, GARGOYLE    )
				CampaignAttackerEx(1,1,3, FROST_WYRM);//call CampaignAttackerEx( 1,1,3, FROST_WYRM  )
				CampaignAttackerEx(0,0,1, MEAT_WAGON);//call CampaignAttackerEx( 0,0,1, MEAT_WAGON  )
				SuicideOnPlayerEx(M8,M6,M6,user);//call SuicideOnPlayerEx(M8,M6,M6,user)
			}//endloop
		}//endfunction

	
	}
}

