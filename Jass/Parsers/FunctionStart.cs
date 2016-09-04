using System;
using System.Text.RegularExpressions;

namespace Jass
{

	public class FunctionStart : IParser
	{
		
		public static readonly Regex InstanceOf = new Regex(@"^(function|native)\s+([\w_]+)\s+takes\s+(nothing|(?:\w+\s+\w+(?:,\s+)*)+)\s+returns\s+(nothing|[\w_]+)");

		private string attribute;
		private string name;
		private string takes;
		private string returns;

		public void Parse(string text)
		{
			Match match = InstanceOf.Match(text);
			attribute = match.Groups[1].Value;
			name = match.Groups[2].Value;
			takes = match.Groups[3].Value;
			returns = match.Groups[4].Value;
		}

		public string ToString(ResultFormat format)
		{
			switch (format)
			{
				case ResultFormat.CSharp:
				return "private " + returns + " " + name + "(" + takes + ") {}";
				default:
					throw new JassException(string.Format("The {0} format string is not supported", format));
			}
		}

	}
}

