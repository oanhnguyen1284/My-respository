
using System;
using OwinApp;
using System.Diagnostics;
using Microsoft.Owin.Hosting;

namespace Self_Host_OWIN
{
    class Program
    {
        static void Main(string[] args)
        {
            string baseUrl = "http://localhost:9999/";

            //using (Microsoft.Owin.Hosting.WebApp.Start<Startup>(new StartOptions(baseUrl) { ServerFactory = "Microsoft.Owin.Host.HttpListener" }))
            //{
                
            //    // Note: CustomServer has not actually been implemented, no requests will be accepted.

            //    // Launch the browser
            //    Process.Start(baseUrl);

            //    // Keep the server going until we're done
            //    Console.WriteLine("Press Any Key To Exit");
            //    Console.ReadKey();
            //}
            using (WebApp.Start<Startup>(baseUrl))
            {
                Console.WriteLine("Started");
                // Open the SignalR negotiation page to make sure things are working.
                Process.Start(baseUrl + "signalr/negotiate");
                Console.ReadKey();
                Console.WriteLine("Finished");
            }
        }
    }
}
