using System;
using System.Collections.Generic;

namespace Jass {

	public class U08_redAi {

		//
		//
		//
		public static player user = Player(3);//player user = Player(3)
		public static player kel = Player(6);//player kel	= Player(6)
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(CommonAi.HOUSE, null);//call CampaignAI(HOUSE,null)
			do_campaign_farms = false;//set do_campaign_farms = false
			SetCaptainHome(CommonAi.ATTACK_CAPTAIN, 5366, -1746);//call SetCaptainHome(ATTACK_CAPTAIN,5366,-1746)
			SetBuildUnit(1, CommonAi.TOWN_HALL);//call SetBuildUnit( 1, TOWN_HALL     )
			SetBuildUnit(2, CommonAi.PEASANT);//call SetBuildUnit( 2, PEASANT       )
			SetBuildUnit(3, CommonAi.BARRACKS);//call SetBuildUnit( 3, BARRACKS      )
			SetBuildUnit(1, CommonAi.LUMBER_MILL);//call SetBuildUnit( 1, LUMBER_MILL   )
			SetBuildUnit(6, CommonAi.HOUSE);//call SetBuildUnit( 6, HOUSE		)
			SetBuildUnit(1, CommonAi.BLACKSMITH);//call SetBuildUnit( 1, BLACKSMITH    )
			SetBuildUnit(5, CommonAi.PEASANT);//call SetBuildUnit( 5, PEASANT       )
			SetBuildUnit(1, CommonAi.WORKSHOP);//call SetBuildUnit( 1, WORKSHOP      )
			SetBuildUnit(1, CommonAi.KEEP);//call SetBuildUnit( 1, KEEP          )
			SetBuildUnit(1, CommonAi.HUMAN_ALTAR);//call SetBuildUnit( 1, HUMAN_ALTAR   )
			SetBuildUnit(1, CommonAi.SANCTUM);//call SetBuildUnit( 1, SANCTUM       )
			SetBuildUnit(1, CommonAi.CASTLE);//call SetBuildUnit( 1, CASTLE        )
			SetBuildUnit(1, CommonAi.WATCH_TOWER);//call SetBuildUnit( 1, WATCH_TOWER   )
			SetBuildUnit(3, CommonAi.CANNON_TOWER);//call SetBuildUnit( 3, CANNON_TOWER  )
			SetBuildUnit(2, CommonAi.GUARD_TOWER);//call SetBuildUnit( 2, GUARD_TOWER	)
			CampaignDefender(CommonAi.EASY, 1, CommonAi.FOOTMAN);//call CampaignDefender (EASY, 1, FOOTMAN     )
			CampaignDefender(CommonAi.EASY, 1, CommonAi.KNIGHT);//call CampaignDefender (EASY, 1, KNIGHT      )
			CampaignDefender(CommonAi.EASY, 1, CommonAi.RIFLEMAN);//call CampaignDefender (EASY, 1, RIFLEMAN    )
			CampaignDefender(CommonAi.EASY, 1, CommonAi.PRIEST);//call CampaignDefender (EASY, 1, PRIEST	    )
			CampaignDefender(CommonAi.EASY, 1, CommonAi.SORCERESS);//call CampaignDefender (EASY, 1, SORCERESS	)
			CampaignDefender(CommonAi.EASY, 1, CommonAi.ARCHMAGE);//call CampaignDefender (EASY, 1, ARCHMAGE    )
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_MELEE);//call SetBuildUpgrEx( 0,0,1, UPG_MELEE	    )
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_RANGED);//call SetBuildUpgrEx( 0,0,1, UPG_RANGED	    )
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_SORCERY);//call SetBuildUpgrEx( 0,0,1, UPG_SORCERY	    )
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_PRAYING);//call SetBuildUpgrEx( 0,0,1, UPG_PRAYING	    )
			SetBuildUpgrEx(1, 1, 1, CommonAi.UPG_GUN_RANGE);//call SetBuildUpgrEx( 1,1,1, UPG_GUN_RANGE	)
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_BREEDING);//call SetBuildUpgrEx( 0,0,1, UPG_BREEDING	)
			SetBuildUpgrEx(3, 3, 3, CommonAi.UPG_MASONRY);//call SetBuildUpgrEx( 3,3,3, UPG_MASONRY	    )
			SetBuildUpgr(1, CommonAi.UPG_SENTINEL);//call SetBuildUpgr  ( 1,		UPG_SENTINEL	)
			WaitForSignal();//call WaitForSignal()
			allow_signal_abort = true;//set allow_signal_abort = true
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2, 2, 2, CommonAi.FOOTMAN);//call CampaignAttackerEx(2,2,2, FOOTMAN		)
			CampaignAttackerEx(1, 1, 2, CommonAi.KNIGHT);//call CampaignAttackerEx(1,1,2, KNIGHT		)
			CampaignAttackerEx(1, 1, 2, CommonAi.RIFLEMAN);//call CampaignAttackerEx(1,1,2, RIFLEMAN		)
			SuicideOnPlayer(30, U08_tealAi.kel);//call SuicideOnPlayer(30,kel)
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_ARMOR);//call SetBuildUpgrEx( 0,0,1, UPG_ARMOR	    )
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_LEATHER);//call SetBuildUpgrEx( 0,0,1, UPG_LEATHER	    )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(1, 1, 4, CommonAi.KNIGHT);//call CampaignAttackerEx(1,1,4, KNIGHT		)
			CampaignAttackerEx(2, 2, 3, CommonAi.RIFLEMAN);//call CampaignAttackerEx(2,2,3, RIFLEMAN		)
			CampaignAttackerEx(1, 1, 2, CommonAi.PRIEST);//call CampaignAttackerEx(1,1,2, PRIEST		)
			SuicideOnPlayer(CommonAi.M4, U08_tealAi.user);//call SuicideOnPlayer(M4,user)
			SetBuildUpgrEx(1, 1, 2, CommonAi.UPG_MELEE);//call SetBuildUpgrEx( 1,1,2, UPG_MELEE	    )
			SetBuildUpgrEx(1, 1, 2, CommonAi.UPG_RANGED);//call SetBuildUpgrEx( 1,1,2, UPG_RANGED	    )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(0, 0, 3, CommonAi.KNIGHT);//call CampaignAttackerEx(0,0,3, KNIGHT		)
			CampaignAttackerEx(4, 4, 0, CommonAi.FOOTMAN);//call CampaignAttackerEx(4,4,0, FOOTMAN		)
			CampaignAttackerEx(0, 0, 2, CommonAi.RIFLEMAN);//call CampaignAttackerEx(0,0,2, RIFLEMAN		)
			CampaignAttackerEx(2, 2, 2, CommonAi.SORCERESS);//call CampaignAttackerEx(2,2,2, SORCERESS	)
			CampaignAttackerEx(1, 1, 1, CommonAi.ARCHMAGE);//call CampaignAttackerEx(1,1,1, ARCHMAGE		)
			SuicideOnPlayer(CommonAi.M3, U08_tealAi.user);//call SuicideOnPlayer(M3,user)
			SetBuildUpgrEx(1, 1, 2, CommonAi.UPG_ARMOR);//call SetBuildUpgrEx( 1,1,2, UPG_ARMOR	    )
			SetBuildUpgrEx(1, 1, 2, CommonAi.UPG_LEATHER);//call SetBuildUpgrEx( 1,1,2, UPG_LEATHER	    )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(1, 1, 4, CommonAi.KNIGHT);//call CampaignAttackerEx(1,1,4, KNIGHT		)
			CampaignAttackerEx(2, 2, 3, CommonAi.RIFLEMAN);//call CampaignAttackerEx(2,2,3, RIFLEMAN		)
			CampaignAttackerEx(1, 1, 2, CommonAi.PRIEST);//call CampaignAttackerEx(1,1,2, PRIEST		)
			CampaignAttackerEx(1, 1, 2, CommonAi.MORTAR);//call CampaignAttackerEx(1,1,2, MORTAR		)
			SuicideOnPlayer(CommonAi.M4, U08_tealAi.user);//call SuicideOnPlayer(M4,user)
			SetBuildUpgrEx(1, 1, 2, CommonAi.UPG_SORCERY);//call SetBuildUpgrEx( 1,1,2, UPG_SORCERY	    )
			SetBuildUpgrEx(1, 1, 2, CommonAi.UPG_PRAYING);//call SetBuildUpgrEx( 1,1,2, UPG_PRAYING	    )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(0, 0, 2, CommonAi.KNIGHT);//call CampaignAttackerEx(0,0,2, KNIGHT		)
			CampaignAttackerEx(5, 5, 4, CommonAi.RIFLEMAN);//call CampaignAttackerEx(5,5,4, RIFLEMAN		)
			CampaignAttackerEx(2, 2, 2, CommonAi.SORCERESS);//call CampaignAttackerEx(2,2,2, SORCERESS	)
			CampaignAttackerEx(1, 1, 1, CommonAi.ARCHMAGE);//call CampaignAttackerEx(1,1,1, ARCHMAGE		)
			SuicideOnPlayer(CommonAi.M3, U08_tealAi.user);//call SuicideOnPlayer(M3,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2, 2, 4, CommonAi.KNIGHT);//call CampaignAttackerEx(2,2,4, KNIGHT		)
			CampaignAttackerEx(3, 3, 4, CommonAi.FOOTMAN);//call CampaignAttackerEx(3,3,4, FOOTMAN		)
			CampaignAttackerEx(2, 2, 2, CommonAi.PRIEST);//call CampaignAttackerEx(2,2,2, PRIEST		)
			CampaignAttackerEx(1, 1, 2, CommonAi.MORTAR);//call CampaignAttackerEx(1,1,2, MORTAR		)
			SuicideOnPlayer(CommonAi.M4, U08_tealAi.user);//call SuicideOnPlayer(M4,user)
			SetBuildUpgrEx(1, 1, 1, CommonAi.UPG_BREEDING);//call SetBuildUpgrEx( 1,1,1, UPG_BREEDING	)
			SetBuildUpgrEx(2, 2, 3, CommonAi.UPG_MELEE);//call SetBuildUpgrEx( 2,2,3, UPG_MELEE	    )
			SetBuildUpgrEx(2, 2, 3, CommonAi.UPG_RANGED);//call SetBuildUpgrEx( 2,2,3, UPG_RANGED	    )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2, 2, 4, CommonAi.KNIGHT);//call CampaignAttackerEx(2,2,4, KNIGHT		)
			CampaignAttackerEx(2, 2, 4, CommonAi.RIFLEMAN);//call CampaignAttackerEx(2,2,4, RIFLEMAN		)
			CampaignAttackerEx(1, 1, 2, CommonAi.MORTAR);//call CampaignAttackerEx(1,1,2, MORTAR		)
			CampaignAttackerEx(2, 2, 2, CommonAi.SORCERESS);//call CampaignAttackerEx(2,2,2, SORCERESS	)
			CampaignAttackerEx(1, 1, 1, CommonAi.ARCHMAGE);//call CampaignAttackerEx(1,1,1, ARCHMAGE		)
			SuicideOnPlayer(CommonAi.M3, U08_tealAi.kel);//call SuicideOnPlayer(M3,kel)
			SetBuildUpgrEx(2, 2, 3, CommonAi.UPG_ARMOR);//call SetBuildUpgrEx( 2,2,3, UPG_ARMOR	    )
			SetBuildUpgrEx(2, 2, 3, CommonAi.UPG_LEATHER);//call SetBuildUpgrEx( 2,2,3, UPG_LEATHER	    )
			SetBuildUpgrEx(2, 2, 2, CommonAi.UPG_SORCERY);//call SetBuildUpgrEx( 2,2,2, UPG_SORCERY	    )
			SetBuildUpgrEx(2, 2, 2, CommonAi.UPG_PRAYING);//call SetBuildUpgrEx( 2,2,2, UPG_PRAYING	    )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(6, 6, 8, CommonAi.KNIGHT);//call CampaignAttackerEx(6,6,8, KNIGHT		)
			CampaignAttackerEx(1, 1, 2, CommonAi.MORTAR);//call CampaignAttackerEx(1,1,2, MORTAR		)
			CampaignAttackerEx(2, 2, 2, CommonAi.PRIEST);//call CampaignAttackerEx(2,2,2, PRIEST		)
			CampaignAttackerEx(0, 0, 1, CommonAi.ARCHMAGE);//call CampaignAttackerEx(0,0,1, ARCHMAGE		)
			SuicideOnPlayer(CommonAi.M4, U08_tealAi.user);//call SuicideOnPlayer(M4,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2, 2, 4, CommonAi.KNIGHT);//call CampaignAttackerEx(2,2,4, KNIGHT		)
			CampaignAttackerEx(2, 2, 4, CommonAi.RIFLEMAN);//call CampaignAttackerEx(2,2,4, RIFLEMAN		)
			CampaignAttackerEx(1, 1, 2, CommonAi.MORTAR);//call CampaignAttackerEx(1,1,2, MORTAR		)
			CampaignAttackerEx(2, 2, 2, CommonAi.SORCERESS);//call CampaignAttackerEx(2,2,2, SORCERESS	)
			CampaignAttackerEx(1, 1, 1, CommonAi.ARCHMAGE);//call CampaignAttackerEx(1,1,1, ARCHMAGE		)
			SuicideOnPlayer(CommonAi.M3, U08_tealAi.kel);//call SuicideOnPlayer(M3,kel)
			SuicideUnits(CommonAi.RIFLEMAN, CommonAi.TANK, CommonAi.COPTER, CommonAi.MORTAR, CommonAi.FOOTMAN, CommonAi.KNIGHT, CommonAi.PRIEST, CommonAi.ARCHMAGE, CommonAi.SORCERESS, 0);//call SuicideUnits( RIFLEMAN, TANK, COPTER, MORTAR, FOOTMAN, KNIGHT, PRIEST, ARCHMAGE, SORCERESS, 0 )
		}//endfunction

	
	}
}

