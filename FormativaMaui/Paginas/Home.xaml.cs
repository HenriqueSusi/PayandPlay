namespace FormativaMaui.Paginas;

public partial class Home : ContentPage
{
	public Home()
	{
		InitializeComponent();
	}
    private async void OnBuyButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Confirmacao());
    }
    private void BtnMenuInferiorHome_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Home());
    }

    private void BtnMenuInferiorSobre_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Sobre());
    }
    private void BtnMenuInferiorPerfil_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Perfil());
    }

    private void BtnMenuInferiorSair_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Index());
    }
}