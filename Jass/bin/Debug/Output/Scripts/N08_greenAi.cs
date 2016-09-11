using System;
using System.Collections.Generic;

namespace Jass {

	public class N08_greenAi {

		//
		//
		//
		public static player user = Player(1);//player user = Player(1)
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(CommonAi.ZIGGURAT_1, null);//call CampaignAI(ZIGGURAT_1,null)
			SetReplacements(2, 2, 4);//call SetReplacements(2,2,4)
			SetCaptainHome(CommonAi.ATTACK_CAPTAIN, 4161, -4668);//call SetCaptainHome(ATTACK_CAPTAIN,4161,-4668	)
			SetCaptainHome(CommonAi.DEFENSE_CAPTAIN, 5218, -6441);//call SetCaptainHome(DEFENSE_CAPTAIN,5218,-6441	)
			campaign_wood_peons = 2;//set campaign_wood_peons = 2
			SetBuildUnit(1, CommonAi.NECROPOLIS_1);//call SetBuildUnit( 1, NECROPOLIS_1		)
			SetBuildUnit(1, CommonAi.ACOLYTE);//call SetBuildUnit( 1, ACOLYTE			)
			SetBuildUnit(1, CommonAi.UNDEAD_MINE);//call SetBuildUnit( 1, UNDEAD_MINE		)
			SetBuildUnit(1, CommonAi.GRAVEYARD);//call SetBuildUnit( 1, GRAVEYARD			)
			SetBuildUnit(8, CommonAi.ZIGGURAT_1);//call SetBuildUnit( 8, ZIGGURAT_1		)
			SetBuildUnit(2, CommonAi.CRYPT);//call SetBuildUnit( 2, CRYPT				)
			SetBuildUnit(1, CommonAi.UNDEAD_ALTAR);//call SetBuildUnit( 1, UNDEAD_ALTAR		)
			SetBuildUnit(1, CommonAi.NECROPOLIS_2);//call SetBuildUnit( 1, NECROPOLIS_2		)
			SetBuildUnit(2, CommonAi.SLAUGHTERHOUSE);//call SetBuildUnit( 2, SLAUGHTERHOUSE	)
			SetBuildUnit(1, CommonAi.DAMNED_TEMPLE);//call SetBuildUnit( 1, DAMNED_TEMPLE		)
			SetBuildUnit(1, CommonAi.NECROPOLIS_3);//call SetBuildUnit( 1, NECROPOLIS_3		)
			SetBuildUnit(2, CommonAi.BONEYARD);//call SetBuildUnit( 2, BONEYARD			)
			SetBuildUnit(5, CommonAi.ACOLYTE);//call SetBuildUnit( 5, ACOLYTE			)
			SetBuildUnit(8, CommonAi.ZIGGURAT_2);//call SetBuildUnit( 8, ZIGGURAT_2		)
			CampaignDefenderEx(1, 1, 2, CommonAi.ABOMINATION);//call CampaignDefenderEx( 1,1,2, ABOMINATION	)
			CampaignDefenderEx(1, 1, 1, CommonAi.GARGOYLE);//call CampaignDefenderEx( 1,1,1, GARGOYLE	)
			CampaignDefenderEx(1, 1, 1, CommonAi.FROST_WYRM);//call CampaignDefenderEx( 1,1,1, FROST_WYRM	)
			CampaignDefenderEx(1, 1, 1, CommonAi.CRYPT_FIEND);//call CampaignDefenderEx( 1,1,1, CRYPT_FIEND	)
			CampaignDefenderEx(1, 1, 1, CommonAi.DREAD_LORD);//call CampaignDefenderEx( 1,1,1, DREAD_LORD	)
			WaitForSignal();//call WaitForSignal()
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(6, 6, 8, CommonAi.GARGOYLE);//call CampaignAttackerEx( 6,6,8, GARGOYLE    )
			SuicideOnPlayerEx(CommonAi.M5, CommonAi.M5, CommonAi.M3, U08_tealAi.user);//call SuicideOnPlayerEx(M5,M5,M3,user)
			SetBuildUpgrEx(1, 1, 1, CommonAi.UPG_FIEND_WEB);//call SetBuildUpgrEx( 1,1,1, UPG_FIEND_WEB	)
			SetBuildUpgrEx(1, 1, 1, CommonAi.UPG_CANNIBALIZE);//call SetBuildUpgrEx( 1,1,1, UPG_CANNIBALIZE )
			SetBuildUpgrEx(1, 1, 1, CommonAi.UPG_UNHOLY_STR);//call SetBuildUpgrEx( 1,1,1, UPG_UNHOLY_STR  )
			SetBuildUpgrEx(1, 1, 1, CommonAi.UPG_CR_ATTACK);//call SetBuildUpgrEx( 1,1,1, UPG_CR_ATTACK   )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(6, 6, 8, CommonAi.GARGOYLE);//call CampaignAttackerEx( 6,6,8, GARGOYLE    )
			CampaignAttackerEx(2, 2, 4, CommonAi.CRYPT_FIEND);//call CampaignAttackerEx( 2,2,4, CRYPT_FIEND )
			CampaignAttackerEx(1, 1, 2, CommonAi.FROST_WYRM);//call CampaignAttackerEx( 1,1,2, FROST_WYRM  )
			SuicideOnPlayerEx(CommonAi.M6, CommonAi.M6, CommonAi.M4, U08_tealAi.user);//call SuicideOnPlayerEx(M6,M6,M4,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(6, 6, 8, CommonAi.GARGOYLE);//call CampaignAttackerEx( 6,6,8, GARGOYLE    )
			CampaignAttackerEx(2, 2, 4, CommonAi.CRYPT_FIEND);//call CampaignAttackerEx( 2,2,4, CRYPT_FIEND )
			CampaignAttackerEx(1, 1, 2, CommonAi.FROST_WYRM);//call CampaignAttackerEx( 1,1,2, FROST_WYRM  )
			CampaignAttackerEx(1, 1, 1, CommonAi.DREAD_LORD);//call CampaignAttackerEx( 1,1,1, DREAD_LORD	)
			SuicideOnPlayerEx(CommonAi.M6, CommonAi.M6, CommonAi.M4, U08_tealAi.user);//call SuicideOnPlayerEx(M6,M6,M4,user)
			SetBuildUpgrEx(2, 2, 2, CommonAi.UPG_UNHOLY_STR);//call SetBuildUpgrEx( 2,2,2, UPG_UNHOLY_STR  )
			SetBuildUpgrEx(2, 2, 2, CommonAi.UPG_CR_ATTACK);//call SetBuildUpgrEx( 2,2,2, UPG_CR_ATTACK   )
			SetBuildUpgrEx(1, 1, 1, CommonAi.UPG_SKEL_LIFE);//call SetBuildUpgrEx( 1,1,1, UPG_SKEL_LIFE   )
			SetBuildUpgrEx(1, 1, 1, CommonAi.UPG_WYRM_BREATH);//call SetBuildUpgrEx( 1,1,1, UPG_WYRM_BREATH )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2, 2, 3, CommonAi.GARGOYLE);//call CampaignAttackerEx( 2,2,3, GARGOYLE    )
			CampaignAttackerEx(5, 5, 6, CommonAi.CRYPT_FIEND);//call CampaignAttackerEx( 5,5,6, CRYPT_FIEND )
			CampaignAttackerEx(1, 1, 2, CommonAi.BANSHEE);//call CampaignAttackerEx( 1,1,2, BANSHEE		)
			CampaignAttackerEx(1, 1, 2, CommonAi.MEAT_WAGON);//call CampaignAttackerEx( 1,1,2, MEAT_WAGON  )
			CampaignAttackerEx(1, 1, 1, CommonAi.DREAD_LORD);//call CampaignAttackerEx( 1,1,1, DREAD_LORD	)
			SuicideOnPlayerEx(CommonAi.M6, CommonAi.M6, CommonAi.M4, U08_tealAi.user);//call SuicideOnPlayerEx(M6,M6,M4,user)
			SetBuildUpgrEx(1, 1, 1, CommonAi.UPG_PLAGUE);//call SetBuildUpgrEx( 1,1,1, UPG_PLAGUE      )
			SetBuildUpgrEx(2, 2, 2, CommonAi.UPG_UNHOLY_ARMOR);//call SetBuildUpgrEx( 2,2,2, UPG_UNHOLY_ARMOR)
			SetBuildUpgrEx(2, 2, 2, CommonAi.UPG_CR_ARMOR);//call SetBuildUpgrEx( 2,2,2, UPG_CR_ARMOR	)
			SetBuildUpgrEx(2, 2, 2, CommonAi.UPG_NECROS);//call SetBuildUpgrEx( 2,2,2, UPG_NECROS      )
			SetBuildUpgrEx(2, 2, 2, CommonAi.UPG_BANSHEE);//call SetBuildUpgrEx( 2,2,2, UPG_BANSHEE		)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(3, 3, 4, CommonAi.GARGOYLE);//call CampaignAttackerEx( 3,3,4, GARGOYLE    )
			CampaignAttackerEx(2, 2, 4, CommonAi.CRYPT_FIEND);//call CampaignAttackerEx( 2,2,4, CRYPT_FIEND )
			CampaignAttackerEx(3, 3, 4, CommonAi.FROST_WYRM);//call CampaignAttackerEx( 3,3,4, FROST_WYRM  )
			SuicideOnPlayerEx(CommonAi.M6, CommonAi.M6, CommonAi.M4, U08_tealAi.user);//call SuicideOnPlayerEx(M6,M6,M4,user)
			SetBuildUpgrEx(2, 2, 3, CommonAi.UPG_UNHOLY_STR);//call SetBuildUpgrEx( 2,2,3, UPG_UNHOLY_STR  )
			SetBuildUpgrEx(2, 2, 3, CommonAi.UPG_CR_ATTACK);//call SetBuildUpgrEx( 2,2,3, UPG_CR_ATTACK   )
			SetBuildUpgrEx(1, 1, 1, CommonAi.UPG_GHOUL_FRENZY);//call SetBuildUpgrEx( 1,1,1, UPG_GHOUL_FRENZY)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2, 2, 3, CommonAi.GARGOYLE);//call CampaignAttackerEx( 2,2,3, GARGOYLE    )
			CampaignAttackerEx(5, 5, 6, CommonAi.CRYPT_FIEND);//call CampaignAttackerEx( 5,5,6, CRYPT_FIEND )
			CampaignAttackerEx(4, 4, 5, CommonAi.BANSHEE);//call CampaignAttackerEx( 4,4,5, BANSHEE		)
			CampaignAttackerEx(1, 1, 2, CommonAi.MEAT_WAGON);//call CampaignAttackerEx( 1,1,2, MEAT_WAGON  )
			CampaignAttackerEx(1, 1, 1, CommonAi.DREAD_LORD);//call CampaignAttackerEx( 1,1,1, DREAD_LORD	)
			SuicideOnPlayerEx(CommonAi.M6, CommonAi.M6, CommonAi.M4, U08_tealAi.user);//call SuicideOnPlayerEx(M6,M6,M4,user)
			SetBuildUpgrEx(2, 2, 3, CommonAi.UPG_UNHOLY_ARMOR);//call SetBuildUpgrEx( 2,2,3, UPG_UNHOLY_ARMOR)
			SetBuildUpgrEx(2, 2, 3, CommonAi.UPG_CR_ARMOR);//call SetBuildUpgrEx( 2,2,3, UPG_CR_ARMOR	)
			SetBuildUpgrEx(1, 1, 1, CommonAi.UPG_MEAT_WAGON);//call SetBuildUpgrEx( 1,1,1, UPG_MEAT_WAGON	)
			while (true) {//loop
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(6, 6, 8, CommonAi.GARGOYLE);//call CampaignAttackerEx( 6,6,8, GARGOYLE    )
				CampaignAttackerEx(3, 3, 4, CommonAi.CRYPT_FIEND);//call CampaignAttackerEx( 3,3,4, CRYPT_FIEND )
				CampaignAttackerEx(2, 2, 3, CommonAi.FROST_WYRM);//call CampaignAttackerEx( 2,2,3, FROST_WYRM  )
				CampaignAttackerEx(1, 1, 1, CommonAi.DREAD_LORD);//call CampaignAttackerEx( 1,1,1, DREAD_LORD	)
				SuicideOnPlayerEx(CommonAi.M6, CommonAi.M6, CommonAi.M4, U08_tealAi.user);//call SuicideOnPlayerEx(M6,M6,M4,user)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(2, 2, 3, CommonAi.GARGOYLE);//call CampaignAttackerEx( 2,2,3, GARGOYLE    )
				CampaignAttackerEx(5, 5, 6, CommonAi.CRYPT_FIEND);//call CampaignAttackerEx( 5,5,6, CRYPT_FIEND )
				CampaignAttackerEx(4, 4, 5, CommonAi.BANSHEE);//call CampaignAttackerEx( 4,4,5, BANSHEE		)
				CampaignAttackerEx(1, 1, 2, CommonAi.MEAT_WAGON);//call CampaignAttackerEx( 1,1,2, MEAT_WAGON  )
				CampaignAttackerEx(1, 1, 1, CommonAi.DREAD_LORD);//call CampaignAttackerEx( 1,1,1, DREAD_LORD	)
				SuicideOnPlayerEx(CommonAi.M6, CommonAi.M6, CommonAi.M4, U08_tealAi.user);//call SuicideOnPlayerEx(M6,M6,M4,user)
			}//endloop
		}//endfunction

	
	}
}

