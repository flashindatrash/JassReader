using System;
using System.IO;

namespace Jass
{
	public class TemplateFile : JassFile
	{
		public TemplateFile(string fullname) : base (fullname)
		{
			
		}

		override public string Name
		{
			get { return Path.GetFileNameWithoutExtension(SourcePath); }
		}

		override public string Directory
		{
			get { return ""; }
		}

		override public string ToString()
		{
			return File.Get(SourcePath);
		}
	}
}
