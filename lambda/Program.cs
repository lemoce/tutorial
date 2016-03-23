using System;

namespace lambda
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine (GetSomeString ("Hello World!"));
		}

		static string GetSomeString (string str) => $"modified { str } more modified";
	}
}
