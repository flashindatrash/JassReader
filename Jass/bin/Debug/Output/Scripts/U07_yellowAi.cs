using System;
using System.Collections.Generic;

namespace Jass {

	public class U07_yellowAi {

		//
		//
		//
		public static player user = Player(6);//player user = Player(6)
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(HOUSE,null);//call CampaignAI(HOUSE,null)
			SetReplacements(2,2,4);//call SetReplacements(2,2,4)
			do_campaign_farms = false;//set do_campaign_farms = false
			SetCaptainHome(ATTACK_CAPTAIN,2531,744);//call SetCaptainHome(ATTACK_CAPTAIN,2531,744)
			SetBuildUnitEx(0,0,1, TOWN_HALL);//call SetBuildUnitEx( 0,0,1, TOWN_HALL		)
			SetBuildUnitEx(3,3,3, PEASANT);//call SetBuildUnitEx( 3,3,3, PEASANT			)
			SetBuildUnitEx(0,0,2, BARRACKS);//call SetBuildUnitEx( 0,0,2, BARRACKS		)
			SetBuildUnitEx(0,0,1, LUMBER_MILL);//call SetBuildUnitEx( 0,0,1, LUMBER_MILL		)
			SetBuildUnitEx(0,0,1, HUMAN_ALTAR);//call SetBuildUnitEx( 0,0,1, HUMAN_ALTAR		)
			SetBuildUnitEx(3,3,3, PEASANT);//call SetBuildUnitEx( 3,3,3, PEASANT			)
			SetBuildUnitEx(0,0,1, BLACKSMITH);//call SetBuildUnitEx( 0,0,1, BLACKSMITH		)
			SetBuildUnitEx(7,7,7, PEASANT);//call SetBuildUnitEx( 7,7,7, PEASANT			)
			SetBuildUnitEx(0,0,1, KEEP);//call SetBuildUnitEx( 0,0,1, KEEP			)
			SetBuildUnitEx(0,0,1, WORKSHOP);//call SetBuildUnitEx( 0,0,1, WORKSHOP		)
			SetBuildUnitEx(0,0,1, SANCTUM);//call SetBuildUnitEx( 0,0,1, SANCTUM			)
			SetBuildUnitEx(0,0,1, CASTLE);//call SetBuildUnitEx( 0,0,1, CASTLE			)
			CampaignDefenderEx(1,1,1, KNIGHT);//call CampaignDefenderEx( 1,1,1, KNIGHT		)
			CampaignDefenderEx(1,1,1, SORCERESS);//call CampaignDefenderEx( 1,1,1, SORCERESS	)
			CampaignDefenderEx(0,0,1, RIFLEMAN);//call CampaignDefenderEx( 0,0,1, RIFLEMAN    )
			CampaignDefenderEx(0,0,1, ARCHMAGE);//call CampaignDefenderEx( 0,0,1, ARCHMAGE	)
			WaitForSignal();//call WaitForSignal()
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(3,3,4, KNIGHT);//call CampaignAttackerEx( 3,3,4, KNIGHT      )
			CampaignAttackerEx(1,1,2, SORCERESS);//call CampaignAttackerEx( 1,1,2, SORCERESS	)
			CampaignAttackerEx(1,1,4, RIFLEMAN);//call CampaignAttackerEx( 1,1,4, RIFLEMAN    )
			SuicideOnPlayerEx(M4,M4,M2,user);//call SuicideOnPlayerEx(M4,M4,M2,user)
			SetBuildUpgrEx(1,1,1, UPG_MELEE);//call SetBuildUpgrEx( 1,1,1, UPG_MELEE		)
			SetBuildUpgrEx(1,1,1, UPG_RANGED);//call SetBuildUpgrEx( 1,1,1, UPG_RANGED		)
			SetBuildUpgrEx(0,0,1, UPG_PRAYING);//call SetBuildUpgrEx( 0,0,1, UPG_PRAYING		)
			SetBuildUpgrEx(0,0,1, UPG_SORCERY);//call SetBuildUpgrEx( 0,0,1, UPG_SORCERY		)
			SetBuildUpgrEx(0,0,1, UPG_MASONRY);//call SetBuildUpgrEx( 0,0,1, UPG_MASONRY		)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(1,1,4, KNIGHT);//call CampaignAttackerEx( 1,1,4, KNIGHT      )
			CampaignAttackerEx(1,1,2, PRIEST);//call CampaignAttackerEx( 1,1,2, PRIEST      )
			CampaignAttackerEx(4,4,4, RIFLEMAN);//call CampaignAttackerEx( 4,4,4, RIFLEMAN    )
			CampaignAttackerEx(0,0,2, MORTAR);//call CampaignAttackerEx( 0,0,2, MORTAR		)
			SuicideOnPlayerEx(M9,M9,M6,user);//call SuicideOnPlayerEx(M9,M9,M6,user)
			SetBuildUpgrEx(1,1,1, UPG_GUN_RANGE);//call SetBuildUpgrEx( 1,1,1, UPG_GUN_RANGE	)
			SetBuildUpgrEx(1,1,1, UPG_LEATHER);//call SetBuildUpgrEx( 1,1,1, UPG_LEATHER		)
			SetBuildUpgrEx(1,1,1, UPG_ARMOR);//call SetBuildUpgrEx( 1,1,1, UPG_ARMOR		)
			SetBuildUpgrEx(1,1,2, UPG_PRAYING);//call SetBuildUpgrEx( 1,1,2, UPG_PRAYING		)
			SetBuildUpgrEx(0,0,1, UPG_BREEDING);//call SetBuildUpgrEx( 0,0,1, UPG_BREEDING	)
			SetBuildUpgrEx(0,0,1, UPG_SENTINEL);//call SetBuildUpgrEx( 0,0,1, UPG_SENTINEL	)
			SetBuildUpgrEx(1,1,1, UPG_BOMBS);//call SetBuildUpgrEx( 1,1,1, UPG_BOMBS		)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(4,4,6, KNIGHT);//call CampaignAttackerEx( 4,4,6, KNIGHT      )
			CampaignAttackerEx(2,2,3, SORCERESS);//call CampaignAttackerEx( 2,2,3, SORCERESS	)
			CampaignAttackerEx(0,0,2, RIFLEMAN);//call CampaignAttackerEx( 0,0,2, RIFLEMAN    )
			SuicideOnPlayerEx(M9,M9,M7,user);//call SuicideOnPlayerEx(M9,M9,M7,user)
			SetBuildUpgrEx(0,0,2, UPG_MELEE);//call SetBuildUpgrEx( 0,0,2, UPG_MELEE		)
			SetBuildUpgrEx(0,0,2, UPG_RANGED);//call SetBuildUpgrEx( 0,0,2, UPG_RANGED		)
			SetBuildUpgrEx(1,1,2, UPG_SORCERY);//call SetBuildUpgrEx( 1,1,2, UPG_SORCERY		)
			SetBuildUpgrEx(1,1,2, UPG_MASONRY);//call SetBuildUpgrEx( 1,1,2, UPG_MASONRY		)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(0,0,2, KNIGHT);//call CampaignAttackerEx( 0,0,2, KNIGHT      )
			CampaignAttackerEx(2,2,1, PRIEST);//call CampaignAttackerEx( 2,2,1, PRIEST      )
			CampaignAttackerEx(2,2,2, SORCERESS);//call CampaignAttackerEx( 2,2,2, SORCERESS	)
			CampaignAttackerEx(4,4,7, RIFLEMAN);//call CampaignAttackerEx( 4,4,7, RIFLEMAN    )
			CampaignAttackerEx(1,1,2, MORTAR);//call CampaignAttackerEx( 1,1,2, MORTAR		)
			SuicideOnPlayerEx(M9,M9,M6,user);//call SuicideOnPlayerEx(M9,M9,M6,user)
			SetBuildUpgrEx(0,0,2, UPG_LEATHER);//call SetBuildUpgrEx( 0,0,2, UPG_LEATHER		)
			SetBuildUpgrEx(0,0,2, UPG_ARMOR);//call SetBuildUpgrEx( 0,0,2, UPG_ARMOR		)
			SetBuildUpgrEx(1,1,1, UPG_BREEDING);//call SetBuildUpgrEx( 1,1,1, UPG_BREEDING	)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(4,4,6, KNIGHT);//call CampaignAttackerEx( 4,4,6, KNIGHT      )
			CampaignAttackerEx(1,1,2, PRIEST);//call CampaignAttackerEx( 1,1,2, PRIEST      )
			CampaignAttackerEx(1,1,2, SORCERESS);//call CampaignAttackerEx( 1,1,2, SORCERESS	)
			CampaignAttackerEx(0,0,2, RIFLEMAN);//call CampaignAttackerEx( 0,0,2, RIFLEMAN    )
			CampaignAttackerEx(1,1,1, MORTAR);//call CampaignAttackerEx( 1,1,1, MORTAR		)
			SuicideOnPlayerEx(M9,M9,M7,user);//call SuicideOnPlayerEx(M9,M9,M7,user)
			SetBuildUpgrEx(2,2,2, UPG_SORCERY);//call SetBuildUpgrEx( 2,2,2, UPG_SORCERY		)
			while (true) {//loop
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(1,1,4, KNIGHT);//call CampaignAttackerEx( 1,1,4, KNIGHT      )
				CampaignAttackerEx(1,1,2, PRIEST);//call CampaignAttackerEx( 1,1,2, PRIEST      )
				CampaignAttackerEx(1,1,2, SORCERESS);//call CampaignAttackerEx( 1,1,2, SORCERESS	)
				CampaignAttackerEx(4,4,6, RIFLEMAN);//call CampaignAttackerEx( 4,4,6, RIFLEMAN    )
				CampaignAttackerEx(1,1,2, MORTAR);//call CampaignAttackerEx( 1,1,2, MORTAR		)
				SuicideOnPlayerEx(M9,M9,M6,user);//call SuicideOnPlayerEx(M9,M9,M6,user)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(5,5,7, KNIGHT);//call CampaignAttackerEx( 5,5,7, KNIGHT      )
				CampaignAttackerEx(1,1,2, PRIEST);//call CampaignAttackerEx( 1,1,2, PRIEST      )
				CampaignAttackerEx(1,1,2, SORCERESS);//call CampaignAttackerEx( 1,1,2, SORCERESS	)
				CampaignAttackerEx(0,0,2, RIFLEMAN);//call CampaignAttackerEx( 0,0,2, RIFLEMAN    )
				CampaignAttackerEx(1,1,2, MORTAR);//call CampaignAttackerEx( 1,1,2, MORTAR		)
				SuicideOnPlayerEx(M9,M9,M7,user);//call SuicideOnPlayerEx(M9,M9,M7,user)
			}//endloop
		}//endfunction

	
	}
}

