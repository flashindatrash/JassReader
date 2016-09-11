using System;
using System.Collections.Generic;

namespace Jass {

	public class O05_tealAi {

		//
		//
		//
		//
		//
		//
		//
		//
		//
		//
		//
		//
		//
		//
		//
		//
		private void gather_force() {//function gather_force takes nothing returns nothing
			Trace("Cenarius gather_force\n");//call Trace("Cenarius gather_force\n")
			InitAssaultGroup();//call InitAssaultGroup()
			SetAssaultGroup(1,1,CENARIUS);//call SetAssaultGroup( 1,1,CENARIUS       )
			SetAssaultGroup(2,99,ARCHER);//call SetAssaultGroup( 2,99,ARCHER        )
			SetAssaultGroup(2,99,HUNTRESS);//call SetAssaultGroup( 2,99,HUNTRESS      )
			SetInitialWave(1);//call SetInitialWave(1)
			FormGroup(1,true);//call FormGroup(1,true)
			Trace("Cenarius force ready\n");//call Trace("Cenarius force ready\n")
		}//endfunction
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			int command;//local integer command
			int data;//local integer data
			float goal_x = 0;//local real goal_x = 0
			float goal_y = 0;//local real goal_y = 0
			float home_x = 0;//local real home_x = 0
			float home_y = 0;//local real home_y = 0
			CampaignAI(MOON_WELL,null);//call CampaignAI(MOON_WELL,null)
			SetBuildUnit(2, ARCHER);//call SetBuildUnit( 2, ARCHER    )
			SetBuildUnit(2, HUNTRESS);//call SetBuildUnit( 2, HUNTRESS  )
			campaign_wood_peons = 0;//set campaign_wood_peons = 0
			while (true) {//loop
				while (true) {//loop
					if (CommandsWaiting() != 0) { break; }//exitwhen CommandsWaiting() != 0
					Sleep(0.5);//call Sleep(0.5)
				}//endloop
				command = GetLastCommand();//set command = GetLastCommand()
				data = GetLastData();//set data    = GetLastData()
				PopLastCommand();//call PopLastCommand()
				//
				//
				//
				if (command==1) {//if command==1 then
					Trace("Cenarius set goal x\n");//call Trace("Cenarius set goal x\n")
					goal_x = data;//set goal_x = data
					//
					//
					//
				} else if (command==2) {//elseif command==2 then
					Trace("Cenarius set goal y\n");//call Trace("Cenarius set goal y\n")
					goal_y = data;//set goal_y = data
					//
					//
					//
				} else if (command==3) {//elseif command==3 then
					Trace("Cenarius set home x\n");//call Trace("Cenarius set home x\n")
					home_x = data;//set home_x = data
					//
					//
					//
				} else if (command==4) {//elseif command==4 then
					Trace("Cenarius set home y\n");//call Trace("Cenarius set home y\n")
					home_y = data;//set home_y = data
					//
					//
					//
				} else if (command==5) {//elseif command==5 then
					Trace("Cenarius attack goal\n");//call Trace("Cenarius attack goal\n")
					gather_force();//call gather_force()
					Trace("Cenarius home change & attack order\n");//call Trace("Cenarius home change & attack order\n")
					SetCaptainHome(ATTACK_CAPTAIN, goal_x, goal_y);//call SetCaptainHome(ATTACK_CAPTAIN, goal_x, goal_y)
					CaptainAttack(goal_x,goal_y);//call CaptainAttack(goal_x,goal_y)
					//
					//
					//
				} else if (command==6) {//elseif command==6 then
					Trace("Cenarius home change & go home order\n");//call Trace("Cenarius home change & go home order\n")
					SetCaptainHome(ATTACK_CAPTAIN, home_x, home_y);//call SetCaptainHome(ATTACK_CAPTAIN, home_x, home_y)
					ClearCaptainTargets();//call ClearCaptainTargets()
					CaptainGoHome();//call CaptainGoHome()
				}//endif
			}//endloop
		}//endfunction

	
	}
}

