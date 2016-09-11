using System;
using System.Collections.Generic;

namespace Jass {

	public class U06x06Ai {

		//
		//
		//
		public const int LICH2 = 'U000';//constant integer LICH2 = 'U000'
		public static player user = PlayerEx(2);//player user = PlayerEx(2)
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(ZIGGURAT_1,null);//call CampaignAI(ZIGGURAT_1,null)
			SetReplacements(2,2,3);//call SetReplacements(2,2,3)
			SetWoodPeons(2);//call SetWoodPeons(2)
			SetBuildUnitEx(1, 1, 1, ACOLYTE);//call SetBuildUnitEx( 1, 1, 1, ACOLYTE           )
			SetBuildUnitEx(0, 0, 1, NECROPOLIS_1);//call SetBuildUnitEx( 0, 0, 1, NECROPOLIS_1      )
			SetBuildUnitEx(0, 0, 1, UNDEAD_MINE);//call SetBuildUnitEx( 0, 0, 1, UNDEAD_MINE       )
			SetBuildUnitEx(0, 0, 1, CRYPT);//call SetBuildUnitEx( 0, 0, 1, CRYPT             )
			SetBuildUnitEx(0, 0, 3, ZIGGURAT_1);//call SetBuildUnitEx( 0, 0, 3, ZIGGURAT_1        )
			SetBuildUnitEx(0, 0, 1, GRAVEYARD);//call SetBuildUnitEx( 0, 0, 1, GRAVEYARD         )
			SetBuildUnitEx(0, 0, 1, UNDEAD_ALTAR);//call SetBuildUnitEx( 0, 0, 1, UNDEAD_ALTAR      )
			SetBuildUnitEx(0, 0, 1, NECROPOLIS_2);//call SetBuildUnitEx( 0, 0, 1, NECROPOLIS_2      )
			SetBuildUnitEx(0, 0, 3, ZIGGURAT_2);//call SetBuildUnitEx( 0, 0, 3, ZIGGURAT_2        )
			SetBuildUnitEx(0, 0, 1, SLAUGHTERHOUSE);//call SetBuildUnitEx( 0, 0, 1, SLAUGHTERHOUSE    )
			SetBuildUnitEx(0, 0, 1, SAC_PIT);//call SetBuildUnitEx( 0, 0, 1, SAC_PIT           )
			SetBuildUnitEx(0, 0, 1, NECROPOLIS_3);//call SetBuildUnitEx( 0, 0, 1, NECROPOLIS_3      )
			SetBuildUnitEx(0, 0, 1, BONEYARD);//call SetBuildUnitEx( 0, 0, 1, BONEYARD          )
			SetBuildUnitEx(5, 5, 5, ACOLYTE);//call SetBuildUnitEx( 5, 5, 5, ACOLYTE           )
			SetBuildUpgrEx(1,1,1, UPG_BLK_SPHINX);//call SetBuildUpgrEx( 1,1,1, UPG_BLK_SPHINX  )
			CampaignDefenderEx(0, 0, 1, LICH2);//call CampaignDefenderEx( 0, 0, 1, LICH2         )
			CampaignDefenderEx(1, 1, 1, GHOUL);//call CampaignDefenderEx( 1, 1, 1, GHOUL         )
			CampaignDefenderEx(1, 1, 1, OBS_STATUE);//call CampaignDefenderEx( 1, 1, 1, OBS_STATUE    )
			CampaignDefenderEx(1, 1, 1, GARGOYLE);//call CampaignDefenderEx( 1, 1, 1, GARGOYLE      )
			CampaignDefenderEx(1, 1, 1, BLK_SPHINX);//call CampaignDefenderEx( 1, 1, 1, BLK_SPHINX    )
			SetBuildUpgrEx(1,1,1, UPG_EXHUME);//call SetBuildUpgrEx( 1,1,1, UPG_EXHUME      )
			SetBuildUpgrEx(0,0,1, UPG_GHOUL_FRENZY);//call SetBuildUpgrEx( 0,0,1, UPG_GHOUL_FRENZY)
			SetBuildUpgrEx(1,1,1, UPG_FIEND_WEB);//call SetBuildUpgrEx( 1,1,1, UPG_FIEND_WEB   )
			SetBuildUpgrEx(1,1,1, UPG_SKEL_LIFE);//call SetBuildUpgrEx( 1,1,1, UPG_SKEL_LIFE   )
			SetBuildUpgrEx(0,0,1, UPG_SKEL_MASTERY);//call SetBuildUpgrEx( 0,0,1, UPG_SKEL_MASTERY)
			SetBuildUpgrEx(0,0,1, UPG_NECROS);//call SetBuildUpgrEx( 0,0,1, UPG_NECROS      )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(5,5,6, GARGOYLE);//call CampaignAttackerEx( 5,5,6, GARGOYLE    )
			SuicideOnPlayerEx(M5,M5,M4,user);//call SuicideOnPlayerEx(M5,M5,M4,user)
			SetBuildUpgrEx(0,0,1, UPG_UNHOLY_STR);//call SetBuildUpgrEx( 0,0,1, UPG_UNHOLY_STR  )
			SetBuildUpgrEx(0,1,1, UPG_CR_ATTACK);//call SetBuildUpgrEx( 0,1,1, UPG_CR_ATTACK   )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(1,1,2, MEAT_WAGON);//call CampaignAttackerEx( 1,1,2, MEAT_WAGON  )
			CampaignAttackerEx(4,4,6, GHOUL);//call CampaignAttackerEx( 4,4,6, GHOUL       )
			CampaignAttackerEx(1,1,1, LICH2);//call CampaignAttackerEx( 1,1,1, LICH2       )
			SuicideOnPlayerEx(M7,M7,M6,user);//call SuicideOnPlayerEx(M7,M7,M6,user)
			SetBuildUpgrEx(0,0,1, UPG_UNHOLY_ARMOR);//call SetBuildUpgrEx( 0,0,1, UPG_UNHOLY_ARMOR)
			SetBuildUpgrEx(0,0,1, UPG_CR_ARMOR);//call SetBuildUpgrEx( 0,0,1, UPG_CR_ARMOR    )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(6,6,8, GHOUL);//call CampaignAttackerEx( 6,6,8, GHOUL       )
			CampaignAttackerEx(3,3,5, NECRO);//call CampaignAttackerEx( 3,3,5, NECRO       )
			CampaignAttackerEx(1,1,1, BLK_SPHINX);//call CampaignAttackerEx( 1,1,1, BLK_SPHINX  )
			SuicideOnPlayerEx(M6,M6,M5,user);//call SuicideOnPlayerEx(M6,M6,M5,user)
			SetBuildUpgrEx(0,0,1, UPG_PLAGUE);//call SetBuildUpgrEx( 0,0,1, UPG_PLAGUE      )
			SetBuildUpgrEx(1,1,1, UPG_GHOUL_FRENZY);//call SetBuildUpgrEx( 1,1,1, UPG_GHOUL_FRENZY)
			SetBuildUpgrEx(1,1,1, UPG_WYRM_BREATH);//call SetBuildUpgrEx( 1,1,1, UPG_WYRM_BREATH )
			SetBuildUpgrEx(1,1,1, UPG_SKEL_MASTERY);//call SetBuildUpgrEx( 1,1,1, UPG_SKEL_MASTERY)
			SetBuildUpgrEx(1,1,2, UPG_NECROS);//call SetBuildUpgrEx( 1,1,2, UPG_NECROS      )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(3,3,4, GARGOYLE);//call CampaignAttackerEx( 3,3,4, GARGOYLE    )
			CampaignAttackerEx(1,1,2, FROST_WYRM);//call CampaignAttackerEx( 1,1,2, FROST_WYRM  )
			CampaignAttackerEx(2,2,2, BLK_SPHINX);//call CampaignAttackerEx( 2,2,2, BLK_SPHINX  )
			SuicideOnPlayerEx(M7,M7,M6,user);//call SuicideOnPlayerEx(M7,M7,M6,user)
			SetBuildUpgrEx(1,1,2, UPG_UNHOLY_STR);//call SetBuildUpgrEx( 1,1,2, UPG_UNHOLY_STR  )
			SetBuildUpgrEx(1,1,2, UPG_CR_ATTACK);//call SetBuildUpgrEx( 1,1,2, UPG_CR_ATTACK   )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(1,1,2, MEAT_WAGON);//call CampaignAttackerEx( 1,1,2, MEAT_WAGON  )
			CampaignAttackerEx(4,4,6, GHOUL);//call CampaignAttackerEx( 4,4,6, GHOUL       )
			CampaignAttackerEx(2,2,4, NECRO);//call CampaignAttackerEx( 2,2,4, NECRO       )
			CampaignAttackerEx(1,1,1, LICH2);//call CampaignAttackerEx( 1,1,1, LICH2       )
			SuicideOnPlayerEx(M6,M6,M5,user);//call SuicideOnPlayerEx(M6,M6,M5,user)
			SetBuildUpgrEx(1,1,2, UPG_UNHOLY_ARMOR);//call SetBuildUpgrEx( 1,1,2, UPG_UNHOLY_ARMOR)
			SetBuildUpgrEx(1,1,2, UPG_CR_ARMOR);//call SetBuildUpgrEx( 1,1,2, UPG_CR_ARMOR    )
			SetBuildUpgrEx(2,2,2, UPG_NECROS);//call SetBuildUpgrEx( 2,2,2, UPG_NECROS      )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(10,10,14,  GHOUL);//call CampaignAttackerEx( 10,10,14,  GHOUL   )
			SuicideOnPlayerEx(M7,M7,M6,user);//call SuicideOnPlayerEx(M7,M7,M6,user)
			SetBuildUpgrEx(2,2,3, UPG_UNHOLY_STR);//call SetBuildUpgrEx( 2,2,3, UPG_UNHOLY_STR  )
			SetBuildUpgrEx(2,2,3, UPG_CR_ATTACK);//call SetBuildUpgrEx( 2,2,3, UPG_CR_ATTACK   )
			SetBuildUpgrEx(1,1,1, UPG_GHOUL_FRENZY);//call SetBuildUpgrEx( 1,1,1, UPG_GHOUL_FRENZY)
			SetBuildUpgrEx(1,1,1, UPG_PLAGUE);//call SetBuildUpgrEx( 1,1,1, UPG_PLAGUE      )
			//
			while (true) {//loop
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(3,3,4, GARGOYLE);//call CampaignAttackerEx( 3,3,4, GARGOYLE    )
				CampaignAttackerEx(1,1,2, FROST_WYRM);//call CampaignAttackerEx( 1,1,2, FROST_WYRM  )
				CampaignAttackerEx(2,2,2, BLK_SPHINX);//call CampaignAttackerEx( 2,2,2, BLK_SPHINX  )
				SuicideOnPlayerEx(M7,M7,M6,user);//call SuicideOnPlayerEx(M7,M7,M6,user)
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(1,1,2, MEAT_WAGON);//call CampaignAttackerEx( 1,1,2, MEAT_WAGON  )
				CampaignAttackerEx(4,4,6, GHOUL);//call CampaignAttackerEx( 4,4,6, GHOUL       )
				CampaignAttackerEx(2,2,4, NECRO);//call CampaignAttackerEx( 2,2,4, NECRO       )
				CampaignAttackerEx(1,1,1, LICH2);//call CampaignAttackerEx( 1,1,1, LICH2       )
				SuicideOnPlayerEx(M7,M7,M6,user);//call SuicideOnPlayerEx(M7,M7,M6,user)
				InitAssaultGroup();//call InitAssaultGroup()
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(7,7,9, GARGOYLE);//call CampaignAttackerEx( 7,7,9, GARGOYLE    )
				CampaignAttackerEx(3,3,4, BLK_SPHINX);//call CampaignAttackerEx( 3,3,4, BLK_SPHINX  )
				SuicideOnPlayerEx(M7,M7,M6,user);//call SuicideOnPlayerEx(M7,M7,M6,user)
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(1,1, 1, LICH2);//call CampaignAttackerEx( 1,1, 1, LICH2        )
				CampaignAttackerEx(8,8,12, GHOUL);//call CampaignAttackerEx( 8,8,12, GHOUL        )
				CampaignAttackerEx(1,1, 2, MEAT_WAGON);//call CampaignAttackerEx( 1,1, 2, MEAT_WAGON   )
				SuicideOnPlayerEx(M7,M7,M6,user);//call SuicideOnPlayerEx(M7,M7,M6,user)
			}//endloop
		}//endfunction

	
	}
}

