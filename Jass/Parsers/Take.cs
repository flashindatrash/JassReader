using System;
using System.Text.RegularExpressions;

namespace Jass
{
	public class Take : IParser
	{
		public const string Pattern = @"^(?<class>" + Class.Pattern + @")\s*(?<name>" + Name.Pattern + @")";

		private readonly Class jclass = new Class();
		private readonly Name name = new Name();

		public void Parse(string text)
		{
			Match match = Regex.Match(text, Pattern);
			jclass.Parse(match.Groups["class"].Value);
			name.Parse(match.Groups["name"].Value);
		}

		public override string ToString()
		{
			return jclass + " " + name;
		}
	}
}

