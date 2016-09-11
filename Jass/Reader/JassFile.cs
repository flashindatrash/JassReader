using System;
using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Jass
{
	public class JassFile
	{
		private const string RegCode = @"\n(?<tabs>[\t]*)\{code\}";

		public string Directory; //директория файла
		public string Name; //имя класса
		public string NameWithExtension; //имя с расширением
		public string FullPath; //полный путь для вывода
		public string SourcePath; //исходный путь
		public List<JassLine> Lines = new List<JassLine>();

		public JassFile(string fullname)
		{
			SourcePath = fullname;
			Name = Path.GetFileName(SourcePath).EachDotUpper();
			NameWithExtension = Name + Settings.Extension;
			Directory = Path.GetDirectoryName(SourcePath);
			FullPath = Path.Combine(Directory, NameWithExtension);
		}

		public void AddLine(JassLine line)
		{
			Lines.Add(line);

			if (line is IName)
			{
				LinkStorage.Add(new LinkInfo(this, line));
			}
		}

		public string Format()
		{
			string output = File.Get(Settings.ClassTemplate);

			if (!Regex.IsMatch(output, RegCode))
			{
				Log.Add("Cannot find {code} in template", ConsoleColor.Red);
				return "";
			}

			//определим количество табов перед кодом
			Match matchCode = Regex.Match(output, RegCode);
			int tabs = matchCode.Groups["tabs"].Length;

			output = output.Replace("{name}", Name);
			output = output.Replace("{code}", Format(tabs));

			return output;
		}

		private string Format(int tabs)
		{
			string output = "";
			int currentTabs = 0;
			bool firstLine = true;
			foreach (JassLine line in Lines)
			{
				if (line is ITabBefore)
				{
					currentTabs -= ((ITabBefore)line).tabBefore;
				}

				output += Tab(currentTabs) + line + line.Comment + "\n";

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

