using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using System.Linq;
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


			var exde = SetupList();
			//Lista.ItemsSource = App.dataRepository.getProblemsByRoom(nItem.typeOfRoom);
			itemListView.ItemsSource = SetupList();


		}

		public List<ProblemList> SetupList()
		{
			var allListItemGroups = new List<ProblemList>();
			var l1 = App.dataRepository.getProblemsByCategoryAndRoom(LanguageStrings.Audio, nItem.typeOfRoom);
			var l2 = App.dataRepository.getProblemsByCategoryAndRoom(LanguageStrings.Video, nItem.typeOfRoom);

			var problemlist1 = new ProblemList();
			var problemlist2 = new ProblemList();

			problemlist1.Category = LanguageStrings.Audio;
			problemlist2.Category = LanguageStrings.Video;

			foreach (Problem p in l1)
				problemlist1.Add(p);

			foreach (Problem p in l2)
				problemlist2.Add(p);

			allListItemGroups.Add(problemlist1);
			allListItemGroups.Add(problemlist2);
			return allListItemGroups;
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

