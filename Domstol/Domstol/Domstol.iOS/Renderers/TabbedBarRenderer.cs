using System;
using Domstol.iOS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using UIKit;
[assembly: ExportRenderer(typeof(TabbedPage), typeof(TabbedBarRenderer))]
namespace Domstol.iOS
{
	public class TabbedBarRenderer : TabbedRenderer
	{
		protected override void OnElementChanged(VisualElementChangedEventArgs e)
		{
			base.OnElementChanged(e);

			TabBar.TintColor = UIColor.FromRGB(102, 153, 204);
			//TabBar.BarTintColor = UIColor.FromRGB(255, 128, 0);
			//TabBar.BackgroundColor = UIColor.Gray;
		
		}
		

	
	}
}
