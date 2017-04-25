using UIKit;
using Xamarin.Forms.Platform.iOS;

namespace Domstol.iOS
{
	public class CustomNavigationRenderer : NavigationRenderer
	{

		public override void WillMoveToParentViewController(UIViewController parent)
		{
			base.WillMoveToParentViewController(parent);
			if (parent == null)
			{
				
			}
		}
		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			if (InteractivePopGestureRecognizer != null)
			{
				InteractivePopGestureRecognizer.Enabled = false;
			}
		}
	}
}