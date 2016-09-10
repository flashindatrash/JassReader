using System;
using System.Text.RegularExpressions;

namespace Jass
{
	public class Call : JassLine, IParser
	{
		public const string Pattern = @"^(?<debug>debug\s+)*call\s+(?<name>" + Name.Pattern + @")\s*\(\s*(?<args>" + Args.Pattern + @")\s*\)\r?$";

		public bool isDebug
		{
			get { return !String.IsNullOrEmpty(debug); }
		}

		private string debug;
		private readonly Name name = new Name();
		private readonly Args args = new Args();

		public void Parse(string text)
		{
			Match match = Regex.Match(text, Pattern);
			debug = match.Groups["debug"].Value.Trim();
			name.Parse(match.Groups["name"].Value);
			args.Parse(match.Groups["args"].Value);
		}
		
		public override string ToString()
		{
			return name + "(" + args + ");";
		}

	}
}

