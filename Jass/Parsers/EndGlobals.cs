namespace Jass
{
	public class EndGlobals : JassLine, IParser
	{
		public const string Pattern = @"^endglobals\r?$";

		public void Parse(string text)
		{

		}

		public override string ToString()
		{
			return "";
		}

	}
}

