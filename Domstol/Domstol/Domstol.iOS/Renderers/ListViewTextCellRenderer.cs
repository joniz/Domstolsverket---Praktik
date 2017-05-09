using System;
using Domstol.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;


[assembly: ExportRenderer(typeof(TextCell), typeof(ListViewTextCellRenderer))]
namespace Domstol.iOS
{
	public class ListViewTextCellRenderer : TextCellRenderer
	{
		public override UIKit.UITableViewCell GetCell(Cell item, UIKit.UITableViewCell reusableCell, UIKit.UITableView tv)
		{

			var cell = base.GetCell(item, reusableCell, tv);
			cell.Accessory = UITableViewCellAccessory.DisclosureIndicator;
			return cell;
		}
	}
}
