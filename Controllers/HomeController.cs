using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using practica1.Models;

namespace practica1.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [HttpPost]
    public IActionResult FRegistro(operacion objoperacion)
    {
        string rspt;

        try{
            rspt = objoperacion.msjF().ToString()+"";
        }catch(Exception ex){
            rspt = ex.Message;
        }

        ViewData["Message"] = rspt;
        return View("Index");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
