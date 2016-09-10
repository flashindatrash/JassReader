namespace Jass
{
	public class Globals : JassLine, IParser
	{
		public const string Pattern = @"^globals\r?$";

		public void Parse(string text)
		{

		}

		public override string ToString()
		{
			return "";
		}

	}
}

