using System;
using System.Text.RegularExpressions;

namespace Jass
{
	public class Args : IParser
	{
		private string args;

		public void Parse(string text)
		{
			args = text;
		}
		
		public override string ToString()
		{
			return args;
		}
	}
}