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

			//UINavigationBar.Appearance.BarTintColor = UIColor.DarkGray;



			//this.NavigationItem.LeftBarButtonItem.TintColor = UIColor.Red;
		}

	}
}
