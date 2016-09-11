using System;
using System.Collections.Generic;

namespace Jass {

	public class N04_purpleAi {

		//
		//
		//
		public const player orcs = Player(0);//constant player orcs = Player(0)
		public const player humans = Player(9);//constant player humans = Player(9)
		//
		//
		//
		private void after_orcs() {//function after_orcs takes nothing returns nothing
			SetStagePoint(237, -4826);//call SetStagePoint(237,-4826)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttacker(CommonAi.EASY, 3, CommonAi.GARGOYLE);//call CampaignAttacker( EASY,    3, GARGOYLE		)
			SuicideOnPlayer(CommonAi.M1, N04_purpleAi.humans);//call SuicideOnPlayer(M1,humans)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttacker(CommonAi.EASY, 1, CommonAi.FROST_WYRM);//call CampaignAttacker( EASY,    1, FROST_WYRM	)
			SuicideOnPlayer(CommonAi.M3, N04_purpleAi.humans);//call SuicideOnPlayer(M3,humans)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttacker(CommonAi.EASY, 4, CommonAi.GARGOYLE);//call CampaignAttacker( EASY,    4, GARGOYLE     )
			CampaignAttacker(CommonAi.EASY, 1, CommonAi.FROST_WYRM);//call CampaignAttacker( EASY,    1, FROST_WYRM	)
			SuicideOnPlayer(CommonAi.M3, N04_purpleAi.humans);//call SuicideOnPlayer(M3,humans)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttacker(CommonAi.EASY, 4, CommonAi.GARGOYLE);//call CampaignAttacker( EASY,    4, GARGOYLE     )
			SuicideOnPlayer(CommonAi.M3, N04_purpleAi.humans);//call SuicideOnPlayer(M3,humans)
			while (true) {//loop
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttacker(CommonAi.EASY, 4, CommonAi.GARGOYLE);//call CampaignAttacker( EASY,    4, GARGOYLE     )
				SuicideOnPlayer(CommonAi.M3, N04_purpleAi.humans);//call SuicideOnPlayer(M3,humans)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttacker(CommonAi.EASY, 4, CommonAi.GARGOYLE);//call CampaignAttacker( EASY,    4, GARGOYLE     )
				CampaignAttacker(CommonAi.EASY, 1, CommonAi.FROST_WYRM);//call CampaignAttacker( EASY,    1, FROST_WYRM	)
				SuicideOnPlayer(CommonAi.M3, N04_purpleAi.humans);//call SuicideOnPlayer(M3,humans)
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
			CampaignAI(CommonAi.BURROW, null);//call CampaignAI(BURROW,null)
			do_campaign_farms = false;//set do_campaign_farms = false
			SetStagePoint(-4350, -103);//call SetStagePoint(-4350,-103)
			SetBuildUnit(2, CommonAi.ACOLYTE);//call SetBuildUnit( 2, ACOLYTE           )
			CampaignDefender(CommonAi.EASY, 2, CommonAi.GARGOYLE);//call CampaignDefender( EASY, 2, GARGOYLE	)
			CampaignDefender(CommonAi.EASY, 1, CommonAi.FROST_WYRM);//call CampaignDefender( EASY, 1, FROST_WYRM	)
			WaitForSignal();//call WaitForSignal()
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttacker(CommonAi.EASY, 3, CommonAi.GARGOYLE);//call CampaignAttacker( EASY,    3, GARGOYLE		)
			SuicideOnPlayer(CommonAi.M2, N04_purpleAi.orcs);//call SuicideOnPlayer(M2,orcs)
			test_orcs();//call test_orcs()
			while (true) {//loop
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttacker(CommonAi.EASY, 7, CommonAi.GARGOYLE);//call CampaignAttacker( EASY,    7, GARGOYLE     )
				SuicideOnPlayer(CommonAi.M2, N04_purpleAi.orcs);//call SuicideOnPlayer(M2,orcs)
				test_orcs();//call test_orcs()
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttacker(CommonAi.EASY, 5, CommonAi.GARGOYLE);//call CampaignAttacker( EASY,    5, GARGOYLE     )
				CampaignAttacker(CommonAi.EASY, 1, CommonAi.FROST_WYRM);//call CampaignAttacker( EASY,    1, FROST_WYRM	)
				SuicideOnPlayer(CommonAi.M2, N04_purpleAi.orcs);//call SuicideOnPlayer(M2,orcs)
				test_orcs();//call test_orcs()
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttacker(CommonAi.EASY, 8, CommonAi.GARGOYLE);//call CampaignAttacker( EASY,    8, GARGOYLE     )
				SuicideOnPlayer(CommonAi.M2, N04_purpleAi.orcs);//call SuicideOnPlayer(M2,orcs)
				test_orcs();//call test_orcs()
			}//endloop
		}//endfunction

	
	}
}

