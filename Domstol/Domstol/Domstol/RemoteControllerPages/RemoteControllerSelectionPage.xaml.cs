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
			
			Image x = s as Image;

			FileImageSource objFileImageSource = (FileImageSource)x.Source;
			string strFileName = objFileImageSource.File;


			foreach(RemoteController rc in RemoteControllerCollection.RemoteControllers)
				if((FileImageSource)rc.ControllerImage.Source == objFileImageSource)
					Navigation.PushAsync(new RemoteControllerSelectedPage(rc));

			

		}
}
}
