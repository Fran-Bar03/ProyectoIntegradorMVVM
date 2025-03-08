using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProyectoIntegradorMVVM.ViewModels
{
    public class InicioSesionViewModel : BaseViewModel
    {
        #region VARIABLES
        string _email;
        string _password;
        #endregion

        #region CONSTRUCTOR
        public string Email
        {
            get => _email;
            set
            {
                _email = value;
                OnPropertyChanged();
            }
        }

        public string Password
        {
            get => _password;
            set
            {
                _password = value;
                OnPropertyChanged();
            }
        }

        #endregion

        #region PROCESOS

        #endregion

        #region COMANDOS
        public ICommand IniciarSesionCommand { get; }
        public ICommand RecuperarContraseñaCommand { get; }
        public ICommand CrearCuentaCommand { get; }
        #endregion

        public InicioSesionViewModel()
        {
            IniciarSesionCommand = new Command(IniciarSesion);
            RecuperarContraseñaCommand = new Command(RecuperarContraseña);
            CrearCuentaCommand = new Command(CrearCuenta);
        }

        private void IniciarSesion()
        {
            // Lógica de inicio de sesión
            App.Current.MainPage.DisplayAlert("Inicio de Sesión", "Sesión iniciada correctamente", "OK");
        }

        private void RecuperarContraseña()
        {
            // Lógica para recuperar contraseña
            App.Current.MainPage.DisplayAlert("Recuperar Contraseña", "Redirigiendo...", "OK");
        }

        private void CrearCuenta()
        {
            // Lógica para crear cuenta
            App.Current.MainPage.DisplayAlert("Crear Cuenta", "Redirigiendo a registro...", "OK");
        }
    }
}
