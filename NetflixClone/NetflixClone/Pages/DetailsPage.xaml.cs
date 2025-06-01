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
}