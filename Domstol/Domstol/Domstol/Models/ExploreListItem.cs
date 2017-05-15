using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
namespace Domstol
{
	public class ExploreListItem
	{

		public string name { get; set; }
		public string imagename { get; set; }


		public static List<ExploreListItem> items = new List<ExploreListItem>() 
		{
			new ExploreListItem{name = "Fjärrkontroller"}
		
		};


		
	}

}