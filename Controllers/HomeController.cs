using Microsoft.AspNetCore.Mvc;
using Series.Models;
namespace Series.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewBag.Series = BD.ObtenerSeries();
        return View();
    }
    public Temporadas ObtenerTemporadas(int id){
        return BD.ObtenerTemporadas()[id];
    }
}



