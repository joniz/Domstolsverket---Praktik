using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Domstol
{
	public partial class RemoteControllerTutorialSelectionPage : ContentPage
	{
		public RemoteControllerTutorialSelectionPage()
		{
			InitializeComponent();
		}

		public RemoteControllerTutorialSelectionPage(RemoteController rc)
		{
            InitializeComponent();
			TutorialListView.ItemsSource = rc.ControllerTutorials;
		
		}
		void TutorialSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
		{


			RemoteControllerTutorial rct = e.SelectedItem as RemoteControllerTutorial;
			if (rct != null)
			{


				Navigation.PushModalAsync(new NavigationPage(new RemoteControllerTutorialPage(rct)));
				((ListView)sender).SelectedItem = null;
			}
		}
	}
}
