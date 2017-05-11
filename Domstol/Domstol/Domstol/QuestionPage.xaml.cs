using System;
using System.Collections.Generic;
using Domstol;
using Xamarin.Forms;

namespace Domstol
{
	public partial class QuestionPage : ContentPage
	{


		private Problem currentProblem { get; set; }
		private Question currentQuestion { get; set; }
		private Question yesQuestion { get; set; }
		private Question noQuestion { get; set; }
		private List<string> ListAlternatives { get; set; }

		public QuestionPage()
		{
			InitializeComponent();
			NavigationPage.SetBackButtonTitle(this, LanguageStrings.Back);
		}


		public QuestionPage(Problem p, Question question)
		{
			currentProblem = p;
			InitializeComponent();
			initializeQuestions(question);




			App.AllQuestions.Clear();
			Question firstQuestion = App.dataRepository.getQuestionByID(p.firstQuestionID);
			AllQuestionsPage.populateQuestionList(firstQuestion);

			Title = getQuestionIndex(currentQuestion).ToString() + " av " + App.AllQuestions.Count.ToString();


		}



		public QuestionPage(Problem p, Question question, string previousAnswer)
		{
			currentProblem = p;
			InitializeComponent();
			initializeQuestions(question);


			Title = getQuestionIndex(currentQuestion).ToString() + " av " + App.AllQuestions.Count.ToString();


		}

		public int getQuestionIndex(Question q) 
		{
			for (int i = 0; i < App.AllQuestions.Count; i++) 
				if (App.AllQuestions[i] == q)
					return i;

			return 0;
			
		
		}



		public void initializeQuestions(Question question)
		{
			currentQuestion = question;
			questionLabel.Text = question.questionText;
			yesQuestion = App.dataRepository.getQuestionByID(currentQuestion.questionYesID);
			noQuestion = App.dataRepository.getQuestionByID(currentQuestion.questionNoID);

			ListAlternatives = new List<string>();

			ListAlternatives.Add(LanguageStrings.Yes);
					
			if (noQuestion != null)
				ListAlternatives.Add(LanguageStrings.No);


			if (question.questionMoreInfo != null || question.questionMoreInfoImageName != null)
				MoreInfoButton.IsVisible = true;

			if (question.questionSupportNumber != null)
			{
				SupportLabel.IsVisible = true;
				SupportLabel.Text = currentQuestion.questionSupportNumber;
				SupportLabel.TextColor = Color.Blue;
		

				var tgr = new TapGestureRecognizer();
				tgr.Tapped +=(s,e)=>SupportLabelClicked();
				SupportLabel.GestureRecognizers.Add(tgr);
			}


			if (Device.RuntimePlatform == TargetPlatform.Android.ToString())
			{
				//Android related code 
				ListAlternatives.Add(LanguageStrings.BackToMenu);
			}


			if (yesQuestion == null && noQuestion == null)
			{
				ListAlternatives.Remove(LanguageStrings.Yes);
				ListAlternatives.Remove(LanguageStrings.No);

			}

			NavigationPage.SetBackButtonTitle(this, LanguageStrings.Back);
			ButtonList.ItemsSource = ListAlternatives;

		}

		////Add all questions that are related to the starting question
		//public void populateQuestionList(Question q)
		//{

		//	if (q == null)
		//		return;

		//	if (q.questionYesID == 0 && q.questionNoID == 0)
		//		return;

		//	Question nQuestion = App.dataRepository.getQuestionByID(q.questionNoID);
		//	Question yQuestion = App.dataRepository.getQuestionByID(q.questionYesID);


		//	if (q.questionNoID != 0)
		//		App.AllQuestions.Push(nQuestion);

		//	if (q.questionYesID != 0)
		//		App.AllQuestions.Push(yQuestion);


		//	populateQuestionList(nQuestion);
		//	populateQuestionList(yQuestion);
		//}
	
		protected override void OnDisappearing()
		{
			base.OnDisappearing();


			//Reset list to unselect all rows
		
			initializeQuestions(currentQuestion);

		}



		void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
		{

			if (((ListView)sender).SelectedItem != null)
			{
				string selectedChoice = e.SelectedItem as string;

				((ListView)sender).SelectedItem = null;

				if (selectedChoice == LanguageStrings.Yes)
				{

					if (yesQuestion != null)
					{
						App.AllQuestions.Push(currentQuestion);
						Navigation.PushAsync(new QuestionPage(currentProblem, yesQuestion, LanguageStrings.Yes));
					}
				

				}

				if (selectedChoice == LanguageStrings.No)
				{
					if (noQuestion != null)
					{
						Navigation.PushAsync(new QuestionPage(currentProblem, noQuestion, LanguageStrings.No));
			
					}

				}

				if (selectedChoice == LanguageStrings.BackToMenu)
				{

					 Navigation.PopToRootAsync();

				}

			}

		}

		void AllQuestionsClicked(object sender, System.EventArgs e)
		{
			Navigation.PushAsync(new AllQuestionsPage(currentProblem, currentQuestion));
		}

		void MoreInfoClicked(object sender, System.EventArgs e)
		{
			Navigation.PushModalAsync(new NavigationPage(new MoreInfoPage(currentQuestion)));
		}

		void SupportLabelClicked()
		{
			var dialer = DependencyService.Get<IDialer>();
			if (dialer != null)
				dialer.DialAsync(currentQuestion.questionSupportNumber);
		}


	}
}
