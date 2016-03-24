using System;
using System.Configuration;
using System.Diagnostics;
using System.Threading;

namespace diag
{
	class MainClass
	{
		private static TraceSource mySource = 
			new TraceSource ("diag");

		public static void Main (string[] args)
		{
			Console.WriteLine (ConfigurationManager.AppSettings ["myVar"]);
			Activity1 ();
			mySource.Flush ();
			mySource.Close ();
			return;
		}

		static void Activity1 ()
		{
			mySource.TraceEvent (TraceEventType.Error, 1, "Error message");
			mySource.TraceInformation ("teste");
			mySource.TraceEvent (TraceEventType.Warning, 2, "Warning message");
		}
	}
}
