using System;
using Xamarin.Forms;
using UIKit;
using Domstol;
using Xamarin.Forms.Platform.iOS;

/* Example of using a custom renderer to get the > disclosure indicator to appear */

[assembly: ExportRenderer(typeof(ViewCell), typeof(ListViewCellRenderer))]

namespace Domstol
{
	public class ListViewCellRenderer : ViewCellRenderer
	{

		public override UITableViewCell GetCell(Cell item, UITableViewCell reusableCell, UITableView tv)
		{
			var cell = base.GetCell(item, reusableCell, tv);
   
			cell.Accessory = UITableViewCellAccessory.DisclosureIndicator;


			//cell.ValueForKeyPath;


            return cell;


		}




	}
}
