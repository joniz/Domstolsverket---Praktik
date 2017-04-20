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
   





        }
		void ButtonClicked(object sender, System.EventArgs e)
		{
			Button button = sender as Button;


			if (button.Text == Room.Conferenceroom)
			{
				nItem.imageName = PictureNames.ConferenceRoom;
				nItem.typeOfRoom = Room.Conferenceroom;
			}

			if (button.Text == Room.Courtroom)
			{
				nItem.imageName = PictureNames.CourtRoom;
				nItem.typeOfRoom = Room.Courtroom;
			}
			if (button.Text == Room.Meetingroom) 
			{
				nItem.imageName = PictureNames.MeetingRoom;
				nItem.typeOfRoom = Room.Meetingroom;
			
			}

					
			Navigation.PushAsync(new ProblemTypePage(nItem));

			

		}
    }
}
