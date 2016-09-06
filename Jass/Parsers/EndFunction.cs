using System;
using System.Text.RegularExpressions;

namespace Jass
{
	public class EndFunction : IParser
	{
		public static readonly string Pattern = @"^endfunction";

		public void Parse(string text)
		{

		}
		
		public override string ToString()
		{
			return "}";
		}
	}
}

