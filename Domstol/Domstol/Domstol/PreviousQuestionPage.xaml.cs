using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Domstol
{
	public partial class PreviousQuestionPage : ContentPage
	{
		
		void DoneButtonClicked(object sender, System.EventArgs e)
		{
			Navigation.PopModalAsync();
		}

		public PreviousQuestionPage()
		{
			InitializeComponent();
		}
		public PreviousQuestionPage(Question q)
		{
			InitializeComponent();
			QuestionLabel.Text = q.questionText;


		}
	}
}
