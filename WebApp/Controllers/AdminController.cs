using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers;

public class AdminController : Controller
{
    [HttpGet("admin")]
    public IActionResult Index()
    {
        return View();
    }
}