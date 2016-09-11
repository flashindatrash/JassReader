using System;
using System.Collections.Generic;

namespace Jass {

	public class U07_orangeAi {

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
			SetBuildUnitEx(0,0,1, TOWN_HALL);//call SetBuildUnitEx( 0,0,1, TOWN_HALL		)
			SetBuildUnitEx(3,3,3, PEASANT);//call SetBuildUnitEx( 3,3,3, PEASANT			)
			SetBuildUnitEx(0,0,2, BARRACKS);//call SetBuildUnitEx( 0,0,2, BARRACKS		)
			SetBuildUnitEx(0,0,1, LUMBER_MILL);//call SetBuildUnitEx( 0,0,1, LUMBER_MILL		)
			SetBuildUnitEx(0,0,1, HUMAN_ALTAR);//call SetBuildUnitEx( 0,0,1, HUMAN_ALTAR		)
			SetBuildUnitEx(3,3,3, PEASANT);//call SetBuildUnitEx( 3,3,3, PEASANT			)
			SetBuildUnitEx(0,0,1, BLACKSMITH);//call SetBuildUnitEx( 0,0,1, BLACKSMITH		)
			SetBuildUnitEx(4,4,4, PEASANT);//call SetBuildUnitEx( 4,4,4, PEASANT			)
			SetBuildUnitEx(0,0,1, KEEP);//call SetBuildUnitEx( 0,0,1, KEEP			)
			SetBuildUnitEx(0,0,1, WORKSHOP);//call SetBuildUnitEx( 0,0,1, WORKSHOP		)
			SetBuildUnitEx(0,0,1, SANCTUM);//call SetBuildUnitEx( 0,0,1, SANCTUM			)
			SetBuildUnitEx(0,0,1, CASTLE);//call SetBuildUnitEx( 0,0,1, CASTLE			)
			SetBuildUnitEx(0,0,3, AVIARY);//call SetBuildUnitEx( 0,0,3, AVIARY			)
			CampaignDefenderEx(1,1,2, GRYPHON);//call CampaignDefenderEx( 1,1,2, GRYPHON		)
			CampaignDefenderEx(1,1,1, PRIEST);//call CampaignDefenderEx( 1,1,1, PRIEST		)
			SetBuildUpgrEx(1,1,1, UPG_MELEE);//call SetBuildUpgrEx( 1,1,1, UPG_MELEE		)
			SetBuildUpgrEx(1,1,1, UPG_RANGED);//call SetBuildUpgrEx( 1,1,1, UPG_RANGED		)
			SetBuildUpgrEx(0,0,1, UPG_PRAYING);//call SetBuildUpgrEx( 0,0,1, UPG_PRAYING		)
			SetBuildUpgrEx(0,0,1, UPG_SORCERY);//call SetBuildUpgrEx( 0,0,1, UPG_SORCERY		)
			SetBuildUpgrEx(0,0,1, UPG_MASONRY);//call SetBuildUpgrEx( 0,0,1, UPG_MASONRY		)
			WaitForSignal();//call WaitForSignal()
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(3,3,6, GRYPHON);//call CampaignAttackerEx( 3,3,6, GRYPHON     )
			SuicideOnPlayerEx(M5,M5,0,user);//call SuicideOnPlayerEx(M5,M5,0,user)
			SetBuildUpgrEx(1,1,1, UPG_LEATHER);//call SetBuildUpgrEx( 1,1,1, UPG_LEATHER		)
			SetBuildUpgrEx(1,1,1, UPG_ARMOR);//call SetBuildUpgrEx( 1,1,1, UPG_ARMOR		)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(1,1,4, KNIGHT);//call CampaignAttackerEx( 1,1,4, KNIGHT      )
			CampaignAttackerEx(3,3,4, GRYPHON);//call CampaignAttackerEx( 3,3,4, GRYPHON     )
			CampaignAttackerEx(0,0,2, MORTAR);//call CampaignAttackerEx( 0,0,2, MORTAR		)
			SuicideOnPlayerEx(M10,M10,M7,user);//call SuicideOnPlayerEx(M10,M10,M7,user)
			SetBuildUpgrEx(1,1,1, UPG_HAMMERS);//call SetBuildUpgrEx( 1,1,1, UPG_HAMMERS		)
			SetBuildUpgrEx(1,1,2, UPG_PRAYING);//call SetBuildUpgrEx( 1,1,2, UPG_PRAYING		)
			SetBuildUpgrEx(0,0,1, UPG_BREEDING);//call SetBuildUpgrEx( 0,0,1, UPG_BREEDING	)
			SetBuildUpgrEx(0,0,1, UPG_SENTINEL);//call SetBuildUpgrEx( 0,0,1, UPG_SENTINEL	)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(0,0,2, KNIGHT);//call CampaignAttackerEx( 0,0,2, KNIGHT      )
			CampaignAttackerEx(2,2,3, SORCERESS);//call CampaignAttackerEx( 2,2,3, SORCERESS	)
			CampaignAttackerEx(4,4,6, GRYPHON);//call CampaignAttackerEx( 4,4,6, GRYPHON	    )
			SuicideOnPlayerEx(M10,M10,M8,user);//call SuicideOnPlayerEx(M10,M10,M8,user)
			SetBuildUpgrEx(0,0,2, UPG_MELEE);//call SetBuildUpgrEx( 0,0,2, UPG_MELEE		)
			SetBuildUpgrEx(0,0,2, UPG_RANGED);//call SetBuildUpgrEx( 0,0,2, UPG_RANGED		)
			SetBuildUpgrEx(1,1,2, UPG_SORCERY);//call SetBuildUpgrEx( 1,1,2, UPG_SORCERY		)
			SetBuildUpgrEx(1,1,2, UPG_MASONRY);//call SetBuildUpgrEx( 1,1,2, UPG_MASONRY		)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2,2,3, KNIGHT);//call CampaignAttackerEx( 2,2,3, KNIGHT      )
			CampaignAttackerEx(1,1,2, PRIEST);//call CampaignAttackerEx( 1,1,2, PRIEST      )
			CampaignAttackerEx(1,1,1, SORCERESS);//call CampaignAttackerEx( 1,1,1, SORCERESS	)
			CampaignAttackerEx(2,2,5, GRYPHON);//call CampaignAttackerEx( 2,2,5, GRYPHON	    )
			CampaignAttackerEx(0,0,2, MORTAR);//call CampaignAttackerEx( 0,0,2, MORTAR		)
			SuicideOnPlayerEx(M10,M10,M7,user);//call SuicideOnPlayerEx(M10,M10,M7,user)
			SetBuildUpgrEx(0,0,2, UPG_LEATHER);//call SetBuildUpgrEx( 0,0,2, UPG_LEATHER		)
			SetBuildUpgrEx(0,0,2, UPG_ARMOR);//call SetBuildUpgrEx( 0,0,2, UPG_ARMOR		)
			SetBuildUpgrEx(1,1,1, UPG_BREEDING);//call SetBuildUpgrEx( 1,1,1, UPG_BREEDING	)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(1,1,3, KNIGHT);//call CampaignAttackerEx( 1,1,3, KNIGHT      )
			CampaignAttackerEx(0,0,1, PRIEST);//call CampaignAttackerEx( 0,0,1, PRIEST      )
			CampaignAttackerEx(2,2,2, SORCERESS);//call CampaignAttackerEx( 2,2,2, SORCERESS	)
			CampaignAttackerEx(5,5,7, GRYPHON);//call CampaignAttackerEx( 5,5,7, GRYPHON	    )
			CampaignAttackerEx(0,0,1, MORTAR);//call CampaignAttackerEx( 0,0,1, MORTAR		)
			SuicideOnPlayerEx(M10,M10,M8,user);//call SuicideOnPlayerEx(M10,M10,M8,user)
			SetBuildUpgrEx(2,2,2, UPG_SORCERY);//call SetBuildUpgrEx( 2,2,2, UPG_SORCERY		)
			SetBuildUpgrEx(1,1,1, UPG_HAMMERS);//call SetBuildUpgrEx( 1,1,1, UPG_HAMMERS		)
			while (true) {//loop
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(3,3,6, KNIGHT);//call CampaignAttackerEx( 3,3,6, KNIGHT      )
				CampaignAttackerEx(1,1,2, PRIEST);//call CampaignAttackerEx( 1,1,2, PRIEST      )
				CampaignAttackerEx(1,1,2, SORCERESS);//call CampaignAttackerEx( 1,1,2, SORCERESS	)
				CampaignAttackerEx(2,2,3, GRYPHON);//call CampaignAttackerEx( 2,2,3, GRYPHON	    )
				CampaignAttackerEx(0,0,2, MORTAR);//call CampaignAttackerEx( 0,0,2, MORTAR		)
				SuicideOnPlayerEx(M10,M10,M7,user);//call SuicideOnPlayerEx(M10,M10,M7,user)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(1,1,2, KNIGHT);//call CampaignAttackerEx( 1,1,2, KNIGHT      )
				CampaignAttackerEx(1,1,2, PRIEST);//call CampaignAttackerEx( 1,1,2, PRIEST      )
				CampaignAttackerEx(1,1,2, SORCERESS);//call CampaignAttackerEx( 1,1,2, SORCERESS	)
				CampaignAttackerEx(6,6,8, GRYPHON);//call CampaignAttackerEx( 6,6,8, GRYPHON	    )
				CampaignAttackerEx(0,0,2, MORTAR);//call CampaignAttackerEx( 0,0,2, MORTAR		)
				SuicideOnPlayerEx(M10,M10,M8,user);//call SuicideOnPlayerEx(M10,M10,M8,user)
			}//endloop
		}//endfunction

	
	}
}

