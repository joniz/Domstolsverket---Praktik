using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Domstol
{
	public partial class RemoteControllerSelectionPage : ContentPage
	{

		public RemoteControllerSelectionPage()
		{
			InitializeComponent();
			Title = "fjärrkontroller";

			var tgr = new TapGestureRecognizer();
			tgr.Tapped +=(s,e)=>ImageClicked(s,e);


			foreach (RemoteController rc in RemoteControllerCollection.RemoteControllers)
			{
				rc.ControllerImage.WidthRequest = 100;
				rc.ControllerImage.GestureRecognizers.Add(tgr);
				ControllerStack.Children.Add(rc.ControllerImage);
			}
				


		}

		void ImageClicked(object s, EventArgs e)
		{
			
			Image image = s as Image;
			FileImageSource imageSource = (FileImageSource)image.Source;


			foreach(RemoteController rc in RemoteControllerCollection.RemoteControllers)
				if ((FileImageSource)rc.ControllerImage.Source == imageSource)
					Navigation.PushAsync(new RemoteControllerSelectedPage(rc));

			

		}
}
}
