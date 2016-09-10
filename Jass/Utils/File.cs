using System;
using System.Collections.Generic;
using System.IO;

namespace Jass
{
	public static class File
	{

		private static Dictionary<string, string> _templates = new Dictionary<string, string>();

		public static string Get(string path)
		{
			if (!_templates.ContainsKey(path))
			{
				try
				{
					_templates[path] = System.IO.File.ReadAllText(path);
				}
				catch (Exception ex)
				{
					Log.Add(ex.Message, ConsoleColor.Red);
					return "";
				}
			}
			return _templates[path];
		}

		public static string GenerateName(string file)
		{
			string output = "";
			foreach (string part in Path.GetFileName(file).SplitDot())
			{
				output += part.FirstUpper();
			}
			return Path.Combine(Path.GetDirectoryName(file), output + Settings.Extension);
		}

	}
}

