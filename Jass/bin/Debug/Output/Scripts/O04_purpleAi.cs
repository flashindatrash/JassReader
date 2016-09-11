using System;
using System.Collections.Generic;

namespace Jass {

	public class O04_purpleAi {

		//
		//
		//
		public static player user = Player(0);//player user = Player(0)
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(CommonAi.MOON_WELL, null);//call CampaignAI(MOON_WELL,null)
			campaign_wood_peons = 100;//set campaign_wood_peons = 100
			SetBuildUnit(1, CommonAi.TREE_LIFE);//call SetBuildUnit( 1, TREE_LIFE     )
			SetBuildUnit(1, CommonAi.WISP);//call SetBuildUnit( 1, WISP          )
			SetBuildUnit(1, CommonAi.ANCIENT_WAR);//call SetBuildUnit( 1, ANCIENT_WAR   )
			SetBuildUnit(2, CommonAi.WISP);//call SetBuildUnit( 2, WISP          )
			SetBuildUnit(1, CommonAi.HUNTERS_HALL);//call SetBuildUnit( 1, HUNTERS_HALL  )
			SetBuildUnit(1, CommonAi.TREE_AGES);//call SetBuildUnit( 1, TREE_AGES     )
			SetBuildUnit(3, CommonAi.WISP);//call SetBuildUnit( 3, WISP          )
			SetBuildUnit(1, CommonAi.ELF_ALTAR);//call SetBuildUnit( 1, ELF_ALTAR     )
			SetBuildUnit(1, CommonAi.ANCIENT_WIND);//call SetBuildUnit( 1, ANCIENT_WIND  )
			SetBuildUnit(1, CommonAi.ANCIENT_LORE);//call SetBuildUnit( 1, ANCIENT_LORE  )
			SetBuildUnit(1, CommonAi.TREE_ETERNITY);//call SetBuildUnit( 1, TREE_ETERNITY )
			SetBuildUnit(5, CommonAi.WISP);//call SetBuildUnit( 5, WISP          )
			CampaignDefender(CommonAi.EASY, 3, CommonAi.ARCHER);//call CampaignDefender( EASY, 3, ARCHER      )
			CampaignDefender(CommonAi.EASY, 2, CommonAi.HUNTRESS);//call CampaignDefender( EASY, 2, HUNTRESS    )
			WaitForSignal();//call WaitForSignal()
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttacker(CommonAi.EASY, 2, CommonAi.ARCHER);//call CampaignAttacker( EASY, 2, ARCHER      )
			SuicideOnPlayer(0, U08_tealAi.user);//call SuicideOnPlayer(0,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttacker(CommonAi.EASY, 2, CommonAi.ARCHER);//call CampaignAttacker( EASY, 2, ARCHER      )
			CampaignAttacker(CommonAi.EASY, 1, CommonAi.HUNTRESS);//call CampaignAttacker( EASY, 1, HUNTRESS    )
			SuicideOnPlayer(3*60, U08_tealAi.user);//call SuicideOnPlayer(3*60,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttacker(CommonAi.EASY, 2, CommonAi.ARCHER);//call CampaignAttacker( EASY, 2, ARCHER      )
			CampaignAttacker(CommonAi.EASY, 2, CommonAi.HUNTRESS);//call CampaignAttacker( EASY, 2, HUNTRESS    )
			CampaignAttacker(CommonAi.EASY, 1, CommonAi.BALLISTA);//call CampaignAttacker( EASY, 1, BALLISTA    )
			SuicideOnPlayer(4*60, U08_tealAi.user);//call SuicideOnPlayer(4*60,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttacker(CommonAi.EASY, 5, CommonAi.ARCHER);//call CampaignAttacker( EASY, 5, ARCHER      )
			CampaignAttacker(CommonAi.EASY, 2, CommonAi.HUNTRESS);//call CampaignAttacker( EASY, 2, HUNTRESS    )
			CampaignAttacker(CommonAi.EASY, 5, CommonAi.MOON_CHICK);//call CampaignAttacker( EASY, 5, MOON_CHICK  )
			SuicideOnPlayer(6*60, U08_tealAi.user);//call SuicideOnPlayer(6*60,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttacker(CommonAi.EASY, 3, CommonAi.ARCHER);//call CampaignAttacker( EASY, 3, ARCHER      )
			CampaignAttacker(CommonAi.EASY, 1, CommonAi.HUNTRESS);//call CampaignAttacker( EASY, 1, HUNTRESS    )
			SuicideOnPlayer(2*60, U08_tealAi.user);//call SuicideOnPlayer(2*60,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttacker(CommonAi.EASY, 4, CommonAi.HUNTRESS);//call CampaignAttacker( EASY, 4, HUNTRESS    )
			CampaignAttacker(CommonAi.EASY, 2, CommonAi.BALLISTA);//call CampaignAttacker( EASY, 2, BALLISTA    )
			CampaignAttacker(CommonAi.EASY, 1, CommonAi.WISP);//call CampaignAttacker( EASY, 1, WISP        )
			CampaignAttacker(CommonAi.EASY, 1, CommonAi.MOON_CHICK);//call CampaignAttacker( EASY, 1, MOON_CHICK  )
			SuicideOnPlayer(6*60, U08_tealAi.user);//call SuicideOnPlayer(6*60,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttacker(CommonAi.EASY, 2, CommonAi.HUNTRESS);//call CampaignAttacker( EASY, 2, HUNTRESS        )
			CampaignAttacker(CommonAi.EASY, 1, CommonAi.ANCIENT_PROTECT);//call CampaignAttacker( EASY, 1, ANCIENT_PROTECT )
			SuicideOnPlayer(3*60, U08_tealAi.user);//call SuicideOnPlayer(3*60,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttacker(CommonAi.EASY, 6, CommonAi.ARCHER);//call CampaignAttacker( EASY, 6, ARCHER      )
			SuicideOnPlayer(4*60, U08_tealAi.user);//call SuicideOnPlayer(4*60,user)
			while (true) {//loop
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttacker(CommonAi.EASY, 3, CommonAi.HUNTRESS);//call CampaignAttacker( EASY, 3, HUNTRESS        )
				CampaignAttacker(CommonAi.EASY, 2, CommonAi.ANCIENT_PROTECT);//call CampaignAttacker( EASY, 2, ANCIENT_PROTECT )
				CampaignAttacker(CommonAi.EASY, 1, CommonAi.MOON_CHICK);//call CampaignAttacker( EASY, 1, MOON_CHICK      )
				SuicideOnPlayer(4*6, U08_tealAi.user);//call SuicideOnPlayer(4*6,user)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttacker(CommonAi.EASY, 4, CommonAi.ARCHER);//call CampaignAttacker( EASY, 4, ARCHER      )
				CampaignAttacker(CommonAi.EASY, 2, CommonAi.HUNTRESS);//call CampaignAttacker( EASY, 2, HUNTRESS    )
				CampaignAttacker(CommonAi.EASY, 1, CommonAi.BALLISTA);//call CampaignAttacker( EASY, 1, BALLISTA    )
				CampaignAttacker(CommonAi.EASY, 2, CommonAi.WISP);//call CampaignAttacker( EASY, 2, WISP        )
				SuicideOnPlayer(6*60, U08_tealAi.user);//call SuicideOnPlayer(6*60,user)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttacker(CommonAi.EASY, 2, CommonAi.ARCHER);//call CampaignAttacker( EASY, 2, ARCHER          )
				CampaignAttacker(CommonAi.EASY, 1, CommonAi.HUNTRESS);//call CampaignAttacker( EASY, 1, HUNTRESS        )
				CampaignAttacker(CommonAi.EASY, 1, CommonAi.ANCIENT_PROTECT);//call CampaignAttacker( EASY, 1, ANCIENT_PROTECT )
				CampaignAttacker(CommonAi.EASY, 1, CommonAi.WISP);//call CampaignAttacker( EASY, 1, WISP            )
				SuicideOnPlayer(2*60, U08_tealAi.user);//call SuicideOnPlayer(2*60,user)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttacker(CommonAi.EASY, 6, CommonAi.ARCHER);//call CampaignAttacker( EASY, 6, ARCHER      )
				CampaignAttacker(CommonAi.EASY, 1, CommonAi.BALLISTA);//call CampaignAttacker( EASY, 1, BALLISTA    )
				CampaignAttacker(CommonAi.EASY, 1, CommonAi.MOON_CHICK);//call CampaignAttacker( EASY, 1, MOON_CHICK  )
				SuicideOnPlayer(4*60, U08_tealAi.user);//call SuicideOnPlayer(4*60,user)
			}//endloop
		}//endfunction

	
	}
}

