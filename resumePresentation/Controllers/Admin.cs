using Microsoft.AspNetCore.Mvc;

namespace resumePresentation.Controllers
{
    public class Admin : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string username, string email)
        {
            //some code
            return View();
        }
    }
}
