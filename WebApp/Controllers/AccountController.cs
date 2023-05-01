using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
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

        var roles = await _userManager.GetRolesAsync(user);

        return View(new AccountViewModel(user, roles));
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

        AppUser user = viewModel;
        var createResult = await _userManager.CreateAsync(user, viewModel.Password);
        if (!createResult.Succeeded)
        {
            foreach (var error in createResult.Errors)
            {
                // Skip username duplication error
                if (error.Code == "DuplicateUserName")
                    continue;

                ModelState.AddModelError("", error.Description);
            }
            return View(viewModel);
        }

        await _userManager.AddToRoleAsync(user, "user");
        // Add admin role if first registered user, else add customer
        if (_userManager.Users.Count() <= 1)
        {
            await _userManager.AddToRoleAsync(user, "admin");
        }
        else
        {
            await _userManager.AddToRoleAsync(user, "customer");
        }

        return RedirectToAction("Login", "Account");
    }

    [Authorize]
    public async Task<IActionResult> Logout()
    {
        await _signInManager.SignOutAsync();
        return LocalRedirect("/");
    }

    public IActionResult Denied()
    {
        return View();
    }
}