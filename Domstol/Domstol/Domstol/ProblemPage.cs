using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Domstol
{
	public partial class ProblemPage : ContentPage
	{
		
		public ProblemPage() { InitializeComponent(); }


		public ProblemPage(MyNavigationItem nItem)
		{
			
			InitializeComponent();
			Title = nItem.category;
			NavigationPage.SetBackButtonTitle(this, "Tillbaka");


			problemList.ItemsSource = App.dataRepository.getProblemsByCategoryAndRoom(
					nItem.category, nItem.typeOfRoom);
			
			
		}

		void problemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
		{
			if (((ListView)sender).SelectedItem != null)
			{

				Problem p = e.SelectedItem as Problem;

				Question q = App.dataRepository.getQuestionByID(p.firstQuestionID);

				((ListView)sender).SelectedItem = null;

				if (q != null)
					Navigation.PushAsync(new QuestionPage(q));

			}

		}

	}
}
