using System;
using System.Linq;
using System.Reflection;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;



[assembly: ExportRenderer(typeof(NavigationPage), typeof(Domstol.iOS.CustomBackButton))]

namespace Domstol.iOS
{

	public class CustomBackButton : NavigationRenderer
	{
		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			var attrs = new UITextAttributes()
			{
				
				TextColor = UIColor.FromRGB(102,153,204),
				TextShadowColor = UIColor.Black,


			};


			//Color of backbutton
			UINavigationBar.Appearance.TintColor = UIColor.FromRGB(102,153,204);


			//Appearence of title text
			UINavigationBar.Appearance.SetTitleTextAttributes(attrs);
			NavigationItem.Title = "FromRenderer";

		}

	}
}
