using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using System.Linq;
namespace Domstol
{
	public class ProblemList : List<Problem>
	{
		public string Category { get; set; }
	}
}
