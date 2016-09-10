using System;
using System.Text.RegularExpressions;

namespace Jass
{
	public class EndIf : JassLine, IParser, ITabBefore
	{
		public const string Pattern = @"^endif\r?$";

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

