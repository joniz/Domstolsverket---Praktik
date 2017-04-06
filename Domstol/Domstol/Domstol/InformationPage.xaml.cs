using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Domstol
{
	public partial class InformationPage : ContentPage
	{
		public InformationPage(Item selected)
		{
			InitializeComponent();
			Title = selected.name;
		}
	}
}
