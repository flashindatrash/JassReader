using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace Jass
{
	public class Declaration : JassLine, IParser, IName
	{
		public const string Pattern = @"^(?:(?<attr>local|constant)\s+)*(?<class>" + Class.Pattern + @")\s+(?<array>array\s+)*(?<name>" + Name.Pattern + @")(?:\s*=\s*(?<eval>" + Eval.Pattern + @"))*\r?$";

		private string attr;

		private readonly Class jclass = new Class();
		private readonly Name name = new Name();
		private readonly Eval eval = new Eval();

		public bool IsLocal
		{
			get
			{
				return attr == "local";
			}
		}

		public bool IsConstant
		{
			get
			{
				return attr == "constant";
			}
		}

		public bool HasEval
		{
			set; get;
		}

		public bool IsArray
		{
			set; get;
		}

		public void Parse(string text)
		{
			Match match = Regex.Match(text, Pattern);
			attr = match.Groups["attr"].Value;
			jclass.Parse(match.Groups["class"].Value);
			IsArray = !String.IsNullOrEmpty(match.Groups["array"].Value.Trim());
			name.Parse(match.Groups["name"].Value);
			string e = match.Groups["eval"].Value.Trim();
			HasEval = !String.IsNullOrEmpty(e);
			if (HasEval)
			{
				eval.Parse(e);
			}
		}

		public string GetName()
		{
			return name.ToString();
		}

		public override string ToString()
		{
			return (IsLocal ? "" : IsGlobal ? "public " : "private ") + 
				(IsConstant ? "const " : IsGlobal ? "static " : "") +
				(IsArray ? jclass + "[] " : jclass + " ") + 
				GetName() + 
				(HasEval ? " = " + eval : "") + ";";
		}

	}
}

