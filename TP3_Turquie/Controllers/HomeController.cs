using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP3_Turquie.Models;

namespace TP3_Turquie.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Catalogo.InicializarAlbum();
        ViewBag.Albumes = Catalogo.Albunes;
        return View();
    }

    public IActionResult SelectAlbum(int a)
    {
        Catalogo.InicializarAlbum();
        if (Catalogo.Albunes.ContainsKey(a))
        {
            var album = Catalogo.Albunes[a];
            if (album != null){
            ViewBag.Album = album;
            ViewBag.Canciones = album.ListaDeCanciones;
            return View("Albumes");
            }
        }

        return NotFound();
    }
}
