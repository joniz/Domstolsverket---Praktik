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
			NavigationPage.SetBackButtonTitle(this, "Tillbaka");


			Startbild.Source = PictureNames.Home;

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
			foreach (Room r in App.dataRepository.rooms)
			{
				rooms.Add(r.Name);
			
			}
			return rooms;
		
		}
		void roomSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
		{

	
			string listText = e.SelectedItem as string;
		


			if (listText != null)
			{

				Room room = new Room();
				foreach (Room r in App.dataRepository.rooms)
					if (listText == r.Name)
					{
						room = r;
						break;
					}
					
					

				((ListView)sender).SelectedItem = null;
			

				Navigation.PushAsync(new ProblemPage(room));



			}

		}

    }
}
