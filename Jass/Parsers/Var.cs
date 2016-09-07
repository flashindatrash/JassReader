using System;
using System.Text.RegularExpressions;

namespace Jass
{
	public class Var : IParser
	{
		public const string Pattern = @"^(?<class>[\w_]+)\s*(?<name>[\w_]+)";

		private readonly Class jclass = new Class();
		private string name;

		public void Parse(string text)
		{
			Match match = Regex.Match(text, Pattern);
			jclass.Parse(match.Groups["class"].Value);
			name = match.Groups["name"].Value;
		}

		public override string ToString()
		{
			return jclass + " " + name;
		}
	}
}

