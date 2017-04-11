using System;
using System.Collections.Generic;
using System.Linq;
using Domstol;
using SQLite;

namespace Domstol
{
	public class ProblemRepository
	{
		public string StatusMessage { get; set; }
		private SQLiteConnection conn;

		public ProblemRepository(string dbPath)
		{
			
			conn = new SQLiteConnection(dbPath);
			//conn.CreateTable<Problem>();

		}

		public void AddNewProblem(Problem problem)
		{
			int result = 0;
			try
			{
				//basic validation to ensure a name was entered
				//if (string.IsNullOrEmpty(name))
					//throw new Exception("Valid name required");





				// TODO: insert a new person into the Person table
				result = conn.Insert(problem);



				//StatusMessage = string.Format("{0} record(s) added [Name: {1})", result, name);
			}
			catch (Exception ex)
			{
				//StatusMessage = string.Format("Failed to add {0}. Error: {1}", name, ex.Message);
			}

		}

		public List<Problem> GetAllProblems()
		{


			// TODO: return a list of people saved to the Person table in the database
			return conn.Table<Problem>().ToList();
		}
	}
}