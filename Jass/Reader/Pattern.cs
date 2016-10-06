using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Jass
{
	public class Pattern
	{
		private static List<Pattern> Parsers = new List<Pattern>();

		public static void RegisterParser(Pattern parser)
		{
			Parsers.Add(parser);
		}

		public static Pattern GetParser(string text)
		{
			return GetPattern(ref Parsers, text);
		}

		private static List<Pattern> Types = new List<Pattern>();

		public static void RegisterType(Pattern type)
		{
			Types.Add(type);
		}

		public static Pattern GetType(string text)
		{
			return GetPattern(ref Types, text);
		}

		private static Pattern GetPattern(ref List<Pattern> list, string text)
		{
			foreach (Pattern parser in list)
			{
				if (Regex.IsMatch(text, parser.pattern))
				{
					return parser;
				}
			}
			return null;
		}

		public Type type;
		public string pattern;

		public Pattern(Type type, string pattern)
		{
			this.type = type;
			this.pattern = pattern;
		}
	}
}

