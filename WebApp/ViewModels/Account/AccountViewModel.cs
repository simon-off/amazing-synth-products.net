using WebApp.Models;

namespace WebApp.ViewModels.Account;

public class AccountViewModel
{
    public AccountViewModel(AppUser user)
    {
        Email = user.Email!;
        FirstName = user.FirstName;
        LastName = user.LastName;
    }

    public string Email { get; set; } = null!;
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
}