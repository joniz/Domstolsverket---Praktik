using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Domstol
{
	public partial class AllQuestionsPage : ContentPage
	{
		public AllQuestionsPage()
		{
			InitializeComponent();
			QuestionListView.ItemsSource = App.AllQuestions;
			NavigationPage.SetBackButtonTitle(this, LanguageStrings.Back);
			//for (int i = 1; i < App.previousQuestions.Count; i++)

				
		}

		void questionSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
		{
			if (((ListView)sender).SelectedItem != null)
			{

				Question q = e.SelectedItem as Question;


				((ListView)sender).SelectedItem = null;



				if (q != null)
					Navigation.PushAsync(new QuestionPage(q));


			}
		}
	}
}
