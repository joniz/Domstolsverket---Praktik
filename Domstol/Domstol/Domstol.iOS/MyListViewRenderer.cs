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
		protected UITableView tbl;
		protected override void OnElementChanged(ElementChangedEventArgs<ListView> e)
		{
			base.OnElementChanged(e);
			if (this.Control != null)
			{
				tbl = new UITableView(this.Bounds, UITableViewStyle.Grouped)
				{
					Source = this.Control.Source,
				};


				tbl.BackgroundColor = UIColor.White;



				//Hide unwanted margin at top of UITableView
				var frame = CoreGraphics.CGRect.Empty;
				frame.Height = 1;
				tbl.TableHeaderView = new UIView(frame);


				tbl.ScrollEnabled = false;


				this.SetNativeControl(tbl);

			}
		}

	



	}
}