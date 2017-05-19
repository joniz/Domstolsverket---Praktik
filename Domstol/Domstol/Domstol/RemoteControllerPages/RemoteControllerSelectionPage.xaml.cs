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
			Title = "Fjärrkontroller";

			var tgr = new TapGestureRecognizer();
			tgr.Tapped +=(s,e)=>ImageClicked(s,e);


			List<RemoteController> controllers = App.dataRepository.remoteControllers;

			if (Device.RuntimePlatform == Device.Android)
			{
				foreach (RemoteController r in controllers)
					if (r.Name == "TRC3")
					{
						controllers.Remove(r);
						break;
					}
			}
				


			for (int i = 0; i < controllers.Count; i++)
			{
				Image image = new Image() { 
					Source = "RemoteControllers/" + controllers[i].ImageName +"/" + controllers[i].ImageName };


				image.WidthRequest = 100;
				image.GestureRecognizers.Add(tgr);


				ColumnDefinition c = new ColumnDefinition();
				TheGrid.ColumnDefinitions.Add(c);
				TheGrid.Children.Add(image,i,1);


			}
				


		}

		void ImageClicked(object s, EventArgs e)
		{
			
			Image image = s as Image;
			FileImageSource imageSource = (FileImageSource)image.Source;


			foreach (RemoteController rc in App.dataRepository.remoteControllers)
				if ((FileImageSource)"RemoteControllers/" + rc.ImageName + "/" + rc.ImageName == imageSource) 
					Navigation.PushAsync(new RemoteControllerSelectedPage(rc));
			
				
					

			

		}
}
}
