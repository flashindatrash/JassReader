using System;
using System.Text.RegularExpressions;

namespace Jass
{
	public enum ClassType
	{
		nothing,
		integer
	}

	public class Class : IParser
	{

		public const string Pattern = @"nothing|[\w_]+";

		public bool isNothing
		{
			get
			{
				return jname == ClassType.nothing.ToString();
			}
		}

		private string jname, name;
		
		public void Parse(string text)
		{
			jname = name = text;
			if (Core.ClassAssociation.ContainsKey(jname)) {
				name = Core.ClassAssociation[jname];
			}
		}
		
		public override string ToString()
		{
			return name;
		}
	}
}

