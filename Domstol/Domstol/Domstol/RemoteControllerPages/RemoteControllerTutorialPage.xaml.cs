using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Domstol
{
	public partial class RemoteControllerTutorialPage : ContentPage
	{
		public RemoteControllerTutorialPage()
		{
			InitializeComponent();
		}
		public RemoteControllerTutorialPage(RemoteControllerTutorial rct)
		{
			InitializeComponent();
			TutorialLabel.Text = rct.Answer;
		}

		void DoneButtonClicked(object sender, System.EventArgs e)
		{
			Navigation.PopModalAsync();
		}
	}
}
