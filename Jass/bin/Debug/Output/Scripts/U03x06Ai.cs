using System;
using System.Collections.Generic;

namespace Jass {

	public class U03x06Ai {

		//
		//
		//
		public static player user = PlayerEx(2);//player user = PlayerEx(2)
		public const int VARIMATHRAS = 'Uvar';//constant integer VARIMATHRAS    = 'Uvar'
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
			SetBuildUnitEx(0, 0, 8, ZIGGURAT_1);//call SetBuildUnitEx( 0, 0, 8, ZIGGURAT_1        )
			SetBuildUnitEx(0, 0, 1, GRAVEYARD);//call SetBuildUnitEx( 0, 0, 1, GRAVEYARD         )
			SetBuildUnitEx(0, 0, 1, UNDEAD_ALTAR);//call SetBuildUnitEx( 0, 0, 1, UNDEAD_ALTAR      )
			SetBuildUnitEx(0, 0, 1, NECROPOLIS_2);//call SetBuildUnitEx( 0, 0, 1, NECROPOLIS_2      )
			SetBuildUnitEx(0, 0, 1, DAMNED_TEMPLE);//call SetBuildUnitEx( 0, 0, 1, DAMNED_TEMPLE     )
			SetBuildUnitEx(0, 0, 2, SLAUGHTERHOUSE);//call SetBuildUnitEx( 0, 0, 2, SLAUGHTERHOUSE    )
			SetBuildUnitEx(0, 0, 6, ZIGGURAT_2);//call SetBuildUnitEx( 0, 0, 6, ZIGGURAT_2        )
			SetBuildUnitEx(0, 0, 2, ZIGGURAT_FROST);//call SetBuildUnitEx( 0, 0, 2, ZIGGURAT_FROST    )
			SetBuildUnitEx(0, 0, 1, NECROPOLIS_3);//call SetBuildUnitEx( 0, 0, 1, NECROPOLIS_3      )
			SetBuildUnitEx(5, 5, 5, ACOLYTE);//call SetBuildUnitEx( 5, 5, 5, ACOLYTE           )
			CampaignDefenderEx(0, 0, 1, VARIMATHRAS);//call CampaignDefenderEx( 0, 0, 1, VARIMATHRAS	)
			CampaignDefenderEx(1, 1, 1, ABOMINATION);//call CampaignDefenderEx( 1, 1, 1, ABOMINATION   )
			CampaignDefenderEx(1, 1, 1, NECRO);//call CampaignDefenderEx( 1, 1, 1, NECRO			)
			SetBuildUpgrEx(1,1,1, UPG_EXHUME);//call SetBuildUpgrEx( 1,1,1, UPG_EXHUME		)
			SetBuildUpgrEx(0,0,1, UPG_GHOUL_FRENZY);//call SetBuildUpgrEx( 0,0,1, UPG_GHOUL_FRENZY)
			SetBuildUpgrEx(1,1,1, UPG_FIEND_WEB);//call SetBuildUpgrEx( 1,1,1, UPG_FIEND_WEB	)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2,2,4,	ABOMINATION);//call CampaignAttackerEx( 2,2,4,	ABOMINATION	)
			CampaignAttackerEx(0,0,1,	VARIMATHRAS);//call CampaignAttackerEx( 0,0,1,	VARIMATHRAS )
			SuicideOnPlayer(10,user);//call SuicideOnPlayer(10,user)
			SetBuildUpgrEx(0,0,1, UPG_UNHOLY_STR);//call SetBuildUpgrEx( 0,0,1, UPG_UNHOLY_STR  )
			SetBuildUpgrEx(0,1,1, UPG_CR_ATTACK);//call SetBuildUpgrEx( 0,1,1, UPG_CR_ATTACK   )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(4,4,6,	NECRO);//call CampaignAttackerEx( 4,4,6,	NECRO		)
			SuicideOnPlayerEx(M5,M5,M3,user);//call SuicideOnPlayerEx(M5,M5,M3,user)
			SetBuildUpgrEx(0,0,1, UPG_UNHOLY_ARMOR);//call SetBuildUpgrEx( 0,0,1, UPG_UNHOLY_ARMOR)
			SetBuildUpgrEx(0,0,1, UPG_CR_ARMOR);//call SetBuildUpgrEx( 0,0,1, UPG_CR_ARMOR	)
			SetBuildUpgrEx(0,0,1, UPG_NECROS);//call SetBuildUpgrEx( 0,0,1, UPG_NECROS		)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(1,1,1,	VARIMATHRAS);//call CampaignAttackerEx( 1,1,1,	VARIMATHRAS  )
			CampaignAttackerEx(2,2,3,	ABOMINATION);//call CampaignAttackerEx( 2,2,3,	ABOMINATION	)
			CampaignAttackerEx(3,3,4,	NECRO);//call CampaignAttackerEx( 3,3,4,	NECRO		)
			SuicideOnPlayerEx(M5,M5,M3,user);//call SuicideOnPlayerEx(M5,M5,M3,user)
			SetBuildUpgrEx(1,1,1, UPG_SKEL_LIFE);//call SetBuildUpgrEx( 1,1,1, UPG_SKEL_LIFE	)
			SetBuildUpgrEx(0,0,1, UPG_SKEL_MASTERY);//call SetBuildUpgrEx( 0,0,1, UPG_SKEL_MASTERY)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(1,1,2,	MEAT_WAGON);//call CampaignAttackerEx( 1,1,2,	MEAT_WAGON  )
			CampaignAttackerEx(3,3,4,	ABOMINATION);//call CampaignAttackerEx( 3,3,4,	ABOMINATION	)
			CampaignAttackerEx(3,3,4,	NECRO);//call CampaignAttackerEx( 3,3,4,	NECRO		)
			SuicideOnPlayerEx(M5,M5,M3,user);//call SuicideOnPlayerEx(M5,M5,M3,user)
			SetBuildUpgrEx(1,1,2, UPG_UNHOLY_STR);//call SetBuildUpgrEx( 1,1,2, UPG_UNHOLY_STR  )
			SetBuildUpgrEx(1,1,2, UPG_CR_ATTACK);//call SetBuildUpgrEx( 1,1,2, UPG_CR_ATTACK   )
			SetBuildUpgrEx(1,1,1, UPG_SKEL_MASTERY);//call SetBuildUpgrEx( 1,1,1, UPG_SKEL_MASTERY)
			SetBuildUpgrEx(0,0,2, UPG_NECROS);//call SetBuildUpgrEx( 0,0,2, UPG_NECROS		)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(1,1,1,	VARIMATHRAS);//call CampaignAttackerEx( 1,1,1,	VARIMATHRAS )
			CampaignAttackerEx(5,5,6,	ABOMINATION);//call CampaignAttackerEx( 5,5,6,	ABOMINATION	)
			SuicideOnPlayerEx(M5,M5,M3,user);//call SuicideOnPlayerEx(M5,M5,M3,user)
			SetBuildUpgrEx(1,1,2, UPG_UNHOLY_ARMOR);//call SetBuildUpgrEx( 1,1,2, UPG_UNHOLY_ARMOR)
			SetBuildUpgrEx(1,1,2, UPG_CR_ARMOR);//call SetBuildUpgrEx( 1,1,2, UPG_CR_ARMOR    )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2,2,2,	MEAT_WAGON);//call CampaignAttackerEx( 2,2,2,	MEAT_WAGON  )
			CampaignAttackerEx(6,6,8,	NECRO);//call CampaignAttackerEx( 6,6,8,	NECRO		)
			SuicideOnPlayerEx(M5,M5,M3,user);//call SuicideOnPlayerEx(M5,M5,M3,user)
			SetBuildUpgrEx(2,2,3, UPG_UNHOLY_STR);//call SetBuildUpgrEx( 2,2,3, UPG_UNHOLY_STR  )
			SetBuildUpgrEx(2,2,3, UPG_CR_ATTACK);//call SetBuildUpgrEx( 2,2,3, UPG_CR_ATTACK   )
			SetBuildUpgrEx(1,1,1, UPG_GHOUL_FRENZY);//call SetBuildUpgrEx( 1,1,1, UPG_GHOUL_FRENZY)
			//
			while (true) {//loop
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(1,1,1,	VARIMATHRAS);//call CampaignAttackerEx( 1,1,1,	VARIMATHRAS )
				CampaignAttackerEx(3,3,3,	ABOMINATION);//call CampaignAttackerEx( 3,3,3,	ABOMINATION	)
				CampaignAttackerEx(3,3,4,	NECRO);//call CampaignAttackerEx( 3,3,4,	NECRO		)
				SuicideOnPlayerEx(M5,M5,M3,user);//call SuicideOnPlayerEx(M5,M5,M3,user)
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(2,2,2,	MEAT_WAGON);//call CampaignAttackerEx( 2,2,2,	MEAT_WAGON  )
				CampaignAttackerEx(6,6,8,	NECRO);//call CampaignAttackerEx( 6,6,8,	NECRO		)
				SuicideOnPlayerEx(M5,M5,M3,user);//call SuicideOnPlayerEx(M5,M5,M3,user)
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(1,1,1,	VARIMATHRAS);//call CampaignAttackerEx( 1,1,1,	VARIMATHRAS )
				CampaignAttackerEx(5,5,6,	ABOMINATION);//call CampaignAttackerEx( 5,5,6,	ABOMINATION	)
				SuicideOnPlayerEx(M5,M5,M3,user);//call SuicideOnPlayerEx(M5,M5,M3,user)
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(1,1,2,	MEAT_WAGON);//call CampaignAttackerEx( 1,1,2,	MEAT_WAGON  )
				CampaignAttackerEx(2,2,3,	ABOMINATION);//call CampaignAttackerEx( 2,2,3,	ABOMINATION	)
				CampaignAttackerEx(3,3,4,	NECRO);//call CampaignAttackerEx( 3,3,4,	NECRO		)
				SuicideOnPlayerEx(M5,M5,M3,user);//call SuicideOnPlayerEx(M5,M5,M3,user)
			}//endloop
		}//endfunction

	
	}
}

