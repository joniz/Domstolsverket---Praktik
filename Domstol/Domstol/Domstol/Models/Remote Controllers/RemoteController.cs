using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Domstol
{
	public class RemoteController
	{
		public string Name { get; set; }
		public string ImageName { get; set; }
		public string ID { get; set; }
		public List<RemoteControllerButton> ControllerButtons { get; set; }
		public List<RemoteControllerTutorial> ControllerTutorials { get; set; }
	}
}
