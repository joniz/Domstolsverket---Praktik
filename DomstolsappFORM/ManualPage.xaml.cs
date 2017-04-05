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
				DisplayAlert("Title", selected.name, "Quit");
			
			
			}
		}

		void Handle_Clicked(object sender, System.EventArgs e)
		{
			Navigation.PushAsync(new InformationPage());
		}

		public ManualPage()
		{
			InitializeComponent();

			Title = "Information";


			itemlist.ItemsSource = Item.items;
	
		}
	}
}
