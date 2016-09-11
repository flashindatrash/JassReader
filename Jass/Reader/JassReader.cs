using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.IO;

namespace Jass
{

	public class JassReader : JassDirectory
	{
		
		//Contructor
		public JassReader() : base (Settings.InputFolder)
		{
		}

		public JassFile[] ReadAll()
		{
			FileInfo[] files = _directory.GetFiles("*.*", SearchOption.AllDirectories);
			JassFile[] jassFiles = new JassFile[files.Length];
			for (int i = 0; i < files.Length; i++)
			{
				FileInfo searchFile = files[i];
				jassFiles[i] = Read(searchFile.FullName.Substring(_directory.FullName.Length));
			}
			return jassFiles;
		}

		public JassFile Read(string path)
		{
			Log.Add(string.Format("Read file: {0}", path), ConsoleColor.Blue);

			var file = new JassFile(path);

			bool globalSection = false;

			string[] lines = File.Get(Path.Combine(_directory.ToString(), path)).SplitLines();

			for (int i = 0; i < lines.Length; i++)
			{
				string text = lines[i].Trim();

				Comment comment = null;
				JassLine line = null;

				//если присутстсвует комментарий, а если до него находиться код, то переопределим text
				if (Regex.IsMatch(text, Comment.Pattern))
				{
					comment = new Comment();
					comment.Parse(text);
					text = comment.line;
				}

				if (String.IsNullOrEmpty(text))
				{
					if (comment != null)
					{
						line = comment;
					}
					else
					{
						continue;
					}
				}
				else
				{
					foreach (LineInfo parser in Core.Parsers)
					{
						if (Regex.IsMatch(text, parser.pattern))
						{
							line = (JassLine)Activator.CreateInstance(parser.type);
							((IParser)line).Parse(text);
							break;
						}
					}
				}

				if (line != null)
				{
					
					if (comment != null)
					{
						line.Comment = comment.Comment;
					}

					if (Settings.Debug)
					{
						line.Comment = "//" + text;
					}

					//определим глобальную секцию
					if (line is Globals)
					{
						globalSection = true;
					}
					else if (line is EndGlobals)
					{
						globalSection = false;
					}

					if (line is ISkeep)
						continue;

					line.IsGlobal = globalSection;

					file.AddLine(line);
				}
				else {
					Log.Add(string.Format("Unknown line: {0}", text), ConsoleColor.DarkRed);
				}
			}

			return file;
		}

	}
}

