using System;
using System.Collections.Generic;

namespace Jass {

	public class Human05InterludePld {

		private void PreloadFiles() {//function PreloadFiles takes nothing returns nothing
			Preload("ReplaceableTextures\\CameraMasks\\Black_mask.blp");//call Preload( "ReplaceableTextures\\CameraMasks\\Black_mask.blp" )
			Preload("Splats\\SplatData.slk");//call Preload( "Splats\\SplatData.slk" )
			Preload("ReplaceableTextures\\Splats\\Splat01Mature.blp");//call Preload( "ReplaceableTextures\\Splats\\Splat01Mature.blp" )
			Preload("ReplaceableTextures\\Selection\\SelectionCircleSmall.blp");//call Preload( "ReplaceableTextures\\Selection\\SelectionCircleSmall.blp" )
			Preload("ReplaceableTextures\\Selection\\SelectionCircleMed.blp");//call Preload( "ReplaceableTextures\\Selection\\SelectionCircleMed.blp" )
			Preload("Environment\\Sky\\LordaeronSummerSky\\LordaeronSummerSky.mdx");//call Preload( "Environment\\Sky\\LordaeronSummerSky\\LordaeronSummerSky.mdx" )
			Preload("environment\\Sky\\LordaeronSummerSky\\LordaeronSummerSky.blp");//call Preload( "environment\\Sky\\LordaeronSummerSky\\LordaeronSummerSky.blp" )
			Preload("UI\\TipStrings.txt");//call Preload( "UI\\TipStrings.txt" )
			Preload("UI\\Widgets\\EscMenu\\Human\\human-options-button-border-up.blp");//call Preload( "UI\\Widgets\\EscMenu\\Human\\human-options-button-border-up.blp" )
			Preload("UI\\Widgets\\EscMenu\\Human\\human-options-button-border-down.blp");//call Preload( "UI\\Widgets\\EscMenu\\Human\\human-options-button-border-down.blp" )
			Preload("UI\\Widgets\\EscMenu\\Human\\human-options-button-background-disabled.blp");//call Preload( "UI\\Widgets\\EscMenu\\Human\\human-options-button-background-disabled.blp" )
			Preload("UI\\Widgets\\EscMenu\\Human\\editbox-background.blp");//call Preload( "UI\\Widgets\\EscMenu\\Human\\editbox-background.blp" )
			Preload("UI\\Widgets\\EscMenu\\Human\\editbox-border.blp");//call Preload( "UI\\Widgets\\EscMenu\\Human\\editbox-border.blp" )
			Preload("UI\\Widgets\\EscMenu\\Human\\slider-background.blp");//call Preload( "UI\\Widgets\\EscMenu\\Human\\slider-background.blp" )
			Preload("UI\\Widgets\\EscMenu\\Human\\slider-border.blp");//call Preload( "UI\\Widgets\\EscMenu\\Human\\slider-border.blp" )
			Preload("UI\\Widgets\\EscMenu\\Human\\slider-knob.blp");//call Preload( "UI\\Widgets\\EscMenu\\Human\\slider-knob.blp" )
			Preload("UI\\HelpStrings.txt");//call Preload( "UI\\HelpStrings.txt" )
			Preload("UI\\Widgets\\EscMenu\\Human\\slider-borderdisabled.blp");//call Preload( "UI\\Widgets\\EscMenu\\Human\\slider-borderdisabled.blp" )
			Preload("UI\\Widgets\\EscMenu\\Human\\slider-knobdisabled.blp");//call Preload( "UI\\Widgets\\EscMenu\\Human\\slider-knobdisabled.blp" )
			Preload("UI\\Widgets\\EscMenu\\Human\\checkbox-background.blp");//call Preload( "UI\\Widgets\\EscMenu\\Human\\checkbox-background.blp" )
			Preload("UI\\Widgets\\EscMenu\\Human\\checkbox-depressed.blp");//call Preload( "UI\\Widgets\\EscMenu\\Human\\checkbox-depressed.blp" )
			Preload("UI\\Widgets\\EscMenu\\Human\\checkbox-background-disabled.blp");//call Preload( "UI\\Widgets\\EscMenu\\Human\\checkbox-background-disabled.blp" )
			Preload("UI\\Widgets\\Glues\\GlueScreen-PullDown-Arrow.blp");//call Preload( "UI\\Widgets\\Glues\\GlueScreen-PullDown-Arrow.blp" )
			Preload("UI\\Widgets\\EscMenu\\Human\\alliance-gold.blp");//call Preload( "UI\\Widgets\\EscMenu\\Human\\alliance-gold.blp" )
			Preload("UI\\Widgets\\EscMenu\\Human\\alliance-lumber.blp");//call Preload( "UI\\Widgets\\EscMenu\\Human\\alliance-lumber.blp" )
			Preload("war3mapMap.blp");//call Preload( "war3mapMap.blp" )
			Preload("UI\\Minimap\\minimap-gold.blp");//call Preload( "UI\\Minimap\\minimap-gold.blp" )
			Preload("UI\\Minimap\\minimap-neutralbuilding.blp");//call Preload( "UI\\Minimap\\minimap-neutralbuilding.blp" )
			Preload("UI\\Minimap\\MinimapIconCircleOfPower.blp");//call Preload( "UI\\Minimap\\MinimapIconCircleOfPower.blp" )
			Preload("UI\\Minimap\\minimap-hero.blp");//call Preload( "UI\\Minimap\\minimap-hero.blp" )
			Preload("Sound\\Dialogue\\HumanCampaign\\Human05Interlude\\H05Medivh36.mp3");//call Preload( "Sound\\Dialogue\\HumanCampaign\\Human05Interlude\\H05Medivh36.mp3" )
			Preload("units\\creeps\\Medivh\\Medivh_portrait.mdx");//call Preload( "units\\creeps\\Medivh\\Medivh_portrait.mdx" )
			Preload("Sound\\Dialogue\\HumanCampaign\\Human05Interlude\\H05Arthas37.mp3");//call Preload( "Sound\\Dialogue\\HumanCampaign\\Human05Interlude\\H05Arthas37.mp3" )
			Preload("units\\human\\Arthas\\Arthas_portrait.mdx");//call Preload( "units\\human\\Arthas\\Arthas_portrait.mdx" )
			Preload("Sound\\Dialogue\\HumanCampaign\\Human05Interlude\\H05Medivh38.mp3");//call Preload( "Sound\\Dialogue\\HumanCampaign\\Human05Interlude\\H05Medivh38.mp3" )
			Preload("Sound\\Dialogue\\HumanCampaign\\Human05Interlude\\H05Arthas39.mp3");//call Preload( "Sound\\Dialogue\\HumanCampaign\\Human05Interlude\\H05Arthas39.mp3" )
			Preload("Sound\\Dialogue\\HumanCampaign\\Human05Interlude\\H05Medivh40.mp3");//call Preload( "Sound\\Dialogue\\HumanCampaign\\Human05Interlude\\H05Medivh40.mp3" )
			Preload("Sound\\Dialogue\\HumanCampaign\\Human05Interlude\\H05Jaina41.mp3");//call Preload( "Sound\\Dialogue\\HumanCampaign\\Human05Interlude\\H05Jaina41.mp3" )
			Preload("units\\human\\Jaina\\Jaina_portrait.mdx");//call Preload( "units\\human\\Jaina\\Jaina_portrait.mdx" )
			Preload("Sound\\Dialogue\\HumanCampaign\\Human05Interlude\\H05Arthas42.mp3");//call Preload( "Sound\\Dialogue\\HumanCampaign\\Human05Interlude\\H05Arthas42.mp3" )
			Preload("Sound\\Dialogue\\HumanCampaign\\Human05Interlude\\H05Jaina43.mp3");//call Preload( "Sound\\Dialogue\\HumanCampaign\\Human05Interlude\\H05Jaina43.mp3" )
			Preload("Sound\\Dialogue\\HumanCampaign\\Human05Interlude\\H05Arthas44.mp3");//call Preload( "Sound\\Dialogue\\HumanCampaign\\Human05Interlude\\H05Arthas44.mp3" )
			PreloadEnd(5.00);//call PreloadEnd( 5.00 )
		}//endfunction

	
	}
}

