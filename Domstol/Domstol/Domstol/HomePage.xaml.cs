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
			Button button = sender as Button;

			if (button.Text == Room.Konferensrum.ToString())
			{
				nItem.imageName = "Konferensrum.jpg";
				nItem.typeOfRoom = Room.Konferensrum;
			}

			if (button.Text == Room.Sal.ToString())
			{
				nItem.imageName = "Sal.jpg";
				nItem.typeOfRoom = Room.Sal;
			}
			if (button.Text == Room.Samtalsrum.ToString()) 
			{
				nItem.imageName = "Samtalsrum.jpg";
				nItem.typeOfRoom = Room.Samtalsrum;
			
			}

					
			Navigation.PushAsync(new ProblemTypePage(nItem));

			

		}
    }
}
