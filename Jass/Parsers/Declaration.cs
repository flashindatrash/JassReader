using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace Jass
{
	public class Declaration : JassLine, IParser
	{
		public const string Pattern = @"^(?:(?<attr>local|constant)\s+)*(?<class>" + Class.Pattern + @")\s+(?<array>array\s+)*(?<name>" + Name.Pattern + @")(?:\s*=\s*(?<eval>" + Eval.Pattern + @"))*\r?$";

		private string attr;

		private readonly Class jclass = new Class();
		private readonly Name name = new Name();
		private readonly Eval eval = new Eval();

		public bool isLocal
		{
			get
			{
				return attr == "local";
			}
		}

		public bool isConstant
		{
			get
			{
				return attr == "constant";
			}
		}

		public bool hasEval
		{
			set; get;
		}

		public bool isArray
		{
			set; get;
		}

		public void Parse(string text)
		{
			Match match = Regex.Match(text, Pattern);
			attr = match.Groups["attr"].Value;
			jclass.Parse(match.Groups["class"].Value);
			isArray = !String.IsNullOrEmpty(match.Groups["array"].Value.Trim());
			name.Parse(match.Groups["name"].Value);
			string e = match.Groups["eval"].Value.Trim();
			hasEval = !String.IsNullOrEmpty(e);
			if (hasEval)
			{
				eval.Parse(e);
			}
		}

		public override string ToString()
		{
			return (isLocal ? "" : "private ") + (isArray ? jclass + "[] " : jclass + " ") + name + (hasEval ? " = " + eval : "") + ";";
		}

	}
}

