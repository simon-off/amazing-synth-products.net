using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.RateLimiting;
using Microsoft.EntityFrameworkCore;
using WebApp.Models;
using WebApp.ViewModels.Contact;

namespace WebApp.Controllers;

public class ContactController : Controller
{
    private readonly Contexts.AppDbContext _context;
    public ContactController(Contexts.AppDbContext context) { _context = context; }

    [HttpGet("contact")]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost("contact")]
    public async Task<IActionResult> Index(ContactViewModel viewModel)
    {
        if (ModelState.IsValid)
        {
            await _context.ContactMessages.AddAsync(viewModel);
            await _context.SaveChangesAsync();
            return RedirectToAction("MessageSent");
        }
        return View(viewModel);
    }

    [HttpGet("contact/sent")]
    public IActionResult MessageSent()
    {
        return View();
    }
}