using System;
using System.IO;
using System.Text;

namespace Jass
{
	public class JassWriter : JassDirectory
	{
		
		//constructor
		public JassWriter() : base (Settings.OutputFolder)
		{
		}

		public void ClearFolder()
		{
			_directory.Clear();
		}

		public void CreateFile(IFile file)
		{
			string path = Path.Combine(_directory.ToString(), file.FullPath);

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
					Byte[] info = new UTF8Encoding().GetBytes(file.ToString());
					fs.Write(info, 0, info.Length);
				}
			}

			catch (Exception ex)
			{
				Log.Add(ex.ToString(), ConsoleColor.Red);
			}
		}

	}
}

