using System;
using System.Collections.Generic;

namespace Jass {

	public class H02_redAi {

		//
		//
		//
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(PIG_FARM,null);//call CampaignAI(PIG_FARM,null)
			SetReplacements(0,1,3);//call SetReplacements(0,1,3)
			CampaignDefenderEx(1,1,1, HEAD_HUNTER);//call CampaignDefenderEx( 1,1,1, HEAD_HUNTER	)
			CampaignDefenderEx(1,1,2, GRUNT);//call CampaignDefenderEx( 1,1,2, GRUNT		)
			CampaignDefenderEx(0,0,1, RAIDER);//call CampaignDefenderEx( 0,0,1, RAIDER		)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2,2,2, GRUNT);//call CampaignAttackerEx( 2,2,2, GRUNT       )
			CampaignAttackerEx(1,1,2, HEAD_HUNTER);//call CampaignAttackerEx( 1,1,2, HEAD_HUNTER )
			SuicideOnPlayer(M2,user);//call SuicideOnPlayer(M2,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2,2,2, GRUNT);//call CampaignAttackerEx( 2,2,2, GRUNT       )
			CampaignAttackerEx(2,2,3, HEAD_HUNTER);//call CampaignAttackerEx( 2,2,3, HEAD_HUNTER )
			SuicideOnPlayer(M2,user);//call SuicideOnPlayer(M2,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(4,4,4, GRUNT);//call CampaignAttackerEx( 4,4,4, GRUNT		)
			CampaignAttackerEx(0,0,2, RAIDER);//call CampaignAttackerEx( 0,0,2, RAIDER		)
			CampaignAttackerEx(1,1,1, HEAD_HUNTER);//call CampaignAttackerEx( 1,1,1, HEAD_HUNTER )
			SuicideOnPlayer(M3,user);//call SuicideOnPlayer(M3,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(3,3,3, GRUNT);//call CampaignAttackerEx( 3,3,3, GRUNT       )
			CampaignAttackerEx(1,1,3, HEAD_HUNTER);//call CampaignAttackerEx( 1,1,3, HEAD_HUNTER )
			SuicideOnPlayer(M2,user);//call SuicideOnPlayer(M2,user)
			while (true) {//loop
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(1,1,3, GRUNT);//call CampaignAttackerEx( 1,1,3, GRUNT       )
				CampaignAttackerEx(0,0,2, RAIDER);//call CampaignAttackerEx( 0,0,2, RAIDER		)
				CampaignAttackerEx(4,4,4, HEAD_HUNTER);//call CampaignAttackerEx( 4,4,4, HEAD_HUNTER )
				SuicideOnPlayer(M3,user);//call SuicideOnPlayer(M3,user)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(4,4,5, GRUNT);//call CampaignAttackerEx( 4,4,5, GRUNT       )
				CampaignAttackerEx(1,1,2, HEAD_HUNTER);//call CampaignAttackerEx( 1,1,2, HEAD_HUNTER )
				SuicideOnPlayer(M3,user);//call SuicideOnPlayer(M3,user)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(2,2,3, GRUNT);//call CampaignAttackerEx( 2,2,3, GRUNT       )
				CampaignAttackerEx(0,0,2, RAIDER);//call CampaignAttackerEx( 0,0,2, RAIDER		)
				CampaignAttackerEx(3,3,4, HEAD_HUNTER);//call CampaignAttackerEx( 3,3,4, HEAD_HUNTER )
				SuicideOnPlayer(M4,user);//call SuicideOnPlayer(M4,user)
			}//endloop
		}//endfunction

	
	}
}

