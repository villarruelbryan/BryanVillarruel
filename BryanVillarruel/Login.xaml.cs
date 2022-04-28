using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BryanVillarruel
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }
        private async void btnAbrir_Clicked(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contrasena = txtContrasena.Text;
           
            if (usuario == "bryan2022" && contrasena == "uisrael2022")
            {
                await Navigation.PushAsync(new Registro(usuario, contrasena));
            }
            else
                await DisplayAlert("Mensaje de Alerta. \nDatos Ingresados Incorrectos. ", "Usted ingreso como usuario: " + usuario + "\n y como contraseña: " + contrasena + "\nUsted debe ingresar la contraseña solicitada en los datos de conexión.", "OK");
        }
    }
}