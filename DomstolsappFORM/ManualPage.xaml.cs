using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DomstolsappFORM
{
	public partial class ManualPage : ContentPage
	{
		void OnItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
		{
			if (e.SelectedItem != null) 
			{
				var selected = e.SelectedItem as Item;
				Navigation.PushAsync(new InformationPage(selected));
			
			}
		}


	



		public ManualPage()
		{
			InitializeComponent();



			itemlist.ItemsSource = Item.items;

		}
	}
}
