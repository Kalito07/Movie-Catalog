using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Movie_Catalog.Models;

public class HomeController : Controller
{
    private readonly MovieService _movieService;

    public HomeController(MovieService movieService)
    {
        _movieService = movieService;
    }

    public async Task<IActionResult> Index()
    {
        try
        {
            await _movieService.Initialize();
            return View();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
            return View("Error");
        }
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
}