using Microsoft.AspNetCore.Mvc;

namespace SalesWebMvc60.Controllers
{
    public class SellersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
