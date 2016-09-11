using System;
using System.Text.RegularExpressions;

namespace Jass
{
	public class Comment : JassLine, IParser
	{
		public const string Pattern = @"^(?<line>.*)(?<comment>//.*)\r?$";

		public string line; //все что угодно может быть до коммента, находится здесь

		public void Parse(string text)
		{
			Match match = Regex.Match(text, Pattern);
			line = match.Groups["line"].Value.Trim();
			Comment = match.Groups["comment"].Value;
			while (Regex.IsMatch(line, Pattern))
			{
				string nextComment = Comment;
				Parse(line);
				Comment += nextComment;
			}
		}

		public override string ToString()
		{
			return "";
		}
	}
}

