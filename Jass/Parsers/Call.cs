using System;
using System.Text.RegularExpressions;

namespace Jass
{
	public class Call : IParser
	{
		public const string Pattern = @"^call\s+(?<name>" + Name.Pattern + @")\s*\(\s*(?<args>" + Args.Pattern + @")\s*\)\r?$";

		private readonly Name name = new Name();
		private readonly Args args = new Args();

		public void Parse(string text)
		{
			Match match = Regex.Match(text, Pattern);
			name.Parse(match.Groups["name"].Value);
			args.Parse(match.Groups["args"].Value);
		}
		
		public override string ToString()
		{
			return name + "(" + args + ");";
		}

	}
}

