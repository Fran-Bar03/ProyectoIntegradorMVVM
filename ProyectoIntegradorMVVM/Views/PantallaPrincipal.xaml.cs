namespace ProyectoIntegradorMVVM.Views;

public partial class PantallaPrincipal : ContentPage
{
	public PantallaPrincipal()
	{
		InitializeComponent();
	}

    private async void Ir_AgregarInvernadero(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AgregarInvernadero());
    }

    private async void Ir_Detalle(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new DetalleInvernadero());
    }
}