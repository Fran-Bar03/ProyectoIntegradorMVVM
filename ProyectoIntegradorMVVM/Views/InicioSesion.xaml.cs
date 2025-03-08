using ProyectoIntegradorMVVM.ViewModels;

namespace ProyectoIntegradorMVVM.Views;

public partial class InicioSesion : ContentPage
{
	public InicioSesion()
	{
		InitializeComponent();
        BindingContext = new InicioSesionViewModel();
    }

    private async void Iniciar_Sesion(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PantallaPrincipal());
    }

    private async void Recuperar_Contraseña(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new RecuperarContrasena());
    }

    private async void Crear_Cuenta(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new CrearCuenta());
    }
}