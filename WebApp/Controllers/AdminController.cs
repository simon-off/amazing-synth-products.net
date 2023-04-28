using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers;

public class AdminController : Controller
{
    [Authorize(Roles = "Admin")]
    [HttpGet("admin")]
    public IActionResult Index()
    {
        return View();
    }
}