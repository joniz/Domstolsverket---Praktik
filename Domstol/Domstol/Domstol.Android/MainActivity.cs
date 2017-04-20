using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Domstol.Android;

namespace Domstol.Droid
{
    
    [Activity(Label = "Domstol", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            global::Xamarin.Forms.DependencyService.Register<PhoneDialer>();
			string dbPath = FileAccessHelper.GetLocalFilePath("Domstol.db3");
	  		LoadApplication(new App(dbPath));

        }
    }
}

