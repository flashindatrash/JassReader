using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Jass
{
	public class Takes : IParser
	{
		public const string Pattern = @".+";

		private readonly List<Var> takes = new List<Var>();
		
		public void Parse(string text)
		{

			if (String.IsNullOrEmpty(text.Trim()))
			{
				return;
			}

			string[] arr = text.SplitComma();
			int length = (arr.Length == 1 && arr[0] == ClassType.nothing.ToString()) ? 0 : arr.Length;

			for (int i = 0; i < length; i++)
			{
				var v = new Var();
				v.Parse(arr[i].Trim());
				takes.Add(v);
			}
		}
		
		public override string ToString()
		{
			return String.Join(", ", takes);
		}
	}
}

