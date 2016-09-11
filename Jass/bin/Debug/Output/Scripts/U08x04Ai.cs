using System;
using System.Collections.Generic;

namespace Jass {

	public class U08x04Ai {

		//
		//
		//
		public const int NO_CLOUD_HAWK = 'h000';//constant integer NO_CLOUD_HAWK  = 'h000'
		public const int CLOUD_HAWK = HUMAN_DRAGON_HAWK;//constant integer CLOUD_HAWK     = HUMAN_DRAGON_HAWK
		public static player user = PlayerEx(1);//player user = PlayerEx(1)
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(CommonAi.HOUSE, null);//call CampaignAI(HOUSE,null)
			SetReplacements(1, 1, 2);//call SetReplacements(1,1,2)
			DoCampaignFarms(false);//call DoCampaignFarms(false)
			GroupTimedLife(true);//call GroupTimedLife(true)
			SetBuildUnitEx(1, 1, 1, CommonAi.BLOOD_PEASANT);//call SetBuildUnitEx( 1,1,1, BLOOD_PEASANT   )
			SetBuildUnitEx(0, 0, 1, CommonAi.TOWN_HALL);//call SetBuildUnitEx( 0,0,1, TOWN_HALL       )
			SetBuildUnitEx(0, 0, 1, CommonAi.HUMAN_ALTAR);//call SetBuildUnitEx( 0,0,1, HUMAN_ALTAR     )
			SetBuildUnitEx(0, 0, 4, CommonAi.WATCH_TOWER);//call SetBuildUnitEx( 0,0,4, WATCH_TOWER     )
			SetBuildUnitEx(0, 0, 1, CommonAi.LUMBER_MILL);//call SetBuildUnitEx( 0,0,1, LUMBER_MILL     )
			SetBuildUnitEx(0, 0, 4, CommonAi.GUARD_TOWER);//call SetBuildUnitEx( 0,0,4, GUARD_TOWER     )
			SetBuildUnitEx(0, 0, 1, CommonAi.ARCANE_VAULT);//call SetBuildUnitEx( 0,0,1, ARCANE_VAULT    )
			SetBuildUnitEx(0, 0, 1, CommonAi.BLACKSMITH);//call SetBuildUnitEx( 0,0,1, BLACKSMITH      )
			SetBuildUnitEx(0, 0, 1, CommonAi.KEEP);//call SetBuildUnitEx( 0,0,1, KEEP            )
			SetBuildUnitEx(0, 0, 1, CommonAi.ARCANE_SANCTUM);//call SetBuildUnitEx( 0,0,1, ARCANE_SANCTUM  )
			SetBuildUnitEx(0, 0, 0, CommonAi.CASTLE);//call SetBuildUnitEx( 0,0,0, CASTLE          )
			SetBuildUnitEx(0, 0, 0, CommonAi.AVIARY);//call SetBuildUnitEx( 0,0,0, AVIARY          )
			SetBuildUnitEx(8, 8, 8, CommonAi.BLOOD_PEASANT);//call SetBuildUnitEx( 8,8,8, BLOOD_PEASANT   )
			CampaignDefenderEx(0, 0, 1, CommonAi.KAEL);//call CampaignDefenderEx( 0,0,1, KAEL            )
			CampaignDefenderEx(1, 1, 1, CommonAi.SPELL_BREAKER);//call CampaignDefenderEx( 1,1,1, SPELL_BREAKER   )
			CampaignDefenderEx(1, 1, 2, CommonAi.HIGH_SWORDMAN);//call CampaignDefenderEx( 1,1,2, HIGH_SWORDMAN   )
			CampaignDefenderEx(0, 0, 1, CommonAi.SORCERESS);//call CampaignDefenderEx( 0,0,1, SORCERESS       )
			CampaignDefenderEx(1, 1, 1, CommonAi.PRIEST);//call CampaignDefenderEx( 1,1,1, PRIEST          )
			CampaignDefenderEx(1, 1, 2, CommonAi.HIGH_ARCHER);//call CampaignDefenderEx( 1,1,2, HIGH_ARCHER     )
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_SORCERY);//call SetBuildUpgrEx( 0,0,1, UPG_SORCERY         )
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_PRAYING);//call SetBuildUpgrEx( 0,0,1, UPG_PRAYING         )
			SetBuildUpgrEx(1, 1, 3, CommonAi.UPG_MASONRY);//call SetBuildUpgrEx( 1,1,3, UPG_MASONRY         )
			SetBuildUpgrEx(1, 1, 1, CommonAi.UPG_CLOUD);//call SetBuildUpgrEx( 1,1,1, UPG_CLOUD           )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(3, 3, 5, CommonAi.HIGH_SWORDMAN);//call CampaignAttackerEx( 3,3,5, HIGH_SWORDMAN   )
			CampaignAttackerEx(2, 2, 3, CommonAi.HIGH_ARCHER);//call CampaignAttackerEx( 2,2,3, HIGH_ARCHER     )
			CampaignAttackerEx(1, 1, 2, CommonAi.BALLISTA);//call CampaignAttackerEx( 1,1,2, BALLISTA        )
			SuicideOnPlayerEx(CommonAi.M4, CommonAi.M4, CommonAi.M3, U08_tealAi.user);//call SuicideOnPlayerEx(M4,M4,M3,user)
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_ARMOR);//call SetBuildUpgrEx( 0,0,1, UPG_ARMOR           )
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_LEATHER);//call SetBuildUpgrEx( 0,0,1, UPG_LEATHER         )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2, 2, 5, CommonAi.SPELL_BREAKER);//call CampaignAttackerEx( 2,2,5, SPELL_BREAKER   )
			CampaignAttackerEx(2, 2, 3, CommonAi.HIGH_ARCHER);//call CampaignAttackerEx( 2,2,3, HIGH_ARCHER     )
			SuicideOnPlayerEx(CommonAi.M4, CommonAi.M4, CommonAi.M7, U08_tealAi.user);//call SuicideOnPlayerEx(M4,M4,M7,user)
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_RANGED);//call SetBuildUpgrEx( 0,0,1, UPG_RANGED          )
			SetBuildUpgrEx(0, 0, 1, CommonAi.UPG_MELEE);//call SetBuildUpgrEx( 0,0,1, UPG_MELEE           )
			SetBuildUpgrEx(1, 1, 2, CommonAi.UPG_SORCERY);//call SetBuildUpgrEx( 1,1,2, UPG_SORCERY         )
			SetBuildUpgrEx(1, 1, 2, CommonAi.UPG_PRAYING);//call SetBuildUpgrEx( 1,1,2, UPG_PRAYING         )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(4, 4, 6, CommonAi.HIGH_SWORDMAN);//call CampaignAttackerEx( 4,4,6, HIGH_SWORDMAN   )
			CampaignAttackerEx(1, 1, 2, CommonAi.PRIEST);//call CampaignAttackerEx( 1,1,2, PRIEST          )
			CampaignAttackerEx(1, 1, 1, CommonAi.KAEL);//call CampaignAttackerEx( 1,1,1, KAEL            )
			SuicideOnPlayerEx(CommonAi.M8, CommonAi.M8, CommonAi.M8, U08_tealAi.user);//call SuicideOnPlayerEx(M8,M8,M8,user)
			SetBuildUpgrEx(1, 1, 3, CommonAi.UPG_ARMOR);//call SetBuildUpgrEx( 1,1,3, UPG_ARMOR           )
			SetBuildUpgrEx(1, 1, 3, CommonAi.UPG_LEATHER);//call SetBuildUpgrEx( 1,1,3, UPG_LEATHER         )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2, 2, 3, U08x04Ai.CLOUD_HAWK);//call CampaignAttackerEx( 2,2,3, CLOUD_HAWK      )
			CampaignAttackerEx(4, 4, 7, U08x04Ai.NO_CLOUD_HAWK);//call CampaignAttackerEx( 4,4,7, NO_CLOUD_HAWK   )
			SuicideOnPlayerEx(CommonAi.M4, CommonAi.M4, CommonAi.M2, U08_tealAi.user);//call SuicideOnPlayerEx(M4,M4,M2,user)
			SetBuildUpgrEx(1, 1, 3, CommonAi.UPG_RANGED);//call SetBuildUpgrEx( 1,1,3, UPG_RANGED          )
			SetBuildUpgrEx(1, 1, 3, CommonAi.UPG_MELEE);//call SetBuildUpgrEx( 1,1,3, UPG_MELEE           )
			SetBuildUpgrEx(2, 2, 2, CommonAi.UPG_SORCERY);//call SetBuildUpgrEx( 2,2,2, UPG_SORCERY         )
			SetBuildUpgrEx(2, 2, 2, CommonAi.UPG_PRAYING);//call SetBuildUpgrEx( 2,2,2, UPG_PRAYING         )
			SetBuildUpgrEx(1, 1, 1, CommonAi.UPG_CONT_MAGIC);//call SetBuildUpgrEx( 1,1,1, UPG_CONT_MAGIC      )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(4, 4, 6, CommonAi.SPELL_BREAKER);//call CampaignAttackerEx( 4,4,6, SPELL_BREAKER   )
			CampaignAttackerEx(0, 0, 2, CommonAi.HIGH_ARCHER);//call CampaignAttackerEx( 0,0,2, HIGH_ARCHER     )
			CampaignAttackerEx(1, 1, 1, CommonAi.BALLISTA);//call CampaignAttackerEx( 1,1,1, BALLISTA        )
			CampaignAttackerEx(2, 2, 4, CommonAi.SORCERESS);//call CampaignAttackerEx( 2,2,4, SORCERESS       )
			SuicideOnPlayerEx(CommonAi.M6, CommonAi.M6, CommonAi.M9, U08_tealAi.user);//call SuicideOnPlayerEx(M6,M6,M9,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(4, 4, 6, CommonAi.HIGH_SWORDMAN);//call CampaignAttackerEx( 4,4,6, HIGH_SWORDMAN   )
			CampaignAttackerEx(2, 2, 4, CommonAi.HIGH_ARCHER);//call CampaignAttackerEx( 2,2,4, HIGH_ARCHER     )
			CampaignAttackerEx(1, 1, 2, CommonAi.PRIEST);//call CampaignAttackerEx( 1,1,2, PRIEST          )
			CampaignAttackerEx(0, 0, 1, CommonAi.KAEL);//call CampaignAttackerEx( 0,0,1, KAEL            )
			CampaignAttackerEx(1, 1, 1, U08x04Ai.CLOUD_HAWK);//call CampaignAttackerEx( 1,1,1, CLOUD_HAWK      )
			SuicideOnPlayerEx(CommonAi.M6, CommonAi.M6, CommonAi.M7, U08_tealAi.user);//call SuicideOnPlayerEx(M6,M6,M7,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(4, 4, 6, CommonAi.SPELL_BREAKER);//call CampaignAttackerEx( 4,4,6, SPELL_BREAKER   )
			CampaignAttackerEx(0, 0, 2, CommonAi.HIGH_ARCHER);//call CampaignAttackerEx( 0,0,2, HIGH_ARCHER     )
			CampaignAttackerEx(1, 1, 1, CommonAi.BALLISTA);//call CampaignAttackerEx( 1,1,1, BALLISTA        )
			CampaignAttackerEx(2, 2, 4, CommonAi.SORCERESS);//call CampaignAttackerEx( 2,2,4, SORCERESS       )
			CampaignAttackerEx(1, 1, 1, CommonAi.KAEL);//call CampaignAttackerEx( 1,1,1, KAEL            )
			SuicideOnPlayerEx(CommonAi.M7, CommonAi.M7, CommonAi.M7, U08_tealAi.user);//call SuicideOnPlayerEx(M7,M7,M7,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(4, 4, 4, CommonAi.HIGH_SWORDMAN);//call CampaignAttackerEx( 4,4,4, HIGH_SWORDMAN   )
			CampaignAttackerEx(2, 2, 2, CommonAi.HIGH_ARCHER);//call CampaignAttackerEx( 2,2,2, HIGH_ARCHER     )
			CampaignAttackerEx(1, 1, 2, CommonAi.PRIEST);//call CampaignAttackerEx( 1,1,2, PRIEST          )
			CampaignAttackerEx(1, 1, 2, CommonAi.SORCERESS);//call CampaignAttackerEx( 1,1,2, SORCERESS       )
			CampaignAttackerEx(1, 1, 0, CommonAi.KAEL);//call CampaignAttackerEx( 1,1,0, KAEL            )
			SuicideOnPlayerEx(CommonAi.M8, CommonAi.M8, CommonAi.M3, U08_tealAi.user);//call SuicideOnPlayerEx(M8,M8,M3,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2, 2, 3, U08x04Ai.CLOUD_HAWK);//call CampaignAttackerEx( 2,2,3, CLOUD_HAWK      )
			CampaignAttackerEx(4, 4, 7, U08x04Ai.NO_CLOUD_HAWK);//call CampaignAttackerEx( 4,4,7, NO_CLOUD_HAWK   )
			SuicideOnPlayerEx(CommonAi.M8, CommonAi.M8, CommonAi.M9, U08_tealAi.user);//call SuicideOnPlayerEx(M8,M8,M9,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(4, 4, 6, CommonAi.SPELL_BREAKER);//call CampaignAttackerEx( 4,4,6, SPELL_BREAKER   )
			CampaignAttackerEx(0, 0, 2, CommonAi.HIGH_ARCHER);//call CampaignAttackerEx( 0,0,2, HIGH_ARCHER     )
			CampaignAttackerEx(1, 1, 1, CommonAi.BALLISTA);//call CampaignAttackerEx( 1,1,1, BALLISTA        )
			CampaignAttackerEx(2, 2, 4, CommonAi.SORCERESS);//call CampaignAttackerEx( 2,2,4, SORCERESS       )
			CampaignAttackerEx(0, 0, 1, CommonAi.KAEL);//call CampaignAttackerEx( 0,0,1, KAEL            )
			SuicideOnPlayerEx(CommonAi.M4, CommonAi.M4, CommonAi.M7, U08_tealAi.user);//call SuicideOnPlayerEx(M4,M4,M7,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(4, 4, 6, CommonAi.HIGH_SWORDMAN);//call CampaignAttackerEx( 4,4,6, HIGH_SWORDMAN   )
			CampaignAttackerEx(2, 2, 4, CommonAi.HIGH_ARCHER);//call CampaignAttackerEx( 2,2,4, HIGH_ARCHER     )
			CampaignAttackerEx(1, 1, 2, CommonAi.PRIEST);//call CampaignAttackerEx( 1,1,2, PRIEST          )
			CampaignAttackerEx(0, 0, 1, CommonAi.KAEL);//call CampaignAttackerEx( 0,0,1, KAEL            )
			CampaignAttackerEx(1, 1, 1, U08x04Ai.CLOUD_HAWK);//call CampaignAttackerEx( 1,1,1, CLOUD_HAWK      )
			SuicideOnPlayerEx(CommonAi.M7, CommonAi.M7, CommonAi.M7, U08_tealAi.user);//call SuicideOnPlayerEx(M7,M7,M7,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(4, 4, 6, CommonAi.SPELL_BREAKER);//call CampaignAttackerEx( 4,4,6, SPELL_BREAKER   )
			CampaignAttackerEx(0, 0, 2, CommonAi.HIGH_ARCHER);//call CampaignAttackerEx( 0,0,2, HIGH_ARCHER     )
			CampaignAttackerEx(1, 1, 1, CommonAi.BALLISTA);//call CampaignAttackerEx( 1,1,1, BALLISTA        )
			CampaignAttackerEx(2, 2, 4, CommonAi.SORCERESS);//call CampaignAttackerEx( 2,2,4, SORCERESS       )
			CampaignAttackerEx(1, 1, 0, CommonAi.KAEL);//call CampaignAttackerEx( 1,1,0, KAEL            )
			SuicideOnPlayerEx(CommonAi.M8, CommonAi.M8, CommonAi.M3, U08_tealAi.user);//call SuicideOnPlayerEx(M8,M8,M3,user)
			while (true) {//loop
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(2, 2, 3, U08x04Ai.CLOUD_HAWK);//call CampaignAttackerEx( 2,2,3, CLOUD_HAWK      )
				CampaignAttackerEx(4, 4, 7, U08x04Ai.NO_CLOUD_HAWK);//call CampaignAttackerEx( 4,4,7, NO_CLOUD_HAWK   )
				SuicideOnPlayerEx(CommonAi.M8, CommonAi.M8, CommonAi.M9, U08_tealAi.user);//call SuicideOnPlayerEx(M8,M8,M9,user)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(4, 4, 4, CommonAi.HIGH_SWORDMAN);//call CampaignAttackerEx( 4,4,4, HIGH_SWORDMAN   )
				CampaignAttackerEx(2, 2, 2, CommonAi.HIGH_ARCHER);//call CampaignAttackerEx( 2,2,2, HIGH_ARCHER     )
				CampaignAttackerEx(1, 1, 2, CommonAi.PRIEST);//call CampaignAttackerEx( 1,1,2, PRIEST          )
				CampaignAttackerEx(1, 1, 2, CommonAi.SORCERESS);//call CampaignAttackerEx( 1,1,2, SORCERESS       )
				CampaignAttackerEx(1, 1, 1, CommonAi.KAEL);//call CampaignAttackerEx( 1,1,1, KAEL            )
				CampaignAttackerEx(1, 1, 1, U08x04Ai.CLOUD_HAWK);//call CampaignAttackerEx( 1,1,1, CLOUD_HAWK      )
				SuicideOnPlayerEx(CommonAi.M8, CommonAi.M8, CommonAi.M7, U08_tealAi.user);//call SuicideOnPlayerEx(M8,M8,M7,user)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(4, 4, 6, CommonAi.SPELL_BREAKER);//call CampaignAttackerEx( 4,4,6, SPELL_BREAKER   )
				CampaignAttackerEx(0, 0, 2, CommonAi.HIGH_ARCHER);//call CampaignAttackerEx( 0,0,2, HIGH_ARCHER     )
				CampaignAttackerEx(1, 1, 1, CommonAi.BALLISTA);//call CampaignAttackerEx( 1,1,1, BALLISTA        )
				CampaignAttackerEx(2, 2, 4, CommonAi.SORCERESS);//call CampaignAttackerEx( 2,2,4, SORCERESS       )
				CampaignAttackerEx(0, 0, 1, CommonAi.KAEL);//call CampaignAttackerEx( 0,0,1, KAEL            )
				SuicideOnPlayerEx(CommonAi.M8, CommonAi.M8, CommonAi.M7, U08_tealAi.user);//call SuicideOnPlayerEx(M8,M8,M7,user)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(2, 2, 3, U08x04Ai.CLOUD_HAWK);//call CampaignAttackerEx( 2,2,3, CLOUD_HAWK      )
				CampaignAttackerEx(4, 4, 7, U08x04Ai.NO_CLOUD_HAWK);//call CampaignAttackerEx( 4,4,7, NO_CLOUD_HAWK   )
				SuicideOnPlayerEx(CommonAi.M8, CommonAi.M8, CommonAi.M3, U08_tealAi.user);//call SuicideOnPlayerEx(M8,M8,M3,user)
			}//endloop
		}//endfunction

	
	}
}

