using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Domstol
{
	public partial class ProblemPage : ContentPage
	{
		
		public ProblemPage() { InitializeComponent(); }


		public ProblemPage(NavigationItem nItem)
		{
			
			InitializeComponent();
			Title = nItem.typeOfRoom + " -> " + nItem.category;


			problemList.ItemsSource = App.dataRepository.problems;
		}

		void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
		{
			Problem p = e.SelectedItem as Problem;


			Question q = App.dataRepository.getQuestionByID(p.firstQuestionID);



			if(q != null)
				Navigation.PushAsync(new QuestionPage(q));
		}

	}
}
