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
			CampaignAI(ZIGGURAT_1,null);//call CampaignAI(ZIGGURAT_1,null)
			campaign_wood_peons = 99;//set campaign_wood_peons = 99
			SetBuildUnit(4, PEASANT);//call SetBuildUnit( 4, PEASANT   )
			SetBuildUnit(4, PEON);//call SetBuildUnit( 4, PEON      )
			CampaignDefender(EASY, 1, HIGH_FOOTMAN);//call CampaignDefender( EASY, 1, HIGH_FOOTMAN )
			WaitForSignal();//call WaitForSignal()
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttacker(EASY, 2, FOOTMEN);//call CampaignAttacker( EASY, 2, FOOTMEN     )
			SuicideOnPlayer(0,user);//call SuicideOnPlayer(0,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttacker(EASY, 1, GRUNT);//call CampaignAttacker( EASY, 1, GRUNT       )
			CampaignAttacker(EASY, 1, HEAD_HUNTER);//call CampaignAttacker( EASY, 1, HEAD_HUNTER )
			SuicideOnPlayer(M3,user);//call SuicideOnPlayer(M3,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttacker(EASY, 2, FOOTMEN);//call CampaignAttacker( EASY, 2, FOOTMEN     )
			CampaignAttacker(EASY, 1, RIFLEMAN);//call CampaignAttacker( EASY, 1, RIFLEMAN    )
			SuicideOnPlayer(M6,user);//call SuicideOnPlayer(M6,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttacker(EASY, 1, GRUNT);//call CampaignAttacker( EASY, 1, GRUNT       )
			CampaignAttacker(EASY, 2, HEAD_HUNTER);//call CampaignAttacker( EASY, 2, HEAD_HUNTER )
			SuicideOnPlayer(M3,user);//call SuicideOnPlayer(M3,user)
			while (true) {//loop
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttacker(EASY, 3, FOOTMEN);//call CampaignAttacker( EASY, 3, FOOTMEN     )
				CampaignAttacker(EASY, 2, RIFLEMAN);//call CampaignAttacker( EASY, 2, RIFLEMAN    )
				SuicideOnPlayer(M6,user);//call SuicideOnPlayer(M6,user)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttacker(EASY, 2, GRUNT);//call CampaignAttacker( EASY, 2, GRUNT       )
				CampaignAttacker(EASY, 1, HEAD_HUNTER);//call CampaignAttacker( EASY, 1, HEAD_HUNTER )
				SuicideOnPlayer(M3,user);//call SuicideOnPlayer(M3,user)
			}//endloop
		}//endfunction

	
	}
}

