using System;
using System.Collections.Generic;
using SQLite;
namespace Domstol
{
	public class DataRepository
	{
		public List<Problem> problems { get; set; }
		public List<Question> questions { get; set; }
		public List<RemoteController> remoteControllers { get; set; }
		public DataRepository(string dbPath)
		{
		
			problems = new List<Problem>();
			questions = new List<Question>();
			remoteControllers = new List<RemoteController>();


			SQLiteConnection db = new SQLiteConnection(dbPath);
			problems  = db.Query<Problem>("SELECT * FROM Problems");
			questions = db.Query<Question>("SELECT * FROM Questions");



			remoteControllers = db.Query<RemoteController>("SELECT * FROM RemoteControllers");
			List<RemoteControllerButton> AllButtons = db.Query<RemoteControllerButton>("SELECT * FROM RemoteControllerButtons");
			initializeRemoteControllerLists(AllButtons);



			db.Close();



		}


		public Question getQuestionByID(int id)
		{

			foreach (Question q in questions) 
				if (q.questionID == id)
					return q;

			return null;
			
		}

		public List<Problem> getProblemsByCategoryAndRoom(string category, string typeOfRoom) 
		{

			List<Problem> temps = new List<Problem>();
			foreach (Problem p in problems)
				if (p.problemCategory == category && p.problemTypeOfRoom == typeOfRoom)
					temps.Add(p);
				


			return temps;
		
		



		}

		public List<Problem> getProblemsByRoom(string typeOfRoom)
		{

			List<Problem> temps = new List<Problem>();
			foreach (Problem p in problems)
				if (p.problemTypeOfRoom == typeOfRoom)
					temps.Add(p);



			return temps;



		}



		private void initializeRemoteControllerLists(List<RemoteControllerButton> AllButtons) 
		{

			foreach (RemoteController rc in remoteControllers)
				rc.ControllerButtons = new List<RemoteControllerButton>();




			foreach (RemoteControllerButton rcb in AllButtons)
			{

				foreach (RemoteController rc in remoteControllers)
					if (rcb.ControllerID == rc.ID)
						rc.ControllerButtons.Add(rcb);
				
			
			}
		
		
		}

	}
}
