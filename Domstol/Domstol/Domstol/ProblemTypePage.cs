using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Domstol
{
	public partial class ProblemTypePage : ContentPage
	{

		private NavigationItem nItem { get; set; }
	

		public ProblemTypePage(NavigationItem n)
		{
			InitializeComponent();

			nItem = n;
			Title = nItem.typeOfRoom.ToString();
			BackgroundPic.Source = nItem.imageName;

		}


		void ButtonClicked(object sender, System.EventArgs e)
		{
			Button button = sender as Button;



			if (button.Text == Category.Bild.ToString())
			{
				nItem.category = Category.Bild;
				Navigation.PushAsync(new ProblemPage(nItem));
			}
			if (button.Text == Category.Ljud.ToString())
			{
				nItem.category = Category.Ljud;
				Navigation.PushAsync(new ProblemPage(nItem));
			}
			
			
			
			}
		}
	}

