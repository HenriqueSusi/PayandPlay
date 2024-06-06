using FormativaMaui.Model;

namespace FormativaMaui.Paginas;

public partial class EditUserPage : ContentPage
{
    Usuario _usuario;
    public EditUserPage()
	{
        _usuario = new Usuario();
        this.BindingContext = _usuario;
        InitializeComponent();
	}

    private async void OnStartButton(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(_usuario.Email) && string.IsNullOrEmpty(_usuario.Nome) && string.IsNullOrEmpty(_usuario.Senha))
        {
            await DisplayAlert("Erro", "Preencha todas as informações", "Fechar");
            return;
        }
        var cadastro = await App.BancoDados.UserDataTable.SalvarUsuario(_usuario);

        if (cadastro > 0)
        {
            await DisplayAlert("Sucesso", "Usuário cadastrado com sucesso", "Fechar");
           
            await Navigation.PushAsync(new Login());
        }
    }

    private async void btnVoltar_Clicked(object sender, EventArgs e)
    {
        
        await Navigation.PopAsync();
    }
}