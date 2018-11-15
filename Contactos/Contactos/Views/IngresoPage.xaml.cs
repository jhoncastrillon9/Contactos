using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Contactos.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class IngresoPage : ContentPage
	{
		public IngresoPage ()
		{
			InitializeComponent ();
		}

        private async void Ingresar_Click(object sender, EventArgs e)
        {
           await Navigation.PushAsync(new ContactosPage());
        }
    }
}