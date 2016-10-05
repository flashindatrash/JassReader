using System;
using System.Text.RegularExpressions;
namespace Jass
{
	public static class StringExtend
	{
		public static string[] SplitLines(this string str)
		{
			return Regex.Split(str, "[\r\n]", RegexOptions.IgnorePatternWhitespace);
		}

		public static string[] SplitComma(this string str)
		{
			return str.Split(new string[] { "," }, System.StringSplitOptions.RemoveEmptyEntries);
		}

		public static string[] SplitDot(this string str)
		{
			return str.Split(new string[] { "." }, System.StringSplitOptions.RemoveEmptyEntries);
		}

		public static string FirstUpper(this string str)
		{
			return str.Substring(0, 1).ToUpper() + str.Substring(1, str.Length - 1);
		}

		public static string EachDotUpper(this string str)
		{
			string output = "";
			foreach (string part in str.SplitDot())
			{
				output += part.FirstUpper();
			}
			return output;
		}

	}
}

