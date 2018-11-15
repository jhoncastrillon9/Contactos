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
	public partial class DetalleContactoPage : ContentPage
	{
		public DetalleContactoPage (Contacto contacto)
		{
			InitializeComponent ();
            BindingContext = contacto;
		}
	}
}