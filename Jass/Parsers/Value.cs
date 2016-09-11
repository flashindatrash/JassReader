using System;
using System.Text.RegularExpressions;

namespace Jass
{
	public class Value : IParser
	{
		public const string Pattern = @".*";

		private string value;

		public Value(string text)
		{
			Parse(text);
		}

		public void Parse(string text)
		{
			value = text.Trim();
		}

		public override string ToString()
		{
			if (LinkStorage.Globals.ContainsKey(value))
			{
				LinkInfo link = LinkStorage.Globals[value];
				return link.File.Name + "." + value;
			}
			return value;
		}
	}
}