using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Domstol
{
	public partial class PreviousQuestionPage : ContentPage
	{

		private Question currentQuestion { get; set; }
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
			currentQuestion = q;

			if (q.questionMoreInfo != null)
				MoreInfoButton.IsVisible = true;

		}

		void MoreInfoClicked(object sender, System.EventArgs e)
		{
			Navigation.PushModalAsync(new NavigationPage(new MoreInfoPage(currentQuestion)));
		}
	}
}
