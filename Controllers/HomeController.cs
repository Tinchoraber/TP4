using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP4.Models;

namespace TP4.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewBag.EquiposIndumentaria();
        return View();
    }
    public IActionResult SelectIndumentaria()
    {
        ViewBag.ListaEquipos();
        ViewBag.ListaCamisetas();
        ViewBag.ListaPantalones();
        ViewBag.ListaMedias();
        return SelectIndumentaria();
    }
    public IActionResult GuardarIndumentaria(int Equipo, int Pantalon, int Media, int Remera)
    {
        bool validar = false;
        if(Equipo == null || Pantalon == null || Media == null || Remera == null)
        {
            validar = true;
            return SelectIndumentaria();
        }
        else
        {
            validar = false;
            return View();
        }
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
