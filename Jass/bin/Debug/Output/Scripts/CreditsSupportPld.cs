using System;
using System.Collections.Generic;

namespace Jass {

	public class CreditsSupportPld {

		private void PreloadFiles() {//function PreloadFiles takes nothing returns nothing
			Preload("units\\critters\\Seal\\Seal_portrait.mdx");//call Preload( "units\\critters\\Seal\\Seal_portrait.mdx" )
			Preload("units\\Critters\\Seal\\Seal_Portrait.blp");//call Preload( "units\\Critters\\Seal\\Seal_Portrait.blp" )
			Preload("units\\creeps\\Revenant\\Revenant_portrait.mdx");//call Preload( "units\\creeps\\Revenant\\Revenant_portrait.mdx" )
			Preload("units\\Creeps\\Revenant\\Revenant.blp");//call Preload( "units\\Creeps\\Revenant\\Revenant.blp" )
			Preload("units\\Creeps\\Revenant\\BlueWaves.blp");//call Preload( "units\\Creeps\\Revenant\\BlueWaves.blp" )
			Preload("Textures\\Blue_Glow2.blp");//call Preload( "Textures\\Blue_Glow2.blp" )
			Preload("units\\critters\\VillagerMan\\VillagerMan_portrait.mdx");//call Preload( "units\\critters\\VillagerMan\\VillagerMan_portrait.mdx" )
			Preload("units\\Critters\\VillagerMan\\VillagerMale.blp");//call Preload( "units\\Critters\\VillagerMan\\VillagerMale.blp" )
			Preload("units\\critters\\Pig\\Pig_portrait.mdx");//call Preload( "units\\critters\\Pig\\Pig_portrait.mdx" )
			Preload("units\\Critters\\Pig\\Pig.blp");//call Preload( "units\\Critters\\Pig\\Pig.blp" )
			Preload("units\\creeps\\Owlbear\\Owlbear_portrait.mdx");//call Preload( "units\\creeps\\Owlbear\\Owlbear_portrait.mdx" )
			Preload("units\\Creeps\\Owlbear\\HeroForceOfNature.blp");//call Preload( "units\\Creeps\\Owlbear\\HeroForceOfNature.blp" )
			PreloadEnd(0.0);//call PreloadEnd( 0.0 )
		}//endfunction

	
	}
}

