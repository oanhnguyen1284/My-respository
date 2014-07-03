using Learning.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.Data.Mappers
{
    class CourseMapper : EntityTypeConfiguration<Course>
    {
    }
}
