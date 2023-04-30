using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebApp.Models;
using WebApp.ViewModels.Admin;
using WebApp.ViewModels.Shared;

namespace WebApp.Controllers;

public class AdminController : Controller
{
    private readonly UserManager<AppUser> _userManager;
    public AdminController(UserManager<AppUser> userManager) { _userManager = userManager; }

    [Authorize(Roles = "Admin")]
    [HttpGet("admin")]
    public async Task<IActionResult> Index()
    {
        var users = _userManager.Users.ToList();
        var usersWithRoles = new List<UserProfileViewModel>();

        foreach (var user in users)
        {
            var roles = await _userManager.GetRolesAsync(user);
            usersWithRoles.Add(new UserProfileViewModel(user, roles));
        }

        return View(new AdminViewModel(usersWithRoles));
    }
}