using System;
using System.Collections.Generic;

namespace Jass {

	public class N08_yellowAi {

		//
		//
		//
		//
		public static player user = Player(0);//player user = Player(0)
		private void set_cheats() {//function set_cheats takes nothing returns nothing
			Cheat("warnings");//call Cheat("warnings")
			Cheat("viewres");//call Cheat("viewres")
			Cheat("av");//call Cheat("av")
			Cheat("dg");//call Cheat("dg")
		}//endfunction
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(CommonAi.ZIGGURAT_1, null);//call CampaignAI(ZIGGURAT_1,null)
			SetBuildUnit(1, CommonAi.ACOLYTE);//call SetBuildUnit( 1, ACOLYTE			)
			SetBuildUnit(1, CommonAi.UNDEAD_MINE);//call SetBuildUnit( 1, UNDEAD_MINE		)
			SetBuildUnit(1, CommonAi.NECROPOLIS_1);//call SetBuildUnit( 1, NECROPOLIS_1		)
			SetBuildUnit(6, CommonAi.ACOLYTE);//call SetBuildUnit( 6, ACOLYTE			)
			SetBuildUnit(1, CommonAi.CRYPT);//call SetBuildUnit( 1, CRYPT				)
			SetBuildUnit(1, CommonAi.GRAVEYARD);//call SetBuildUnit( 1, GRAVEYARD			)
			SetBuildUnit(3, CommonAi.ZIGGURAT_1);//call SetBuildUnit( 3, ZIGGURAT_1  		)
			SetBuildUnit(3, CommonAi.ZIGGURAT_2);//call SetBuildUnit( 3, ZIGGURAT_2		)
			SetBuildUnit(1, CommonAi.UNDEAD_ALTAR);//call SetBuildUnit( 1, UNDEAD_ALTAR		)
			SetBuildUnit(1, CommonAi.SAC_PIT);//call SetBuildUnit( 1, SAC_PIT			)
			SetBuildUnit(2, CommonAi.CRYPT);//call SetBuildUnit( 2, CRYPT				)
			SetBuildUnit(1, CommonAi.DAMNED_TEMPLE);//call SetBuildUnit( 1, DAMNED_TEMPLE		)
			SetBuildUnit(1, CommonAi.SLAUGHTERHOUSE);//call SetBuildUnit( 1, SLAUGHTERHOUSE	)
			SetBuildUnit(7, CommonAi.ZIGGURAT_1);//call SetBuildUnit( 7, ZIGGURAT_1  		)
			SetBuildUnit(7, CommonAi.ZIGGURAT_2);//call SetBuildUnit( 7, ZIGGURAT_2		)
			SetBuildUnit(1, CommonAi.NECROPOLIS_2);//call SetBuildUnit( 1, NECROPOLIS_2		)
			SetBuildUnit(1, CommonAi.NECROPOLIS_3);//call SetBuildUnit( 1, NECROPOLIS_3		)
			WaitForSignal();//call WaitForSignal()
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttacker(CommonAi.EASY, 6, CommonAi.GHOUL);//call CampaignAttacker( EASY,    6, GHOUL         )
			SuicideOnPlayer(0, U08_tealAi.user);//call SuicideOnPlayer(0,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttacker(CommonAi.EASY, 6, CommonAi.GHOUL);//call CampaignAttacker( EASY,    6, GHOUL         )
			CampaignAttacker(CommonAi.EASY, 1, CommonAi.NECRO);//call CampaignAttacker( EASY,    1, NECRO         )
			SuicideOnPlayer(3*60, U08_tealAi.user);//call SuicideOnPlayer(3*60,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttacker(CommonAi.EASY, 8, CommonAi.GHOUL);//call CampaignAttacker( EASY,    8, GHOUL         )
			CampaignAttacker(CommonAi.EASY, 2, CommonAi.NECRO);//call CampaignAttacker( EASY,    2, NECRO         )
			SuicideOnPlayer(3*60, U08_tealAi.user);//call SuicideOnPlayer(3*60,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttacker(CommonAi.EASY, 8, CommonAi.GHOUL);//call CampaignAttacker( EASY,    8, GHOUL         )
			CampaignAttacker(CommonAi.EASY, 2, CommonAi.NECRO);//call CampaignAttacker( EASY,    2, NECRO         )
			CampaignAttacker(CommonAi.EASY, 1, CommonAi.MEAT_WAGON);//call CampaignAttacker( EASY,    1, MEAT_WAGON    )
			SuicideOnPlayer(3*60, U08_tealAi.user);//call SuicideOnPlayer(3*60,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttacker(CommonAi.EASY, 8, CommonAi.GHOUL);//call CampaignAttacker( EASY,    8, GHOUL         )
			CampaignAttacker(CommonAi.EASY, 2, CommonAi.NECRO);//call CampaignAttacker( EASY,    2, NECRO         )
			CampaignAttacker(CommonAi.EASY, 2, CommonAi.MEAT_WAGON);//call CampaignAttacker( EASY,    2, MEAT_WAGON    )
			SuicideOnPlayer(2*60, U08_tealAi.user);//call SuicideOnPlayer(2*60,user)
			//
			ForeverSuicideOnPlayer(2*60, U08_tealAi.user);//call ForeverSuicideOnPlayer(2*60,user)
		}//endfunction

	
	}
}

