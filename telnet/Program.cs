using System;
using System.Text;
using System.IO;
using System.Net.Sockets;

namespace telnet
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			if (args?.Length != 3) {
				throw new ArgumentException ("Parameters: <server> <word> <port>");
			}

			String server = args [0];
			byte[] byteBuffer = Encoding.ASCII.GetBytes ("GET / HTTP/1.1\n\r\n\r");
			int servPort = int.Parse (args [2]);

			TcpClient client = null;
			NetworkStream netStream = null;

			try {

				client = new TcpClient(server, servPort);
				Console.WriteLine ("Connected to server... sending echo string");

				netStream = client.GetStream ();
				netStream.Write (byteBuffer, 0, byteBuffer.Length);
				Console.WriteLine ($"Sent { byteBuffer.Length } bytes to server...");

				int totalBytesRecvd = 0;
				int bytesRecvd = 0;

				while (totalBytesRecvd < byteBuffer.Length) {
					if ( (bytesRecvd = netStream.Read(byteBuffer, 
						totalBytesRecvd, byteBuffer.Length - totalBytesRecvd)) == 0 ) {
						Console.WriteLine ("Connection closed prematurely.");
						break;
					}
					totalBytesRecvd += bytesRecvd;
				}

				Console.WriteLine ("Received {0} bytes from server: {1}",
					totalBytesRecvd,
					Encoding.ASCII.GetString(byteBuffer, 0, totalBytesRecvd));
			} catch (Exception e) {
				Console.WriteLine (e.Message);
			} finally {
				netStream.Close ();
				client.Close ();
			}
		}
	}
}
