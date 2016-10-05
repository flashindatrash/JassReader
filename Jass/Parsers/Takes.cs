using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Jass
{
	public class Takes : IParser
	{
		public const string Pattern = @".+";

		private readonly DataArray takes = new DataArray();
		
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
				takes.Add<Take>(arr[i]);
			}
		}
		
		public override string ToString()
		{
			return takes.ToString();
		}
	}
}

