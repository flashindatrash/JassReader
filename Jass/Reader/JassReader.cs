using System;
using System.Collections.Generic;

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
			
			string[] lines = text.GetLines();
			_result = new List<IParser>();
			for (int i = 0; i < lines.Length; i++)
			{
				string line = lines[i].Trim();
				IParser instance = null;
				foreach (LineStruct structure in Core.Classes)
				{
					if (structure.instanceOf.IsMatch(line))
					{
						instance = (IParser)Activator.CreateInstance(structure.type);
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

		public string ToString(ResultFormat format)
		{
			string o = "";
			foreach (IParser line in _result)
			{
				o += line.ToString(format) + "\n";
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

