using System.ComponentModel.DataAnnotations;
using WebApp.Models;

namespace WebApp.ViewModels.Contact;

public class ContactViewModel
{
    [Required(ErrorMessage = "{0} is required")]
    public string Name { get; set; } = null!;

    [Required(ErrorMessage = "{0} is required")]
    [EmailAddress(ErrorMessage = "Invalid email address")]
    [RegularExpression(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$", ErrorMessage = "Invalid email address")]
    public string Email { get; set; } = null!;

    [Required(ErrorMessage = "{0} is required")]
    public string Subject { get; set; } = null!;

    [Required(ErrorMessage = "{0} is required")]
    public string Message { get; set; } = null!;

    public static implicit operator ContactMessage(ContactViewModel vm)
    {
        return new ContactMessage
        {
            Name = vm.Name,
            Email = vm.Email,
            Subject = vm.Subject,
            Message = vm.Message,
        };
    }
}