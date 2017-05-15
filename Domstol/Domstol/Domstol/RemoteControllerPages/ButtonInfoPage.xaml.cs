using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Domstol
{
	public partial class ButtonInfoPage : ContentPage
	{
		public ButtonInfoPage(RemoteControllerButton b)
		{
			InitializeComponent();
			ButtonInfoLabel.Text = b.Description;
		}

		void BackButton(object sender, System.EventArgs e)
		{
			Navigation.PopModalAsync();
		}
	}
}
