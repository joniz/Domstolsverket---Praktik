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


			problemList.ItemsSource = App.probs;
		}
	}
}
