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



		public QuestionPage() 
		{
            InitializeComponent();
		}
		public QuestionPage(Question question)
		{
            InitializeComponent();
			initializeQuestion(question);
		}

		public QuestionPage(Question question, string previousAnswer)
		{

			InitializeComponent();
			initializeQuestion(question);

			BackButtonWasPressed = true;

			for (int i = 1; i <= App.previousQuestions.Count; i++)
			{
				Button b = new Button();
				b.Style = (Style)Application.Current.Resources ["PreviousQuestionsButtonStyle"];
				b.Text = i.ToString();
				b.Clicked += PreviousQuestionClicked;
				Questions.Children.Add(b);
			}

		

			//Check if it's the last question and we came from a 'Yes' alternative
			if (yesQuestion == null && noQuestion == null && previousAnswer == Answer.Yes) 
			{
				yesButton.IsVisible = false;
				noButton.IsVisible = false;
				menuButton.IsVisible = true;
			}


			//Check if it's the last question, and that we came from a 'No' alternative
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
		void NoButtonClicked(object sender, System.EventArgs e)
		{
			if (noQuestion != null)
			{
				App.previousQuestions.Push(currentQuestion);
				Navigation.PushAsync(new QuestionPage(noQuestion, Answer.No));
				BackButtonWasPressed = false;
			}
		}

		public void initializeQuestion(Question question)
		{
			currentQuestion = question;
			questionLabel.Text = question.questionText;
			yesQuestion = App.dataRepository.getQuestionByID(currentQuestion.questionYesID);
			noQuestion = App.dataRepository.getQuestionByID(currentQuestion.questionNoID);
		
		}


		private void PreviousQuestionClicked(object sender, EventArgs e)
		{
			int index = Int32.Parse((sender as Button).Text);
			Navigation.PushAsync(new PreviousQuestionPage(App.previousQuestions[index-1]));
			BackButtonWasPressed = false;
		}
		protected override void OnDisappearing()
		{
			base.OnDisappearing();
			if (BackButtonWasPressed)
				App.previousQuestions.Pop();
			
			
			BackButtonWasPressed = true;
		}




	}
}
