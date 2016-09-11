using System;
using System.Collections.Generic;

namespace Jass {

	public class N07x06Ai {

		//
		//
		//
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(ZIGGURAT_1,null);//call CampaignAI(ZIGGURAT_1,null)
			SetReplacements(2,2,3);//call SetReplacements(2,2,3)
			SetRandomPaths(false);//call SetRandomPaths(false)
			campaign_wood_peons = 2;//set campaign_wood_peons = 2
			SetCaptainHome(ATTACK_CAPTAIN,-225,330);//call SetCaptainHome(ATTACK_CAPTAIN,-225,330)
			SetBuildUnitEx(1,1,1, NECROPOLIS_1);//call SetBuildUnitEx( 1,1,1, NECROPOLIS_1    )
			SetBuildUnitEx(1,1,1, ACOLYTE);//call SetBuildUnitEx( 1,1,1, ACOLYTE         )
			SetBuildUnitEx(1,1,1, UNDEAD_ALTAR);//call SetBuildUnitEx( 1,1,1, UNDEAD_ALTAR    )
			SetBuildUnitEx(1,1,1, CRYPT);//call SetBuildUnitEx( 1,1,1, CRYPT           )
			SetBuildUnitEx(1,1,1, TOMB_OF_RELICS);//call SetBuildUnitEx( 1,1,1, TOMB_OF_RELICS  )
			SetBuildUnitEx(1,1,1, GRAVEYARD);//call SetBuildUnitEx( 1,1,1, GRAVEYARD       )
			SetBuildUnitEx(9,9,9, ZIGGURAT_1);//call SetBuildUnitEx( 9,9,9, ZIGGURAT_1      )
			SetBuildUnitEx(1,1,1, NECROPOLIS_2);//call SetBuildUnitEx( 1,1,1, NECROPOLIS_2    )
			SetBuildUnitEx(1,1,1, SLAUGHTERHOUSE);//call SetBuildUnitEx( 1,1,1, SLAUGHTERHOUSE  )
			SetBuildUnitEx(1,1,1, DAMNED_TEMPLE);//call SetBuildUnitEx( 1,1,1, DAMNED_TEMPLE   )
			SetBuildUnitEx(1,1,1, NECROPOLIS_3);//call SetBuildUnitEx( 1,1,1, NECROPOLIS_3    )
			SetBuildUnitEx(5,5,5, ACOLYTE);//call SetBuildUnitEx( 5,5,5, ACOLYTE         )
			SetBuildUnitEx(6,6,6, ZIGGURAT_2);//call SetBuildUnitEx( 6,6,6, ZIGGURAT_2      )
			SetBuildUnitEx(3,3,3, ZIGGURAT_FROST);//call SetBuildUnitEx( 3,3,3, ZIGGURAT_FROST  )
			CampaignDefenderEx(1,1,1, LICH);//call CampaignDefenderEx( 1,1,1, LICH        )
			CampaignDefenderEx(1,1,1, DREAD_LORD);//call CampaignDefenderEx( 1,1,1, DREAD_LORD  )
			CampaignDefenderEx(1,1,1, ABOMINATION);//call CampaignDefenderEx( 1,1,1, ABOMINATION )
			CampaignDefenderEx(1,1,1, NECRO);//call CampaignDefenderEx( 1,1,1, NECRO       )
			CampaignDefenderEx(1,1,1, OBS_STATUE);//call CampaignDefenderEx( 1,1,1, OBS_STATUE  )
			CampaignDefenderEx(1,1,1, GARGOYLE);//call CampaignDefenderEx( 1,1,1, GARGOYLE    )
			CampaignDefenderEx(1,1,1, FROST_WYRM);//call CampaignDefenderEx( 1,1,1, FROST_WYRM  )
			CampaignDefenderEx(1,1,1, CRYPT_FIEND);//call CampaignDefenderEx( 1,1,1, CRYPT_FIEND )
			SetBuildUpgrEx(1,1,1, UPG_BLK_SPHINX);//call SetBuildUpgrEx( 1,1,1, UPG_BLK_SPHINX  )
			WaitForSignal();//call WaitForSignal()
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(4,4,6, GHOUL);//call CampaignAttackerEx( 4,4,6, GHOUL        )
			CampaignAttackerEx(1,1,3, ABOMINATION);//call CampaignAttackerEx( 1,1,3, ABOMINATION  )
			CampaignAttackerEx(1,1,2, NECRO);//call CampaignAttackerEx( 1,1,2, NECRO        )
			SuicideOnPlayerEx(M2,M2,M1,user);//call SuicideOnPlayerEx(M2,M2,M1,user)
			SetBuildUpgr(1, UPG_FIEND_WEB);//call SetBuildUpgr( 1, UPG_FIEND_WEB     )
			SetBuildUpgrEx(1,1,1, UPG_UNHOLY_STR);//call SetBuildUpgrEx( 1,1,1, UPG_UNHOLY_STR    )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(3,3,4, GHOUL);//call CampaignAttackerEx( 3,3,4, GHOUL           )
			CampaignAttackerEx(2,2,4, CRYPT_FIEND);//call CampaignAttackerEx( 2,2,4, CRYPT_FIEND     )
			CampaignAttackerEx(1,1,1, DREAD_LORD);//call CampaignAttackerEx( 1,1,1, DREAD_LORD      )
			SuicideOnPlayerEx(M4,M4,M3,user);//call SuicideOnPlayerEx(M4,M4,M3,user)
			SetBuildUpgrEx(1,1,1, UPG_CR_ATTACK);//call SetBuildUpgrEx( 1,1,1, UPG_CR_ATTACK       )
			SetBuildUpgrEx(1,1,1, UPG_SKEL_LIFE);//call SetBuildUpgrEx( 1,1,1, UPG_SKEL_LIFE       )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(6,6,12, GHOUL);//call CampaignAttackerEx( 6,6,12, GHOUL      )
			CampaignAttackerEx(3,3,4, NECRO);//call CampaignAttackerEx( 3,3,4, NECRO       )
			CampaignAttackerEx(1,1,1, OBS_STATUE);//call CampaignAttackerEx( 1,1,1, OBS_STATUE  )
			CampaignAttackerEx(1,1,1, LICH);//call CampaignAttackerEx( 1,1,1, LICH        )
			SuicideOnPlayerEx(M4,M4,M3,user);//call SuicideOnPlayerEx(M4,M4,M3,user)
			SetBuildUpgrEx(0,0,1, UPG_PLAGUE);//call SetBuildUpgrEx( 0,0,1, UPG_PLAGUE          )
			SetBuildUpgrEx(1,1,1, UPG_UNHOLY_ARMOR);//call SetBuildUpgrEx( 1,1,1, UPG_UNHOLY_ARMOR    )
			SetBuildUpgrEx(1,1,1, UPG_CR_ARMOR);//call SetBuildUpgrEx( 1,1,1, UPG_CR_ARMOR        )
			SetBuildUpgrEx(1,1,1, UPG_NECROS);//call SetBuildUpgrEx( 1,1,1, UPG_NECROS          )
			SetBuildUpgrEx(1,1,1, UPG_BANSHEE);//call SetBuildUpgrEx( 1,1,1, UPG_BANSHEE         )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(0,0,2, NECRO);//call CampaignAttackerEx( 0,0,2, NECRO       )
			CampaignAttackerEx(3,3,4, ABOMINATION);//call CampaignAttackerEx( 3,3,4, ABOMINATION )
			CampaignAttackerEx(1,1,1, MEAT_WAGON);//call CampaignAttackerEx( 1,1,1, MEAT_WAGON  )
			CampaignAttackerEx(1,1,1, DREAD_LORD);//call CampaignAttackerEx( 1,1,1, DREAD_LORD  )
			SuicideOnPlayerEx(M4,M4,M3,user);//call SuicideOnPlayerEx(M4,M4,M3,user)
			SetBuildUpgrEx(2,2,2, UPG_UNHOLY_STR);//call SetBuildUpgrEx( 2,2,2, UPG_UNHOLY_STR      )
			SetBuildUpgrEx(2,2,2, UPG_CR_ATTACK);//call SetBuildUpgrEx( 2,2,2, UPG_CR_ATTACK       )
			SetBuildUpgrEx(1,1,1, UPG_SKEL_MASTERY);//call SetBuildUpgrEx( 1,1,1, UPG_SKEL_MASTERY    )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2,2,3, ABOMINATION);//call CampaignAttackerEx( 2,2,3, ABOMINATION )
			CampaignAttackerEx(1,1,1, OBS_STATUE);//call CampaignAttackerEx( 1,1,1, OBS_STATUE  )
			CampaignAttackerEx(4,4,6, GARGOYLE);//call CampaignAttackerEx( 4,4,6, GARGOYLE    )
			CampaignAttackerEx(1,1,1, LICH);//call CampaignAttackerEx( 1,1,1, LICH        )
			SuicideOnPlayerEx(M3,M3,M3,user);//call SuicideOnPlayerEx(M3,M3,M3,user)
			SetBuildUpgrEx(1,1,1, UPG_GHOUL_FRENZY);//call SetBuildUpgrEx( 1,1,1, UPG_GHOUL_FRENZY    )
			SetBuildUpgrEx(1,1,1, UPG_STONE_FORM);//call SetBuildUpgrEx( 1,1,1, UPG_STONE_FORM      )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(6,6,8, GARGOYLE);//call CampaignAttackerEx( 6,6,8, GARGOYLE        )
			CampaignAttackerEx(2,2,2, BLK_SPHINX);//call CampaignAttackerEx( 2,2,2, BLK_SPHINX      )
			SuicideOnPlayerEx(M3,M3,M3,user);//call SuicideOnPlayerEx(M3,M3,M3,user)
			SetBuildUpgrEx(2,2,2, UPG_UNHOLY_ARMOR);//call SetBuildUpgrEx( 2,2,2, UPG_UNHOLY_ARMOR    )
			SetBuildUpgrEx(2,2,2, UPG_CR_ARMOR);//call SetBuildUpgrEx( 2,2,2, UPG_CR_ARMOR        )
			SetBuildUpgrEx(2,2,2, UPG_NECROS);//call SetBuildUpgrEx( 2,2,2, UPG_NECROS          )
			SetBuildUpgrEx(1,2,2, UPG_BANSHEE);//call SetBuildUpgrEx( 1,2,2, UPG_BANSHEE         )
			while (true) {//loop
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(3,3,4, ABOMINATION);//call CampaignAttackerEx( 3,3,4, ABOMINATION )
				CampaignAttackerEx(2,2,3, NECRO);//call CampaignAttackerEx( 2,2,3, NECRO       )
				CampaignAttackerEx(2,2,3, BANSHEE);//call CampaignAttackerEx( 2,2,3, BANSHEE     )
				CampaignAttackerEx(1,1,1, LICH);//call CampaignAttackerEx( 1,1,1, LICH        )
				CampaignAttackerEx(1,1,1, OBS_STATUE);//call CampaignAttackerEx( 1,1,1, OBS_STATUE  )
				CampaignAttackerEx(1,1,2, MEAT_WAGON);//call CampaignAttackerEx( 1,1,2, MEAT_WAGON  )
				SuicideOnPlayerEx(M3,M3,M3,user);//call SuicideOnPlayerEx(M3,M3,M3,user)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(6,6,8, GHOUL);//call CampaignAttackerEx( 6,6,8, GHOUL       )
				CampaignAttackerEx(3,3,4, GARGOYLE);//call CampaignAttackerEx( 3,3,4, GARGOYLE    )
				CampaignAttackerEx(2,2,2, BLK_SPHINX);//call CampaignAttackerEx( 2,2,2, BLK_SPHINX  )
				CampaignAttackerEx(1,1,2, MEAT_WAGON);//call CampaignAttackerEx( 1,1,2, MEAT_WAGON  )
				CampaignAttackerEx(1,1,1, DREAD_LORD);//call CampaignAttackerEx( 1,1,1, DREAD_LORD  )
				SuicideOnPlayerEx(M3,M3,M3,user);//call SuicideOnPlayerEx(M3,M3,M3,user)
			}//endloop
		}//endfunction

	
	}
}

