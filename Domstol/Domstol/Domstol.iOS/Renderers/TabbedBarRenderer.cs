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



			//Color of 
			TabBar.TintColor = UIColor.FromRGB(102, 153, 204);
				
		}
		

	
	}
}
