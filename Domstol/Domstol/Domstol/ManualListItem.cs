using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
namespace Domstol
{
	public class ManualListItem
	{
		public ManualListItem()
		{
		}
		public string name { get; set; }
		public string imagename { get; set; }


		public static List<ManualListItem> items = new List<ManualListItem>() 
		{
			new ManualListItem{name = "Bild", imagename = "videoMedium"},
			new ManualListItem{name = "Ljud", imagename = "audioMedium"},
			new ManualListItem{name = "Annat"}
		
		};


		
	}

}