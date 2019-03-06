using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Controllers
{
    public class PortfolioController: Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View("index");
        }
    }
}