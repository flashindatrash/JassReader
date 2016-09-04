using System;

namespace Jass
{
	public interface IParser
	{
		void Parse(string text);
		string ToString(ResultFormat format);
	}
}

