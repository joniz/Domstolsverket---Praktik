using System;
using SQLite;
namespace Domstol
{
	//[Table("Problems")]
	public class Problem
	{
		//[PrimaryKey, AutoIncrement]
		public int ProblemID { get; set; }
	
		public int firstQuestionID { get; set; }

		//[NotNull]
		public string problemCategory { get; set; }

		//[NotNull]
		public Room room { get; set; }

		public string RoomID { get; set; }

		//[NotNull]
		public string problemDescription { get; set; }

	
	
	}
}
