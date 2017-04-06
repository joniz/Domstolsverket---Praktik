using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Domstol
{
	public partial class InformationPage : ContentPage
	{
		public InformationPage(ManualListItem selected)
		{
			InitializeComponent();
			Title = selected.name;
		}
	}
}
