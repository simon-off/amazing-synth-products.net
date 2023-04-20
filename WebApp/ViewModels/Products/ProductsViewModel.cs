using WebApp.Models.Entities;

namespace WebApp.ViewModels.Products;

public class ProductsViewModel
{
    public ProductsViewModel(List<Product> products)
    {
        Products = products;
    }

    public List<Product> Products { get; private set; }
}