using System;
namespace Jass
{
	public class EndLoop : JassLine, IParser, ITabBefore
	{
		public const string Pattern = @"^endloop\r?$";

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

