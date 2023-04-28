using WebApp.Models;

namespace WebApp.ViewModels.Account;

public class AccountViewModel
{
    public AccountViewModel(AppUser user, IList<string> roles)
    {
        Email = user.Email!;
        FirstName = user.FirstName;
        LastName = user.LastName;
        Roles = roles;
    }

    public string Email { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public IList<string> Roles { get; set; }
}