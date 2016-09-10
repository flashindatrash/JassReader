using System;
using System.Text.RegularExpressions;

namespace Jass
{

	public class Function : JassLine, IParser, ITabAfter
	{

		public const string Pattern = @"^(?:(?<constant>constant)\s+)*(?<attr>function|native)\s+(?<name>" + Name.Pattern + @")\s+takes\s+(?<takes>" + Takes.Pattern + @")\s+returns\s+(?<returns>" + Class.Pattern + @")\r?$";

		private string constant;
		private string attr;
		private readonly Name name = new Name();
		private readonly Takes takes = new Takes();
		private readonly Class returns = new Class();

		public bool isConstant
		{
			get { return !String.IsNullOrEmpty(constant); }
		}

		public bool isNative
		{
			get { return attr == "native"; }
		}

		public string callEngine
		{
			get {
				if (Settings.Debug)
				{
					if (returns.IsNothing) return "";
					else {
						return "return " + returns.DefaultValue + ";";
					}
				}

				return Settings.EngineClass + ".Test();"; 
			}
		}

		public void Parse(string text)
		{
			Match match = Regex.Match(text, Pattern);
			constant = match.Groups["constant"].Value;
			attr = match.Groups["attr"].Value;
			name.Parse(match.Groups["name"].Value);
			takes.Parse(match.Groups["takes"].Value);
			returns.Parse(match.Groups["returns"].Value);
		}

		public override string ToString()
		{
			string modifier = isNative ? "public" : "private";
			string stat = (isNative || isConstant) ? " static" : "";
			return modifier + stat + " " + returns + " " + name + "(" + takes + ") " + (isNative ? "{ " + callEngine + " }" : "{");
		}

		public int tabAfter
		{
			get { return isNative ? 0 : 1; }
		}

	}
}

