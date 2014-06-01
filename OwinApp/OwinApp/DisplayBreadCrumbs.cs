using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Owin;

namespace OwinApp
{
    public class DisplayBreadCrumbs : OwinMiddleware
    {
        public DisplayBreadCrumbs(OwinMiddleware next):base(next) { }

        public override System.Threading.Tasks.Task Invoke(IOwinContext context)
        {
            context.Response.ContentType = "text/plain";
            string responseText = context.Request.Headers.Get("breadcrumbs") + "\r\n" 
                +  "PathBase: " + context.Request.PathBase + "\r\n"
                + "Path: " + context.Request.Path + "\r\n";
            return context.Response.WriteAsync(responseText);
        }
    }
}