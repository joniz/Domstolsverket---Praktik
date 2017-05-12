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
				


				Button btn = new Button() { Image = "RemoteControllers/" + rc.ImageName + "/" + b.ImageName };
				btn.WidthRequest = 75;
				btn.HeightRequest = 50;


				if (rc.ControllerButtons.Count > 9)
				{

					if (e)
					{
						ButtonStack.Children.Add(btn);
						e = false;
					}
					else
					{
						ButtonStack2.Children.Add(btn);
						e = true;
					}
				}
				else 
				{
					ButtonStack.Children.Add(btn);
				
				
				}
			
			}
		}
	}
}
