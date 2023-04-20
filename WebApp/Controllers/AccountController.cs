using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers;

public class AccountController : Controller
{
    [HttpGet("account")]
    public IActionResult Index()
    {
        return View();
    }
}