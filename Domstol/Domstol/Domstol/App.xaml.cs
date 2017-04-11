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


		public void addProblemOne()
		{

			QuestionRepository qr = new QuestionRepository(path);
			ProblemRepository pr = new ProblemRepository(path);
			pr.DeleteAllProblems();

			pr.AddNewProblem(new Problem
			{
				firstQuestionID = 1,
				problemCategory = "Video",
				problemDescription = "Kan inte koppla upp videokonferenssamtal",
				problemTypeOfRoom = "Sal"
			});

			qr.AddNewQuestion(new Question
			{
				questionText = "Låter det som att uppringningssignaler går fram?",
				questionNoID = 2,
				questionYesID = 3,

				
			});

			qr.AddNewQuestion(new Question 
			{
				questionText = "Kontrollera att du har fått rätt nummer.\u2028Om du ringer inomSveriges Domstolar ska det vara ett femsiffrigt nummer. Om du ringer utanför Sveriges Domstolar är det antingen ett IP-nummer eller ett ISDN - nummer.\u2028Ett IP-nummer innehåller tecken som punkter eller @. Till exempel: 194.45.16.16 \neller moss@domstol.no \nEtt ISDN-nummer ser ut som ett telefonnummer. Till exempel 036478390. OBS! Om det är ett ISDN-nummer måste du lägga till en 0:a för numret. Alltså 0036478390\u2028Går det att koppla upp videokonferenssamtalet?",

			});
			qr.AddNewQuestion(new Question 
			{
				questionText = "Kontakta personen som ska ta emot samtalet för att kontrollera att hen sitter i rummet och väntar. Går det att koppla upp videokonferenssamtalet?",

			
			});

		
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
