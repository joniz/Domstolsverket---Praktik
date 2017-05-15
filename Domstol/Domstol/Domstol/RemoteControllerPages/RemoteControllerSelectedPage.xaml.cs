using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Domstol
{
	public partial class RemoteControllerSelectedPage : ContentPage
	{
		public RemoteControllerSelectedPage()
		{
			InitializeComponent();
		}
		public RemoteControllerSelectedPage(RemoteController rc) 
		{
        	InitializeComponent();





			ControllerImage.Source = "RemoteControllers/" + rc.ImageName + "/" + rc.ImageName;






			bool e = true;
			foreach (RemoteControllerButton b in rc.ControllerButtons) 
			{




				b.Image = "RemoteControllers/" + rc.ImageName + "/" + b.ImageName;
				b.WidthRequest = 75;
				b.HeightRequest = 50;
				b.Clicked += ButtonClicked;
				b.Margin = 0;
                b.BackgroundColor = Color.White;
				if (rc.Name == "TRC4")
				{
					b.WidthRequest = 120;
					b.HeightRequest = 40;
				
				}








				if (b.Name == "Funktioner" && rc.Name == "TRC5")
				{
					TheGrid.Children.Add(b, 1, 0);
					
				}

				else if (rc.Name == "TRC5")
				{

					if (e)
					{
						ButtonStack.Children.Add(b);
						e = false;
					}
					else
					{
						ButtonStack2.Children.Add(b);
						e = true;
					}
				}
				else	                 
					ButtonStack.Children.Add(b);
				
				
				
			
			}
		}
		public void ButtonClicked(object s, EventArgs e)
		{

			RemoteControllerButton btn = s as RemoteControllerButton;


			Navigation.PushModalAsync(new NavigationPage(new ButtonInfoPage(btn)));
		
		}
	}
}
