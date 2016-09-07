using System;

namespace Jass
{
	public class JassException : Exception
	{
		public JassException()
		{
		}

		public JassException(string message) : base(message)
		{

		}
	}
}

