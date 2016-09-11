using System;
using System.Collections.Generic;

namespace Jass {

	public class O08_JainaAi {

		//
		//
		//
		public static player purple = Player(3);//player purple	= Player(3)
		public static player green = Player(10);//player green	= Player(10)
		//
		//
		//
		private void assaults() {//function assaults takes nothing returns nothing
			int target;//local integer target
			int strength = 1;//local integer strength = 1
			while (true) {//loop
				while (true) {//loop
					if (CommandsWaiting() != 0) { break; }//exitwhen CommandsWaiting() != 0
					Sleep(5);//call Sleep(5)
				}//endloop
				if (strength == 1) {//if strength == 1 then
					CampaignAttackerEx(4, 4, 3, CommonAi.FOOTMAN);//call CampaignAttackerEx	( 4,4,3, FOOTMAN	)
					CampaignAttackerEx(2, 2, 2, CommonAi.RIFLEMAN);//call CampaignAttackerEx	( 2,2,2, RIFLEMAN	)
				} else if (strength == 2) {//elseif strength == 2 then
					CampaignAttackerEx(4, 4, 2, CommonAi.FOOTMAN);//call CampaignAttackerEx	( 4,4,2, FOOTMAN	)
					CampaignAttackerEx(4, 4, 4, CommonAi.RIFLEMAN);//call CampaignAttackerEx	( 4,4,4, RIFLEMAN	)
				} else {//else
					CampaignAttackerEx(2, 2, 4, CommonAi.FOOTMAN);//call CampaignAttackerEx	( 2,2,4, FOOTMAN	)
					CampaignAttackerEx(3, 3, 2, CommonAi.RIFLEMAN);//call CampaignAttackerEx	( 3,3,2, RIFLEMAN	)
					CampaignAttackerEx(1, 1, 1, CommonAi.KNIGHT);//call CampaignAttackerEx	( 1,1,1, KNIGHT		)
					CampaignAttackerEx(1, 1, 0, CommonAi.SORCERESS);//call CampaignAttackerEx	( 1,1,0, SORCERESS	)
				}//endif
				strength = strength + 1;//set strength = strength + 1
				target = GetLastCommand();//set target = GetLastCommand()
				PopLastCommand();//call PopLastCommand()
				SuicideOnPlayer(CommonAi.M3, Player(target));//call SuicideOnPlayer(M3,Player(target))
			}//endloop
		}//endfunction
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(CommonAi.HOUSE, null);//call CampaignAI(HOUSE,null)
			//
			//
			//
			//
			//
			//
			//
			SetSlowChopping(false);//call SetSlowChopping(false)
			campaign_wood_peons = 7;//set campaign_wood_peons = 7
			//
			//
			SetBuildUnit(1, CommonAi.PEASANT);//call SetBuildUnit( 1, PEASANT       )
			SetBuildUnit(1, CommonAi.TOWN_HALL);//call SetBuildUnit( 1, TOWN_HALL     )
			SetBuildUnit(2, CommonAi.PEASANT);//call SetBuildUnit( 2, PEASANT       )
			SetBuildUnit(1, CommonAi.BARRACKS);//call SetBuildUnit( 1, BARRACKS      )
			SetBuildUnit(1, CommonAi.BLACKSMITH);//call SetBuildUnit( 1, BLACKSMITH    )
			SetBuildUnit(1, CommonAi.KEEP);//call SetBuildUnit( 1, KEEP          )
			SetBuildUnit(1, CommonAi.HUMAN_ALTAR);//call SetBuildUnit( 1, HUMAN_ALTAR   )
			SetBuildUnit(1, CommonAi.SANCTUM);//call SetBuildUnit( 1, SANCTUM       )
			SetBuildUnit(1, CommonAi.CASTLE);//call SetBuildUnit( 1, CASTLE        )
			SetBuildUnit(12, CommonAi.PEASANT);//call SetBuildUnit( 12, PEASANT		)
			CampaignDefenderEx(1, 1, 1, CommonAi.FOOTMAN);//call CampaignDefenderEx( 1,1,1, FOOTMAN     )
			CampaignDefenderEx(1, 1, 1, CommonAi.SORCERESS);//call CampaignDefenderEx( 1,1,1, SORCERESS	)
			CampaignDefenderEx(1, 1, 0, CommonAi.KNIGHT);//call CampaignDefenderEx( 1,1,0, KNIGHT		)
			CampaignDefenderEx(1, 1, 0, CommonAi.RIFLEMAN);//call CampaignDefenderEx( 1,1,0, RIFLEMAN	)
			CampaignDefenderEx(1, 1, 1, CommonAi.JAINA);//call CampaignDefenderEx( 1,1,1, JAINA		)
			SetBuildUpgrEx(2, 2, 1, CommonAi.UPG_MELEE);//call SetBuildUpgrEx( 2,2,1, UPG_MELEE		)
			SetBuildUpgrEx(2, 2, 1, CommonAi.UPG_RANGED);//call SetBuildUpgrEx( 2,2,1, UPG_RANGED		)
			SetBuildUpgrEx(2, 2, 1, CommonAi.UPG_ARMOR);//call SetBuildUpgrEx( 2,2,1, UPG_ARMOR		)
			SetBuildUpgrEx(2, 2, 1, CommonAi.UPG_LEATHER);//call SetBuildUpgrEx( 2,2,1, UPG_LEATHER		)
			SetBuildUpgrEx(2, 2, 1, CommonAi.UPG_MASONRY);//call SetBuildUpgrEx( 2,2,1, UPG_MASONRY		)
			SetBuildUpgrEx(1, 1, 0, CommonAi.UPG_DEFEND);//call SetBuildUpgrEx( 1,1,0, UPG_DEFEND		)
			SetBuildUpgrEx(1, 1, 0, CommonAi.UPG_BREEDING);//call SetBuildUpgrEx( 1,1,0, UPG_BREEDING	)
			SetBuildUpgrEx(2, 2, 1, CommonAi.UPG_PRAYING);//call SetBuildUpgrEx( 2,2,1, UPG_PRAYING		)
			SetBuildUpgrEx(2, 2, 1, CommonAi.UPG_SORCERY);//call SetBuildUpgrEx( 2,2,1, UPG_SORCERY		)
			SetBuildUpgrEx(1, 1, 1, CommonAi.UPG_GUN_RANGE);//call SetBuildUpgrEx( 1,1,1, UPG_GUN_RANGE	)
			SetBuildUpgrEx(1, 1, 0, CommonAi.UPG_BOMBS);//call SetBuildUpgrEx( 1,1,0, UPG_BOMBS		)
			SetBuildUpgrEx(1, 1, 0, CommonAi.UPG_HAMMERS);//call SetBuildUpgrEx( 1,1,0, UPG_HAMMERS		)
			assaults();//call assaults()
		}//endfunction

	
	}
}

