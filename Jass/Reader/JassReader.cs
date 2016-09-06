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
				if (String.IsNullOrEmpty(line))
				{
					continue;
				}

				IParser instance = null;
				foreach (LineParser parser in Core.Parsers)
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

