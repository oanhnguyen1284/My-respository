
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(OwinApp.Startup))]

namespace OwinApp
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.Run(context =>
            {
                context.Response.ContentType = "text/plain";
                return context.Response.WriteAsync("Hello, world.");
            });   
        }
    }
}