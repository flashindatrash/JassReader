using System;

namespace Jass {

	public class CreditsBlizzard {

		private void PreloadFiles() {
Preload("buildings\\other\\GoldMine\\GoldMine.mdx");
Preload("Textures\\Goldmine.blp");
Preload("Textures\\Chest.blp");
Preload("Textures\\Dust3.blp");
Preload("Textures\\Base.blp");
Preload("ReplaceableTextures\\Splats\\GoldmineUberSplat.blp");
Preload("Textures\\star5tga.blp");
Preload("units\\human\\Knight\\Knight.mdx");
Preload("Textures\\Dust3x.blp");
Preload("Textures\\Knight.blp");
Preload("units\\human\\Knight\\Knight_portrait.mdx");
Preload("units\\nightelf\\Furion\\Furion_portrait.mdx");
Preload("units\\NightElf\\Furion\\Furion.blp");
PreloadEnd(1.0);
}
private void SetUnitUserData(unit whichUnit, int data);
private player Player(int number);
Trace("minor creep attack\n");

	
	}
}

