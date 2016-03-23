using System;
using System.Text;

namespace ebcdic
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			byte[] msg = ConvertAsciiToEbcdic (Encoding.ASCII.GetBytes ("HELLO WORLD"));

			foreach (byte c in msg) {
				Console.Write (String.Format("{0:X} ", c));
			}
			Console.WriteLine ();
		}

		public static byte[] ConvertAsciiToEbcdic (byte[] asciiData)
		{
			Encoding ascii = Encoding.ASCII;
			Encoding ebcdic = Encoding.GetEncoding (37);

			return Encoding.Convert (ascii, ebcdic, asciiData);
		}
	}
}
