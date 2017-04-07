using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Domstol
{
    public partial class RootPage : TabbedPage
    {
        public RootPage()
        {
		InitializeComponent();
		if (Device.RuntimePlatform == TargetPlatform.iOS.ToString())
		{
			homenav.BackgroundColor = Color.Beige;
			manualnav.BackgroundColor = Color.Beige;

		}

		if (Device.RuntimePlatform == TargetPlatform.Android.ToString())
		{
				//Android related code 
		}
        }
    }
}
