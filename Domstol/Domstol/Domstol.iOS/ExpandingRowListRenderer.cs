using System;
using UIKit;
using Xamarin.Forms.Platform.iOS;
using Xamarin.Forms;
using MyNamespace;
using Domstol;

[assembly: ExportRenderer(typeof(ExpandingRowList), typeof(ExpandingRowListRenderer))]

namespace MyNamespace
{
	public class ExpandingRowListRenderer : MyListViewRenderer
	{
		protected override void OnElementChanged(ElementChangedEventArgs<ListView> e)
		{
			base.OnElementChanged(e);
			if (this.Control != null)
			{

				tbl.RowHeight = 200;

			





				this.SetNativeControl(tbl);

			}
		}





	}
}