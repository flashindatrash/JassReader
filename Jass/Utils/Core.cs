using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Jass
{

	public static class Core
	{

		public static List<LineParser> Parsers = new List<LineParser>();

		public static void RegisterParser(Type type, Regex instanceOf)
		{
			Console.WriteLine(string.Format("Register Class: {0}", type.ToString()));
			Parsers.Add(new LineParser(type, instanceOf));
		}

	}

}