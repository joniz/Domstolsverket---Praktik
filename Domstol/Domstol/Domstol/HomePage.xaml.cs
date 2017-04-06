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
				Button category = sender as Button;
			Navigation.PushAsync(new TroubleShootingPage(category.Text));

			

		}
    }
}
