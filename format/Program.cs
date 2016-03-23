using System;

namespace format
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			const double number = 1.168033988749895;
			double result;
			string text;

			text = $"{number}";
			result = double.Parse (text);
			Console.WriteLine ($"{result == number}: result == number ({text})");

			text = String.Format("{0:R}", number);
			result = double.Parse (text);
			Console.WriteLine ($"{result == number}: result == number ({text})");
		}
	}
}
