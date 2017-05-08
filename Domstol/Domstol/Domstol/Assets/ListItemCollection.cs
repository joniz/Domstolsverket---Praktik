using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabelledSections
{
    // Represents a group of items in our list.
    public class ListItemCollection : ObservableCollection<string>
    {
        public string Title { get; private set; }

		public string LongTitle { get { return "The letter " + Title; } }

		public ListItemCollection(string title)
        {
            Title = title;
        }

        public static List<string> GetSortedData()
        {
            var items = ListItems;
            items.Sort();
            return items;
        }

        // Data used to populate our list.
        static readonly List<string> ListItems = new List<string>() {
			"bajs",
			"hej",
		};
    }
}
