using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Parking_Lot.views;

namespace Parking_Lot
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

		// Evento para el botón de iniciar sesión
		private async void OnLoginButtonClicked(object sender, EventArgs e)
		{
			// Navegación a la página de inicio de sesión (Login.xaml en la carpeta Views)
			await Application.Current.MainPage.Navigation.PushModalAsync(new Login());
		}

		// Evento para el botón de registrarse
		private async void OnRegisterButtonClicked(object sender, EventArgs e)
		{
			// Lógica para navegar a la página de registro (si existe en Views)
			await Application.Current.MainPage.Navigation.PushModalAsync(new Registrar());
		}
	}
}
