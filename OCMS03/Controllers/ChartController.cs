using Microsoft.AspNetCore.Mvc;
using OCMS03.Models;

namespace OCMS03.Controllers
{
    public class ChartController : Controller
    {
        public IActionResult Index()
        {
            return View(new Helper());
        }
     }
}
