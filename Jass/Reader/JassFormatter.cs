using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Jass
{
	public class JassFormatter
	{

		private const string RegCode = @"\n(?<tabs>[\t]*)\{code\}";

		public string Path;
		public string Out;

		public JassFormatter(List<JassLine> lines, string file, string templatePath)
		{
			Out = File.Get(templatePath);
			Path = File.GenerateName(file);

			if (!Regex.IsMatch(Out, RegCode))
			{
				Log.Add("Cannot find {code} in template", ConsoleColor.Red);
				return;
			}

			//определим количество табов перед кодом
			Match matchCode = Regex.Match(Out, RegCode);
			int tabs = matchCode.Groups["tabs"].Length;

			string filename = System.IO.Path.GetFileNameWithoutExtension(Path);
			string code = Format(lines, tabs);

			Out = Out.Replace("{name}", filename);
			Out = Out.Replace("{code}", code);
		}

		private string Format(List<JassLine> lines, int tabs)
		{
			string output = "";
			int currentTabs = 0;
			bool firstLine = true;
			foreach (JassLine line in lines)
			{
				if (line is ITabBefore)
				{
					currentTabs -= ((ITabBefore)line).tabBefore;
				}

				output += Tab(currentTabs) + line.ToString() + line.Comment + "\n";

				if (firstLine)
				{
					currentTabs = tabs;
					firstLine = false;
				}

				if (line is ITabAfter)
				{
					currentTabs += ((ITabAfter)line).tabAfter;
				}
			}

			return output;
		}

		private string Tab(int count)
		{
			string output = "";
			for (int i = 0; i < count; i++)
			{
				output += "\t";
			}
			return output;
		}

	}
}

