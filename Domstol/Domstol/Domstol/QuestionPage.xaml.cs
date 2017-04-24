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
				Navigation.PushAsync(new QuestionPage(yesQuestion, Answer.Yes));

	

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
		}
		void NoButtonClicked(object sender, System.EventArgs e)
		{ 
			if (noQuestion != null)
				Navigation.PushAsync(new QuestionPage(noQuestion, Answer.No));	
		}

		public void initializeQuestion(Question question)
		{
			currentQuestion = question;
			questionLabel.Text = question.questionText;
			yesQuestion = App.dataRepository.getQuestionByID(currentQuestion.questionYesID);
			noQuestion = App.dataRepository.getQuestionByID(currentQuestion.questionNoID);
		
		}
	}
}
