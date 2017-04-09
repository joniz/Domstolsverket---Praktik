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
        public HomePage()
        {
            InitializeComponent();
        }
		void ButtonClicked(object sender, System.EventArgs e)
		{
			Button typeOfRoom = sender as Button;
			string backgroundPic = "";

			if (typeOfRoom.Text == "Sal")
				backgroundPic = "Sal.jpg";

			if (typeOfRoom.Text == "Rum")
				backgroundPic = "Samtalsrum.jpg";
					
			Navigation.PushAsync(new ProblemTypePage(typeOfRoom.Text, backgroundPic));

			

		}
    }
}
