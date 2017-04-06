using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Domstol
{
    public partial class ManualPage : ContentPage
    {
        public ManualPage()
        {
            InitializeComponent();
			itemlist.ItemsSource = ManualListItem.items;
        }



        void OnItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
				var selected = e.SelectedItem as ManualListItem;
                Navigation.PushAsync(new InformationPage(selected));

            }
        }

    }
}
