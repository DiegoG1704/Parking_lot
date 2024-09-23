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
	public partial class Index : MasterDetailPage
	{
		public Index ()
		{
			InitializeComponent ();
			this.Master = new bard();
			this.Detail = new NavigationPage(new Detail());
		}
	}
}