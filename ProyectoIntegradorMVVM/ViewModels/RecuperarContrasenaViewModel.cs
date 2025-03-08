using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ProyectoIntegradorMVVM.Services;
using ProyectoIntegradorMVVM.Views;


namespace ProyectoIntegradorMVVM.ViewModels
{
    public class RecuperarContrasenaViewModel : INotifyPropertyChanged
    {
        private string _email;
        private bool _isBusy;
        private readonly Service _authService;

        public event PropertyChangedEventHandler PropertyChanged;

        public string Email
        {
            get => _email;
            set
            {
                _email = value;
                OnPropertyChanged();
            }
        }

        public bool IsBusy
        {
            get => _isBusy;
            set
            {
                _isBusy = value;
                OnPropertyChanged();
            }
        }

        public ICommand RecuperarCommand { get; }
        public ICommand IrLoginCommand { get; }

        public RecuperarContrasenaViewModel(Service authService)
        {
            _authService = authService;
            RecuperarCommand = new Command(async () => await RecuperarContrasena(), CanRecuperar);
            IrLoginCommand = new Command(async () => await IrLogin());
        }

        private async Task RecuperarContrasena()
        {
            if (string.IsNullOrWhiteSpace(Email))
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Por favor, introduce tu email", "OK");
                return;
            }

            IsBusy = true;
            bool enviado = await _authService.EnviarRecuperacionContrasena(Email);
            IsBusy = false;

            if (enviado)
                await Application.Current.MainPage.DisplayAlert("Éxito", "Se han enviado instrucciones a tu correo", "OK");
            else
                await Application.Current.MainPage.DisplayAlert("Error", "No se pudo enviar el correo. Verifica tu email", "OK");
        }

        private bool CanRecuperar()
        {
            return !IsBusy;
        }

        private async Task IrLogin()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new InicioSesion());
        }

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
