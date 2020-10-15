using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Udemy.Model;
using Udemy.Models.Services.Application;

namespace Udemy.Controllers
{
    public class CoursesController : Controller
    {
        private readonly ICourseService courseServices;

        public CoursesController(ICourseService courseServices)
        {
            this.courseServices = courseServices;
        }
        public IActionResult Index()
        {

            CourseServices courseService = new CourseServices();
            List<CourseViewModel> courses = courseService.GetCourses();
            return View(courses);
        }

        public IActionResult Detail(string ID)
        {

            return View();
        }
    }
}