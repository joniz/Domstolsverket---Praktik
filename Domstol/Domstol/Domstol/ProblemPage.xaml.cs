using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using System.Linq;
namespace Domstol
{
	public partial class ProblemPage : ContentPage
	{

		public Room currentRoom;
	
		public ProblemPage() { InitializeComponent(); }

		public ProblemPage(Room r)
		{
			InitializeComponent();

			currentRoom = r;

			Title = r.Name;
			Roompic.Source = "LocationImages/" + r.ImageName;
			NavigationPage.SetBackButtonTitle(this, "Tillbaka");

			itemListView.ItemsSource = SetupList();


		}

		public List<ProblemList> SetupList()
		{
			var allListItemGroups = new List<ProblemList>();
			var typesOfProblemList = new List<string>();

			foreach (Problem p in App.dataRepository.problems)
				if (!typesOfProblemList.Contains(p.problemCategory))
					typesOfProblemList.Add(p.problemCategory);


			foreach (string problemtype in typesOfProblemList)
				allListItemGroups.Add(new ProblemList() { Category = problemtype });


			foreach (ProblemList p in allListItemGroups)
			{
				List<Problem> xd = App.dataRepository.getProblemsByCategoryAndRoom(p.Category, currentRoom.Name);
				p.AddRange(xd);
			}


			
			var temp = new List<ProblemList>();

			foreach (ProblemList p in allListItemGroups)
				if (p.Count != 0)
					temp.Add(p);

			return temp;


		}


		void problemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
		{


			Problem p = e.SelectedItem as Problem;

			if (p != null)
			{
				Question q = App.dataRepository.getQuestionByID(p.firstQuestionID);

				((ListView)sender).SelectedItem = null;

				if (q != null)
					Navigation.PushAsync(new QuestionPage(p,q));

			}
		}


	}
}

