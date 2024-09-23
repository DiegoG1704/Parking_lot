using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Parking_Lot.views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Estacionamiento : ContentPage
	{
		public Estacionamiento()
		{
			InitializeComponent();
		}

		private void OnBotonLibreClicked(object sender, EventArgs e)
		{
			// Cambiar el color del botón "Libre" a verde oscuro y el botón "Ocupado" a blanco
			botonLibre.BackgroundColor = Color.FromHex("#063A34"); // Color verde oscuro
			botonLibre.TextColor = Color.White;

			botonOcupado.BackgroundColor = Color.FromHex("#182724");
			botonOcupado.TextColor = Color.White;
		}

		private void OnBotonOcupadoClicked(object sender, EventArgs e)
		{
			// Cambiar el color del botón "Ocupado" a verde oscuro y el botón "Libre" a blanco
			botonOcupado.BackgroundColor = Color.FromHex("#063A34"); // Color verde oscuro
			botonOcupado.TextColor = Color.White;

			botonLibre.BackgroundColor = Color.FromHex("#182724");
			botonLibre.TextColor = Color.White;
		}
	}
}
