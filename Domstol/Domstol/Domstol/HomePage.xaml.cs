using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Domstol
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }
		void ButtonClicked(object sender, System.EventArgs e)
		{
			Navigation.PushAsync(new TroubleShootingPage());
		}
    }
}
