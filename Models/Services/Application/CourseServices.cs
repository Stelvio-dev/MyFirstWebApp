using System;
using System.Collections.Generic;
using Udemy.Model;
using Udemy.Model.ValueTypes;

namespace Udemy.Models.Services.Application
{
    public class CourseServices : ICourseService
    {
        public List<CourseViewModel> GetCourses()
        {
         var courseList = new List<CourseViewModel>();
            var rand = new Random();
            for(int i = 1; i< 20; i++)
            {
                var price = Convert.ToDecimal(rand.NextDouble()*10+10);
                var course = new CourseViewModel{
                    ID = 1,
                    Title = $"Corso {i}",
                    CurrentPrice = new Money(Currency.EUR, price),
                    FullPrice = new Money(Currency.EUR,rand.NextDouble()>0.5?price:price-1),
                    Author = "Nome Cognome",
                    Rating = rand.NextDouble() * 0.5,
                    ImagePath ="~/logo.jpg"

                };
                courseList.Add (course);
            }
            return courseList;
            //throw new NotImplementedException();        }
        }

    }
}