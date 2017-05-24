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
    
    [Activity(Label = "Domstol", Icon = "@drawable/iconapp", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation, ScreenOrientation = ScreenOrientation.Portrait)]
    [assembly: ExportRenderer(typeof(NavigationPage), typeof(MyApp.iOS.Renderers.CustomNavigationRenderer))]
    
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            global::Xamarin.Forms.DependencyService.Register<PhoneDialer>();
			string dbPath = FileAccessHelper.GetLocalFilePath("Domstol2.db");
	  		LoadApplication(new App(dbPath));

        }
    }
}

