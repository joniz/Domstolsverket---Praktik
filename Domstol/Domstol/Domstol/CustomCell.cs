using System;
using Xamarin.Forms;

namespace Domstol
{
	public class CustomCell : ViewCell
	{

		protected override void OnBindingContextChanged()
		{
			base.OnBindingContextChanged();

			// rough translation of character-count to cell height
			// doesn't always work, but close enough for now

			this.Height = 200;
			//if (session.Title.Length > 75)
			//	this.Height = 110;
			//else if (session.Title.Length > 60)
			//	this.Height = 80;
			//else if (session.Title.Length > 30)
			//	this.Height = 60;
			//else
			//	this.Height = 40;
		}
	}
}