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
		private bool BackButtonWasPressed { get; set; }
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
		}

		public QuestionPage(Question question, string previousAnswer)
		{
			InitializeComponent();
			initializeQuestions(question);
			initializePage(previousAnswer);
		}




		public void initializeQuestions(Question question)
		{
			currentQuestion = question;
			questionLabel.Text = question.questionText;
			yesQuestion = App.dataRepository.getQuestionByID(currentQuestion.questionYesID);
			noQuestion = App.dataRepository.getQuestionByID(currentQuestion.questionNoID);

			ListAlternatives = new List<string>() { LanguageStrings.Yes,
				LanguageStrings.No};

			if (question.questionMoreInfo != null)
				ListAlternatives.Add(LanguageStrings.MoreInfo);

			if (App.previousQuestions.Count > 0)
				ListAlternatives.Add(LanguageStrings.PreviousQuestions);


			NavigationPage.SetBackButtonTitle(this, LanguageStrings.Back);
			ButtonList.ItemsSource = ListAlternatives;
			BackButtonWasPressed = true;

		}

	


		public void initializePage(string previousAnswer)
		{


			//Check if it's the last question and if we came from a 'Yes' alternative
			if (yesQuestion == null && noQuestion == null && previousAnswer == LanguageStrings.Yes)
			{
				ListAlternatives.Clear();
				ListAlternatives.Add(LanguageStrings.BackToMenu);

			}


			//Check if it's the last question and if we came from a 'No' alternative
			if (yesQuestion == null && noQuestion == null && previousAnswer == LanguageStrings.No)
			{
				ListAlternatives.Clear();
				ListAlternatives.Add(LanguageStrings.BackToMenu);
				ListAlternatives.Add(LanguageStrings.CallSupport);
			}


		}

		protected override void OnDisappearing()
		{
			base.OnDisappearing();
			if (BackButtonWasPressed)
				App.previousQuestions.Pop();

			BackButtonWasPressed = true;
		}

		void MoreInfoButtonClicked(object sender, System.EventArgs e)
		{
			Navigation.PushModalAsync(new NavigationPage(new MoreInfoPage(currentQuestion)));
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
						App.previousQuestions.Push(currentQuestion);
						Navigation.PushAsync(new QuestionPage(yesQuestion, LanguageStrings.Yes));
						BackButtonWasPressed = false;
					}

				}
				if (selectedChoice == LanguageStrings.No)
				{
					if (noQuestion != null)
					{

						App.previousQuestions.Push(currentQuestion);
						Navigation.PushAsync(new QuestionPage(noQuestion, LanguageStrings.No));
						BackButtonWasPressed = false;
					}

				}
				if (selectedChoice == LanguageStrings.PreviousQuestions)
				{
					Navigation.PushAsync(new PreviousQuestionSelectionPage());
					BackButtonWasPressed = false;

				}
				if (selectedChoice == LanguageStrings.BackToMenu)
				{
					Navigation.PopToRootAsync();
					App.previousQuestions.Clear();

				}
				if (selectedChoice == LanguageStrings.CallSupport)
				{

					var dialer = DependencyService.Get<IDialer>();
					if (dialer != null)
						dialer.DialAsync("0364422000");



				}
			}

		}
	}
}
