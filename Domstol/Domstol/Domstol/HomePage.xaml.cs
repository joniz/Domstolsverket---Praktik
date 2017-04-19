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

		public NavigationItem nItem { get; set; }
        public HomePage()
        {
            InitializeComponent();
			nItem = new NavigationItem();
			NavigationPage.SetBackButtonTitle(this, "Tillbaka");






        }
		void ButtonClicked(object sender, System.EventArgs e)
		{
			Button button = sender as Button;


			if (button.Text == Room.Conferenceroom)
			{
				nItem.imageName = "Konferensrum.jpg";
				nItem.typeOfRoom = Room.Conferenceroom;
			}

			if (button.Text == Room.Courtroom)
			{
				nItem.imageName = "Sal.jpg";
				nItem.typeOfRoom = Room.Courtroom;
			}
			if (button.Text == Room.Meetingroom) 
			{
				nItem.imageName = "Samtalsrum.jpg";
				nItem.typeOfRoom = Room.Meetingroom;
			
			}

					
			Navigation.PushAsync(new ProblemTypePage(nItem));

			

		}
    }
}
