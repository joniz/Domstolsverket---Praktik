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
			FirstPicture.GestureRecognizers.Add(tgr);
	
		}

		void ImageClicked(object s, EventArgs e)
		{
			
			Image x = s as Image;
			x.IsVisible = false;
		}
}
}
