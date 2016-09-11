using System;
using System.Collections.Generic;

namespace Jass {

	public class O05_yellowAi {

		//
		//
		//
		public static player user = Player(3);//player user = Player(3)
		public static int factor = 1;//integer factor = 1
		private void MikesSuicide(int easy, int med, int hard, player user) {//function MikesSuicide takes integer easy, integer med, integer hard, player user returns nothing
			if (CommandsWaiting()>0) {//if CommandsWaiting()>0 then
				factor = 2;//set factor = 2
				PopLastCommand();//call PopLastCommand()
			}//endif
			SuicideOnPlayerEx(easy/factor, med/factor, hard/factor, U08_tealAi.user);//call SuicideOnPlayerEx(easy/factor, med/factor, hard/factor, user)
		}//endfunction
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
			SetBuildUnit(1, CommonAi.ELF_ALTAR);//call SetBuildUnit( 1, ELF_ALTAR     )
			SetBuildUnit(1, CommonAi.HUNTERS_HALL);//call SetBuildUnit( 1, HUNTERS_HALL  )
			SetBuildUnit(1, CommonAi.TREE_AGES);//call SetBuildUnit( 1, TREE_AGES     )
			SetBuildUnit(1, CommonAi.ANCIENT_WIND);//call SetBuildUnit( 1, ANCIENT_WIND  )
			SetBuildUnit(1, CommonAi.ANCIENT_LORE);//call SetBuildUnit( 1, ANCIENT_LORE  )
			SetBuildUnit(1, CommonAi.TREE_ETERNITY);//call SetBuildUnit( 1, TREE_ETERNITY )
			SetBuildUnit(8, CommonAi.WISP);//call SetBuildUnit( 8, WISP          )
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
			MikesSuicide(4*60, 4*60, 4*60, U08_tealAi.user);//call MikesSuicide(4*60,4*60,4*60,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttacker(CommonAi.EASY, 5, CommonAi.ARCHER);//call CampaignAttacker( EASY, 5, ARCHER          )
			CampaignAttacker(CommonAi.EASY, 2, CommonAi.HUNTRESS);//call CampaignAttacker( EASY, 2, HUNTRESS        )
			MikesSuicide(6*60, 6*60, 6*60, U08_tealAi.user);//call MikesSuicide(6*60,6*60,6*60,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttacker(CommonAi.EASY, 3, CommonAi.ARCHER);//call CampaignAttacker( EASY, 3, ARCHER      )
			CampaignAttacker(CommonAi.EASY, 1, CommonAi.HUNTRESS);//call CampaignAttacker( EASY, 1, HUNTRESS    )
			MikesSuicide(2*60, 2*60, 2*60, U08_tealAi.user);//call MikesSuicide(2*60,2*60,2*60,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttacker(CommonAi.EASY, 4, CommonAi.HUNTRESS);//call CampaignAttacker( EASY, 4, HUNTRESS    )
			CampaignAttacker(CommonAi.EASY, 2, CommonAi.BALLISTA);//call CampaignAttacker( EASY, 2, BALLISTA    )
			CampaignAttacker(CommonAi.EASY, 1, CommonAi.WISP);//call CampaignAttacker( EASY, 1, WISP        )
			MikesSuicide(6*60, 6*60, 6*60, U08_tealAi.user);//call MikesSuicide(6*60,6*60,6*60,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttacker(CommonAi.EASY, 2, CommonAi.HUNTRESS);//call CampaignAttacker( EASY, 2, HUNTRESS        )
			CampaignAttacker(CommonAi.EASY, 1, CommonAi.ANCIENT_PROTECT);//call CampaignAttacker( EASY, 1, ANCIENT_PROTECT )
			MikesSuicide(3*60, 3*60, 3*60, U08_tealAi.user);//call MikesSuicide(3*60,3*60,3*60,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttacker(CommonAi.EASY, 6, CommonAi.ARCHER);//call CampaignAttacker( EASY, 6, ARCHER      )
			MikesSuicide(4*60, 4*60, 4*60, U08_tealAi.user);//call MikesSuicide(4*60,4*60,4*60,user)
			while (true) {//loop
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttacker(CommonAi.EASY, 3, CommonAi.HUNTRESS);//call CampaignAttacker( EASY, 3, HUNTRESS        )
				CampaignAttacker(CommonAi.EASY, 2, CommonAi.ANCIENT_PROTECT);//call CampaignAttacker( EASY, 2, ANCIENT_PROTECT )
				MikesSuicide(4*60, 4*60, 4*60, U08_tealAi.user);//call MikesSuicide(4*60,4*60,4*60,user)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttacker(CommonAi.EASY, 4, CommonAi.ARCHER);//call CampaignAttacker( EASY, 4, ARCHER      )
				CampaignAttacker(CommonAi.EASY, 2, CommonAi.HUNTRESS);//call CampaignAttacker( EASY, 2, HUNTRESS    )
				CampaignAttacker(CommonAi.EASY, 1, CommonAi.BALLISTA);//call CampaignAttacker( EASY, 1, BALLISTA    )
				CampaignAttacker(CommonAi.EASY, 2, CommonAi.WISP);//call CampaignAttacker( EASY, 2, WISP        )
				MikesSuicide(6*60, 6*60, 6*60, U08_tealAi.user);//call MikesSuicide(6*60,6*60,6*60,user)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttacker(CommonAi.EASY, 2, CommonAi.ARCHER);//call CampaignAttacker( EASY, 2, ARCHER          )
				CampaignAttacker(CommonAi.EASY, 1, CommonAi.HUNTRESS);//call CampaignAttacker( EASY, 1, HUNTRESS        )
				CampaignAttacker(CommonAi.EASY, 1, CommonAi.ANCIENT_PROTECT);//call CampaignAttacker( EASY, 1, ANCIENT_PROTECT )
				CampaignAttacker(CommonAi.EASY, 1, CommonAi.WISP);//call CampaignAttacker( EASY, 1, WISP            )
				MikesSuicide(2*60, 2*60, 2*60, U08_tealAi.user);//call MikesSuicide(2*60,2*60,2*60,user)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttacker(CommonAi.EASY, 6, CommonAi.ARCHER);//call CampaignAttacker( EASY, 6, ARCHER      )
				CampaignAttacker(CommonAi.EASY, 1, CommonAi.BALLISTA);//call CampaignAttacker( EASY, 1, BALLISTA    )
				MikesSuicide(4*60, 4*60, 4*60, U08_tealAi.user);//call MikesSuicide(4*60,4*60,4*60,user)
			}//endloop
		}//endfunction

	
	}
}

