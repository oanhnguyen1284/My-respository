using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;

//[assembly: OwinStartup(typeof(OwinApp.Startup))]

namespace OwinApp
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.Use<AddBreadCrumbMiddleware>("start-of-the-line");
            app.Map("/branch1", app1 =>
            {
                app1.Use<AddBreadCrumbMiddleware>("took-branch1");
                // Nesting paths, e.g. /branch1/branch2
                app1.Map("/branch2", app2 =>
                {
                    app2.Use<AddBreadCrumbMiddleware>("took-branch2");
                    app2.Use<DisplayBreadCrumbs>();
                });
                MapIfIE(app1);
                app1.Use<DisplayBreadCrumbs>();
            });
            // Only full segments are matched, so /branch1 does not match /branch100
            app.Map("/branch100", app1 => 
            {
                app1.Use<AddBreadCrumbMiddleware>("took-branch100");
                app1.Use<DisplayBreadCrumbs>();
            });

            MapIfIE(app);
            app.Use<AddBreadCrumbMiddleware>("no-branches-taken");
            app.Use<DisplayBreadCrumbs>();
        }

        public Task Invoke(IOwinContext context) {
            context.Response.ContentType = "text/plain";
            return context.Response.WriteAsync("Hello, world.");
        }

        private void MapIfIE(IAppBuilder app) {
            app.MapWhen(IsIE, app2 => 
            {
                app2.Use<AddBreadCrumbMiddleware>("took-IE-branch");
                app2.Use<DisplayBreadCrumbs>();
            });
        }
        private bool IsIE(IOwinContext  context) {
            return context.Request.Headers.Get("User-Agent").Contains("MSIE");
        }
    }
}