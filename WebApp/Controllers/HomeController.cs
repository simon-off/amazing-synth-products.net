using Microsoft.AspNetCore.Mvc;
using WebApp.ViewModels.Home;

namespace WebApp.Controllers;

public class HomeController : Controller
{
    private readonly Contexts.AppDbContext _context;

    public HomeController(Contexts.AppDbContext context)
    {
        _context = context;
    }

    [HttpGet("/")]
    public IActionResult Index()
    {
        var viewModel = new HomeViewModel(new List<CarouselViewModel> {
            new CarouselViewModel("New Products", _context.Products.Where(x => x.Categories.Any(x => x.Id == 1)).ToList()),
            new CarouselViewModel("Featured Products", _context.Products.Where(x => x.Categories.Any(x => x.Id == 2)).ToList()),
            new CarouselViewModel("Popular Products", _context.Products.Where(x => x.Categories.Any(x => x.Id == 3)).ToList())
        });

        return View(viewModel);
    }
}