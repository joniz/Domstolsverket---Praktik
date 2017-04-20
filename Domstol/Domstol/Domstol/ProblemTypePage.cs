using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Domstol
{
	public partial class ProblemTypePage : ContentPage
	{

		private MyNavigationItem nItem { get; set; }

		public ProblemTypePage() { InitializeComponent();}

		public ProblemTypePage(MyNavigationItem n)
		{
			InitializeComponent();

			nItem = n;
			Title = nItem.typeOfRoom.ToString();
			Roompic.Source = nItem.imageName;

		}


		void ButtonClicked(object sender, System.EventArgs e)
		{
			Button button = sender as Button;



			if (button.Text == Category.Video)
			{
				nItem.category = Category.Video;
				Navigation.PushAsync(new ProblemPage(nItem));
			}
			if (button.Text == Category.Audio)
			{
				nItem.category = Category.Audio;
				Navigation.PushAsync(new ProblemPage(nItem));
			}
			
			
			
			}
		}
	}

