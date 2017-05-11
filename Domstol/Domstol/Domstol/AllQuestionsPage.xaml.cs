using System;
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

			App.AllQuestions.Clear();
			Question firstQuestion = App.dataRepository.getQuestionByID(p.firstQuestionID);
			populateQuestionList(firstQuestion);


			QuestionListView.ItemsSource = App.AllQuestions;
			NavigationPage.SetBackButtonTitle(this, LanguageStrings.Back);

		}

		//Add all questions that are related to the starting question
		public static void populateQuestionList(Question q)
		{

			if (q == null)
				return;

			if (q.questionYesID == 0 && q.questionNoID == 0)
				return;

			Question nQuestion = App.dataRepository.getQuestionByID(q.questionNoID);
			Question yQuestion = App.dataRepository.getQuestionByID(q.questionYesID);


			if (q.questionNoID != 0)
				App.AllQuestions.Push(nQuestion);

			if (q.questionYesID != 0 )
				App.AllQuestions.Push(yQuestion);


			populateQuestionList(nQuestion);
			populateQuestionList(yQuestion);	
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
