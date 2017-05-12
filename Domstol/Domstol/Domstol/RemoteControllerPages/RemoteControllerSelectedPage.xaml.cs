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

			FileImageSource objFileImageSource = (FileImageSource)rc.ControllerImage.Source;



			ControllerImage.Source = objFileImageSource.File;


			foreach (Button b in rc.ControllerButtons) 
			{
				if (rc.ControllerButtons.Count > 9)
				{
					b.WidthRequest = 35;
					b.HeightRequest = 35;
				}
				else
				{
					b.WidthRequest = 50;
					b.HeightRequest = 50;
				}
				ButtonStack.Children.Add(b);
			
			
			}
		}
	}
}
