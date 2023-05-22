using Microsoft.AspNetCore.Mvc;
using WebApp.ViewModels.Contact;
using WebApp.Contexts;

namespace WebApp.Controllers;

public class ContactController : Controller
{
    private readonly AppDbContext _context;
    public ContactController(AppDbContext context) { _context = context; }

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
            TempData["formSubmitted"] = true;
            return RedirectToAction("MessageSent");
        }
        return View(viewModel);
    }

    [HttpGet("contact/sent")]
    public IActionResult MessageSent()
    {
        if (TempData.ContainsKey("formSubmitted") && (bool)TempData["formSubmitted"]!)
            return View();

        return RedirectToAction("Index");
    }
}