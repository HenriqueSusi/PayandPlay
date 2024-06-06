namespace FormativaMaui.Paginas;

public partial class Index : ContentPage
{
	public Index()
	{
		InitializeComponent();
	}
    private async void OnStartButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Paginas.Login());
    }
}