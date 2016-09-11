using System;
using System.Collections.Generic;

namespace Jass {

	public class H05x07Ai {

		//
		//
		//
		public static player targ1 = PlayerEx(6);//player targ1 = PlayerEx(6)
		public static player targ2 = PlayerEx(4);//player targ2 = PlayerEx(4)
		public static player targ = targ1;//player targ  = targ1
		public const int AKAMA = 'Naka';//constant integer AKAMA          = 'Naka'
		public const int DPEON = 'ndrl';//constant integer DPEON          = 'ndrl'
		public const int DCATAPULT = 'ncat';//constant integer DCATAPULT      = 'ncat'
		public const int DSALAMANDER = 'ndsa';//constant integer DSALAMANDER    = 'ndsa'
		public const int DSTALKER = 'ndrt';//constant integer DSTALKER       = 'ndrt'
		public const int DVINDICATOR = 'ndrn';//constant integer DVINDICATOR    = 'ndrn'
		public const int DHARBINGER = 'ndrh';//constant integer DHARBINGER     = 'ndrh'
		public const int DSEER = 'ndrs';//constant integer DSEER          = 'ndrs'
		//
		//
		//
		private void switch_targets() {//function switch_targets takes nothing returns nothing
			while (true) {//loop
				if (CommandsWaiting() > 0) { break; }//exitwhen CommandsWaiting() > 0
				Sleep(1);//call Sleep(1)
			}//endloop
			targ = targ2;//set targ = targ2
		}//endfunction
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(CommonAi.PIG_FARM, null);//call CampaignAI(PIG_FARM,null)
			DoCampaignFarms(false);//call DoCampaignFarms(false)
			SetReplacements(9, 9, 9);//call SetReplacements(9,9,9)
			SetPeonsRepair(true);//call SetPeonsRepair(true)
			SetCaptainHome(CommonAi.ATTACK_CAPTAIN, -4268, -6436);//call SetCaptainHome(ATTACK_CAPTAIN, -4268,-6436)
			SetCaptainHome(CommonAi.DEFENSE_CAPTAIN, -4723, -6604);//call SetCaptainHome(DEFENSE_CAPTAIN,-4723,-6604)
			SetBuildUnitEx(3, 3, 3, H05x07Ai.DPEON);//call SetBuildUnitEx( 3,3,3, DPEON )
			CampaignDefenderEx(1, 1, 1, H05x07Ai.DVINDICATOR);//call CampaignDefenderEx( 1, 1, 1, DVINDICATOR   )
			CampaignDefenderEx(1, 1, 1, H05x07Ai.DSEER);//call CampaignDefenderEx( 1, 1, 1, DSEER         )
			CampaignDefenderEx(1, 1, 1, H05x07Ai.DSALAMANDER);//call CampaignDefenderEx( 1, 1, 1, DSALAMANDER   )
			CampaignDefenderEx(1, 1, 1, H05x07Ai.AKAMA);//call CampaignDefenderEx( 1, 1, 1, AKAMA         )
			WaitForSignal();//call WaitForSignal()
			StartThread(function switch_targets);//call StartThread(function switch_targets)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(3, 3, 2, H05x07Ai.DVINDICATOR);//call CampaignAttackerEx( 3,3,2, DVINDICATOR     )
			CampaignAttackerEx(4, 4, 3, H05x07Ai.DSALAMANDER);//call CampaignAttackerEx( 4,4,3, DSALAMANDER     )
			CampaignAttackerEx(1, 1, 1, H05x07Ai.AKAMA);//call CampaignAttackerEx( 1,1,1, AKAMA           )
			SuicideOnPlayerEx(CommonAi.M1, CommonAi.M1, CommonAi.M1, N07x04Ai.targ);//call SuicideOnPlayerEx(M1,M1,M1,targ)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(8, 8, 6, H05x07Ai.DSTALKER);//call CampaignAttackerEx( 8,8,6, DSTALKER        )
			SuicideOnPlayerEx(CommonAi.M4, CommonAi.M4, CommonAi.M4, N07x04Ai.targ);//call SuicideOnPlayerEx(M4,M4,M4,targ)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(3, 3, 2, H05x07Ai.DVINDICATOR);//call CampaignAttackerEx( 3,3,2, DVINDICATOR     )
			CampaignAttackerEx(2, 2, 1, H05x07Ai.DHARBINGER);//call CampaignAttackerEx( 2,2,1, DHARBINGER      )
			CampaignAttackerEx(2, 2, 1, H05x07Ai.DCATAPULT);//call CampaignAttackerEx( 2,2,1, DCATAPULT       )
			CampaignAttackerEx(1, 1, 1, H05x07Ai.AKAMA);//call CampaignAttackerEx( 1,1,1, AKAMA           )
			SuicideOnPlayerEx(CommonAi.M4, CommonAi.M4, CommonAi.M4, N07x04Ai.targ);//call SuicideOnPlayerEx(M4,M4,M4,targ)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(3, 3, 2, H05x07Ai.DVINDICATOR);//call CampaignAttackerEx( 3,3,2, DVINDICATOR     )
			CampaignAttackerEx(2, 2, 1, H05x07Ai.DHARBINGER);//call CampaignAttackerEx( 2,2,1, DHARBINGER      )
			CampaignAttackerEx(2, 2, 1, H05x07Ai.DCATAPULT);//call CampaignAttackerEx( 2,2,1, DCATAPULT       )
			SuicideOnPlayerEx(CommonAi.M4, CommonAi.M4, CommonAi.M4, N07x04Ai.targ);//call SuicideOnPlayerEx(M4,M4,M4,targ)
			while (true) {//loop
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(5, 5, 4, H05x07Ai.DVINDICATOR);//call CampaignAttackerEx( 5,5,4, DVINDICATOR     )
				CampaignAttackerEx(2, 2, 2, H05x07Ai.DSALAMANDER);//call CampaignAttackerEx( 2,2,2, DSALAMANDER     )
				CampaignAttackerEx(1, 1, 1, H05x07Ai.DSEER);//call CampaignAttackerEx( 1,1,1, DSEER           )
				CampaignAttackerEx(1, 1, 1, H05x07Ai.DCATAPULT);//call CampaignAttackerEx( 1,1,1, DCATAPULT       )
				SuicideOnPlayerEx(CommonAi.M4, CommonAi.M4, CommonAi.M4, N07x04Ai.targ);//call SuicideOnPlayerEx(M4,M4,M4,targ)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(9, 9, 7, H05x07Ai.DSTALKER);//call CampaignAttackerEx( 9,9,7, DSTALKER        )
				CampaignAttackerEx(1, 1, 1, H05x07Ai.AKAMA);//call CampaignAttackerEx( 1,1,1, AKAMA           )
				SuicideOnPlayerEx(CommonAi.M4, CommonAi.M4, CommonAi.M4, N07x04Ai.targ);//call SuicideOnPlayerEx(M4,M4,M4,targ)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(5, 5, 4, H05x07Ai.DVINDICATOR);//call CampaignAttackerEx( 5,5,4, DVINDICATOR     )
				CampaignAttackerEx(2, 2, 2, H05x07Ai.DSALAMANDER);//call CampaignAttackerEx( 2,2,2, DSALAMANDER     )
				CampaignAttackerEx(1, 1, 1, H05x07Ai.DSEER);//call CampaignAttackerEx( 1,1,1, DSEER           )
				CampaignAttackerEx(1, 1, 1, H05x07Ai.DCATAPULT);//call CampaignAttackerEx( 1,1,1, DCATAPULT       )
				SuicideOnPlayerEx(CommonAi.M4, CommonAi.M4, CommonAi.M4, N07x04Ai.targ);//call SuicideOnPlayerEx(M4,M4,M4,targ)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(5, 5, 4, H05x07Ai.DVINDICATOR);//call CampaignAttackerEx( 5,5,4, DVINDICATOR     )
				CampaignAttackerEx(2, 2, 2, H05x07Ai.DSALAMANDER);//call CampaignAttackerEx( 2,2,2, DSALAMANDER     )
				CampaignAttackerEx(1, 1, 1, H05x07Ai.DHARBINGER);//call CampaignAttackerEx( 1,1,1, DHARBINGER      )
				CampaignAttackerEx(1, 1, 1, H05x07Ai.DCATAPULT);//call CampaignAttackerEx( 1,1,1, DCATAPULT       )
				SuicideOnPlayerEx(CommonAi.M4, CommonAi.M4, CommonAi.M4, N07x04Ai.targ);//call SuicideOnPlayerEx(M4,M4,M4,targ)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(8, 8, 7, H05x07Ai.DSTALKER);//call CampaignAttackerEx( 8,8,7, DSTALKER        )
				CampaignAttackerEx(1, 1, 1, H05x07Ai.AKAMA);//call CampaignAttackerEx( 1,1,1, AKAMA           )
				SuicideOnPlayerEx(CommonAi.M4, CommonAi.M4, CommonAi.M4, N07x04Ai.targ);//call SuicideOnPlayerEx(M4,M4,M4,targ)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(5, 5, 4, H05x07Ai.DVINDICATOR);//call CampaignAttackerEx( 5,5,4, DVINDICATOR     )
				CampaignAttackerEx(2, 2, 2, H05x07Ai.DSALAMANDER);//call CampaignAttackerEx( 2,2,2, DSALAMANDER     )
				CampaignAttackerEx(1, 1, 1, H05x07Ai.DSEER);//call CampaignAttackerEx( 1,1,1, DSEER           )
				CampaignAttackerEx(1, 1, 1, H05x07Ai.DCATAPULT);//call CampaignAttackerEx( 1,1,1, DCATAPULT       )
				SuicideOnPlayerEx(CommonAi.M4, CommonAi.M4, CommonAi.M4, N07x04Ai.targ);//call SuicideOnPlayerEx(M4,M4,M4,targ)
			}//endloop
		}//endfunction

	
	}
}

