using System;
using System.Collections.Generic;

namespace Jass
{

	public static class Core
	{

		public static List<LineData> Parsers = new List<LineData>();

		public static void RegisterParser(Type type, string pattern)
		{
			Console.WriteLine(string.Format("Register Class: {0}", type.ToString()));
			Parsers.Add(new LineData(type, pattern));
		}

		public static Dictionary<string, string> ClassAssociation = new Dictionary<string, string>();

		public static void RegisterClass(ClassType type, string name) {
			ClassAssociation[type.ToString()] = name;
		}

	}

}