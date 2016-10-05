using System;
namespace Jass
{
	public class DataArray : JassArray<IParser>
	{
		public void Add<T>(string text) where T : IParser
		{
			IParser p = (IParser)Activator.CreateInstance(typeof(T));
			p.Parse(text);
			this[Length] = p;
		}

		public override string ToString()
		{
			if (Length == 0) return "";
			string[] result = new string[Length];
			for (var i = 0; i < Length; i++)
			{
				result[i] = this[i].ToString();
			}
			return Length >= 1 ? String.Join(", ", result) : "";
		}
	}
}
