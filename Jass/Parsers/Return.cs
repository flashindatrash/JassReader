using System;
using System.Text.RegularExpressions;

namespace Jass
{
	public class Return : JassLine, IParser
	{
		public const string Pattern = @"^return\s*(?<returns>.*)\r?$";

		private string returns;

		public void Parse(string text)
		{
			Match match = Regex.Match(text, Pattern);
			returns = match.Groups["returns"].Value.Trim();
		}

		public override string ToString()
		{
			return "return" + (returns.Length>0 ? " " + returns : "") + ";";
		}
	}
}

