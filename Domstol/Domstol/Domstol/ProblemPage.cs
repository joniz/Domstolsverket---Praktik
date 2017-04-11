using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Domstol
{
	public partial class ProblemPage : ContentPage
	{public ProblemPage() { InitializeComponent(); }


		public ProblemPage(string problemCategory, string typeOfRoom)
		{
			InitializeComponent();
			Title = typeOfRoom + " -> " + problemCategory;

			ProblemRepository pr = new ProblemRepository(App.path);

			problemList.ItemsSource = App.probs;
		}
	}
}
