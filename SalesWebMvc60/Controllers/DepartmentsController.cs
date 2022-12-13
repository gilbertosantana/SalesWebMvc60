using Microsoft.AspNetCore.Mvc;
using SalesWebMvc60.Models;

namespace SalesWebMvc60.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> list = new List<Department>();
            list.Add(new Department(1, "Eletronics"));
            list.Add(new Department(2, "Fashio"));

            return View(list);
        }
    }
}
