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
			CampaignAI(CommonAi.HOUSE, null);//call CampaignAI(HOUSE,null)
			do_campaign_farms = false;//set do_campaign_farms = false
			SetStagePoint(4211, 1446);//call SetStagePoint(4211,1446)
			SetBuildUnit(4, CommonAi.PEASANT);//call SetBuildUnit( 4, PEASANT       )
			CampaignDefender(CommonAi.EASY, 1, CommonAi.GRYPHON);//call CampaignDefender( EASY, 1, GRYPHON		)
			CampaignDefender(CommonAi.EASY, 1, CommonAi.COPTER);//call CampaignDefender( EASY, 1, COPTER		)
			SetBuildUpgr(1, CommonAi.UPG_BOMBS);//call SetBuildUpgr( 1, UPG_BOMBS				)
			WaitForSignal();//call WaitForSignal()
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttacker(CommonAi.EASY, 3, CommonAi.COPTER);//call CampaignAttacker( EASY,    3, COPTER	)
			SuicideOnPlayer(70, N04_redAi.undead);//call SuicideOnPlayer(70,undead)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttacker(CommonAi.EASY, 5, CommonAi.GRYPHON);//call CampaignAttacker( EASY,    5, GRYPHON  )
			SuicideOnPlayer(CommonAi.M4, N04_redAi.undead);//call SuicideOnPlayer(M4,undead)
			while (true) {//loop
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttacker(CommonAi.EASY, 8, CommonAi.COPTER);//call CampaignAttacker( EASY,    8, COPTER	)
				SuicideOnPlayer(CommonAi.M2, N04_redAi.undead);//call SuicideOnPlayer(M2,undead)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttacker(CommonAi.EASY, 7, CommonAi.GRYPHON);//call CampaignAttacker( EASY,    7, GRYPHON  )
				SuicideOnPlayer(CommonAi.M4, N04_redAi.undead);//call SuicideOnPlayer(M4,undead)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttacker(CommonAi.EASY, 3, CommonAi.GRYPHON);//call CampaignAttacker( EASY,    3, GRYPHON  )
				CampaignAttacker(CommonAi.EASY, 2, CommonAi.COPTER);//call CampaignAttacker( EASY,    2, COPTER	)
				SuicideOnPlayer(CommonAi.M2, N04_redAi.undead);//call SuicideOnPlayer(M2,undead)
			}//endloop
		}//endfunction

	
	}
}

