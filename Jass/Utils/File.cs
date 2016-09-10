using System;
using System.Collections.Generic;

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

	}
}

