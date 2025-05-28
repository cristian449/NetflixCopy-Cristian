using NetflixClone.Models;

namespace NetflixClone.Controls;

public partial class MoveInfoBox : ContentView
{
	public static readonly BindableProperty MediaProperty =
		BindableProperty.Create(nameof(Media), typeof(Media), typeof(MoveInfoBox), null);
    public MoveInfoBox()
	{
		InitializeComponent();
	}

	public Media Media
    {
        get => (Media)GetValue(MediaProperty);
        set => SetValue(MediaProperty, value);
    }
}