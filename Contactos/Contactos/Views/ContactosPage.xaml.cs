using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Contactos.Models;

namespace Contactos.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ContactosPage : ContentPage
	{
        public List<Contacto> MisContactos { get; set; }

        public ContactosPage ()
		{
			InitializeComponent ();

            CargarContactos();
		}

        private void CargarContactos()
        {
            MisContactos = new List<Contacto>
            {

                new Contacto {Nombres="Juan Rodriguez", Telefono="123456789", Direccion="cra 11", Imagen="noimg.png" },
                new Contacto {Nombres="Daniel Ayala", Telefono="123456789", Direccion="cra 12", Imagen="noimg.png" },
                new Contacto {Nombres="Tulio Galarga", Telefono="123456789", Direccion="cra 13", Imagen="Duck.png" },
                new Contacto {Nombres="Andres Torres", Telefono="123456789", Direccion="cra 14", Imagen="noimg.png" },
                new Contacto {Nombres="Chupame este penco", Telefono="123456789", Direccion="cra 15", Imagen="noimg.png" }
        };
            listContactos.ItemsSource = MisContactos;
        }

        private async void Conctac_Selected(object sender, SelectedItemChangedEventArgs e)
        {
            var contacto = e.SelectedItem as Contacto;
            await Navigation.PushAsync(new DetalleContactoPage(contacto));
        }
    }
}

//Control + . 