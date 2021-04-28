using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExamenGABRIELAGUANUNA
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Resumen : ContentPage
    {
        public Resumen(string userlogin, string nombre, string tot)
        {
            InitializeComponent();

            lblUser.Text = userlogin;
            txtEstudiante.Text = nombre;
            txtTotal.Text = tot;
        }
    }
}