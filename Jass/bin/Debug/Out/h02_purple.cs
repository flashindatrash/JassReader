using System;

namespace Jass {

	public class h02_purple {

		//============================================================================
//  Human 02 -- purple player -- Uther Script
//============================================================================
private int UtherAI() {
if (level == 1 || level == 4 || level == 7) {
// holy bolt
return 'AHhb';
}
if (level == 2 || level == 5 || level == 8) {
// divine shield
return 'AHds';
}
if (level == 3 || level == 6 || level == 9) {
// devotion aura
return 'AHad';
}
if (level == 10) {
// resurrection
return 'AHre';
}
return 0;
}
//============================================================================
//  main
//============================================================================
private void main() {
SetHeroLevels(function UtherAI);
SleepForever();
}

	
	}
}

