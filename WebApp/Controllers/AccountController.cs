using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApp.ViewModels.Account;

namespace WebApp.Controllers;

public class AccountController : Controller
{
    [Authorize]
    [HttpGet("account")]
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet("account/login")]
    public IActionResult Login()
    {
        return View();
    }

    [HttpPost("account/login")]
    public IActionResult Login(LoginViewModel viewModel)
    {
        return View(viewModel);
    }

    [HttpGet("account/register")]
    public IActionResult Register()
    {
        return View();
    }

    [HttpPost("account/register")]
    public IActionResult Register(RegisterViewModel viewModel)
    {
        return View(viewModel);
    }
}