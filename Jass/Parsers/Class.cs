using System;
using System.Text.RegularExpressions;

namespace Jass
{
	public enum ClassType
	{
		nothing
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
		
		public void Parse(string text)
		{
			name = text;
		}
		
		public override string ToString()
		{
			return Settings.ClassAssociation(name);
		}
	}
}

