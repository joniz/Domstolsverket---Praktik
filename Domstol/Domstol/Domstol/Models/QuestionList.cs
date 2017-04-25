using System;
using System.Collections.Generic;

namespace Domstol
{
	public class QuestionList<Question> : List<Question>
	{
		public void Push(Question q)
		{
			Add(q);
		
		}
		public void Pop() 
		{
			if(Count > 0)
				RemoveAt(Count - 1);
		
		}
	}
}
