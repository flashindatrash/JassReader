using System;
using System.Collections.Generic;

namespace Jass
{
	public static class LinkStorage
	{

		public static Dictionary<string, Link> Globals = new Dictionary<string, Link>();
		public static Dictionary<string, Link> Native = new Dictionary<string, Link>();

		public static void Add(Link link)
		{
			if (!link.HasName) return;

			if (link.IsNativeFunction)
			{
				if (Native.ContainsKey(link.Name))
				{
					throw new JassException(string.Format("double alloc native func {0}", link.Name));
				}

				//добавить в нативный список функций
				Native[link.Name] = link;
			}
			else if (link.IsGlobal)
			{
				if (Globals.ContainsKey(link.Name))
				{
					Log.Add(string.Format("double alloc global var {0}", link.Name));
				}

				//добавить в глоабльный список
				Globals[link.Name] = link;
			}
		}
	}
}

