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
        ViewBag.EquipoIndumentaria = Equipos.EquiposIndumentaria;
        return View();
    }
    public IActionResult SelectIndumentaria()
    {
        ViewBag.Listaequipos = Equipos.ListaEquipos;
        ViewBag.ListaRemeras = Equipos.ListaCamisetas;
        ViewBag.ListaShorts = Equipos.ListaPantalones;
        ViewBag.Listamedias = Equipos.ListaMedias;
        return View();
    }
    public IActionResult GuardarIndumentaria(int Equipo, int Pantalon, int Media, int Remera)
    {
        bool validar = false;
        if(Equipo == 0 || Pantalon == 0 || Media == 0 || Remera == 0)
        {
            validar = true;
            ViewBag.Error = "Error, no ingresaste datos";
            ViewBag.Listaequipos = Equipos.ListaEquipos;
            ViewBag.ListaRemeras = Equipos.ListaCamisetas;
            ViewBag.ListaShorts = Equipos.ListaPantalones;
            ViewBag.Listamedias = Equipos.ListaMedias;
            return View("SelectIndumentaria");
        }
        else
        {
            validar = false;
            Indumentaria objeto = new Indumentaria(Equipos.ListaPantalones[Pantalon], Equipos.ListaMedias[Media], Equipos.ListaCamisetas[Remera]);
            Equipos.ingresarIndumentaria(Equipos.ListaEquipos[Equipo], objeto);
            ViewBag.EquipoIndumentaria = Equipos.EquiposIndumentaria;
            return View("Index");
        }
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
