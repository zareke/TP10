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
    public List<Temporadas> ObtenerTemporadas(int id){
        return BD.ObtenerTemporadas().FindAll(x => x.IdSerie == id+1);
    }
 public List<Actores> ObtenerActores(int id){
        return BD.ObtenerActores().FindAll(x => x.IdSerie == id+1);
    }

     public Serie ObtenerSeries(int id){
        return BD.ObtenerSeries()[id];
    }
}



