using System;
using System.Collections.Generic;

namespace Jass
{
	public static class LinkStorage
	{

		public static Dictionary<string, LinkInfo> Globals = new Dictionary<string, LinkInfo>();
		public static Dictionary<string, LinkInfo> Native = new Dictionary<string, LinkInfo>();

		public static void Add(LinkInfo link)
		{
			if (!link.HasName) return;

			if (link.IsNativeFunction)
			{
				//добавить в нативный список функций
				Native[link.Name] = link;
			}
			else if (link.IsGlobal)
			{
				//добавить в глоабльный список
				Globals[link.Name] = link;
			}
		}
	}
}

