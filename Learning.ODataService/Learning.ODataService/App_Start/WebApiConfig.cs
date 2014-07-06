using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.OData.Builder;
using Learning.Data.Entities;
using Microsoft.Data.Edm;

namespace Learning.ODataService
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Routes.MapODataRoute("elearningOData", "OData", GenerateModel());
        }

        private static IEdmModel GenerateModel() {
            var builder = new ODataConventionModelBuilder();
            builder.EntitySet<Course>("Courses");
            builder.EntitySet<Enrollment>("Enrollments");
            builder.EntitySet<Subject>("Subjects");
            builder.EntitySet<Tutor>("Tutors");
            return builder.GetEdmModel();
        }
    }
}
