using System;

namespace BoxesCyka
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.Write ("State length:");
			int length = Convert.ToInt32 (Console.ReadLine ());
			Console.Write ("State width:");
			int width = Convert.ToInt32 (Console.ReadLine ());
			Console.Write ("Symbol: ");
			char symbol = Convert.ToChar (Console.ReadLine ());
			Console.WriteLine ("Your length is: " + length);
			Console.WriteLine ("Your width is: " + width);
			Console.WriteLine ("Your symbol: " + symbol);
		}
	}
}
