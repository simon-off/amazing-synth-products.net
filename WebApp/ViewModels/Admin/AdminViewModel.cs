using WebApp.ViewModels.Shared;
using WebApp.Models;

namespace WebApp.ViewModels.Admin;

public class AdminViewModel
{
    public AdminViewModel(IList<UserProfileViewModel> users, IList<ContactMessage> contactMessages)
    {
        Users = users;
        ContactMessages = contactMessages;
    }

    public IList<UserProfileViewModel> Users { get; set; }
    public IList<ContactMessage> ContactMessages { get; set; }
}