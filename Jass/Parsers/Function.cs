using System;
using System.Text.RegularExpressions;

namespace Jass
{

	public class Function : IParser
	{

		public static readonly string Pattern = @"^(?<attr>function|native)\s+(?<name>[\w_]+)\s+takes\s+(?<takes>nothing|(?:\w+\s+\w+(?:,\s+)*)+)\s+returns\s+(?<returns>nothing|[\w_]+)";

		private string attr;
		private string name;
		private Takes takes = new Takes();
		private Class returns = new Class();

		public void Parse(string text)
		{
			Match match = Regex.Match(text, Pattern);
			attr = match.Groups["attr"].Value;
			name = match.Groups["name"].Value;
			takes.Parse(match.Groups["takes"].Value);
			returns.Parse(match.Groups["returns"].Value);
		}

		public override string ToString()
		{
			return "private " + returns + " " + name + "(" + takes + ")";
		}

	}
}

