using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApp.ViewModels.Home;

namespace WebApp.Controllers;

public class HomeController : Controller
{
    private readonly Contexts.AppDbContext _context;
    public HomeController(Contexts.AppDbContext context) { _context = context; }

    [HttpGet("/")]
    public async Task<IActionResult> Index()
    {
        var viewModel = new HomeViewModel(
            new ShowcaseViewModel("Back in stock!", await _context.Products.FirstAsync()),
            new List<CarouselViewModel> {
                new CarouselViewModel("Popular", await _context.Products.Where(x => x.Categories.Any(x => x.Id == 3)).ToListAsync()),
                new CarouselViewModel("Featured", await _context.Products.Where(x => x.Categories.Any(x => x.Id == 2)).ToListAsync()),
                new CarouselViewModel("New", await _context.Products.Where(x => x.Categories.Any(x => x.Id == 1)).ToListAsync())
            });

        return View(viewModel);
    }
}