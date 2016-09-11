namespace Jass
{
	public class Extends : JassLine, IParser, ISkeep
	{
		public const string Pattern = @"^type\s+\w+\s+extends\s+\w+\r?$";

		public void Parse(string text)
		{

		}
	}
}

