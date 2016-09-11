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
			Cheat("control 12");//debug call Cheat("control 12")
			Cheat("vision 12");//debug call Cheat("vision 12")
			Cheat("control 9");//debug call Cheat("control 9")
			Cheat("vision 9");//debug call Cheat("vision 9")
			Cheat("warnings");//debug call Cheat("warnings")
			Cheat("av");//debug call Cheat("av")
			Cheat("dg");//debug call Cheat("dg")
			Cheat("ca");//debug call Cheat("ca")
			CampaignAI(HOUSE,null);//call CampaignAI(HOUSE,null)
			SetStagePoint(500,-3500);//call SetStagePoint(500,-3500)
			SetBuildUnit(1, PEASANT);//call SetBuildUnit( 1, PEASANT       )
			SetBuildUnit(1, TOWN_HALL);//call SetBuildUnit( 1, TOWN_HALL     )
			SetBuildUnit(1, BARRACKS);//call SetBuildUnit( 1, BARRACKS      )
			SetBuildUnit(2, PEASANT);//call SetBuildUnit( 2, PEASANT       )
			SetBuildUnit(1, BLACKSMITH);//call SetBuildUnit( 1, BLACKSMITH    )
			SetBuildUnit(1, KEEP);//call SetBuildUnit( 1, KEEP          )
			SetBuildUnit(1, LUMBER_MILL);//call SetBuildUnit( 1, LUMBER_MILL   )
			SetBuildUnit(3, PEASANT);//call SetBuildUnit( 3, PEASANT       )
			SetBuildUnit(1, HUMAN_ALTAR);//call SetBuildUnit( 1, HUMAN_ALTAR   )
			SetBuildUnit(1, WORKSHOP);//call SetBuildUnit( 1, WORKSHOP      )
			SetBuildUnit(4, PEASANT);//call SetBuildUnit( 4, PEASANT       )
			SetBuildUnit(1, SANCTUM);//call SetBuildUnit( 1, SANCTUM       )
			SetBuildUnit(8, PEASANT);//call SetBuildUnit( 8, PEASANT       )
			CampaignDefender(EASY, 2, FOOTMEN);//call CampaignDefender( EASY, 2, FOOTMEN     )
			CampaignDefender(EASY, 1, RIFLEMAN);//call CampaignDefender( EASY, 1, RIFLEMAN    )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttacker(EASY,    2, FOOTMEN);//call CampaignAttacker( EASY,    2, FOOTMEN      )
			SuicideOnPlayer(0,undead);//call SuicideOnPlayer(0,undead)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttacker(EASY,    2, FOOTMEN);//call CampaignAttacker( EASY,    2, FOOTMEN      )
			CampaignAttacker(EASY,    2, RIFLEMEN);//call CampaignAttacker( EASY,    2, RIFLEMEN     )
			SuicideOnPlayer(3*60,undead);//call SuicideOnPlayer(3*60,undead)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttacker(EASY,    3, FOOTMEN);//call CampaignAttacker( EASY,    3, FOOTMEN      )
			CampaignAttacker(EASY,    3, RIFLEMEN);//call CampaignAttacker( EASY,    3, RIFLEMEN     )
			CampaignAttacker(EASY,    2, MORTAR);//call CampaignAttacker( EASY,    2, MORTAR       )
			SuicideOnPlayer(4*60,undead);//call SuicideOnPlayer(4*60,undead)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttacker(EASY,    4, FOOTMEN);//call CampaignAttacker( EASY,    4, FOOTMEN      )
			CampaignAttacker(EASY,    4, RIFLEMEN);//call CampaignAttacker( EASY,    4, RIFLEMEN     )
			CampaignAttacker(EASY,    2, PRIEST);//call CampaignAttacker( EASY,    2, PRIEST       )
			SuicideOnPlayer(6*60,undead);//call SuicideOnPlayer(6*60,undead)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttacker(EASY,    6, RIFLEMEN);//call CampaignAttacker( EASY,    6, RIFLEMEN     )
			CampaignAttacker(EASY,    3, MORTAR);//call CampaignAttacker( EASY,    3, MORTAR       )
			CampaignAttacker(EASY,    3, PRIEST);//call CampaignAttacker( EASY,    3, PRIEST       )
			SuicideOnPlayer(7*60,undead);//call SuicideOnPlayer(7*60,undead)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttacker(EASY,    4, FOOTMEN);//call CampaignAttacker( EASY,    4, FOOTMEN      )
			CampaignAttacker(EASY,    4, RIFLEMEN);//call CampaignAttacker( EASY,    4, RIFLEMEN     )
			CampaignAttacker(EASY,    2, MORTAR);//call CampaignAttacker( EASY,    2, MORTAR       )
			CampaignAttacker(EASY,    2, PRIEST);//call CampaignAttacker( EASY,    2, PRIEST       )
			ForeverSuicideOnPlayer(6*60,undead);//call ForeverSuicideOnPlayer(6*60,undead)
		}//endfunction

	
	}
}

