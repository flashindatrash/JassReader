using System;
using System.Collections.Generic;

namespace Jass {

	public class N01_horcsAi {

		//
		//
		//
		public const int SIDE_HUMAN = 1;//constant integer SIDE_HUMAN = 1
		public const int SIDE_ORC = 2;//constant integer SIDE_ORC   = 2
		public static int side;//integer side
		public const player user = Player(1);//constant player user = Player(1)
		//
		//
		//
		private void mixed_wave(int hqty, int hid, int oqty, int oid) {//function mixed_wave takes integer hqty, integer hid, integer oqty, integer oid returns nothing
			if (side == SIDE_HUMAN) {//if side == SIDE_HUMAN then
				CampaignAttacker(CommonAi.EASY, hqty, hid);//call CampaignAttacker( EASY, hqty, hid )
			} else {//else
				CampaignAttacker(CommonAi.EASY, oqty, oid);//call CampaignAttacker( EASY, oqty, oid )
			}//endif
		}//endfunction
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			if (GetUnitCount(PEASANT)>0) {//if GetUnitCount(PEASANT)>0 then
				side = SIDE_HUMAN;//set side = SIDE_HUMAN
				CampaignAI(CommonAi.HOUSE, null);//call CampaignAI(HOUSE,null)
				SetBuildUnit(6, CommonAi.PEASANT);//call SetBuildUnit( 6, PEASANT )
				CampaignDefender(CommonAi.EASY, 1, CommonAi.HIGH_FOOTMAN);//call CampaignDefender( EASY, 1, HIGH_FOOTMAN )
			} else {//else
				side = SIDE_ORC;//set side = SIDE_ORC
				CampaignAI(CommonAi.BURROW, null);//call CampaignAI(BURROW,null)
				SetBuildUnit(5, CommonAi.PEON);//call SetBuildUnit( 5, PEON )
			}//endif
			campaign_wood_peons = 99;//set campaign_wood_peons = 99
			WaitForSignal();//call WaitForSignal()
			//
			InitAssaultGroup();//call InitAssaultGroup()
			mixed_wave(1, CommonAi.FOOTMAN, 1, CommonAi.GRUNT);//call mixed_wave( 1,FOOTMAN,  1,GRUNT )
			SuicideOnPlayer(0, U08_tealAi.user);//call SuicideOnPlayer(0,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			mixed_wave(1, CommonAi.RIFLEMAN, 1, CommonAi.GRUNT);//call mixed_wave( 1,RIFLEMAN,  1,GRUNT )
			SuicideOnPlayer(CommonAi.M3, U08_tealAi.user);//call SuicideOnPlayer(M3,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			mixed_wave(2, CommonAi.FOOTMAN, 1, CommonAi.HEAD_HUNTER);//call mixed_wave( 2,FOOTMAN,  1,HEAD_HUNTER )
			SuicideOnPlayer(CommonAi.M6, U08_tealAi.user);//call SuicideOnPlayer(M6,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			mixed_wave(1, CommonAi.RIFLEMAN, 1, CommonAi.GRUNT);//call mixed_wave( 1,RIFLEMAN,  1,GRUNT )
			SuicideOnPlayer(CommonAi.M3, U08_tealAi.user);//call SuicideOnPlayer(M3,user)
			while (true) {//loop
				//
				InitAssaultGroup();//call InitAssaultGroup()
				mixed_wave(2, CommonAi.FOOTMAN, 2, CommonAi.HEAD_HUNTER);//call mixed_wave( 2,FOOTMAN,  2,HEAD_HUNTER )
				SuicideOnPlayer(CommonAi.M6, U08_tealAi.user);//call SuicideOnPlayer(M6,user)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				mixed_wave(1, CommonAi.RIFLEMAN, 2, CommonAi.GRUNT);//call mixed_wave( 1,RIFLEMAN,  2,GRUNT )
				SuicideOnPlayer(CommonAi.M3, U08_tealAi.user);//call SuicideOnPlayer(M3,user)
			}//endloop
		}//endfunction

	
	}
}

