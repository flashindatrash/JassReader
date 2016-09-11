using System;
using System.Collections.Generic;

namespace Jass {

	public class N08x07Ai {

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
			SetBuildUnitEx(5, 5, 5, ACOLYTE);//call SetBuildUnitEx( 5, 5, 5, ACOLYTE           )
			SetBuildUnitEx(2, 2, 2, UNDEAD_BARGE);//call SetBuildUnitEx( 2, 2, 2, UNDEAD_BARGE      )
			CampaignDefenderEx(0, 0, 1, ABOMINATION);//call CampaignDefenderEx( 0, 0, 1, ABOMINATION   )
			CampaignDefenderEx(1, 1, 1, GARGOYLE);//call CampaignDefenderEx( 1, 1, 1, GARGOYLE      )
			CampaignDefenderEx(1, 1, 1, CRYPT_FIEND);//call CampaignDefenderEx( 1, 1, 1, CRYPT_FIEND   )
			CampaignDefenderEx(1, 1, 1, OBS_STATUE);//call CampaignDefenderEx( 1, 1, 1, OBS_STATUE    )
			CampaignDefenderEx(0, 0, 1, DEATH_KNIGHT);//call CampaignDefenderEx( 0, 0, 1, DEATH_KNIGHT  )
			SetBuildUpgrEx(1, 1, 1, UPG_BLK_SPHINX);//call SetBuildUpgrEx( 1, 1, 1, UPG_BLK_SPHINX    )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(3,3,4, GARGOYLE);//call CampaignAttackerEx( 3,3,4, GARGOYLE    )
			CampaignAttackerEx(1,1,2, BLK_SPHINX);//call CampaignAttackerEx( 1,1,2, BLK_SPHINX  )
			SuicideOnPlayerEx(M8,M8,M3,user);//call SuicideOnPlayerEx(M8,M8,M3,user)
			SetBuildUpgrEx(0,0,1, UPG_UNHOLY_STR);//call SetBuildUpgrEx( 0,0,1, UPG_UNHOLY_STR  )
			SetBuildUpgrEx(0,0,1, UPG_CR_ATTACK);//call SetBuildUpgrEx( 0,0,1, UPG_CR_ATTACK   )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(4,4,5, GHOUL);//call CampaignAttackerEx( 4,4,5, GHOUL       )
			CampaignAttackerEx(2,2,3, CRYPT_FIEND);//call CampaignAttackerEx( 2,2,3, CRYPT_FIEND )
			CampaignAttackerEx(0,0,1, DEATH_KNIGHT);//call CampaignAttackerEx( 0,0,1, DEATH_KNIGHT)
			SuicideOnPlayerEx(M7,M7,M5,user);//call SuicideOnPlayerEx(M7,M7,M5,user)
			SetBuildUpgrEx(0,0,1, UPG_UNHOLY_ARMOR);//call SetBuildUpgrEx( 0,0,1, UPG_UNHOLY_ARMOR)
			SetBuildUpgrEx(0,0,1, UPG_CR_ARMOR);//call SetBuildUpgrEx( 0,0,1, UPG_CR_ARMOR    )
			SetBuildUpgrEx(1,1,2, UPG_NECROS);//call SetBuildUpgrEx( 1,1,2, UPG_NECROS      )
			SetBuildUpgrEx(1,1,2, UPG_BANSHEE);//call SetBuildUpgrEx( 1,1,2, UPG_BANSHEE     )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(3,3,5, GARGOYLE);//call CampaignAttackerEx( 3,3,5, GARGOYLE    )
			CampaignAttackerEx(1,1,2, FROST_WYRM);//call CampaignAttackerEx( 1,1,2, FROST_WYRM  )
			SuicideOnPlayerEx(M7,M7,M5,user);//call SuicideOnPlayerEx(M7,M7,M5,user)
			SetBuildUpgrEx(0,0,1, UPG_PLAGUE);//call SetBuildUpgrEx( 0,0,1, UPG_PLAGUE        )
			SetBuildUpgrEx(1,1,2, UPG_UNHOLY_STR);//call SetBuildUpgrEx( 1,1,2, UPG_UNHOLY_STR    )
			SetBuildUpgrEx(1,1,2, UPG_CR_ATTACK);//call SetBuildUpgrEx( 1,1,2, UPG_CR_ATTACK     )
			SetBuildUpgrEx(0,0,1, UPG_SKEL_MASTERY);//call SetBuildUpgrEx( 0,0,1, UPG_SKEL_MASTERY  )
			SetBuildUpgrEx(0,0,1, UPG_WYRM_BREATH);//call SetBuildUpgrEx( 0,0,1, UPG_WYRM_BREATH   )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(4,4,6, NECRO);//call CampaignAttackerEx( 4,4,6, NECRO       )
			CampaignAttackerEx(1,1,2, MEAT_WAGON);//call CampaignAttackerEx( 1,1,2, MEAT_WAGON  )
			CampaignAttackerEx(1,1,1, DEATH_KNIGHT);//call CampaignAttackerEx( 1,1,1, DEATH_KNIGHT)
			SuicideOnPlayerEx(M7,M7,M5,user);//call SuicideOnPlayerEx(M7,M7,M5,user)
			SetBuildUpgrEx(1,1,2, UPG_UNHOLY_ARMOR);//call SetBuildUpgrEx( 1,1,2, UPG_UNHOLY_ARMOR)
			SetBuildUpgrEx(1,1,2, UPG_CR_ARMOR);//call SetBuildUpgrEx( 1,1,2, UPG_CR_ARMOR    )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(3,3,5, GARGOYLE);//call CampaignAttackerEx( 3,3,5, GARGOYLE    )
			CampaignAttackerEx(1,1,3, BLK_SPHINX);//call CampaignAttackerEx( 1,1,3, BLK_SPHINX  )
			SuicideOnPlayerEx(M7,M7,M5,user);//call SuicideOnPlayerEx(M7,M7,M5,user)
			SetBuildUpgrEx(2,2,3, UPG_UNHOLY_STR);//call SetBuildUpgrEx( 2,2,3, UPG_UNHOLY_STR  )
			SetBuildUpgrEx(2,2,3, UPG_CR_ATTACK);//call SetBuildUpgrEx( 2,2,3, UPG_CR_ATTACK   )
			SetBuildUpgrEx(1,1,1, UPG_GHOUL_FRENZY);//call SetBuildUpgrEx( 1,1,1, UPG_GHOUL_FRENZY)
			SetBuildUpgrEx(1,1,1, UPG_SKEL_MASTERY);//call SetBuildUpgrEx( 1,1,1, UPG_SKEL_MASTERY)
			SetBuildUpgrEx(1,1,1, UPG_WYRM_BREATH);//call SetBuildUpgrEx( 1,1,1, UPG_WYRM_BREATH )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(3,3,4, ABOMINATION);//call CampaignAttackerEx( 3,3,4, ABOMINATION )
			CampaignAttackerEx(0,0,2, CRYPT_FIEND);//call CampaignAttackerEx( 0,0,2, CRYPT_FIEND )
			CampaignAttackerEx(1,1,1, DEATH_KNIGHT);//call CampaignAttackerEx( 1,1,1, DEATH_KNIGHT)
			SuicideOnPlayerEx(M7,M7,M5,user);//call SuicideOnPlayerEx(M7,M7,M5,user)
			SetBuildUpgrEx(2,2,3, UPG_UNHOLY_ARMOR);//call SetBuildUpgrEx( 2,2,3, UPG_UNHOLY_ARMOR)
			SetBuildUpgrEx(2,2,3, UPG_CR_ARMOR);//call SetBuildUpgrEx( 2,2,3, UPG_CR_ARMOR    )
			SetBuildUpgrEx(1,1,1, UPG_PLAGUE);//call SetBuildUpgrEx( 1,1,1, UPG_PLAGUE      )
			SetBuildUpgrEx(2,2,2, UPG_NECROS);//call SetBuildUpgrEx( 2,2,2, UPG_NECROS      )
			SetBuildUpgrEx(2,2,2, UPG_BANSHEE);//call SetBuildUpgrEx( 2,2,2, UPG_BANSHEE     )
			//
			while (true) {//loop
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(2,2,3, FROST_WYRM);//call CampaignAttackerEx( 2,2,3, FROST_WYRM  )
				SuicideOnPlayerEx(M7,M7,M5,user);//call SuicideOnPlayerEx(M7,M7,M5,user)
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(2,2,4, ABOMINATION);//call CampaignAttackerEx( 2,2,4, ABOMINATION )
				CampaignAttackerEx(2,2,3, CRYPT_FIEND);//call CampaignAttackerEx( 2,2,3, CRYPT_FIEND )
				CampaignAttackerEx(1,1,2, MEAT_WAGON);//call CampaignAttackerEx( 1,1,2, MEAT_WAGON  )
				SuicideOnPlayerEx(M7,M7,M5,user);//call SuicideOnPlayerEx(M7,M7,M5,user)
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(2,2,4, GARGOYLE);//call CampaignAttackerEx( 2,2,4, GARGOYLE    )
				CampaignAttackerEx(1,1,2, FROST_WYRM);//call CampaignAttackerEx( 1,1,2, FROST_WYRM  )
				CampaignAttackerEx(1,1,2, BLK_SPHINX);//call CampaignAttackerEx( 1,1,2, BLK_SPHINX  )
				SuicideOnPlayerEx(M7,M7,M5,user);//call SuicideOnPlayerEx(M7,M7,M5,user)
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(2,2,4, NECRO);//call CampaignAttackerEx( 2,2,4, NECRO       )
				CampaignAttackerEx(2,2,3, BANSHEE);//call CampaignAttackerEx( 2,2,3, BANSHEE     )
				CampaignAttackerEx(1,1,1, DEATH_KNIGHT);//call CampaignAttackerEx( 1,1,1, DEATH_KNIGHT)
				SuicideOnPlayerEx(M7,M7,M5,user);//call SuicideOnPlayerEx(M7,M7,M5,user)
			}//endloop
		}//endfunction

	
	}
}

