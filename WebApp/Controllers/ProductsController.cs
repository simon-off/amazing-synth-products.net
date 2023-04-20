using Microsoft.AspNetCore.Mvc;
using WebApp.ViewModels.Products;

namespace WebApp.Controllers;

public class ProductsController : Controller
{
    private readonly Contexts.AppDbContext _context;

    public ProductsController(Contexts.AppDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var viewModel = new ProductsViewModel(_context.Products.ToList());
        return View(viewModel);
    }
}