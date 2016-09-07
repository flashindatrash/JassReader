using System;
using System.Text.RegularExpressions;

namespace Jass
{
	public class Comment : IParser
	{
		public const string Pattern = @"^(?<line>.*)(?<comment>//.*)";

		private string line; //все что угодно может быть до коммента, находится здесь
		private string comment;

		public string left
		{
			get
			{
				return line;
			}
		}

		public void Parse(string text)
		{
			Match match = Regex.Match(text, Pattern);
			line = match.Groups["line"].Value;
			comment = match.Groups["comment"].Value;
		}

		public override string ToString()
		{
			return comment;
		}
	}
}

