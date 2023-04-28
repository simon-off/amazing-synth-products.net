using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebApp.Contexts;
using WebApp.Models;
using WebApp.ViewModels.Account;

namespace WebApp.Controllers;

public class AccountController : Controller
{
    private readonly SignInManager<AppUser> _signInManager;
    private readonly UserManager<AppUser> _userManager;
    public AccountController(SignInManager<AppUser> signInManager, UserManager<AppUser> userManager)
    {
        _signInManager = signInManager;
        _userManager = userManager;
    }

    [Authorize]
    [HttpGet("account")]
    public async Task<IActionResult> Index()
    {
        var user = await _userManager.FindByNameAsync(User.Identity?.Name ?? "");
        if (user == null)
            return RedirectToAction("Login");

        return View(new AccountViewModel(user));
    }

    [HttpGet("account/login")]
    public IActionResult Login()
    {
        if (_signInManager.IsSignedIn(User))
            return RedirectToAction("Index");

        return View();
    }

    [HttpPost("account/login")]
    public async Task<IActionResult> Login(LoginViewModel viewModel)
    {
        if (!ModelState.IsValid)
            return View(viewModel);

        var result = await _signInManager.PasswordSignInAsync(viewModel.Email, viewModel.Password, viewModel.RememberMe, false);
        if (!result.Succeeded)
        {
            ModelState.AddModelError("", "Incorrect email or password");
            return View(viewModel);
        }

        return RedirectToAction("Index", "Account");
    }

    [HttpGet("account/register")]
    public IActionResult Register()
    {
        if (_signInManager.IsSignedIn(User))
            return RedirectToAction("Index");

        return View();
    }

    [HttpPost("account/register")]
    public async Task<IActionResult> Register(RegisterViewModel viewModel)
    {
        if (!ModelState.IsValid)
            return View(viewModel);

        var result = await _userManager.CreateAsync(viewModel, viewModel.Password);
        if (!result.Succeeded)
        {
            foreach (var error in result.Errors)
            {
                // Skip username duplication error
                if (error.Code == "DuplicateUserName")
                    continue;

                ModelState.AddModelError("", error.Description);
            }
            return View(viewModel);
        }

        return RedirectToAction("Login", "Account");
    }

    [Authorize]
    public async Task<IActionResult> Logout()
    {
        await _signInManager.SignOutAsync();
        return LocalRedirect("/");
    }
}