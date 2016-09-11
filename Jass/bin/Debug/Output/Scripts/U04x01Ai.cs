using System;
using System.Collections.Generic;

namespace Jass {

	public class U04x01Ai {

		//
		//
		//
		public static player user = PlayerEx(4);//player user = PlayerEx(4)
		public const int NO_CLOUD_HAWK = 'h001';//constant integer NO_CLOUD_HAWK  = 'h001'
		public const int CLOUD_HAWK = HUMAN_DRAGON_HAWK;//constant integer CLOUD_HAWK     = HUMAN_DRAGON_HAWK
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(CommonAi.HOUSE, null);//call CampaignAI(HOUSE,null)
			SetReplacements(2, 2, 3);//call SetReplacements(2,2,3)
			SetBuildUnitEx(1, 1, 1, CommonAi.BLOOD_PEASANT);//call SetBuildUnitEx( 1,1,1, BLOOD_PEASANT   )
			SetBuildUnitEx(0, 0, 1, CommonAi.TOWN_HALL);//call SetBuildUnitEx( 0,0,1, TOWN_HALL       )
			SetBuildUnitEx(0, 0, 1, CommonAi.BARRACKS);//call SetBuildUnitEx( 0,0,1, BARRACKS        )
			SetBuildUnitEx(0, 0, 1, CommonAi.HUMAN_ALTAR);//call SetBuildUnitEx( 0,0,1, HUMAN_ALTAR     )
			SetBuildUnitEx(0, 0, 4, CommonAi.WATCH_TOWER);//call SetBuildUnitEx( 0,0,4, WATCH_TOWER     )
			SetBuildUnitEx(0, 0, 1, CommonAi.LUMBER_MILL);//call SetBuildUnitEx( 0,0,1, LUMBER_MILL     )
			SetBuildUnitEx(0, 0, 4, CommonAi.GUARD_TOWER);//call SetBuildUnitEx( 0,0,4, GUARD_TOWER     )
			SetBuildUnitEx(0, 0, 1, CommonAi.ARCANE_VAULT);//call SetBuildUnitEx( 0,0,1, ARCANE_VAULT    )
			SetBuildUnitEx(0, 0, 1, CommonAi.BLACKSMITH);//call SetBuildUnitEx( 0,0,1, BLACKSMITH      )
			SetBuildUnitEx(0, 0, 1, CommonAi.KEEP);//call SetBuildUnitEx( 0,0,1, KEEP            )
			SetBuildUnitEx(0, 0, 1, CommonAi.ARCANE_SANCTUM);//call SetBuildUnitEx( 0,0,1, ARCANE_SANCTUM  )
			SetBuildUnitEx(0, 0, 1, CommonAi.CASTLE);//call SetBuildUnitEx( 0,0,1, CASTLE          )
			SetBuildUnitEx(0, 0, 1, CommonAi.AVIARY);//call SetBuildUnitEx( 0,0,1, AVIARY          )
			SetBuildUnitEx(8, 8, 8, CommonAi.BLOOD_PEASANT);//call SetBuildUnitEx( 8,8,8, BLOOD_PEASANT   )
			SetBuildUnitEx(2, 2, 2, CommonAi.ZEPPELIN);//call SetBuildUnitEx( 2,2,2, ZEPPELIN        )
			CampaignDefenderEx(1, 1, 1, CommonAi.SPELL_BREAKER);//call CampaignDefenderEx( 1,1,1, SPELL_BREAKER   )
			CampaignDefenderEx(1, 1, 2, CommonAi.HIGH_SWORDMAN);//call CampaignDefenderEx( 1,1,2, HIGH_SWORDMAN   )
			CampaignDefenderEx(0, 0, 1, CommonAi.SORCERESS);//call CampaignDefenderEx( 0,0,1, SORCERESS       )
			CampaignDefenderEx(1, 1, 1, CommonAi.PRIEST);//call CampaignDefenderEx( 1,1,1, PRIEST          )
			CampaignDefenderEx(1, 1, 2, CommonAi.HIGH_ARCHER);//call CampaignDefenderEx( 1,1,2, HIGH_ARCHER     )
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_SORCERY);//call SetBuildUpgrEx( 0,0,1, UPG_SORCERY         )
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_PRAYING);//call SetBuildUpgrEx( 0,0,1, UPG_PRAYING         )
			SetBuildUpgrEx(1, 1, 3, CommonAi.UPG_MASONRY);//call SetBuildUpgrEx( 1,1,3, UPG_MASONRY         )
			SetBuildUpgrEx(1, 1, 1, CommonAi.UPG_CLOUD);//call SetBuildUpgrEx( 1,1,1, UPG_CLOUD           )
			WaitForSignal();//call WaitForSignal()
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(3, 3, 5, CommonAi.HIGH_SWORDMAN);//call CampaignAttackerEx( 3,3,5, HIGH_SWORDMAN   )
			CampaignAttackerEx(2, 2, 3, CommonAi.HIGH_ARCHER);//call CampaignAttackerEx( 2,2,3, HIGH_ARCHER     )
			SuicideOnPlayerEx(CommonAi.M6, CommonAi.M6, CommonAi.M4, U08_tealAi.user);//call SuicideOnPlayerEx(M6,M6,M4,user)
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_ARMOR);//call SetBuildUpgrEx( 0,0,1, UPG_ARMOR           )
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_LEATHER);//call SetBuildUpgrEx( 0,0,1, UPG_LEATHER         )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2, 2, 5, CommonAi.SPELL_BREAKER);//call CampaignAttackerEx( 2,2,5, SPELL_BREAKER   )
			CampaignAttackerEx(2, 2, 3, CommonAi.HIGH_ARCHER);//call CampaignAttackerEx( 2,2,3, HIGH_ARCHER     )
			CampaignAttackerEx(1, 1, 2, CommonAi.BALLISTA);//call CampaignAttackerEx( 1,1,2, BALLISTA        )
			SuicideOnPlayerEx(CommonAi.M6, CommonAi.M6, CommonAi.M5, U08_tealAi.user);//call SuicideOnPlayerEx(M6,M6,M5,user)
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_RANGED);//call SetBuildUpgrEx( 0,0,1, UPG_RANGED          )
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_MELEE);//call SetBuildUpgrEx( 0,0,1, UPG_MELEE           )
			SetBuildUpgrEx(1, 1, 2, CommonAi.UPG_SORCERY);//call SetBuildUpgrEx( 1,1,2, UPG_SORCERY         )
			SetBuildUpgrEx(1, 1, 2, CommonAi.UPG_PRAYING);//call SetBuildUpgrEx( 1,1,2, UPG_PRAYING         )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2, 2, 3, U08x04Ai.CLOUD_HAWK);//call CampaignAttackerEx( 2,2,3, CLOUD_HAWK      )
			CampaignAttackerEx(4, 4, 7, U08x04Ai.NO_CLOUD_HAWK);//call CampaignAttackerEx( 4,4,7, NO_CLOUD_HAWK   )
			SuicideOnPlayerEx(CommonAi.M6, CommonAi.M6, CommonAi.M5, U08_tealAi.user);//call SuicideOnPlayerEx(M6,M6,M5,user)
			SetBuildUpgrEx(1, 1, 3, CommonAi.UPG_ARMOR);//call SetBuildUpgrEx( 1,1,3, UPG_ARMOR           )
			SetBuildUpgrEx(1, 1, 3, CommonAi.UPG_LEATHER);//call SetBuildUpgrEx( 1,1,3, UPG_LEATHER         )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(4, 4, 6, CommonAi.SPELL_BREAKER);//call CampaignAttackerEx( 4,4,6, SPELL_BREAKER   )
			CampaignAttackerEx(1, 1, 2, CommonAi.BALLISTA);//call CampaignAttackerEx( 1,1,2, BALLISTA        )
			CampaignAttackerEx(2, 2, 3, CommonAi.SORCERESS);//call CampaignAttackerEx( 2,2,3, SORCERESS       )
			SuicideOnPlayerEx(CommonAi.M6, CommonAi.M6, CommonAi.M5, U08_tealAi.user);//call SuicideOnPlayerEx(M6,M6,M5,user)
			SetBuildUpgrEx(1, 1, 3, CommonAi.UPG_RANGED);//call SetBuildUpgrEx( 1,1,3, UPG_RANGED          )
			SetBuildUpgrEx(1, 1, 3, CommonAi.UPG_MELEE);//call SetBuildUpgrEx( 1,1,3, UPG_MELEE           )
			SetBuildUpgrEx(2, 2, 2, CommonAi.UPG_SORCERY);//call SetBuildUpgrEx( 2,2,2, UPG_SORCERY         )
			SetBuildUpgrEx(2, 2, 2, CommonAi.UPG_PRAYING);//call SetBuildUpgrEx( 2,2,2, UPG_PRAYING         )
			SetBuildUpgrEx(1, 1, 1, CommonAi.UPG_SENTINEL);//call SetBuildUpgrEx( 1,1,1, UPG_SENTINEL        )
			SetBuildUpgrEx(1, 1, 1, CommonAi.UPG_CONT_MAGIC);//call SetBuildUpgrEx( 1,1,1, UPG_CONT_MAGIC      )
			while (true) {//loop
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(4, 4, 9, CommonAi.HIGH_SWORDMAN);//call CampaignAttackerEx( 4,4,9, HIGH_SWORDMAN   )
				CampaignAttackerEx(2, 2, 5, CommonAi.HIGH_ARCHER);//call CampaignAttackerEx( 2,2,5, HIGH_ARCHER     )
				CampaignAttackerEx(1, 1, 2, CommonAi.PRIEST);//call CampaignAttackerEx( 1,1,2, PRIEST          )
				CampaignAttackerEx(1, 1, 2, CommonAi.BALLISTA);//call CampaignAttackerEx( 1,1,2, BALLISTA        )
				SuicideOnPlayerEx(CommonAi.M6, CommonAi.M6, CommonAi.M5, U08_tealAi.user);//call SuicideOnPlayerEx(M6,M6,M5,user)
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(2, 2, 3, U08x04Ai.CLOUD_HAWK);//call CampaignAttackerEx( 2,2,3, CLOUD_HAWK      )
				CampaignAttackerEx(5, 5, 7, U08x04Ai.NO_CLOUD_HAWK);//call CampaignAttackerEx( 5,5,7, NO_CLOUD_HAWK   )
				SuicideOnPlayerEx(CommonAi.M6, CommonAi.M6, CommonAi.M5, U08_tealAi.user);//call SuicideOnPlayerEx(M6,M6,M5,user)
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(4, 4, 9, CommonAi.SPELL_BREAKER);//call CampaignAttackerEx( 4,4,9, SPELL_BREAKER   )
				CampaignAttackerEx(0, 0, 4, CommonAi.HIGH_ARCHER);//call CampaignAttackerEx( 0,0,4, HIGH_ARCHER     )
				CampaignAttackerEx(1, 1, 2, CommonAi.BALLISTA);//call CampaignAttackerEx( 1,1,2, BALLISTA        )
				CampaignAttackerEx(2, 2, 4, CommonAi.SORCERESS);//call CampaignAttackerEx( 2,2,4, SORCERESS       )
				SuicideOnPlayerEx(CommonAi.M6, CommonAi.M6, CommonAi.M5, U08_tealAi.user);//call SuicideOnPlayerEx(M6,M6,M5,user)
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(4, 4, 9, CommonAi.HIGH_SWORDMAN);//call CampaignAttackerEx( 4,4,9, HIGH_SWORDMAN   )
				CampaignAttackerEx(2, 2, 5, CommonAi.HIGH_ARCHER);//call CampaignAttackerEx( 2,2,5, HIGH_ARCHER     )
				CampaignAttackerEx(1, 1, 2, CommonAi.PRIEST);//call CampaignAttackerEx( 1,1,2, PRIEST          )
				CampaignAttackerEx(1, 1, 2, CommonAi.SORCERESS);//call CampaignAttackerEx( 1,1,2, SORCERESS       )
				CampaignAttackerEx(1, 1, 2, CommonAi.BALLISTA);//call CampaignAttackerEx( 1,1,2, BALLISTA        )
				SuicideOnPlayerEx(CommonAi.M6, CommonAi.M6, CommonAi.M5, U08_tealAi.user);//call SuicideOnPlayerEx(M6,M6,M5,user)
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(2, 2, 3, U08x04Ai.CLOUD_HAWK);//call CampaignAttackerEx( 2,2,3, CLOUD_HAWK      )
				CampaignAttackerEx(5, 5, 7, U08x04Ai.NO_CLOUD_HAWK);//call CampaignAttackerEx( 5,5,7, NO_CLOUD_HAWK   )
				SuicideOnPlayerEx(CommonAi.M6, CommonAi.M6, CommonAi.M5, U08_tealAi.user);//call SuicideOnPlayerEx(M6,M6,M5,user)
			}//endloop
		}//endfunction

	
	}
}

