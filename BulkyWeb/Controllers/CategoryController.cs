using Microsoft.AspNetCore.Mvc;

namespace Online_Book_Store.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
