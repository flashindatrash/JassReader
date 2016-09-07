using System;
using System.IO;
using System.Text;

namespace Jass
{
	public class JassWriter
	{

		private const string Dir = "Out\\";
		private const string Extension = "cs";

		private string _template;

		public JassWriter()
		{
		}

		public void SetTemplate(string template)
		{
			_template = template;
		}

		public void Write(string file, IParser reader)
		{
			string output = _template;
			string code = reader.ToString();
			string filename = Path.GetFileNameWithoutExtension(file);

			output = output.Replace("{name}", filename);
			output = output.Replace("{code}", code);

			Log.Add(code, ConsoleColor.Yellow);

			string path = Path.Combine(Dir, filename + "." + Extension);

			try
			{
				// Delete the file if it exists.
				if (File.Exists(path))
				{
					File.Delete(path);
				}

				// Create the file.
				using (FileStream fs = File.Create(path))
				{
					Byte[] info = new UTF8Encoding(true).GetBytes(output);
					fs.Write(info, 0, info.Length);
				}
			}

			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
			}
		}
	}
}

