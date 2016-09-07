using System;

namespace Jass
{
	public struct LineData
	{
		public Type type;
		public string pattern;
		public LineData(Type type, string pattern)
		{
			this.type = type;
			this.pattern = pattern;
		}
	}
}

