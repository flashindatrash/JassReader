using System;

namespace Jass
{
	public struct LineInfo
	{
		public Type type;
		public string pattern;
		public LineInfo(Type type, string pattern)
		{
			this.type = type;
			this.pattern = pattern;
		}
	}
}

