using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Domstol
{
	public partial class ProblemSolvedPage : ContentPage
	{
		public ProblemSolvedPage()
		{
			InitializeComponent();
		}

		void BackToMenu(object sender, System.EventArgs e)
		{
			Navigation.PopToRootAsync();
		}

		void CallSupport(object sender, System.EventArgs e)
		{
			var dialer = DependencyService.Get<IDialer>();
			if (dialer != null)
				dialer.DialAsync("0364422000,3");
		}
	}
}
