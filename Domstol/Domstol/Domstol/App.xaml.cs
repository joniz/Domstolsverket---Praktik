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
		public static DataRepository dataRepository { get; set; }
		public static QuestionList<Question> AllQuestions { get; set; }

		public App() 
		{
        InitializeComponent();
		MainPage = new RootPage();
		
		}
		public App(string dbPath)
		{
			dataRepository = new DataRepository(dbPath);

			InitializeComponent();
			MainPage = new RootPage();

			AllQuestions = new QuestionList<Question>();



			if (Current.Resources == null)
			 {
    			Current.Resources = new ResourceDictionary();

 			 }


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
