using System;

namespace Jass
{
	
	public static class Log
	{

		public static void Add(object message, ConsoleColor color = ConsoleColor.Gray)
		{
			Console.ForegroundColor = color;
			Console.WriteLine(message);
			Console.ForegroundColor = ConsoleColor.Gray;
		}

	}
}

