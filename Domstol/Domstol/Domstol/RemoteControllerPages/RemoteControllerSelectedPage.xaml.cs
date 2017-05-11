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
			string strFileName = objFileImageSource.File;


			ControllerImage.Source = strFileName;


			foreach (Button b in rc.ControllerButtons) 
			{
				ButtonStack.Children.Add(b);
			
			
			}
		}
	}
}
