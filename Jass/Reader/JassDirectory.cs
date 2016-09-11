using System;
using System.IO;

namespace Jass
{
	public class JassDirectory : IDisposable
	{
		protected DirectoryInfo _directory;

		//Constructor
		public JassDirectory(string path)
		{
			_directory = new DirectoryInfo(path);
		}

		//Destructor
		~JassDirectory()
		{
			Dispose(false);
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
					_directory = null;
				}
				// освобождаем неуправляемые объекты
				disposed = true;
			}
		}

	}
}

