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


			List<string> problems = new List<string>() { "Jag ser inget", "Jag hör inget", "Jag vet inte" };
			problemList.ItemsSource = problems;
		}
	}
}
