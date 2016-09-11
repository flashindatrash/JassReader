using System;
using System.Collections.Generic;

namespace Jass {

	public class N04_purpleAi {

		//
		//
		//
		//
		//
		//
		private void after_orcs() {//function after_orcs takes nothing returns nothing
			SetStagePoint(237,-4826);//call SetStagePoint(237,-4826)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttacker(EASY,    3, GARGOYLE);//call CampaignAttacker( EASY,    3, GARGOYLE		)
			SuicideOnPlayer(M1,humans);//call SuicideOnPlayer(M1,humans)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttacker(EASY,    1, FROST_WYRM);//call CampaignAttacker( EASY,    1, FROST_WYRM	)
			SuicideOnPlayer(M3,humans);//call SuicideOnPlayer(M3,humans)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttacker(EASY,    4, GARGOYLE);//call CampaignAttacker( EASY,    4, GARGOYLE     )
			CampaignAttacker(EASY,    1, FROST_WYRM);//call CampaignAttacker( EASY,    1, FROST_WYRM	)
			SuicideOnPlayer(M3,humans);//call SuicideOnPlayer(M3,humans)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttacker(EASY,    4, GARGOYLE);//call CampaignAttacker( EASY,    4, GARGOYLE     )
			SuicideOnPlayer(M3,humans);//call SuicideOnPlayer(M3,humans)
			while (true) {//loop
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttacker(EASY,    4, GARGOYLE);//call CampaignAttacker( EASY,    4, GARGOYLE     )
				SuicideOnPlayer(M3,humans);//call SuicideOnPlayer(M3,humans)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttacker(EASY,    4, GARGOYLE);//call CampaignAttacker( EASY,    4, GARGOYLE     )
				CampaignAttacker(EASY,    1, FROST_WYRM);//call CampaignAttacker( EASY,    1, FROST_WYRM	)
				SuicideOnPlayer(M3,humans);//call SuicideOnPlayer(M3,humans)
			}//endloop
		}//endfunction
		//
		//
		//
		private void test_orcs() {//function test_orcs takes nothing returns nothing
			if (CommandsWaiting() > 0) {//if CommandsWaiting() > 0 then
				after_orcs();//call after_orcs()
			}//endif
		}//endfunction
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			Cheat("control 3");//debug call Cheat("control 3")
			Cheat("vision 3");//debug call Cheat("vision 3")
			CampaignAI(BURROW,null);//call CampaignAI(BURROW,null)
			do_campaign_farms = false;//set do_campaign_farms = false
			SetStagePoint(-4350,-103);//call SetStagePoint(-4350,-103)
			SetBuildUnit(2, ACOLYTE);//call SetBuildUnit( 2, ACOLYTE           )
			CampaignDefender(EASY, 2, GARGOYLE);//call CampaignDefender( EASY, 2, GARGOYLE	)
			CampaignDefender(EASY, 1, FROST_WYRM);//call CampaignDefender( EASY, 1, FROST_WYRM	)
			WaitForSignal();//call WaitForSignal()
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttacker(EASY,    3, GARGOYLE);//call CampaignAttacker( EASY,    3, GARGOYLE		)
			SuicideOnPlayer(M2,orcs);//call SuicideOnPlayer(M2,orcs)
			test_orcs();//call test_orcs()
			while (true) {//loop
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttacker(EASY,    7, GARGOYLE);//call CampaignAttacker( EASY,    7, GARGOYLE     )
				SuicideOnPlayer(M2,orcs);//call SuicideOnPlayer(M2,orcs)
				test_orcs();//call test_orcs()
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttacker(EASY,    5, GARGOYLE);//call CampaignAttacker( EASY,    5, GARGOYLE     )
				CampaignAttacker(EASY,    1, FROST_WYRM);//call CampaignAttacker( EASY,    1, FROST_WYRM	)
				SuicideOnPlayer(M2,orcs);//call SuicideOnPlayer(M2,orcs)
				test_orcs();//call test_orcs()
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttacker(EASY,    8, GARGOYLE);//call CampaignAttacker( EASY,    8, GARGOYLE     )
				SuicideOnPlayer(M2,orcs);//call SuicideOnPlayer(M2,orcs)
				test_orcs();//call test_orcs()
			}//endloop
		}//endfunction

	
	}
}

