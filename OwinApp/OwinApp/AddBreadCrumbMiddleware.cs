using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Owin;

namespace OwinApp
{
    public class AddBreadCrumbMiddleware : OwinMiddleware
    {
        private string _breadcrumb;

        public AddBreadCrumbMiddleware(OwinMiddleware next, string breadcrumb):base(next)
        {
            _breadcrumb = breadcrumb;
        }

        public override System.Threading.Tasks.Task Invoke(IOwinContext context)
        {
            context.Request.Headers.Append("breadcrumbs", _breadcrumb);
            return Next.Invoke(context);
        }
    }
}