using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using System.Web.Http;


[assembly: OwinStartup(typeof(OwinApp.Startup1))]

namespace OwinApp
{
    using AppFunc = Func<IDictionary<string, object>, Task>;
    public class Startup1
    {     

        public void Configuration(IAppBuilder app){
           // app.Use (new Func<AppFunc, AppFunc>(ignoredNextApp => (AppFunc)Invoke));
            HttpConfiguration config = new HttpConfiguration();
            config.Routes.MapHttpRoute("Default", "{controller}/{customerID}", new { controller = "Customer", customerID = RouteParameter.Optional });
            config.Formatters.XmlFormatter.UseXmlSerializer = true;
            config.Formatters.Remove(config.Formatters.JsonFormatter);
            app.UseWebApi(config);
        }

        public Task Invoke(IDictionary<string, object> environments) {
            string responseText = "Hello World";
            byte[] responseBytes = Encoding.UTF8.GetBytes(responseText);
            Stream responseStream = (Stream)environments["owin.ResponseBody"];

            IDictionary<string, string[]> responseHeaders = (IDictionary<string, string[]>)environments["owin.ResponseHeaders"];
            responseHeaders["Content-Length"] = new string[] { responseBytes.Length.ToString(CultureInfo.InvariantCulture) };
            responseHeaders["Content-Type"] = new string[] { "text/plain" };

            return Task.Factory.FromAsync(responseStream.BeginWrite, responseStream.EndWrite, responseBytes, 0, responseBytes.Length, null);
        }

    }
}