using System;
namespace Jass
{
	public class Loop : JassLine, IParser, ITabAfter
	{
		public const string Pattern = @"^loop\r?$";

		public void Parse(string text)
		{

		}

		public override string ToString()
		{
			return "while (true) {";
		}

		public int tabAfter
		{
			get { return 1; }
		}
	}
}

