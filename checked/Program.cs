using System;

namespace checked1
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			unchecked {
				int n = int.MaxValue;
				n = n + 1;
				System.Console.WriteLine (n);
			}

			checked {
				int n = int.MaxValue;
				n = n + 1;
				System.Console.WriteLine (n);
			}

			Console.WriteLine("Hello World!");
		}
	}
}
