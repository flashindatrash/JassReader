using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace Jass
{
	public class JassWriter : IDisposable
	{
		
		private DirectoryInfo _outputFolder;

		//constructor
		public JassWriter()
		{
			_outputFolder = new DirectoryInfo(Settings.OutputFolder);
		}

		//destructor
		~JassWriter()
		{
			Dispose(false);
		}

		public void ClearFolder()
		{
			_outputFolder.Clear();
		}

		public void CreateFile(JassFormatter file)
		{
			string path = Path.Combine(_outputFolder.ToString(), file.Path);

			Directory.CreateDirectory(Path.GetDirectoryName(path));

			try
			{
				// Delete the file if it exists.
				if (System.IO.File.Exists(path))
				{
					System.IO.File.Delete(path);
				}

				// Create the file.
				using (FileStream fs = System.IO.File.Create(path))
				{
					Byte[] info = new UTF8Encoding().GetBytes(file.Out);
					fs.Write(info, 0, info.Length);
				}
			}

			catch (Exception ex)
			{
				Log.Add(ex.ToString(), ConsoleColor.Red);
			}
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
					_outputFolder = null;
				}
				// освобождаем неуправляемые объекты
				disposed = true;
			}
		}
	}
}

