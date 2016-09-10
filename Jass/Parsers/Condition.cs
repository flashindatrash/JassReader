using System;
using System.Text.RegularExpressions;

namespace Jass
{
	public class Condition : IParser
	{
		public const string Pattern = @".*";

		private string predicate;

		public void Parse(string text)
		{
			predicate = text;
			predicate = predicate.Replace("or", "||");
			predicate = predicate.Replace("and", "&&");
		}

		public override string ToString()
		{
			return predicate;
		}
	}
}

