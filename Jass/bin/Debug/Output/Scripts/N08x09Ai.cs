using System;
using System.Collections.Generic;

namespace Jass {

	public class N08x09Ai {

		//
		//
		//
		public static player user = PlayerEx(4);//player user = PlayerEx(4)
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(ZIGGURAT_1,null);//call CampaignAI(ZIGGURAT_1,null)
			SetReplacements(2,2,4);//call SetReplacements(2,2,4)
			DoCampaignFarms(false);//call DoCampaignFarms(false)
			SetWoodPeons(2);//call SetWoodPeons(2)
			SetBuildUnitEx(1, 1, 1, ACOLYTE);//call SetBuildUnitEx( 1, 1, 1, ACOLYTE           )
			SetBuildUnitEx(0, 0, 1, NECROPOLIS_1);//call SetBuildUnitEx( 0, 0, 1, NECROPOLIS_1      )
			SetBuildUnitEx(0, 0, 1, UNDEAD_MINE);//call SetBuildUnitEx( 0, 0, 1, UNDEAD_MINE       )
			SetBuildUnitEx(0, 0, 2, CRYPT);//call SetBuildUnitEx( 0, 0, 2, CRYPT             )
			SetBuildUnitEx(0, 0, 4, ZIGGURAT_1);//call SetBuildUnitEx( 0, 0, 4, ZIGGURAT_1        )
			SetBuildUnitEx(0, 0, 1, GRAVEYARD);//call SetBuildUnitEx( 0, 0, 1, GRAVEYARD         )
			SetBuildUnitEx(0, 0, 1, UNDEAD_ALTAR);//call SetBuildUnitEx( 0, 0, 1, UNDEAD_ALTAR      )
			SetBuildUnitEx(0, 0, 1, NECROPOLIS_2);//call SetBuildUnitEx( 0, 0, 1, NECROPOLIS_2      )
			SetBuildUnitEx(0, 0, 4, ZIGGURAT_2);//call SetBuildUnitEx( 0, 0, 4, ZIGGURAT_2        )
			SetBuildUnitEx(0, 0, 2, DAMNED_TEMPLE);//call SetBuildUnitEx( 0, 0, 2, DAMNED_TEMPLE     )
			SetBuildUnitEx(0, 0, 2, SLAUGHTERHOUSE);//call SetBuildUnitEx( 0, 0, 2, SLAUGHTERHOUSE    )
			SetBuildUnitEx(0, 0, 1, NECROPOLIS_3);//call SetBuildUnitEx( 0, 0, 1, NECROPOLIS_3      )
			SetBuildUnitEx(5, 5, 5, ACOLYTE);//call SetBuildUnitEx( 5, 5, 5, ACOLYTE           )
			SetBuildUpgrEx(0,0,1, UPG_NECROS);//call SetBuildUpgrEx( 0,0,1, UPG_NECROS      )
			SetBuildUpgrEx(0,0,1, UPG_BANSHEE);//call SetBuildUpgrEx( 0,0,1, UPG_BANSHEE     )
			SetBuildUpgrEx(1,1,1, UPG_SKEL_LIFE);//call SetBuildUpgrEx( 1,1,1, UPG_SKEL_LIFE   )
			SetBuildUpgrEx(1,1,1, UPG_EXHUME);//call SetBuildUpgrEx( 1,1,1, UPG_EXHUME      )
			CampaignDefenderEx(0, 0, 1, ABOMINATION);//call CampaignDefenderEx( 0, 0, 1, ABOMINATION   )
			CampaignDefenderEx(1, 1, 1, NECRO);//call CampaignDefenderEx( 1, 1, 1, NECRO         )
			CampaignDefenderEx(1, 1, 1, CRYPT_FIEND);//call CampaignDefenderEx( 1, 1, 1, CRYPT_FIEND   )
			CampaignDefenderEx(0, 0, 1, DREAD_LORD);//call CampaignDefenderEx( 0, 0, 1, DREAD_LORD    )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(6,6,8, GHOUL);//call CampaignAttackerEx( 6,6,8, GHOUL       )
			CampaignAttackerEx(1,1,2, NECRO);//call CampaignAttackerEx( 1,1,2, NECRO       )
			CampaignAttackerEx(1,1,1, LICH);//call CampaignAttackerEx( 1,1,1, LICH        )
			SuicideOnPlayerEx(M4,M4,M2,user);//call SuicideOnPlayerEx(M4,M4,M2,user)
			SetBuildUpgrEx(0,0,1, UPG_UNHOLY_STR);//call SetBuildUpgrEx( 0,0,1, UPG_UNHOLY_STR    )
			SetBuildUpgrEx(0,0,1, UPG_CR_ATTACK);//call SetBuildUpgrEx( 0,0,1, UPG_CR_ATTACK     )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(6,6,8, GHOUL);//call CampaignAttackerEx( 6,6,8, GHOUL        )
			CampaignAttackerEx(2,2,3, CRYPT_FIEND);//call CampaignAttackerEx( 2,2,3, CRYPT_FIEND  )
			CampaignAttackerEx(1,1,2, MEAT_WAGON);//call CampaignAttackerEx( 1,1,2, MEAT_WAGON   )
			SuicideOnPlayerEx(M7,M7,M5,user);//call SuicideOnPlayerEx(M7,M7,M5,user)
			SetBuildUpgrEx(0,0,1, UPG_UNHOLY_ARMOR);//call SetBuildUpgrEx( 0,0,1, UPG_UNHOLY_ARMOR)
			SetBuildUpgrEx(0,0,1, UPG_CR_ARMOR);//call SetBuildUpgrEx( 0,0,1, UPG_CR_ARMOR    )
			SetBuildUpgrEx(1,1,2, UPG_NECROS);//call SetBuildUpgrEx( 1,1,2, UPG_NECROS      )
			SetBuildUpgrEx(1,1,2, UPG_BANSHEE);//call SetBuildUpgrEx( 1,1,2, UPG_BANSHEE     )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(1,1,1, DREAD_LORD);//call CampaignAttackerEx( 1,1,1, DREAD_LORD  )
			CampaignAttackerEx(2,2,3, NECRO);//call CampaignAttackerEx( 2,2,3, NECRO       )
			CampaignAttackerEx(1,1,1, MEAT_WAGON);//call CampaignAttackerEx( 1,1,1, MEAT_WAGON  )
			SuicideOnPlayerEx(M7,M7,M5,user);//call SuicideOnPlayerEx(M7,M7,M5,user)
			SetBuildUpgrEx(0,0,1, UPG_PLAGUE);//call SetBuildUpgrEx( 0,0,1, UPG_PLAGUE        )
			SetBuildUpgrEx(1,1,2, UPG_UNHOLY_STR);//call SetBuildUpgrEx( 1,1,2, UPG_UNHOLY_STR    )
			SetBuildUpgrEx(1,1,2, UPG_CR_ATTACK);//call SetBuildUpgrEx( 1,1,2, UPG_CR_ATTACK     )
			SetBuildUpgrEx(0,0,1, UPG_SKEL_MASTERY);//call SetBuildUpgrEx( 0,0,1, UPG_SKEL_MASTERY  )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(5,5,4, GHOUL);//call CampaignAttackerEx( 5,5,4, GHOUL       )
			CampaignAttackerEx(1,1,3, ABOMINATION);//call CampaignAttackerEx( 1,1,3, ABOMINATION )
			CampaignAttackerEx(3,3,5, CRYPT_FIEND);//call CampaignAttackerEx( 3,3,5, CRYPT_FIEND )
			CampaignAttackerEx(1,1,1, OBS_STATUE);//call CampaignAttackerEx( 1,1,1, OBS_STATUE  )
			SuicideOnPlayerEx(M7,M7,M5,user);//call SuicideOnPlayerEx(M7,M7,M5,user)
			SetBuildUpgrEx(1,1,2, UPG_UNHOLY_ARMOR);//call SetBuildUpgrEx( 1,1,2, UPG_UNHOLY_ARMOR)
			SetBuildUpgrEx(1,1,2, UPG_CR_ARMOR);//call SetBuildUpgrEx( 1,1,2, UPG_CR_ARMOR    )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(1,1,1, LICH);//call CampaignAttackerEx( 1,1,1, LICH        )
			CampaignAttackerEx(4,4,6, NECRO);//call CampaignAttackerEx( 4,4,6, NECRO       )
			CampaignAttackerEx(1,1,1, OBS_STATUE);//call CampaignAttackerEx( 1,1,1, OBS_STATUE  )
			CampaignAttackerEx(1,1,1, MEAT_WAGON);//call CampaignAttackerEx( 1,1,1, MEAT_WAGON  )
			SuicideOnPlayerEx(M7,M7,M5,user);//call SuicideOnPlayerEx(M7,M7,M5,user)
			SetBuildUpgrEx(2,2,3, UPG_UNHOLY_STR);//call SetBuildUpgrEx( 2,2,3, UPG_UNHOLY_STR  )
			SetBuildUpgrEx(2,2,3, UPG_CR_ATTACK);//call SetBuildUpgrEx( 2,2,3, UPG_CR_ATTACK   )
			SetBuildUpgrEx(0,0,1, UPG_GHOUL_FRENZY);//call SetBuildUpgrEx( 0,0,1, UPG_GHOUL_FRENZY)
			SetBuildUpgrEx(1,1,1, UPG_SKEL_MASTERY);//call SetBuildUpgrEx( 1,1,1, UPG_SKEL_MASTERY  )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(1,1,1, DREAD_LORD);//call CampaignAttackerEx( 1,1,1, DREAD_LORD  )
			CampaignAttackerEx(4,4,5, GHOUL);//call CampaignAttackerEx( 4,4,5, GHOUL       )
			CampaignAttackerEx(2,2,4, BANSHEE);//call CampaignAttackerEx( 2,2,4, BANSHEE     )
			CampaignAttackerEx(1,1,1, MEAT_WAGON);//call CampaignAttackerEx( 1,1,1, MEAT_WAGON  )
			SuicideOnPlayerEx(M7,M7,M5,user);//call SuicideOnPlayerEx(M7,M7,M5,user)
			SetBuildUpgrEx(2,2,3, UPG_UNHOLY_ARMOR);//call SetBuildUpgrEx( 2,2,3, UPG_UNHOLY_ARMOR)
			SetBuildUpgrEx(2,2,3, UPG_CR_ARMOR);//call SetBuildUpgrEx( 2,2,3, UPG_CR_ARMOR    )
			SetBuildUpgrEx(1,1,1, UPG_PLAGUE);//call SetBuildUpgrEx( 1,1,1, UPG_PLAGUE      )
			SetBuildUpgrEx(2,2,2, UPG_NECROS);//call SetBuildUpgrEx( 2,2,2, UPG_NECROS      )
			SetBuildUpgrEx(2,2,2, UPG_BANSHEE);//call SetBuildUpgrEx( 2,2,2, UPG_BANSHEE     )
			//
			while (true) {//loop
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(0,0,1, DREAD_LORD);//call CampaignAttackerEx( 0,0,1, DREAD_LORD  )
				CampaignAttackerEx(5,5,4, ABOMINATION);//call CampaignAttackerEx( 5,5,4, ABOMINATION )
				SuicideOnPlayerEx(M7,M7,M5,user);//call SuicideOnPlayerEx(M7,M7,M5,user)
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(1,1,1, LICH);//call CampaignAttackerEx( 1,1,1, LICH        )
				CampaignAttackerEx(4,4,5, NECRO);//call CampaignAttackerEx( 4,4,5, NECRO       )
				CampaignAttackerEx(2,2,3, BANSHEE);//call CampaignAttackerEx( 2,2,3, BANSHEE     )
				CampaignAttackerEx(1,1,1, OBS_STATUE);//call CampaignAttackerEx( 1,1,1, OBS_STATUE  )
				CampaignAttackerEx(1,1,1, MEAT_WAGON);//call CampaignAttackerEx( 1,1,1, MEAT_WAGON  )
				SuicideOnPlayerEx(M7,M7,M5,user);//call SuicideOnPlayerEx(M7,M7,M5,user)
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(1,1,1, DREAD_LORD);//call CampaignAttackerEx( 1,1,1, DREAD_LORD  )
				CampaignAttackerEx(5,5,6, GHOUL);//call CampaignAttackerEx( 5,5,6, GHOUL       )
				CampaignAttackerEx(2,2,3, NECRO);//call CampaignAttackerEx( 2,2,3, NECRO       )
				CampaignAttackerEx(0,0,1, MEAT_WAGON);//call CampaignAttackerEx( 0,0,1, MEAT_WAGON  )
				SuicideOnPlayerEx(M7,M7,M5,user);//call SuicideOnPlayerEx(M7,M7,M5,user)
			}//endloop
		}//endfunction

	
	}
}

