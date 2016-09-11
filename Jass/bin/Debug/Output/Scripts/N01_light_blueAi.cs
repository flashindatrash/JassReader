using System;
using System.Collections.Generic;

namespace Jass {

	public class N01_light_blueAi {

		//
		//
		//
		public const player user = Player(1);//constant player user = Player(1)
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(CommonAi.ZIGGURAT_1, null);//call CampaignAI(ZIGGURAT_1,null)
			campaign_wood_peons = 99;//set campaign_wood_peons = 99
			SetBuildUnit(4, CommonAi.PEASANT);//call SetBuildUnit( 4, PEASANT   )
			SetBuildUnit(4, CommonAi.PEON);//call SetBuildUnit( 4, PEON      )
			CampaignDefender(CommonAi.EASY, 1, CommonAi.HIGH_FOOTMAN);//call CampaignDefender( EASY, 1, HIGH_FOOTMAN )
			WaitForSignal();//call WaitForSignal()
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttacker(CommonAi.EASY, 2, CommonAi.FOOTMEN);//call CampaignAttacker( EASY, 2, FOOTMEN     )
			SuicideOnPlayer(0, U08_tealAi.user);//call SuicideOnPlayer(0,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttacker(CommonAi.EASY, 1, CommonAi.GRUNT);//call CampaignAttacker( EASY, 1, GRUNT       )
			CampaignAttacker(CommonAi.EASY, 1, CommonAi.HEAD_HUNTER);//call CampaignAttacker( EASY, 1, HEAD_HUNTER )
			SuicideOnPlayer(CommonAi.M3, U08_tealAi.user);//call SuicideOnPlayer(M3,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttacker(CommonAi.EASY, 2, CommonAi.FOOTMEN);//call CampaignAttacker( EASY, 2, FOOTMEN     )
			CampaignAttacker(CommonAi.EASY, 1, CommonAi.RIFLEMAN);//call CampaignAttacker( EASY, 1, RIFLEMAN    )
			SuicideOnPlayer(CommonAi.M6, U08_tealAi.user);//call SuicideOnPlayer(M6,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttacker(CommonAi.EASY, 1, CommonAi.GRUNT);//call CampaignAttacker( EASY, 1, GRUNT       )
			CampaignAttacker(CommonAi.EASY, 2, CommonAi.HEAD_HUNTER);//call CampaignAttacker( EASY, 2, HEAD_HUNTER )
			SuicideOnPlayer(CommonAi.M3, U08_tealAi.user);//call SuicideOnPlayer(M3,user)
			while (true) {//loop
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttacker(CommonAi.EASY, 3, CommonAi.FOOTMEN);//call CampaignAttacker( EASY, 3, FOOTMEN     )
				CampaignAttacker(CommonAi.EASY, 2, CommonAi.RIFLEMAN);//call CampaignAttacker( EASY, 2, RIFLEMAN    )
				SuicideOnPlayer(CommonAi.M6, U08_tealAi.user);//call SuicideOnPlayer(M6,user)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttacker(CommonAi.EASY, 2, CommonAi.GRUNT);//call CampaignAttacker( EASY, 2, GRUNT       )
				CampaignAttacker(CommonAi.EASY, 1, CommonAi.HEAD_HUNTER);//call CampaignAttacker( EASY, 1, HEAD_HUNTER )
				SuicideOnPlayer(CommonAi.M3, U08_tealAi.user);//call SuicideOnPlayer(M3,user)
			}//endloop
		}//endfunction

	
	}
}

