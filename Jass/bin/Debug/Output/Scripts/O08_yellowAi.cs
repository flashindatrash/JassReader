using System;
using System.Collections.Generic;

namespace Jass {

	public class O08_yellowAi {

		//
		//
		//
		public static player Thrall = Player(0);//player Thrall = Player(0)
		public static player Jaina = Player(9);//player Jaina  = Player(9)
		//
		//
		//
		private void custom_suicide(int seconds, player target) {//function custom_suicide takes integer seconds, player target returns nothing
			if (CommandsWaiting() != 0) {//if CommandsWaiting() != 0 then
				SleepForever();//call SleepForever()
			} else {//else
				SuicideOnPlayer(seconds,target);//call SuicideOnPlayer(seconds,target)
			}//endif
		}//endfunction
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			Cheat("vision 4");//debug call Cheat("vision 4")
			Cheat("control 4");//debug call Cheat("control 4")
			CampaignAI(BURROW,null);//call CampaignAI(BURROW,null)
			GroupTimedLife(false);//call GroupTimedLife(false)
			SetCaptainHome(BOTH_CAPTAINS,1271,2764);//call SetCaptainHome(BOTH_CAPTAINS,1271,2764)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttacker(EASY, 6, CHAOS_GRUNT);//call CampaignAttacker( EASY, 6, CHAOS_GRUNT     )
			custom_suicide(0,Thrall);//call custom_suicide(0,Thrall)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttacker(EASY, 4, CHAOS_GRUNT);//call CampaignAttacker( EASY, 4, CHAOS_GRUNT     )
			CampaignAttacker(EASY, 3, CHAOS_RAIDER);//call CampaignAttacker( EASY, 3, CHAOS_RAIDER    )
			custom_suicide(5*60,Jaina);//call custom_suicide(5*60,Jaina)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttacker(EASY, 4, CHAOS_GRUNT);//call CampaignAttacker( EASY, 4, CHAOS_GRUNT     )
			CampaignAttacker(EASY, 2, CHAOS_RAIDER);//call CampaignAttacker( EASY, 2, CHAOS_RAIDER    )
			custom_suicide(2*60,Jaina);//call custom_suicide(2*60,Jaina)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttacker(EASY, 5, CHAOS_GRUNT);//call CampaignAttacker( EASY, 5, CHAOS_GRUNT     )
			CampaignAttacker(EASY, 2, CHAOS_RAIDER);//call CampaignAttacker( EASY, 2, CHAOS_RAIDER    )
			CampaignAttacker(EASY, 2, CHAOS_WARLOCK);//call CampaignAttacker( EASY, 2, CHAOS_WARLOCK   )
			custom_suicide(4*60,Thrall);//call custom_suicide(4*60,Thrall)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttacker(EASY, 8, CHAOS_GRUNT);//call CampaignAttacker( EASY, 8, CHAOS_GRUNT     )
			CampaignAttacker(EASY, 1, CHAOS_WARLOCK);//call CampaignAttacker( EASY, 1, CHAOS_WARLOCK   )
			custom_suicide(2*60,Jaina);//call custom_suicide(2*60,Jaina)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttacker(EASY, 6, CHAOS_GRUNT);//call CampaignAttacker( EASY, 6, CHAOS_GRUNT     )
			CampaignAttacker(EASY, 3, CHAOS_RAIDER);//call CampaignAttacker( EASY, 3, CHAOS_RAIDER    )
			CampaignAttacker(EASY, 2, CHAOS_WARLOCK);//call CampaignAttacker( EASY, 2, CHAOS_WARLOCK   )
			custom_suicide(5*60,Thrall);//call custom_suicide(5*60,Thrall)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttacker(EASY, 6, CHAOS_GRUNT);//call CampaignAttacker( EASY, 6, CHAOS_GRUNT     )
			CampaignAttacker(EASY, 5, CHAOS_RAIDER);//call CampaignAttacker( EASY, 5, CHAOS_RAIDER    )
			custom_suicide(3*60,Jaina);//call custom_suicide(3*60,Jaina)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttacker(EASY, 8, CHAOS_GRUNT);//call CampaignAttacker( EASY, 8, CHAOS_GRUNT     )
			CampaignAttacker(EASY, 2, CHAOS_RAIDER);//call CampaignAttacker( EASY, 2, CHAOS_RAIDER    )
			CampaignAttacker(EASY, 3, CHAOS_WARLOCK);//call CampaignAttacker( EASY, 3, CHAOS_WARLOCK   )
			custom_suicide(3*60,Thrall);//call custom_suicide(3*60,Thrall)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttacker(EASY, 8, CHAOS_GRUNT);//call CampaignAttacker( EASY, 8, CHAOS_GRUNT     )
			CampaignAttacker(EASY, 6, CHAOS_RAIDER);//call CampaignAttacker( EASY, 6, CHAOS_RAIDER    )
			CampaignAttacker(EASY, 2, CHAOS_WARLOCK);//call CampaignAttacker( EASY, 2, CHAOS_WARLOCK   )
			custom_suicide(2*60,Jaina);//call custom_suicide(2*60,Jaina)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttacker(EASY, 6, CHAOS_GRUNT);//call CampaignAttacker( EASY, 6, CHAOS_GRUNT     )
			CampaignAttacker(EASY, 8, CHAOS_RAIDER);//call CampaignAttacker( EASY, 8, CHAOS_RAIDER    )
			CampaignAttacker(EASY, 3, CHAOS_WARLOCK);//call CampaignAttacker( EASY, 3, CHAOS_WARLOCK   )
			custom_suicide(2*60,Thrall);//call custom_suicide(2*60,Thrall)
			//
			while (true) {//loop
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttacker(EASY, 8, CHAOS_GRUNT);//call CampaignAttacker( EASY, 8, CHAOS_GRUNT     )
				CampaignAttacker(EASY, 6, CHAOS_RAIDER);//call CampaignAttacker( EASY, 6, CHAOS_RAIDER    )
				CampaignAttacker(EASY, 2, CHAOS_WARLOCK);//call CampaignAttacker( EASY, 2, CHAOS_WARLOCK   )
				custom_suicide(4*60,Jaina);//call custom_suicide(4*60,Jaina)
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttacker(EASY, 6, CHAOS_GRUNT);//call CampaignAttacker( EASY, 6, CHAOS_GRUNT     )
				CampaignAttacker(EASY, 8, CHAOS_RAIDER);//call CampaignAttacker( EASY, 8, CHAOS_RAIDER    )
				CampaignAttacker(EASY, 3, CHAOS_WARLOCK);//call CampaignAttacker( EASY, 3, CHAOS_WARLOCK   )
				custom_suicide(4*60,Thrall);//call custom_suicide(4*60,Thrall)
			}//endloop
		}//endfunction

	
	}
}

