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
			NavigationPage.SetBackButtonTitle(this, "Tillbaka");




			List<string> problemtypes = new List<string>();
			problemtypes.Add(LanguageStrings.Audio);
			problemtypes.Add(LanguageStrings.Video);

			Lista.ItemsSource = problemtypes;


		}

		void problemTypeSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
		{


			string listText = e.SelectedItem as string;



			if (listText != null)
			{

				if (listText == LanguageStrings.Video)
				{
					nItem.category = LanguageStrings.Video;
					Navigation.PushAsync(new ProblemPage(nItem));
				}
				if (listText == LanguageStrings.Audio)
				{
					nItem.category = LanguageStrings.Audio;
					Navigation.PushAsync(new ProblemPage(nItem));
				}

				((ListView)sender).SelectedItem = null;




			}
	
		}

	
	}
}

