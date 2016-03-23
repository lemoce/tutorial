using System;

namespace surname
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string first;
			string second;
			System.Console.Write ("Enter your first name: ");
			first = System.Console.ReadLine ();
			System.Console.Write ("Enter your last name: ");
			second = System.Console.ReadLine ();
			Console.WriteLine ($"Hello { first } {second}!");

			Console.WriteLine ("Hello again {0} {1}!", first, second);
		}
	}
}
