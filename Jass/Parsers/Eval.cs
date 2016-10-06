using System;
using System.Text.RegularExpressions;

namespace Jass
{
	public class Eval : IParser
	{
		public const string Pattern = @".*";

		private string eval;

		public bool IsNone
		{
			get
			{
				return String.IsNullOrEmpty(eval);
			}
		}

		public void Parse(string text)
		{
			eval = text.Trim();
			eval = eval.Replace(" or ", " || ");
			eval = eval.Replace(")or ", ") || ");
			eval = eval.Replace(" or(", " || (");
			eval = eval.Replace(")or(", ") || (");
			eval = eval.Replace(" and ", " && ");
			eval = eval.Replace(")and ", ") && ");
			eval = eval.Replace("and(", " && (");
			eval = eval.Replace(")and(", ") && (");
			eval = eval.Replace("not ", "!");
			eval = Regex.Replace(eval, Integer.Pattern, delegate (Match match)
			{
				return match.ToString().ToInt().ToString();
			});
		}

		public override string ToString()
		{
			if (LinkStorage.Globals.ContainsKey(eval))
			{
				Link link = LinkStorage.Globals[eval];
				return link.File.Name + "." + eval;
			}
			return eval;
		}
	}
}

