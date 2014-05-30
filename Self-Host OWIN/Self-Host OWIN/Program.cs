
using System;
using OwinApp;

namespace Self_Host_OWIN
{
    class Program
    {
        static void Main(string[] args)
        {

            using (Microsoft.Owin.Hosting.WebApp.Start<Startup>("http://localhost:9000"))
            {
                Console.WriteLine("Press [enter] to quit...");
                Console.ReadLine();
            }
        }
    }
}
