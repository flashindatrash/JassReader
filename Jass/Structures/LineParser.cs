using System;

namespace Jass
{
	public struct LineParser
	{
		public Type type;
		public string pattern;
		public LineParser(Type type, string pattern)
		{
			this.type = type;
			this.pattern = pattern;
		}
	}
}

