using FormativaMaui.Model;

namespace FormativaMaui.Paginas;

public partial class Perfil : ContentPage
{
    private Usuario _usuario;

    public Perfil()
    {
        InitializeComponent();

        _usuario = App.Usuario;

        this.BindingContext = _usuario;

        //BemVindo.Text = $"Seja Bem-Vindo {App.Usuario.Nome}! ";

        Ftperfil.Clicked += async (sender, e) =>
        {
            if (MediaPicker.IsCaptureSupported)
            {
                var file = await MediaPicker.PickPhotoAsync();
                if (file != null)
                {
                    var filePath = file.FullPath;

                    Ftperfil.Source = ImageSource.FromFile(filePath);

                    _usuario.Foto = filePath;
                    await App.BancoDados.UserDataTable.SalvarUsuario(_usuario);

                }
            }
        };
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
    private async void BTNSalvar_Clicked(object sender, EventArgs e)
    {
        await App.BancoDados.UserDataTable.SalvarUsuario(_usuario);
    }
}
