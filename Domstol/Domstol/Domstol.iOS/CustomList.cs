using System;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;


[assembly: ExportRenderer(typeof(ListView), typeof(Domstol.CustomList))]
namespace Domstol
{
	public class CustomList : ListViewRenderer
	{
		protected override void OnElementChanged(ElementChangedEventArgs<ListView> e)
		{
			base.OnElementChanged(e);

			if (this.Control == null) return;

			this.Control.TableFooterView = new UIView();
		
		}
		}
}
