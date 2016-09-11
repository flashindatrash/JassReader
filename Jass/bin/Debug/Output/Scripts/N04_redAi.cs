using System;
using System.Collections.Generic;

namespace Jass {

	public class N04_redAi {

		//
		//
		//
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(BURROW,null);//call CampaignAI(BURROW,null)
			do_campaign_farms = false;//set do_campaign_farms = false
			SetStagePoint(-4350,-103);//call SetStagePoint(-4350,-103)
			SetBuildUnit(4, PEON);//call SetBuildUnit( 4, PEON          )
			SetBuildUnit(2, ZEPPLIN);//call SetBuildUnit( 2, ZEPPLIN       )
			CampaignDefender(EASY, 1, GRUNT);//call CampaignDefender( EASY, 1, GRUNT			)
			CampaignDefender(EASY, 3, WYVERN);//call CampaignDefender( EASY, 3, WYVERN			)
			WaitForSignal();//call WaitForSignal()
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttacker(EASY,    2, WYVERN);//call CampaignAttacker( EASY,    2, WYVERN        )
			SuicideOnPlayer(0,undead);//call SuicideOnPlayer(0,undead)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttacker(EASY,    6, WYVERN);//call CampaignAttacker( EASY,    6, WYVERN		)
			SuicideOnPlayer(M2,undead);//call SuicideOnPlayer(M2,undead)
			while (true) {//loop
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttacker(EASY,    4, WYVERN);//call CampaignAttacker( EASY,    4, WYVERN		)
				SuicideOnPlayer(M2,undead);//call SuicideOnPlayer(M2,undead)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttacker(EASY,    8, WYVERN);//call CampaignAttacker( EASY,    8, WYVERN		)
				SuicideOnPlayer(M2,undead);//call SuicideOnPlayer(M2,undead)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttacker(EASY,    6, WYVERN);//call CampaignAttacker( EASY,    6, WYVERN		)
				SuicideOnPlayer(M2,undead);//call SuicideOnPlayer(M2,undead)
			}//endloop
		}//endfunction

	
	}
}

