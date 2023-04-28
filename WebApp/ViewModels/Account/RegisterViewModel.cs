using System.ComponentModel.DataAnnotations;
using WebApp.Models;

namespace WebApp.ViewModels.Account;

public class RegisterViewModel
{
    [Required(ErrorMessage = "{0} is required")]
    [Display(Name = "First name")]
    public string FirstName { get; set; } = null!;

    [Required(ErrorMessage = "{0} is required")]
    [Display(Name = "Last name")]
    public string LastName { get; set; } = null!;

    [Required(ErrorMessage = "{0} is required")]
    [EmailAddress(ErrorMessage = "Invalid email address")]
    [RegularExpression(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$", ErrorMessage = "Invalid email address")]
    public string Email { get; set; } = null!;

    [DataType(DataType.Password)]
    [Required(ErrorMessage = "{0} is required")]
    public string Password { get; set; } = null!;

    [DataType(DataType.Password)]
    [Required(ErrorMessage = "{0} is required")]
    [Display(Name = "Confirm password")]
    [Compare(nameof(Password), ErrorMessage = "Passwords do not match")]
    public string ConfirmPassword { get; set; } = null!;

    public static implicit operator AppUser(RegisterViewModel vm)
    {
        return new AppUser
        {
            FirstName = vm.FirstName,
            LastName = vm.LastName,
            UserName = vm.Email,
            Email = vm.Email,
        };
    }
}