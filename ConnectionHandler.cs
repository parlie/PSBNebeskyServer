using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;
using System.Net.Security;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Security;
using System.Security.Cryptography;

namespace PSBNebeskyServer
{
    public class ConnectionHandler
    {
        //Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        TcpListener listener = new TcpListener(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 49152));
        TcpClient client;

        public async void StartListener()
        {
            listener.Start();
            //socket.Bind(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 49152));
            Console.WriteLine($"Listener opened on {listener.LocalEndpoint}");
            //socket.Listen(1);
            await ListenForConnection();
        }

        public async Task ListenForConnection()
        {
            while(true)
            {
                if (client == null)
                {
                    Console.WriteLine("Awaiting client connection");
                    client = await listener.AcceptTcpClientAsync();
                    Console.WriteLine($"Client connected:{client.Client.RemoteEndPoint}");
                }
                else
                {
                    Console.WriteLine("Since client connected I stopped looking for more clients");
                    await ListenForMessages();
                    break;
                }
            }
        }

        int messageLenght;
        NetworkStream stream;
        Byte[] bytes = new byte[256];
        string data;
        RequestHandler handler = new RequestHandler();

        public async Task ListenForMessages()
        {
            Console.WriteLine("Listening for messages from client");
            while (true)
            {
                stream = client.GetStream();
                messageLenght = stream.Read(bytes, 0, bytes.Length);
                data = System.Text.Encoding.ASCII.GetString(bytes);
                Console.WriteLine(data);
            }
        }
    }
}