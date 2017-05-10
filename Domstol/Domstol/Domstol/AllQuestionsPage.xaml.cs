﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Domstol
{
	public partial class AllQuestionsPage : ContentPage
	{
		private Problem currentProblem{ get; set; }
		public AllQuestionsPage(Problem p, Question q)
		{
			currentProblem = p;
			InitializeComponent();

			QuestionListView.ItemsSource = App.AllQuestions;
			NavigationPage.SetBackButtonTitle(this, LanguageStrings.Back);

		}




		void questionSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
		{
			if (((ListView)sender).SelectedItem != null)
			{

				Question q = e.SelectedItem as Question;


				((ListView)sender).SelectedItem = null;



				if (q != null)
					Navigation.PushAsync(new QuestionPage(currentProblem, q));


			}
		}
	}
}
