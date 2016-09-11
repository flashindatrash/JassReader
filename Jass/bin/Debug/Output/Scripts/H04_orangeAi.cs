using System;
using System.Collections.Generic;

namespace Jass {

	public class H04_orangeAi {

		//
		//
		//
		public static player user = Player(1);//player user = Player(1)
		private void do_cheats() {//function do_cheats takes nothing returns nothing
			Cheat("showmap");//call Cheat("showmap")
			Cheat("av");//call Cheat("av")
			Cheat("dg");//call Cheat("dg")
			Cheat("warnings");//call Cheat("warnings")
			Cheat("viewres");//call Cheat("viewres")
			//
			debug_fast_attacks = true;//set debug_fast_attacks = true
		}//endfunction
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			campaign_wood_peons = 1;//set campaign_wood_peons = 1
			CampaignAI(CommonAi.ZIGGURAT_1, null);//call CampaignAI(ZIGGURAT_1,null)
			SetBuildUnit(3, CommonAi.ACOLYTE);//call SetBuildUnit( 3, ACOLYTE           )
			SetBuildUnit(1, CommonAi.NECROPOLIS_1);//call SetBuildUnit( 1, NECROPOLIS_1      )
			SetBuildUnit(1, CommonAi.UNDEAD_MINE);//call SetBuildUnit( 1, UNDEAD_MINE       )
			SetBuildUnit(1, CommonAi.ZIGGURAT_1);//call SetBuildUnit( 1, ZIGGURAT_1        )
			SetBuildUnit(1, CommonAi.ZIGGURAT_2);//call SetBuildUnit( 1, ZIGGURAT_2        )
			SetBuildUnit(1, CommonAi.CRYPT);//call SetBuildUnit( 1, CRYPT             )
			CampaignDefender(CommonAi.EASY, 2, CommonAi.GHOUL);//call CampaignDefender (EASY, 2, GHOUL     )
			//
		}//endfunction

	
	}
}

