using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DomstolsappFORM
{
	public partial class HomePage : ContentPage
	{
		void ButtonClicked(object sender, System.EventArgs e)
		{
			Navigation.PushAsync(new TroubleShootingPage());
		}

		public HomePage()
		{
			InitializeComponent();
		}
	}
}
