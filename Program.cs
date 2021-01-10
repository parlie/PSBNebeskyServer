using System;

namespace PSBNebeskyServer
{
    class Program
    {
        public static ConnectionHandler connection = new ConnectionHandler();

        static void Main(string[] args)
        {
            Console.WriteLine($"Startup time:{DateTime.UtcNow}");
            connection.StartListener();
            Console.ReadLine();
        }
    }
}
