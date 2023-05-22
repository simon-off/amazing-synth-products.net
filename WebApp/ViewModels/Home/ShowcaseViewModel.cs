using WebApp.Models;

namespace WebApp.ViewModels.Home;

public class ShowcaseViewModel
{
    public ShowcaseViewModel(string title, Product product)
    {
        Title = title;
        Product = product;
    }

    public string Title { get; private set; }
    public Product Product { get; private set; }
}
