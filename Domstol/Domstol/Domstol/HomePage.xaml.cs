using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Domstol
{
    public partial class HomePage : ContentPage
    {

		public MyNavigationItem nItem { get; set; }
        public HomePage()
        {
            InitializeComponent();
			nItem = new MyNavigationItem();
			NavigationPage.SetBackButtonTitle(this, "Tillbaka");


			Startbild.Source = "Start.jpg";

			Lista.ItemsSource = getRooms();




        }

		protected override void OnDisappearing()
		{
		
			base.OnDisappearing();

			Lista.ItemsSource = getRooms();
		}

		public List<string> getRooms() 
		{
			List<string> rooms = new List<string>();
			rooms.Add(LanguageStrings.Conferenceroom);
			rooms.Add(LanguageStrings.Courtroom);
			rooms.Add(LanguageStrings.Meetingroom);
			return rooms;
		
		}
		void roomSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
		{

	
			string listText = e.SelectedItem as string;
		


			if (listText != null)
			{

				if (listText == LanguageStrings.Conferenceroom)
				{
					nItem.imageName = PictureNames.ConferenceRoom;
					nItem.typeOfRoom = LanguageStrings.Conferenceroom;
				}

				if (listText == LanguageStrings.Courtroom)
				{
					nItem.imageName = PictureNames.CourtRoom;
					nItem.typeOfRoom = LanguageStrings.Courtroom;
				}
				if (listText == LanguageStrings.Meetingroom) 
				{
					nItem.imageName = PictureNames.MeetingRoom;
					nItem.typeOfRoom = LanguageStrings.Meetingroom;
			
				}

				((ListView)sender).SelectedItem = null;
			

				Navigation.PushAsync(new ProblemPage(nItem));



			}

		}

    }
}
