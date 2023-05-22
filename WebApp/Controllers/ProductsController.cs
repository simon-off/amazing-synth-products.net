using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApp.ViewModels.Products;
using WebApp.Contexts;

namespace WebApp.Controllers;

public class ProductsController : Controller
{
    private readonly AppDbContext _context;
    public ProductsController(AppDbContext context) { _context = context; }

    [HttpGet("products")]
    public async Task<IActionResult> Index()
    {
        var viewModel = new ProductsViewModel(await _context.Products.ToListAsync());
        return View(viewModel);
    }

    [HttpGet("products/{id}")]
    public async Task<IActionResult> ProductDetails(int id)
    {
        var product = await _context.Products.FindAsync(id);

        if (product == null)
            return RedirectToAction("Index");

        return View(product);
    }
}