using System;
using UIKit;
using Xamarin.Forms.Platform.iOS;
using Xamarin.Forms;
using Domstol;

[assembly: ExportRenderer(typeof(GroupedListView), typeof(GroupedListViewRenderer))]

namespace Domstol
{
	public class GroupedListViewRenderer : ListViewRenderer
	{
		protected UITableView tbl;
		protected override void OnElementChanged(ElementChangedEventArgs<ListView> e)
		{
			base.OnElementChanged(e);
			if (this.Control != null && e.NewElement !=null)
			{
				tbl = new UITableView(this.Bounds, UITableViewStyle.Grouped)
				{
					Source = this.Control.Source,
				};


				tbl.BackgroundColor = UIColor.White;



				//Hide unwanted margin at top of grouped UITableView
				var frame = CoreGraphics.CGRect.Empty;
				frame.Height = 1;
				tbl.TableHeaderView = new UIView(frame);


				tbl.ScrollEnabled = false;


				this.SetNativeControl(tbl);


			}


		}


	



	}
}