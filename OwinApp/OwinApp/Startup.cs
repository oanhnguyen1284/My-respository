using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(OwinApp.Startup))]

namespace OwinApp
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseErrorPage();

            app.Run(context =>
            {
                if (context.Request.Path.ToString() ==  "/fail")
                {
                    throw new Exception("Random exception");
                }
                context.Response.ContentType = "text/plain";
                return context.Response.WriteAsync("Hello, world.");
            });
            //app.Run(context =>
            //{
            //    context.Response.ContentType = "text/plain";
            //    return context.Response.WriteAsync("Hello, world.");
            //});   
        }
    }
}