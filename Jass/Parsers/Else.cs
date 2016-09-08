using System;
using System.Text.RegularExpressions;

namespace Jass
{
	public class Else : IParser
	{
		public const string Pattern = @"^else\r?$";

		public void Parse(string text)
		{
			
		}

		public override string ToString()
		{
			return "} else {";
		}

	}
}

