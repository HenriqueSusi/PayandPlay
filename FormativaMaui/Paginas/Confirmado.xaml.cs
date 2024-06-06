namespace FormativaMaui.Paginas;

public partial class Confirmado : ContentPage
{
    public Confirmado()
    {
        InitializeComponent();
    }
    private async void OnConfirmed(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Home());
    }
}