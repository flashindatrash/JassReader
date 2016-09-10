using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace Jass
{
	public class JassWriter : IDisposable
	{

		private const string RegCode = @"\n(?<tabs>[\t]*)\{code\}";

		private DirectoryInfo _directory;

		//constructor
		public JassWriter()
		{
			_directory = new DirectoryInfo(Settings.OutputFolder);
		}

		//destructor
		~JassWriter()
		{
			Dispose(false);
		}

		public void ClearFolder()
		{
			_directory.Clear();
		}

		public void Write(JassReader reader, string template)
		{
			string output = template;

			if (!Regex.IsMatch(output, RegCode))
			{
				Log.Add("Cannot find {code} in template", ConsoleColor.Red);
				return;
			}

			//определим количество табов перед кодом
			Match matchCode = Regex.Match(output, RegCode);
			int tabs = matchCode.Groups["tabs"].Length;

			string filename = Path.GetFileNameWithoutExtension(reader.file);
			string code = Format(reader, tabs);

			output = output.Replace("{name}", filename);
			output = output.Replace("{code}", code);

			CreateFile(filename, output);
		}

		private string Format(JassReader reader, int tabs)
		{
			string output = "";
			int currentTabs = 0;
			bool firstLine = true;
			foreach (JassLine line in reader.result)
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

		private void CreateFile(string filename, string output)
		{
			string path = Path.Combine(_directory.ToString(), filename + ".cs");

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
					Byte[] info = new UTF8Encoding().GetBytes(output);
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
					_directory = null;
				}
				// освобождаем неуправляемые объекты
				disposed = true;
			}
		}
	}
}

