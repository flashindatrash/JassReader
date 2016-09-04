using System;
using System.Text.RegularExpressions;
namespace Jass
{
	public struct LineParser
	{
		public Type type;
		public Regex instanceOf;
		public LineParser(Type type, Regex instanceOf)
		{
			this.type = type;
			this.instanceOf = instanceOf;
		}
	}
}

