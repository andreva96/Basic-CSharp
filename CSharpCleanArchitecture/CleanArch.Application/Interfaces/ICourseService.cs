using CleanArch.Application.ViewModels;
using System;
using System.Collections.Generic;

namespace CleanArch.Application.Interfaces
{
    public interface ICourseService
    {
        IEnumerable<CourseViewModel> GetCourses();

        void Create(CourseViewModel courseViewModel);
    }
}
