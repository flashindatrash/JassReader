using System;
using System.Collections.Generic;

namespace Jass {

	public class N08_purpleAi {

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
			SetCaptainHome(CommonAi.ATTACK_CAPTAIN, -2265, -4200);//call SetCaptainHome(ATTACK_CAPTAIN,-2265,-4200	)
			SetCaptainHome(CommonAi.DEFENSE_CAPTAIN, -2453, -5875);//call SetCaptainHome(DEFENSE_CAPTAIN,-2453,-5875	)
			campaign_wood_peons = 2;//set campaign_wood_peons = 2
			SetBuildUnit(1, CommonAi.NECROPOLIS_1);//call SetBuildUnit( 1, NECROPOLIS_1		)
			SetBuildUnit(1, CommonAi.ACOLYTE);//call SetBuildUnit( 1, ACOLYTE			)
			SetBuildUnit(1, CommonAi.UNDEAD_MINE);//call SetBuildUnit( 1, UNDEAD_MINE		)
			SetBuildUnit(1, CommonAi.GRAVEYARD);//call SetBuildUnit( 1, GRAVEYARD			)
			SetBuildUnit(8, CommonAi.ZIGGURAT_1);//call SetBuildUnit( 8, ZIGGURAT_1		)
			SetBuildUnit(3, CommonAi.CRYPT);//call SetBuildUnit( 3, CRYPT				)
			SetBuildUnit(1, CommonAi.UNDEAD_ALTAR);//call SetBuildUnit( 1, UNDEAD_ALTAR		)
			SetBuildUnit(1, CommonAi.NECROPOLIS_2);//call SetBuildUnit( 1, NECROPOLIS_2		)
			SetBuildUnit(3, CommonAi.SLAUGHTERHOUSE);//call SetBuildUnit( 3, SLAUGHTERHOUSE	)
			SetBuildUnit(2, CommonAi.DAMNED_TEMPLE);//call SetBuildUnit( 2, DAMNED_TEMPLE		)
			SetBuildUnit(1, CommonAi.NECROPOLIS_3);//call SetBuildUnit( 1, NECROPOLIS_3		)
			SetBuildUnit(1, CommonAi.BONEYARD);//call SetBuildUnit( 1, BONEYARD			)
			SetBuildUnit(5, CommonAi.ACOLYTE);//call SetBuildUnit( 5, ACOLYTE			)
			SetBuildUnit(8, CommonAi.ZIGGURAT_2);//call SetBuildUnit( 8, ZIGGURAT_2		)
			CampaignDefenderEx(1, 1, 2, CommonAi.ABOMINATION);//call CampaignDefenderEx( 1,1,2, ABOMINATION	)
			CampaignDefenderEx(1, 1, 1, CommonAi.NECRO);//call CampaignDefenderEx( 1,1,1, NECRO		)
			CampaignDefenderEx(2, 2, 2, CommonAi.GHOUL);//call CampaignDefenderEx( 2,2,2, GHOUL		)
			CampaignDefenderEx(1, 1, 1, CommonAi.CRYPT_FIEND);//call CampaignDefenderEx( 1,1,1, CRYPT_FIEND	)
			CampaignDefenderEx(1, 1, 1, CommonAi.LICH);//call CampaignDefenderEx( 1,1,1, LICH		)
			WaitForSignal();//call WaitForSignal()
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(4, 4, 6, CommonAi.GHOUL);//call CampaignAttackerEx( 4,4,6, GHOUL        )
			CampaignAttackerEx(2, 2, 3, CommonAi.ABOMINATION);//call CampaignAttackerEx( 2,2,3, ABOMINATION  )
			CampaignAttackerEx(2, 2, 3, CommonAi.NECRO);//call CampaignAttackerEx( 2,2,3, NECRO        )
			SuicideOnPlayerEx(CommonAi.M2, CommonAi.M2, CommonAi.M1, U08_tealAi.user);//call SuicideOnPlayerEx(M2,M2,M1,user)
			SetBuildUpgrEx(1, 1, 1, CommonAi.UPG_FIEND_WEB);//call SetBuildUpgrEx( 1,1,1, UPG_FIEND_WEB	)
			SetBuildUpgrEx(1, 1, 1, CommonAi.UPG_CANNIBALIZE);//call SetBuildUpgrEx( 1,1,1, UPG_CANNIBALIZE )
			SetBuildUpgrEx(1, 1, 1, CommonAi.UPG_UNHOLY_STR);//call SetBuildUpgrEx( 1,1,1, UPG_UNHOLY_STR  )
			SetBuildUpgrEx(1, 1, 1, CommonAi.UPG_CR_ATTACK);//call SetBuildUpgrEx( 1,1,1, UPG_CR_ATTACK   )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2, 2, 4, CommonAi.GHOUL);//call CampaignAttackerEx( 2,2,4, GHOUL        )
			CampaignAttackerEx(1, 1, 2, CommonAi.ABOMINATION);//call CampaignAttackerEx( 1,1,2, ABOMINATION  )
			CampaignAttackerEx(2, 2, 4, CommonAi.CRYPT_FIEND);//call CampaignAttackerEx( 2,2,4, CRYPT_FIEND  )
			CampaignAttackerEx(1, 1, 2, CommonAi.MEAT_WAGON);//call CampaignAttackerEx( 1,1,2, MEAT_WAGON   )
			SuicideOnPlayerEx(CommonAi.M6, CommonAi.M6, CommonAi.M4, U08_tealAi.user);//call SuicideOnPlayerEx(M6,M6,M4,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(4, 4, 5, CommonAi.GHOUL);//call CampaignAttackerEx( 4,4,5, GHOUL		)
			CampaignAttackerEx(2, 2, 3, CommonAi.ABOMINATION);//call CampaignAttackerEx( 2,2,3, ABOMINATION )
			CampaignAttackerEx(1, 1, 2, CommonAi.NECRO);//call CampaignAttackerEx( 1,1,2, NECRO       )
			CampaignAttackerEx(1, 1, 2, CommonAi.BANSHEE);//call CampaignAttackerEx( 1,1,2, BANSHEE		)
			CampaignAttackerEx(1, 1, 1, CommonAi.LICH);//call CampaignAttackerEx( 1,1,1, LICH		)
			SuicideOnPlayerEx(CommonAi.M6, CommonAi.M6, CommonAi.M4, U08_tealAi.user);//call SuicideOnPlayerEx(M6,M6,M4,user)
			SetBuildUpgrEx(2, 2, 2, CommonAi.UPG_UNHOLY_STR);//call SetBuildUpgrEx( 2,2,2, UPG_UNHOLY_STR  )
			SetBuildUpgrEx(2, 2, 2, CommonAi.UPG_CR_ATTACK);//call SetBuildUpgrEx( 2,2,2, UPG_CR_ATTACK   )
			SetBuildUpgrEx(1, 1, 1, CommonAi.UPG_SKEL_LIFE);//call SetBuildUpgrEx( 1,1,1, UPG_SKEL_LIFE   )
			SetBuildUpgrEx(1, 1, 1, CommonAi.UPG_WYRM_BREATH);//call SetBuildUpgrEx( 1,1,1, UPG_WYRM_BREATH )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(3, 3, 4, CommonAi.CRYPT_FIEND);//call CampaignAttackerEx( 3,3,4, CRYPT_FIEND  )
			CampaignAttackerEx(4, 4, 6, CommonAi.ABOMINATION);//call CampaignAttackerEx( 4,4,6, ABOMINATION  )
			CampaignAttackerEx(2, 2, 4, CommonAi.MEAT_WAGON);//call CampaignAttackerEx( 2,2,4, MEAT_WAGON   )
			SuicideOnPlayerEx(CommonAi.M6, CommonAi.M6, CommonAi.M4, U08_tealAi.user);//call SuicideOnPlayerEx(M6,M6,M4,user)
			SetBuildUpgrEx(1, 1, 1, CommonAi.UPG_PLAGUE);//call SetBuildUpgrEx( 1,1,1, UPG_PLAGUE      )
			SetBuildUpgrEx(2, 2, 2, CommonAi.UPG_UNHOLY_ARMOR);//call SetBuildUpgrEx( 2,2,2, UPG_UNHOLY_ARMOR)
			SetBuildUpgrEx(2, 2, 2, CommonAi.UPG_CR_ARMOR);//call SetBuildUpgrEx( 2,2,2, UPG_CR_ARMOR	)
			SetBuildUpgrEx(2, 2, 2, CommonAi.UPG_NECROS);//call SetBuildUpgrEx( 2,2,2, UPG_NECROS      )
			SetBuildUpgrEx(2, 2, 2, CommonAi.UPG_BANSHEE);//call SetBuildUpgrEx( 2,2,2, UPG_BANSHEE		)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(3, 3, 5, CommonAi.ABOMINATION);//call CampaignAttackerEx( 3,3,5, ABOMINATION )
			CampaignAttackerEx(4, 4, 6, CommonAi.NECRO);//call CampaignAttackerEx( 4,4,6, NECRO		)
			CampaignAttackerEx(1, 1, 1, CommonAi.LICH);//call CampaignAttackerEx( 1,1,1, LICH		)
			CampaignAttackerEx(1, 1, 2, CommonAi.MEAT_WAGON);//call CampaignAttackerEx( 1,1,2, MEAT_WAGON  )
			SuicideOnPlayerEx(CommonAi.M6, CommonAi.M6, CommonAi.M4, U08_tealAi.user);//call SuicideOnPlayerEx(M6,M6,M4,user)
			SetBuildUpgrEx(2, 2, 3, CommonAi.UPG_UNHOLY_STR);//call SetBuildUpgrEx( 2,2,3, UPG_UNHOLY_STR  )
			SetBuildUpgrEx(2, 2, 3, CommonAi.UPG_CR_ATTACK);//call SetBuildUpgrEx( 2,2,3, UPG_CR_ATTACK   )
			SetBuildUpgrEx(1, 1, 1, CommonAi.UPG_GHOUL_FRENZY);//call SetBuildUpgrEx( 1,1,1, UPG_GHOUL_FRENZY)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(3, 3, 5, CommonAi.ABOMINATION);//call CampaignAttackerEx( 3,3,5, ABOMINATION )
			CampaignAttackerEx(4, 4, 6, CommonAi.BANSHEE);//call CampaignAttackerEx( 4,4,6, BANSHEE		)
			CampaignAttackerEx(1, 1, 1, CommonAi.LICH);//call CampaignAttackerEx( 1,1,1, LICH		)
			CampaignAttackerEx(1, 1, 2, CommonAi.MEAT_WAGON);//call CampaignAttackerEx( 1,1,2, MEAT_WAGON  )
			SuicideOnPlayerEx(CommonAi.M6, CommonAi.M6, CommonAi.M4, U08_tealAi.user);//call SuicideOnPlayerEx(M6,M6,M4,user)
			SetBuildUpgrEx(2, 2, 3, CommonAi.UPG_UNHOLY_ARMOR);//call SetBuildUpgrEx( 2,2,3, UPG_UNHOLY_ARMOR)
			SetBuildUpgrEx(2, 2, 3, CommonAi.UPG_CR_ARMOR);//call SetBuildUpgrEx( 2,2,3, UPG_CR_ARMOR	)
			SetBuildUpgrEx(1, 1, 1, CommonAi.UPG_MEAT_WAGON);//call SetBuildUpgrEx( 1,1,1, UPG_MEAT_WAGON	)
			while (true) {//loop
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(10, 10, 12, CommonAi.GHOUL);//call CampaignAttackerEx( 10,10,12, GHOUL	)
				CampaignAttackerEx(2, 2, 3, CommonAi.ABOMINATION);//call CampaignAttackerEx( 2,2,3, ABOMINATION )
				CampaignAttackerEx(2, 2, 3, CommonAi.NECRO);//call CampaignAttackerEx( 2,2,3, NECRO		)
				CampaignAttackerEx(1, 1, 1, CommonAi.LICH);//call CampaignAttackerEx( 1,1,1, LICH		)
				CampaignAttackerEx(1, 1, 2, CommonAi.MEAT_WAGON);//call CampaignAttackerEx( 1,1,2, MEAT_WAGON  )
				SuicideOnPlayerEx(CommonAi.M6, CommonAi.M6, CommonAi.M4, U08_tealAi.user);//call SuicideOnPlayerEx(M6,M6,M4,user)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(3, 3, 5, CommonAi.ABOMINATION);//call CampaignAttackerEx( 3,3,5, ABOMINATION )
				CampaignAttackerEx(3, 3, 4, CommonAi.CRYPT_FIEND);//call CampaignAttackerEx( 3,3,4, CRYPT_FIEND  )
				CampaignAttackerEx(4, 4, 6, CommonAi.BANSHEE);//call CampaignAttackerEx( 4,4,6, BANSHEE		)
				CampaignAttackerEx(1, 1, 1, CommonAi.LICH);//call CampaignAttackerEx( 1,1,1, LICH		)
				CampaignAttackerEx(2, 2, 3, CommonAi.MEAT_WAGON);//call CampaignAttackerEx( 2,2,3, MEAT_WAGON  )
				SuicideOnPlayerEx(CommonAi.M6, CommonAi.M6, CommonAi.M4, U08_tealAi.user);//call SuicideOnPlayerEx(M6,M6,M4,user)
			}//endloop
		}//endfunction

	
	}
}

