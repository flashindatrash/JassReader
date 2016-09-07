using System;
using System.Text.RegularExpressions;

namespace Jass
{
	public class Args : IParser
	{
		public const string Pattern = @"[\w\s]*";

		private string args;

		public void Parse(string text)
		{
			args = text;
		}
		
		public override string ToString()
		{
			return args;
		}
	}
}