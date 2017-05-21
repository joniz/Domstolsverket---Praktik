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
		if (Device.RuntimePlatform == Device.iOS)
		{
				homenav.Title = "Hem";
				manualnav.Title = "Utforska";

		}

		if (Device.RuntimePlatform == Device.Android)
		{
				//Android related code 
		}
        }
    }
}
