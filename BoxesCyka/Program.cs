using System;

namespace BoxesCyka
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			START:
			Console.Write ("State length:");
			int length = Convert.ToInt32 (Console.ReadLine ());
			Console.Write ("State width:");
			int width = Convert.ToInt32 (Console.ReadLine ());
			Console.Write ("Symbol: ");
			char symbol = Convert.ToChar (Console.ReadLine ());
			Console.WriteLine ("Your length is: " + length);
			Console.WriteLine ("Your width is: " + width);
			Console.WriteLine ("Your symbol: " + symbol);

			for (int j = 0; j < length; j++) 
			{
				for ( int i = 0; i < width; i++ )
				{
					Console.Write (symbol);
				}
				Console.WriteLine (" ");
			}
			Console.WriteLine ("\n");
			goto START;
		}
	}
}
