using NetflixClone.ViewModels;

namespace NetflixClone.Pages;

public partial class DetailsPage : ContentPage
{
    private readonly DetailsViewModel _viewModel;
    public DetailsPage(DetailsViewModel _viewmodel)
    {
        InitializeComponent();
        _viewModel = _viewmodel;
        BindingContext = _viewModel;
    }

    protected async override void OnAppearing()
    {
        base.OnAppearing();
        await _viewModel.InitializeAsync();
    }

    private void TrailersTab_Tapped(object sender, TappedEventArgs e)
    {
        similarTabIndicator.Color = Colors.Black;
        similarTabContent.IsVisible = false;

        trailersTabIndicator.Color = Colors.Red;
        trailersTabContent.IsVisible = true;
    }

    private void SimilarTab_Tapped(object sender, TappedEventArgs e)
    {
        trailersTabIndicator.Color = Colors.Black;
        trailersTabContent.IsVisible = false;

        similarTabIndicator.Color = Colors.Red;
        similarTabContent.IsVisible = true;
    }
}