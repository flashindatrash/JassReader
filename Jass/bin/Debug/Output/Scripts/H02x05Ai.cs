using System;
using System.Collections.Generic;

namespace Jass {

	public class H02x05Ai {

		//
		//
		//
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(ZIGGURAT_1,null);//call CampaignAI(ZIGGURAT_1,null)
			SetHarvestLumber(false);//call SetHarvestLumber(false)
			DoCampaignFarms(false);//call DoCampaignFarms(false)
			SetBuildUnitEx(1,1,1, ACOLYTE);//call SetBuildUnitEx( 1,1,1, ACOLYTE         )
			SetBuildUnitEx(1,1,1, UNDEAD_MINE);//call SetBuildUnitEx( 1,1,1, UNDEAD_MINE     )
			SetBuildUnitEx(1,1,1, NECROPOLIS_1);//call SetBuildUnitEx( 1,1,1, NECROPOLIS_1    )
			SetBuildUnitEx(5,5,5, ACOLYTE);//call SetBuildUnitEx( 5,5,5, ACOLYTE         )
			while (true) {//loop
				if (TownCountDone(NECROPOLIS_1) > 0) { break; }//exitwhen TownCountDone(NECROPOLIS_1) > 0
				Sleep(1);//call Sleep(1)
			}//endloop
			ResetCaptainLocs();//call ResetCaptainLocs()
			SetHarvestLumber(true);//call SetHarvestLumber(true)
			SetWoodPeons(2);//call SetWoodPeons(2)
			InitBuildArray();//call InitBuildArray()
			SetBuildUnitEx(0,0,2, UNDEAD_BARGE);//call SetBuildUnitEx( 0,0,2, UNDEAD_BARGE    )
			SetBuildUnitEx(5,5,5, ACOLYTE);//call SetBuildUnitEx( 5,5,5, ACOLYTE         )
			CampaignDefenderEx(1,1,1, GHOUL);//call CampaignDefenderEx( 1,1,1, GHOUL       )
			CampaignDefenderEx(0,0,1, CRYPT_FIEND);//call CampaignDefenderEx( 0,0,1, CRYPT_FIEND )
			CampaignDefenderEx(1,1,1, NECRO);//call CampaignDefenderEx( 1,1,1, NECRO       )
			CampaignDefenderEx(0,0,1, ABOMINATION);//call CampaignDefenderEx( 0,0,1, ABOMINATION )
			CampaignDefenderEx(1,1,1, OBS_STATUE);//call CampaignDefenderEx( 1,1,1, OBS_STATUE  )
			CampaignDefenderEx(1,1,1, BLK_SPHINX);//call CampaignDefenderEx( 1,1,1, BLK_SPHINX  )
			WaitForSignal();//call WaitForSignal()
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(4,4,6, CRYPT_FIEND);//call CampaignAttackerEx( 4,4,6, CRYPT_FIEND )
			SuicideOnPlayerEx(M1,M1,M1,user);//call SuicideOnPlayerEx(M1,M1,M1,user)
			SetBuildUpgrEx(0,0,1, UPG_UNHOLY_STR);//call SetBuildUpgrEx( 0,0,1, UPG_UNHOLY_STR  )
			SetBuildUpgrEx(0,0,1, UPG_CR_ATTACK);//call SetBuildUpgrEx( 0,0,1, UPG_CR_ATTACK   )
			SetBuildUpgrEx(0,0,1, UPG_SKEL_LIFE);//call SetBuildUpgrEx( 0,0,1, UPG_SKEL_LIFE   )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(6,6,7, GHOUL);//call CampaignAttackerEx( 6,6,7, GHOUL       )
			CampaignAttackerEx(2,2,3, BANSHEE);//call CampaignAttackerEx( 2,2,3, BANSHEE     )
			CampaignAttackerEx(1,1,1, MEAT_WAGON);//call CampaignAttackerEx( 1,1,1, MEAT_WAGON  )
			SuicideOnPlayerEx(M6,M6,M4,user);//call SuicideOnPlayerEx(M6,M6,M4,user)
			SetBuildUpgrEx(0,0,1, UPG_UNHOLY_ARMOR);//call SetBuildUpgrEx( 0,0,1, UPG_UNHOLY_ARMOR)
			SetBuildUpgrEx(0,0,1, UPG_CR_ARMOR);//call SetBuildUpgrEx( 0,0,1, UPG_CR_ARMOR    )
			SetBuildUpgrEx(1,1,2, UPG_NECROS);//call SetBuildUpgrEx( 1,1,2, UPG_NECROS      )
			SetBuildUpgrEx(1,1,2, UPG_BANSHEE);//call SetBuildUpgrEx( 1,1,2, UPG_BANSHEE     )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(4,4,0, GHOUL);//call CampaignAttackerEx( 4,4,0, GHOUL       )
			CampaignAttackerEx(2,2,4, CRYPT_FIEND);//call CampaignAttackerEx( 2,2,4, CRYPT_FIEND )
			CampaignAttackerEx(3,3,4, NECRO);//call CampaignAttackerEx( 3,3,4, NECRO       )
			CampaignAttackerEx(0,0,3, ABOMINATION);//call CampaignAttackerEx( 0,0,3, ABOMINATION )
			CampaignAttackerEx(0,0,1, MEAT_WAGON);//call CampaignAttackerEx( 0,0,1, MEAT_WAGON  )
			SuicideOnPlayerEx(M6,M6,M4,user);//call SuicideOnPlayerEx(M6,M6,M4,user)
			SetBuildUpgrEx(0,0,1, UPG_PLAGUE);//call SetBuildUpgrEx( 0,0,1, UPG_PLAGUE        )
			SetBuildUpgrEx(1,1,2, UPG_UNHOLY_STR);//call SetBuildUpgrEx( 1,1,2, UPG_UNHOLY_STR    )
			SetBuildUpgrEx(1,1,2, UPG_CR_ATTACK);//call SetBuildUpgrEx( 1,1,2, UPG_CR_ATTACK     )
			SetBuildUpgrEx(0,0,1, UPG_SKEL_MASTERY);//call SetBuildUpgrEx( 0,0,1, UPG_SKEL_MASTERY  )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2,2,3, BANSHEE);//call CampaignAttackerEx( 2,2,3, BANSHEE     )
			CampaignAttackerEx(5,5,7, CRYPT_FIEND);//call CampaignAttackerEx( 5,5,7, CRYPT_FIEND )
			CampaignAttackerEx(1,1,2, MEAT_WAGON);//call CampaignAttackerEx( 1,1,2, MEAT_WAGON  )
			SuicideOnPlayerEx(M6,M6,M4,user);//call SuicideOnPlayerEx(M6,M6,M4,user)
			SetBuildUpgrEx(1,1,2, UPG_UNHOLY_ARMOR);//call SetBuildUpgrEx( 1,1,2, UPG_UNHOLY_ARMOR)
			SetBuildUpgrEx(1,1,2, UPG_CR_ARMOR);//call SetBuildUpgrEx( 1,1,2, UPG_CR_ARMOR    )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(4,4,5, GHOUL);//call CampaignAttackerEx( 4,4,5, GHOUL       )
			CampaignAttackerEx(0,0,2, CRYPT_FIEND);//call CampaignAttackerEx( 0,0,2, CRYPT_FIEND )
			CampaignAttackerEx(5,5,7, NECRO);//call CampaignAttackerEx( 5,5,7, NECRO       )
			CampaignAttackerEx(0,0,1, MEAT_WAGON);//call CampaignAttackerEx( 0,0,1, MEAT_WAGON  )
			SuicideOnPlayerEx(M6,M6,M4,user);//call SuicideOnPlayerEx(M6,M6,M4,user)
			SetBuildUpgrEx(1,1,3, UPG_UNHOLY_STR);//call SetBuildUpgrEx( 1,1,3, UPG_UNHOLY_STR  )
			SetBuildUpgrEx(1,1,3, UPG_CR_ATTACK);//call SetBuildUpgrEx( 1,1,3, UPG_CR_ATTACK   )
			SetBuildUpgrEx(0,0,1, UPG_GHOUL_FRENZY);//call SetBuildUpgrEx( 0,0,1, UPG_GHOUL_FRENZY)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(3,3,4, BANSHEE);//call CampaignAttackerEx( 3,3,4, BANSHEE     )
			CampaignAttackerEx(0,0,3, ABOMINATION);//call CampaignAttackerEx( 0,0,3, ABOMINATION )
			CampaignAttackerEx(4,4,6, CRYPT_FIEND);//call CampaignAttackerEx( 4,4,6, CRYPT_FIEND )
			CampaignAttackerEx(1,1,2, MEAT_WAGON);//call CampaignAttackerEx( 1,1,2, MEAT_WAGON  )
			SuicideOnPlayerEx(M6,M6,M4,user);//call SuicideOnPlayerEx(M6,M6,M4,user)
			SetBuildUpgrEx(1,1,3, UPG_UNHOLY_ARMOR);//call SetBuildUpgrEx( 1,1,3, UPG_UNHOLY_ARMOR)
			SetBuildUpgrEx(1,1,3, UPG_CR_ARMOR);//call SetBuildUpgrEx( 1,1,3, UPG_CR_ARMOR    )
			SetBuildUpgrEx(1,1,2, UPG_NECROS);//call SetBuildUpgrEx( 1,1,2, UPG_NECROS      )
			SetBuildUpgrEx(1,1,2, UPG_BANSHEE);//call SetBuildUpgrEx( 1,1,2, UPG_BANSHEE     )
			//
			while (true) {//loop
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(0,0,3, ABOMINATION);//call CampaignAttackerEx( 0,0,3, ABOMINATION )
				CampaignAttackerEx(5,5,0, GHOUL);//call CampaignAttackerEx( 5,5,0, GHOUL       )
				CampaignAttackerEx(2,2,3, CRYPT_FIEND);//call CampaignAttackerEx( 2,2,3, CRYPT_FIEND )
				CampaignAttackerEx(4,4,6, NECRO);//call CampaignAttackerEx( 4,4,6, NECRO       )
				CampaignAttackerEx(1,1,2, MEAT_WAGON);//call CampaignAttackerEx( 1,1,2, MEAT_WAGON  )
				SuicideOnPlayerEx(M6,M6,M4,user);//call SuicideOnPlayerEx(M6,M6,M4,user)
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(3,3,4, CRYPT_FIEND);//call CampaignAttackerEx( 3,3,4, CRYPT_FIEND )
				CampaignAttackerEx(3,3,4, NECRO);//call CampaignAttackerEx( 3,3,4, NECRO       )
				CampaignAttackerEx(3,3,4, BANSHEE);//call CampaignAttackerEx( 3,3,4, BANSHEE     )
				CampaignAttackerEx(0,0,1, MEAT_WAGON);//call CampaignAttackerEx( 0,0,1, MEAT_WAGON  )
				SuicideOnPlayerEx(M6,M6,M4,user);//call SuicideOnPlayerEx(M6,M6,M4,user)
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(6,6,0, GHOUL);//call CampaignAttackerEx( 6,6,0, GHOUL       )
				CampaignAttackerEx(3,3,5, BANSHEE);//call CampaignAttackerEx( 3,3,5, BANSHEE     )
				CampaignAttackerEx(0,0,3, ABOMINATION);//call CampaignAttackerEx( 0,0,3, ABOMINATION )
				CampaignAttackerEx(1,1,2, MEAT_WAGON);//call CampaignAttackerEx( 1,1,2, MEAT_WAGON  )
				SuicideOnPlayerEx(M6,M6,M4,user);//call SuicideOnPlayerEx(M6,M6,M4,user)
			}//endloop
		}//endfunction

	
	}
}

