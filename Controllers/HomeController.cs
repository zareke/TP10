using Microsoft.AspNetCore.Mvc;

namespace Series.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
