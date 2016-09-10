using System;
using System.IO;

namespace Jass
{
	public static class DirectoryInfoExtend
	{
		public static void Clear(this DirectoryInfo directory)
		{
			foreach (FileInfo file in directory.GetFiles()) file.Delete();
			foreach (DirectoryInfo subDirectory in directory.GetDirectories()) subDirectory.Delete(true);
		}
	}
}

