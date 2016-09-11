using System;
using System.Text.RegularExpressions;

namespace Jass
{
	public enum ClassType
	{
		nothing,
		integer,
		boolean,
		real,
		unit
	}

	public class Class : IParser
	{

		public const string Pattern = @"nothing|[\w_]+";

		public bool IsNothing
		{
			get
			{
				return name == ClassType.nothing.ToString();
			}
		}

		private string name;
		private ClassInfo info;
		
		public void Parse(string text)
		{
			name = text;
			if (Core.ClassAssociation.ContainsKey(name)) {
				info = Core.ClassAssociation[name];
			}
		}
		
		public override string ToString()
		{
			return info.Name ?? name;
		}
	}
}

