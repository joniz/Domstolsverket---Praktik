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

			currentQuestion = question;
			questionLabel.Text = question.questionText;
			yesQuestion = App.dataRepository.getQuestionByID(currentQuestion.questionYesID);
			noQuestion = App.dataRepository.getQuestionByID(currentQuestion.questionNoID);

			if (yesQuestion == null && noQuestion == null) 
			{
				yesButton.IsVisible = false;
				noButton.IsVisible = false;
				menuButton.IsVisible = true;
				callButton.IsVisible = true;
			}


		}

		void ButtonClicked(object sender, System.EventArgs e)
		{
			Button b = sender as Button;
			string choice = b.Text;


			switch (choice) 
			{
				case "Ja":
					if (yesQuestion != null)
						Navigation.PushAsync(new QuestionPage(yesQuestion));
					break;
				case "Nej":
					if (noQuestion != null)
						Navigation.PushAsync(new QuestionPage(noQuestion));
					break;
				case "Tillbaka till meny":
					Navigation.PopToRootAsync();
					break;
				case "Ring support":
					var dialer = DependencyService.Get<IDialer>();
					if (dialer != null) {
						dialer.DialAsync("0364422000");
					}
					break;
			
			}
		
			

		}
	}
}
