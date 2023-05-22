using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebApp.Models;
using WebApp.ViewModels.Admin;
using WebApp.ViewModels.Shared;
using WebApp.Contexts;

namespace WebApp.Controllers;

public class AdminController : Controller
{
    private readonly AppDbContext _context;
    private readonly UserManager<AppUser> _userManager;
    public AdminController(UserManager<AppUser> userManager, AppDbContext context)
    {
        _userManager = userManager;
        _context = context;
    }

    [Authorize(Roles = "Admin")]
    [HttpGet("admin")]
    public async Task<IActionResult> Index()
    {
        var users = await _userManager.Users.ToListAsync();
        var usersWithRoles = new List<UserProfileViewModel>();

        foreach (var user in users)
        {
            var roles = await _userManager.GetRolesAsync(user);
            usersWithRoles.Add(new UserProfileViewModel(user, roles));
        }

        var contactMessages = await _context.ContactMessages.ToListAsync();

        return View(new AdminViewModel(usersWithRoles, contactMessages));
    }
}