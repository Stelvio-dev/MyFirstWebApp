using System.Collections.Generic;
using Udemy.Model;

namespace Udemy.Models.Services.Application
{
    public interface ICourseService
    {
         List<CourseViewModel> GetCourses();
         //CoursesDetailViewModel GetCourse(int ID);
    }
}