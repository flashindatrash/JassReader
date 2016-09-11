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
			CampaignAI(HOUSE,null);//call CampaignAI(HOUSE,null)
			do_campaign_farms = false;//set do_campaign_farms = false
			SetCaptainHome(ATTACK_CAPTAIN,5366,-1746);//call SetCaptainHome(ATTACK_CAPTAIN,5366,-1746)
			SetBuildUnit(1, TOWN_HALL);//call SetBuildUnit( 1, TOWN_HALL     )
			SetBuildUnit(2, PEASANT);//call SetBuildUnit( 2, PEASANT       )
			SetBuildUnit(3, BARRACKS);//call SetBuildUnit( 3, BARRACKS      )
			SetBuildUnit(1, LUMBER_MILL);//call SetBuildUnit( 1, LUMBER_MILL   )
			SetBuildUnit(6, HOUSE);//call SetBuildUnit( 6, HOUSE		)
			SetBuildUnit(1, BLACKSMITH);//call SetBuildUnit( 1, BLACKSMITH    )
			SetBuildUnit(5, PEASANT);//call SetBuildUnit( 5, PEASANT       )
			SetBuildUnit(1, WORKSHOP);//call SetBuildUnit( 1, WORKSHOP      )
			SetBuildUnit(1, KEEP);//call SetBuildUnit( 1, KEEP          )
			SetBuildUnit(1, HUMAN_ALTAR);//call SetBuildUnit( 1, HUMAN_ALTAR   )
			SetBuildUnit(1, SANCTUM);//call SetBuildUnit( 1, SANCTUM       )
			SetBuildUnit(1, CASTLE);//call SetBuildUnit( 1, CASTLE        )
			SetBuildUnit(1, WATCH_TOWER);//call SetBuildUnit( 1, WATCH_TOWER   )
			SetBuildUnit(3, CANNON_TOWER);//call SetBuildUnit( 3, CANNON_TOWER  )
			SetBuildUnit(2, GUARD_TOWER);//call SetBuildUnit( 2, GUARD_TOWER	)
			CampaignDefender(EASY, 1, FOOTMAN);//call CampaignDefender (EASY, 1, FOOTMAN     )
			CampaignDefender(EASY, 1, KNIGHT);//call CampaignDefender (EASY, 1, KNIGHT      )
			CampaignDefender(EASY, 1, RIFLEMAN);//call CampaignDefender (EASY, 1, RIFLEMAN    )
			CampaignDefender(EASY, 1, PRIEST);//call CampaignDefender (EASY, 1, PRIEST	    )
			CampaignDefender(EASY, 1, SORCERESS);//call CampaignDefender (EASY, 1, SORCERESS	)
			CampaignDefender(EASY, 1, ARCHMAGE);//call CampaignDefender (EASY, 1, ARCHMAGE    )
			SetBuildUpgrEx(0,0,1, UPG_MELEE);//call SetBuildUpgrEx( 0,0,1, UPG_MELEE	    )
			SetBuildUpgrEx(0,0,1, UPG_RANGED);//call SetBuildUpgrEx( 0,0,1, UPG_RANGED	    )
			SetBuildUpgrEx(0,0,1, UPG_SORCERY);//call SetBuildUpgrEx( 0,0,1, UPG_SORCERY	    )
			SetBuildUpgrEx(0,0,1, UPG_PRAYING);//call SetBuildUpgrEx( 0,0,1, UPG_PRAYING	    )
			SetBuildUpgrEx(1,1,1, UPG_GUN_RANGE);//call SetBuildUpgrEx( 1,1,1, UPG_GUN_RANGE	)
			SetBuildUpgrEx(0,0,1, UPG_BREEDING);//call SetBuildUpgrEx( 0,0,1, UPG_BREEDING	)
			SetBuildUpgrEx(3,3,3, UPG_MASONRY);//call SetBuildUpgrEx( 3,3,3, UPG_MASONRY	    )
			SetBuildUpgr(1,		UPG_SENTINEL);//call SetBuildUpgr  ( 1,		UPG_SENTINEL	)
			WaitForSignal();//call WaitForSignal()
			allow_signal_abort = true;//set allow_signal_abort = true
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2,2,2, FOOTMAN);//call CampaignAttackerEx(2,2,2, FOOTMAN		)
			CampaignAttackerEx(1,1,2, KNIGHT);//call CampaignAttackerEx(1,1,2, KNIGHT		)
			CampaignAttackerEx(1,1,2, RIFLEMAN);//call CampaignAttackerEx(1,1,2, RIFLEMAN		)
			SuicideOnPlayer(30,kel);//call SuicideOnPlayer(30,kel)
			SetBuildUpgrEx(0,0,1, UPG_ARMOR);//call SetBuildUpgrEx( 0,0,1, UPG_ARMOR	    )
			SetBuildUpgrEx(0,0,1, UPG_LEATHER);//call SetBuildUpgrEx( 0,0,1, UPG_LEATHER	    )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(1,1,4, KNIGHT);//call CampaignAttackerEx(1,1,4, KNIGHT		)
			CampaignAttackerEx(2,2,3, RIFLEMAN);//call CampaignAttackerEx(2,2,3, RIFLEMAN		)
			CampaignAttackerEx(1,1,2, PRIEST);//call CampaignAttackerEx(1,1,2, PRIEST		)
			SuicideOnPlayer(M4,user);//call SuicideOnPlayer(M4,user)
			SetBuildUpgrEx(1,1,2, UPG_MELEE);//call SetBuildUpgrEx( 1,1,2, UPG_MELEE	    )
			SetBuildUpgrEx(1,1,2, UPG_RANGED);//call SetBuildUpgrEx( 1,1,2, UPG_RANGED	    )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(0,0,3, KNIGHT);//call CampaignAttackerEx(0,0,3, KNIGHT		)
			CampaignAttackerEx(4,4,0, FOOTMAN);//call CampaignAttackerEx(4,4,0, FOOTMAN		)
			CampaignAttackerEx(0,0,2, RIFLEMAN);//call CampaignAttackerEx(0,0,2, RIFLEMAN		)
			CampaignAttackerEx(2,2,2, SORCERESS);//call CampaignAttackerEx(2,2,2, SORCERESS	)
			CampaignAttackerEx(1,1,1, ARCHMAGE);//call CampaignAttackerEx(1,1,1, ARCHMAGE		)
			SuicideOnPlayer(M3,user);//call SuicideOnPlayer(M3,user)
			SetBuildUpgrEx(1,1,2, UPG_ARMOR);//call SetBuildUpgrEx( 1,1,2, UPG_ARMOR	    )
			SetBuildUpgrEx(1,1,2, UPG_LEATHER);//call SetBuildUpgrEx( 1,1,2, UPG_LEATHER	    )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(1,1,4, KNIGHT);//call CampaignAttackerEx(1,1,4, KNIGHT		)
			CampaignAttackerEx(2,2,3, RIFLEMAN);//call CampaignAttackerEx(2,2,3, RIFLEMAN		)
			CampaignAttackerEx(1,1,2, PRIEST);//call CampaignAttackerEx(1,1,2, PRIEST		)
			CampaignAttackerEx(1,1,2, MORTAR);//call CampaignAttackerEx(1,1,2, MORTAR		)
			SuicideOnPlayer(M4,user);//call SuicideOnPlayer(M4,user)
			SetBuildUpgrEx(1,1,2, UPG_SORCERY);//call SetBuildUpgrEx( 1,1,2, UPG_SORCERY	    )
			SetBuildUpgrEx(1,1,2, UPG_PRAYING);//call SetBuildUpgrEx( 1,1,2, UPG_PRAYING	    )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(0,0,2, KNIGHT);//call CampaignAttackerEx(0,0,2, KNIGHT		)
			CampaignAttackerEx(5,5,4, RIFLEMAN);//call CampaignAttackerEx(5,5,4, RIFLEMAN		)
			CampaignAttackerEx(2,2,2, SORCERESS);//call CampaignAttackerEx(2,2,2, SORCERESS	)
			CampaignAttackerEx(1,1,1, ARCHMAGE);//call CampaignAttackerEx(1,1,1, ARCHMAGE		)
			SuicideOnPlayer(M3,user);//call SuicideOnPlayer(M3,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2,2,4, KNIGHT);//call CampaignAttackerEx(2,2,4, KNIGHT		)
			CampaignAttackerEx(3,3,4, FOOTMAN);//call CampaignAttackerEx(3,3,4, FOOTMAN		)
			CampaignAttackerEx(2,2,2, PRIEST);//call CampaignAttackerEx(2,2,2, PRIEST		)
			CampaignAttackerEx(1,1,2, MORTAR);//call CampaignAttackerEx(1,1,2, MORTAR		)
			SuicideOnPlayer(M4,user);//call SuicideOnPlayer(M4,user)
			SetBuildUpgrEx(1,1,1, UPG_BREEDING);//call SetBuildUpgrEx( 1,1,1, UPG_BREEDING	)
			SetBuildUpgrEx(2,2,3, UPG_MELEE);//call SetBuildUpgrEx( 2,2,3, UPG_MELEE	    )
			SetBuildUpgrEx(2,2,3, UPG_RANGED);//call SetBuildUpgrEx( 2,2,3, UPG_RANGED	    )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2,2,4, KNIGHT);//call CampaignAttackerEx(2,2,4, KNIGHT		)
			CampaignAttackerEx(2,2,4, RIFLEMAN);//call CampaignAttackerEx(2,2,4, RIFLEMAN		)
			CampaignAttackerEx(1,1,2, MORTAR);//call CampaignAttackerEx(1,1,2, MORTAR		)
			CampaignAttackerEx(2,2,2, SORCERESS);//call CampaignAttackerEx(2,2,2, SORCERESS	)
			CampaignAttackerEx(1,1,1, ARCHMAGE);//call CampaignAttackerEx(1,1,1, ARCHMAGE		)
			SuicideOnPlayer(M3,kel);//call SuicideOnPlayer(M3,kel)
			SetBuildUpgrEx(2,2,3, UPG_ARMOR);//call SetBuildUpgrEx( 2,2,3, UPG_ARMOR	    )
			SetBuildUpgrEx(2,2,3, UPG_LEATHER);//call SetBuildUpgrEx( 2,2,3, UPG_LEATHER	    )
			SetBuildUpgrEx(2,2,2, UPG_SORCERY);//call SetBuildUpgrEx( 2,2,2, UPG_SORCERY	    )
			SetBuildUpgrEx(2,2,2, UPG_PRAYING);//call SetBuildUpgrEx( 2,2,2, UPG_PRAYING	    )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(6,6,8, KNIGHT);//call CampaignAttackerEx(6,6,8, KNIGHT		)
			CampaignAttackerEx(1,1,2, MORTAR);//call CampaignAttackerEx(1,1,2, MORTAR		)
			CampaignAttackerEx(2,2,2, PRIEST);//call CampaignAttackerEx(2,2,2, PRIEST		)
			CampaignAttackerEx(0,0,1, ARCHMAGE);//call CampaignAttackerEx(0,0,1, ARCHMAGE		)
			SuicideOnPlayer(M4,user);//call SuicideOnPlayer(M4,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2,2,4, KNIGHT);//call CampaignAttackerEx(2,2,4, KNIGHT		)
			CampaignAttackerEx(2,2,4, RIFLEMAN);//call CampaignAttackerEx(2,2,4, RIFLEMAN		)
			CampaignAttackerEx(1,1,2, MORTAR);//call CampaignAttackerEx(1,1,2, MORTAR		)
			CampaignAttackerEx(2,2,2, SORCERESS);//call CampaignAttackerEx(2,2,2, SORCERESS	)
			CampaignAttackerEx(1,1,1, ARCHMAGE);//call CampaignAttackerEx(1,1,1, ARCHMAGE		)
			SuicideOnPlayer(M3,kel);//call SuicideOnPlayer(M3,kel)
			SuicideUnits(RIFLEMAN, TANK, COPTER, MORTAR, FOOTMAN, KNIGHT, PRIEST, ARCHMAGE, SORCERESS, 0);//call SuicideUnits( RIFLEMAN, TANK, COPTER, MORTAR, FOOTMAN, KNIGHT, PRIEST, ARCHMAGE, SORCERESS, 0 )
		}//endfunction

	
	}
}

