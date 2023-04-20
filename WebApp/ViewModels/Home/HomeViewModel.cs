namespace WebApp.ViewModels.Home;

public class HomeViewModel
{
    public HomeViewModel(List<CarouselViewModel> carousels)
    {
        Carousels = carousels;
    }

    public List<CarouselViewModel> Carousels { get; private set; }
}