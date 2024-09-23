using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Parking_Lot.views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Registrar : ContentPage
	{
		public Registrar()
		{
			InitializeComponent();
		}
		private async void OnLoginButtonNumber(object sender, EventArgs e)
		{
			// Navegación a la página de inicio de sesión (Login.xaml en la carpeta Views)
			await Application.Current.MainPage.Navigation.PushModalAsync(new Number());
		}
	}
}