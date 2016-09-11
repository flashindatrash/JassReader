using System;
using System.Collections.Generic;

namespace Jass {

	public class WarChasersPld {

		private void PreloadFiles() {//function PreloadFiles takes nothing returns nothing
			Preload("Splats\\SplatData.slk");//call Preload( "Splats\\SplatData.slk" )
			Preload("ReplaceableTextures\\Splats\\Splat01Mature.blp");//call Preload( "ReplaceableTextures\\Splats\\Splat01Mature.blp" )
			Preload("UI\\TipStrings.txt");//call Preload( "UI\\TipStrings.txt" )
			Preload("UI\\HelpStrings.txt");//call Preload( "UI\\HelpStrings.txt" )
			Preload("UI\\Widgets\\Glues\\GlueScreen-PullDown-Arrow.blp");//call Preload( "UI\\Widgets\\Glues\\GlueScreen-PullDown-Arrow.blp" )
			Preload("ReplaceableTextures\\TeamColor\\TeamColor02.blp");//call Preload( "ReplaceableTextures\\TeamColor\\TeamColor02.blp" )
			Preload("ReplaceableTextures\\TeamColor\\TeamColor03.blp");//call Preload( "ReplaceableTextures\\TeamColor\\TeamColor03.blp" )
			Preload("ReplaceableTextures\\TeamColor\\TeamColor04.blp");//call Preload( "ReplaceableTextures\\TeamColor\\TeamColor04.blp" )
			Preload("ReplaceableTextures\\TeamColor\\TeamColor07.blp");//call Preload( "ReplaceableTextures\\TeamColor\\TeamColor07.blp" )
			Preload("ReplaceableTextures\\TeamColor\\TeamColor08.blp");//call Preload( "ReplaceableTextures\\TeamColor\\TeamColor08.blp" )
			Preload("ReplaceableTextures\\TeamColor\\TeamColor09.blp");//call Preload( "ReplaceableTextures\\TeamColor\\TeamColor09.blp" )
			Preload("ReplaceableTextures\\TeamColor\\TeamColor10.blp");//call Preload( "ReplaceableTextures\\TeamColor\\TeamColor10.blp" )
			Preload("ReplaceableTextures\\TeamColor\\TeamColor13.blp");//call Preload( "ReplaceableTextures\\TeamColor\\TeamColor13.blp" )
			Preload("ReplaceableTextures\\TeamColor\\TeamColor14.blp");//call Preload( "ReplaceableTextures\\TeamColor\\TeamColor14.blp" )
			Preload("war3mapMap.blp");//call Preload( "war3mapMap.blp" )
			Preload("UI\\Minimap\\minimap-gold.blp");//call Preload( "UI\\Minimap\\minimap-gold.blp" )
			Preload("UI\\Minimap\\minimap-neutralbuilding.blp");//call Preload( "UI\\Minimap\\minimap-neutralbuilding.blp" )
			Preload("UI\\Minimap\\MinimapIconCircleOfPower.blp");//call Preload( "UI\\Minimap\\MinimapIconCircleOfPower.blp" )
			Preload("UI\\Minimap\\minimap-hero.blp");//call Preload( "UI\\Minimap\\minimap-hero.blp" )
			Preload("Sound\\Ambient\\DoodadEffects\\CityScapeMagicRunesLoop1.wav");//call Preload( "Sound\\Ambient\\DoodadEffects\\CityScapeMagicRunesLoop1.wav" )
			Preload("Abilities\\Spells\\Other\\GeneralAuraTarget\\GeneralAuraTarget.mdl");//call Preload( "Abilities\\Spells\\Other\\GeneralAuraTarget\\GeneralAuraTarget.mdl" )
			Preload("Abilities\\Spells\\Other\\GeneralAuraTarget\\GeneralAuraTarget.mdx");//call Preload( "Abilities\\Spells\\Other\\GeneralAuraTarget\\GeneralAuraTarget.mdx" )
			Preload("Abilities\\Weapons\\SludgeMissile\\SludgeMissile.mdl");//call Preload( "Abilities\\Weapons\\SludgeMissile\\SludgeMissile.mdl" )
			Preload("Abilities\\Weapons\\SludgeMissile\\SludgeMissile.mdx");//call Preload( "Abilities\\Weapons\\SludgeMissile\\SludgeMissile.mdx" )
			Preload("Sound\\Buildings\\Fire\\OrcHumanMediumBuildingFire1.wav");//call Preload( "Sound\\Buildings\\Fire\\OrcHumanMediumBuildingFire1.wav" )
			Preload("Units\\Critters\\OrcJuggernaught\\OrcJuggernaught.mdl");//call Preload( "Units\\Critters\\OrcJuggernaught\\OrcJuggernaught.mdl" )
			Preload("Units\\Critters\\OrcJuggernaught\\OrcJuggernaught.mdx");//call Preload( "Units\\Critters\\OrcJuggernaught\\OrcJuggernaught.mdx" )
			Preload("units\\Critters\\OrcJuggernaught\\Orc_juggernaught.blp");//call Preload( "units\\Critters\\OrcJuggernaught\\Orc_juggernaught.blp" )
			Preload("Abilities\\Spells\\Undead\\FrostArmor\\FrostArmorTarget.mdl");//call Preload( "Abilities\\Spells\\Undead\\FrostArmor\\FrostArmorTarget.mdl" )
			Preload("Abilities\\Spells\\Undead\\FrostArmor\\FrostArmorTarget.mdx");//call Preload( "Abilities\\Spells\\Undead\\FrostArmor\\FrostArmorTarget.mdx" )
			Preload("Textures\\Ghost2.blp");//call Preload( "Textures\\Ghost2.blp" )
			Preload("units\\creeps\\Murloc\\Murloc.mdl");//call Preload( "units\\creeps\\Murloc\\Murloc.mdl" )
			Preload("units\\creeps\\Murloc\\Murloc.mdx");//call Preload( "units\\creeps\\Murloc\\Murloc.mdx" )
			Preload("units\\Creeps\\Murloc\\Murloc.blp");//call Preload( "units\\Creeps\\Murloc\\Murloc.blp" )
			Preload("units\\creeps\\GnollArcher\\GnollArcher.mdl");//call Preload( "units\\creeps\\GnollArcher\\GnollArcher.mdl" )
			Preload("units\\creeps\\GnollArcher\\GnollArcher.mdx");//call Preload( "units\\creeps\\GnollArcher\\GnollArcher.mdx" )
			Preload("Textures\\gnoll.blp");//call Preload( "Textures\\gnoll.blp" )
			Preload("units\\creeps\\Satyr\\Satyr.mdl");//call Preload( "units\\creeps\\Satyr\\Satyr.mdl" )
			Preload("units\\creeps\\Satyr\\Satyr.mdx");//call Preload( "units\\creeps\\Satyr\\Satyr.mdx" )
			Preload("units\\undead\\Ghoul\\Ghoul.mdl");//call Preload( "units\\undead\\Ghoul\\Ghoul.mdl" )
			Preload("units\\undead\\Ghoul\\Ghoul.mdx");//call Preload( "units\\undead\\Ghoul\\Ghoul.mdx" )
			Preload("units\\Undead\\Ghoul\\Ghoul.blp");//call Preload( "units\\Undead\\Ghoul\\Ghoul.blp" )
			Preload("Textures\\Peasant.blp");//call Preload( "Textures\\Peasant.blp" )
			Preload("units\\creeps\\MurlocWarrior\\MurlocWarrior.mdl");//call Preload( "units\\creeps\\MurlocWarrior\\MurlocWarrior.mdl" )
			Preload("units\\creeps\\MurlocWarrior\\MurlocWarrior.mdx");//call Preload( "units\\creeps\\MurlocWarrior\\MurlocWarrior.mdx" )
			Preload("units\\Creeps\\MurlocWarrior\\MurlocWarrior.blp");//call Preload( "units\\Creeps\\MurlocWarrior\\MurlocWarrior.blp" )
			Preload("units\\creeps\\CorruptedEnt\\CorruptedEnt.mdl");//call Preload( "units\\creeps\\CorruptedEnt\\CorruptedEnt.mdl" )
			Preload("units\\creeps\\CorruptedEnt\\CorruptedEnt.mdx");//call Preload( "units\\creeps\\CorruptedEnt\\CorruptedEnt.mdx" )
			Preload("units\\Creeps\\CorruptedEnt\\CorruptedEnt.blp");//call Preload( "units\\Creeps\\CorruptedEnt\\CorruptedEnt.blp" )
			Preload("units\\creeps\\IceTrollShadowPriest\\IceTrollShadowPriest.mdl");//call Preload( "units\\creeps\\IceTrollShadowPriest\\IceTrollShadowPriest.mdl" )
			Preload("units\\creeps\\IceTrollShadowPriest\\IceTrollShadowPriest.mdx");//call Preload( "units\\creeps\\IceTrollShadowPriest\\IceTrollShadowPriest.mdx" )
			Preload("units\\Creeps\\IceTrollShadowPriest\\IceTrollShadowPriest.blp");//call Preload( "units\\Creeps\\IceTrollShadowPriest\\IceTrollShadowPriest.blp" )
			Preload("units\\demon\\felhound\\felhound.mdl");//call Preload( "units\\demon\\felhound\\felhound.mdl" )
			Preload("units\\demon\\felhound\\felhound.mdx");//call Preload( "units\\demon\\felhound\\felhound.mdx" )
			Preload("units\\Demon\\felhound\\FelHound.blp");//call Preload( "units\\Demon\\felhound\\FelHound.blp" )
			PreloadEnd(5.0);//call PreloadEnd( 5.0 )
		}//endfunction

	
	}
}

