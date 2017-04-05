using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DomstolsappFORM
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
