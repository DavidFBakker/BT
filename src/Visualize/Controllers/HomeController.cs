#region Using Directives

using Microsoft.AspNetCore.Mvc;

#endregion

namespace Visualize.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["StartDate"] = Config.StartDate;
            ViewData["EndDate"] = Config.EndDate;
            ViewData["MinDate"] = Config.MinDate;
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";


            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}