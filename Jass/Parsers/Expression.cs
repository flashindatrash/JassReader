using System;
using System.Text.RegularExpressions;

namespace Jass
{
	public class Expression : IParser
	{
		public const string Pattern = @".*";

		private string condition;

		public void Parse(string text)
		{
			condition = text;
			condition = condition.Replace(" or ", " || ");
			condition = condition.Replace(" and ", " && ");
			condition = condition.Replace("not ", "!");
		}

		public override string ToString()
		{
			return condition;
		}
	}
}

