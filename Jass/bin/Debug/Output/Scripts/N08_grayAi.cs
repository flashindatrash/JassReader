using System;
using System.Collections.Generic;

namespace Jass {

	public class N08_grayAi {

		//
		//
		//
		//
		public static player user = Player(9);//player user = Player(9)
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
			set_cheats();//debug call set_cheats()
			CampaignAI(ZIGGURAT_1,null);//call CampaignAI(ZIGGURAT_1,null)
			SetBuildUnit(1, ACOLYTE);//call SetBuildUnit( 1, ACOLYTE			)
			SetBuildUnit(1, UNDEAD_MINE);//call SetBuildUnit( 1, UNDEAD_MINE		)
			SetBuildUnit(1, NECROPOLIS_1);//call SetBuildUnit( 1, NECROPOLIS_1		)
			SetBuildUnit(6, ACOLYTE);//call SetBuildUnit( 6, ACOLYTE			)
			SetBuildUnit(1, CRYPT);//call SetBuildUnit( 1, CRYPT				)
			SetBuildUnit(1, GRAVEYARD);//call SetBuildUnit( 1, GRAVEYARD			)
			SetBuildUnit(3, ZIGGURAT_1);//call SetBuildUnit( 3, ZIGGURAT_1  		)
			SetBuildUnit(3, ZIGGURAT_2);//call SetBuildUnit( 3, ZIGGURAT_2		)
			SetBuildUnit(1, UNDEAD_ALTAR);//call SetBuildUnit( 1, UNDEAD_ALTAR		)
			SetBuildUnit(1, SAC_PIT);//call SetBuildUnit( 1, SAC_PIT			)
			SetBuildUnit(2, CRYPT);//call SetBuildUnit( 2, CRYPT				)
			SetBuildUnit(1, DAMNED_TEMPLE);//call SetBuildUnit( 1, DAMNED_TEMPLE		)
			SetBuildUnit(1, SLAUGHTERHOUSE);//call SetBuildUnit( 1, SLAUGHTERHOUSE	)
			SetBuildUnit(7, ZIGGURAT_1);//call SetBuildUnit( 7, ZIGGURAT_1  		)
			SetBuildUnit(7, ZIGGURAT_2);//call SetBuildUnit( 7, ZIGGURAT_2		)
			SetBuildUnit(1, NECROPOLIS_2);//call SetBuildUnit( 1, NECROPOLIS_2		)
			SetBuildUnit(1, NECROPOLIS_3);//call SetBuildUnit( 1, NECROPOLIS_3		)
			WaitForSignal();//call WaitForSignal()
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttacker(EASY,    6, GHOUL);//call CampaignAttacker( EASY,    6, GHOUL         )
			SuicideOnPlayer(0,user);//call SuicideOnPlayer(0,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttacker(EASY,    6, GHOUL);//call CampaignAttacker( EASY,    6, GHOUL         )
			CampaignAttacker(EASY,    1, NECRO);//call CampaignAttacker( EASY,    1, NECRO         )
			SuicideOnPlayer(3*60,user);//call SuicideOnPlayer(3*60,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttacker(EASY,    8, GHOUL);//call CampaignAttacker( EASY,    8, GHOUL         )
			CampaignAttacker(EASY,    2, NECRO);//call CampaignAttacker( EASY,    2, NECRO         )
			SuicideOnPlayer(3*60,user);//call SuicideOnPlayer(3*60,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttacker(EASY,    8, GHOUL);//call CampaignAttacker( EASY,    8, GHOUL         )
			CampaignAttacker(EASY,    2, NECRO);//call CampaignAttacker( EASY,    2, NECRO         )
			CampaignAttacker(EASY,    1, MEAT_WAGON);//call CampaignAttacker( EASY,    1, MEAT_WAGON    )
			SuicideOnPlayer(3*60,user);//call SuicideOnPlayer(3*60,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttacker(EASY,    8, GHOUL);//call CampaignAttacker( EASY,    8, GHOUL         )
			CampaignAttacker(EASY,    2, NECRO);//call CampaignAttacker( EASY,    2, NECRO         )
			CampaignAttacker(EASY,    2, MEAT_WAGON);//call CampaignAttacker( EASY,    2, MEAT_WAGON    )
			SuicideOnPlayer(2*60,user);//call SuicideOnPlayer(2*60,user)
			//
			ForeverSuicideOnPlayer(2*60,user);//call ForeverSuicideOnPlayer(2*60,user)
		}//endfunction

	
	}
}

