using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Jass
{

	public class JassReader : IDisposable
	{

		public static List<JassLine> globals = new List<JassLine>();
		public static List<JassLine> native = new List<JassLine>();

		public List<JassLine> result = new List<JassLine>();

		public string file
		{
			set; get;
		}

		//contructor
		public JassReader()
		{
		
		}

		//destructor
		~JassReader()
		{
			Dispose(false);
		}


		public void Read(string path)
		{
			file = path;
			Log.Add(string.Format("Read file: {0}", file), ConsoleColor.Blue);
			Parse(File.Get(System.IO.Path.Combine(Settings.InputFolder, file)));
		}

		private void Parse(string input)
		{
			string[] lines = input.SplitLines();
			int totalRead = 0;
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
					foreach (LineData parser in Core.Parsers)
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

					totalRead++;

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
					else
					{
						//добавить в текущий класс
						result.Add(line);
					}
				}
				else {
					Log.Add(string.Format("Unknown line: {0}", text), ConsoleColor.DarkRed);
				}
			}

			Log.Add(string.Format("Completed: {0}%", Math.Round((decimal)totalRead/lines.Length*100)), ConsoleColor.Green);
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
					result = null;
				}
				// освобождаем неуправляемые объекты
				disposed = true;
			}
		}

	}
}

