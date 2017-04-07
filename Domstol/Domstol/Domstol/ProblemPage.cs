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

			List<Problem> temp = Problem.problemList;
			List<Problem> problems = new List<Problem>();

			foreach (Problem p in temp)
			{
				if (p.problemCategory == problemCategory && p.typeOfRoom == typeOfRoom)
					problems.Add(p);
			
			
			}


			problemList.ItemsSource = problems;
		}
	}
}
