using Microsoft.AspNetCore.Mvc;

namespace Udemy
{
    public class HomeController : Controller
    {
        public IActionResult Index() 
        {
            return Content ("Sono nella Home Index");
        }
    }
}