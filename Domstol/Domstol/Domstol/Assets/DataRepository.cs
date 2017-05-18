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
		public List<Room> rooms { get; set; }
		public DataRepository(string dbPath)
		{


			SQLiteConnection db = new SQLiteConnection(dbPath);
			problems  = db.Query<Problem>("SELECT * FROM Problems");
			questions = db.Query<Question>("SELECT * FROM Questions");
			rooms = db.Query<Room>("SELECT * FROM Room");


			initializeProblemList();


			remoteControllers = db.Query<RemoteController>("SELECT * FROM RemoteControllers");
			List<RemoteControllerButton> AllButtons = db.Query<RemoteControllerButton>("SELECT * FROM RemoteControllerButtons");
			List<RemoteControllerTutorial> AllTutorials = db.Query<RemoteControllerTutorial>("SELECT * FROM RemoteControllerTutorials");
			initializeRemoteControllerLists(AllButtons, AllTutorials);





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
			string roomID = "";
			foreach (Room r in rooms)
				if (r.Name == typeOfRoom)
					roomID = r.ID;


			foreach (Problem p in problems)
				if (p.problemCategory == category && p.RoomID == roomID)
					temps.Add(p);
				


			return temps;
		
		



		}

		public List<Problem> getProblemsByRoom(string typeOfRoom)
		{

			List<Problem> temps = new List<Problem>();
			foreach (Problem p in problems)
				if (p.RoomID == typeOfRoom)
					temps.Add(p);



			return temps;



		}



		private void initializeRemoteControllerLists(List<RemoteControllerButton> AllButtons,
		                                             List<RemoteControllerTutorial> AllTutorials) 
		{

			foreach (RemoteController rc in remoteControllers)
			{
				rc.ControllerButtons = new List<RemoteControllerButton>();
				rc.ControllerTutorials = new List<RemoteControllerTutorial>();
			}



			foreach (RemoteControllerTutorial rct in AllTutorials)
			{
				foreach (RemoteController rc in remoteControllers)
					if (rct.ControllerID == rc.ID)
						rc.ControllerTutorials.Add(rct);
			
			}


			foreach (RemoteControllerButton rcb in AllButtons)
			{

				foreach (RemoteController rc in remoteControllers)
					if (rcb.ControllerID == rc.ID)
						rc.ControllerButtons.Add(rcb);
			
			}
		
		
		}


		public void initializeProblemList()
		{
			foreach (Problem p in problems)
				foreach (Room r in rooms) 
					if (p.RoomID == r.ID)
						p.room = r;
				
				
		
		}




	}
}
