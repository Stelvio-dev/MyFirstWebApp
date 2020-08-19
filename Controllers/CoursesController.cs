using Microsoft.AspNetCore.Mvc;

namespace Udemy.Controllers
{
    public class CoursesController : Controller
    {
        public IActionResult Index(){
            return Content("Sono Index");
        }

        public IActionResult Detail (string ID){

            return Content ($"Sono detail e ho ricevuto l'ID:{ID}");
        }
    }
}