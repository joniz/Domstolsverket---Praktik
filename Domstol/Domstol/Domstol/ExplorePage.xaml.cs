using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Domstol
{
    public partial class ExplorePage : ContentPage
    {
        public ExplorePage()
        {
            InitializeComponent();
			itemlist.ItemsSource = ExploreListItem.items;
        }



        void OnItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
				var selected = e.SelectedItem as ExploreListItem;
                Navigation.PushAsync(new RemoteControllerSelectionPage());

            }
        }

    }
}
