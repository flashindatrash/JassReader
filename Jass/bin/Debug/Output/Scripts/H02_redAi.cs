using System;
using System.Collections.Generic;

namespace Jass {

	public class H02_redAi {

		//
		//
		//
		public static player user = Player(1);//player user = Player(1)
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(CommonAi.PIG_FARM, null);//call CampaignAI(PIG_FARM,null)
			SetReplacements(0, 1, 3);//call SetReplacements(0,1,3)
			CampaignDefenderEx(1, 1, 1, CommonAi.HEAD_HUNTER);//call CampaignDefenderEx( 1,1,1, HEAD_HUNTER	)
			CampaignDefenderEx(1, 1, 2, CommonAi.GRUNT);//call CampaignDefenderEx( 1,1,2, GRUNT		)
			CampaignDefenderEx(0, 0, 1, CommonAi.RAIDER);//call CampaignDefenderEx( 0,0,1, RAIDER		)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2, 2, 2, CommonAi.GRUNT);//call CampaignAttackerEx( 2,2,2, GRUNT       )
			CampaignAttackerEx(1, 1, 2, CommonAi.HEAD_HUNTER);//call CampaignAttackerEx( 1,1,2, HEAD_HUNTER )
			SuicideOnPlayer(CommonAi.M2, U08_tealAi.user);//call SuicideOnPlayer(M2,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2, 2, 2, CommonAi.GRUNT);//call CampaignAttackerEx( 2,2,2, GRUNT       )
			CampaignAttackerEx(2, 2, 3, CommonAi.HEAD_HUNTER);//call CampaignAttackerEx( 2,2,3, HEAD_HUNTER )
			SuicideOnPlayer(CommonAi.M2, U08_tealAi.user);//call SuicideOnPlayer(M2,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(4, 4, 4, CommonAi.GRUNT);//call CampaignAttackerEx( 4,4,4, GRUNT		)
			CampaignAttackerEx(0, 0, 2, CommonAi.RAIDER);//call CampaignAttackerEx( 0,0,2, RAIDER		)
			CampaignAttackerEx(1, 1, 1, CommonAi.HEAD_HUNTER);//call CampaignAttackerEx( 1,1,1, HEAD_HUNTER )
			SuicideOnPlayer(CommonAi.M3, U08_tealAi.user);//call SuicideOnPlayer(M3,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(3, 3, 3, CommonAi.GRUNT);//call CampaignAttackerEx( 3,3,3, GRUNT       )
			CampaignAttackerEx(1, 1, 3, CommonAi.HEAD_HUNTER);//call CampaignAttackerEx( 1,1,3, HEAD_HUNTER )
			SuicideOnPlayer(CommonAi.M2, U08_tealAi.user);//call SuicideOnPlayer(M2,user)
			while (true) {//loop
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(1, 1, 3, CommonAi.GRUNT);//call CampaignAttackerEx( 1,1,3, GRUNT       )
				CampaignAttackerEx(0, 0, 2, CommonAi.RAIDER);//call CampaignAttackerEx( 0,0,2, RAIDER		)
				CampaignAttackerEx(4, 4, 4, CommonAi.HEAD_HUNTER);//call CampaignAttackerEx( 4,4,4, HEAD_HUNTER )
				SuicideOnPlayer(CommonAi.M3, U08_tealAi.user);//call SuicideOnPlayer(M3,user)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(4, 4, 5, CommonAi.GRUNT);//call CampaignAttackerEx( 4,4,5, GRUNT       )
				CampaignAttackerEx(1, 1, 2, CommonAi.HEAD_HUNTER);//call CampaignAttackerEx( 1,1,2, HEAD_HUNTER )
				SuicideOnPlayer(CommonAi.M3, U08_tealAi.user);//call SuicideOnPlayer(M3,user)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(2, 2, 3, CommonAi.GRUNT);//call CampaignAttackerEx( 2,2,3, GRUNT       )
				CampaignAttackerEx(0, 0, 2, CommonAi.RAIDER);//call CampaignAttackerEx( 0,0,2, RAIDER		)
				CampaignAttackerEx(3, 3, 4, CommonAi.HEAD_HUNTER);//call CampaignAttackerEx( 3,3,4, HEAD_HUNTER )
				SuicideOnPlayer(CommonAi.M4, U08_tealAi.user);//call SuicideOnPlayer(M4,user)
			}//endloop
		}//endfunction

	
	}
}

