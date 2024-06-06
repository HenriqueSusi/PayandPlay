namespace FormativaMaui.Paginas;

public partial class Confirmacao : ContentPage
{
	public Confirmacao()
	{
		InitializeComponent();
	}
    private async void OnConfirmPurchase(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Confirmado());
    }

    private async void OnCancelPurchase(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}