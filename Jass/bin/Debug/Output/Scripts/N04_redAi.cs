using System;
using System.Collections.Generic;

namespace Jass {

	public class N04_redAi {

		//
		//
		//
		public const player undead = Player(3);//constant player undead = Player(3)
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(CommonAi.BURROW, null);//call CampaignAI(BURROW,null)
			do_campaign_farms = false;//set do_campaign_farms = false
			SetStagePoint(-4350, -103);//call SetStagePoint(-4350,-103)
			SetBuildUnit(4, CommonAi.PEON);//call SetBuildUnit( 4, PEON          )
			SetBuildUnit(2, CommonAi.ZEPPLIN);//call SetBuildUnit( 2, ZEPPLIN       )
			CampaignDefender(CommonAi.EASY, 1, CommonAi.GRUNT);//call CampaignDefender( EASY, 1, GRUNT			)
			CampaignDefender(CommonAi.EASY, 3, CommonAi.WYVERN);//call CampaignDefender( EASY, 3, WYVERN			)
			WaitForSignal();//call WaitForSignal()
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttacker(CommonAi.EASY, 2, CommonAi.WYVERN);//call CampaignAttacker( EASY,    2, WYVERN        )
			SuicideOnPlayer(0, N04_redAi.undead);//call SuicideOnPlayer(0,undead)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttacker(CommonAi.EASY, 6, CommonAi.WYVERN);//call CampaignAttacker( EASY,    6, WYVERN		)
			SuicideOnPlayer(CommonAi.M2, N04_redAi.undead);//call SuicideOnPlayer(M2,undead)
			while (true) {//loop
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttacker(CommonAi.EASY, 4, CommonAi.WYVERN);//call CampaignAttacker( EASY,    4, WYVERN		)
				SuicideOnPlayer(CommonAi.M2, N04_redAi.undead);//call SuicideOnPlayer(M2,undead)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttacker(CommonAi.EASY, 8, CommonAi.WYVERN);//call CampaignAttacker( EASY,    8, WYVERN		)
				SuicideOnPlayer(CommonAi.M2, N04_redAi.undead);//call SuicideOnPlayer(M2,undead)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttacker(CommonAi.EASY, 6, CommonAi.WYVERN);//call CampaignAttacker( EASY,    6, WYVERN		)
				SuicideOnPlayer(CommonAi.M2, N04_redAi.undead);//call SuicideOnPlayer(M2,undead)
			}//endloop
		}//endfunction

	
	}
}

