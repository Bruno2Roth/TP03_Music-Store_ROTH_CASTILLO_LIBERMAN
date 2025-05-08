using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP03.Models;

namespace TP03.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Catálogo.InicializarCatálogo();

        ViewBag.Catálogo = Catálogo.Discografía;

        return View();
    }

    public IActionResult Particular(int id)
    {
        Dictionary<int, Album> c = Catálogo.Discografía;

        if (c.ContainsKey(id))
        {
            Album a = c[id];
            ViewBag.Album = a;
            ViewBag.ID = id;
        }
        else
        {
            ViewBag.Album = null;
        }

        return View();
    }

}
