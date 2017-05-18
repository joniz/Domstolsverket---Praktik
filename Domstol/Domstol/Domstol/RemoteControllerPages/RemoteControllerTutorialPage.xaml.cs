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

			var largeSize = Device.GetNamedSize(NamedSize.Large, typeof(Label));


			TutorialStack.Children.Add(new Label() { Text = rct.Question, TextColor = Color.FromHex("6699CC"),
				FontAttributes= FontAttributes.Italic, FontSize = largeSize });



			TutorialStack.Children.Add(new Label() { Text = rct.Answer, FontSize = largeSize });
			TutorialStack.Children.Add(new Image() { 
				Source = "RemoteControllers/TutorialImages/" + rct.RemoteTutorialImageName });


			foreach (RemoteController r in App.dataRepository.remoteControllers)
				if (r.ID == rct.ControllerID)
					Title = r.Name;
			
			


		}

		void DoneButtonClicked(object sender, System.EventArgs e)
		{
			Navigation.PopModalAsync();
		}
	}
}
