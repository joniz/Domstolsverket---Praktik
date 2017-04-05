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
			new Item{name = "Video", imagename = "videoPic2"},
			new Item{name = "Audio", imagename = "audioPic2"},
			new Item{name = "Misc"}
		
		};


		
	}

}