using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Domstol
{
	public partial class MoreInfoPage : ContentPage
	{
		public MoreInfoPage() 
		{
			InitializeComponent();
		
		}
		public MoreInfoPage(Question q)
		{
			InitializeComponent();
			moreinfoLabel.Text = q.questionMoreInfo;
			infoImage.Source = q.questionMoreInfoImageName;
		}

		void DoneClicked(object sender, System.EventArgs e)
		{
			Navigation.PopModalAsync();
		}
	}
}
