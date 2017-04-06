using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
namespace Domstol
{
	public class Item
	{
		public Item()
		{
		}
		public string name { get; set; }
		public string imagename { get; set; }


		public static List<Item> items = new List<Item>() 
		{
			new Item{name = "Bild", imagename = "videoPic2"},
			new Item{name = "Ljud", imagename = "audioPic2"},
			new Item{name = "Annat"}
		
		};


		
	}

}