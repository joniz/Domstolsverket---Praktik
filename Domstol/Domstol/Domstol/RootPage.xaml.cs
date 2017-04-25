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
				homenav.Title = "Hem";
				manualnav.Title = "Utforska";

		}

		if (Device.RuntimePlatform == TargetPlatform.Android.ToString())
		{
				//Android related code 
		}
        }
    }
}
