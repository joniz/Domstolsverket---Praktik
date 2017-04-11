using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLite;
using Xamarin.Forms;

namespace Domstol
{
	public partial class App : Application
	{
		public static string path{get;set;}
		public static List<Problem> probs { get; set; }
		public static List<Question> quests { get; set; }



		public App() 
		{
        InitializeComponent();
		MainPage = new RootPage();
		
		}
        public App(string dbPath)
        {
			InitializeComponent();
            MainPage = new RootPage();
			path = "Domstol2.db";


			probs = new List<Problem>();
			quests = new List<Question>();


			SQLiteConnection db = new SQLiteConnection(path);
			probs  = db.Query<Problem>("SELECT * FROM Problems");
			quests = db.Query<Question>("SELECT * FROM Questions");




        }


        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
