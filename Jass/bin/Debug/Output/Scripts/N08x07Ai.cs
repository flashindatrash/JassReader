using System;
using System.Collections.Generic;

namespace Jass {

	public class N08x07Ai {

		//
		//
		//
		public static player user = PlayerEx(2);//player user = PlayerEx(2)
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(CommonAi.ZIGGURAT_1, null);//call CampaignAI(ZIGGURAT_1,null)
			SetReplacements(1, 1, 3);//call SetReplacements(1,1,3)
			DoCampaignFarms(false);//call DoCampaignFarms(false)
			SetWoodPeons(2);//call SetWoodPeons(2)
			SetBuildUnitEx(5, 5, 5, CommonAi.ACOLYTE);//call SetBuildUnitEx( 5, 5, 5, ACOLYTE           )
			SetBuildUnitEx(2, 2, 2, CommonAi.UNDEAD_BARGE);//call SetBuildUnitEx( 2, 2, 2, UNDEAD_BARGE      )
			CampaignDefenderEx(0, 0, 1, CommonAi.ABOMINATION);//call CampaignDefenderEx( 0, 0, 1, ABOMINATION   )
			CampaignDefenderEx(1, 1, 1, CommonAi.GARGOYLE);//call CampaignDefenderEx( 1, 1, 1, GARGOYLE      )
			CampaignDefenderEx(1, 1, 1, CommonAi.CRYPT_FIEND);//call CampaignDefenderEx( 1, 1, 1, CRYPT_FIEND   )
			CampaignDefenderEx(1, 1, 1, CommonAi.OBS_STATUE);//call CampaignDefenderEx( 1, 1, 1, OBS_STATUE    )
			CampaignDefenderEx(0, 0, 1, CommonAi.DEATH_KNIGHT);//call CampaignDefenderEx( 0, 0, 1, DEATH_KNIGHT  )
			SetBuildUpgrEx(1, 1, 1, CommonAi.UPG_BLK_SPHINX);//call SetBuildUpgrEx( 1, 1, 1, UPG_BLK_SPHINX    )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(3, 3, 4, CommonAi.GARGOYLE);//call CampaignAttackerEx( 3,3,4, GARGOYLE    )
			CampaignAttackerEx(1, 1, 2, CommonAi.BLK_SPHINX);//call CampaignAttackerEx( 1,1,2, BLK_SPHINX  )
			SuicideOnPlayerEx(CommonAi.M8, CommonAi.M8, CommonAi.M3, U08_tealAi.user);//call SuicideOnPlayerEx(M8,M8,M3,user)
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_UNHOLY_STR);//call SetBuildUpgrEx( 0,0,1, UPG_UNHOLY_STR  )
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_CR_ATTACK);//call SetBuildUpgrEx( 0,0,1, UPG_CR_ATTACK   )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(4, 4, 5, CommonAi.GHOUL);//call CampaignAttackerEx( 4,4,5, GHOUL       )
			CampaignAttackerEx(2, 2, 3, CommonAi.CRYPT_FIEND);//call CampaignAttackerEx( 2,2,3, CRYPT_FIEND )
			CampaignAttackerEx(0, 0, 1, CommonAi.DEATH_KNIGHT);//call CampaignAttackerEx( 0,0,1, DEATH_KNIGHT)
			SuicideOnPlayerEx(CommonAi.M7, CommonAi.M7, CommonAi.M5, U08_tealAi.user);//call SuicideOnPlayerEx(M7,M7,M5,user)
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_UNHOLY_ARMOR);//call SetBuildUpgrEx( 0,0,1, UPG_UNHOLY_ARMOR)
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_CR_ARMOR);//call SetBuildUpgrEx( 0,0,1, UPG_CR_ARMOR    )
			SetBuildUpgrEx(1, 1, 2, CommonAi.UPG_NECROS);//call SetBuildUpgrEx( 1,1,2, UPG_NECROS      )
			SetBuildUpgrEx(1, 1, 2, CommonAi.UPG_BANSHEE);//call SetBuildUpgrEx( 1,1,2, UPG_BANSHEE     )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(3, 3, 5, CommonAi.GARGOYLE);//call CampaignAttackerEx( 3,3,5, GARGOYLE    )
			CampaignAttackerEx(1, 1, 2, CommonAi.FROST_WYRM);//call CampaignAttackerEx( 1,1,2, FROST_WYRM  )
			SuicideOnPlayerEx(CommonAi.M7, CommonAi.M7, CommonAi.M5, U08_tealAi.user);//call SuicideOnPlayerEx(M7,M7,M5,user)
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_PLAGUE);//call SetBuildUpgrEx( 0,0,1, UPG_PLAGUE        )
			SetBuildUpgrEx(1, 1, 2, CommonAi.UPG_UNHOLY_STR);//call SetBuildUpgrEx( 1,1,2, UPG_UNHOLY_STR    )
			SetBuildUpgrEx(1, 1, 2, CommonAi.UPG_CR_ATTACK);//call SetBuildUpgrEx( 1,1,2, UPG_CR_ATTACK     )
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_SKEL_MASTERY);//call SetBuildUpgrEx( 0,0,1, UPG_SKEL_MASTERY  )
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_WYRM_BREATH);//call SetBuildUpgrEx( 0,0,1, UPG_WYRM_BREATH   )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(4, 4, 6, CommonAi.NECRO);//call CampaignAttackerEx( 4,4,6, NECRO       )
			CampaignAttackerEx(1, 1, 2, CommonAi.MEAT_WAGON);//call CampaignAttackerEx( 1,1,2, MEAT_WAGON  )
			CampaignAttackerEx(1, 1, 1, CommonAi.DEATH_KNIGHT);//call CampaignAttackerEx( 1,1,1, DEATH_KNIGHT)
			SuicideOnPlayerEx(CommonAi.M7, CommonAi.M7, CommonAi.M5, U08_tealAi.user);//call SuicideOnPlayerEx(M7,M7,M5,user)
			SetBuildUpgrEx(1, 1, 2, CommonAi.UPG_UNHOLY_ARMOR);//call SetBuildUpgrEx( 1,1,2, UPG_UNHOLY_ARMOR)
			SetBuildUpgrEx(1, 1, 2, CommonAi.UPG_CR_ARMOR);//call SetBuildUpgrEx( 1,1,2, UPG_CR_ARMOR    )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(3, 3, 5, CommonAi.GARGOYLE);//call CampaignAttackerEx( 3,3,5, GARGOYLE    )
			CampaignAttackerEx(1, 1, 3, CommonAi.BLK_SPHINX);//call CampaignAttackerEx( 1,1,3, BLK_SPHINX  )
			SuicideOnPlayerEx(CommonAi.M7, CommonAi.M7, CommonAi.M5, U08_tealAi.user);//call SuicideOnPlayerEx(M7,M7,M5,user)
			SetBuildUpgrEx(2, 2, 3, CommonAi.UPG_UNHOLY_STR);//call SetBuildUpgrEx( 2,2,3, UPG_UNHOLY_STR  )
			SetBuildUpgrEx(2, 2, 3, CommonAi.UPG_CR_ATTACK);//call SetBuildUpgrEx( 2,2,3, UPG_CR_ATTACK   )
			SetBuildUpgrEx(1, 1, 1, CommonAi.UPG_GHOUL_FRENZY);//call SetBuildUpgrEx( 1,1,1, UPG_GHOUL_FRENZY)
			SetBuildUpgrEx(1, 1, 1, CommonAi.UPG_SKEL_MASTERY);//call SetBuildUpgrEx( 1,1,1, UPG_SKEL_MASTERY)
			SetBuildUpgrEx(1, 1, 1, CommonAi.UPG_WYRM_BREATH);//call SetBuildUpgrEx( 1,1,1, UPG_WYRM_BREATH )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(3, 3, 4, CommonAi.ABOMINATION);//call CampaignAttackerEx( 3,3,4, ABOMINATION )
			CampaignAttackerEx(0, 0, 2, CommonAi.CRYPT_FIEND);//call CampaignAttackerEx( 0,0,2, CRYPT_FIEND )
			CampaignAttackerEx(1, 1, 1, CommonAi.DEATH_KNIGHT);//call CampaignAttackerEx( 1,1,1, DEATH_KNIGHT)
			SuicideOnPlayerEx(CommonAi.M7, CommonAi.M7, CommonAi.M5, U08_tealAi.user);//call SuicideOnPlayerEx(M7,M7,M5,user)
			SetBuildUpgrEx(2, 2, 3, CommonAi.UPG_UNHOLY_ARMOR);//call SetBuildUpgrEx( 2,2,3, UPG_UNHOLY_ARMOR)
			SetBuildUpgrEx(2, 2, 3, CommonAi.UPG_CR_ARMOR);//call SetBuildUpgrEx( 2,2,3, UPG_CR_ARMOR    )
			SetBuildUpgrEx(1, 1, 1, CommonAi.UPG_PLAGUE);//call SetBuildUpgrEx( 1,1,1, UPG_PLAGUE      )
			SetBuildUpgrEx(2, 2, 2, CommonAi.UPG_NECROS);//call SetBuildUpgrEx( 2,2,2, UPG_NECROS      )
			SetBuildUpgrEx(2, 2, 2, CommonAi.UPG_BANSHEE);//call SetBuildUpgrEx( 2,2,2, UPG_BANSHEE     )
			//
			while (true) {//loop
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(2, 2, 3, CommonAi.FROST_WYRM);//call CampaignAttackerEx( 2,2,3, FROST_WYRM  )
				SuicideOnPlayerEx(CommonAi.M7, CommonAi.M7, CommonAi.M5, U08_tealAi.user);//call SuicideOnPlayerEx(M7,M7,M5,user)
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(2, 2, 4, CommonAi.ABOMINATION);//call CampaignAttackerEx( 2,2,4, ABOMINATION )
				CampaignAttackerEx(2, 2, 3, CommonAi.CRYPT_FIEND);//call CampaignAttackerEx( 2,2,3, CRYPT_FIEND )
				CampaignAttackerEx(1, 1, 2, CommonAi.MEAT_WAGON);//call CampaignAttackerEx( 1,1,2, MEAT_WAGON  )
				SuicideOnPlayerEx(CommonAi.M7, CommonAi.M7, CommonAi.M5, U08_tealAi.user);//call SuicideOnPlayerEx(M7,M7,M5,user)
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(2, 2, 4, CommonAi.GARGOYLE);//call CampaignAttackerEx( 2,2,4, GARGOYLE    )
				CampaignAttackerEx(1, 1, 2, CommonAi.FROST_WYRM);//call CampaignAttackerEx( 1,1,2, FROST_WYRM  )
				CampaignAttackerEx(1, 1, 2, CommonAi.BLK_SPHINX);//call CampaignAttackerEx( 1,1,2, BLK_SPHINX  )
				SuicideOnPlayerEx(CommonAi.M7, CommonAi.M7, CommonAi.M5, U08_tealAi.user);//call SuicideOnPlayerEx(M7,M7,M5,user)
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(2, 2, 4, CommonAi.NECRO);//call CampaignAttackerEx( 2,2,4, NECRO       )
				CampaignAttackerEx(2, 2, 3, CommonAi.BANSHEE);//call CampaignAttackerEx( 2,2,3, BANSHEE     )
				CampaignAttackerEx(1, 1, 1, CommonAi.DEATH_KNIGHT);//call CampaignAttackerEx( 1,1,1, DEATH_KNIGHT)
				SuicideOnPlayerEx(CommonAi.M7, CommonAi.M7, CommonAi.M5, U08_tealAi.user);//call SuicideOnPlayerEx(M7,M7,M5,user)
			}//endloop
		}//endfunction

	
	}
}

