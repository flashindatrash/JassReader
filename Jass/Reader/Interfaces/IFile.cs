using System;
namespace Jass
{
	public interface IFile
	{
		string FullPath { get; }
		string ToString();
	}
}
