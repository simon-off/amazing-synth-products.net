using WebApp.Models.Entities;

namespace WebApp.ViewModels.Home;

public class CarouselViewModel
{
    public CarouselViewModel(string title, List<Product> products)
    {
        Title = title;
        Products = products;
    }

    public string Title { get; private set; }
    public List<Product> Products { get; private set; }
}