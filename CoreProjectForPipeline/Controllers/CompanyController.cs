using Microsoft.AspNetCore.Mvc;

namespace CoreProjectForPipeline.Controllers
{
    public class CompanyController : Controller
    {
        public IActionResult Home()
        {
            return View();
        }
        public IActionResult AboutUs()
        {
            return View();
        }
        public IActionResult ContactUs()
        {
            return View();

        }
        public IActionResult Services()
        {
            return View();
        }
    }
}
