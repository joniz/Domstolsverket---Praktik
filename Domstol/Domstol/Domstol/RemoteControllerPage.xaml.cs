using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Domstol
{
	public partial class RemoteControllerPage : ContentPage
	{
		public RemoteControllerPage(ExploreListItem selected)
		{
			InitializeComponent();
			Title = selected.name;
		}
	}
}
