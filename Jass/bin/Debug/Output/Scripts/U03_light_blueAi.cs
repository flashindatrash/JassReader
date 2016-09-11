using System;
using System.Collections.Generic;

namespace Jass {

	public class U03_light_blueAi {

		//
		//
		//
		public static player user = Player(3);//player user = Player(3)
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(CommonAi.ELF_FARM, null);//call CampaignAI(ELF_FARM,null)
			SetBuildUnit(1, CommonAi.TOWN_HALL);//call SetBuildUnit( 1, TOWN_HALL         )
			SetBuildUnit(2, CommonAi.PEASANT);//call SetBuildUnit( 2, PEASANT           )
			SetBuildUnit(1, CommonAi.ELF_HIGH_BARRACKS);//call SetBuildUnit( 1, ELF_HIGH_BARRACKS )
			SetBuildUnit(1, CommonAi.LUMBER_MILL);//call SetBuildUnit( 1, LUMBER_MILL       )
			SetBuildUnit(4, CommonAi.PEASANT);//call SetBuildUnit( 4, PEASANT           )
			SetBuildUnit(1, CommonAi.BLACKSMITH);//call SetBuildUnit( 1, BLACKSMITH        )
			SetBuildUnit(1, CommonAi.HUMAN_ALTAR);//call SetBuildUnit( 1, HUMAN_ALTAR       )
			SetBuildUnit(8, CommonAi.PEASANT);//call SetBuildUnit( 8, PEASANT           )
			CampaignDefender(CommonAi.EASY, 3, CommonAi.HIGH_FOOTMEN);//call CampaignDefender( EASY, 3, HIGH_FOOTMEN)
			CampaignDefender(CommonAi.EASY, 4, CommonAi.HIGH_ARCHER);//call CampaignDefender( EASY, 4, HIGH_ARCHER )
			CampaignDefender(CommonAi.EASY, 1, CommonAi.PRIEST);//call CampaignDefender( EASY, 1, PRIEST      )
			WaitForSignal();//call WaitForSignal()
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttacker(CommonAi.EASY, 2, CommonAi.HIGH_FOOTMEN);//call CampaignAttacker( EASY, 2, HIGH_FOOTMEN)
			CampaignAttacker(CommonAi.EASY, 1, CommonAi.HIGH_ARCHER);//call CampaignAttacker( EASY, 1, HIGH_ARCHER )
			SuicideOnPlayer(0, U08_tealAi.user);//call SuicideOnPlayer(0,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttacker(CommonAi.EASY, 3, CommonAi.HIGH_FOOTMEN);//call CampaignAttacker( EASY, 3, HIGH_FOOTMEN)
			CampaignAttacker(CommonAi.EASY, 2, CommonAi.HIGH_ARCHER);//call CampaignAttacker( EASY, 2, HIGH_ARCHER )
			CampaignAttacker(CommonAi.EASY, 1, CommonAi.SYLVANUS);//call CampaignAttacker( EASY, 1, SYLVANUS    )
			SuicideOnPlayer(5*60, U08_tealAi.user);//call SuicideOnPlayer(5*60,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttacker(CommonAi.EASY, 2, CommonAi.HIGH_FOOTMEN);//call CampaignAttacker( EASY, 2, HIGH_FOOTMEN)
			CampaignAttacker(CommonAi.EASY, 3, CommonAi.HIGH_ARCHER);//call CampaignAttacker( EASY, 3, HIGH_ARCHER )
			CampaignAttacker(CommonAi.EASY, 1, CommonAi.SYLVANUS);//call CampaignAttacker( EASY, 1, SYLVANUS    )
			SuicideOnPlayer(5*60, U08_tealAi.user);//call SuicideOnPlayer(5*60,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttacker(CommonAi.EASY, 4, CommonAi.HIGH_FOOTMEN);//call CampaignAttacker( EASY, 4, HIGH_FOOTMEN)
			CampaignAttacker(CommonAi.EASY, 1, CommonAi.HIGH_ARCHER);//call CampaignAttacker( EASY, 1, HIGH_ARCHER )
			CampaignAttacker(CommonAi.EASY, 1, CommonAi.PRIEST);//call CampaignAttacker( EASY, 1, PRIEST      )
			CampaignAttacker(CommonAi.EASY, 1, CommonAi.SYLVANUS);//call CampaignAttacker( EASY, 1, SYLVANUS    )
			SuicideOnPlayer(5*60, U08_tealAi.user);//call SuicideOnPlayer(5*60,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttacker(CommonAi.EASY, 3, CommonAi.HIGH_FOOTMEN);//call CampaignAttacker( EASY, 3, HIGH_FOOTMEN)
			CampaignAttacker(CommonAi.EASY, 3, CommonAi.HIGH_ARCHER);//call CampaignAttacker( EASY, 3, HIGH_ARCHER )
			CampaignAttacker(CommonAi.EASY, 1, CommonAi.PRIEST);//call CampaignAttacker( EASY, 1, PRIEST      )
			CampaignAttacker(CommonAi.EASY, 1, CommonAi.SYLVANUS);//call CampaignAttacker( EASY, 1, SYLVANUS    )
			SuicideOnPlayer(5*60, U08_tealAi.user);//call SuicideOnPlayer(5*60,user)
			while (true) {//loop
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttacker(CommonAi.EASY, 2, CommonAi.HIGH_FOOTMEN);//call CampaignAttacker( EASY, 2, HIGH_FOOTMEN)
				CampaignAttacker(CommonAi.EASY, 3, CommonAi.HIGH_ARCHER);//call CampaignAttacker( EASY, 3, HIGH_ARCHER )
				CampaignAttacker(CommonAi.EASY, 1, CommonAi.PRIEST);//call CampaignAttacker( EASY, 1, PRIEST      )
				CampaignAttacker(CommonAi.EASY, 1, CommonAi.SYLVANUS);//call CampaignAttacker( EASY, 1, SYLVANUS    )
				SuicideOnPlayer(5*60, U08_tealAi.user);//call SuicideOnPlayer(5*60,user)
			}//endloop
		}//endfunction

	
	}
}

