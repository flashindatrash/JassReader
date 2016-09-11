using System;
using System.Collections.Generic;

namespace Jass {

	public class H02_purpleAi {

		//
		//
		//
		private int UtherAI() {//function UtherAI takes nothing returns integer
			int level = GetHeroLevelAI();//local integer level = GetHeroLevelAI()
			if (level == 1 || level == 4 || level == 7) {//if level == 1 or level == 4 or level == 7 then
				return 'AHhb';//return 'AHhb'
			}//endif
			if (level == 2 || level == 5 || level == 8) {//if level == 2 or level == 5 or level == 8 then
				return 'AHds';//return 'AHds'
			}//endif
			if (level == 3 || level == 6 || level == 9) {//if level == 3 or level == 6 or level == 9 then
				return 'AHad';//return 'AHad'
			}//endif
			if (level == 10) {//if level == 10 then
				return 'AHre';//return 'AHre'
			}//endif
			return 0;//return 0
		}//endfunction
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			SetHeroLevels(function UtherAI);//call SetHeroLevels(function UtherAI)
			SleepForever();//call SleepForever()
		}//endfunction

	
	}
}

