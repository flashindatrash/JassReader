using System;
namespace Jass
{
	public struct ClassInfo
	{
		public string Name;
		public string DefaultValue;

		public ClassInfo(string name, string defaultValue = "")
		{
			this.Name = name;
			this.DefaultValue = defaultValue;
		}
	}
}

