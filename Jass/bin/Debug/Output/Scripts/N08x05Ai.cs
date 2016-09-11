using System;
using System.Collections.Generic;

namespace Jass {

	public class N08x05Ai {

		//
		//
		//
		public static player user = PlayerEx(3);//player user = PlayerEx(3)
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(CommonAi.ZIGGURAT_1, null);//call CampaignAI(ZIGGURAT_1,null)
			SetReplacements(1, 1, 3);//call SetReplacements(1,1,3)
			DoCampaignFarms(false);//call DoCampaignFarms(false)
			SetBuildUpgrEx(1, 1, 1, CommonAi.UPG_BLK_SPHINX);//call SetBuildUpgrEx( 1, 1, 1, UPG_BLK_SPHINX    )
			CampaignDefenderEx(1, 1, 2, CommonAi.ABOMINATION);//call CampaignDefenderEx( 1, 1, 2, ABOMINATION   )
			CampaignDefenderEx(1, 1, 2, CommonAi.NECRO);//call CampaignDefenderEx( 1, 1, 2, NECRO         )
			CampaignDefenderEx(0, 0, 1, CommonAi.FROST_WYRM);//call CampaignDefenderEx( 0, 0, 1, FROST_WYRM    )
			CampaignDefenderEx(1, 1, 1, CommonAi.GARGOYLE);//call CampaignDefenderEx( 1, 1, 1, GARGOYLE      )
			CampaignDefenderEx(0, 0, 1, CommonAi.DREAD_LORD);//call CampaignDefenderEx( 0, 0, 1, DREAD_LORD    )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(3, 3, 3, CommonAi.GARGOYLE);//call CampaignAttackerEx( 3,3,3, GARGOYLE    )
			CampaignAttackerEx(3, 3, 3, CommonAi.GHOUL);//call CampaignAttackerEx( 3,3,3, GHOUL       )
			CampaignAttackerEx(3, 3, 3, CommonAi.CRYPT_FIEND);//call CampaignAttackerEx( 3,3,3, CRYPT_FIEND )
			SuicideOnPlayerEx(CommonAi.M1, CommonAi.M1, CommonAi.M1, U08_tealAi.user);//call SuicideOnPlayerEx(M1,M1,M1,user)
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_UNHOLY_STR);//call SetBuildUpgrEx( 0,0,1, UPG_UNHOLY_STR  )
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_CR_ATTACK);//call SetBuildUpgrEx( 0,0,1, UPG_CR_ATTACK   )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(5, 5, 5, CommonAi.GHOUL);//call CampaignAttackerEx( 5,5,5, GHOUL       )
			SuicideOnPlayerEx(CommonAi.M2, CommonAi.M2, CommonAi.M2, U08_tealAi.user);//call SuicideOnPlayerEx(M2,M2,M2,user)
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_UNHOLY_ARMOR);//call SetBuildUpgrEx( 0,0,1, UPG_UNHOLY_ARMOR)
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_CR_ARMOR);//call SetBuildUpgrEx( 0,0,1, UPG_CR_ARMOR    )
			SetBuildUpgrEx(1, 1, 2, CommonAi.UPG_NECROS);//call SetBuildUpgrEx( 1,1,2, UPG_NECROS      )
			SetBuildUpgrEx(1, 1, 2, CommonAi.UPG_BANSHEE);//call SetBuildUpgrEx( 1,1,2, UPG_BANSHEE     )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(3, 3, 3, CommonAi.GARGOYLE);//call CampaignAttackerEx( 3,3,3, GARGOYLE    )
			CampaignAttackerEx(4, 4, 4, CommonAi.NECRO);//call CampaignAttackerEx( 4,4,4, NECRO       )
			SuicideOnPlayerEx(CommonAi.M2, CommonAi.M2, CommonAi.M2, U08_tealAi.user);//call SuicideOnPlayerEx(M2,M2,M2,user)
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_PLAGUE);//call SetBuildUpgrEx( 0,0,1, UPG_PLAGUE        )
			SetBuildUpgrEx(1, 1, 2, CommonAi.UPG_UNHOLY_STR);//call SetBuildUpgrEx( 1,1,2, UPG_UNHOLY_STR    )
			SetBuildUpgrEx(1, 1, 2, CommonAi.UPG_CR_ATTACK);//call SetBuildUpgrEx( 1,1,2, UPG_CR_ATTACK     )
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_SKEL_MASTERY);//call SetBuildUpgrEx( 0,0,1, UPG_SKEL_MASTERY  )
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_WYRM_BREATH);//call SetBuildUpgrEx( 0,0,1, UPG_WYRM_BREATH   )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(4, 4, 4, CommonAi.NECRO);//call CampaignAttackerEx( 4,4,4, NECRO       )
			CampaignAttackerEx(2, 2, 2, CommonAi.GHOUL);//call CampaignAttackerEx( 2,2,2, GHOUL       )
			CampaignAttackerEx(2, 2, 2, CommonAi.GARGOYLE);//call CampaignAttackerEx( 2,2,2, GARGOYLE    )
			SuicideOnPlayerEx(CommonAi.M2, CommonAi.M2, CommonAi.M2, U08_tealAi.user);//call SuicideOnPlayerEx(M2,M2,M2,user)
			SetBuildUpgrEx(1, 1, 2, CommonAi.UPG_UNHOLY_ARMOR);//call SetBuildUpgrEx( 1,1,2, UPG_UNHOLY_ARMOR)
			SetBuildUpgrEx(1, 1, 2, CommonAi.UPG_CR_ARMOR);//call SetBuildUpgrEx( 1,1,2, UPG_CR_ARMOR    )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(3, 3, 3, CommonAi.GARGOYLE);//call CampaignAttackerEx( 3,3,3, GARGOYLE    )
			CampaignAttackerEx(2, 2, 2, CommonAi.ABOMINATION);//call CampaignAttackerEx( 2,2,2, ABOMINATION )
			SuicideOnPlayerEx(CommonAi.M2, CommonAi.M2, CommonAi.M2, U08_tealAi.user);//call SuicideOnPlayerEx(M2,M2,M2,user)
			SetBuildUpgrEx(2, 2, 3, CommonAi.UPG_UNHOLY_STR);//call SetBuildUpgrEx( 2,2,3, UPG_UNHOLY_STR  )
			SetBuildUpgrEx(2, 2, 3, CommonAi.UPG_CR_ATTACK);//call SetBuildUpgrEx( 2,2,3, UPG_CR_ATTACK   )
			SetBuildUpgrEx(1, 1, 1, CommonAi.UPG_GHOUL_FRENZY);//call SetBuildUpgrEx( 1,1,1, UPG_GHOUL_FRENZY)
			SetBuildUpgrEx(1, 1, 1, CommonAi.UPG_SKEL_MASTERY);//call SetBuildUpgrEx( 1,1,1, UPG_SKEL_MASTERY)
			SetBuildUpgrEx(1, 1, 1, CommonAi.UPG_WYRM_BREATH);//call SetBuildUpgrEx( 1,1,1, UPG_WYRM_BREATH )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(1, 1, 1, CommonAi.ABOMINATION);//call CampaignAttackerEx( 1,1,1, ABOMINATION )
			CampaignAttackerEx(3, 3, 3, CommonAi.NECRO);//call CampaignAttackerEx( 3,3,3, NECRO       )
			CampaignAttackerEx(2, 2, 2, CommonAi.GHOUL);//call CampaignAttackerEx( 2,2,2, GHOUL       )
			CampaignAttackerEx(2, 2, 2, CommonAi.GARGOYLE);//call CampaignAttackerEx( 2,2,2, GARGOYLE    )
			SuicideOnPlayerEx(CommonAi.M2, CommonAi.M2, CommonAi.M2, U08_tealAi.user);//call SuicideOnPlayerEx(M2,M2,M2,user)
			SetBuildUpgrEx(2, 2, 3, CommonAi.UPG_UNHOLY_ARMOR);//call SetBuildUpgrEx( 2,2,3, UPG_UNHOLY_ARMOR)
			SetBuildUpgrEx(2, 2, 3, CommonAi.UPG_CR_ARMOR);//call SetBuildUpgrEx( 2,2,3, UPG_CR_ARMOR    )
			SetBuildUpgrEx(1, 1, 1, CommonAi.UPG_PLAGUE);//call SetBuildUpgrEx( 1,1,1, UPG_PLAGUE      )
			SetBuildUpgrEx(2, 2, 2, CommonAi.UPG_NECROS);//call SetBuildUpgrEx( 2,2,2, UPG_NECROS      )
			SetBuildUpgrEx(2, 2, 2, CommonAi.UPG_BANSHEE);//call SetBuildUpgrEx( 2,2,2, UPG_BANSHEE     )
			while (true) {//loop
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(1, 1, 1, CommonAi.FROST_WYRM);//call CampaignAttackerEx( 1,1,1, FROST_WYRM  )
				CampaignAttackerEx(3, 3, 3, CommonAi.GARGOYLE);//call CampaignAttackerEx( 3,3,3, GARGOYLE    )
				SuicideOnPlayerEx(CommonAi.M2, CommonAi.M2, CommonAi.M2, U08_tealAi.user);//call SuicideOnPlayerEx(M2,M2,M2,user)
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(2, 2, 2, CommonAi.BANSHEE);//call CampaignAttackerEx( 2,2,2, BANSHEE     )
				CampaignAttackerEx(8, 8, 8, CommonAi.GHOUL);//call CampaignAttackerEx( 8,8,8, GHOUL       )
				SuicideOnPlayerEx(CommonAi.M2, CommonAi.M2, CommonAi.M2, U08_tealAi.user);//call SuicideOnPlayerEx(M2,M2,M2,user)
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(3, 3, 3, CommonAi.GARGOYLE);//call CampaignAttackerEx( 3,3,3, GARGOYLE    )
				CampaignAttackerEx(1, 1, 1, CommonAi.ABOMINATION);//call CampaignAttackerEx( 1,1,1, ABOMINATION )
				CampaignAttackerEx(3, 3, 3, CommonAi.NECRO);//call CampaignAttackerEx( 3,3,3, NECRO       )
				SuicideOnPlayerEx(CommonAi.M2, CommonAi.M2, CommonAi.M2, U08_tealAi.user);//call SuicideOnPlayerEx(M2,M2,M2,user)
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(1, 1, 1, CommonAi.ABOMINATION);//call CampaignAttackerEx( 1,1,1, ABOMINATION )
				CampaignAttackerEx(4, 4, 4, CommonAi.NECRO);//call CampaignAttackerEx( 4,4,4, NECRO       )
				CampaignAttackerEx(2, 2, 2, CommonAi.GHOUL);//call CampaignAttackerEx( 2,2,2, GHOUL       )
				SuicideOnPlayerEx(CommonAi.M2, CommonAi.M2, CommonAi.M2, U08_tealAi.user);//call SuicideOnPlayerEx(M2,M2,M2,user)
			}//endloop
		}//endfunction

	
	}
}

