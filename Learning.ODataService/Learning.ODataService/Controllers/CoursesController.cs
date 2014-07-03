using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.OData;

namespace Learning.ODataService.Controllers
{
    public class CoursesController : EntitySetController<Course, int>
    {
        LearningContext ctx = new LearningContext();

        public override IQueryable<Course> Get()
        {
            return ctx.
        }
    }
}
