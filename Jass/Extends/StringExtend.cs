using System;
namespace Jass
{
	public static class StringExtend
	{
		public static string[] SplitLines(this string str)
		{
			return str.Split(new string[] { "\n" }, System.StringSplitOptions.RemoveEmptyEntries);
		}

		public static string[] SplitComma(this string str)
		{
			return str.Split(new string[] { "," }, System.StringSplitOptions.RemoveEmptyEntries);
		}
	}
}

