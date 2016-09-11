using System;
using System.Collections.Generic;

namespace Jass {

	public class N08x06Ai {

		//
		//
		//
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(ZIGGURAT_1,null);//call CampaignAI(ZIGGURAT_1,null)
			SetReplacements(1,1,3);//call SetReplacements(1,1,3)
			DoCampaignFarms(false);//call DoCampaignFarms(false)
			SetWoodPeons(2);//call SetWoodPeons(2)
			SetBuildUnitEx(1, 1, 1, ACOLYTE);//call SetBuildUnitEx( 1, 1, 1, ACOLYTE           )
			SetBuildUnitEx(0, 0, 1, NECROPOLIS_1);//call SetBuildUnitEx( 0, 0, 1, NECROPOLIS_1      )
			SetBuildUnitEx(0, 0, 1, UNDEAD_MINE);//call SetBuildUnitEx( 0, 0, 1, UNDEAD_MINE       )
			SetBuildUnitEx(0, 0, 2, CRYPT);//call SetBuildUnitEx( 0, 0, 2, CRYPT             )
			SetBuildUnitEx(0, 0, 3, ZIGGURAT_1);//call SetBuildUnitEx( 0, 0, 3, ZIGGURAT_1        )
			SetBuildUnitEx(0, 0, 1, GRAVEYARD);//call SetBuildUnitEx( 0, 0, 1, GRAVEYARD         )
			SetBuildUnitEx(0, 0, 1, UNDEAD_ALTAR);//call SetBuildUnitEx( 0, 0, 1, UNDEAD_ALTAR      )
			SetBuildUnitEx(0, 0, 1, NECROPOLIS_2);//call SetBuildUnitEx( 0, 0, 1, NECROPOLIS_2      )
			SetBuildUnitEx(0, 0, 3, ZIGGURAT_2);//call SetBuildUnitEx( 0, 0, 3, ZIGGURAT_2        )
			SetBuildUnitEx(0, 0, 2, SLAUGHTERHOUSE);//call SetBuildUnitEx( 0, 0, 2, SLAUGHTERHOUSE    )
			SetBuildUnitEx(0, 0, 1, SAC_PIT);//call SetBuildUnitEx( 0, 0, 1, SAC_PIT           )
			SetBuildUnitEx(0, 0, 1, NECROPOLIS_3);//call SetBuildUnitEx( 0, 0, 1, NECROPOLIS_3      )
			SetBuildUnitEx(0, 0, 1, BONEYARD);//call SetBuildUnitEx( 0, 0, 1, BONEYARD          )
			SetBuildUnitEx(5, 5, 5, ACOLYTE);//call SetBuildUnitEx( 5, 5, 5, ACOLYTE           )
			SetBuildUnitEx(2, 2, 2, UNDEAD_BARGE);//call SetBuildUnitEx( 2, 2, 2, UNDEAD_BARGE      )
			SetBuildUpgrEx(1, 1, 1, UPG_BLK_SPHINX);//call SetBuildUpgrEx( 1, 1, 1, UPG_BLK_SPHINX    )
			CampaignDefenderEx(1, 1, 1, DEATH_KNIGHT);//call CampaignDefenderEx( 1, 1, 1, DEATH_KNIGHT  )
			CampaignDefenderEx(1, 1, 1, ABOMINATION);//call CampaignDefenderEx( 1, 1, 1, ABOMINATION   )
			CampaignDefenderEx(1, 1, 1, OBS_STATUE);//call CampaignDefenderEx( 1, 1, 1, OBS_STATUE    )
			CampaignDefenderEx(1, 1, 1, FROST_WYRM);//call CampaignDefenderEx( 1, 1, 1, FROST_WYRM    )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(5,5,6, GARGOYLE);//call CampaignAttackerEx( 5,5,6, GARGOYLE    )
			SuicideOnPlayerEx(M6,M6,M4,user);//call SuicideOnPlayerEx(M6,M6,M4,user)
			SetBuildUpgrEx(0,0,1, UPG_UNHOLY_STR);//call SetBuildUpgrEx( 0,0,1, UPG_UNHOLY_STR  )
			SetBuildUpgrEx(0,1,1, UPG_CR_ATTACK);//call SetBuildUpgrEx( 0,1,1, UPG_CR_ATTACK   )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(1,1,1, MEAT_WAGON);//call CampaignAttackerEx( 1,1,1, MEAT_WAGON  )
			CampaignAttackerEx(6,6,8, GHOUL);//call CampaignAttackerEx( 6,6,8, GHOUL       )
			CampaignAttackerEx(0,0,1, DEATH_KNIGHT);//call CampaignAttackerEx( 0,0,1, DEATH_KNIGHT)
			SuicideOnPlayerEx(M7,M7,M5,user);//call SuicideOnPlayerEx(M7,M7,M5,user)
			SetBuildUpgrEx(0,0,1, UPG_UNHOLY_ARMOR);//call SetBuildUpgrEx( 0,0,1, UPG_UNHOLY_ARMOR)
			SetBuildUpgrEx(0,0,1, UPG_CR_ARMOR);//call SetBuildUpgrEx( 0,0,1, UPG_CR_ARMOR    )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(5,5,6, GARGOYLE);//call CampaignAttackerEx( 5,5,6, GARGOYLE    )
			CampaignAttackerEx(1,1,1, BLK_SPHINX);//call CampaignAttackerEx( 1,1,1, BLK_SPHINX  )
			SuicideOnPlayerEx(M7,M7,M5,user);//call SuicideOnPlayerEx(M7,M7,M5,user)
			SetBuildUpgrEx(0,0,1, UPG_PLAGUE);//call SetBuildUpgrEx( 0,0,1, UPG_PLAGUE      )
			SetBuildUpgrEx(0,0,1, UPG_GHOUL_FRENZY);//call SetBuildUpgrEx( 0,0,1, UPG_GHOUL_FRENZY)
			SetBuildUpgrEx(1,1,1, UPG_WYRM_BREATH);//call SetBuildUpgrEx( 1,1,1, UPG_WYRM_BREATH )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(0,0,1, MEAT_WAGON);//call CampaignAttackerEx( 0,0,1, MEAT_WAGON  )
			CampaignAttackerEx(4,4,4, ABOMINATION);//call CampaignAttackerEx( 4,4,4, ABOMINATION )
			CampaignAttackerEx(1,1,1, DEATH_KNIGHT);//call CampaignAttackerEx( 1,1,1, DEATH_KNIGHT)
			SuicideOnPlayerEx(M7,M7,M5,user);//call SuicideOnPlayerEx(M7,M7,M5,user)
			SetBuildUpgrEx(1,1,2, UPG_UNHOLY_STR);//call SetBuildUpgrEx( 1,1,2, UPG_UNHOLY_STR  )
			SetBuildUpgrEx(1,1,2, UPG_CR_ATTACK);//call SetBuildUpgrEx( 1,1,2, UPG_CR_ATTACK   )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(4,4,5, GARGOYLE);//call CampaignAttackerEx( 4,4,5, GARGOYLE    )
			CampaignAttackerEx(2,2,3, ABOMINATION);//call CampaignAttackerEx( 2,2,3, ABOMINATION )
			CampaignAttackerEx(1,1,1, MEAT_WAGON);//call CampaignAttackerEx( 1,1,1, MEAT_WAGON  )
			SuicideOnPlayerEx(M7,M7,M5,user);//call SuicideOnPlayerEx(M7,M7,M5,user)
			SetBuildUpgrEx(1,1,2, UPG_UNHOLY_ARMOR);//call SetBuildUpgrEx( 1,1,2, UPG_UNHOLY_ARMOR)
			SetBuildUpgrEx(1,1,2, UPG_CR_ARMOR);//call SetBuildUpgrEx( 1,1,2, UPG_CR_ARMOR    )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(1,1,1, DEATH_KNIGHT);//call CampaignAttackerEx( 1,1,1, DEATH_KNIGHT)
			CampaignAttackerEx(4,4,6, GHOUL);//call CampaignAttackerEx( 4,4,6, GHOUL       )
			CampaignAttackerEx(2,2,4, ABOMINATION);//call CampaignAttackerEx( 2,2,4, ABOMINATION )
			CampaignAttackerEx(0,0,1, MEAT_WAGON);//call CampaignAttackerEx( 0,0,1, MEAT_WAGON  )
			SuicideOnPlayerEx(M7,M7,M5,user);//call SuicideOnPlayerEx(M7,M7,M5,user)
			SetBuildUpgrEx(2,2,3, UPG_UNHOLY_STR);//call SetBuildUpgrEx( 2,2,3, UPG_UNHOLY_STR  )
			SetBuildUpgrEx(2,2,3, UPG_CR_ATTACK);//call SetBuildUpgrEx( 2,2,3, UPG_CR_ATTACK   )
			SetBuildUpgrEx(1,1,1, UPG_GHOUL_FRENZY);//call SetBuildUpgrEx( 1,1,1, UPG_GHOUL_FRENZY)
			SetBuildUpgrEx(1,1,1, UPG_PLAGUE);//call SetBuildUpgrEx( 1,1,1, UPG_PLAGUE      )
			//
			while (true) {//loop
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(3,3,4, GARGOYLE);//call CampaignAttackerEx( 3,3,4, GARGOYLE    )
				CampaignAttackerEx(1,1,2, FROST_WYRM);//call CampaignAttackerEx( 1,1,2, FROST_WYRM  )
				CampaignAttackerEx(1,1,1, BLK_SPHINX);//call CampaignAttackerEx( 1,1,1, BLK_SPHINX  )
				SuicideOnPlayerEx(M7,M7,M5,user);//call SuicideOnPlayerEx(M7,M7,M5,user)
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(1,1,1, DEATH_KNIGHT);//call CampaignAttackerEx( 1,1,1, DEATH_KNIGHT)
				CampaignAttackerEx(4,4,6, ABOMINATION);//call CampaignAttackerEx( 4,4,6, ABOMINATION )
				CampaignAttackerEx(1,1,2, MEAT_WAGON);//call CampaignAttackerEx( 1,1,2, MEAT_WAGON  )
				SuicideOnPlayerEx(M7,M7,M5,user);//call SuicideOnPlayerEx(M7,M7,M5,user)
				InitAssaultGroup();//call InitAssaultGroup()
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(5,5,7, GARGOYLE);//call CampaignAttackerEx( 5,5,7, GARGOYLE    )
				CampaignAttackerEx(3,3,4, BLK_SPHINX);//call CampaignAttackerEx( 3,3,4, BLK_SPHINX  )
				SuicideOnPlayerEx(M7,M7,M5,user);//call SuicideOnPlayerEx(M7,M7,M5,user)
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(1,1,1, DEATH_KNIGHT);//call CampaignAttackerEx( 1,1,1, DEATH_KNIGHT)
				CampaignAttackerEx(8,8,12,    GHOUL);//call CampaignAttackerEx( 8,8,12,    GHOUL   )
				CampaignAttackerEx(1,1,2, MEAT_WAGON);//call CampaignAttackerEx( 1,1,2, MEAT_WAGON  )
				SuicideOnPlayerEx(M7,M7,M5,user);//call SuicideOnPlayerEx(M7,M7,M5,user)
			}//endloop
		}//endfunction

	
	}
}

