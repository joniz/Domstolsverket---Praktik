using System;
using SQLite;
namespace Domstol
{
	[Table("Questions")]
	public class Question
	{

		public int questionID { get; set; }

		public int questionNoID { get; set; }
		public int questionYesID { get; set; }

		public string questionText { get; set; }

		public string questionImageName { get; set; }

		public string questionMoreInfo { get; set; }
	}
}
