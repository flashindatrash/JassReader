using System;
using System.Collections.Generic;

namespace Jass {

	public class U03x04Ai {

		//
		//
		//
		public static player user = PlayerEx(2);//player user = PlayerEx(2)
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(ZIGGURAT_1,null);//call CampaignAI(ZIGGURAT_1,null)
			SetReplacements(1,1,3);//call SetReplacements(1,1,3)
			campaign_wood_peons = 2;//set campaign_wood_peons = 2
			SetBuildUnitEx(1, 1, 1, ACOLYTE);//call SetBuildUnitEx( 1, 1, 1, ACOLYTE           )
			SetBuildUnitEx(0, 0, 1, NECROPOLIS_1);//call SetBuildUnitEx( 0, 0, 1, NECROPOLIS_1      )
			SetBuildUnitEx(0, 0, 1, CRYPT);//call SetBuildUnitEx( 0, 0, 1, CRYPT             )
			SetBuildUnitEx(0, 0, 5, ZIGGURAT_1);//call SetBuildUnitEx( 0, 0, 5, ZIGGURAT_1        )
			SetBuildUnitEx(0, 0, 1, GRAVEYARD);//call SetBuildUnitEx( 0, 0, 1, GRAVEYARD         )
			SetBuildUnitEx(0, 0, 1, UNDEAD_ALTAR);//call SetBuildUnitEx( 0, 0, 1, UNDEAD_ALTAR      )
			SetBuildUnitEx(0, 0, 1, NECROPOLIS_2);//call SetBuildUnitEx( 0, 0, 1, NECROPOLIS_2      )
			SetBuildUnitEx(0, 0, 1, SLAUGHTERHOUSE);//call SetBuildUnitEx( 0, 0, 1, SLAUGHTERHOUSE    )
			SetBuildUnitEx(0, 0, 1, DAMNED_TEMPLE);//call SetBuildUnitEx( 0, 0, 1, DAMNED_TEMPLE		)
			SetBuildUnitEx(0, 0, 4, ZIGGURAT_2);//call SetBuildUnitEx( 0, 0, 4, ZIGGURAT_2        )
			SetBuildUnitEx(0, 0, 1, ZIGGURAT_FROST);//call SetBuildUnitEx( 0, 0, 1, ZIGGURAT_FROST    )
			SetBuildUnitEx(0, 0, 1, NECROPOLIS_3);//call SetBuildUnitEx( 0, 0, 1, NECROPOLIS_3      )
			SetBuildUnitEx(5, 5, 5, ACOLYTE);//call SetBuildUnitEx( 5, 5, 5, ACOLYTE           )
			CampaignDefenderEx(1, 1, 1, ABOMINATION);//call CampaignDefenderEx( 1, 1, 1, ABOMINATION   )
			CampaignDefenderEx(1, 1, 1, CRYPT_FIEND);//call CampaignDefenderEx( 1, 1, 1, CRYPT_FIEND	)
			SetBuildUpgrEx(0,0,1, UPG_GHOUL_FRENZY);//call SetBuildUpgrEx( 0,0,1, UPG_GHOUL_FRENZY)
			SetBuildUpgrEx(1,1,1, UPG_FIEND_WEB);//call SetBuildUpgrEx( 1,1,1, UPG_FIEND_WEB	)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2,2,4,	ABOMINATION);//call CampaignAttackerEx( 2,2,4,	ABOMINATION	)
			SuicideOnPlayerEx(M4,M4,M3,user);//call SuicideOnPlayerEx(M4,M4,M3,user)
			SetBuildUpgrEx(0,0,1, UPG_UNHOLY_STR);//call SetBuildUpgrEx( 0,0,1, UPG_UNHOLY_STR  )
			SetBuildUpgrEx(0,1,1, UPG_CR_ATTACK);//call SetBuildUpgrEx( 0,1,1, UPG_CR_ATTACK   )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2,2,2,	GHOUL);//call CampaignAttackerEx( 2,2,2,	GHOUL   	)
			CampaignAttackerEx(3,3,4,	CRYPT_FIEND);//call CampaignAttackerEx( 3,3,4,	CRYPT_FIEND	)
			SuicideOnPlayerEx(M5,M5,M3,user);//call SuicideOnPlayerEx(M5,M5,M3,user)
			SetBuildUpgrEx(0,0,1, UPG_UNHOLY_ARMOR);//call SetBuildUpgrEx( 0,0,1, UPG_UNHOLY_ARMOR)
			SetBuildUpgrEx(0,0,1, UPG_CR_ARMOR);//call SetBuildUpgrEx( 0,0,1, UPG_CR_ARMOR	)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2,2,4,	ABOMINATION);//call CampaignAttackerEx( 2,2,4,	ABOMINATION	)
			CampaignAttackerEx(3,3,4,	CRYPT_FIEND);//call CampaignAttackerEx( 3,3,4,	CRYPT_FIEND	)
			SuicideOnPlayerEx(M5,M5,M3,user);//call SuicideOnPlayerEx(M5,M5,M3,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2,2,2,	GHOUL);//call CampaignAttackerEx( 2,2,2,	GHOUL   	)
			CampaignAttackerEx(2,2,4,	ABOMINATION);//call CampaignAttackerEx( 2,2,4,	ABOMINATION	)
			CampaignAttackerEx(1,1,2,	MEAT_WAGON);//call CampaignAttackerEx( 1,1,2,	MEAT_WAGON	)
			SuicideOnPlayerEx(M5,M5,M3,user);//call SuicideOnPlayerEx(M5,M5,M3,user)
			SetBuildUpgrEx(1,1,2, UPG_UNHOLY_STR);//call SetBuildUpgrEx( 1,1,2, UPG_UNHOLY_STR  )
			SetBuildUpgrEx(1,1,2, UPG_CR_ATTACK);//call SetBuildUpgrEx( 1,1,2, UPG_CR_ATTACK   )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2,2,2,	GHOUL);//call CampaignAttackerEx( 2,2,2,	GHOUL   	)
			CampaignAttackerEx(5,5,7,	CRYPT_FIEND);//call CampaignAttackerEx( 5,5,7,	CRYPT_FIEND	)
			CampaignAttackerEx(1,1,2,	MEAT_WAGON);//call CampaignAttackerEx( 1,1,2,	MEAT_WAGON	)
			SuicideOnPlayerEx(M5,M5,M3,user);//call SuicideOnPlayerEx(M5,M5,M3,user)
			SetBuildUpgrEx(1,1,2, UPG_UNHOLY_ARMOR);//call SetBuildUpgrEx( 1,1,2, UPG_UNHOLY_ARMOR)
			SetBuildUpgrEx(1,1,2, UPG_CR_ARMOR);//call SetBuildUpgrEx( 1,1,2, UPG_CR_ARMOR    )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(3,3,5,	ABOMINATION);//call CampaignAttackerEx( 3,3,5,	ABOMINATION	)
			CampaignAttackerEx(3,3,4,	CRYPT_FIEND);//call CampaignAttackerEx( 3,3,4,	CRYPT_FIEND	)
			SuicideOnPlayerEx(M5,M5,M3,user);//call SuicideOnPlayerEx(M5,M5,M3,user)
			SetBuildUpgrEx(2,2,3, UPG_UNHOLY_STR);//call SetBuildUpgrEx( 2,2,3, UPG_UNHOLY_STR  )
			SetBuildUpgrEx(2,2,3, UPG_CR_ATTACK);//call SetBuildUpgrEx( 2,2,3, UPG_CR_ATTACK   )
			SetBuildUpgrEx(1,1,1, UPG_GHOUL_FRENZY);//call SetBuildUpgrEx( 1,1,1, UPG_GHOUL_FRENZY)
			//
			while (true) {//loop
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(2,2,2,	GHOUL);//call CampaignAttackerEx( 2,2,2,	GHOUL   	)
				CampaignAttackerEx(5,5,7,	ABOMINATION);//call CampaignAttackerEx( 5,5,7,	ABOMINATION	)
				SuicideOnPlayerEx(M5,M5,M3,user);//call SuicideOnPlayerEx(M5,M5,M3,user)
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(2,2,2,	GHOUL);//call CampaignAttackerEx( 2,2,2,	GHOUL   	)
				CampaignAttackerEx(5,5,7,	CRYPT_FIEND);//call CampaignAttackerEx( 5,5,7,	CRYPT_FIEND	)
				CampaignAttackerEx(1,1,2,	MEAT_WAGON);//call CampaignAttackerEx( 1,1,2,	MEAT_WAGON	)
				SuicideOnPlayerEx(M5,M5,M3,user);//call SuicideOnPlayerEx(M5,M5,M3,user)
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(3,3,5,	ABOMINATION);//call CampaignAttackerEx( 3,3,5,	ABOMINATION	)
				CampaignAttackerEx(3,3,4,	CRYPT_FIEND);//call CampaignAttackerEx( 3,3,4,	CRYPT_FIEND	)
				SuicideOnPlayerEx(M5,M5,M3,user);//call SuicideOnPlayerEx(M5,M5,M3,user)
			}//endloop
		}//endfunction

	
	}
}

