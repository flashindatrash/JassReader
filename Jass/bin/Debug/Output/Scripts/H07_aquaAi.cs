using System;
using System.Collections.Generic;

namespace Jass {

	public class H07_aquaAi {

		//
		//
		//
		public static player user = Player(1);//player user = Player(1)
		private void set_cheats() {//function set_cheats takes nothing returns nothing
			Cheat("warnings");//call Cheat("warnings")
			Cheat("viewres");//call Cheat("viewres")
			Cheat("av");//call Cheat("av")
			Cheat("dg");//call Cheat("dg")
			Cheat("vision 3");//call Cheat("vision 3")
			Cheat("vision 10");//call Cheat("vision 10")
		}//endfunction
		//
		//
		//
		private int hero_levels() {//function hero_levels takes nothing returns integer
			int hero = GetHeroId();//local integer hero  = GetHeroId()
			int level = GetHeroLevelAI();//local integer level = GetHeroLevelAI()
			if (hero == LICH) {//if hero == LICH then
				if (level == 2 || level == 4) {//if level == 2 or level == 4 then
					return 'AUfn';//return 'AUfn'
				}//endif
				if (level == 3) {//if level == 3 then
					return 'AUfa';//return 'AUfa'
				}//endif
				if (level == 5) {//if level == 5 then
					return 'AUdd';//return 'AUdd'
				}//endif
			}//endif
			return 0;//return 0
		}//endfunction
		//
		//
		//
		private void SetDefenders() {//function SetDefenders takes nothing returns nothing
			CampaignDefender(CommonAi.EASY, 1, CommonAi.GARGOYLE);//call CampaignDefender( EASY, 1, GARGOYLE    )
			CampaignDefender(CommonAi.EASY, 2, CommonAi.GHOUL);//call CampaignDefender( EASY, 2, GHOUL       )
			CampaignDefender(CommonAi.EASY, 1, CommonAi.NECRO);//call CampaignDefender( EASY, 1, NECRO       )
		}//endfunction
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(CommonAi.ZIGGURAT_1, function hero_levels);//call CampaignAI(ZIGGURAT_1,function hero_levels)
			SetBuildUnit(1, CommonAi.ACOLYTE);//call SetBuildUnit( 1, ACOLYTE			)
			SetBuildUnit(1, CommonAi.NECROPOLIS_1);//call SetBuildUnit( 1, NECROPOLIS_1		)
			SetBuildUnit(1, CommonAi.CRYPT);//call SetBuildUnit( 1, CRYPT				)
			SetBuildUnit(1, CommonAi.GRAVEYARD);//call SetBuildUnit( 1, GRAVEYARD			)
			SetBuildUnit(1, CommonAi.UNDEAD_MINE);//call SetBuildUnit( 1, UNDEAD_MINE		)
			SetBuildUnit(1, CommonAi.NECROPOLIS_2);//call SetBuildUnit( 1, NECROPOLIS_2		)
			SetBuildUnit(1, CommonAi.UNDEAD_ALTAR);//call SetBuildUnit( 1, UNDEAD_ALTAR      )
			SetBuildUnit(1, CommonAi.SLAUGHTERHOUSE);//call SetBuildUnit( 1, SLAUGHTERHOUSE	)
			SetBuildUnit(1, CommonAi.DAMNED_TEMPLE);//call SetBuildUnit( 1, DAMNED_TEMPLE     )
			SetBuildUnit(1, CommonAi.NECROPOLIS_3);//call SetBuildUnit( 1, NECROPOLIS_3		)
			SetBuildUnit(1, CommonAi.SAC_PIT);//call SetBuildUnit( 1, SAC_PIT           )
			SetBuildUnit(5, CommonAi.ACOLYTE);//call SetBuildUnit( 5, ACOLYTE			)
			while (true) {//loop
				SetDefenders();//call SetDefenders()
				if (CommandsWaiting() != 0) { break; }//exitwhen CommandsWaiting() != 0
				Sleep(10);//call Sleep(10)
			}//endloop
			PopLastCommand();//call PopLastCommand()
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttacker(CommonAi.EASY, 4, CommonAi.GHOUL);//call CampaignAttacker( EASY,    4, GHOUL        )
			CampaignAttacker(CommonAi.EASY, 1, CommonAi.NECRO);//call CampaignAttacker( EASY,    1, NECRO        )
			SuicideOnPlayer(0, U08_tealAi.user);//call SuicideOnPlayer(0,user)
			SetDefenders();//call SetDefenders()
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttacker(CommonAi.EASY, 3, CommonAi.GARGOYLE);//call CampaignAttacker( EASY,    3, GARGOYLE     )
			SuicideOnPlayer(5*60, U08_tealAi.user);//call SuicideOnPlayer(5*60,user)
			SetDefenders();//call SetDefenders()
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttacker(CommonAi.EASY, 4, CommonAi.GHOUL);//call CampaignAttacker( EASY,    4, GHOUL        )
			CampaignAttacker(CommonAi.EASY, 1, CommonAi.ABOMINATION);//call CampaignAttacker( EASY,    1, ABOMINATION  )
			CampaignAttacker(CommonAi.EASY, 1, CommonAi.NECRO);//call CampaignAttacker( EASY,    1, NECRO        )
			CampaignAttacker(CommonAi.EASY, 1, CommonAi.LICH);//call CampaignAttacker( EASY,    1, LICH         )
			SuicideOnPlayer(4*60, U08_tealAi.user);//call SuicideOnPlayer(4*60,user)
			SetDefenders();//call SetDefenders()
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttacker(CommonAi.EASY, 2, CommonAi.GHOUL);//call CampaignAttacker( EASY,    2, GHOUL        )
			CampaignAttacker(CommonAi.EASY, 2, CommonAi.ABOMINATION);//call CampaignAttacker( EASY,    2, ABOMINATION  )
			CampaignAttacker(CommonAi.EASY, 1, CommonAi.NECRO);//call CampaignAttacker( EASY,    1, NECRO        )
			CampaignAttacker(CommonAi.EASY, 1, CommonAi.MEAT_WAGON);//call CampaignAttacker( EASY,    1, MEAT_WAGON   )
			CampaignAttacker(CommonAi.EASY, 1, CommonAi.LICH);//call CampaignAttacker( EASY,    1, LICH         )
			SuicideOnPlayer(5*60, U08_tealAi.user);//call SuicideOnPlayer(5*60,user)
			while (true) {//loop
				SetDefenders();//call SetDefenders()
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttacker(CommonAi.EASY, 6, CommonAi.GARGOYLE);//call CampaignAttacker( EASY,    6, GARGOYLE     )
				SuicideOnPlayer(5*60, U08_tealAi.user);//call SuicideOnPlayer(5*60,user)
				SetDefenders();//call SetDefenders()
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttacker(CommonAi.EASY, 4, CommonAi.ABOMINATION);//call CampaignAttacker( EASY,    4, ABOMINATION  )
				CampaignAttacker(CommonAi.EASY, 2, CommonAi.NECRO);//call CampaignAttacker( EASY,    2, NECRO        )
				CampaignAttacker(CommonAi.EASY, 2, CommonAi.MEAT_WAGON);//call CampaignAttacker( EASY,    2, MEAT_WAGON   )
				CampaignAttacker(CommonAi.EASY, 1, CommonAi.LICH);//call CampaignAttacker( EASY,    1, LICH         )
				SuicideOnPlayer(4*60, U08_tealAi.user);//call SuicideOnPlayer(4*60,user)
			}//endloop
		}//endfunction

	
	}
}

