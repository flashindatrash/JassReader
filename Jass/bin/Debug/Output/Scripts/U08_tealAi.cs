using System;
using System.Collections.Generic;

namespace Jass {

	public class U08_tealAi {

		//
		//
		//
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(HOUSE,null);//call CampaignAI(HOUSE,null)
			do_campaign_farms = false;//set do_campaign_farms = false
			SetCaptainHome(ATTACK_CAPTAIN,-4713,1217);//call SetCaptainHome(ATTACK_CAPTAIN,-4713,1217)
			SetBuildUnit(1, TOWN_HALL);//call SetBuildUnit( 1, TOWN_HALL     )
			SetBuildUnit(2, PEASANT);//call SetBuildUnit( 2, PEASANT       )
			SetBuildUnit(2, BARRACKS);//call SetBuildUnit( 2, BARRACKS      )
			SetBuildUnit(1, LUMBER_MILL);//call SetBuildUnit( 1, LUMBER_MILL   )
			SetBuildUnit(6, HOUSE);//call SetBuildUnit( 6, HOUSE		    )
			SetBuildUnit(1, BLACKSMITH);//call SetBuildUnit( 1, BLACKSMITH    )
			SetBuildUnit(5, PEASANT);//call SetBuildUnit( 5, PEASANT       )
			SetBuildUnit(3, WORKSHOP);//call SetBuildUnit( 3, WORKSHOP      )
			SetBuildUnit(1, KEEP);//call SetBuildUnit( 1, KEEP          )
			SetBuildUnit(1, HUMAN_ALTAR);//call SetBuildUnit( 1, HUMAN_ALTAR   )
			SetBuildUnit(1, SANCTUM);//call SetBuildUnit( 1, SANCTUM       )
			SetBuildUnit(1, CASTLE);//call SetBuildUnit( 1, CASTLE        )
			SetBuildUnit(1, WATCH_TOWER);//call SetBuildUnit( 1, WATCH_TOWER   )
			SetBuildUnit(3, CANNON_TOWER);//call SetBuildUnit( 3, CANNON_TOWER	)
			CampaignDefender(EASY, 1, FOOTMAN);//call CampaignDefender (EASY, 1, FOOTMAN     )
			CampaignDefender(EASY, 1, KNIGHT);//call CampaignDefender (EASY, 1, KNIGHT      )
			CampaignDefender(EASY, 1, RIFLEMAN);//call CampaignDefender (EASY, 1, RIFLEMAN    )
			CampaignDefender(EASY, 1, PRIEST);//call CampaignDefender (EASY, 1, PRIEST	    )
			CampaignDefender(EASY, 1, COPTER);//call CampaignDefender (EASY, 1, COPTER		)
			CampaignDefender(EASY, 1, ARCHMAGE);//call CampaignDefender (EASY, 1, ARCHMAGE    )
			SetBuildUpgrEx(0,0,1, UPG_MELEE);//call SetBuildUpgrEx( 0,0,1, UPG_MELEE	    )
			SetBuildUpgrEx(0,0,1, UPG_RANGED);//call SetBuildUpgrEx( 0,0,1, UPG_RANGED	    )
			SetBuildUpgrEx(0,0,1, UPG_SORCERY);//call SetBuildUpgrEx( 0,0,1, UPG_SORCERY	    )
			SetBuildUpgrEx(0,0,1, UPG_PRAYING);//call SetBuildUpgrEx( 0,0,1, UPG_PRAYING	    )
			SetBuildUpgrEx(1,1,1, UPG_GUN_RANGE);//call SetBuildUpgrEx( 1,1,1, UPG_GUN_RANGE	)
			SetBuildUpgrEx(0,0,1, UPG_BREEDING);//call SetBuildUpgrEx( 0,0,1, UPG_BREEDING	)
			SetBuildUpgrEx(3,3,3, UPG_MASONRY);//call SetBuildUpgrEx( 3,3,3, UPG_MASONRY	    )
			SetBuildUpgrEx(1,1,1, UPG_BOMBS);//call SetBuildUpgrEx( 1,1,1, UPG_BOMBS	    )
			SetBuildUpgr(1,		UPG_SENTINEL);//call SetBuildUpgr  ( 1,		UPG_SENTINEL	)
			WaitForSignal();//call WaitForSignal()
			allow_signal_abort = true;//set allow_signal_abort = true
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(4,4,3, RIFLEMAN);//call CampaignAttackerEx(4,4,3, RIFLEMAN		)
			CampaignAttackerEx(0,0,1, TANK);//call CampaignAttackerEx(0,0,1, TANK			)
			SuicideOnPlayer(M2,user);//call SuicideOnPlayer(M2,user)
			SetBuildUpgrEx(0,0,1, UPG_ARMOR);//call SetBuildUpgrEx( 0,0,1, UPG_ARMOR	    )
			SetBuildUpgrEx(0,0,1, UPG_LEATHER);//call SetBuildUpgrEx( 0,0,1, UPG_LEATHER	    )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(4,4,6, COPTER);//call CampaignAttackerEx(4,4,6, COPTER		)
			SuicideOnPlayer(M4,user);//call SuicideOnPlayer(M4,user)
			SetBuildUpgrEx(1,1,2, UPG_MELEE);//call SetBuildUpgrEx( 1,1,2, UPG_MELEE	    )
			SetBuildUpgrEx(1,1,2, UPG_RANGED);//call SetBuildUpgrEx( 1,1,2, UPG_RANGED	    )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(1,1,2, TANK);//call CampaignAttackerEx(1,1,2, TANK			)
			CampaignAttackerEx(2,2,4, RIFLEMAN);//call CampaignAttackerEx(2,2,4, RIFLEMAN		)
			SuicideOnPlayer(M3,user);//call SuicideOnPlayer(M3,user)
			SetBuildUpgrEx(1,1,2, UPG_ARMOR);//call SetBuildUpgrEx( 1,1,2, UPG_ARMOR	    )
			SetBuildUpgrEx(1,1,2, UPG_LEATHER);//call SetBuildUpgrEx( 1,1,2, UPG_LEATHER	    )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(4,4,6, COPTER);//call CampaignAttackerEx(4,4,6, COPTER		)
			CampaignAttackerEx(4,4,6, RIFLEMAN);//call CampaignAttackerEx(4,4,6, RIFLEMAN		)
			SuicideOnPlayer(M4,user);//call SuicideOnPlayer(M4,user)
			SetBuildUpgrEx(1,1,2, UPG_SORCERY);//call SetBuildUpgrEx( 1,1,2, UPG_SORCERY	    )
			SetBuildUpgrEx(1,1,2, UPG_PRAYING);//call SetBuildUpgrEx( 1,1,2, UPG_PRAYING	    )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2,2,3, TANK);//call CampaignAttackerEx(2,2,3, TANK			)
			CampaignAttackerEx(3,3,4, RIFLEMAN);//call CampaignAttackerEx(3,3,4, RIFLEMAN		)
			SuicideOnPlayer(M3,user);//call SuicideOnPlayer(M3,user)
			SetBuildUpgrEx(1,1,1, UPG_BREEDING);//call SetBuildUpgrEx( 1,1,1, UPG_BREEDING	)
			SetBuildUpgrEx(2,2,3, UPG_MELEE);//call SetBuildUpgrEx( 2,2,3, UPG_MELEE	    )
			SetBuildUpgrEx(2,2,3, UPG_RANGED);//call SetBuildUpgrEx( 2,2,3, UPG_RANGED	    )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(5,5,6, COPTER);//call CampaignAttackerEx(5,5,6, COPTER		)
			CampaignAttackerEx(2,2,6, RIFLEMAN);//call CampaignAttackerEx(2,2,6, RIFLEMAN		)
			SuicideOnPlayer(M4,user);//call SuicideOnPlayer(M4,user)
			SetBuildUpgrEx(2,2,3, UPG_ARMOR);//call SetBuildUpgrEx( 2,2,3, UPG_ARMOR	    )
			SetBuildUpgrEx(2,2,3, UPG_LEATHER);//call SetBuildUpgrEx( 2,2,3, UPG_LEATHER	    )
			SetBuildUpgrEx(2,2,2, UPG_SORCERY);//call SetBuildUpgrEx( 2,2,2, UPG_SORCERY	    )
			SetBuildUpgrEx(2,2,2, UPG_PRAYING);//call SetBuildUpgrEx( 2,2,2, UPG_PRAYING	    )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(3,3,3, TANK);//call CampaignAttackerEx(3,3,3, TANK			)
			CampaignAttackerEx(2,2,4, RIFLEMAN);//call CampaignAttackerEx(2,2,4, RIFLEMAN		)
			CampaignAttackerEx(1,1,3, MORTAR);//call CampaignAttackerEx(1,1,3, MORTAR		)
			SuicideOnPlayer(M3,user);//call SuicideOnPlayer(M3,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(3,3,4, TANK);//call CampaignAttackerEx(3,3,4, TANK			)
			CampaignAttackerEx(2,2,4, RIFLEMAN);//call CampaignAttackerEx(2,2,4, RIFLEMAN		)
			CampaignAttackerEx(1,1,3, MORTAR);//call CampaignAttackerEx(1,1,3, MORTAR		)
			SuicideOnPlayer(M4,user);//call SuicideOnPlayer(M4,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(4,4,5, TANK);//call CampaignAttackerEx(4,4,5, TANK			)
			CampaignAttackerEx(6,6,8, RIFLEMAN);//call CampaignAttackerEx(6,6,8, RIFLEMAN		)
			CampaignAttackerEx(3,3,5, MORTAR);//call CampaignAttackerEx(3,3,5, MORTAR		)
			SuicideOnPlayer(M3,user);//call SuicideOnPlayer(M3,user)
			SuicideUnits(RIFLEMAN, TANK, COPTER, MORTAR, FOOTMAN, KNIGHT, PRIEST, ARCHMAGE, GRYPHON, 0);//call SuicideUnits( RIFLEMAN, TANK, COPTER, MORTAR, FOOTMAN, KNIGHT, PRIEST, ARCHMAGE, GRYPHON, 0 )
		}//endfunction

	
	}
}

