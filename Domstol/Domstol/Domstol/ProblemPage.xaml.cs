using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using System.Linq;
namespace Domstol
{
	public partial class ProblemPage : ContentPage
	{

		private MyNavigationItem nItem { get; set; }

		public ProblemPage() { InitializeComponent(); }

		public ProblemPage(MyNavigationItem n)
		{
			InitializeComponent();

			nItem = n;
			Title = nItem.typeOfRoom.ToString();
			Roompic.Source = nItem.imageName;
			NavigationPage.SetBackButtonTitle(this, "Tillbaka");

			itemListView.ItemsSource = SetupList();


		}

		public List<ProblemList> SetupList()
		{
			var allListItemGroups = new List<ProblemList>();

			var audioProblemList = new ProblemList();
			var videoProblemList = new ProblemList();
			var videoconferenceProblemList = new ProblemList();

			audioProblemList.Category = LanguageStrings.Audio;
			videoProblemList.Category = LanguageStrings.Video;
			videoconferenceProblemList.Category = LanguageStrings.VideoConference;

			audioProblemList.AddRange(App.dataRepository.getProblemsByCategoryAndRoom(LanguageStrings.Audio, nItem.typeOfRoom));
			videoProblemList.AddRange(App.dataRepository.getProblemsByCategoryAndRoom(LanguageStrings.Video, nItem.typeOfRoom));
			videoconferenceProblemList.AddRange(App.dataRepository.getProblemsByCategoryAndRoom(LanguageStrings.VideoConference, nItem.typeOfRoom));

			allListItemGroups.Add(audioProblemList);
			allListItemGroups.Add(videoProblemList);
			allListItemGroups.Add(videoconferenceProblemList);
			return allListItemGroups;


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

