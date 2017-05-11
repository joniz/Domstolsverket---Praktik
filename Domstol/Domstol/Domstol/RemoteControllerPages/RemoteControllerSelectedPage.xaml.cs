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
				ButtonStack.Children.Add(b);
			
			
			}
		}
	}
}
