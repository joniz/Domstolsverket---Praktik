using System;
using UIKit;
using Xamarin.Forms.Platform.iOS;
using Xamarin.Forms;
using MyNamespace;
using Domstol;

[assembly: ExportRenderer(typeof(ListView), typeof(StandardListViewRenderer))]

namespace MyNamespace
{
	public class StandardListViewRenderer : ListViewRenderer
	{
		protected override void OnElementChanged(ElementChangedEventArgs<ListView> e)
		{
			base.OnElementChanged(e);
			if (this.Control != null)
			{




				this.Control.TableFooterView = new UIView();





			}
		}





	}
}