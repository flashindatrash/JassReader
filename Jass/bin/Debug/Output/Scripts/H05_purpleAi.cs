using System;
using System.Collections.Generic;

namespace Jass {

	public class H05_purpleAi {

		//
		//
		//
		public static player user = Player(1);//player user = Player(1)
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(CommonAi.ZIGGURAT_1, null);//call CampaignAI(ZIGGURAT_1,null)
			SetCaptainHome(CommonAi.ATTACK_CAPTAIN, 1264, -1401);//call SetCaptainHome(ATTACK_CAPTAIN,1264,-1401)
			SetBuildUnit(1, CommonAi.NECROPOLIS_1);//call SetBuildUnit( 1, NECROPOLIS_1      )
			SetBuildUnit(1, CommonAi.ACOLYTE);//call SetBuildUnit( 1, ACOLYTE           )
			SetBuildUnit(1, CommonAi.UNDEAD_MINE);//call SetBuildUnit( 1, UNDEAD_MINE       )
			SetBuildUnit(1, CommonAi.UNDEAD_ALTAR);//call SetBuildUnit( 1, UNDEAD_ALTAR      )
			SetBuildUnit(2, CommonAi.CRYPT);//call SetBuildUnit( 2, CRYPT             )
			SetBuildUnit(1, CommonAi.GRAVEYARD);//call SetBuildUnit( 1, GRAVEYARD         )
			SetBuildUnit(5, CommonAi.ACOLYTE);//call SetBuildUnit( 5, ACOLYTE           )
			SetBuildUnit(1, CommonAi.LICH);//call SetBuildUnit( 1, LICH				)
			SetBuildUnit(8, CommonAi.ZIGGURAT_1);//call SetBuildUnit( 8, ZIGGURAT_1        )
			SetBuildUnit(8, CommonAi.ZIGGURAT_2);//call SetBuildUnit( 8, ZIGGURAT_2        )
			SetBuildUnit(1, CommonAi.NECROPOLIS_2);//call SetBuildUnit( 1, NECROPOLIS_2      )
			SetBuildUnit(1, CommonAi.SAC_PIT);//call SetBuildUnit( 1, SAC_PIT           )
			SetBuildUnit(1, CommonAi.DAMNED_TEMPLE);//call SetBuildUnit( 1, DAMNED_TEMPLE     )
			SetBuildUnit(1, CommonAi.SLAUGHTERHOUSE);//call SetBuildUnit( 1, SLAUGHTERHOUSE    )
			SetBuildUnit(1, CommonAi.NECROPOLIS_3);//call SetBuildUnit( 1, NECROPOLIS_3      )
			CampaignDefenderEx(3, 3, 3, CommonAi.GHOUL);//call CampaignDefenderEx( 3,3,3, GHOUL       )
			CampaignDefenderEx(2, 2, 2, CommonAi.NECRO);//call CampaignDefenderEx( 2,2,2, NECRO       )
			CampaignDefenderEx(2, 2, 2, CommonAi.ABOMINATION);//call CampaignDefenderEx( 2,2,2, ABOMINATION )
			CampaignDefenderEx(1, 1, 1, CommonAi.MEAT_WAGON);//call CampaignDefenderEx( 1,1,1, MEAT_WAGON	)
			CampaignDefenderEx(1, 1, 1, CommonAi.LICH);//call CampaignDefenderEx( 1,1,1, LICH		)
			WaitForSignal();//call WaitForSignal()
			allow_signal_abort = true;//set allow_signal_abort = true
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(6, 6, 6, CommonAi.GHOUL);//call CampaignAttackerEx( 6,6,6, GHOUL			)
			CampaignAttackerEx(0, 0, 2, CommonAi.ABOMINATION);//call CampaignAttackerEx( 0,0,2, ABOMINATION	)
			SuicideOnPlayer(CommonAi.M1, U08_tealAi.user);//call SuicideOnPlayer(M1,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(4, 4, 4, CommonAi.GHOUL);//call CampaignAttackerEx( 4,4,4, GHOUL       )
			CampaignAttackerEx(0, 0, 2, CommonAi.ABOMINATION);//call CampaignAttackerEx( 0,0,2, ABOMINATION )
			CampaignAttackerEx(0, 0, 1, CommonAi.NECRO);//call CampaignAttackerEx( 0,0,1, NECRO       )
			SuicideOnPlayer(CommonAi.M3, U08_tealAi.user);//call SuicideOnPlayer(M3,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(4, 4, 8, CommonAi.GHOUL);//call CampaignAttackerEx( 4,4,8, GHOUL       )
			CampaignAttackerEx(1, 1, 3, CommonAi.NECRO);//call CampaignAttackerEx( 1,1,3, NECRO       )
			SuicideOnPlayer(CommonAi.M3, U08_tealAi.user);//call SuicideOnPlayer(M3,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2, 2, 4, CommonAi.GHOUL);//call CampaignAttackerEx( 2,2,4, GHOUL       )
			CampaignAttackerEx(0, 0, 1, CommonAi.NECRO);//call CampaignAttackerEx( 0,0,1, NECRO       )
			CampaignAttackerEx(1, 1, 2, CommonAi.ABOMINATION);//call CampaignAttackerEx( 1,1,2, ABOMINATION )
			SuicideOnPlayer(CommonAi.M3, U08_tealAi.user);//call SuicideOnPlayer(M3,user)
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_CANNIBALIZE);//call SetBuildUpgrEx( 0,0,1, UPG_CANNIBALIZE   )
			SetBuildUpgrEx(1, 1, 1, CommonAi.UPG_SKEL_LIFE);//call SetBuildUpgrEx( 1,1,1, UPG_SKEL_LIFE     )
			SetBuildUpgrEx(1, 1, 1, CommonAi.UPG_UNHOLY_ARMOR);//call SetBuildUpgrEx( 1,1,1, UPG_UNHOLY_ARMOR  )
			SetBuildUpgrEx(1, 1, 1, CommonAi.UPG_NECROS);//call SetBuildUpgrEx( 1,1,1, UPG_NECROS        )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2, 2, 5, CommonAi.GHOUL);//call CampaignAttackerEx( 2,2,5, GHOUL       )
			CampaignAttackerEx(1, 1, 2, CommonAi.ABOMINATION);//call CampaignAttackerEx( 1,1,2, ABOMINATION )
			CampaignAttackerEx(2, 2, 2, CommonAi.NECRO);//call CampaignAttackerEx( 2,2,2, NECRO       )
			CampaignAttackerEx(0, 0, 2, CommonAi.MEAT_WAGON);//call CampaignAttackerEx( 0,0,2, MEAT_WAGON  )
			CampaignAttackerEx(0, 0, 1, CommonAi.LICH);//call CampaignAttackerEx( 0,0,1, LICH		)
			SuicideOnPlayer(CommonAi.M3, U08_tealAi.user);//call SuicideOnPlayer(M3,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(3, 3, 4, CommonAi.GHOUL);//call CampaignAttackerEx( 3,3,4, GHOUL       )
			CampaignAttackerEx(2, 2, 1, CommonAi.NECRO);//call CampaignAttackerEx( 2,2,1, NECRO       )
			CampaignAttackerEx(0, 0, 2, CommonAi.ABOMINATION);//call CampaignAttackerEx( 0,0,2, ABOMINATION )
			CampaignAttackerEx(1, 1, 2, CommonAi.MEAT_WAGON);//call CampaignAttackerEx( 1,1,2, MEAT_WAGON  )
			SuicideOnPlayer(CommonAi.M3, U08_tealAi.user);//call SuicideOnPlayer(M3,user)
			SetBuildUpgrEx(1, 1, 1, CommonAi.UPG_UNHOLY_STR);//call SetBuildUpgrEx( 1,1,1, UPG_UNHOLY_STR    )
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_GHOUL_FRENZY);//call SetBuildUpgrEx( 0,0,1, UPG_GHOUL_FRENZY  )
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_PLAGUE);//call SetBuildUpgrEx( 0,0,1, UPG_PLAGUE        )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(4, 4, 4, CommonAi.GHOUL);//call CampaignAttackerEx( 4,4,4, GHOUL       )
			CampaignAttackerEx(2, 2, 2, CommonAi.ABOMINATION);//call CampaignAttackerEx( 2,2,2, ABOMINATION )
			CampaignAttackerEx(1, 1, 4, CommonAi.NECRO);//call CampaignAttackerEx( 1,1,4, NECRO       )
			CampaignAttackerEx(0, 0, 1, CommonAi.LICH);//call CampaignAttackerEx( 0,0,1, LICH		)
			SuicideOnPlayer(CommonAi.M3, U08_tealAi.user);//call SuicideOnPlayer(M3,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(3, 3, 4, CommonAi.GHOUL);//call CampaignAttackerEx( 3,3,4, GHOUL       )
			CampaignAttackerEx(1, 1, 1, CommonAi.NECRO);//call CampaignAttackerEx( 1,1,1, NECRO       )
			CampaignAttackerEx(0, 0, 2, CommonAi.ABOMINATION);//call CampaignAttackerEx( 0,0,2, ABOMINATION )
			CampaignAttackerEx(0, 0, 2, CommonAi.MEAT_WAGON);//call CampaignAttackerEx( 0,0,2, MEAT_WAGON  )
			CampaignAttackerEx(0, 0, 1, CommonAi.LICH);//call CampaignAttackerEx( 0,0,1, LICH		)
			SuicideOnPlayer(CommonAi.M3, U08_tealAi.user);//call SuicideOnPlayer(M3,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(4, 4, 8, CommonAi.GHOUL);//call CampaignAttackerEx( 4,4,8, GHOUL       )
			CampaignAttackerEx(1, 1, 1, CommonAi.NECRO);//call CampaignAttackerEx( 1,1,1, NECRO       )
			CampaignAttackerEx(1, 1, 3, CommonAi.ABOMINATION);//call CampaignAttackerEx( 1,1,3, ABOMINATION )
			CampaignAttackerEx(1, 1, 2, CommonAi.MEAT_WAGON);//call CampaignAttackerEx( 1,1,2, MEAT_WAGON  )
			SuicideOnPlayer(CommonAi.M3, U08_tealAi.user);//call SuicideOnPlayer(M3,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(4, 4, 6, CommonAi.GHOUL);//call CampaignAttackerEx( 4,4,6, GHOUL       )
			CampaignAttackerEx(1, 1, 1, CommonAi.NECRO);//call CampaignAttackerEx( 1,1,1, NECRO       )
			CampaignAttackerEx(1, 1, 4, CommonAi.ABOMINATION);//call CampaignAttackerEx( 1,1,4, ABOMINATION )
			CampaignAttackerEx(2, 2, 3, CommonAi.MEAT_WAGON);//call CampaignAttackerEx( 2,2,3, MEAT_WAGON  )
			SuicideOnPlayer(CommonAi.M3, U08_tealAi.user);//call SuicideOnPlayer(M3,user)
			ForeverSuicideOnPlayer(CommonAi.M2, U08_tealAi.user);//call ForeverSuicideOnPlayer(M2,user)
			SuicideUnits(CommonAi.MEAT_WAGON, CommonAi.ABOMINATION, CommonAi.GHOUL, CommonAi.NECRO, CommonAi.SKEL_WARRIOR, CommonAi.LICH, 0, 0, 0, 0);//call SuicideUnits( MEAT_WAGON, ABOMINATION, GHOUL, NECRO, SKEL_WARRIOR, LICH, 0, 0, 0, 0 )
		}//endfunction

	
	}
}

