using System;
using System.Collections.Generic;
using Domstol;
using Xamarin.Forms;

namespace Domstol
{
	public partial class QuestionPage : ContentPage
	{


		private Question currentQuestion { get; set; }
		private Question yesQuestion { get; set; }
		private Question noQuestion { get; set; }
		private List<string> ListAlternatives { get; set; }

		public QuestionPage()
		{
			InitializeComponent();
			NavigationPage.SetBackButtonTitle(this, LanguageStrings.Back);
		}
		public QuestionPage(Question question)
		{
			InitializeComponent();
			initializeQuestions(question);

			App.AllQuestions.Push(question);
			quests(question);

		}

		public void quests(Question q)
		{

			if (q.questionYesID != 0)
				App.AllQuestions.Push(App.dataRepository.getQuestionByID(q.questionYesID));
			if (q.questionNoID != 0)
				App.AllQuestions.Push(App.dataRepository.getQuestionByID(q.questionNoID));

			if (q.questionYesID != 0)
				quests(App.dataRepository.getQuestionByID(q.questionYesID));

			if (q.questionNoID != 0)
				quests(App.dataRepository.getQuestionByID(q.questionNoID));

		}

		public QuestionPage(Question question, string previousAnswer)
		{
			InitializeComponent();
			initializeQuestions(question);
		}




		public void initializeQuestions(Question question)
		{
			currentQuestion = question;
			questionLabel.Text = question.questionText;
			yesQuestion = App.dataRepository.getQuestionByID(currentQuestion.questionYesID);
			noQuestion = App.dataRepository.getQuestionByID(currentQuestion.questionNoID);

			ListAlternatives = new List<string>();


			if (yesQuestion != null)
				ListAlternatives.Add(LanguageStrings.Yes);
					

			if (noQuestion != null)
				ListAlternatives.Add(LanguageStrings.No);
			
			if (question.questionMoreInfo != null)
				ListAlternatives.Add(LanguageStrings.MoreInfo);


			ListAlternatives.Add(LanguageStrings.AllQuestions);


			if(question.questionSupportNumber != null)
				ListAlternatives.Add(LanguageStrings.CallSupport);

			if(yesQuestion == null)
				ListAlternatives.Add(LanguageStrings.BackToMenu);


			NavigationPage.SetBackButtonTitle(this, LanguageStrings.Back);
			ButtonList.ItemsSource = ListAlternatives;

		}


	




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
						Navigation.PushAsync(new QuestionPage(yesQuestion, LanguageStrings.Yes));
					}
				

				}

				if (selectedChoice == LanguageStrings.No)
				{
					if (noQuestion != null)
					{
						Navigation.PushAsync(new QuestionPage(noQuestion, LanguageStrings.No));
			
					}

				}

				if (selectedChoice == LanguageStrings.AllQuestions)
				{
					Navigation.PushAsync(new AllQuestionsPage());

				}

				if (selectedChoice == LanguageStrings.BackToMenu)
				{

					 Navigation.PopToRootAsync();



				}
				if (selectedChoice == LanguageStrings.CallSupport)
				{

					var dialer = DependencyService.Get<IDialer>();
					if (dialer != null)
						dialer.DialAsync(currentQuestion.questionSupportNumber);

				}
				if (selectedChoice == LanguageStrings.MoreInfo) 
				{
					Navigation.PushModalAsync(new NavigationPage(new MoreInfoPage(currentQuestion)));
				
				
				
				}
			}

		}
	}
}
