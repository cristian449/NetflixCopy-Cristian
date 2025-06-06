using System.Windows.Input;
using NetflixClone.Models;
using NetflixClone.Pages;
using NetflixClone.ViewModels;

namespace NetflixClone.Controls;

public partial class MoveInfoBox : ContentView
{
	public static readonly BindableProperty MediaProperty =
		BindableProperty.Create(nameof(Media), typeof(Media), typeof(MoveInfoBox), null);

	public event EventHandler Closed;
    public MoveInfoBox()
	{
		InitializeComponent();
        ClosedCommand = new Command(ExecuteClosedCommand);
    }

	public Media Media
    {
        get => (Media)GetValue(MediaProperty);
        set => SetValue(MediaProperty, value);
    }

    public ICommand ClosedCommand { get; private set; }

    private void ExecuteClosedCommand() =>
        Closed?.Invoke(this, EventArgs.Empty);

    private void Button_Clicked(object sender, EventArgs e) =>
        Closed?.Invoke(this, EventArgs.Empty);


    private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        var parameters = new Dictionary<string, object>
        {
            [nameof(DetailsViewModel.Media)] = Media
        };
        await Shell.Current.GoToAsync(nameof(DetailsPage), true, parameters);
    }
}