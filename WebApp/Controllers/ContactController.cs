using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers;

public class ContactController : Controller
{
    [HttpGet("contact")]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost("contact")]
    public IActionResult Index(ContactMessage contactMessage)
    {
        Console.WriteLine("hello");
        return View();
    }
}