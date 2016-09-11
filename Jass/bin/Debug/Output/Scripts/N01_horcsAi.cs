using System;
using System.Collections.Generic;

namespace Jass {

	public class N01_horcsAi {

		//
		//
		//
		//
		//
		//
		private void mixed_wave(int hqty, int hid, int oqty, int oid) {//function mixed_wave takes integer hqty, integer hid, integer oqty, integer oid returns nothing
			if (side == SIDE_HUMAN) {//if side == SIDE_HUMAN then
				CampaignAttacker(EASY, hqty, hid);//call CampaignAttacker( EASY, hqty, hid )
			} else {//else
				CampaignAttacker(EASY, oqty, oid);//call CampaignAttacker( EASY, oqty, oid )
			}//endif
		}//endfunction
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			if (GetUnitCount(PEASANT)>0) {//if GetUnitCount(PEASANT)>0 then
				side = SIDE_HUMAN;//set side = SIDE_HUMAN
				CampaignAI(HOUSE,null);//call CampaignAI(HOUSE,null)
				SetBuildUnit(6, PEASANT);//call SetBuildUnit( 6, PEASANT )
				CampaignDefender(EASY, 1, HIGH_FOOTMAN);//call CampaignDefender( EASY, 1, HIGH_FOOTMAN )
			} else {//else
				side = SIDE_ORC;//set side = SIDE_ORC
				CampaignAI(BURROW,null);//call CampaignAI(BURROW,null)
				SetBuildUnit(5, PEON);//call SetBuildUnit( 5, PEON )
			}//endif
			campaign_wood_peons = 99;//set campaign_wood_peons = 99
			WaitForSignal();//call WaitForSignal()
			//
			InitAssaultGroup();//call InitAssaultGroup()
			mixed_wave(1,FOOTMAN,  1,GRUNT);//call mixed_wave( 1,FOOTMAN,  1,GRUNT )
			SuicideOnPlayer(0,user);//call SuicideOnPlayer(0,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			mixed_wave(1,RIFLEMAN,  1,GRUNT);//call mixed_wave( 1,RIFLEMAN,  1,GRUNT )
			SuicideOnPlayer(M3,user);//call SuicideOnPlayer(M3,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			mixed_wave(2,FOOTMAN,  1,HEAD_HUNTER);//call mixed_wave( 2,FOOTMAN,  1,HEAD_HUNTER )
			SuicideOnPlayer(M6,user);//call SuicideOnPlayer(M6,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			mixed_wave(1,RIFLEMAN,  1,GRUNT);//call mixed_wave( 1,RIFLEMAN,  1,GRUNT )
			SuicideOnPlayer(M3,user);//call SuicideOnPlayer(M3,user)
			while (true) {//loop
				//
				InitAssaultGroup();//call InitAssaultGroup()
				mixed_wave(2,FOOTMAN,  2,HEAD_HUNTER);//call mixed_wave( 2,FOOTMAN,  2,HEAD_HUNTER )
				SuicideOnPlayer(M6,user);//call SuicideOnPlayer(M6,user)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				mixed_wave(1,RIFLEMAN,  2,GRUNT);//call mixed_wave( 1,RIFLEMAN,  2,GRUNT )
				SuicideOnPlayer(M3,user);//call SuicideOnPlayer(M3,user)
			}//endloop
		}//endfunction

	
	}
}

