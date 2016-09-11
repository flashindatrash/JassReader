using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace Jass
{
	public class Args : IParser
	{
		public const string Pattern = @".*";

		private readonly List<Value> values = new List<Value>();

		public void Parse(string text)
		{
			string[] args = text.Trim().SplitComma();
			for (int i = 0; i < args.Length; i++)
			{
				values.Add(new Value(args[i]));
			}
		}
		
		public override string ToString()
		{
			return values.Count >= 1 ? String.Join(", ", values) : "";
		}
	}
}