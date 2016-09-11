using System;
using System.Collections.Generic;

namespace Jass {

	public class U08_blueAi {

		//
		//
		//
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(HOUSE,null);//call CampaignAI(HOUSE,null)
			do_campaign_farms = false;//set do_campaign_farms = false
			SetCaptainHome(ATTACK_CAPTAIN,2963,4429);//call SetCaptainHome(ATTACK_CAPTAIN,2963,4429)
			SetBuildUnit(1, TOWN_HALL);//call SetBuildUnit( 1, TOWN_HALL     )
			SetBuildUnit(2, PEASANT);//call SetBuildUnit( 2, PEASANT       )
			SetBuildUnit(2, BARRACKS);//call SetBuildUnit( 2, BARRACKS      )
			SetBuildUnit(1, LUMBER_MILL);//call SetBuildUnit( 1, LUMBER_MILL   )
			SetBuildUnit(1, BLACKSMITH);//call SetBuildUnit( 1, BLACKSMITH    )
			SetBuildUnit(5, PEASANT);//call SetBuildUnit( 5, PEASANT       )
			SetBuildUnit(6, HOUSE);//call SetBuildUnit( 6, HOUSE		)
			SetBuildUnit(1, WORKSHOP);//call SetBuildUnit( 1, WORKSHOP      )
			SetBuildUnit(1, KEEP);//call SetBuildUnit( 1, KEEP          )
			SetBuildUnit(1, SANCTUM);//call SetBuildUnit( 1, SANCTUM       )
			SetBuildUnit(1, HUMAN_ALTAR);//call SetBuildUnit( 1, HUMAN_ALTAR   )
			SetBuildUnit(1, CASTLE);//call SetBuildUnit( 1, CASTLE        )
			SetBuildUnit(3, AVIARY);//call SetBuildUnit( 3, AVIARY        )
			SetBuildUnit(1, WATCH_TOWER);//call SetBuildUnit( 1, WATCH_TOWER   )
			SetBuildUnit(2, CANNON_TOWER);//call SetBuildUnit( 2, CANNON_TOWER  )
			SetBuildUnit(1, GUARD_TOWER);//call SetBuildUnit( 1, GUARD_TOWER	)
			CampaignDefender(EASY, 1, FOOTMAN);//call CampaignDefender (EASY, 1, FOOTMAN     )
			CampaignDefender(EASY, 1, KNIGHT);//call CampaignDefender (EASY, 1, KNIGHT      )
			CampaignDefender(EASY, 1, RIFLEMAN);//call CampaignDefender (EASY, 1, RIFLEMAN    )
			CampaignDefender(EASY, 2, GRYPHON);//call CampaignDefender (EASY, 2, GRYPHON		)
			CampaignDefender(EASY, 1, ARCHMAGE);//call CampaignDefender (EASY, 1, ARCHMAGE    )
			SetBuildUpgrEx(0,0,1, UPG_MELEE);//call SetBuildUpgrEx( 0,0,1, UPG_MELEE	    )
			SetBuildUpgrEx(0,0,1, UPG_RANGED);//call SetBuildUpgrEx( 0,0,1, UPG_RANGED	    )
			SetBuildUpgrEx(0,0,1, UPG_SORCERY);//call SetBuildUpgrEx( 0,0,1, UPG_SORCERY	    )
			SetBuildUpgrEx(1,1,1, UPG_GUN_RANGE);//call SetBuildUpgrEx( 1,1,1, UPG_GUN_RANGE	)
			SetBuildUpgrEx(0,0,1, UPG_BREEDING);//call SetBuildUpgrEx( 0,0,1, UPG_BREEDING	)
			SetBuildUpgrEx(3,3,3, UPG_MASONRY);//call SetBuildUpgrEx( 3,3,3, UPG_MASONRY	    )
			SetBuildUpgr(1,		UPG_SENTINEL);//call SetBuildUpgr  ( 1,		UPG_SENTINEL	)
			WaitForSignal();//call WaitForSignal()
			allow_signal_abort = true;//set allow_signal_abort = true
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2,2,3, GRYPHON);//call CampaignAttackerEx(2,2,3, GRYPHON		)
			SuicideOnPlayer(M3,user);//call SuicideOnPlayer(M3,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(3,3,4, GRYPHON);//call CampaignAttackerEx(3,3,4, GRYPHON		)
			SuicideOnPlayer(M3,user);//call SuicideOnPlayer(M3,user)
			SetBuildUpgrEx(0,0,1, UPG_ARMOR);//call SetBuildUpgrEx( 0,0,1, UPG_ARMOR	    )
			SetBuildUpgrEx(0,0,1, UPG_LEATHER);//call SetBuildUpgrEx( 0,0,1, UPG_LEATHER	    )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(4,4,5, GRYPHON);//call CampaignAttackerEx(4,4,5, GRYPHON		)
			SuicideOnPlayer(M3,user);//call SuicideOnPlayer(M3,user)
			SetBuildUpgrEx(1,1,1, UPG_HAMMERS);//call SetBuildUpgrEx( 1,1,1, UPG_HAMMERS	    )
			SetBuildUpgrEx(1,1,2, UPG_MELEE);//call SetBuildUpgrEx( 1,1,2, UPG_MELEE	    )
			SetBuildUpgrEx(1,1,2, UPG_RANGED);//call SetBuildUpgrEx( 1,1,2, UPG_RANGED	    )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(4,4,5, GRYPHON);//call CampaignAttackerEx(4,4,5, GRYPHON		)
			SuicideOnPlayer(M3,kel);//call SuicideOnPlayer(M3,kel)
			SetBuildUpgrEx(1,1,2, UPG_ARMOR);//call SetBuildUpgrEx( 1,1,2, UPG_ARMOR	    )
			SetBuildUpgrEx(1,1,2, UPG_LEATHER);//call SetBuildUpgrEx( 1,1,2, UPG_LEATHER	    )
			SetBuildUpgrEx(1,1,2, UPG_SORCERY);//call SetBuildUpgrEx( 1,1,2, UPG_SORCERY	    )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(5,5,6, GRYPHON);//call CampaignAttackerEx(5,5,6, GRYPHON		)
			SuicideOnPlayer(M3,user);//call SuicideOnPlayer(M3,user)
			SetBuildUpgrEx(1,1,1, UPG_BREEDING);//call SetBuildUpgrEx( 1,1,1, UPG_BREEDING	)
			SetBuildUpgrEx(2,2,3, UPG_MELEE);//call SetBuildUpgrEx( 2,2,3, UPG_MELEE	    )
			SetBuildUpgrEx(2,2,3, UPG_RANGED);//call SetBuildUpgrEx( 2,2,3, UPG_RANGED	    )
			SetBuildUpgrEx(2,2,3, UPG_ARMOR);//call SetBuildUpgrEx( 2,2,3, UPG_ARMOR	    )
			SetBuildUpgrEx(2,2,3, UPG_LEATHER);//call SetBuildUpgrEx( 2,2,3, UPG_LEATHER	    )
			SetBuildUpgrEx(2,2,2, UPG_SORCERY);//call SetBuildUpgrEx( 2,2,2, UPG_SORCERY	    )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(3,3,4, KNIGHT);//call CampaignAttackerEx(3,3,4, KNIGHT		)
			CampaignAttackerEx(4,4,5, GRYPHON);//call CampaignAttackerEx(4,4,5, GRYPHON		)
			SuicideOnPlayer(M3,user);//call SuicideOnPlayer(M3,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(4,4,5, KNIGHT);//call CampaignAttackerEx(4,4,5, KNIGHT		)
			CampaignAttackerEx(4,4,5, GRYPHON);//call CampaignAttackerEx(4,4,5, GRYPHON		)
			SuicideOnPlayer(M3,user);//call SuicideOnPlayer(M3,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(3,3,4, KNIGHT);//call CampaignAttackerEx(3,3,4, KNIGHT		)
			CampaignAttackerEx(5,5,6, GRYPHON);//call CampaignAttackerEx(5,5,6, GRYPHON		)
			CampaignAttackerEx(1,1,2, SORCERESS);//call CampaignAttackerEx(1,1,2, SORCERESS	)
			SuicideOnPlayer(M3,user);//call SuicideOnPlayer(M3,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(3,3,4, KNIGHT);//call CampaignAttackerEx(3,3,4, KNIGHT		)
			CampaignAttackerEx(5,5,6, GRYPHON);//call CampaignAttackerEx(5,5,6, GRYPHON		)
			CampaignAttackerEx(1,1,2, SORCERESS);//call CampaignAttackerEx(1,1,2, SORCERESS	)
			CampaignAttackerEx(1,1,2, MORTAR);//call CampaignAttackerEx(1,1,2, MORTAR		)
			CampaignAttackerEx(1,1,1, ARCHMAGE);//call CampaignAttackerEx(1,1,1, ARCHMAGE		)
			SuicideOnPlayer(M3,kel);//call SuicideOnPlayer(M3,kel)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(3,3,4, KNIGHT);//call CampaignAttackerEx(3,3,4, KNIGHT		)
			CampaignAttackerEx(5,5,6, GRYPHON);//call CampaignAttackerEx(5,5,6, GRYPHON		)
			CampaignAttackerEx(1,1,2, SORCERESS);//call CampaignAttackerEx(1,1,2, SORCERESS	)
			CampaignAttackerEx(1,1,2, MORTAR);//call CampaignAttackerEx(1,1,2, MORTAR		)
			CampaignAttackerEx(1,1,1, ARCHMAGE);//call CampaignAttackerEx(1,1,1, ARCHMAGE		)
			SuicideOnPlayer(M3,kel);//call SuicideOnPlayer(M3,kel)
			SuicideUnits(RIFLEMAN, TANK, COPTER, MORTAR, FOOTMAN, KNIGHT, PRIEST, ARCHMAGE, GRYPHON, 0);//call SuicideUnits( RIFLEMAN, TANK, COPTER, MORTAR, FOOTMAN, KNIGHT, PRIEST, ARCHMAGE, GRYPHON, 0 )
		}//endfunction

	
	}
}

