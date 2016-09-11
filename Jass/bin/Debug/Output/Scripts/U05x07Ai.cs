using System;
using System.Collections.Generic;

namespace Jass {

	public class U05x07Ai {

		//
		//
		//
		//
		//
		//
		private void check_base_deaths() {//function check_base_deaths takes nothing returns nothing
			if (difficulty == HARD) {//if difficulty == HARD then
				return;//return
			}//endif
			while (true) {//loop
				if (CommandsWaiting() != 0) { break; }//exitwhen CommandsWaiting() != 0
				Trace("check_base_deaths waiting for signal...\n");//call Trace("check_base_deaths waiting for signal...\n")
				Sleep(10);//call Sleep(10)
			}//endloop
			PopLastCommand();//call PopLastCommand()
			delay = fast_delay;//set delay = fast_delay
		}//endfunction
		//
		//
		//
		private void upgrade_towers() {//function upgrade_towers takes nothing returns nothing
			int count;//local integer count
			while (true) {//loop
				count = TownCountDone(ZIGGURAT_1);//set count = TownCountDone(ZIGGURAT_1)
				if (count > 0) {//if count > 0 then
					SetProduce(count,ZIGGURAT_2,-1);//call SetProduce(count,ZIGGURAT_2,-1)
				}//endif
				Sleep(1);//call Sleep(1)
			}//endloop
		}//endfunction
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(ZIGGURAT_1,null);//call CampaignAI(ZIGGURAT_1,null)
			SetReplacements(2,2,3);//call SetReplacements(2,2,3)
			campaign_wood_peons = 2;//set campaign_wood_peons = 2
			if (difficulty == HARD) {//if difficulty == HARD then
				delay = hard_delay;//set delay = hard_delay
			}//endif
			SetBuildUnitEx(1, 1, 1, ACOLYTE);//call SetBuildUnitEx( 1, 1, 1, ACOLYTE           )
			SetBuildUnitEx(1, 1, 1, NECROPOLIS_1);//call SetBuildUnitEx( 1, 1, 1, NECROPOLIS_1      )
			SetBuildUnitEx(0, 0, 1, UNDEAD_MINE);//call SetBuildUnitEx( 0, 0, 1, UNDEAD_MINE       )
			SetBuildUnitEx(0, 0, 1, CRYPT);//call SetBuildUnitEx( 0, 0, 1, CRYPT             )
			SetBuildUnitEx(0, 0, 8, ZIGGURAT_1);//call SetBuildUnitEx( 0, 0, 8, ZIGGURAT_1        )
			SetBuildUnitEx(0, 0, 1, GRAVEYARD);//call SetBuildUnitEx( 0, 0, 1, GRAVEYARD         )
			SetBuildUnitEx(0, 0, 1, UNDEAD_ALTAR);//call SetBuildUnitEx( 0, 0, 1, UNDEAD_ALTAR      )
			SetBuildUnitEx(1, 1, 1, NECROPOLIS_2);//call SetBuildUnitEx( 1, 1, 1, NECROPOLIS_2      )
			SetBuildUnitEx(0, 0, 1, SLAUGHTERHOUSE);//call SetBuildUnitEx( 0, 0, 1, SLAUGHTERHOUSE    )
			SetBuildUnitEx(0, 0, 1, DAMNED_TEMPLE);//call SetBuildUnitEx( 0, 0, 1, DAMNED_TEMPLE     )
			SetBuildUnitEx(1, 1, 1, NECROPOLIS_3);//call SetBuildUnitEx( 1, 1, 1, NECROPOLIS_3      )
			SetBuildUnitEx(0, 0, 1, BONEYARD);//call SetBuildUnitEx( 0, 0, 1, BONEYARD          )
			SetBuildUnitEx(5, 5, 5, ACOLYTE);//call SetBuildUnitEx( 5, 5, 5, ACOLYTE           )
			WaitForSignal();//call WaitForSignal()
			//
			SuicideOnce(3, 3, 5, GHOUL);//call SuicideOnce( 3, 3, 5, GHOUL        )
			SuicideOnce(1, 1, 2, ABOMINATION);//call SuicideOnce( 1, 1, 2, ABOMINATION  )
			SuicideOnce(1, 1, 1, FROST_WYRM);//call SuicideOnce( 1, 1, 1, FROST_WYRM   )
			SuicideOnce(2, 2, 3, CRYPT_FIEND);//call SuicideOnce( 2, 2, 3, CRYPT_FIEND  )
			SuicideOnce(2, 2, 2, GARGOYLE);//call SuicideOnce( 2, 2, 2, GARGOYLE     )
			SuicideOnce(2, 2, 2, NECRO);//call SuicideOnce( 2, 2, 2, NECRO        )
			SuicideOnce(1, 1, 1, DETHEROC);//call SuicideOnce( 1, 1, 1, DETHEROC     )
			WaitForSignal();//call WaitForSignal()
			//
			CampaignDefenderEx(1, 1, 1, ABOMINATION);//call CampaignDefenderEx( 1, 1, 1, ABOMINATION   )
			CampaignDefenderEx(1, 1, 1, OBS_STATUE);//call CampaignDefenderEx( 1, 1, 1, OBS_STATUE    )
			CampaignDefenderEx(0, 0, 1, FROST_WYRM);//call CampaignDefenderEx( 0, 0, 1, FROST_WYRM    )
			CampaignDefenderEx(0, 0, 1, CRYPT_FIEND);//call CampaignDefenderEx( 0, 0, 1, CRYPT_FIEND   )
			CampaignDefenderEx(0, 0, 1, DETHEROC);//call CampaignDefenderEx( 0, 0, 1, DETHEROC      )
			StartThread(function upgrade_towers);//call StartThread(function upgrade_towers)
			SetBuildUpgrEx(1, 1, 1, UPG_BLK_SPHINX);//call SetBuildUpgrEx( 1, 1, 1, UPG_BLK_SPHINX    )
			WaitForSignal();//call WaitForSignal()
			StartThread(function check_base_deaths);//call StartThread(function check_base_deaths)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2,2,3, CRYPT_FIEND);//call CampaignAttackerEx( 2,2,3, CRYPT_FIEND )
			CampaignAttackerEx(6,6,8, GHOUL);//call CampaignAttackerEx( 6,6,8, GHOUL       )
			SuicideOnPlayerEx(M2,M2,M2,user);//call SuicideOnPlayerEx(M2,M2,M2,user)
			SetBuildUpgrEx(0,0,1, UPG_UNHOLY_STR);//call SetBuildUpgrEx( 0,0,1, UPG_UNHOLY_STR  )
			SetBuildUpgrEx(0,1,1, UPG_CR_ATTACK);//call SetBuildUpgrEx( 0,1,1, UPG_CR_ATTACK   )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2,2,3, GARGOYLE);//call CampaignAttackerEx( 2,2,3, GARGOYLE    )
			CampaignAttackerEx(5,5,6, GHOUL);//call CampaignAttackerEx( 5,5,6, GHOUL       )
			CampaignAttackerEx(1,1,1, DETHEROC);//call CampaignAttackerEx( 1,1,1, DETHEROC    )
			SuicideOnPlayer(delay,user);//call SuicideOnPlayer(delay,user)
			SetBuildUpgrEx(0,0,1, UPG_UNHOLY_ARMOR);//call SetBuildUpgrEx( 0,0,1, UPG_UNHOLY_ARMOR)
			SetBuildUpgrEx(0,0,1, UPG_CR_ARMOR);//call SetBuildUpgrEx( 0,0,1, UPG_CR_ARMOR    )
			SetBuildUpgrEx(1,1,1, UPG_NECROS);//call SetBuildUpgrEx( 1,1,1, UPG_NECROS      )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(5,5,8, GARGOYLE);//call CampaignAttackerEx( 5,5,8, GARGOYLE    )
			CampaignAttackerEx(1,1,2, FROST_WYRM);//call CampaignAttackerEx( 1,1,2, FROST_WYRM  )
			CampaignAttackerEx(1,1,2, BLK_SPHINX);//call CampaignAttackerEx( 1,1,2, BLK_SPHINX  )
			SuicideOnPlayer(delay,user);//call SuicideOnPlayer(delay,user)
			SetBuildUpgrEx(0,0,1, UPG_PLAGUE);//call SetBuildUpgrEx( 0,0,1, UPG_PLAGUE      )
			SetBuildUpgrEx(0,0,1, UPG_GHOUL_FRENZY);//call SetBuildUpgrEx( 0,0,1, UPG_GHOUL_FRENZY)
			SetBuildUpgrEx(1,1,1, UPG_WYRM_BREATH);//call SetBuildUpgrEx( 1,1,1, UPG_WYRM_BREATH )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(1,1,2, MEAT_WAGON);//call CampaignAttackerEx( 1,1,2, MEAT_WAGON  )
			CampaignAttackerEx(3,3,4, ABOMINATION);//call CampaignAttackerEx( 3,3,4, ABOMINATION )
			CampaignAttackerEx(1,1,1, DETHEROC);//call CampaignAttackerEx( 1,1,1, DETHEROC    )
			SuicideOnPlayer(delay,user);//call SuicideOnPlayer(delay,user)
			SetBuildUpgrEx(1,1,2, UPG_UNHOLY_STR);//call SetBuildUpgrEx( 1,1,2, UPG_UNHOLY_STR  )
			SetBuildUpgrEx(1,1,2, UPG_CR_ATTACK);//call SetBuildUpgrEx( 1,1,2, UPG_CR_ATTACK   )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(3,3,4, BLK_SPHINX);//call CampaignAttackerEx( 3,3,4, BLK_SPHINX  )
			CampaignAttackerEx(2,2,3, FROST_WYRM);//call CampaignAttackerEx( 2,2,3, FROST_WYRM  )
			SuicideOnPlayer(delay,user);//call SuicideOnPlayer(delay,user)
			SetBuildUpgrEx(1,1,2, UPG_UNHOLY_ARMOR);//call SetBuildUpgrEx( 1,1,2, UPG_UNHOLY_ARMOR)
			SetBuildUpgrEx(1,1,2, UPG_CR_ARMOR);//call SetBuildUpgrEx( 1,1,2, UPG_CR_ARMOR    )
			SetBuildUpgrEx(2,2,2, UPG_NECROS);//call SetBuildUpgrEx( 2,2,2, UPG_NECROS      )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(1,1,1, DETHEROC);//call CampaignAttackerEx( 1,1,1, DETHEROC    )
			CampaignAttackerEx(6,6,8, GHOUL);//call CampaignAttackerEx( 6,6,8, GHOUL       )
			CampaignAttackerEx(4,4,6, ABOMINATION);//call CampaignAttackerEx( 4,4,6, ABOMINATION )
			CampaignAttackerEx(1,1,2, MEAT_WAGON);//call CampaignAttackerEx( 1,1,2, MEAT_WAGON  )
			SuicideOnPlayer(delay,user);//call SuicideOnPlayer(delay,user)
			SetBuildUpgrEx(2,2,3, UPG_UNHOLY_STR);//call SetBuildUpgrEx( 2,2,3, UPG_UNHOLY_STR  )
			SetBuildUpgrEx(2,2,3, UPG_CR_ATTACK);//call SetBuildUpgrEx( 2,2,3, UPG_CR_ATTACK   )
			SetBuildUpgrEx(1,1,1, UPG_GHOUL_FRENZY);//call SetBuildUpgrEx( 1,1,1, UPG_GHOUL_FRENZY)
			SetBuildUpgrEx(1,1,1, UPG_PLAGUE);//call SetBuildUpgrEx( 1,1,1, UPG_PLAGUE      )
			//
			while (true) {//loop
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(3,3,6, GARGOYLE);//call CampaignAttackerEx( 3,3,6, GARGOYLE    )
				CampaignAttackerEx(1,1,2, FROST_WYRM);//call CampaignAttackerEx( 1,1,2, FROST_WYRM  )
				CampaignAttackerEx(2,2,3, BLK_SPHINX);//call CampaignAttackerEx( 2,2,3, BLK_SPHINX  )
				SuicideOnPlayer(delay,user);//call SuicideOnPlayer(delay,user)
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(1,1,1, DETHEROC);//call CampaignAttackerEx( 1,1,1, DETHEROC    )
				CampaignAttackerEx(5,5,7, ABOMINATION);//call CampaignAttackerEx( 5,5,7, ABOMINATION )
				CampaignAttackerEx(1,1,2, MEAT_WAGON);//call CampaignAttackerEx( 1,1,2, MEAT_WAGON  )
				SuicideOnPlayer(delay,user);//call SuicideOnPlayer(delay,user)
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(5,5,7, GARGOYLE);//call CampaignAttackerEx( 5,5,7, GARGOYLE    )
				CampaignAttackerEx(3,3,4, BLK_SPHINX);//call CampaignAttackerEx( 3,3,4, BLK_SPHINX  )
				SuicideOnPlayer(delay,user);//call SuicideOnPlayer(delay,user)
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(1,1,1, DETHEROC);//call CampaignAttackerEx( 1,1,1, DETHEROC    )
				CampaignAttackerEx(8,8,8,  GHOUL);//call CampaignAttackerEx( 8,8,8,  GHOUL      )
				CampaignAttackerEx(1,1,2, ABOMINATION);//call CampaignAttackerEx( 1,1,2, ABOMINATION )
				CampaignAttackerEx(1,1,2, MEAT_WAGON);//call CampaignAttackerEx( 1,1,2, MEAT_WAGON  )
				SuicideOnPlayer(delay,user);//call SuicideOnPlayer(delay,user)
			}//endloop
		}//endfunction

	
	}
}

