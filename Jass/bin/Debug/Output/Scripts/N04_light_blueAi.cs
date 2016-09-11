using System;
using System.Collections.Generic;

namespace Jass {

	public class N04_light_blueAi {

		//
		//
		//
		public const player undead = Player(3);//constant player undead = Player(3)
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(CommonAi.HOUSE, null);//call CampaignAI(HOUSE,null)
			SetStagePoint(500, -3500);//call SetStagePoint(500,-3500)
			SetBuildUnit(1, CommonAi.PEASANT);//call SetBuildUnit( 1, PEASANT       )
			SetBuildUnit(1, CommonAi.TOWN_HALL);//call SetBuildUnit( 1, TOWN_HALL     )
			SetBuildUnit(1, CommonAi.BARRACKS);//call SetBuildUnit( 1, BARRACKS      )
			SetBuildUnit(2, CommonAi.PEASANT);//call SetBuildUnit( 2, PEASANT       )
			SetBuildUnit(1, CommonAi.BLACKSMITH);//call SetBuildUnit( 1, BLACKSMITH    )
			SetBuildUnit(1, CommonAi.KEEP);//call SetBuildUnit( 1, KEEP          )
			SetBuildUnit(1, CommonAi.LUMBER_MILL);//call SetBuildUnit( 1, LUMBER_MILL   )
			SetBuildUnit(3, CommonAi.PEASANT);//call SetBuildUnit( 3, PEASANT       )
			SetBuildUnit(1, CommonAi.HUMAN_ALTAR);//call SetBuildUnit( 1, HUMAN_ALTAR   )
			SetBuildUnit(1, CommonAi.WORKSHOP);//call SetBuildUnit( 1, WORKSHOP      )
			SetBuildUnit(4, CommonAi.PEASANT);//call SetBuildUnit( 4, PEASANT       )
			SetBuildUnit(1, CommonAi.SANCTUM);//call SetBuildUnit( 1, SANCTUM       )
			SetBuildUnit(8, CommonAi.PEASANT);//call SetBuildUnit( 8, PEASANT       )
			CampaignDefender(CommonAi.EASY, 2, CommonAi.FOOTMEN);//call CampaignDefender( EASY, 2, FOOTMEN     )
			CampaignDefender(CommonAi.EASY, 1, CommonAi.RIFLEMAN);//call CampaignDefender( EASY, 1, RIFLEMAN    )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttacker(CommonAi.EASY, 2, CommonAi.FOOTMEN);//call CampaignAttacker( EASY,    2, FOOTMEN      )
			SuicideOnPlayer(0, N04_redAi.undead);//call SuicideOnPlayer(0,undead)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttacker(CommonAi.EASY, 2, CommonAi.FOOTMEN);//call CampaignAttacker( EASY,    2, FOOTMEN      )
			CampaignAttacker(CommonAi.EASY, 2, CommonAi.RIFLEMEN);//call CampaignAttacker( EASY,    2, RIFLEMEN     )
			SuicideOnPlayer(3*60, N04_redAi.undead);//call SuicideOnPlayer(3*60,undead)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttacker(CommonAi.EASY, 3, CommonAi.FOOTMEN);//call CampaignAttacker( EASY,    3, FOOTMEN      )
			CampaignAttacker(CommonAi.EASY, 3, CommonAi.RIFLEMEN);//call CampaignAttacker( EASY,    3, RIFLEMEN     )
			CampaignAttacker(CommonAi.EASY, 2, CommonAi.MORTAR);//call CampaignAttacker( EASY,    2, MORTAR       )
			SuicideOnPlayer(4*60, N04_redAi.undead);//call SuicideOnPlayer(4*60,undead)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttacker(CommonAi.EASY, 4, CommonAi.FOOTMEN);//call CampaignAttacker( EASY,    4, FOOTMEN      )
			CampaignAttacker(CommonAi.EASY, 4, CommonAi.RIFLEMEN);//call CampaignAttacker( EASY,    4, RIFLEMEN     )
			CampaignAttacker(CommonAi.EASY, 2, CommonAi.PRIEST);//call CampaignAttacker( EASY,    2, PRIEST       )
			SuicideOnPlayer(6*60, N04_redAi.undead);//call SuicideOnPlayer(6*60,undead)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttacker(CommonAi.EASY, 6, CommonAi.RIFLEMEN);//call CampaignAttacker( EASY,    6, RIFLEMEN     )
			CampaignAttacker(CommonAi.EASY, 3, CommonAi.MORTAR);//call CampaignAttacker( EASY,    3, MORTAR       )
			CampaignAttacker(CommonAi.EASY, 3, CommonAi.PRIEST);//call CampaignAttacker( EASY,    3, PRIEST       )
			SuicideOnPlayer(7*60, N04_redAi.undead);//call SuicideOnPlayer(7*60,undead)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttacker(CommonAi.EASY, 4, CommonAi.FOOTMEN);//call CampaignAttacker( EASY,    4, FOOTMEN      )
			CampaignAttacker(CommonAi.EASY, 4, CommonAi.RIFLEMEN);//call CampaignAttacker( EASY,    4, RIFLEMEN     )
			CampaignAttacker(CommonAi.EASY, 2, CommonAi.MORTAR);//call CampaignAttacker( EASY,    2, MORTAR       )
			CampaignAttacker(CommonAi.EASY, 2, CommonAi.PRIEST);//call CampaignAttacker( EASY,    2, PRIEST       )
			ForeverSuicideOnPlayer(6*60, N04_redAi.undead);//call ForeverSuicideOnPlayer(6*60,undead)
		}//endfunction

	
	}
}

