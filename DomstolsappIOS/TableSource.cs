using System;
using UIKit;
namespace DomstolsappIOS
{
	public class TableSource : UITableViewSource
	{
		string cellIdentifier = "TableCell";
		string[] tableItems;
		public TableSource(string[] items)
		{
			tableItems = items;
		}

		public override nint RowsInSection(UITableView tableview, nint section)
		{
			return tableItems.Length;
		}

		public override UITableViewCell GetCell(UITableView tableView, Foundation.NSIndexPath indexPath)
		{
			UITableViewCell cell = tableView.DequeueReusableCell(cellIdentifier);
			if (cell == null)
				cell = new UITableViewCell(UITableViewCellStyle.Default, cellIdentifier);
			cell.TextLabel.Text = tableItems[indexPath.Row];
			return cell;
		}

		public override void RowSelected(UITableView tableView, Foundation.NSIndexPath indexPath)
		{
			//base.RowSelected(tableView, indexPath);
			new UIAlertView("Titel", tableItems[indexPath.Row], null, "Exit", null).Show();
			tableView.DeselectRow(indexPath, true);
		}
	}
}
