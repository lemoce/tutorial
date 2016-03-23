using System;

namespace static_class
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int[] numbers = new int[args.Length];
			for (int count = 0; count < numbers.Length; count++) {
				numbers [count] = int.Parse (args [count]);
			}

			Console.WriteLine (SimpleMath.Max(numbers));
			Console.WriteLine (SimpleMath.Min(numbers));
		}
	}

	public static class SimpleMath 
	{
		public static int Max(params int[] numbers)
		{
			if (numbers.Length == 0) {
				throw new ArgumentException ("numbers cannot be empty", "numbers");
			}

			int result = Int32.MinValue;
			foreach (int number in numbers) {
				if (number > result) {
					result = number;
				}
			}
			return result;
		}

		public static int Min(params int[] numbers)
		{
			if (numbers.Length == 0) {
				throw new ArgumentException ("numbers cannot be empty", "numbers");
			}

			int result = Int32.MaxValue;
			foreach (int number in numbers) {
				if (number < result) {
					result = number;
				}
			}
			return result;
		}
	}
}
