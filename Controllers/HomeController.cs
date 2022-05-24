using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FileUpload.Models;
using Microsoft.AspNetCore.Http;

namespace FileUpload.Controllers;

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

    public IActionResult Upload([FromBody] FormData data)
    {
        var x = data.file;
        System.Diagnostics.Debug.WriteLine(x.FileName);
        return Redirect("/home/index");
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    public class FormData{
       public IFormFile file {get;set;}
    }
}
