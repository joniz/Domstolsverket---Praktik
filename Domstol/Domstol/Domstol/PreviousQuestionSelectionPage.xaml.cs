using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Domstol
{
	public partial class PreviousQuestionSelectionPage : ContentPage
	{
		public PreviousQuestionSelectionPage()
		{
			InitializeComponent();
			QuestionListView.ItemsSource = App.previousQuestions;
		}

		void questionSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
		{
			if (((ListView)sender).SelectedItem != null)
			{

				Question q = e.SelectedItem as Question;


				((ListView)sender).SelectedItem = null;



				if (q != null)
					Navigation.PushModalAsync(new PreviousQuestionPage(q));


			}
		}
	}
}
