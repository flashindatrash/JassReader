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
			eval = text;
			eval = eval.Replace(" or ", " || ");
			eval = eval.Replace(")or ", ") || ");
			eval = eval.Replace(" or(", " || (");
			eval = eval.Replace(")or(", ") || (");
			eval = eval.Replace(" and ", " && ");
			eval = eval.Replace(")and ", ") && ");
			eval = eval.Replace("and(", " && (");
			eval = eval.Replace(")and(", ") && (");
			eval = eval.Replace("not ", "!");
			eval = Regex.Replace(eval, Id.Pattern, delegate (Match match)
			{
				return match.ToString().ToInt().ToString();
			});
		}

		public override string ToString()
		{
			return eval;
		}
	}
}

