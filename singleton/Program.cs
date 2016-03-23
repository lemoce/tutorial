using System;

namespace singleton
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Singleton s1 = Singleton.getInstance ();

			Singleton s2 = Singleton.getInstance ();

			Console.WriteLine (s1 == s2);
		}
	}

	class Singleton {
		private Singleton() {}

		public static Singleton getInstance () {
			if (myInstance == null)
				myInstance = new Singleton ();
			return myInstance;
		}

		private static Singleton myInstance = null;
	}
}
