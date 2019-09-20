using Microsoft.AspNetCore.Mvc;

namespace WebSolution.Controllers
{
    public class SolutionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}