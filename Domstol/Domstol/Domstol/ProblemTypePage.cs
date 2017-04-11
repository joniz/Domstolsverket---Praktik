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
			Title = nItem.typeOfRoom;
			BackgroundPic.Source = nItem.imageName;
		}


		void ButtonClicked(object sender, System.EventArgs e)
		{
			Button problemCategory = sender as Button;



			switch (problemCategory.Text) 
			{
				case "Bild":
					nItem.category = "Bild";
					Navigation.PushAsync(new ProblemPage(nItem));
					break;
				case "Ljud":
					nItem.category = "Ljud";
					Navigation.PushAsync(new ProblemPage(nItem));
					break;
				
			
			
			
			}
		}
	}
}
