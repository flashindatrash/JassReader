using System;
using System.Collections.Generic;

namespace Jass {

	public class U06x04Ai {

		//
		//
		//
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(ZIGGURAT_1,null);//call CampaignAI(ZIGGURAT_1,null)
			SetReplacements(3,3,5);//call SetReplacements(3,3,5)
			campaign_wood_peons = 2;//set campaign_wood_peons = 2
			GroupTimedLife(true);//call GroupTimedLife(true)
			SetBuildUnitEx(5, 5, 5, ACOLYTE);//call SetBuildUnitEx( 5, 5, 5, ACOLYTE           )
			SetBuildUpgrEx(1, 1, 1, UPG_BLK_SPHINX);//call SetBuildUpgrEx( 1, 1, 1, UPG_BLK_SPHINX    )
			CampaignDefenderEx(1, 1, 1, ABOMINATION);//call CampaignDefenderEx( 1, 1, 1, ABOMINATION   )
			CampaignDefenderEx(1, 1, 1, OBS_STATUE);//call CampaignDefenderEx( 1, 1, 1, OBS_STATUE    )
			CampaignDefenderEx(1, 1, 1, FROST_WYRM);//call CampaignDefenderEx( 1, 1, 1, FROST_WYRM	)
			CampaignDefenderEx(0, 0, 1, CRYPT_FIEND);//call CampaignDefenderEx( 0, 0, 1, CRYPT_FIEND	)
			CampaignDefenderEx(0, 0, 1, BALNAZZAR);//call CampaignDefenderEx( 0, 0, 1, BALNAZZAR		)
			CampaignDefenderEx(0, 0, 1, DOOMGUARD);//call CampaignDefenderEx( 0, 0, 1, DOOMGUARD		)
			CampaignDefenderEx(1, 1, 1, FELLHOUND);//call CampaignDefenderEx( 1, 1, 1, FELLHOUND 	)
			WaitForSignal();//call WaitForSignal()
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(1,1,1,	DOOMGUARD);//call CampaignAttackerEx( 1,1,1,	DOOMGUARD	)
			CampaignAttackerEx(6,6,8,	GHOUL);//call CampaignAttackerEx( 6,6,8,	GHOUL		)
			SuicideOnPlayerEx(M7,M7,M6,sylvie);//call SuicideOnPlayerEx(M7,M7,M6,sylvie)
			SetBuildUpgrEx(0,0,1, UPG_UNHOLY_STR);//call SetBuildUpgrEx( 0,0,1, UPG_UNHOLY_STR  )
			SetBuildUpgrEx(0,1,1, UPG_CR_ATTACK);//call SetBuildUpgrEx( 0,1,1, UPG_CR_ATTACK   )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(1,1,1,	BALNAZZAR);//call CampaignAttackerEx( 1,1,1,	BALNAZZAR	)
			SuicideOnPlayerEx(M7,M7,M5,garit);//call SuicideOnPlayerEx(M7,M7,M5,garit)
			SetBuildUpgrEx(0,0,1, UPG_UNHOLY_ARMOR);//call SetBuildUpgrEx( 0,0,1, UPG_UNHOLY_ARMOR)
			SetBuildUpgrEx(0,0,1, UPG_CR_ARMOR);//call SetBuildUpgrEx( 0,0,1, UPG_CR_ARMOR	)
			SetBuildUpgrEx(1,1,1, UPG_NECROS);//call SetBuildUpgrEx( 1,1,1, UPG_NECROS		)
			SetBuildUpgrEx(1,1,1, UPG_GHOUL_FRENZY);//call SetBuildUpgrEx( 1,1,1, UPG_GHOUL_FRENZY)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(1,1,1,	BALNAZZAR);//call CampaignAttackerEx( 1,1,1,	BALNAZZAR	)
			SuicideOnPlayerEx(M6,M6,M5,sylvie);//call SuicideOnPlayerEx(M6,M6,M5,sylvie)
			SetBuildUpgrEx(1,1,1, UPG_PLAGUE);//call SetBuildUpgrEx( 1,1,1, UPG_PLAGUE		)
			SetBuildUpgrEx(1,1,1, UPG_WYRM_BREATH);//call SetBuildUpgrEx( 1,1,1, UPG_WYRM_BREATH )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(1,1,1,	BALNAZZAR);//call CampaignAttackerEx( 1,1,1,	BALNAZZAR	)
			SuicideOnPlayerEx(M7,M7,M5,garit);//call SuicideOnPlayerEx(M7,M7,M5,garit)
			SetBuildUpgrEx(1,1,2, UPG_UNHOLY_STR);//call SetBuildUpgrEx( 1,1,2, UPG_UNHOLY_STR  )
			SetBuildUpgrEx(1,1,2, UPG_CR_ATTACK);//call SetBuildUpgrEx( 1,1,2, UPG_CR_ATTACK   )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(1,1,2,	DOOMGUARD);//call CampaignAttackerEx( 1,1,2,	DOOMGUARD	)
			CampaignAttackerEx(4,4,5,	ABOMINATION);//call CampaignAttackerEx( 4,4,5,	ABOMINATION	)
			CampaignAttackerEx(1,1,2,	MEAT_WAGON);//call CampaignAttackerEx( 1,1,2,	MEAT_WAGON	)
			SuicideOnPlayerEx(M6,M6,M5,sylvie);//call SuicideOnPlayerEx(M6,M6,M5,sylvie)
			SetBuildUpgrEx(1,1,2, UPG_UNHOLY_ARMOR);//call SetBuildUpgrEx( 1,1,2, UPG_UNHOLY_ARMOR)
			SetBuildUpgrEx(1,1,2, UPG_CR_ARMOR);//call SetBuildUpgrEx( 1,1,2, UPG_CR_ARMOR    )
			SetBuildUpgrEx(2,2,2, UPG_NECROS);//call SetBuildUpgrEx( 2,2,2, UPG_NECROS		)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(1,1,1,	BALNAZZAR);//call CampaignAttackerEx( 1,1,1,	BALNAZZAR	)
			SuicideOnPlayerEx(M7,M7,M5,garit);//call SuicideOnPlayerEx(M7,M7,M5,garit)
			SetBuildUpgrEx(2,2,3, UPG_UNHOLY_STR);//call SetBuildUpgrEx( 2,2,3, UPG_UNHOLY_STR  )
			SetBuildUpgrEx(2,2,3, UPG_CR_ATTACK);//call SetBuildUpgrEx( 2,2,3, UPG_CR_ATTACK   )
			//
			while (true) {//loop
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(1,1,1,	BALNAZZAR);//call CampaignAttackerEx( 1,1,1,	BALNAZZAR	)
				SuicideOnPlayerEx(M7,M7,M5,sylvie);//call SuicideOnPlayerEx(M7,M7,M5,sylvie)
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(1,1,2,	DOOMGUARD);//call CampaignAttackerEx( 1,1,2,	DOOMGUARD	)
				CampaignAttackerEx(4,4,4,	ABOMINATION);//call CampaignAttackerEx( 4,4,4,	ABOMINATION	)
				CampaignAttackerEx(1,1,2,	MEAT_WAGON);//call CampaignAttackerEx( 1,1,2,	MEAT_WAGON	)
				SuicideOnPlayerEx(M7,M7,M5,garit);//call SuicideOnPlayerEx(M7,M7,M5,garit)
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(1,1,1,	BALNAZZAR);//call CampaignAttackerEx( 1,1,1,	BALNAZZAR	)
				SuicideOnPlayerEx(M7,M7,M5,sylvie);//call SuicideOnPlayerEx(M7,M7,M5,sylvie)
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(1,1,1,	BALNAZZAR);//call CampaignAttackerEx( 1,1,1,	BALNAZZAR	)
				SuicideOnPlayerEx(M7,M7,M5,garit);//call SuicideOnPlayerEx(M7,M7,M5,garit)
			}//endloop
		}//endfunction

	
	}
}

