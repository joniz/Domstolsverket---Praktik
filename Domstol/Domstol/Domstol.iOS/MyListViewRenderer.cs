using System;
using UIKit;
using Xamarin.Forms.Platform.iOS;
using Xamarin.Forms;
using MyNamespace;

[assembly: ExportRenderer(typeof(ListView), typeof(MyListViewRenderer))]

namespace MyNamespace
{
	public class MyListViewRenderer : ListViewRenderer
	{
		protected override void OnElementChanged(ElementChangedEventArgs<ListView> e)
		{
			base.OnElementChanged(e);
			if (this.Control != null)
			{
				var tbl = new UITableView(this.Bounds, UITableViewStyle.Grouped)
				{
					Source = this.Control.Source,

				};


				tbl.BackgroundColor = UIColor.White;

				CoreGraphics.CGRect frame = new CoreGraphics.CGRect(0,0,0,0);
				this.Control.TableHeaderView = frame;
				this.SetNativeControl(tbl);
			


				this.Control.ScrollEnabled = false;
			}
		}




	}
}