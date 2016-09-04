using System;
using System.Text.RegularExpressions;
namespace Jass
{
	public struct LineStruct
	{
		public Type type;
		public Regex instanceOf;
		public LineStruct(Type type, Regex instanceOf)
		{
			this.type = type;
			this.instanceOf = instanceOf;
		}
	}
}

