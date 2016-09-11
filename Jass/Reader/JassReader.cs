using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.IO;

namespace Jass
{

	public class JassReader : IDisposable
	{

		public static List<JassLine> globals = new List<JassLine>();
		public static List<JassLine> native = new List<JassLine>();

		private DirectoryInfo _inputFolder;

		//contructor
		public JassReader()
		{
			_inputFolder = new DirectoryInfo(Settings.InputFolder);
		}

		//destructor
		~JassReader()
		{
			Dispose(false);
		}

		public string[] GetAllFiles()
		{
			FileInfo[] files = _inputFolder.GetFiles("*.*", SearchOption.AllDirectories);
			string[] relativeFiles = new string[files.Length];
			for (int i = 0; i < files.Length; i++)
			{
				FileInfo searchFile = files[i];
				relativeFiles[i] = searchFile.FullName.Substring(_inputFolder.FullName.Length);
			}
			return relativeFiles;
		}

		public List<JassLine> Read(string path)
		{
			Log.Add(string.Format("Read file: {0}", path), ConsoleColor.Blue);

			var result = new List<JassLine>();
			string[] lines = File.Get(Path.Combine(_inputFolder.ToString(), path)).SplitLines();

			bool globalSection = false;

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

					result.Add(line);

					if (line is Function && ((Function)line).isNative)
					{
						//добавить в нативный список функций
						native.Add(line);
					}
					else if (globalSection)
					{
						//добавить в глоабльный список
						globals.Add(line);
					}
				}
				else {
					Log.Add(string.Format("Unknown line: {0}", text), ConsoleColor.DarkRed);
				}
			}

			return result;
		}

		/*
		 * IDisposable
		 */
		private bool disposed = false;

		public void Dispose()
		{
			Dispose(true);
			//подавляем финализацию
			GC.SuppressFinalize(this);
		}

		protected virtual void Dispose(bool disposing)
		{
			if (!disposed)
			{
				if (disposing)
				{
					// Освобождаем управляемые ресурсы
					_inputFolder = null;
				}
				// освобождаем неуправляемые объекты
				disposed = true;
			}
		}

	}
}

