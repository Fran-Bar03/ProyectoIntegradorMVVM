namespace ProyectoIntegradorMVVM.Views;

public partial class CrearCuenta : ContentPage
{
	public CrearCuenta()
	{
		InitializeComponent();
	}

    private async void Ir_PantallaPrincipal(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PantallaPrincipal());
    }

    private async void Loginn(object sender, TappedEventArgs e)
    {
        await Navigation.PopAsync();
    }
}