using System;

namespace Jass {

	public class h02_purple {

		//============================================================================
//  Human 02 -- purple player -- Uther Script
//============================================================================
private int UtherAI() {
// holy bolt
return 'AHhb';
}
// divine shield
return 'AHds';
}
// devotion aura
return 'AHad';
}
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

