using System;
using System.Collections.ObjectModel;
namespace DomstolsappFORM
{
	public class Item
	{
		public Item()
		{
		}
		public string name { get; set; }
		public string imagename { get; set; }


		public static ObservableCollection<Item> items = new ObservableCollection<Item>() 
		{
			new Item{name = "Bild", imagename = "videoPic2"},
			new Item{name = "Ljud", imagename = "audioPic2"},
			new Item{name = "Annat"}
		
		};


		
	}

}