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
    public partial class Registro : ContentPage
    {
        public Registro(string usuario, string contrasena)
        {
            InitializeComponent();
            
            lblNombre.Text = "Usuario: " + usuario;
        }
        private void btnCacular_Clicked(object sender, EventArgs e)
        {
            try
            {
                double costoCurso = 3000;
                double cuotaInicial = Convert.ToDouble(txtCuotaInicial.Text);
                double pagoMensual = (costoCurso - cuotaInicial)+(costoCurso*0.05);
                double total = cuotaInicial + (pagoMensual * 5);
                txtPagoMensual.Text = pagoMensual.ToString();
                txtTotal.Text = total.ToString();

                if (cuotaInicial >= costoCurso)
                {

                    DisplayAlert("Mensaje de Alerta", "La cuota inicial es mayor o igual al costo del curso" , "OK");

                }
                
            }
            catch (Exception ex)
            {
                DisplayAlert("ERROR", ex.Message, "Cerrar");

            }

        }

        private async void btnGuardar_Clicked(object sender, EventArgs e)
        {
            //lblNombre.Text = "Usuario: " + usuario;
            string nombre = txtNombre.Text;
            string total = txtTotal.Text;
            string usuario = lblNombre.Text;
            await Navigation.PushAsync(new Resumen(nombre, total, usuario));

        }
    }
}