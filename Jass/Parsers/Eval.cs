using System;
using System.Text.RegularExpressions;

namespace Jass
{
	public class Eval : IParser
	{
		public const string Pattern = @".*";

		private string eval;

		public void Parse(string text)
		{
			eval = text;
		}

		public override string ToString()
		{
			return eval;
		}
	}
}

