using System;
namespace Jass {
	public static class StringExtend {
		public static string[] GetLines(this string str) {
			return str.Split(new string[] { "\n" }, System.StringSplitOptions.RemoveEmptyEntries);
		}
	}
}

