namespace ProyectoIntegradorMVVM.Views;

public partial class RecuperarContrasena : ContentPage
{
	public RecuperarContrasena()
	{
		InitializeComponent();
	}

    private async void Ir_Login(object sender, TappedEventArgs e)
    {
        await Navigation.PopAsync();
    }
}