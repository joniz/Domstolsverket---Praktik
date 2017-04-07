using System;
using System.Collections.Generic;

namespace Domstol
{
	public class Problem
	{
		public int startQuestionId { get; set; }
		public string problemDescription { get; set; }
		public string problemCategory { get; set; }
		public string typeOfRoom { get; set; }
		public Problem()
		{

		}

		public static List<Problem> problemList = new List<Problem>()
		{
			new Problem(){startQuestionId = 1, typeOfRoom = "Rum", problemCategory = "Bild", 
				problemDescription = "Jag ser ingenting"
			},
			new Problem(){startQuestionId = 2, typeOfRoom = "Rum", problemCategory = "Bild", 
				problemDescription = "Det flimmrar"
			},
			new Problem(){startQuestionId = 3, typeOfRoom = "Rum", problemCategory = "Ljud", 
				problemDescription = "Jag hör ingenting"
			},
			new Problem(){startQuestionId = 3, typeOfRoom = "Rum", problemCategory = "Ljud", 
				problemDescription = "Ljudet är för högt"
			}







		};
	}
}
