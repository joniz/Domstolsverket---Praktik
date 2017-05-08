using System;
using UIKit;
using Xamarin.Forms.Platform.iOS;
using Xamarin.Forms;
using MyNamespace;
using Domstol;

[assembly: ExportRenderer(typeof(ExpandingRowList), typeof(ExpandingRowListRenderer))]

namespace MyNamespace
{
	public class ExpandingRowListRenderer : ListViewRenderer
	{
		protected override void OnElementChanged(ElementChangedEventArgs<ListView> e)
		{
			base.OnElementChanged(e);
			if (this.Control != null)
			{

				//Set height of the rows in the tableview
				this.Control.RowHeight = 80;


				this.Control.TableFooterView = new UIView();





			}
		}





	}
}