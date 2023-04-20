using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers;

public class ContactController : Controller
{
    [HttpGet("contact")]
    public IActionResult Index()
    {
        return View();
    }
}