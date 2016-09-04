using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Jass
{

	public static class Core
	{

		public static List<LineStruct> Classes = new List<LineStruct>();

		public static void RegisterClass(Type type, Regex instanceOf)
		{
			Console.WriteLine(string.Format("Register Class: {0}", type.ToString()));
			Classes.Add(new LineStruct(type, instanceOf));
		}

	}

}