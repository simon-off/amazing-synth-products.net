namespace WebApp.ViewModels.Home;

public class HomeViewModel
{
    public HomeViewModel(ShowcaseViewModel showcase, List<CarouselViewModel> carousels)
    {
        Showcase = showcase;
        Carousels = carousels;
    }

    public ShowcaseViewModel Showcase { get; private set; }
    public List<CarouselViewModel> Carousels { get; private set; }
}