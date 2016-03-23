using System;

namespace args
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			if (args?.Length == 0) {
				Console.WriteLine ("ERROR: file missing. "
				+ "Use:\n\tfind.exe file:<filename>");
			} else {
				if (args[0]?.ToLower().StartsWith("file:") ?? false) {
					string fileName = args [0]?.Remove (0, 5);
					Console.WriteLine (fileName);
				}
			}
		}
	}
}
