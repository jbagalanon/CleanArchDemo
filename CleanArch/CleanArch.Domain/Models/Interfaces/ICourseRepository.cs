using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Domain.Models.Interfaces
{
    interface ICourseRepository
    {
        IEnumerable<Course> GetCourses();
    }
}
