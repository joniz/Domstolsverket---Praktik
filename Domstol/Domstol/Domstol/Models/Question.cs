using System;
using SQLite;
namespace Domstol
{
	[Table("Questions")]
	public class Question
	{
		[PrimaryKey, AutoIncrement]
		public int questionID { get; set; }

		public int questionNoID { get; set; }
		public int questionYesID { get; set; }

		[NotNull]
		public string questionText { get; set; }

		public string imageFileName { get; set; }
		
	}
}
