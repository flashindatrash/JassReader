using System;
using System.Collections.Generic;

namespace Jass {

	public class N06_tichAi {

		//
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(0,null);//call CampaignAI(0,null)
			SetReplacementCount(99);//call SetReplacementCount(99)
			SetCaptainHome(DEFENSE_CAPTAIN, TICH_CAPT_X, TICH_CAPT_Y);//call SetCaptainHome( DEFENSE_CAPTAIN, TICH_CAPT_X, TICH_CAPT_Y )
			SetCaptainHome(ATTACK_CAPTAIN,  WAVE_CAPT_X, WAVE_CAPT_Y);//call SetCaptainHome( ATTACK_CAPTAIN,  WAVE_CAPT_X, WAVE_CAPT_Y )
			CampaignDefender(EASY, 1, TICHONDRIUS);//call CampaignDefender( EASY, 1, TICHONDRIUS )
			CampaignDefender(EASY, 2, DOOMGUARD);//call CampaignDefender( EASY, 2, DOOMGUARD   )
			WaitForSignal();//call WaitForSignal()
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(4,4,6, FELLHOUND);//call CampaignAttackerEx( 4,4,6, FELLHOUND   )
			CampaignAttackerEx(1,1,2, WAVE_DOOMS);//call CampaignAttackerEx( 1,1,2, WAVE_DOOMS  )
			SuicideOnPlayerEx(M2,M2,M1,user);//call SuicideOnPlayerEx(M2,M2,M1,user)
			while (true) {//loop
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(1,1,4, INFERNAL);//call CampaignAttackerEx( 1,1,4, INFERNAL    )
				CampaignAttackerEx(1,1,2, WAVE_DOOMS);//call CampaignAttackerEx( 1,1,2, WAVE_DOOMS  )
				SuicideOnPlayerEx(M5,M5,M4,user);//call SuicideOnPlayerEx(M5,M5,M4,user)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(3,3,4, FELLHOUND);//call CampaignAttackerEx( 3,3,4, FELLHOUND   )
				CampaignAttackerEx(1,1,2, INFERNAL);//call CampaignAttackerEx( 1,1,2, INFERNAL    )
				CampaignAttackerEx(0,0,1, WAVE_DOOMS);//call CampaignAttackerEx( 0,0,1, WAVE_DOOMS  )
				SuicideOnPlayerEx(M6,M6,M5,user);//call SuicideOnPlayerEx(M6,M6,M5,user)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(3,3,6, FELLHOUND);//call CampaignAttackerEx( 3,3,6, FELLHOUND   )
				CampaignAttackerEx(2,2,3, WAVE_DOOMS);//call CampaignAttackerEx( 2,2,3, WAVE_DOOMS  )
				SuicideOnPlayerEx(M5,M5,M4,user);//call SuicideOnPlayerEx(M5,M5,M4,user)
			}//endloop
		}//endfunction

	
	}
}

