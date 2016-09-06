using System;
using System.Text.RegularExpressions;

namespace Jass
{
	public class Takes : IParser
	{
		private string[] takes;
		
		public void Parse(string text)
		{
			takes = text.SplitComma();
		}
		
		public override string ToString()
		{
			return takes.ToString();
		}
	}
}

