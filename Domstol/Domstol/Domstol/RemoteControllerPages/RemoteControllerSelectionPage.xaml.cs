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


			foreach (RemoteController rc in App.dataRepository.remoteControllers)
			{
				Image i = new Image() { Source = "RemoteControllers/" + rc.ImageName +"/" + rc.ImageName };
				i.WidthRequest = 100;
				i.GestureRecognizers.Add(tgr);
				ControllerStack.Children.Add(i);
			}
				


		}

		void ImageClicked(object s, EventArgs e)
		{
			
			Image image = s as Image;
			FileImageSource imageSource = (FileImageSource)image.Source;


			foreach(RemoteController rc in App.dataRepository.remoteControllers)
				if ((FileImageSource)"RemoteControllers/" + rc.ImageName + "/" + rc.ImageName == imageSource)
					Navigation.PushAsync(new RemoteControllerSelectedPage(rc));

			

		}
}
}
