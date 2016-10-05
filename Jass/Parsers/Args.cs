using System;
using System.Text.RegularExpressions;

namespace Jass
{
	public class Args : IParser
	{
		public const string Pattern = @".*";

		private readonly DataArray values = new DataArray();

		public void Parse(string text)
		{
			string[] args = text.Trim().SplitComma();
			for (int i = 0; i < args.Length; i++)
			{
				values.Add<Eval>(args[i]);
			}
		}
		
		public override string ToString()
		{
			return values.Length >= 1 ? String.Join(", ", values) : "";
		}
	}
}