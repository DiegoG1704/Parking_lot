﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Parking_Lot.views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Login : ContentPage
	{
		public Login()
		{
			InitializeComponent();
		}
		private async void OnLoginButtonEstac(object sender, EventArgs e)
		{
			// Navegación a la página de inicio de sesión (Login.xaml en la carpeta Views)
			await Application.Current.MainPage.Navigation.PushModalAsync(new Index());
		}
	}
}