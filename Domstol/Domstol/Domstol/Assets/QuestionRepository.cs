using System;
using System.Collections.Generic;
using System.Linq;
using SQLite;
namespace Domstol
{
	public class QuestionRepository
	{
		public string StatusMessage { get; set; }
		private SQLiteConnection conn;

		public QuestionRepository(string dbPath)
		{

			conn = new SQLiteConnection(dbPath);
			conn.CreateTable<Question>();

		}

		public void AddNewQuestion(Question question)
		{
			int result = 0;
			try
			{
				//basic validation to ensure a name was entered
				//if (string.IsNullOrEmpty(name))
				//throw new Exception("Valid name required");

				// TODO: insert a new person into the Person table
				result = conn.Insert(question);



				//StatusMessage = string.Format("{0} record(s) added [Name: {1})", result, name);
			}
			catch (Exception ex)
			{
				//StatusMessage = string.Format("Failed to add {0}. Error: {1}", name, ex.Message);
			}

		}

		public List<Question> GetAllQuestions()
		{
			// TODO: return a list of people saved to the Person table in the database
			return conn.Table<Question>().ToList();

		}
		public void DeleteAllProblems()
		{

			conn.DropTable<Question>();
		}
	}
}
