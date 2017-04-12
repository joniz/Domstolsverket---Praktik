using System;
using System.Collections.Generic;
using Domstol;
using Xamarin.Forms;

namespace Domstol
{
	public partial class QuestionPage : ContentPage
	{

		private Question _question { get; set; }
		public QuestionPage() 
		{
            InitializeComponent();
		}
		public QuestionPage(Question question)
		{


			InitializeComponent();
			_question = question;

			questionLabel.Text = question.questionText;


		}

		void ButtonClicked(object sender, System.EventArgs e)
		{
			Button b = sender as Button;
			string choice = b.Text;


			if (choice == "Yes")
			{
				Question nextQuestion = App.dataRepository.getQuestionByID(_question.questionYesID);

				if (nextQuestion != null)
					Navigation.PushAsync(new QuestionPage(nextQuestion));
				
			}
			else 
			{
			
				Question nextQuestion = App.dataRepository.getQuestionByID(_question.questionNoID);

				if (nextQuestion != null)
					Navigation.PushAsync(new QuestionPage(nextQuestion));
				
			
			}
		}
	}
}
