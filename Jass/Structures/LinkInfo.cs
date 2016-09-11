using System;
namespace Jass
{
	public struct LinkInfo
	{
		/*
		 * Ссылка состоит из линии и файла к которой она принадлежит
		 */
		public JassFile File;
		public JassLine Line;

		public bool HasName
		{
			get
			{
				return Line is IName;
			}
		}

		public string Name
		{
			get
			{
				return ((IName)Line).GetName();
			}
		}

		public bool IsNativeFunction
		{
			get
			{
				return Line is Function && ((Function)Line).isNative;
			}
		}

		public bool IsGlobal
		{
			get
			{
				return Line.IsGlobal;
			}
		}

		public LinkInfo(JassFile File, JassLine Line)
		{
			this.File = File;
			this.Line = Line;
		}
	}
}

