using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Domstol
{
	public partial class ProblemTypePage : ContentPage
	{

		private MyNavigationItem nItem { get; set; }

		public ProblemTypePage() { InitializeComponent();}

		public ProblemTypePage(MyNavigationItem n)
		{
			InitializeComponent();

			nItem = n;
			Title = nItem.typeOfRoom.ToString();
			Roompic.Source = nItem.imageName;

			List<string> problemtypes = new List<string>();
			problemtypes.Add(Category.Audio);
			problemtypes.Add(Category.Video);

			Lista.ItemsSource = problemtypes;


		}

		void problemTypeSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
		{


			string listText = e.SelectedItem as string;



			if (listText != null)
			{

				if (listText == Category.Video)
				{
					nItem.category = Category.Video;
					Navigation.PushAsync(new ProblemPage(nItem));
				}
				if (listText == Category.Audio)
				{
					nItem.category = Category.Audio;
					Navigation.PushAsync(new ProblemPage(nItem));
				}

				((ListView)sender).SelectedItem = null;




			}
	
		}

	
	}
}

