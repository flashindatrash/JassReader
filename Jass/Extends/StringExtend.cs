using System;
using System.Text.RegularExpressions;
using System.Text;

namespace Jass
{
	public static class StringExtend
	{
		public static int ToInt(this string str)
		{
			byte[] bytes = Encoding.Default.GetBytes(str);
			return BitConverter.ToInt32(bytes, 0);
		}

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

