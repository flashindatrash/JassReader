using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Jass
{

	public class JassReader : IDisposable, IParser
	{

		private List<IParser> _result;

		public string content
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

		/*
		 * IParser
		 */
		public void Parse(string text)
		{
			string[] lines = text.SplitLines();
			_result = new List<IParser>();
			for (int i = 0; i < lines.Length; i++)
			{
				string line = lines[i].Trim();

				//check comments
				if (Regex.IsMatch(line, Comment.Pattern))
				{
					var comment = new Comment();
					comment.Parse(line);
					_result.Add(comment);
					line = comment.left;
				}

				if (String.IsNullOrEmpty(line))
				{
					continue;
				}

				IParser instance = null;
				foreach (LineData parser in Core.Parsers)
				{
					if (Regex.IsMatch(line, parser.pattern))
					{
						instance = (IParser)Activator.CreateInstance(parser.type);
						break;
					}
				}
				if (instance != null)
				{
					instance.Parse(line);
					_result.Add(instance);
				}
				else {
					Log.Add(string.Format("Unknown line: {0}", line), ConsoleColor.DarkRed);
				}
			}

			Log.Add(string.Format("Completed: {0}%", Math.Round((decimal)_result.Count/lines.Length*100)), ConsoleColor.Green);
		}

		public override string ToString()
		{
			string o = "";
			foreach (IParser line in _result)
			{
				o += line + "\n";
			}
			return o;
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
					_result = null;
				}
				// освобождаем неуправляемые объекты
				disposed = true;
			}
		}

	}
}

