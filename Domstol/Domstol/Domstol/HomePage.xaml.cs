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


			Rectangle shape = new Rectangle();




			List<string> rooms = new List<string>();
			rooms.Add(Room.Conferenceroom);
			rooms.Add(Room.Courtroom);
			rooms.Add(Room.Meetingroom);
			Lista.ItemsSource = rooms;

			if(App.previousQuestions != null)
				App.previousQuestions.Clear();



        }

		void roomSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
		{

	
			string listText = e.SelectedItem as string;
		


			if (listText != null)
			{

				if (listText == Room.Conferenceroom)
				{
					nItem.imageName = PictureNames.ConferenceRoom;
					nItem.typeOfRoom = Room.Conferenceroom;
				}

				if (listText == Room.Courtroom)
				{
					nItem.imageName = PictureNames.CourtRoom;
					nItem.typeOfRoom = Room.Courtroom;
				}
				if (listText == Room.Meetingroom) 
				{
					nItem.imageName = PictureNames.MeetingRoom;
					nItem.typeOfRoom = Room.Meetingroom;
			
				}

				((ListView)sender).SelectedItem = null;

				Navigation.PushAsync(new ProblemTypePage(nItem));



			}

		}

    }
}
