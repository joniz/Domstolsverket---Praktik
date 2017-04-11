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
        }
		void ButtonClicked(object sender, System.EventArgs e)
		{
			Button typeOfRoom = sender as Button;
			nItem.typeOfRoom = typeOfRoom.Text;


			if (typeOfRoom.Text == "Sal")
				nItem.imageName = "Sal.jpg";

			if (typeOfRoom.Text == "Rum")
				nItem.imageName = "Samtalsrum.jpg";
					
			Navigation.PushAsync(new ProblemTypePage(nItem));

			

		}
    }
}
