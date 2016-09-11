using System;
using System.Collections.Generic;

namespace Jass {

	public class CreditsOtherPld {

		private void PreloadFiles() {//function PreloadFiles takes nothing returns nothing
			Preload("units\\creeps\\RedDragonWelp\\RedDragonWelp_portrait.mdx");//call Preload( "units\\creeps\\RedDragonWelp\\RedDragonWelp_portrait.mdx" )
			Preload("Textures\\RedDragon.blp");//call Preload( "Textures\\RedDragon.blp" )
			Preload("units\\creeps\\ChaosWarlockGreen\\ChaosWarlockGreen_portrait.mdx");//call Preload( "units\\creeps\\ChaosWarlockGreen\\ChaosWarlockGreen_portrait.mdx" )
			Preload("units\\Creeps\\ChaosWarlockGreen\\ChaosGreenWarlock.blp");//call Preload( "units\\Creeps\\ChaosWarlockGreen\\ChaosGreenWarlock.blp" )
			Preload("units\\nightelf\\HeroMoonPriestess\\HeroMoonPriestess_portrait.mdx");//call Preload( "units\\nightelf\\HeroMoonPriestess\\HeroMoonPriestess_portrait.mdx" )
			Preload("units\\NightElf\\HeroMoonPriestess\\PriestessOfTheMoon.blp");//call Preload( "units\\NightElf\\HeroMoonPriestess\\PriestessOfTheMoon.blp" )
			PreloadEnd(0.0);//call PreloadEnd( 0.0 )
		}//endfunction

	
	}
}

