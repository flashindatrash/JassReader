using System;
using System.Collections.Generic;

namespace Jass {

	public class U06x07Ai {

		//
		//
		//
		public const int LICH2 = 'U001';//constant integer LICH2 = 'U001'
		public static player user = PlayerEx(9);//player user = PlayerEx(9)
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(CommonAi.ZIGGURAT_1, null);//call CampaignAI(ZIGGURAT_1,null)
			SetReplacements(2, 2, 3);//call SetReplacements(2,2,3)
			SetWoodPeons(2);//call SetWoodPeons(2)
			SetBuildUnitEx(1, 1, 1, CommonAi.ACOLYTE);//call SetBuildUnitEx( 1, 1, 1, ACOLYTE           )
			SetBuildUnitEx(0, 0, 1, CommonAi.NECROPOLIS_1);//call SetBuildUnitEx( 0, 0, 1, NECROPOLIS_1      )
			SetBuildUnitEx(0, 0, 1, CommonAi.UNDEAD_MINE);//call SetBuildUnitEx( 0, 0, 1, UNDEAD_MINE       )
			SetBuildUnitEx(0, 0, 1, CommonAi.CRYPT);//call SetBuildUnitEx( 0, 0, 1, CRYPT             )
			SetBuildUnitEx(0, 0, 3, CommonAi.ZIGGURAT_1);//call SetBuildUnitEx( 0, 0, 3, ZIGGURAT_1        )
			SetBuildUnitEx(0, 0, 1, CommonAi.GRAVEYARD);//call SetBuildUnitEx( 0, 0, 1, GRAVEYARD         )
			SetBuildUnitEx(0, 0, 1, CommonAi.UNDEAD_ALTAR);//call SetBuildUnitEx( 0, 0, 1, UNDEAD_ALTAR      )
			SetBuildUnitEx(0, 0, 1, CommonAi.NECROPOLIS_2);//call SetBuildUnitEx( 0, 0, 1, NECROPOLIS_2      )
			SetBuildUnitEx(0, 0, 3, CommonAi.ZIGGURAT_2);//call SetBuildUnitEx( 0, 0, 3, ZIGGURAT_2        )
			SetBuildUnitEx(0, 0, 1, CommonAi.SLAUGHTERHOUSE);//call SetBuildUnitEx( 0, 0, 1, SLAUGHTERHOUSE    )
			SetBuildUnitEx(0, 0, 1, CommonAi.SAC_PIT);//call SetBuildUnitEx( 0, 0, 1, SAC_PIT           )
			SetBuildUnitEx(0, 0, 1, CommonAi.NECROPOLIS_3);//call SetBuildUnitEx( 0, 0, 1, NECROPOLIS_3      )
			SetBuildUnitEx(0, 0, 1, CommonAi.BONEYARD);//call SetBuildUnitEx( 0, 0, 1, BONEYARD          )
			SetBuildUnitEx(5, 5, 5, CommonAi.ACOLYTE);//call SetBuildUnitEx( 5, 5, 5, ACOLYTE           )
			CampaignDefenderEx(0, 0, 1, U06x07Ai.LICH2);//call CampaignDefenderEx( 0, 0, 1, LICH2         )
			CampaignDefenderEx(1, 1, 1, CommonAi.ABOMINATION);//call CampaignDefenderEx( 1, 1, 1, ABOMINATION   )
			CampaignDefenderEx(1, 1, 1, CommonAi.FROST_WYRM);//call CampaignDefenderEx( 1, 1, 1, FROST_WYRM    )
			CampaignDefenderEx(1, 1, 1, CommonAi.NECRO);//call CampaignDefenderEx( 1, 1, 1, NECRO         )
			SetBuildUpgrEx(1, 1, 1, CommonAi.UPG_BLK_SPHINX);//call SetBuildUpgrEx( 1,1,1, UPG_BLK_SPHINX  )
			SetBuildUpgrEx(1, 1, 1, CommonAi.UPG_EXHUME);//call SetBuildUpgrEx( 1,1,1, UPG_EXHUME      )
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_GHOUL_FRENZY);//call SetBuildUpgrEx( 0,0,1, UPG_GHOUL_FRENZY)
			SetBuildUpgrEx(1, 1, 1, CommonAi.UPG_FIEND_WEB);//call SetBuildUpgrEx( 1,1,1, UPG_FIEND_WEB   )
			SetBuildUpgrEx(1, 1, 1, CommonAi.UPG_SKEL_LIFE);//call SetBuildUpgrEx( 1,1,1, UPG_SKEL_LIFE   )
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_SKEL_MASTERY);//call SetBuildUpgrEx( 0,0,1, UPG_SKEL_MASTERY)
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_NECROS);//call SetBuildUpgrEx( 0,0,1, UPG_NECROS      )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(3, 3, 5, CommonAi.ABOMINATION);//call CampaignAttackerEx( 3,3,5, ABOMINATION )
			SuicideOnPlayerEx(CommonAi.M3, CommonAi.M3, CommonAi.M2, U08_tealAi.user);//call SuicideOnPlayerEx(M3,M3,M2,user)
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_UNHOLY_STR);//call SetBuildUpgrEx( 0,0,1, UPG_UNHOLY_STR  )
			SetBuildUpgrEx(0, 1, 1, CommonAi.UPG_CR_ATTACK);//call SetBuildUpgrEx( 0,1,1, UPG_CR_ATTACK   )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(3, 3, 4, CommonAi.GARGOYLE);//call CampaignAttackerEx( 3,3,4, GARGOYLE    )
			CampaignAttackerEx(0, 0, 1, CommonAi.FROST_WYRM);//call CampaignAttackerEx( 0,0,1, FROST_WYRM  )
			SuicideOnPlayerEx(CommonAi.M7, CommonAi.M7, CommonAi.M6, U08_tealAi.user);//call SuicideOnPlayerEx(M7,M7,M6,user)
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_UNHOLY_ARMOR);//call SetBuildUpgrEx( 0,0,1, UPG_UNHOLY_ARMOR)
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_CR_ARMOR);//call SetBuildUpgrEx( 0,0,1, UPG_CR_ARMOR    )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2, 2, 4, CommonAi.ABOMINATION);//call CampaignAttackerEx( 2,2,4, ABOMINATION )
			CampaignAttackerEx(2, 2, 5, CommonAi.NECRO);//call CampaignAttackerEx( 2,2,5, NECRO       )
			CampaignAttackerEx(1, 1, 1, U06x07Ai.LICH2);//call CampaignAttackerEx( 1,1,1, LICH2       )
			SuicideOnPlayerEx(CommonAi.M6, CommonAi.M6, CommonAi.M5, U08_tealAi.user);//call SuicideOnPlayerEx(M6,M6,M5,user)
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_PLAGUE);//call SetBuildUpgrEx( 0,0,1, UPG_PLAGUE      )
			SetBuildUpgrEx(1, 1, 1, CommonAi.UPG_GHOUL_FRENZY);//call SetBuildUpgrEx( 1,1,1, UPG_GHOUL_FRENZY)
			SetBuildUpgrEx(1, 1, 1, CommonAi.UPG_WYRM_BREATH);//call SetBuildUpgrEx( 1,1,1, UPG_WYRM_BREATH )
			SetBuildUpgrEx(1, 1, 1, CommonAi.UPG_SKEL_MASTERY);//call SetBuildUpgrEx( 1,1,1, UPG_SKEL_MASTERY)
			SetBuildUpgrEx(1, 1, 2, CommonAi.UPG_NECROS);//call SetBuildUpgrEx( 1,1,2, UPG_NECROS      )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(4, 4, 6, CommonAi.ABOMINATION);//call CampaignAttackerEx( 4,4,6, ABOMINATION )
			CampaignAttackerEx(3, 3, 5, CommonAi.CRYPT_FIEND);//call CampaignAttackerEx( 3,3,5, CRYPT_FIEND )
			CampaignAttackerEx(1, 1, 2, CommonAi.MEAT_WAGON);//call CampaignAttackerEx( 1,1,2, MEAT_WAGON  )
			SuicideOnPlayerEx(CommonAi.M7, CommonAi.M7, CommonAi.M6, U08_tealAi.user);//call SuicideOnPlayerEx(M7,M7,M6,user)
			SetBuildUpgrEx(1, 1, 2, CommonAi.UPG_UNHOLY_STR);//call SetBuildUpgrEx( 1,1,2, UPG_UNHOLY_STR  )
			SetBuildUpgrEx(1, 1, 2, CommonAi.UPG_CR_ATTACK);//call SetBuildUpgrEx( 1,1,2, UPG_CR_ATTACK   )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2, 2, 3, CommonAi.GARGOYLE);//call CampaignAttackerEx( 2,2,3, GARGOYLE    )
			CampaignAttackerEx(1, 1, 2, CommonAi.FROST_WYRM);//call CampaignAttackerEx( 1,1,2, FROST_WYRM  )
			SuicideOnPlayerEx(CommonAi.M6, CommonAi.M6, CommonAi.M5, U08_tealAi.user);//call SuicideOnPlayerEx(M6,M6,M5,user)
			SetBuildUpgrEx(1, 1, 2, CommonAi.UPG_UNHOLY_ARMOR);//call SetBuildUpgrEx( 1,1,2, UPG_UNHOLY_ARMOR)
			SetBuildUpgrEx(1, 1, 2, CommonAi.UPG_CR_ARMOR);//call SetBuildUpgrEx( 1,1,2, UPG_CR_ARMOR    )
			SetBuildUpgrEx(2, 2, 2, CommonAi.UPG_NECROS);//call SetBuildUpgrEx( 2,2,2, UPG_NECROS      )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(4, 4, 6, CommonAi.NECRO);//call CampaignAttackerEx( 4,4,6, NECRO       )
			CampaignAttackerEx(2, 2, 2, CommonAi.MEAT_WAGON);//call CampaignAttackerEx( 2,2,2, MEAT_WAGON  )
			CampaignAttackerEx(1, 1, 1, U06x07Ai.LICH2);//call CampaignAttackerEx( 1,1,1, LICH2       )
			SuicideOnPlayerEx(CommonAi.M7, CommonAi.M7, CommonAi.M6, U08_tealAi.user);//call SuicideOnPlayerEx(M7,M7,M6,user)
			SetBuildUpgrEx(2, 2, 3, CommonAi.UPG_UNHOLY_STR);//call SetBuildUpgrEx( 2,2,3, UPG_UNHOLY_STR  )
			SetBuildUpgrEx(2, 2, 3, CommonAi.UPG_CR_ATTACK);//call SetBuildUpgrEx( 2,2,3, UPG_CR_ATTACK   )
			SetBuildUpgrEx(1, 1, 1, CommonAi.UPG_GHOUL_FRENZY);//call SetBuildUpgrEx( 1,1,1, UPG_GHOUL_FRENZY)
			SetBuildUpgrEx(1, 1, 1, CommonAi.UPG_PLAGUE);//call SetBuildUpgrEx( 1,1,1, UPG_PLAGUE      )
			//
			while (true) {//loop
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(6, 6, 8, CommonAi.ABOMINATION);//call CampaignAttackerEx( 6,6,8, ABOMINATION )
				CampaignAttackerEx(2, 2, 3, CommonAi.CRYPT_FIEND);//call CampaignAttackerEx( 2,2,3, CRYPT_FIEND )
				SuicideOnPlayerEx(CommonAi.M7, CommonAi.M7, CommonAi.M6, U08_tealAi.user);//call SuicideOnPlayerEx(M7,M7,M6,user)
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(3, 3, 4, CommonAi.GARGOYLE);//call CampaignAttackerEx( 3,3,4, GARGOYLE    )
				CampaignAttackerEx(2, 2, 3, CommonAi.FROST_WYRM);//call CampaignAttackerEx( 2,2,3, FROST_WYRM  )
				SuicideOnPlayerEx(CommonAi.M7, CommonAi.M7, CommonAi.M6, U08_tealAi.user);//call SuicideOnPlayerEx(M7,M7,M6,user)
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(2, 2, 3, CommonAi.ABOMINATION);//call CampaignAttackerEx( 2,2,3, ABOMINATION )
				CampaignAttackerEx(2, 2, 4, CommonAi.NECRO);//call CampaignAttackerEx( 2,2,4, NECRO       )
				CampaignAttackerEx(1, 1, 2, CommonAi.MEAT_WAGON);//call CampaignAttackerEx( 1,1,2, MEAT_WAGON  )
				CampaignAttackerEx(1, 1, 1, U06x07Ai.LICH2);//call CampaignAttackerEx( 1,1,1, LICH2       )
				SuicideOnPlayerEx(CommonAi.M7, CommonAi.M7, CommonAi.M6, U08_tealAi.user);//call SuicideOnPlayerEx(M7,M7,M6,user)
			}//endloop
		}//endfunction

	
	}
}

