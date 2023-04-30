using WebApp.ViewModels.Shared;

namespace WebApp.ViewModels.Admin;

public class AdminViewModel
{
    public AdminViewModel(IList<UserProfileViewModel> users)
    {
        Users = users;
    }

    public IList<UserProfileViewModel> Users { get; set; }
}