using System;
using System.Collections.Generic;
using Domstol;
using Xamarin.Forms;

namespace Domstol
{
	public partial class QuestionPage : ContentPage
	{
		

		void Handle_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			int questionIndex = dropdownlist.SelectedIndex;
			if(questionIndex >= 0)
				Navigation.PushModalAsync(new PreviousQuestionPage(App.previousQuestions[questionIndex]));
			
			BackButtonWasPressed = false;
			dropdownlist.SelectedIndex = -1;
		
		}




		private Question currentQuestion { get; set; }
		private Question yesQuestion { get; set; }
		private Question noQuestion { get; set; }
		private bool BackButtonWasPressed { get; set; }



		public QuestionPage() 
		{
            InitializeComponent();
			NavigationPage.SetBackButtonTitle(this, "Tillbaka");
		}
		public QuestionPage(Question question)
		{
            InitializeComponent();
			initializeQuestions(question);
			NavigationPage.SetBackButtonTitle(this, "Tillbaka");
			dropdownlist.IsVisible = false;
		}

		public QuestionPage(Question question, string previousAnswer)
		{

			InitializeComponent();
			initializeQuestions(question);
			NavigationPage.SetBackButtonTitle(this, "Tillbaka");




			BackButtonWasPressed = true;
			dropdownlist.IsVisible = true;

			for (int i = 1; i <= App.previousQuestions.Count; i++)
				dropdownlist.Items.Add("Fråga: " + i);

		

			//Check if it's the last question and if we came from a 'Yes' alternative
			if (yesQuestion == null && noQuestion == null && previousAnswer == Answer.Yes) 
			{
				yesButton.IsVisible = false;
				noButton.IsVisible = false;
				menuButton.IsVisible = true;
			}


			//Check if it's the last question and if we came from a 'No' alternative
			if (yesQuestion == null && noQuestion == null && previousAnswer == Answer.No) 
			{
				yesButton.IsVisible = false;
				noButton.IsVisible = false;
				menuButton.IsVisible = true;
				callButton.IsVisible = true;
			}


		}

		void YesButtonClicked(object sender, System.EventArgs e)
		{
			if (yesQuestion != null)
			{
				App.previousQuestions.Push(currentQuestion);
				Navigation.PushAsync(new QuestionPage(yesQuestion, Answer.Yes));
				BackButtonWasPressed = false;
			}
		}

		void NoButtonClicked(object sender, System.EventArgs e)
		{
			if (noQuestion != null)
			{
				App.previousQuestions.Push(currentQuestion);
				Navigation.PushAsync(new QuestionPage(noQuestion, Answer.No));
				BackButtonWasPressed = false;
			}
		}

		void CallSupportButtonClicked(object sender, System.EventArgs e)
		{
			var dialer = DependencyService.Get<IDialer>();
			if (dialer != null)
				dialer.DialAsync("0364422000");
					
		}

		void MenuButtonClicked(object sender, System.EventArgs e)
		{
			Navigation.PopToRootAsync();
			App.previousQuestions.Clear();
		}

		public void initializeQuestions(Question question)
		{
			currentQuestion = question;
			questionLabel.Text = question.questionText;
			ImageName.Source = question.questionImageName;
			yesQuestion = App.dataRepository.getQuestionByID(currentQuestion.questionYesID);
			noQuestion = App.dataRepository.getQuestionByID(currentQuestion.questionNoID);

		}

		protected override void OnDisappearing()
		{
			base.OnDisappearing();
			if (BackButtonWasPressed)
				App.previousQuestions.Pop();
						
			BackButtonWasPressed = true;
			//dropdownlist.SelectedIndex = -1;

		}




	}
}
