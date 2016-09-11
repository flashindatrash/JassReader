using System;
using System.Collections.Generic;

namespace Jass {

	public class N04_lightblueAi {

		//
		//
		//
		public const player undead = Player(3);//constant player undead = Player(3)
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(HOUSE,null);//call CampaignAI(HOUSE,null)
			do_campaign_farms = false;//set do_campaign_farms = false
			SetStagePoint(4211,1446);//call SetStagePoint(4211,1446)
			SetBuildUnit(4, PEASANT);//call SetBuildUnit( 4, PEASANT       )
			CampaignDefender(EASY, 1, GRYPHON);//call CampaignDefender( EASY, 1, GRYPHON		)
			CampaignDefender(EASY, 1, COPTER);//call CampaignDefender( EASY, 1, COPTER		)
			SetBuildUpgr(1, UPG_BOMBS);//call SetBuildUpgr( 1, UPG_BOMBS				)
			WaitForSignal();//call WaitForSignal()
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttacker(EASY,    3, COPTER);//call CampaignAttacker( EASY,    3, COPTER	)
			SuicideOnPlayer(70,undead);//call SuicideOnPlayer(70,undead)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttacker(EASY,    5, GRYPHON);//call CampaignAttacker( EASY,    5, GRYPHON  )
			SuicideOnPlayer(M4,undead);//call SuicideOnPlayer(M4,undead)
			while (true) {//loop
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttacker(EASY,    8, COPTER);//call CampaignAttacker( EASY,    8, COPTER	)
				SuicideOnPlayer(M2,undead);//call SuicideOnPlayer(M2,undead)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttacker(EASY,    7, GRYPHON);//call CampaignAttacker( EASY,    7, GRYPHON  )
				SuicideOnPlayer(M4,undead);//call SuicideOnPlayer(M4,undead)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttacker(EASY,    3, GRYPHON);//call CampaignAttacker( EASY,    3, GRYPHON  )
				CampaignAttacker(EASY,    2, COPTER);//call CampaignAttacker( EASY,    2, COPTER	)
				SuicideOnPlayer(M2,undead);//call SuicideOnPlayer(M2,undead)
			}//endloop
		}//endfunction

	
	}
}

