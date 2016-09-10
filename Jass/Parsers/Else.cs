using System;
using System.Text.RegularExpressions;

namespace Jass
{
	public class Else : JassLine, IParser, ITabBefore, ITabAfter
	{
		public const string Pattern = @"^else\r?$";

		public void Parse(string text)
		{
			
		}

		public override string ToString()
		{
			return "} else {";
		}

		public int tabBefore
		{
			get { return 1; }
		}

		public int tabAfter
		{
			get { return 1; }
		}
	}
}

