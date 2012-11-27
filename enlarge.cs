using System;
using Bricksoft.PowerCode;

namespace Bricksoft.DosToys
{
	public class enlarge
	{
		public static void Main( string[] args )
		{
			// Adjust the window size.
			Console.WindowWidth = Console.LargestWindowWidth - 4;
			Console.WindowHeight = Console.LargestWindowHeight - 1;

			Console.BufferWidth = Console.WindowWidth;
			Console.BufferHeight = 3000;

			ConsoleUtils.CenterWindow();
		}
	}
}
