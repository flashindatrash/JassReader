using System;
using System.Collections.Generic;

namespace Jass {

	public class N07x01Ai {

		//
		//
		//
		public static player targ = PlayerEx(6);//player targ = PlayerEx(6)
		private void main() {//function main takes nothing returns nothing
			CampaignAI(HOUSE,null);//call CampaignAI(HOUSE,null)
			SetPeonsRepair(true);//call SetPeonsRepair(true)
			SetDefendPlayer(true);//call SetDefendPlayer(true)
			SetReplacements(6,6,3);//call SetReplacements(6,6,3)
			SetBuildUnitEx(1,1,1, BLOOD_PEASANT);//call SetBuildUnitEx( 1,1,1, BLOOD_PEASANT   )
			SetBuildUnitEx(1,1,1, TOWN_HALL);//call SetBuildUnitEx( 1,1,1, TOWN_HALL       )
			SetBuildUnitEx(1,1,1, HUMAN_ALTAR);//call SetBuildUnitEx( 1,1,1, HUMAN_ALTAR     )
			SetBuildUnitEx(4,4,4, WATCH_TOWER);//call SetBuildUnitEx( 4,4,4, WATCH_TOWER     )
			SetBuildUnitEx(1,1,1, LUMBER_MILL);//call SetBuildUnitEx( 1,1,1, LUMBER_MILL     )
			SetBuildUnitEx(4,4,4, GUARD_TOWER);//call SetBuildUnitEx( 4,4,4, GUARD_TOWER     )
			SetBuildUnitEx(1,1,0, ARCANE_VAULT);//call SetBuildUnitEx( 1,1,0, ARCANE_VAULT    )
			SetBuildUnitEx(1,1,0, BLACKSMITH);//call SetBuildUnitEx( 1,1,0, BLACKSMITH      )
			SetBuildUnitEx(1,1,0, KEEP);//call SetBuildUnitEx( 1,1,0, KEEP            )
			SetBuildUnitEx(1,1,0, ARCANE_SANCTUM);//call SetBuildUnitEx( 1,1,0, ARCANE_SANCTUM  )
			SetBuildUnitEx(1,1,0, CASTLE);//call SetBuildUnitEx( 1,1,0, CASTLE          )
			SetBuildUnitEx(1,1,0, AVIARY);//call SetBuildUnitEx( 1,1,0, AVIARY          )
			SetBuildUnitEx(8,8,8, BLOOD_PEASANT);//call SetBuildUnitEx( 8,8,8, BLOOD_PEASANT   )
			CampaignDefenderEx(1,1,1, KAEL);//call CampaignDefenderEx( 1,1,1, KAEL            )
			CampaignDefenderEx(1,1,1, SPELL_BREAKER);//call CampaignDefenderEx( 1,1,1, SPELL_BREAKER   )
			CampaignDefenderEx(2,2,2, HIGH_SWORDMAN);//call CampaignDefenderEx( 2,2,2, HIGH_SWORDMAN   )
			CampaignDefenderEx(1,1,1, SORCERESS);//call CampaignDefenderEx( 1,1,1, SORCERESS       )
			CampaignDefenderEx(1,1,1, PRIEST);//call CampaignDefenderEx( 1,1,1, PRIEST          )
			CampaignDefenderEx(2,2,2, HIGH_ARCHER);//call CampaignDefenderEx( 2,2,2, HIGH_ARCHER		)
			SetBuildUpgrEx(1,1,1, UPG_SORCERY);//call SetBuildUpgrEx( 1,1,1, UPG_SORCERY			)
			SetBuildUpgrEx(1,1,1, UPG_PRAYING);//call SetBuildUpgrEx( 1,1,1, UPG_PRAYING			)
			SetBuildUpgrEx(1,1,1, UPG_MASONRY);//call SetBuildUpgrEx( 1,1,1, UPG_MASONRY			)
			SetBuildUpgrEx(1,1,1, UPG_ARMOR);//call SetBuildUpgrEx( 1,1,1, UPG_ARMOR			)
			SetBuildUpgrEx(1,1,1, UPG_LEATHER);//call SetBuildUpgrEx( 1,1,1, UPG_LEATHER			)
			SetBuildUpgrEx(1,1,1, UPG_RANGED);//call SetBuildUpgrEx( 1,1,1, UPG_RANGED			)
			SetBuildUpgrEx(1,1,1, UPG_MELEE);//call SetBuildUpgrEx( 1,1,1, UPG_MELEE			)
			SetBuildUpgrEx(2,2,1, UPG_PRAYING);//call SetBuildUpgrEx( 2,2,1, UPG_PRAYING			)
			SetBuildUpgrEx(2,2,1, UPG_MASONRY);//call SetBuildUpgrEx( 2,2,1, UPG_MASONRY			)
			SetBuildUpgrEx(2,2,2, UPG_ARMOR);//call SetBuildUpgrEx( 2,2,2, UPG_ARMOR			)
			SetBuildUpgrEx(2,2,2, UPG_LEATHER);//call SetBuildUpgrEx( 2,2,2, UPG_LEATHER			)
			SetBuildUpgrEx(2,2,2, UPG_RANGED);//call SetBuildUpgrEx( 2,2,2, UPG_RANGED			)
			SetBuildUpgrEx(2,2,2, UPG_MELEE);//call SetBuildUpgrEx( 2,2,2, UPG_MELEE			)
			SetBuildUpgrEx(3,3,2, UPG_MASONRY);//call SetBuildUpgrEx( 3,3,2, UPG_MASONRY			)
			SetBuildUpgrEx(3,3,2, UPG_ARMOR);//call SetBuildUpgrEx( 3,3,2, UPG_ARMOR			)
			SetBuildUpgrEx(3,3,2, UPG_LEATHER);//call SetBuildUpgrEx( 3,3,2, UPG_LEATHER			)
			SetBuildUpgrEx(3,3,2, UPG_RANGED);//call SetBuildUpgrEx( 3,3,2, UPG_RANGED			)
			SetBuildUpgrEx(3,3,2, UPG_MELEE);//call SetBuildUpgrEx( 3,3,2, UPG_MELEE			)
			SleepForever();//call SleepForever()
		}//endfunction

	
	}
}

