using System;
using System.Collections.Generic;

namespace Jass {

	public class U08x09Ai {

		//
		//
		//
		//
		//
		//
		private void get_coords() {//function get_coords takes nothing returns nothing
			int x = -1;//local integer x = -1
			int y = -1;//local integer y = -1
			int cmd;//local integer cmd
			int data;//local integer data
			while (true) {//loop
				while (true) {//loop
					if (CommandsWaiting() > 0) { break; }//exitwhen CommandsWaiting() > 0
					Sleep(0.1);//call Sleep(0.1)
				}//endloop
				cmd = GetLastCommand();//set cmd  = GetLastCommand()
				data = GetLastData();//set data = GetLastData()
				PopLastCommand();//call PopLastCommand()
				//
				if (cmd == SET_X) {//if cmd == SET_X then
					//
					x = data;//set x = data
					//
				} else if (cmd == SET_Y) {//elseif cmd == SET_Y then
					//
					y = data;//set y = data
				}//endif
				if (x != -1 && y != -1) { break; }//exitwhen x != -1 and y != -1
			}//endloop
			ShiftTownSpot(R2I(GetStartLocationX(GetPlayerStartLocation(ai_player))), R2I(GetStartLocationY(GetPlayerStartLocation(ai_player))));//call ShiftTownSpot(R2I(GetStartLocationX(GetPlayerStartLocation(ai_player))), R2I(GetStartLocationY(GetPlayerStartLocation(ai_player))))
			SetCaptainHome(BOTH_CAPTAINS,x,y);//call SetCaptainHome(BOTH_CAPTAINS,x,y)
			TeleportCaptain(x,y);//call TeleportCaptain(x,y)
		}//endfunction
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(NAGA_CORAL,null);//call CampaignAI(NAGA_CORAL,null)
			SetPeonsRepair(true);//call SetPeonsRepair(true)
			get_coords();//call get_coords()
			SetBuildUnitEx(1,1,1, NAGA_CORAL);//call SetBuildUnitEx( 1,1,1, NAGA_CORAL      )
			SetBuildUnitEx(1,1,1, NAGA_SPAWNING);//call SetBuildUnitEx( 1,1,1, NAGA_SPAWNING   )
			SetBuildUnitEx(1,1,1, NAGA_SHRINE);//call SetBuildUnitEx( 1,1,1, NAGA_SHRINE     )
			SetBuildUnitEx(2,2,2, NAGA_CORAL);//call SetBuildUnitEx( 2,2,2, NAGA_CORAL      )
			SetBuildUnitEx(1,1,2, NAGA_GUARDIAN);//call SetBuildUnitEx( 1,1,2, NAGA_GUARDIAN   )
			AddGuardPost(NAGA_REAVER,         -313, -4019);//call AddGuardPost( NAGA_REAVER,         -313, -4019 )
			AddGuardPost(NAGA_REAVER,         -579, -4032);//call AddGuardPost( NAGA_REAVER,         -579, -4032 )
			AddGuardPost(NAGA_SIREN,          -291, -3774);//call AddGuardPost( NAGA_SIREN,          -291, -3774 )
			AddGuardPost(NAGA_SNAP_DRAGON,    -609, -3785);//call AddGuardPost( NAGA_SNAP_DRAGON,    -609, -3785 )
			CampaignDefenderEx(1,1,1, NAGA_SIREN);//call CampaignDefenderEx( 1,1,1, NAGA_SIREN          )
			CampaignDefenderEx(2,2,2, NAGA_SNAP_DRAGON);//call CampaignDefenderEx( 2,2,2, NAGA_SNAP_DRAGON    )
			CampaignDefenderEx(2,2,3, NAGA_REAVER);//call CampaignDefenderEx( 2,2,3, NAGA_REAVER         )
			SetBuildUpgrEx(1,1,1, UPG_SIREN);//call SetBuildUpgrEx( 1,1,1, UPG_SIREN           )
			SetBuildUpgrEx(1,1,1, UPG_NAGA_ENSNARE);//call SetBuildUpgrEx( 1,1,1, UPG_NAGA_ENSNARE    )
			SetBuildUpgrEx(1,1,1, UPG_NAGA_ABOLISH);//call SetBuildUpgrEx( 1,1,1, UPG_NAGA_ABOLISH    )
			SetBuildUpgrEx(2,2,2, UPG_SIREN);//call SetBuildUpgrEx( 2,2,2, UPG_SIREN           )
			SleepForever();//call SleepForever()
		}//endfunction

	
	}
}

