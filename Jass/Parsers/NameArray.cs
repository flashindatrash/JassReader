using System;
namespace Jass
{
	public class NameArray : IParser
	{
		public const string Pattern = @"[\w\d_\[\]]+";

		private string name;

		public void Parse(string text)
		{
			name = text;
		}

		public override string ToString()
		{
			return name;
		}
	}
}

