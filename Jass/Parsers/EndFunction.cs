using System;
using System.Text.RegularExpressions;

namespace Jass
{
	public class EndFunction : JassLine, IParser, ITabBefore
	{
		public const string Pattern = @"^endfunction\r?$";

		public void Parse(string text)
		{

		}
		
		public override string ToString()
		{
			return "}";
		}

		public int tabBefore
		{
			get { return 1; }
		}

	}
}

