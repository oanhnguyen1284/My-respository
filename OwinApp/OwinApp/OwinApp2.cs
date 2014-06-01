using System.Threading.Tasks;
using Microsoft.Owin;


namespace OwinApp
{
    public class OwinApp2
    {
        public static Task Invoke(IOwinContext context)
        {
            context.Response.ContentType = "text/plain";
            return context.Response.WriteAsync("Hello, world 2.");
        }
    }
}