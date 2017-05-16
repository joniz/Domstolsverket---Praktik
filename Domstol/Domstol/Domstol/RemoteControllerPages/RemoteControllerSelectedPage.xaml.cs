using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Domstol
{
	public partial class RemoteControllerSelectedPage : ContentPage
	{

		public RemoteController remoteController { get; set; }
		public RemoteControllerSelectedPage()
		{
			InitializeComponent();
		}
		public RemoteControllerSelectedPage(RemoteController rc) 
		{
        	InitializeComponent();





			ControllerImage.Source = "RemoteControllers/" + rc.ImageName + "/" + rc.ImageName;

			remoteController = rc;




			bool columnSwitch = true;
			foreach (RemoteControllerButton b in rc.ControllerButtons) 
			{




				b.Image = "RemoteControllers/" + rc.ImageName + "/" + b.ImageName;
				b.WidthRequest = 75;
				b.HeightRequest = 50;
				b.Clicked += ButtonClicked;
				b.Margin = 0;
				b.BackgroundColor = Color.White;


				if (rc.Name == "TRC4" && b.Name != "VideoKällor")
				{
					b.WidthRequest = 100;
					b.HeightRequest = 40;
				}





				//Add buttons on each side of remote controller and one button on top of it. 
				//TRC4 and TRC5
				if (b.Name == "Funktioner" && rc.Name == "TRC5"
				    || b.Name == "VideoKällor" && rc.Name =="TRC4"
				   )
				{
					TheGrid.Children.Add(b, 1, 0);
					
				}

				else if (rc.Name == "TRC5" || rc.Name == "TRC4")
				{

					if (columnSwitch)
					{
						ButtonStack.Children.Add(b);
						columnSwitch = false;
					}
					else
					{
						ButtonStack2.Children.Add(b);
						columnSwitch = true;
					}
				}
				else	                 
					ButtonStack.Children.Add(b);





			}

			Button tutorialButton = new Button() { Text ="Vanliga frågor"};
			tutorialButton.Clicked += TutorialButtonClicked;

			if (rc.ControllerTutorials.Count != 0)
				ButtonStack.Children.Add(tutorialButton);
		}

		public void ButtonClicked(object s, EventArgs e)
		{

			RemoteControllerButton btn = s as RemoteControllerButton;


			Navigation.PushModalAsync(new NavigationPage(new ButtonInfoPage(btn)));
		
		}


		public void TutorialButtonClicked(object s, EventArgs e)
		{
			Navigation.PushAsync(new RemoteControllerTutorialSelectionPage(remoteController));
		
		
		}
	}
}
