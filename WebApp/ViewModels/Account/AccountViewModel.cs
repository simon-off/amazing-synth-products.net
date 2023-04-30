using WebApp.Models;
using WebApp.ViewModels.Shared;

namespace WebApp.ViewModels.Account;

public class AccountViewModel : UserProfileViewModel
{
    public AccountViewModel(AppUser user, IList<string> roles) : base(user, roles)
    {
    }
}
