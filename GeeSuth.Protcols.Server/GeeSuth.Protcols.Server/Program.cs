using System;
using System.Threading;

namespace GeeSuth.Protcols.Server
{
    class Program
    {
        static void Main(string[] args)
        {
            int port = 13000;
            
            Thread t = new Thread(delegate ()
            {
                Server myserver = new Server(port);
            });
            t.Start();

            Console.WriteLine("Server Started... any to [" + port +"]");
        }
    }
}
