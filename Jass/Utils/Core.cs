using System;
using System.Collections.Generic;

namespace Jass
{

	public static class Core
	{

		public static List<LineInfo> Parsers = new List<LineInfo>();

		public static void RegisterParser(LineInfo info)
		{
			Parsers.Add(info);
		}

	}

}