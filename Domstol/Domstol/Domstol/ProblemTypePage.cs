using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Domstol
{
	public partial class ProblemTypePage : ContentPage
	{

		private string typeOfRoom { get; set; }
	

		public ProblemTypePage(string tOR)
		{
			InitializeComponent();

			typeOfRoom = tOR;
			Title = typeOfRoom;
		}


		void ButtonClicked(object sender, System.EventArgs e)
		{
			Button problemCategory = sender as Button;



			switch (problemCategory.Text) 
			{
				case "Bild":
					Navigation.PushAsync(new ProblemPage(problemCategory.Text, typeOfRoom));
					break;
				case "Ljud":
					Navigation.PushAsync(new ProblemPage(problemCategory.Text, typeOfRoom));
					break;
				
			
			
			
			}
		}
	}
}
