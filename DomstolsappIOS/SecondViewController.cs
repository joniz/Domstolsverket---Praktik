using System;

using UIKit;

namespace DomstolsappIOS
{
	public partial class SecondViewController : UIViewController
	{
		protected SecondViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.


			initializeTable();
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}

		public void initializeTable()
		{ 
		UITableView _table;
			string[] items = { "Data", "Pekskärm", "Ljud", "Salsteknik", "Säkerhet" };
			_table = new UITableView
			{
				Frame = new CoreGraphics.CGRect(0, 30, View.Bounds.Width, View.Bounds.Height - 30),
				Source = new TableSource(items)

			};
			View.Add(_table);
		
		
		}
	}
}
