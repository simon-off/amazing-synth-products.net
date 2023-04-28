using System.ComponentModel.DataAnnotations;

namespace WebApp.ViewModels.Account;

public class LoginViewModel
{
    [EmailAddress(ErrorMessage = "Invalid email address")]
    [Required(ErrorMessage = "{0} is required")]
    public string Email { get; set; } = null!;

    [DataType(DataType.Password)]
    [Required(ErrorMessage = "{0} is required")]
    public string Password { get; set; } = null!;

    [Display(Name = "Keep me logged in")]
    public bool RememberMe { get; set; }
}