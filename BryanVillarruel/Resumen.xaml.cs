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
    public partial class Resumen : ContentPage
    {
        public Resumen( string nombre, string total, string usuario)
        {
            InitializeComponent();
            txtNombre.Text = nombre;
            txtTotal.Text = total;
            lblNombre.Text = usuario;
        }
    }
}